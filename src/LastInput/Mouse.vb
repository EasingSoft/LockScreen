Imports System
Imports System.Runtime.InteropServices.Marshal

Namespace WinHook
    Public Class Mouse
        Inherits WinHook

        Public Sub New()
            MyBase.New(WHid.WH_MOUSE_LL, GetHINSTANCE(), 0)
        End Sub

        Public Event MousePress As MouseEvent

        Friend Overrides Function Callback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
            Dim data = CType(PtrToStructure(lParam, GetType(MSLLHOOKSTRUCT)), MSLLHOOKSTRUCT)
            Dim ea = New MouseArgs(data)
            RaiseEvent MousePress(CType(wParam, Device), ea)
            Return MyBase.Callback(nCode, wParam, lParam)
        End Function
    End Class
End Namespace
