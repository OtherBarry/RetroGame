Public Class screenMain
    'Input Response Sub
    Private Sub screenMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Left/Right controls
        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            'Check that it's on screen
            If Character.Left < (Me.Width - Character.Width) Then
                Character.Left = Character.Left + CharacterMoveSpeed
            End If
        ElseIf e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            'Check that it's on screen
            If Character.Left > 0 Then
                Character.Left = Character.Left - CharacterMoveSpeed
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
        'Entity Movment
        Character.Top = Character.Top + CharacterDropSpeed
        Copter1.Left = Copter1.Left + HelicopterMoveSpeed
        'Collision Detection
        If (Character.Left + Character.Width) > Copter1.Left And Character.Left < (Copter1.Left + Copter1.Width) Then
            If (Character.Top + Character.Height) > Copter1.Top And Character.Top < (Copter1.Top + Copter1.Height) Then
                timeScroll.Enabled = False
                MsgBox("Game Over")
            End If
        End If
    End Sub
End Class
