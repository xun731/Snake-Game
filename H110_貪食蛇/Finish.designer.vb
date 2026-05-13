<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finish
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Finish))
        Me.SnakePicture = New System.Windows.Forms.PictureBox()
        Me.FinishLabel = New System.Windows.Forms.Label()
        Me.gameover = New System.Windows.Forms.ImageList(Me.components)
        Me.GameOverPicture = New System.Windows.Forms.PictureBox()
        Me.RestartPicture = New System.Windows.Forms.PictureBox()
        Me.restart = New System.Windows.Forms.ImageList(Me.components)
        Me.HomePicture = New System.Windows.Forms.PictureBox()
        Me.home = New System.Windows.Forms.ImageList(Me.components)
        Me.Snake = New System.Windows.Forms.ImageList(Me.components)
        Me.SnakeTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SnakePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameOverPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestartPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SnakePicture
        '
        Me.SnakePicture.BackColor = System.Drawing.Color.Transparent
        Me.SnakePicture.Image = CType(resources.GetObject("SnakePicture.Image"), System.Drawing.Image)
        Me.SnakePicture.Location = New System.Drawing.Point(250, 70)
        Me.SnakePicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SnakePicture.Name = "SnakePicture"
        Me.SnakePicture.Size = New System.Drawing.Size(96, 63)
        Me.SnakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SnakePicture.TabIndex = 0
        Me.SnakePicture.TabStop = False
        '
        'FinishLabel
        '
        Me.FinishLabel.AutoSize = True
        Me.FinishLabel.BackColor = System.Drawing.Color.Transparent
        Me.FinishLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishLabel.Location = New System.Drawing.Point(46, 55)
        Me.FinishLabel.Name = "FinishLabel"
        Me.FinishLabel.Size = New System.Drawing.Size(182, 78)
        Me.FinishLabel.TabIndex = 1
        Me.FinishLabel.Text = "Finish"
        '
        'gameover
        '
        Me.gameover.ImageStream = CType(resources.GetObject("gameover.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.gameover.TransparentColor = System.Drawing.Color.Transparent
        Me.gameover.Images.SetKeyName(0, "gameover2.png")
        Me.gameover.Images.SetKeyName(1, "gameover1.png")
        '
        'GameOverPicture
        '
        Me.GameOverPicture.BackColor = System.Drawing.Color.Transparent
        Me.GameOverPicture.Image = CType(resources.GetObject("GameOverPicture.Image"), System.Drawing.Image)
        Me.GameOverPicture.Location = New System.Drawing.Point(10, 161)
        Me.GameOverPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GameOverPicture.Name = "GameOverPicture"
        Me.GameOverPicture.Size = New System.Drawing.Size(123, 95)
        Me.GameOverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GameOverPicture.TabIndex = 2
        Me.GameOverPicture.TabStop = False
        '
        'RestartPicture
        '
        Me.RestartPicture.BackColor = System.Drawing.Color.Transparent
        Me.RestartPicture.Image = CType(resources.GetObject("RestartPicture.Image"), System.Drawing.Image)
        Me.RestartPicture.Location = New System.Drawing.Point(168, 155)
        Me.RestartPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RestartPicture.Name = "RestartPicture"
        Me.RestartPicture.Size = New System.Drawing.Size(117, 113)
        Me.RestartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RestartPicture.TabIndex = 3
        Me.RestartPicture.TabStop = False
        '
        'restart
        '
        Me.restart.ImageStream = CType(resources.GetObject("restart.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.restart.TransparentColor = System.Drawing.Color.Transparent
        Me.restart.Images.SetKeyName(0, "restart1-1.png")
        Me.restart.Images.SetKeyName(1, "restart2.png")
        '
        'HomePicture
        '
        Me.HomePicture.BackColor = System.Drawing.Color.Transparent
        Me.HomePicture.Image = Global.H110_貪食蛇.My.Resources.Resources.home3
        Me.HomePicture.Location = New System.Drawing.Point(318, 147)
        Me.HomePicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomePicture.Name = "HomePicture"
        Me.HomePicture.Size = New System.Drawing.Size(114, 114)
        Me.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HomePicture.TabIndex = 4
        Me.HomePicture.TabStop = False
        '
        'home
        '
        Me.home.ImageStream = CType(resources.GetObject("home.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.home.TransparentColor = System.Drawing.Color.Transparent
        Me.home.Images.SetKeyName(0, "home3.png")
        Me.home.Images.SetKeyName(1, "home2.png")
        '
        'Snake
        '
        Me.Snake.ImageStream = CType(resources.GetObject("Snake.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Snake.TransparentColor = System.Drawing.Color.Transparent
        Me.Snake.Images.SetKeyName(0, "snake.png")
        Me.Snake.Images.SetKeyName(1, "snake1.png")
        '
        'SnakeTimer
        '
        Me.SnakeTimer.Enabled = True
        Me.SnakeTimer.Interval = 300
        '
        'Finish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 271)
        Me.Controls.Add(Me.HomePicture)
        Me.Controls.Add(Me.RestartPicture)
        Me.Controls.Add(Me.GameOverPicture)
        Me.Controls.Add(Me.FinishLabel)
        Me.Controls.Add(Me.SnakePicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Finish"
        Me.Text = "GameOver"
        CType(Me.SnakePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameOverPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestartPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnakePicture As PictureBox
    Friend WithEvents FinishLabel As Label
    Friend WithEvents gameover As ImageList
    Friend WithEvents GameOverPicture As PictureBox
    Friend WithEvents RestartPicture As PictureBox
    Friend WithEvents restart As ImageList
    Friend WithEvents HomePicture As PictureBox
    Friend WithEvents home As ImageList
    Friend WithEvents Snake As ImageList
    Friend WithEvents SnakeTimer As Timer
End Class
