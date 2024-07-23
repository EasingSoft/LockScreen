Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace WinHook
    Delegate Function HOOKPROC(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Public Delegate Sub HookCallbackEventHandler(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr)

    Public Class WinHook
        Implements IDisposable

        <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As HOOKPROC, ByVal hmod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
        End Function
        <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As Boolean
        End Function
        <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        End Function
        <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
        Private Shared Function GetModuleHandle(<MarshalAs(UnmanagedType.LPWStr), [In]> ByVal lpModuleName As String) As IntPtr
        End Function

        Friend Shared Function GetHInstance() As IntPtr
            Using currentProc = Process.GetCurrentProcess()

                Using currentModule = currentProc.MainModule
                    Return GetModuleHandle(currentModule.ModuleName)
                End Using
            End Using
        End Function

        Private hhk As IntPtr
        Public Property CallNextHook As Boolean = True
        Friend CallbackMethod As HOOKPROC

        Public Sub New(ByVal idHook As WHid, ByVal Optional hmod As IntPtr? = Nothing, ByVal Optional dwThreadId As UInteger = 0)
            Me.New(CInt(idHook), hmod, dwThreadId)
        End Sub

        Public Sub New(ByVal idHook As Integer, ByVal Optional hmod As IntPtr? = Nothing, ByVal Optional dwThreadId As UInteger = 0)
            CallbackMethod = AddressOf Callback
            hhk = SetWindowsHookEx(idHook, CallbackMethod, If(hmod, IntPtr.Zero), dwThreadId)
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            UnhookWindowsHookEx(hhk)
        End Sub

        Public Event HookCallback As HookCallbackEventHandler

        Friend Overridable Function Callback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
            RaiseEvent HookCallback(nCode, wParam, lParam)

            If CallNextHook Then
                Return CallNextHookEx(hhk, nCode, wParam, lParam)
            Else
                Return CType(1, IntPtr)
            End If
        End Function
    End Class
End Namespace
