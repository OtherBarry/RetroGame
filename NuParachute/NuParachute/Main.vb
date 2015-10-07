Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles playBtn.Click
        playMenuForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Options.Show()
        Me.Hide()
    End Sub
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim response = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click
        Me.Hide()
        tutorialMenu.Show()
    End Sub
    Private Sub playBtn_VisibleChanged(sender As Object, e As EventArgs) Handles playBtn.VisibleChanged
        playBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        playBtn.FlatAppearance.BorderSize = 0
        playBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        playBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        playBtn.BackColor = Color.Transparent
    End Sub

    Private Sub btnTutorial_VisibleChanged(sender As Object, e As EventArgs) Handles btnTutorial.VisibleChanged
        btnTutorial.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnTutorial.FlatAppearance.BorderSize = 0
        btnTutorial.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        btnTutorial.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnTutorial.BackColor = Color.Transparent
    End Sub

    Private Sub btnOptions_VisibleChanged(sender As Object, e As EventArgs) Handles btnOptions.VisibleChanged
        btnOptions.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnOptions.FlatAppearance.BorderSize = 0
        btnOptions.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        btnOptions.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnOptions.BackColor = Color.Transparent
    End Sub

    Private Sub btnSkins_VisibleChanged(sender As Object, e As EventArgs) Handles btnSkins.VisibleChanged
        btnSkins.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnSkins.FlatAppearance.BorderSize = 0
        btnSkins.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        btnSkins.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnSkins.BackColor = Color.Transparent
    End Sub

    Private Sub exitBtn_VisibleChanged(sender As Object, e As EventArgs) Handles exitBtn.VisibleChanged
        exitBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        exitBtn.FlatAppearance.BorderSize = 0
        exitBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        exitBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        exitBtn.BackColor = Color.Transparent
    End Sub

    Private Sub btnSkins_Click(sender As Object, e As EventArgs) Handles btnSkins.Click
        Me.Hide()
        skinSelectionMenu.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.SAIL, AudioPlayMode.BackgroundLoop)
    End Sub
End Class