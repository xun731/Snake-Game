Public Class StartForm

    Shared StartMusic As New WMPLib.WindowsMediaPlayer

    Public Shared Volume_Num As Integer = 20
    Public Shared Speed_Num As Integer = 5

    Private Sub StartPicture_Click(sender As Object, e As EventArgs) Handles StartPicture.Click
        '
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\StartButton.wav", AudioPlayMode.Background)
        Me.Hide()
        Dim Callplay As New PlayingForm()
        Callplay.Show()
        StartMusic.close()

    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CallGameOver As New Finish()
        CallGameOver.Show()
        Dim GameOver = Application.OpenForms("Finish")
        GameOver.Visible = False
        Dim Callset As New SettingForm()
        Callset.Show()
        Dim Setting = Application.OpenForms("SettingForm")
        Setting.Visible = False

        StartMusic.URL = My.Application.Info.DirectoryPath & "\StartMusic.mp3"
        StartMusic.settings.setMode("loop", True)
        StartMusic.settings.volume = Volume_Num

        StartPicture.Size = New Size(250, 100)
        SettingPicture.Image = SettingList.Images(0)
        SettingPicture.Size = New Size(40, 40)
        ExplainPicture.Image = ExplainList.Images(0)
        ExplainPicture.Size = New Size(40, 40)



    End Sub

    Private Sub StartPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles StartPicture.MouseMove
        StartPicture.Image = StartList.Images(1)
    End Sub

    Private Sub StartPicture_MouseLeave(sender As Object, e As EventArgs) Handles StartPicture.MouseLeave
        StartPicture.Image = StartList.Images(0)
    End Sub

    Private Sub SettingPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles SettingPicture.MouseMove
        SettingPicture.Image = SettingList.Images(1)
    End Sub

    Private Sub SettingPicture_MouseLeave(sender As Object, e As EventArgs) Handles SettingPicture.MouseLeave
        SettingPicture.Image = SettingList.Images(0)
    End Sub

    Private Sub ExplainPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles ExplainPicture.MouseMove
        ExplainPicture.Image = ExplainList.Images(1)
        ExplainwordPicture.Visible = True
    End Sub

    Private Sub ExplainPicture_MouseLeave(sender As Object, e As EventArgs) Handles ExplainPicture.MouseLeave
        ExplainPicture.Image = ExplainList.Images(0)
        ExplainwordPicture.Visible = False
    End Sub

    Private Sub StartForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        StartMusic.close()
        Application.Exit()
    End Sub

    Private Sub SettingPicture_Click(sender As Object, e As EventArgs) Handles SettingPicture.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\SetButton.wav", AudioPlayMode.Background)
        Me.Hide()
        Dim Setting = Application.OpenForms("SettingForm")
        Setting.Visible = True
        VolumeTimer.Enabled = True
    End Sub

    Shared Sub VolumeClose()
        VolumeTimer.Enabled = False
    End Sub

    Private Shared Sub VolumeTimer_Tick(sender As Object, e As EventArgs) Handles VolumeTimer.Tick
        If StartMusic.settings.volume <> Volume_Num Then
            StartMusic.settings.volume = Volume_Num
        End If
    End Sub
End Class
