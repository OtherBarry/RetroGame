Public Class Game
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        Enemies.Add(New Enemy("Helicopter"))
        DeciSecond.Enabled = True
        Tick.Enabled = True
        DoubleBuffered = True
        Character.Top = 75
        Character.Left = (Me.Width / 2) - (Character.Width / 2)
    End Sub
    Private Sub Game_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P Then
            Pause()
        End If
    End Sub
    Private Sub DeciSecond_Tick(sender As Object, e As EventArgs) Handles DeciSecond.Tick
        DeciSeconds += 1
        If DeciSeconds Mod 20 = 0 Then
            Enemies.Add(New Enemy("Helicopter"))
        End If
        If DeciSeconds / 10 >= Seconds - 8.4 Then
            GameScroll = False
        End If

    End Sub

    Private Sub Draw(sender As Object, e As PaintEventArgs) Handles Me.Paint
        For Each en As Enemy In Enemies
            en.Draw(e)
        Next
        LabelUpdate()
    End Sub

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles Tick.Tick
        For Each en As Enemy In Enemies
            en.Move()
            en.CollisionDetect()
        Next
        Me.Invalidate()
        CharacterMove()
    End Sub
End Class
