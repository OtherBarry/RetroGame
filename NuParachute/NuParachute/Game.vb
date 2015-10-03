Public Class Game
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        GameState = "Active"
        Enemies.Add(New Enemy("Helicopter"))
        Backgrounds.Add(New Background("Cloud"))
        Powerups.Add(New Powerup("Speed"))
        Powerups.Add(New Powerup("Invincibility"))
        Powerups.Add(New Powerup("Freeze"))
        DeciSecond.Enabled = True
        EnemySpawn.Enabled = True
        Tick.Enabled = True
        DoubleBuffered = True
        DifficultyChange()
    End Sub
    Private Sub Game_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P Then
            If GameState = "Active" Then
                GameState = "Paused"
            Else
                GameState = "Active"
            End If
            StateCheck()
        End If
        If e.KeyCode = Keys.Escape Then
            If GameState = "Win" Or GameState = "Lose" Or GameState = "Paused" Then
                Reset()
            End If
        End If
    End Sub
    Private Sub EnemySpawn_Tick(sender As Object, e As EventArgs) Handles EnemySpawn.Tick
        ESCounter += 1
        If ESCounter Mod 5 = 0 Then
            Enemies.Add(New Enemy("Plane"))
        Else
            Enemies.Add(New Enemy("Helicopter"))
        End If
    End Sub
    Private Sub DeciSecond_Tick(sender As Object, e As EventArgs) Handles DeciSecond.Tick
        DeciSeconds += 1
        Backgrounds.Add(New Background("Cloud"))
        If GameMode = "Arcade" Or GameMode = "Campaign" Then
            If DeciSeconds / 10 >= Seconds - 8.4 Then
                GameScroll = False
            End If
        End If
        Player.Time()
    End Sub
    Private Sub Draw(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ColourShift()
        For Each bg As Background In Backgrounds
            bg.Move()
            bg.Draw(e)
        Next
        For Each pu As Powerup In Powerups
            pu.Move()
            pu.Draw(e)
        Next
        For Each en As Enemy In Enemies
            en.Move()
            en.Draw(e)
        Next
        Player.Move()
        Player.Draw(e)
        LabelUpdate()
    End Sub
    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles Tick.Tick
        Invalidate()
        If Lives = -1 Then
            GameState = "Lose"
        End If
        StateCheck()
    End Sub
    Private Sub Game_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        GameState = "Paused"
        StateCheck()
    End Sub

    Private Sub txtTitle_Click(sender As Object, e As EventArgs) Handles txtTitle.Click
        Me.Close()
        Main.Show()
    End Sub
End Class
