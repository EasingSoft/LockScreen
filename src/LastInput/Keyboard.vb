Imports System
Imports System.Runtime.InteropServices.Marshal

Namespace WinHook
    Public Class Keyboard
        Inherits WinHook

        Public Sub New()
            MyBase.New(WHid.WH_KEYBOARD_LL, GetHINSTANCE(), 0)
        End Sub

        Public Event KeyPress As KeyboardEvent

        Friend Overrides Function Callback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
            Dim data = CType(PtrToStructure(lParam, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
            Dim ea = New KeyboardArgs(data)
            RaiseEvent KeyPress(CType(wParam, Device), ea)
            Return MyBase.Callback(nCode, wParam, lParam)
        End Function
    End Class
End Namespace
