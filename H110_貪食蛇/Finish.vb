Public Class Finish

    Dim index As Integer = 0
    Dim Mouse_Leave As Boolean = True

    Private Sub GameOverPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles GameOverPicture.MouseMove
        GameOverPicture.Image = gameover.Images(1)
    End Sub
    Private Sub GameOverPicture_MouseLeave(sender As Object, e As EventArgs) Handles GameOverPicture.MouseLeave
        If Mouse_Leave = True Then
            GameOverPicture.Image = gameover.Images(0)
        End If

    End Sub

    Private Sub RestartPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles RestartPicture.MouseMove
        RestartPicture.Image = restart.Images(1)
    End Sub

    Private Sub RestartPicture_MouseLeave(sender As Object, e As EventArgs) Handles RestartPicture.MouseLeave
        If Mouse_Leave = True Then
            RestartPicture.Image = restart.Images(0)
        End If
    End Sub

    Private Sub HomePicture_MouseMove(sender As Object, e As MouseEventArgs) Handles HomePicture.MouseMove
        HomePicture.Image = home.Images(1)
    End Sub

    Private Sub HomePicture_MouseLeave(sender As Object, e As EventArgs) Handles HomePicture.MouseLeave
        If Mouse_Leave = True Then
            HomePicture.Image = home.Images(0)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameOverPicture.Image = gameover.Images(0)
        GameOverPicture.Size = New Size(120, 70)
    End Sub

    Private Sub SnakeTimer_Tick(sender As Object, e As EventArgs) Handles SnakeTimer.Tick
        SnakePicture.Image = Snake.Images(index)

        index += 1
        If index > 1 Then
            index = 0
        End If
    End Sub

    Private Sub RestartPicture_Click(sender As Object, e As EventArgs) Handles RestartPicture.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)
        PlayingForm.Reset_Game()
        Me.Hide()

    End Sub

    Private Sub Finish_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Mouse_Leave = False
        Application.Exit()
    End Sub

    Private Sub GameOverPicture_Click(sender As Object, e As EventArgs) Handles GameOverPicture.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)
        System.Threading.Thread.Sleep(300)
        Mouse_Leave = False
        Application.Exit()
    End Sub

    Private Sub HomePicture_Click(sender As Object, e As EventArgs) Handles HomePicture.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Button.wav", AudioPlayMode.Background)
        System.Threading.Thread.Sleep(100)
        Application.Restart()
        'PlayingForm.Reset_Game()
        'PlayingForm.Hide()
        'Dim PlayForm = Application.OpenForms("PlayingForm")
        'PlayForm.Visible = False
        'Dim Start = Application.OpenForms("StartForm")
        'Start.Visible = True
        'StartForm.Show()
        'Me.Hide()
    End Sub

End Class
