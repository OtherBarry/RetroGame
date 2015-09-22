Public Class Main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        playMenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Options.Show()
        Me.Hide()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim message = "Do you want to exit?"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(message, style)
        If response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click
        Me.Hide()
        tutorialMenu.Show()
    End Sub
End Class