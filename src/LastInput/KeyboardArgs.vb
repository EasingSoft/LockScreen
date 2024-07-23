Imports System
Imports System.Windows.Forms

Namespace WinHook
    Public Delegate Sub KeyboardEvent(ByVal wParam As Device, ByVal e As KeyboardArgs)
    Public Delegate Sub WM_KEY_EventHandler(ByVal e As KeyboardArgs)

    <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)>
    Friend Structure KBDLLHOOKSTRUCT
        Public vkCode As UInteger
        Public scanCode As UInteger
        Public flags As UInteger
        Public time As UInteger
        Public dwExtraInfo As UIntPtr
    End Structure

    Public Class KeyboardArgs
        Inherits EventArgs

        Friend Sub New(ByVal data As KBDLLHOOKSTRUCT)
            Key = CType(data.vkCode, Keys)
            ScanCode = data.scanCode
            Flags = data.flags
            Time = data.time
            ExtraInfo = data.dwExtraInfo
        End Sub

        Public Property Key As Keys
        Public Property ScanCode As UInteger
        Public Property Flags As UInteger
        Public Property Time As UInteger
        Public Property ExtraInfo As UIntPtr
    End Class
End Namespace
