Public Class screenMain

    Private Sub screenMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Left/Right controls
        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            'Check that it's on screen
            If Character.Left < Me.Width - 14 Then
                Character.Left = Character.Left + 2
            End If
        ElseIf e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            'Check that it's on screen
            If Character.Left > 0 Then
                Character.Left = Character.Left - 2
            End If
        End If
    End Sub

    Private Sub screenMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        timeScroll.Enabled = True
    End Sub
    'This sub will handle object scrolling,
    'as I imagine it'll be better to have all the enemies scroll
    'rather than the player, as otherwise it'll be too short
    Private Sub timeScroll_Tick(sender As Object, e As EventArgs) Handles timeScroll.Tick
        Character.Top = Character.Top + 2
    End Sub
End Class
