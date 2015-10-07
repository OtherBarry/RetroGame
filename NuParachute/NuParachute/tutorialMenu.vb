Public Class tutorialMenu
    Private Sub exitTutorialBtn_Click(sender As Object, e As EventArgs) Handles exitTutorialBtn.Click
        Me.Hide()
        Main.Show()

    End Sub
    Private Sub exitTutorialBtn_VisibleChanged(sender As Object, e As EventArgs) Handles exitTutorialBtn.VisibleChanged
        exitTutorialBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        exitTutorialBtn.FlatAppearance.BorderSize = 0
        exitTutorialBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        exitTutorialBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        exitTutorialBtn.BackColor = Color.Transparent
    End Sub
    Private Sub playGameBtn_Click(sender As Object, e As EventArgs) Handles playGameBtn.Click
        Me.Hide()
        playMenuForm.Show()
    End Sub
    Private Sub playGameBtn_VisibleChanged(sender As Object, e As EventArgs) Handles playGameBtn.VisibleChanged
        playGameBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        playGameBtn.FlatAppearance.BorderSize = 0
        playGameBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        playGameBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        playGameBtn.BackColor = Color.Transparent
    End Sub
End Class