<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayingForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayingForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CountTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CountList = New System.Windows.Forms.ImageList(Me.components)
        Me.EatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreGroup = New System.Windows.Forms.GroupBox()
        Me.Score = New System.Windows.Forms.Label()
        Me.BestGroup = New System.Windows.Forms.GroupBox()
        Me.BestScore = New System.Windows.Forms.Label()
        Me.PauseList = New System.Windows.Forms.ImageList(Me.components)
        Me.ContinueList = New System.Windows.Forms.ImageList(Me.components)
        Me.AppleList = New System.Windows.Forms.ImageList(Me.components)
        Me.BadATimer = New System.Windows.Forms.Timer(Me.components)
        Me.FastPicture = New System.Windows.Forms.PictureBox()
        Me.GunPicture = New System.Windows.Forms.PictureBox()
        Me.PausePicture = New System.Windows.Forms.PictureBox()
        Me.ScoreGroup.SuspendLayout()
        Me.BestGroup.SuspendLayout()
        CType(Me.FastPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PausePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 451)
        Me.Panel1.TabIndex = 0
        '
        'CountTimer
        '
        Me.CountTimer.Enabled = True
        Me.CountTimer.Interval = 1000
        '
        'GameTimer
        '
        '
        'CountList
        '
        Me.CountList.ImageStream = CType(resources.GetObject("CountList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CountList.TransparentColor = System.Drawing.Color.Transparent
        Me.CountList.Images.SetKeyName(0, "count1.png")
        Me.CountList.Images.SetKeyName(1, "count2.png")
        Me.CountList.Images.SetKeyName(2, "count3.png")
        '
        'EatTimer
        '
        '
        'ScoreGroup
        '
        Me.ScoreGroup.Controls.Add(Me.Score)
        Me.ScoreGroup.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ScoreGroup.Location = New System.Drawing.Point(505, 13)
        Me.ScoreGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.ScoreGroup.Name = "ScoreGroup"
        Me.ScoreGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.ScoreGroup.Size = New System.Drawing.Size(267, 68)
        Me.ScoreGroup.TabIndex = 4
        Me.ScoreGroup.TabStop = False
        Me.ScoreGroup.Text = "Score"
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.Location = New System.Drawing.Point(121, 22)
        Me.Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(29, 32)
        Me.Score.TabIndex = 0
        Me.Score.Text = "0"
        Me.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BestGroup
        '
        Me.BestGroup.Controls.Add(Me.BestScore)
        Me.BestGroup.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BestGroup.Location = New System.Drawing.Point(505, 101)
        Me.BestGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.BestGroup.Name = "BestGroup"
        Me.BestGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.BestGroup.Size = New System.Drawing.Size(267, 68)
        Me.BestGroup.TabIndex = 5
        Me.BestGroup.TabStop = False
        Me.BestGroup.Text = "BestScore"
        '
        'BestScore
        '
        Me.BestScore.AutoSize = True
        Me.BestScore.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestScore.Location = New System.Drawing.Point(121, 22)
        Me.BestScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BestScore.Name = "BestScore"
        Me.BestScore.Size = New System.Drawing.Size(29, 32)
        Me.BestScore.TabIndex = 0
        Me.BestScore.Text = "0"
        Me.BestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PauseList
        '
        Me.PauseList.ImageStream = CType(resources.GetObject("PauseList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PauseList.TransparentColor = System.Drawing.Color.Transparent
        Me.PauseList.Images.SetKeyName(0, "Pause1.png")
        Me.PauseList.Images.SetKeyName(1, "Pause.png")
        '
        'ContinueList
        '
        Me.ContinueList.ImageStream = CType(resources.GetObject("ContinueList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ContinueList.TransparentColor = System.Drawing.Color.Transparent
        Me.ContinueList.Images.SetKeyName(0, "Continue.png")
        Me.ContinueList.Images.SetKeyName(1, "Continue1.png")
        '
        'AppleList
        '
        Me.AppleList.ImageStream = CType(resources.GetObject("AppleList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.AppleList.TransparentColor = System.Drawing.Color.Transparent
        Me.AppleList.Images.SetKeyName(0, "apple.png")
        Me.AppleList.Images.SetKeyName(1, "Apple1.png")
        '
        'BadATimer
        '
        Me.BadATimer.Interval = 3000
        '
        'FastPicture
        '
        Me.FastPicture.BackColor = System.Drawing.Color.Transparent
        Me.FastPicture.Image = CType(resources.GetObject("FastPicture.Image"), System.Drawing.Image)
        Me.FastPicture.Location = New System.Drawing.Point(505, 187)
        Me.FastPicture.Name = "FastPicture"
        Me.FastPicture.Size = New System.Drawing.Size(281, 83)
        Me.FastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FastPicture.TabIndex = 8
        Me.FastPicture.TabStop = False
        Me.FastPicture.Visible = False
        '
        'GunPicture
        '
        Me.GunPicture.BackColor = System.Drawing.Color.Transparent
        Me.GunPicture.Image = Global.H110_貪食蛇.My.Resources.Resources.Gun
        Me.GunPicture.Location = New System.Drawing.Point(632, 290)
        Me.GunPicture.Name = "GunPicture"
        Me.GunPicture.Size = New System.Drawing.Size(173, 161)
        Me.GunPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunPicture.TabIndex = 7
        Me.GunPicture.TabStop = False
        '
        'PausePicture
        '
        Me.PausePicture.BackColor = System.Drawing.Color.Transparent
        Me.PausePicture.Image = CType(resources.GetObject("PausePicture.Image"), System.Drawing.Image)
        Me.PausePicture.Location = New System.Drawing.Point(527, 309)
        Me.PausePicture.Name = "PausePicture"
        Me.PausePicture.Size = New System.Drawing.Size(68, 97)
        Me.PausePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PausePicture.TabIndex = 6
        Me.PausePicture.TabStop = False
        '
        'PlayingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FastPicture)
        Me.Controls.Add(Me.GunPicture)
        Me.Controls.Add(Me.PausePicture)
        Me.Controls.Add(Me.BestGroup)
        Me.Controls.Add(Me.ScoreGroup)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PlayingForm"
        Me.Text = "貪食蛇"
        Me.ScoreGroup.ResumeLayout(False)
        Me.ScoreGroup.PerformLayout()
        Me.BestGroup.ResumeLayout(False)
        Me.BestGroup.PerformLayout()
        CType(Me.FastPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PausePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend Shared WithEvents FastPicture As PictureBox
    Friend Shared WithEvents BadATimer As Timer
    Friend Shared WithEvents AppleList As ImageList
    Friend WithEvents PausePicture As PictureBox
    Friend Shared WithEvents SnakeList As ImageList
    Friend Shared WithEvents Panel1 As Panel
    Friend Shared WithEvents CountTimer As Timer
    Friend Shared WithEvents GameTimer As Timer
    Friend Shared WithEvents CountList As ImageList
    Friend Shared WithEvents EatTimer As Timer
    Friend Shared WithEvents ScoreGroup As GroupBox
    Friend Shared WithEvents Score As Label
    Friend Shared WithEvents BestGroup As GroupBox
    Friend Shared WithEvents BestScore As Label
    Friend Shared WithEvents GunPicture As PictureBox
    Friend WithEvents PauseList As ImageList
    Friend WithEvents ContinueList As ImageList
End Class
