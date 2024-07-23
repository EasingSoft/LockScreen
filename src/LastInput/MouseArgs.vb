Imports System
Imports System.Windows
Imports System.Windows.Forms

Namespace WinHook
    Public Delegate Sub MouseEvent(ByVal wParam As Device, ByVal e As MouseArgs)
    Public Delegate Sub WM_MOUSE_EventHandler(ByVal e As MouseArgs)

    <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)>
    Friend Structure MSLLHOOKSTRUCT
        Public pt As POINT
        Public mouseData As UInteger
        Public flags As UInteger
        Public time As UInteger
        Public dwExtraInfo As UIntPtr
    End Structure

    <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)>
    Friend Structure POINT
        Public x As Integer
        Public y As Integer
    End Structure

    Public Class MouseArgs
        Inherits EventArgs

        Friend Sub New(ByVal data As MSLLHOOKSTRUCT)
            Point = New System.Windows.POINT(data.pt.x, data.pt.y)
            MouseData = data.mouseData
            Flags = data.flags
            Time = data.time
            ExtraInfo = data.dwExtraInfo
        End Sub

        Public Property Point As System.Windows.POINT
        Public Property MouseData As UInteger
        Public Property Flags As UInteger
        Public Property Time As UInteger
        Public Property ExtraInfo As UIntPtr
    End Class
End Namespace
