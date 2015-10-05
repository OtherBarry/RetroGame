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
End Class