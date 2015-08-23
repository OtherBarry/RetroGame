Public Class playMenuForm
    Public infoList(0 To 2) As String

    Private Sub arcadeBox_MouseDown(sender As Object, e As MouseEventArgs) Handles arcadeBox.MouseDown
        arcadeBox.DoDragDrop(arcadeBox.Text, DragDropEffects.Copy)
    End Sub

    Private Sub arcadeBox_MouseHover(sender As Object, e As EventArgs) Handles arcadeBox.MouseHover
        infoTextBox.Text = infoList(1)
    End Sub

    Private Sub campaignBox_MouseDown(sender As Object, e As MouseEventArgs) Handles campaignBox.MouseDown
        campaignBox.DoDragDrop(campaignBox.Text, DragDropEffects.Copy)
    End Sub

    Private Sub campaignBox_MouseHover(sender As Object, e As EventArgs) Handles campaignBox.MouseHover
        infoTextBox.Text = infoList(0)
    End Sub

    Private Sub endlessBox_MouseDown(sender As Object, e As MouseEventArgs) Handles endlessBox.MouseDown
        endlessBox.DoDragDrop(endlessBox.Text, DragDropEffects.Copy)
    End Sub

    Private Sub endlessBox_MouseHover(sender As Object, e As EventArgs) Handles endlessBox.MouseHover
        infoTextBox.Text = infoList(2)
    End Sub

    Private Sub gameSelectionBox_DragDrop(sender As Object, e As DragEventArgs) Handles gameSelectionBox.DragDrop
        gameSelectionBox.Text = e.Data.GetData(DataFormats.Text).ToString
        If gameSelectionBox.Text = "Arcade" Then
            Me.Close()
            Game.Show()
        End If
    End Sub

    Private Sub gameSelectionBox_DragEnter(sender As Object, e As DragEventArgs) Handles gameSelectionBox.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub playMenuForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' List for gamemode information
        infoList(0) = "Play the Parachute campaign! Defeat increasingly difficuly levels to beat this gamemode!"
        infoList(1) = "Play the original Parachute! Simply reach the bottom of the screen to win!"
        infoList(2) = "Play the endless Parachute! How long can you survive?"
    End Sub
    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click

    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click

    End Sub

    Private Sub gameSelectionBox_VisibleChanged(sender As Object, e As EventArgs) Handles gameSelectionBox.VisibleChanged
        gameSelectionBox.AllowDrop = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub playMenuReturnBtn_Click(sender As Object, e As EventArgs) Handles playMenuReturnBtn.Click
        Me.Close()
        Main.Show()
    End Sub
End Class