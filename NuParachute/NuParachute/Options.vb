Public Class Options
    Private infoList(0 To 6) As String

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles Me.Load
        numDropSpeed.Value = ScrollSpeed
        numLength.Value = Seconds
        numLives.Value = Lives
    End Sub

    Private Sub ValueChanged(sender As Object, e As EventArgs) Handles numCharSpeed.ValueChanged, numDropSpeed.ValueChanged, numEnSpeed.ValueChanged, numLength.ValueChanged, numLives.ValueChanged
        ScrollSpeed = numDropSpeed.Value
        Seconds = numLength.Value
        Lives = numLives.Value
        infoList(0) = "Changes the rate at which your parachutist drops"
        infoList(1) = "Changes the right at which your parachutist flies from side to side"
        infoList(2) = "Changes the rate at which helicopters move"
        infoList(3) = "Changes how long Arcade mode lasts for"
        infoList(4) = "Changes how many lives your character has"
        infoList(5) = "Mute's all in game audio"
        infoList(6) = "Disables all powerups for a more vanilla experience"
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub muteOption_MouseHover(sender As Object, e As EventArgs) Handles muteOption.MouseHover
        optionInfoBox.Text = infoList(5)
    End Sub

    Private Sub numDropSpeed_MouseHover(sender As Object, e As EventArgs) Handles numDropSpeed.MouseHover
        optionInfoBox.Text = infoList(0)
    End Sub

    Private Sub numCharSpeed_MouseHover(sender As Object, e As EventArgs) Handles numCharSpeed.MouseHover
        optionInfoBox.Text = infoList(1)
    End Sub

    Private Sub numEnSpeed_MouseHover(sender As Object, e As EventArgs) Handles numEnSpeed.MouseHover
        optionInfoBox.Text = infoList(2)
    End Sub

    Private Sub numLength_MouseHover(sender As Object, e As EventArgs) Handles numLength.MouseHover
        optionInfoBox.Text = infoList(3)
    End Sub

    Private Sub numLives_MouseHover(sender As Object, e As EventArgs) Handles numLives.MouseHover
        optionInfoBox.Text = infoList(4)
    End Sub

    Private Sub disablePowerups_MouseHover(sender As Object, e As EventArgs) Handles disablePowerups.MouseHover
        optionInfoBox.Text = infoList(6)
    End Sub
End Class