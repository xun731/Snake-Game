<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.StartList = New System.Windows.Forms.ImageList(Me.components)
        Me.SettingList = New System.Windows.Forms.ImageList(Me.components)
        Me.ExplainList = New System.Windows.Forms.ImageList(Me.components)
        Me.VolumeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExplainPicture = New System.Windows.Forms.PictureBox()
        Me.SettingPicture = New System.Windows.Forms.PictureBox()
        Me.TitlePicture = New System.Windows.Forms.PictureBox()
        Me.StartPicture = New System.Windows.Forms.PictureBox()
        Me.ExplainwordPicture = New System.Windows.Forms.PictureBox()
        CType(Me.ExplainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExplainwordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartList
        '
        Me.StartList.ImageStream = CType(resources.GetObject("StartList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StartList.TransparentColor = System.Drawing.Color.Transparent
        Me.StartList.Images.SetKeyName(0, "start.png")
        Me.StartList.Images.SetKeyName(1, "start1.png")
        '
        'SettingList
        '
        Me.SettingList.ImageStream = CType(resources.GetObject("SettingList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SettingList.TransparentColor = System.Drawing.Color.Transparent
        Me.SettingList.Images.SetKeyName(0, "setting1.png")
        Me.SettingList.Images.SetKeyName(1, "setting2.png")
        '
        'ExplainList
        '
        Me.ExplainList.ImageStream = CType(resources.GetObject("ExplainList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ExplainList.TransparentColor = System.Drawing.Color.Transparent
        Me.ExplainList.Images.SetKeyName(0, "說明1.png")
        Me.ExplainList.Images.SetKeyName(1, "說明2.png")
        '
        'VolumeTimer
        '
        '
        'ExplainPicture
        '
        Me.ExplainPicture.BackColor = System.Drawing.Color.Transparent
        Me.ExplainPicture.Image = CType(resources.GetObject("ExplainPicture.Image"), System.Drawing.Image)
        Me.ExplainPicture.Location = New System.Drawing.Point(666, 385)
        Me.ExplainPicture.Name = "ExplainPicture"
        Me.ExplainPicture.Size = New System.Drawing.Size(53, 53)
        Me.ExplainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExplainPicture.TabIndex = 4
        Me.ExplainPicture.TabStop = False
        '
        'SettingPicture
        '
        Me.SettingPicture.BackColor = System.Drawing.Color.Transparent
        Me.SettingPicture.Image = CType(resources.GetObject("SettingPicture.Image"), System.Drawing.Image)
        Me.SettingPicture.Location = New System.Drawing.Point(725, 385)
        Me.SettingPicture.Name = "SettingPicture"
        Me.SettingPicture.Size = New System.Drawing.Size(53, 53)
        Me.SettingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingPicture.TabIndex = 3
        Me.SettingPicture.TabStop = False
        '
        'TitlePicture
        '
        Me.TitlePicture.BackColor = System.Drawing.Color.Transparent
        Me.TitlePicture.Image = CType(resources.GetObject("TitlePicture.Image"), System.Drawing.Image)
        Me.TitlePicture.Location = New System.Drawing.Point(122, 33)
        Me.TitlePicture.Name = "TitlePicture"
        Me.TitlePicture.Size = New System.Drawing.Size(581, 170)
        Me.TitlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TitlePicture.TabIndex = 2
        Me.TitlePicture.TabStop = False
        '
        'StartPicture
        '
        Me.StartPicture.BackColor = System.Drawing.Color.Transparent
        Me.StartPicture.Image = CType(resources.GetObject("StartPicture.Image"), System.Drawing.Image)
        Me.StartPicture.Location = New System.Drawing.Point(109, 268)
        Me.StartPicture.Name = "StartPicture"
        Me.StartPicture.Size = New System.Drawing.Size(289, 137)
        Me.StartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StartPicture.TabIndex = 0
        Me.StartPicture.TabStop = False
        '
        'ExplainwordPicture
        '
        Me.ExplainwordPicture.BackColor = System.Drawing.Color.Transparent
        Me.ExplainwordPicture.Image = CType(resources.GetObject("ExplainwordPicture.Image"), System.Drawing.Image)
        Me.ExplainwordPicture.Location = New System.Drawing.Point(16, 33)
        Me.ExplainwordPicture.Name = "ExplainwordPicture"
        Me.ExplainwordPicture.Size = New System.Drawing.Size(644, 405)
        Me.ExplainwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExplainwordPicture.TabIndex = 5
        Me.ExplainwordPicture.TabStop = False
        Me.ExplainwordPicture.Visible = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExplainwordPicture)
        Me.Controls.Add(Me.ExplainPicture)
        Me.Controls.Add(Me.SettingPicture)
        Me.Controls.Add(Me.TitlePicture)
        Me.Controls.Add(Me.StartPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StartForm"
        Me.Text = "貪食蛇"
        CType(Me.ExplainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExplainwordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartPicture As PictureBox
    Friend WithEvents StartList As ImageList
    Friend WithEvents TitlePicture As PictureBox
    Friend WithEvents SettingPicture As PictureBox
    Friend WithEvents SettingList As ImageList
    Friend WithEvents ExplainPicture As PictureBox
    Friend WithEvents ExplainList As ImageList
    Friend WithEvents ExplainwordPicture As PictureBox
    Friend Shared WithEvents VolumeTimer As Timer
End Class
