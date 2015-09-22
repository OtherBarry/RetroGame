Public Class Game
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        Enemies.Add(New Enemy("Helicopter"))
        Backgrounds.Add(New Background("Cloud"))
        Powerups.Add(New Powerup("Speed"))
        Powerups.Add(New Powerup("Invincibility"))
        Powerups.Add(New Powerup("Freeze"))
        DeciSecond.Enabled = True
        Tick.Enabled = True
        Milli.Enabled = True
        DoubleBuffered = True
    End Sub
    Private Sub Game_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P Then
            Pause()
        End If
        If e.KeyCode = Keys.Escape And Paused = True Then
            Reset()
        End If
    End Sub
    Private Sub DeciSecond_Tick(sender As Object, e As EventArgs) Handles DeciSecond.Tick
        DeciSeconds += 1
        Backgrounds.Add(New Background("Cloud"))
        If DeciSeconds Mod (Difficulty * 6) = 0 Then
            Enemies.Add(New Enemy("Helicopter"))
        End If
        If DeciSeconds Mod (Difficulty * 30) = 0 Then
            Enemies.Add(New Enemy("Plane"))
        End If
        If DeciSeconds / 10 >= Seconds - 8.4 Then
            GameScroll = False
        End If
        Player.Time()
    End Sub

    Private Sub Draw(sender As Object, e As PaintEventArgs) Handles Me.Paint
        For Each bg As Background In Backgrounds
            bg.Draw(e)
        Next
        For Each pu As Powerup In Powerups
            pu.Draw(e)
        Next
        For Each en As Enemy In Enemies
            en.Draw(e)
        Next
        Player.Draw(e)
        LabelUpdate()
    End Sub

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles Tick.Tick
        For Each en As Enemy In Enemies
            en.Move()
        Next
        For Each bg As Background In Backgrounds
            bg.Move()
        Next
        For Each pu As Powerup In Powerups
            pu.Move()
        Next
        Player.Move()
        Invalidate()
        If GameWin = True Then
            Pause()
        End If
        If Collision = True And Lives = -1 Then
            Pause()
        End If
    End Sub

    Private Sub Game_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        DeciSecond.Enabled = False
        Milli.Enabled = False
        Tick.Enabled = False
        Paused = True
        txtPaused.Visible = True
        If GameWin = True Then
            txtPaused.Text = "You Win"
        ElseIf Collision = True
            txtPaused.Text = "You Lose"
        Else
            txtPaused.Text = "Paused"
        End If
    End Sub
End Class
