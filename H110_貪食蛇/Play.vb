Public Class PlayingForm

    Shared Body(), Apple() As PictureBox
    Shared Head, Count, BadA As PictureBox
    Shared walk As Integer = 19
    Shared Block_size As New Size(19, 19)
    Shared SnakeMove As Integer = 2
    Shared Body_count As Integer = 0
    Shared Apple_count As Integer = 0
    Shared Start_count As Integer = 0
    Shared Apple_Rand As Integer
    Shared Head_Walk As New System.Drawing.Point
    Shared Body1_walk As New System.Drawing.Point
    Shared Turn As Boolean = True
    Dim Pause As Integer = 1
    Shared PlayMusic As New WMPLib.WindowsMediaPlayer



    'Shared Playform = Application.OpenForms("PlayingForm")




    Private Sub PlayingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Body = {}
        Apple = {}

        PausePicture.Image = PauseList.Images(0)


        PlayMusic.URL = My.Application.Info.DirectoryPath & "\PlayingMusic.mp3"
        PlayMusic.settings.setMode("loop", True)
        PlayMusic.settings.volume = StartForm.Volume_Num
        System.Threading.Thread.Sleep(100)
        PlayMusic.controls.stop()

        '毒蘋果創建
        BadA = New PictureBox
        BadA.BackColor = System.Drawing.SystemColors.Info
        BadA.Image = AppleList.Images(0)
        BadA.Size = Block_size
        BadA.SizeMode = PictureBoxSizeMode.Zoom
        Me.Controls.Add(BadA)
        BadA.BringToFront()
        If SettingForm.BadA_Mode = False Then
            BadA.Visible = False
        End If


        Call Game_Load()

    End Sub

    Private Sub PlayingForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '移動 方向鍵
        If e.KeyCode = Keys.Left And SnakeMove <> 2 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 1
            Turn = False
        End If
        If e.KeyCode = Keys.Right And SnakeMove <> 1 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 2
            Turn = False
        End If
        If e.KeyCode = Keys.Up And SnakeMove <> 4 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 3
            Turn = False
        End If
        If e.KeyCode = Keys.Down And SnakeMove <> 3 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 4
            Turn = False
        End If
        '移動 WASD
        If e.KeyCode = Keys.A And SnakeMove <> 2 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 1
            Turn = False
        End If
        If e.KeyCode = Keys.D And SnakeMove <> 1 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 2
            Turn = False
        End If
        If e.KeyCode = Keys.W And SnakeMove <> 4 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 3
            Turn = False
        End If
        If e.KeyCode = Keys.S And SnakeMove <> 3 And Turn = True And GameTimer.Enabled = True Then
            SnakeMove = 4
            Turn = False
        End If

    End Sub

    Private Shared Sub CountTimer_Tick(sender As Object, e As EventArgs) Handles CountTimer.Tick
        '開始前倒數
        If Start_count > 2 Then
            '倒數結束
            CountTimer.Enabled = False
            Count.Visible = False
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Start.wav", AudioPlayMode.Background)
            Count.SendToBack()
            GameTimer.Enabled = True
            EatTimer.Enabled = True
            If SettingForm.BadA_Mode = True Then
                BadATimer.Enabled = True
            End If
            PlayMusic.controls.play()
            Return
        End If
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Count.wav", AudioPlayMode.Background)
        Count.Image = CountList.Images(Start_count)
        Start_count += 1



    End Sub

    Private Shared Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        Call Head_Move()
        For i As Integer = 1 To Body_count
            If Head.Location = Body(i).Location Then
                Call Boom()
            End If
        Next

        '最高分
        If Int(Score.Text) > Int(BestScore.Text) Then '沒改成int最高分會卡在9
            BestScore.Text = Score.Text
        End If

    End Sub

    Private Shared Sub BadATimer_Tick(sender As Object, e As EventArgs) Handles BadATimer.Tick
        Call BadA_location()
    End Sub

    Private Shared Sub EatTimer_Tick(sender As Object, e As EventArgs) Handles EatTimer.Tick
        '吃
        Dim Playform = Application.OpenForms("PlayingForm")
        For i As Integer = 1 To Apple_count
            If Head.Location = Apple(i).Location Then
                EatTimer.Enabled = False
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\SnakeEat.wav", AudioPlayMode.Background)
                Apple_count -= 1
                'Apple(i).Location = New System.Drawing.Point(2000, 2000)
                Playform.Controls.Remove(Apple(i))
                Call AppleCreate()
                EatTimer.Enabled = True
                Call Create_body()
                Body(Body_count).Location = Body(Body_count - 1).Location
                Score.Text += 1
                If SettingForm.Challenge_Mode = True Then
                    If GameTimer.Interval > 50 Then
                        GameTimer.Interval -= 50
                    End If
                    If GameTimer.Interval = 50 Then
                        FastPicture.Visible = True
                    End If
                End If

                Exit For
            End If
        Next
        If SettingForm.BadA_Mode = True Then
            If Head.Location = BadA.Location Then
                EatTimer.Enabled = False
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\SnakeEat.wav", AudioPlayMode.Background)
                Call BadA_location()
                EatTimer.Enabled = True
                Score.Text -= 1
            End If
        End If

    End Sub

    Private Sub PausePicture_Click(sender As Object, e As EventArgs) Handles PausePicture.Click
        Dim GameOver = Application.OpenForms("Finish")
        If CountTimer.Enabled = False And GameOver.Visible = False Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Pause.wav", AudioPlayMode.Background)
            If Pause = 2 Then
                GameTimer.Enabled = False
                PausePicture.Image = ContinueList.Images(1)
                Pause = 4
            ElseIf Pause = 4 Then
                GameTimer.Enabled = True
                PausePicture.Image = PauseList.Images(1)
                Pause = 2
            End If
        End If
    End Sub

    Private Sub PausePicture_MouseMove(sender As Object, e As MouseEventArgs) Handles PausePicture.MouseMove
        If Pause = 1 Then
            PausePicture.Image = PauseList.Images(1)
            Pause = 2
        ElseIf Pause = 3 Then
            PausePicture.Image = ContinueList.Images(1)
            Pause = 4
        End If
    End Sub

    Private Sub PausePicture_MouseLeave(sender As Object, e As EventArgs) Handles PausePicture.MouseLeave
        If Pause = 2 Then
            PausePicture.Image = PauseList.Images(0)
            Pause = 1
        ElseIf Pause = 4 Then
            PausePicture.Image = ContinueList.Images(0)
            Pause = 3
        End If
    End Sub



    Shared Sub StartCount()
        '開始倒數ㄉ圖宣告
        Dim Playform = Application.OpenForms("PlayingForm")
        Count = New PictureBox
        Count.Size = New Size(100, 100)
        Count.BackColor = System.Drawing.SystemColors.Info
        Count.Left = Playform.Width / 2 - Count.Width / 2
        Count.Top = Playform.Height / 2 - Count.Height / 2
        Count.Visible = True
        Playform.Controls.Add(Count)
        Count.BringToFront()
    End Sub

    Shared Sub SnakeHead()
        '蛇ㄉ頭圖宣告
        Dim Playform = Application.OpenForms("PlayingForm")
        Head = New PictureBox
        If SettingForm.Body_pic <= 2 Then
            Head.BackColor = Color.SkyBlue
        ElseIf SettingForm.Body_pic > 2 And SettingForm.Body_pic <= 11 Then
            If SettingForm.Body_pic = 3 Then
                Head.BackColor = System.Drawing.SystemColors.Info
                Head.Image = SettingForm.SnakeList.Images(21)
            Else
                Head.BackColor = System.Drawing.SystemColors.Info
                Head.Image = SettingForm.SnakeList.Images(3)
            End If
        ElseIf SettingForm.Body_pic > 11 And SettingForm.Body_pic <= 17 Then
            If SettingForm.Body_pic = 13 Then
                Head.BackColor = System.Drawing.SystemColors.Info
                Head.Image = SettingForm.SnakeList.Images(12)
            Else Head.BackColor = System.Drawing.SystemColors.Info
                Head.Image = SettingForm.SnakeList.Images(13)
            End If

        ElseIf SettingForm.Body_pic > 17 And SettingForm.Body_pic <= 23 Then
            If SettingForm.Body_pic = 22 Then
                Head.BackColor = System.Drawing.SystemColors.Info
                Head.Image = SettingForm.SnakeList.Images(21)
            Else
                Head.BackColor = System.Drawing.SystemColors.Info
                Head.Image = SettingForm.SnakeList.Images(22)
            End If

        End If
        Head.Size = Block_size
        Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Head.Location = New System.Drawing.Point(walk * 2, 0)
        Head.Visible = True
        Playform.Controls.Add(Head)
        Head.BringToFront()
    End Sub


    Shared Sub AppleCreate()
        '蘋果宣告
        Dim Playform = Application.OpenForms("PlayingForm")
        Apple_count += 1
        ReDim Preserve Apple(Apple_count)
        Apple(Apple_count) = New PictureBox
        Apple(Apple_count).Name = "Apple" & Apple_count
        Apple(Apple_count).Visible = True
        'Apple(Apple_count).BackColor = Color.DarkGreen
        Apple(Apple_count).BackColor = System.Drawing.SystemColors.Info
        Apple(Apple_count).Image = AppleList.Images(1)
        Apple(Apple_count).Size = Block_size
        Apple(Apple_count).SizeMode = PictureBoxSizeMode.Zoom
        Randomize()
        Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
        Apple(Apple_count).Left = walk * Apple_Rand
        Randomize()
        Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
        Apple(Apple_count).Top = walk * Apple_Rand

        If Apple(Apple_count).Location = Head.Location Then
            Randomize()
            Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
            Apple(Apple_count).Left = walk * Apple_Rand
            Randomize()
            Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
            Apple(Apple_count).Top = walk * Apple_Rand
        End If
        For i As Integer = 1 To Body_count
            If Apple(Apple_count).Location = Body(i).Location Then
                Randomize()
                Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
                Apple(Apple_count).Left = walk * Apple_Rand
                Randomize()
                Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
                Apple(Apple_count).Top = walk * Apple_Rand
            End If
        Next
        If SettingForm.BadA_Mode = True Then
            If Apple(Apple_count).Location = BadA.Location Then
                Randomize()
                Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
                Apple(Apple_count).Left = walk * Apple_Rand
                Randomize()
                Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
                Apple(Apple_count).Top = walk * Apple_Rand
            End If
        End If

        Playform.Controls.Add(Apple(Apple_count))
        Apple(Apple_count).BringToFront()


    End Sub

    Shared Sub BadA_location()
        Randomize()
        Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
        BadA.Left = walk * Apple_Rand
        Randomize()
        Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
        BadA.Top = walk * Apple_Rand
        If BadA.Location = Head.Location Or BadA.Location = Apple(1).Location Then
            Randomize()
            Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
            BadA.Left = walk * Apple_Rand
            Randomize()
            Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
            BadA.Top = walk * Apple_Rand
        End If
        For i As Integer = 1 To Body_count
            If BadA.Location = Body(i).Location Then
                Randomize()
                Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
                BadA.Left = walk * Apple_Rand
                Randomize()
                Apple_Rand = Int(0 + Rnd() * (18 - 0 + 1))
                BadA.Top = walk * Apple_Rand
            End If
        Next
    End Sub

    Shared Sub Create_body()
        '蛇身宣告
        Dim Playform = Application.OpenForms("PlayingForm")
        Body_count += 1
        ReDim Preserve Body(Body_count)
        Body(Body_count) = New PictureBox
        Body(Body_count).Name = "Body" & Body_count
        Body(Body_count).Visible = True
        'Body(Body_count).BackColor = Color.SkyBlue
        Body(Body_count).BackColor = System.Drawing.SystemColors.Info
        Body(Body_count).Image = SettingForm.SnakeList.Images(SettingForm.Body_pic)
        Body(Body_count).SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Body(Body_count).Size = Block_size
        Playform.Controls.Add(Body(Body_count))
        Body(Body_count).BringToFront()
        'Body_count += 1
    End Sub

    Shared Sub Body_Move()

        For i As Integer = Body_count To 2 Step -1
            Body(i).Location = Body(i - 1).Location
        Next

        Body(1).Location = Body1_walk

    End Sub

    Shared Sub Head_Move()
        '移動

        Body1_walk = Head.Location
        If SnakeMove = 1 Then '向左
            Head_Walk.X -= walk
            Call Wall()
            If GameTimer.Enabled = True Then
                Head.Left -= walk
                Call Body_Move()
            End If
        ElseIf SnakeMove = 2 Then '向右
            Head_Walk.X += walk
            Call Wall()
            If GameTimer.Enabled = True Then
                Head.Left += walk
                Call Body_Move()
            End If
        ElseIf SnakeMove = 3 Then '向上
            Head_Walk.Y -= walk
            Call Wall()
            If GameTimer.Enabled = True Then
                Head.Top -= walk
                Call Body_Move()
            End If
        ElseIf SnakeMove = 4 Then '向下
            Head_Walk.Y += walk
            Call Wall()
            If GameTimer.Enabled = True Then
                Head.Top += walk
                Call Body_Move()
            End If
        End If
        Turn = True

    End Sub

    Shared Sub Wall()
        '擋牆
        If Head_Walk.X < 0 Then '加了等於並且上下左右寫在同個If中 最左側的上下擋牆會失效
            Head.Left = 0
            Call Boom()
        ElseIf Head_Walk.x > Panel1.Width - walk Then
            Head.Left = Panel1.Width - walk
            Call Boom()
        End If
        If Head_Walk.Y < 0 Then
            Head.Top = 0
            Call Boom()
        ElseIf Head_Walk.y > Panel1.Height - walk Then
            Head.Top = Panel1.Height - walk
            Call Boom()
        End If
    End Sub

    Shared Sub Boom()
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Dead.wav", AudioPlayMode.Background)
        Dim GameOver = Application.OpenForms("Finish")
        Head.BringToFront()
        GameTimer.Enabled = False
        If SettingForm.BadA_Mode = True Then
            BadATimer.Enabled = False
        End If
        GameOver.Visible = True

        PlayMusic.controls.pause()

    End Sub

    Shared Sub Reset_Game()
        Dim Playform = Application.OpenForms("PlayingForm")
        For i As Integer = 1 To Body_count
            Playform.Controls.Remove(Body(i))
        Next
        Body_count = 0

        For i As Integer = 1 To Apple_count
            Playform.Controls.Remove(Apple(i))
        Next
        Apple_count = 0

        Playform.Controls.Remove(Head)
        Playform.Controls.Remove(Count)
        Start_count = 0
        Score.Text = 0
        FastPicture.Visible = False
        Call Game_Load()
        'PlayMusic.controls.play()
    End Sub



    Shared Sub Game_Load()
        '蛇ㄉ速度設定
        If SettingForm.Challenge_Mode = False Then
            GameTimer.Interval = Int(1000 / StartForm.Speed_Num)
        Else
            GameTimer.Interval = 500
            EatTimer.Interval = 40
        End If

        Call SnakeHead()
        Call Create_body()
        Body(Body_count).Location = New System.Drawing.Point(walk, 0)
        Call Create_body()
        Body(Body_count).Location = New System.Drawing.Point(0, 0)
        Call AppleCreate()
        Call StartCount()
        SnakeMove = 2
        CountTimer.Enabled = True
        Head_Walk = Head.Location
        If SettingForm.BadA_Mode = True Then
            Call BadA_location()
        End If
    End Sub

    Private Sub PlayingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PlayMusic.close()
        Application.Exit()
    End Sub


End Class