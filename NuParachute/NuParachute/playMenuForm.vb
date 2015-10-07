Public Class playMenuForm
    Dim difficultLevel = {"Current Difficulty: Very Easy", "Current Difficulty: Easy", "Current Difficulty: Medium", "Current Difficulty: Hard", "Current Difficulty: Very Hard"}
    Dim difficultLevelNumber As Integer = 2
    Private Sub playMenuReturnBtn_Click(sender As Object, e As EventArgs) Handles playMenuReturnBtn.Click
        Me.Close()
        Main.Show()
    End Sub
    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles campaignPlayBtn.Click 'Launches Campaign Mode
        GameMode = "Campaign"
        Me.Close()
        Game.Show()
    End Sub
    Private Sub endlessPlayBtn_Click(sender As Object, e As EventArgs) Handles endlessPlayBtn.Click 'Launches Endless Mode
        GameMode = "Endless"
        Me.Close()
        Game.Show()
    End Sub
    Private Sub arcadePlayBtn_Click(sender As Object, e As EventArgs) Handles arcadePlayBtn.Click 'Launches Arcade Mode
        GameMode = "Arcade"
        Me.Close()
        Game.Show()
    End Sub
    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click 'Handles increasing difficulty
        difficultLevelNumber = difficultLevelNumber + 1
        If difficultLevelNumber > 4 Then
            difficultLevelNumber = 4
        End If
        Select Case Difficulty
            Case 1
                Difficulty = 3
            Case 3
                Difficulty = 5
            Case 5
                Difficulty = 7
            Case Else
                Difficulty = 10
        End Select

        lblDifficulty.Text = difficultLevel(difficultLevelNumber)
    End Sub
    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click 'Handles decreasing difficulty
        difficultLevelNumber = difficultLevelNumber - 1
        If difficultLevelNumber < 0 Then
            difficultLevelNumber = 0
        End If
        Select Case Difficulty
            Case 10
                Difficulty = 7
            Case 7
                Difficulty = 5
            Case 5
                Difficulty = 3
            Case Else
                Difficulty = 1
        End Select
        lblDifficulty.Text = difficultLevel(difficultLevelNumber)
    End Sub
    Private Sub tutorialRedirectBtn_Click(sender As Object, e As EventArgs) Handles tutorialRedirectBtn.Click
        Me.Close()
        tutorialMenu.Show()
    End Sub
    Private Sub campaignPlayBtn_VisibleChanged(sender As Object, e As EventArgs) Handles campaignPlayBtn.VisibleChanged
        campaignPlayBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        campaignPlayBtn.FlatAppearance.BorderSize = 0
        campaignPlayBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        campaignPlayBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        campaignPlayBtn.BackColor = Color.Transparent
    End Sub
    Private Sub endlessPlayBtn_VisibleChanged(sender As Object, e As EventArgs) Handles endlessPlayBtn.VisibleChanged
        endlessPlayBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        endlessPlayBtn.FlatAppearance.BorderSize = 0
        endlessPlayBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        endlessPlayBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        endlessPlayBtn.BackColor = Color.Transparent
    End Sub
    Private Sub playMenuReturnBtn_VisibleChanged(sender As Object, e As EventArgs) Handles playMenuReturnBtn.VisibleChanged
        playMenuReturnBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        playMenuReturnBtn.FlatAppearance.BorderSize = 0
        playMenuReturnBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        playMenuReturnBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        playMenuReturnBtn.BackColor = Color.Transparent
    End Sub
    Private Sub arcadePlayBtn_VisibleChanged(sender As Object, e As EventArgs) Handles arcadePlayBtn.VisibleChanged
        arcadePlayBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        arcadePlayBtn.FlatAppearance.BorderSize = 0
        arcadePlayBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        arcadePlayBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        arcadePlayBtn.BackColor = Color.Transparent
    End Sub
End Class