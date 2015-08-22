Public Class Options

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles Me.Load
        numCharSpeed.Value = CharacterMoveSpeed
        numDropSpeed.Value = ScrollSpeed
        numEnSpeed.Value = HelicopterMoveSpeed
        numLength.Value = Seconds
        numLives.Value = Lives
    End Sub

    Private Sub ValueChanged(sender As Object, e As EventArgs) Handles numCharSpeed.ValueChanged, numDropSpeed.ValueChanged, numEnSpeed.ValueChanged, numLength.ValueChanged, numLives.ValueChanged
        ScrollSpeed = numDropSpeed.Value
        CharacterMoveSpeed = numCharSpeed.Value
        HelicopterMoveSpeed = numEnSpeed.Value
        Seconds = numLength.Value
        Lives = numLives.Value
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Main.Show()
    End Sub

End Class