Public Class Options
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Main.Show()
    End Sub
    Private Sub btnHome_VisibleChanged(sender As Object, e As EventArgs) Handles btnHome.VisibleChanged
        btnHome.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        btnHome.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnHome.BackColor = Color.Transparent
    End Sub
    Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles disableLightningPwr.CheckedChanged, disableInvinciblePwr.CheckedChanged, disableTimePwr.CheckedChanged, muteOption.CheckedChanged
        If disableLightningPwr.Checked = True Then
            speedActive = False
        Else
            speedActive = True
        End If
        If disableTimePwr.Checked = True Then
            freezeActive = False
        Else
            freezeActive = True
        End If
        If disableInvinciblePwr.Checked = True Then
            invincibleActive = False
        Else
            invincibleActive = True
        End If
        If muteOption.Checked = True Then
            audioActive = False
        Else
            audioActive = True
        End If
    End Sub
    Private Sub gameLengthLbl_VisibleChanged(sender As Object, e As EventArgs) Handles gameLengthLbl.VisibleChanged
        gameLengthLbl.FlatStyle = Windows.Forms.FlatStyle.Flat
        gameLengthLbl.FlatAppearance.BorderSize = 0
        gameLengthLbl.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        gameLengthLbl.FlatAppearance.MouseOverBackColor = Color.LightBlue
        gameLengthLbl.BackColor = Color.Transparent
    End Sub
End Class