Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WinHook
    Public Class Input
        Implements IDisposable
        Public LastInput As DateTime
        Private Keybord As Keyboard
        Private Mice As Mouse
        Sub Open()
            Keybord = New Keyboard()
            AddHandler Keybord.KeyPress, AddressOf KeyPress
            Mice = New Mouse()
            AddHandler Mice.MousePress, AddressOf MousePress
            LastInput = DateTime.Now
        End Sub


        Private Sub MousePress(ByVal wParam As Device, ByVal e As MouseArgs)
            LastInput = DateTime.Now
        End Sub

        Private Sub KeyPress(ByVal wParam As Device, ByVal e As KeyboardArgs)
            LastInput = DateTime.Now
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            RemoveHandler Mice.MousePress, AddressOf MousePress
            RemoveHandler Keybord.KeyPress, AddressOf KeyPress
            Mice.Dispose()
            Keybord.Dispose()
        End Sub
    End Class
End Namespace
