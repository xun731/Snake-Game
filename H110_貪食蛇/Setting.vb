Imports System.ComponentModel

Public Class SettingForm

    Dim Mouse_Leave As Boolean = True
    Public Shared Body_pic As Integer = 0
    Public Shared BadA_Mode As Boolean = False
    Public Shared Challenge_Mode As Boolean = False
    'Dim Body
    'Shared Speed_Num As Integer = 5
    'Shared Volume_Num As Integer

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPicture.Image = BackList.Images(0)

        Dim bmpUp As New Bitmap(SpeedUp.Image)
        bmpUp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        SpeedUp.Image = bmpUp
        VolumeUp.Image = bmpUp
        SnakeUp.Image = bmpUp
        Dim bmpDown As New Bitmap(SpeedUp.Image)
        bmpDown.RotateFlip(RotateFlipType.RotateNoneFlipX)
        SpeedDown.Image = bmpDown
        VolumeDown.Image = bmpDown
        SnakeDown.Image = bmpDown

        Speed.Text = StartForm.Speed_Num
        Volume.Text = StartForm.Volume_Num
        SnakePicture.Image = SnakeList.Images(Body_pic)
        Volume.Left = (VolumeDown.Left + VolumeDown.Width + VolumeUp.Left) / 2 - Volume.Width / 2

    End Sub

    Private Sub BackPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles BackPicture.MouseMove
        BackPicture.Image = BackList.Images(1)
    End Sub


    Private Sub BackPicture_MouseLeave(sender As Object, e As EventArgs) Handles BackPicture.MouseLeave
        If Mouse_Leave = True Then
            BackPicture.Image = BackList.Images(0)
        End If

    End Sub

    Private Sub SettingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Mouse_Leave = False
        Application.Exit()
    End Sub

    Private Sub BackPicture_Click(sender As Object, e As EventArgs) Handles BackPicture.Click
        StartForm.VolumeClose()
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\SetButton.wav", AudioPlayMode.Background)
        Dim Start = Application.OpenForms("StartForm")
        Start.Visible = True
        Me.Hide()

    End Sub

    Private Sub SpeedUp_MouseMove(sender As Object, e As MouseEventArgs) Handles SpeedUp.MouseMove
        SpeedUp.Image = SetList.Images(1)
        Dim bmp As New Bitmap(SpeedUp.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        SpeedUp.Image = bmp
    End Sub

    Private Sub SpeedUp_MouseLeave(sender As Object, e As EventArgs) Handles SpeedUp.MouseLeave
        SpeedUp.Image = SetList.Images(0)
        Dim bmp As New Bitmap(SpeedUp.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        SpeedUp.Image = bmp
    End Sub

    Private Sub SpeedDown_MouseMove(sender As Object, e As MouseEventArgs) Handles SpeedDown.MouseMove
        SpeedDown.Image = SetList.Images(1)
        Dim bmp As New Bitmap(SpeedDown.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
        SpeedDown.Image = bmp
    End Sub

    Private Sub SpeedDown_MouseLeave(sender As Object, e As EventArgs) Handles SpeedDown.MouseLeave
        SpeedDown.Image = SetList.Images(0)
        Dim bmp As New Bitmap(SpeedDown.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
        SpeedDown.Image = bmp
    End Sub

    Private Sub VolumeUp_MouseMove(sender As Object, e As MouseEventArgs) Handles VolumeUp.MouseMove
        VolumeUp.Image = SetList.Images(1)
        Dim bmp As New Bitmap(VolumeUp.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        VolumeUp.Image = bmp
    End Sub

    Private Sub VolumeUp_MouseLeave(sender As Object, e As EventArgs) Handles VolumeUp.MouseLeave
        VolumeUp.Image = SetList.Images(0)
        Dim bmp As New Bitmap(VolumeUp.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        VolumeUp.Image = bmp
    End Sub

    Private Sub VolumeDown_MouseMove(sender As Object, e As MouseEventArgs) Handles VolumeDown.MouseMove
        VolumeDown.Image = SetList.Images(1)
        Dim bmp As New Bitmap(VolumeDown.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
        VolumeDown.Image = bmp
    End Sub

    Private Sub VolumeDown_MouseLeave(sender As Object, e As EventArgs) Handles VolumeDown.MouseLeave
        VolumeDown.Image = SetList.Images(0)
        Dim bmp As New Bitmap(VolumeDown.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
        VolumeDown.Image = bmp
    End Sub

    Private Sub SnakeUp_MouseMove(sender As Object, e As MouseEventArgs) Handles SnakeUp.MouseMove
        SnakeUp.Image = SetList.Images(1)
        Dim bmp As New Bitmap(SnakeUp.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        SnakeUp.Image = bmp
    End Sub

    Private Sub SnakeUp_MouseLeave(sender As Object, e As EventArgs) Handles SnakeUp.MouseLeave
        SnakeUp.Image = SetList.Images(0)
        Dim bmp As New Bitmap(SnakeUp.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        SnakeUp.Image = bmp
    End Sub

    Private Sub SnakeDown_MouseMove(sender As Object, e As MouseEventArgs) Handles SnakeDown.MouseMove
        SnakeDown.Image = SetList.Images(1)
        Dim bmp As New Bitmap(SnakeDown.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
        SnakeDown.Image = bmp
    End Sub

    Private Sub SnakeDown_MouseLeave(sender As Object, e As EventArgs) Handles SnakeDown.MouseLeave
        SnakeDown.Image = SetList.Images(0)
        Dim bmp As New Bitmap(SnakeDown.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
        SnakeDown.Image = bmp
    End Sub


    Private Sub VolumeUp_Click(sender As Object, e As EventArgs) Handles VolumeUp.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)

        If Int(Volume.Text) = 100 Then
            StartForm.Volume_Num = 0
            Volume.Text = 0
        Else
            StartForm.Volume_Num += 5
            Volume.Text += 5
        End If
        Volume.Left = (VolumeDown.Left + VolumeDown.Width + VolumeUp.Left) / 2 - Volume.Width / 2

    End Sub

    Private Sub VolumeDown_Click(sender As Object, e As EventArgs) Handles VolumeDown.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)

        If Int(Volume.Text) = 0 Then
            StartForm.Volume_Num = 100
            Volume.Text = 100
        Else
            StartForm.Volume_Num -= 5
            Volume.Text -= 5
        End If
        Volume.Left = (VolumeDown.Left + VolumeDown.Width + VolumeUp.Left) / 2 - Volume.Width / 2
    End Sub

    Private Sub SpeedUp_Click(sender As Object, e As EventArgs) Handles SpeedUp.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)

        If Int(Speed.Text) = 10 Then
            StartForm.Speed_Num = 1
            Speed.Text = 1
        Else
            StartForm.Speed_Num += 1
            Speed.Text += 1
        End If
        Speed.Left = (SpeedDown.Left + SpeedDown.Width + SpeedUp.Left) / 2 - Speed.Width / 2

    End Sub

    Private Sub SpeedDown_Click(sender As Object, e As EventArgs) Handles SpeedDown.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)

        If Int(Speed.Text) = 1 Then
            StartForm.Speed_Num = 10
            Speed.Text = 10
        Else
            StartForm.Speed_Num -= 1
            Speed.Text -= 1
        End If
        Speed.Left = (SpeedDown.Left + SpeedDown.Width + SpeedUp.Left) / 2 - Speed.Width / 2
    End Sub

    Private Sub SnakeUp_Click(sender As Object, e As EventArgs) Handles SnakeUp.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)


        If Body_pic = 23 Then
            Body_pic = 0
            SnakePicture.Image = SnakeList.Images(Body_pic)
        Else
            Body_pic += 1
            SnakePicture.Image = SnakeList.Images(Body_pic)
        End If

    End Sub

    Private Sub SnakeDown_Click(sender As Object, e As EventArgs) Handles SnakeDown.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)

        If Body_pic = 0 Then
            Body_pic = 23
            SnakePicture.Image = SnakeList.Images(Body_pic)
        Else
            Body_pic -= 1
            SnakePicture.Image = SnakeList.Images(Body_pic)
        End If


    End Sub

    Private Sub LastPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles LastPicture.MouseMove
        LastPicture.Image = LastList.Images(1)
    End Sub

    Private Sub LastPicture_MouseLeave(sender As Object, e As EventArgs) Handles LastPicture.MouseLeave
        LastPicture.Image = LastList.Images(0)
    End Sub

    Private Sub NextPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles NextPicture.MouseMove
        NextPicture.Image = NextList.Images(1)
    End Sub

    Private Sub NextPicture_MouseLeave(sender As Object, e As EventArgs) Handles NextPicture.MouseLeave
        NextPicture.Image = NextList.Images(0)
    End Sub

    Private Sub NextPicture_Click(sender As Object, e As EventArgs) Handles NextPicture.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\SetButton.wav", AudioPlayMode.Background)
        LastPicture.Visible = True
        LastPicture.Enabled = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Speed.Visible = False
        SpeedUp.Visible = False
        SpeedUp.Enabled = False
        SpeedDown.Visible = False
        SpeedDown.Enabled = False
        Volume.Visible = False
        VolumeUp.Visible = False
        VolumeUp.Enabled = False
        VolumeDown.Visible = False
        VolumeDown.Enabled = False
        SnakePicture.Visible = False
        SnakeUp.Visible = False
        SnakeUp.Enabled = False
        SnakeDown.Visible = False
        SnakeDown.Enabled = False
        ApplePicture.Visible = True
        AppleCheck.Visible = True
        AppleCheck.Enabled = True
        AppleQ.Visible = True
        AppleQ.Enabled = True
        ChallengePicture.Visible = True
        ChallengeCheck.Visible = True
        ChallengeCheck.Enabled = True
        ChallengeQ.Visible = True
        ChallengeQ.Enabled = True
        Label1.Visible = True
        MorePicture.Visible = True
        NextPicture.Visible = False
        NextPicture.Enabled = False
    End Sub

    Private Sub LastPicture_Click(sender As Object, e As EventArgs) Handles LastPicture.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\SetButton.wav", AudioPlayMode.Background)
        NextPicture.Visible = True
        NextPicture.Enabled = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Speed.Visible = True
        SpeedUp.Visible = True
        SpeedDown.Visible = True
        If Challenge_Mode = False Then
            SpeedUp.Enabled = True
            SpeedDown.Enabled = True
        End If
        Volume.Visible = True
        VolumeUp.Visible = True
        VolumeUp.Enabled = True
        VolumeDown.Visible = True
        VolumeDown.Enabled = True
        SnakePicture.Visible = True
        SnakeUp.Visible = True
        SnakeUp.Enabled = True
        SnakeDown.Visible = True
        SnakeDown.Enabled = True
        ApplePicture.Visible = False
        AppleCheck.Visible = False
        AppleCheck.Enabled = False
        AppleQ.Visible = False
        AppleQ.Enabled = False
        ChallengePicture.Visible = False
        ChallengeCheck.Visible = False
        ChallengeCheck.Enabled = False
        ChallengeQ.Visible = False
        ChallengeQ.Enabled = False
        Label1.Visible = False
        MorePicture.Visible = False
        LastPicture.Visible = False
        LastPicture.Enabled = False
    End Sub

    Private Sub AppleCheck_MouseMove(sender As Object, e As MouseEventArgs) Handles AppleCheck.MouseMove
        If BadA_Mode = False Then
            AppleCheck.Image = CheckList.Images(2)
        Else
            AppleCheck.Image = CheckList.Images(1)
        End If
    End Sub

    Private Sub AppleCheck_MouseLeave(sender As Object, e As EventArgs) Handles AppleCheck.MouseLeave
        If BadA_Mode = False Then
            AppleCheck.Image = CheckList.Images(3)
        Else
            AppleCheck.Image = CheckList.Images(0)
        End If
    End Sub

    Private Sub AppleCheck_Click(sender As Object, e As EventArgs) Handles AppleCheck.Click
        If BadA_Mode = False Then
            BadA_Mode = True
            AppleCheck.Image = CheckList.Images(1)
        Else
            BadA_Mode = False
            AppleCheck.Image = CheckList.Images(2)
        End If
    End Sub

    Private Sub AppleQ_MouseMove(sender As Object, e As MouseEventArgs) Handles AppleQ.MouseMove
        AppleQ.Image = QuestionList.Images(0)
        AppleExplain.Visible = True
    End Sub

    Private Sub AppleQ_MouseLeave(sender As Object, e As EventArgs) Handles AppleQ.MouseLeave
        AppleQ.Image = QuestionList.Images(1)
        AppleExplain.Visible = False
    End Sub

    Private Sub ChallengeCheck_MouseMove(sender As Object, e As MouseEventArgs) Handles ChallengeCheck.MouseMove
        If Challenge_Mode = False Then
            ChallengeCheck.Image = CheckList.Images(2)
        Else
            ChallengeCheck.Image = CheckList.Images(1)
        End If
    End Sub

    Private Sub ChallengeCheck_MouseLeave(sender As Object, e As EventArgs) Handles ChallengeCheck.MouseLeave
        If Challenge_Mode = False Then
            ChallengeCheck.Image = CheckList.Images(3)
        Else
            ChallengeCheck.Image = CheckList.Images(0)
        End If
    End Sub

    Private Sub ChallengeCheck_Click(sender As Object, e As EventArgs) Handles ChallengeCheck.Click
        If Challenge_Mode = False Then
            Challenge_Mode = True
            ChallengeCheck.Image = CheckList.Images(1)
            StartForm.Speed_Num = 2
            Speed.Text = 2
            SpeedUp.Enabled = False
            SpeedDown.Enabled = False
        Else
            Challenge_Mode = False
            ChallengeCheck.Image = CheckList.Images(2)
            SpeedUp.Enabled = True
            SpeedDown.Enabled = True
        End If
    End Sub

    Private Sub ChallengeQ_MouseMove(sender As Object, e As MouseEventArgs) Handles ChallengeQ.MouseMove
        ChallengeQ.Image = QuestionList.Images(0)
        ChallengeExplain.Visible = True
    End Sub

    Private Sub ChallengeQ_MouseLeave(sender As Object, e As EventArgs) Handles ChallengeQ.MouseLeave
        ChallengeQ.Image = QuestionList.Images(1)
        ChallengeExplain.Visible = False
    End Sub
End Class