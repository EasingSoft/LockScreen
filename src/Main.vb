Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports Microsoft.Win32
Public Class Main
    Public Activity As WinHook.Input = New WinHook.Input()
    Private notifyIcon As NotifyIcon = New NotifyIcon()
    Public Sub AddToStartup()
        Try
            Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            If regKey IsNot Nothing Then
                regKey.SetValue(Application.ProductName, Application.ExecutablePath)
                regKey.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub IsAnyRunning(Apps As String)
        For Each exe In Apps.Replace(vbCr, String.Empty).Split(vbLf)
            If Not String.IsNullOrEmpty(exe) AndAlso exe.Contains(".") Then
                If Process.GetProcessesByName(Path.GetFileNameWithoutExtension(exe)).Length > 0 Then
                    Activity.LastInput = DateTime.Now
                    Return
                End If
            End If
        Next
    End Sub

    Async Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        IsAnyRunning(Exceptions.Text)
        Dim Sec As Integer = (Activity.LastInput.AddSeconds(Interval.Value) - DateTime.Now).TotalSeconds
        If Sec <= 0 Then
            Await StartAd(Interval.Value)
        Else
            Status.Text = $"{Sec} sec left"
        End If
    End Sub
    Async Function StartAd(Sec As Integer) As Task
        Timer.Stop()
        Player.URL = Video.Text
        Using Lok As New LokScreen
            Lok.Player.settings.setMode("loop", True)
            Lok.Player.URL = Video.Text
            Dim LastActivity = DateTime.Now
            Activity.LastInput = LastActivity.AddSeconds(-1)
            Await Task.Run(
Sub()
    While LastActivity > Activity.LastInput
        Thread.Sleep(10)
    End While
End Sub)
        End Using
        Timer.Start()
    End Function



    Private Sub BrowseVideo_Click(sender As Object, e As EventArgs) Handles BrowseVideo.Click
        Using diag As New OpenFileDialog
            diag.Multiselect = False
            diag.Filter = "Videos|*.mp4"
            If diag.ShowDialog = DialogResult.OK Then
                Video.Text = diag.FileName
                Player.settings.mute = True
                Player.settings.setMode("loop", True)
                Player.URL = Video.Text
            End If
        End Using
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        If Not File.Exists(Video.Text) Then
            MessageBox.Show("Please choose a valid video file")
            Return
        End If
        Player.settings.mute = True
        Player.settings.setMode("loop", True)
        Player.URL = Video.Text
        Activity.Open()
        Timer.Start()
        StartBtn.Visible = False
        My.Settings.isRunning = True
        My.Settings.Save()
    End Sub

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        Timer.Stop()
        StartBtn.Visible = True
        Activity.Dispose()
        My.Settings.isRunning = False
        My.Settings.Save()
    End Sub

    Private Sub Video_TextChanged(sender As Object, e As EventArgs)
        My.Settings.Video = Video.Text
        My.Settings.Save()
    End Sub

    Private Sub Interval_ValueChanged(sender As Object, e As EventArgs)
        My.Settings.Interval = Interval.Value
        My.Settings.Save()
    End Sub
    Private Sub Exceptions_TextChanged(sender As Object, e As EventArgs)
        My.Settings.Apps = Exceptions.Text
        My.Settings.Save()
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Environment.CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath)
        Interval.Value = My.Settings.Interval
        Video.Text = My.Settings.Video
        Exceptions.Text = My.Settings.Apps
        If WindowState <> My.Settings.WindowState Then WindowState = My.Settings.WindowState
        If My.Settings.isRunning Then StartBtn_Click(Nothing, Nothing)

        AddHandler Interval.ValueChanged, AddressOf Interval_ValueChanged
        AddHandler Video.TextChanged, AddressOf Video_TextChanged
        AddHandler Exceptions.TextChanged, AddressOf Exceptions_TextChanged
        AddHandler MyBase.Resize, AddressOf Main_Resize

        AddHandler notifyIcon.DoubleClick, AddressOf notifyClicked
        notifyIcon.Icon = My.Resources.icon
        notifyIcon.Visible = True
        AddToStartup()
    End Sub

    Private Sub notifyClicked(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
        Show()
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs)
        My.Settings.WindowState = WindowState
        My.Settings.Save()
        ShowInTaskbar = Not (WindowState = FormWindowState.Minimized)
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        notifyIcon.Dispose()
    End Sub


End Class
