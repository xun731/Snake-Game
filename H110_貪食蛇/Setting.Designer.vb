<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Me.BackList = New System.Windows.Forms.ImageList(Me.components)
        Me.SetList = New System.Windows.Forms.ImageList(Me.components)
        Me.Speed = New System.Windows.Forms.Label()
        Me.Volume = New System.Windows.Forms.Label()
        Me.SnakeList = New System.Windows.Forms.ImageList(Me.components)
        Me.LastList = New System.Windows.Forms.ImageList(Me.components)
        Me.NextList = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckList = New System.Windows.Forms.ImageList(Me.components)
        Me.QuestionList = New System.Windows.Forms.ImageList(Me.components)
        Me.ChallengeExplain = New System.Windows.Forms.PictureBox()
        Me.PaintQ = New System.Windows.Forms.PictureBox()
        Me.ChallengeQ = New System.Windows.Forms.PictureBox()
        Me.ChallengeCheck = New System.Windows.Forms.PictureBox()
        Me.AppleExplain = New System.Windows.Forms.PictureBox()
        Me.AppleQ = New System.Windows.Forms.PictureBox()
        Me.AppleCheck = New System.Windows.Forms.PictureBox()
        Me.PaintCheck = New System.Windows.Forms.PictureBox()
        Me.LastPicture = New System.Windows.Forms.PictureBox()
        Me.NextPicture = New System.Windows.Forms.PictureBox()
        Me.SnakePicture = New System.Windows.Forms.PictureBox()
        Me.SnakeDown = New System.Windows.Forms.PictureBox()
        Me.SnakeUp = New System.Windows.Forms.PictureBox()
        Me.VolumeDown = New System.Windows.Forms.PictureBox()
        Me.VolumeUp = New System.Windows.Forms.PictureBox()
        Me.SpeedDown = New System.Windows.Forms.PictureBox()
        Me.SpeedUp = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackPicture = New System.Windows.Forms.PictureBox()
        Me.MorePicture = New System.Windows.Forms.PictureBox()
        Me.ApplePicture = New System.Windows.Forms.PictureBox()
        Me.PaintPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ChallengePicture = New System.Windows.Forms.PictureBox()
        CType(Me.ChallengeExplain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaintQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallengeQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallengeCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppleExplain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppleQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppleCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaintCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnakePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnakeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnakeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaintPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallengePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackList
        '
        Me.BackList.ImageStream = CType(resources.GetObject("BackList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.BackList.TransparentColor = System.Drawing.Color.Transparent
        Me.BackList.Images.SetKeyName(0, "Back.png")
        Me.BackList.Images.SetKeyName(1, "Back1.png")
        '
        'SetList
        '
        Me.SetList.ImageStream = CType(resources.GetObject("SetList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SetList.TransparentColor = System.Drawing.Color.Transparent
        Me.SetList.Images.SetKeyName(0, "飯糰.png")
        Me.SetList.Images.SetKeyName(1, "飯糰2.png")
        '
        'Speed
        '
        Me.Speed.AutoSize = True
        Me.Speed.BackColor = System.Drawing.Color.Transparent
        Me.Speed.Font = New System.Drawing.Font("Consolas", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed.Location = New System.Drawing.Point(244, 18)
        Me.Speed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(50, 55)
        Me.Speed.TabIndex = 7
        Me.Speed.Text = "0"
        Me.Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Volume
        '
        Me.Volume.AutoSize = True
        Me.Volume.BackColor = System.Drawing.Color.Transparent
        Me.Volume.Font = New System.Drawing.Font("Consolas", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.Location = New System.Drawing.Point(244, 84)
        Me.Volume.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(50, 55)
        Me.Volume.TabIndex = 8
        Me.Volume.Text = "0"
        Me.Volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SnakeList
        '
        Me.SnakeList.ImageStream = CType(resources.GetObject("SnakeList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SnakeList.TransparentColor = System.Drawing.Color.Transparent
        Me.SnakeList.Images.SetKeyName(0, "23199-abstract-blue-purple-square-background-template.jpg")
        Me.SnakeList.Images.SetKeyName(1, "4132790.png")
        Me.SnakeList.Images.SetKeyName(2, "350.jpg")
        Me.SnakeList.Images.SetKeyName(3, "Body.png")
        Me.SnakeList.Images.SetKeyName(4, "1.png")
        Me.SnakeList.Images.SetKeyName(5, "3.png")
        Me.SnakeList.Images.SetKeyName(6, "4.png")
        Me.SnakeList.Images.SetKeyName(7, "5.png")
        Me.SnakeList.Images.SetKeyName(8, "6.png")
        Me.SnakeList.Images.SetKeyName(9, "7.png")
        Me.SnakeList.Images.SetKeyName(10, "8.png")
        Me.SnakeList.Images.SetKeyName(11, "9.png")
        Me.SnakeList.Images.SetKeyName(12, "01.png")
        Me.SnakeList.Images.SetKeyName(13, "02.png")
        Me.SnakeList.Images.SetKeyName(14, "03.png")
        Me.SnakeList.Images.SetKeyName(15, "04.png")
        Me.SnakeList.Images.SetKeyName(16, "05.png")
        Me.SnakeList.Images.SetKeyName(17, "06.png")
        Me.SnakeList.Images.SetKeyName(18, "001.png")
        Me.SnakeList.Images.SetKeyName(19, "002.png")
        Me.SnakeList.Images.SetKeyName(20, "003.png")
        Me.SnakeList.Images.SetKeyName(21, "004.png")
        Me.SnakeList.Images.SetKeyName(22, "005.png")
        Me.SnakeList.Images.SetKeyName(23, "006.png")
        '
        'LastList
        '
        Me.LastList.ImageStream = CType(resources.GetObject("LastList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LastList.TransparentColor = System.Drawing.Color.Transparent
        Me.LastList.Images.SetKeyName(0, "LastPage.png")
        Me.LastList.Images.SetKeyName(1, "LastPage1.png")
        '
        'NextList
        '
        Me.NextList.ImageStream = CType(resources.GetObject("NextList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.NextList.TransparentColor = System.Drawing.Color.Transparent
        Me.NextList.Images.SetKeyName(0, "NextPage.png")
        Me.NextList.Images.SetKeyName(1, "NextPage1.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("標楷體", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(27, 274)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 80)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "敬請期待"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'CheckList
        '
        Me.CheckList.ImageStream = CType(resources.GetObject("CheckList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CheckList.TransparentColor = System.Drawing.Color.Transparent
        Me.CheckList.Images.SetKeyName(0, "check.png")
        Me.CheckList.Images.SetKeyName(1, "check1.png")
        Me.CheckList.Images.SetKeyName(2, "check2.png")
        Me.CheckList.Images.SetKeyName(3, "check3.png")
        '
        'QuestionList
        '
        Me.QuestionList.ImageStream = CType(resources.GetObject("QuestionList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.QuestionList.TransparentColor = System.Drawing.Color.Transparent
        Me.QuestionList.Images.SetKeyName(0, "main.png")
        Me.QuestionList.Images.SetKeyName(1, "Question.png")
        '
        'ChallengeExplain
        '
        Me.ChallengeExplain.BackColor = System.Drawing.Color.Transparent
        Me.ChallengeExplain.Image = Global.H110_貪食蛇.My.Resources.Resources.挑戰版說明1
        Me.ChallengeExplain.Location = New System.Drawing.Point(418, 12)
        Me.ChallengeExplain.Name = "ChallengeExplain"
        Me.ChallengeExplain.Size = New System.Drawing.Size(327, 326)
        Me.ChallengeExplain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ChallengeExplain.TabIndex = 27
        Me.ChallengeExplain.TabStop = False
        Me.ChallengeExplain.Visible = False
        '
        'PaintQ
        '
        Me.PaintQ.BackColor = System.Drawing.Color.Transparent
        Me.PaintQ.Enabled = False
        Me.PaintQ.Image = Global.H110_貪食蛇.My.Resources.Resources.Question
        Me.PaintQ.Location = New System.Drawing.Point(254, 222)
        Me.PaintQ.Name = "PaintQ"
        Me.PaintQ.Size = New System.Drawing.Size(50, 50)
        Me.PaintQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PaintQ.TabIndex = 26
        Me.PaintQ.TabStop = False
        Me.PaintQ.Visible = False
        '
        'ChallengeQ
        '
        Me.ChallengeQ.BackColor = System.Drawing.Color.Transparent
        Me.ChallengeQ.Enabled = False
        Me.ChallengeQ.Image = Global.H110_貪食蛇.My.Resources.Resources.Question
        Me.ChallengeQ.Location = New System.Drawing.Point(254, 158)
        Me.ChallengeQ.Name = "ChallengeQ"
        Me.ChallengeQ.Size = New System.Drawing.Size(50, 50)
        Me.ChallengeQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ChallengeQ.TabIndex = 25
        Me.ChallengeQ.TabStop = False
        Me.ChallengeQ.Visible = False
        '
        'ChallengeCheck
        '
        Me.ChallengeCheck.BackColor = System.Drawing.Color.Transparent
        Me.ChallengeCheck.Enabled = False
        Me.ChallengeCheck.Image = CType(resources.GetObject("ChallengeCheck.Image"), System.Drawing.Image)
        Me.ChallengeCheck.Location = New System.Drawing.Point(187, 157)
        Me.ChallengeCheck.Name = "ChallengeCheck"
        Me.ChallengeCheck.Size = New System.Drawing.Size(50, 50)
        Me.ChallengeCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ChallengeCheck.TabIndex = 24
        Me.ChallengeCheck.TabStop = False
        Me.ChallengeCheck.Visible = False
        '
        'AppleExplain
        '
        Me.AppleExplain.BackColor = System.Drawing.Color.Transparent
        Me.AppleExplain.Image = Global.H110_貪食蛇.My.Resources.Resources.毒蘋果說明1
        Me.AppleExplain.Location = New System.Drawing.Point(418, 12)
        Me.AppleExplain.Name = "AppleExplain"
        Me.AppleExplain.Size = New System.Drawing.Size(327, 326)
        Me.AppleExplain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppleExplain.TabIndex = 22
        Me.AppleExplain.TabStop = False
        Me.AppleExplain.Visible = False
        '
        'AppleQ
        '
        Me.AppleQ.BackColor = System.Drawing.Color.Transparent
        Me.AppleQ.Enabled = False
        Me.AppleQ.Image = CType(resources.GetObject("AppleQ.Image"), System.Drawing.Image)
        Me.AppleQ.Location = New System.Drawing.Point(254, 89)
        Me.AppleQ.Name = "AppleQ"
        Me.AppleQ.Size = New System.Drawing.Size(50, 50)
        Me.AppleQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppleQ.TabIndex = 21
        Me.AppleQ.TabStop = False
        Me.AppleQ.Visible = False
        '
        'AppleCheck
        '
        Me.AppleCheck.BackColor = System.Drawing.Color.Transparent
        Me.AppleCheck.Enabled = False
        Me.AppleCheck.Image = CType(resources.GetObject("AppleCheck.Image"), System.Drawing.Image)
        Me.AppleCheck.Location = New System.Drawing.Point(187, 89)
        Me.AppleCheck.Name = "AppleCheck"
        Me.AppleCheck.Size = New System.Drawing.Size(50, 50)
        Me.AppleCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppleCheck.TabIndex = 20
        Me.AppleCheck.TabStop = False
        Me.AppleCheck.Visible = False
        '
        'PaintCheck
        '
        Me.PaintCheck.BackColor = System.Drawing.Color.Transparent
        Me.PaintCheck.Enabled = False
        Me.PaintCheck.Image = CType(resources.GetObject("PaintCheck.Image"), System.Drawing.Image)
        Me.PaintCheck.Location = New System.Drawing.Point(187, 222)
        Me.PaintCheck.Name = "PaintCheck"
        Me.PaintCheck.Size = New System.Drawing.Size(50, 50)
        Me.PaintCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PaintCheck.TabIndex = 18
        Me.PaintCheck.TabStop = False
        Me.PaintCheck.Visible = False
        '
        'LastPicture
        '
        Me.LastPicture.BackColor = System.Drawing.Color.Transparent
        Me.LastPicture.Enabled = False
        Me.LastPicture.Image = Global.H110_貪食蛇.My.Resources.Resources.LastPage1
        Me.LastPicture.Location = New System.Drawing.Point(165, 366)
        Me.LastPicture.Name = "LastPicture"
        Me.LastPicture.Size = New System.Drawing.Size(184, 72)
        Me.LastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LastPicture.TabIndex = 14
        Me.LastPicture.TabStop = False
        Me.LastPicture.Visible = False
        '
        'NextPicture
        '
        Me.NextPicture.BackColor = System.Drawing.Color.Transparent
        Me.NextPicture.Image = Global.H110_貪食蛇.My.Resources.Resources.NextPage1
        Me.NextPicture.Location = New System.Drawing.Point(451, 366)
        Me.NextPicture.Name = "NextPicture"
        Me.NextPicture.Size = New System.Drawing.Size(184, 72)
        Me.NextPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NextPicture.TabIndex = 13
        Me.NextPicture.TabStop = False
        '
        'SnakePicture
        '
        Me.SnakePicture.BackColor = System.Drawing.Color.Transparent
        Me.SnakePicture.Location = New System.Drawing.Point(244, 157)
        Me.SnakePicture.Name = "SnakePicture"
        Me.SnakePicture.Size = New System.Drawing.Size(50, 50)
        Me.SnakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SnakePicture.TabIndex = 12
        Me.SnakePicture.TabStop = False
        '
        'SnakeDown
        '
        Me.SnakeDown.BackColor = System.Drawing.Color.Transparent
        Me.SnakeDown.Image = CType(resources.GetObject("SnakeDown.Image"), System.Drawing.Image)
        Me.SnakeDown.Location = New System.Drawing.Point(165, 158)
        Me.SnakeDown.Name = "SnakeDown"
        Me.SnakeDown.Size = New System.Drawing.Size(50, 50)
        Me.SnakeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SnakeDown.TabIndex = 11
        Me.SnakeDown.TabStop = False
        '
        'SnakeUp
        '
        Me.SnakeUp.BackColor = System.Drawing.Color.Transparent
        Me.SnakeUp.Image = CType(resources.GetObject("SnakeUp.Image"), System.Drawing.Image)
        Me.SnakeUp.Location = New System.Drawing.Point(319, 158)
        Me.SnakeUp.Name = "SnakeUp"
        Me.SnakeUp.Size = New System.Drawing.Size(50, 50)
        Me.SnakeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SnakeUp.TabIndex = 10
        Me.SnakeUp.TabStop = False
        '
        'VolumeDown
        '
        Me.VolumeDown.BackColor = System.Drawing.Color.Transparent
        Me.VolumeDown.Image = CType(resources.GetObject("VolumeDown.Image"), System.Drawing.Image)
        Me.VolumeDown.Location = New System.Drawing.Point(165, 89)
        Me.VolumeDown.Name = "VolumeDown"
        Me.VolumeDown.Size = New System.Drawing.Size(50, 50)
        Me.VolumeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VolumeDown.TabIndex = 6
        Me.VolumeDown.TabStop = False
        '
        'VolumeUp
        '
        Me.VolumeUp.BackColor = System.Drawing.Color.Transparent
        Me.VolumeUp.Image = CType(resources.GetObject("VolumeUp.Image"), System.Drawing.Image)
        Me.VolumeUp.Location = New System.Drawing.Point(319, 89)
        Me.VolumeUp.Name = "VolumeUp"
        Me.VolumeUp.Size = New System.Drawing.Size(50, 50)
        Me.VolumeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VolumeUp.TabIndex = 5
        Me.VolumeUp.TabStop = False
        '
        'SpeedDown
        '
        Me.SpeedDown.BackColor = System.Drawing.Color.Transparent
        Me.SpeedDown.Image = CType(resources.GetObject("SpeedDown.Image"), System.Drawing.Image)
        Me.SpeedDown.Location = New System.Drawing.Point(165, 23)
        Me.SpeedDown.Name = "SpeedDown"
        Me.SpeedDown.Size = New System.Drawing.Size(50, 50)
        Me.SpeedDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SpeedDown.TabIndex = 4
        Me.SpeedDown.TabStop = False
        '
        'SpeedUp
        '
        Me.SpeedUp.BackColor = System.Drawing.Color.Transparent
        Me.SpeedUp.Image = CType(resources.GetObject("SpeedUp.Image"), System.Drawing.Image)
        Me.SpeedUp.Location = New System.Drawing.Point(319, 23)
        Me.SpeedUp.Name = "SpeedUp"
        Me.SpeedUp.Size = New System.Drawing.Size(50, 50)
        Me.SpeedUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SpeedUp.TabIndex = 3
        Me.SpeedUp.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_音量1
        Me.PictureBox2.Location = New System.Drawing.Point(26, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(97, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_速度1
        Me.PictureBox1.Location = New System.Drawing.Point(26, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BackPicture
        '
        Me.BackPicture.BackColor = System.Drawing.Color.Transparent
        Me.BackPicture.Image = CType(resources.GetObject("BackPicture.Image"), System.Drawing.Image)
        Me.BackPicture.Location = New System.Drawing.Point(694, 344)
        Me.BackPicture.Name = "BackPicture"
        Me.BackPicture.Size = New System.Drawing.Size(94, 94)
        Me.BackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackPicture.TabIndex = 0
        Me.BackPicture.TabStop = False
        '
        'MorePicture
        '
        Me.MorePicture.BackColor = System.Drawing.Color.Transparent
        Me.MorePicture.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_More1
        Me.MorePicture.Location = New System.Drawing.Point(26, 24)
        Me.MorePicture.Name = "MorePicture"
        Me.MorePicture.Size = New System.Drawing.Size(189, 49)
        Me.MorePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MorePicture.TabIndex = 16
        Me.MorePicture.TabStop = False
        Me.MorePicture.Visible = False
        '
        'ApplePicture
        '
        Me.ApplePicture.BackColor = System.Drawing.Color.Transparent
        Me.ApplePicture.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_Apple1
        Me.ApplePicture.Location = New System.Drawing.Point(26, 90)
        Me.ApplePicture.Name = "ApplePicture"
        Me.ApplePicture.Size = New System.Drawing.Size(149, 49)
        Me.ApplePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ApplePicture.TabIndex = 19
        Me.ApplePicture.TabStop = False
        Me.ApplePicture.Visible = False
        '
        'PaintPicture
        '
        Me.PaintPicture.BackColor = System.Drawing.Color.Transparent
        Me.PaintPicture.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_Paint1
        Me.PaintPicture.Location = New System.Drawing.Point(26, 222)
        Me.PaintPicture.Name = "PaintPicture"
        Me.PaintPicture.Size = New System.Drawing.Size(97, 49)
        Me.PaintPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PaintPicture.TabIndex = 17
        Me.PaintPicture.TabStop = False
        Me.PaintPicture.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_蛇身1
        Me.PictureBox3.Location = New System.Drawing.Point(26, 158)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(97, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'ChallengePicture
        '
        Me.ChallengePicture.BackColor = System.Drawing.Color.Transparent
        Me.ChallengePicture.Image = Global.H110_貪食蛇.My.Resources.Resources.Word_挑戰1
        Me.ChallengePicture.Location = New System.Drawing.Point(26, 158)
        Me.ChallengePicture.Name = "ChallengePicture"
        Me.ChallengePicture.Size = New System.Drawing.Size(149, 49)
        Me.ChallengePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ChallengePicture.TabIndex = 23
        Me.ChallengePicture.TabStop = False
        Me.ChallengePicture.Visible = False
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.H110_貪食蛇.My.Resources.Resources.FFFFFFFF1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PaintQ)
        Me.Controls.Add(Me.ChallengeQ)
        Me.Controls.Add(Me.ChallengeCheck)
        Me.Controls.Add(Me.AppleExplain)
        Me.Controls.Add(Me.AppleQ)
        Me.Controls.Add(Me.AppleCheck)
        Me.Controls.Add(Me.PaintCheck)
        Me.Controls.Add(Me.LastPicture)
        Me.Controls.Add(Me.NextPicture)
        Me.Controls.Add(Me.SnakePicture)
        Me.Controls.Add(Me.SnakeDown)
        Me.Controls.Add(Me.SnakeUp)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.Speed)
        Me.Controls.Add(Me.VolumeDown)
        Me.Controls.Add(Me.VolumeUp)
        Me.Controls.Add(Me.SpeedDown)
        Me.Controls.Add(Me.SpeedUp)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BackPicture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MorePicture)
        Me.Controls.Add(Me.ApplePicture)
        Me.Controls.Add(Me.PaintPicture)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ChallengePicture)
        Me.Controls.Add(Me.ChallengeExplain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SettingForm"
        Me.Text = "設定"
        CType(Me.ChallengeExplain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaintQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallengeQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallengeCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppleExplain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppleQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppleCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaintCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnakePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnakeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnakeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaintPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallengePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackList As ImageList
    Friend WithEvents BackPicture As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SpeedUp As PictureBox
    Friend WithEvents SpeedDown As PictureBox
    Friend WithEvents VolumeUp As PictureBox
    Friend WithEvents VolumeDown As PictureBox
    Friend WithEvents SetList As ImageList
    Friend WithEvents Speed As Label
    Friend WithEvents Volume As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SnakeUp As PictureBox
    Friend WithEvents SnakeDown As PictureBox
    Friend WithEvents SnakePicture As PictureBox
    Friend WithEvents SnakeList As ImageList
    Friend WithEvents NextPicture As PictureBox
    Friend WithEvents LastPicture As PictureBox
    Friend WithEvents LastList As ImageList
    Friend WithEvents NextList As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents MorePicture As PictureBox
    Friend WithEvents PaintPicture As PictureBox
    Friend WithEvents PaintCheck As PictureBox
    Friend WithEvents CheckList As ImageList
    Friend WithEvents ApplePicture As PictureBox
    Friend WithEvents AppleCheck As PictureBox
    Friend WithEvents AppleQ As PictureBox
    Friend WithEvents QuestionList As ImageList
    Friend WithEvents AppleExplain As PictureBox
    Friend WithEvents ChallengePicture As PictureBox
    Friend WithEvents ChallengeCheck As PictureBox
    Friend WithEvents ChallengeQ As PictureBox
    Friend WithEvents PaintQ As PictureBox
    Friend WithEvents ChallengeExplain As PictureBox
End Class
