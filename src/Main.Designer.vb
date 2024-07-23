<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Video = New System.Windows.Forms.TextBox()
        Me.BrowseVideo = New System.Windows.Forms.Button()
        Me.Interval = New System.Windows.Forms.NumericUpDown()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.Exceptions = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Player
        '
        Me.Player.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(0, 186)
        Me.Player.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(469, 271)
        Me.Player.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Video:"
        '
        'Video
        '
        Me.Video.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Video.BackColor = System.Drawing.Color.White
        Me.Video.Location = New System.Drawing.Point(84, 25)
        Me.Video.Name = "Video"
        Me.Video.Size = New System.Drawing.Size(312, 26)
        Me.Video.TabIndex = 2
        '
        'BrowseVideo
        '
        Me.BrowseVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseVideo.BackColor = System.Drawing.Color.White
        Me.BrowseVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrowseVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrowseVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseVideo.Location = New System.Drawing.Point(402, 25)
        Me.BrowseVideo.Name = "BrowseVideo"
        Me.BrowseVideo.Size = New System.Drawing.Size(54, 26)
        Me.BrowseVideo.TabIndex = 3
        Me.BrowseVideo.Text = "+++"
        Me.BrowseVideo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BrowseVideo.UseVisualStyleBackColor = False
        '
        'Interval
        '
        Me.Interval.BackColor = System.Drawing.Color.White
        Me.Interval.Location = New System.Drawing.Point(84, 66)
        Me.Interval.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.Interval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Interval.Name = "Interval"
        Me.Interval.Size = New System.Drawing.Size(60, 26)
        Me.Interval.TabIndex = 5
        Me.Interval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBtn.Location = New System.Drawing.Point(330, 145)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(126, 33)
        Me.StartBtn.TabIndex = 6
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'StopBtn
        '
        Me.StopBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StopBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopBtn.Location = New System.Drawing.Point(330, 145)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(126, 33)
        Me.StopBtn.TabIndex = 7
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "(sec)"
        '
        'Status
        '
        Me.Status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Black
        Me.Status.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Status.Location = New System.Drawing.Point(12, 364)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 20)
        Me.Status.TabIndex = 9
        '
        'Exceptions
        '
        Me.Exceptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exceptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exceptions.Location = New System.Drawing.Point(84, 108)
        Me.Exceptions.Multiline = True
        Me.Exceptions.Name = "Exceptions"
        Me.Exceptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Exceptions.Size = New System.Drawing.Size(219, 70)
        Me.Exceptions.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apps:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 393)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Exceptions)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Interval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BrowseVideo)
        Me.Controls.Add(Me.Video)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.StopBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock Screen"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As Label
    Friend WithEvents Video As TextBox
    Friend WithEvents BrowseVideo As Button
    Friend WithEvents Interval As NumericUpDown
    Friend WithEvents StartBtn As Button
    Friend WithEvents StopBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Status As Label
    Friend WithEvents Exceptions As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
