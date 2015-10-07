Public Class Game
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Stop()
        GameState = "Active"
        DeciSecond.Enabled = True
        EnemySpawn.Enabled = True
        Tick.Enabled = True
        DoubleBuffered = True
        If GameMode = "Campaign" Then
            Level = 1
            Lives = 1
            Seconds = 18
            ScrollSpeed = 1
            Difficulty = 1
            speedActive = False
            freezeActive = False
            invincibleActive = False
        End If
        DifficultyChange()
        Enemies.Add(New Enemy("Helicopter"))
        Backgrounds.Add(New Background("Cloud"))
        If speedActive = True Then
            Powerups.Add(New Powerup("Speed"))
        End If
        If freezeActive = True Then
            Powerups.Add(New Powerup("Freeze"))
        End If
        If invincibleActive = True Then
            Powerups.Add(New Powerup("Invincibility"))
        End If

    End Sub
    Private Sub Game_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P Then
            If GameState = "Active" Then
                GameState = "Paused"
            ElseIf GameState = "Paused"
                GameState = "Active"
            End If
            StateCheck()
        End If
        If e.KeyCode = Keys.Escape Then
            If GameState IsNot "Active" Then
                If GameMode = "Campaign" Then
                    Level = 1
                    Lives = 1
                    Seconds = 16.8
                    ScrollSpeed = 1
                    Difficulty = 1
                    speedActive = False
                    freezeActive = False
                    invincibleActive = False
                    DifficultyChange()
                End If
                Reset()
            End If

        End If
        If e.KeyCode = Keys.Space Then
            If GameState = "Win" Then
                Select Case Level
                    Case 1
                        Seconds = 21.84
                        ScrollSpeed = 1.25
                        Difficulty = 2
                        speedActive = True

                    Case 2
                        Seconds = 26.88
                        ScrollSpeed = 1.5
                        Difficulty = 3

                    Case 3
                        Seconds = 31.92
                        ScrollSpeed = 1.75
                        Difficulty = 4
                        freezeActive = True
                    Case 4
                        Seconds = 36.96
                        ScrollSpeed = 2
                        Difficulty = 5
                    Case 5
                        Seconds = 42
                        ScrollSpeed = 2.25
                        Difficulty = 6
                        invincibleActive = True
                    Case 6
                        Seconds = 47.04
                        ScrollSpeed = 2.5
                        Difficulty = 7
                    Case 7
                        Seconds = 52.08
                        ScrollSpeed = 2.75
                        Difficulty = 8
                    Case 8
                        Seconds = 57.12
                        ScrollSpeed = 3
                        Difficulty = 9
                    Case 9
                        Seconds = 60.48
                        ScrollSpeed = 3
                        Difficulty = 10
                End Select
                Level += 1
                Lives += 1
                DifficultyChange()
                If Level > 10 Then
                    txtPaused.Text = "Campaign Completed"
                Else
                    Reset()
                End If


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
            If DeciSeconds / 10 >= Seconds - (16.8 / ScrollSpeed) Then
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
        LiveCheck()
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

    Private Sub txtPaused_Click(sender As Object, e As EventArgs) Handles txtPaused.Click

    End Sub

    Private Sub exitTutorialBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
        Main.Show()
    End Sub
End Class
