Public Class Game
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        Enemies.Add(New Enemy("Helicopter"))
        DeciSecond.Enabled = True
        Tick.Enabled = True
        Milli.Enabled = True
        DoubleBuffered = True
        Character.Top = 75
        Character.Left = (Me.Width / 2) - (Character.Width / 2)
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
        If DeciSeconds Mod (Difficulty * 5) = 0 Then
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
        If GameWin = True Then
            Pause()
        End If
    End Sub

    Private Sub Milli_Tick(sender As Object, e As EventArgs) Handles Milli.Tick
        Millis += 1
        If Collision = True Then
            If Lives > -1 Then
                DeciSecond.Enabled = False
                Tick.Enabled = False
                If Millis Mod 10 = 0 Then
                    If Counter < 6 Then
                        Counter += 1
                        If Character.Visible = True Then
                            Character.Visible = False
                        Else
                            Character.Visible = True
                        End If
                    Else
                        Collision = False
                        Counter = 0
                        DeciSecond.Enabled = True
                        Tick.Enabled = True
                    End If
                End If

            Else
                Pause()
            End If
        End If
    End Sub
End Class
