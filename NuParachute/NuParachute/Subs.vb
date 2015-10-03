﻿Module Subs
    Public Sub Reset()
        Enemies.Clear()
        Powerups.Clear()
        Backgrounds.Clear()
        Enemies.Add(New Enemy("Helicopter"))
        Powerups.Add(New Powerup("Speed"))
        Powerups.Add(New Powerup("Invincibility"))
        Powerups.Add(New Powerup("Freeze"))
        DeciSeconds = 0
        Player.Reset()
        Lives = 3
        GameScroll = True
        GameState = "Active"
        StateCheck()
    End Sub
    Public Sub StateCheck()
        Select Case GameState
            Case "Paused"
                Game.DeciSecond.Enabled = False
                Game.Tick.Enabled = False
                Game.EnemySpawn.Enabled = False
                Game.txtPaused.Visible = True
                Game.txtPaused.Text = "Paused"
            Case "Lose"
                Game.DeciSecond.Enabled = False
                Game.Tick.Enabled = False
                Game.EnemySpawn.Enabled = False
                Game.txtPaused.Visible = True
                If GameMode = "Endless" Then
                    Game.txtPaused.Text = "You Survived " + (DeciSeconds / 10).ToString + "s"
                Else
                    Game.txtPaused.Text = "You Lose"
                End If
                Lives = 0
            Case "Win"
                Game.DeciSecond.Enabled = False
                Game.Tick.Enabled = False
                Game.EnemySpawn.Enabled = False
                Game.txtPaused.Visible = True
                Game.txtPaused.Text = "You Win"
            Case Else
                Game.DeciSecond.Enabled = True
                Game.Tick.Enabled = True
                Game.EnemySpawn.Enabled = True
                Game.txtPaused.Visible = False
        End Select
        Game.txtPaused.Left = (Game.Width / 2) - (Game.txtPaused.Width / 2)
    End Sub
    Public Sub LabelUpdate()
        Game.txtTime.Text = "Time : " + (DeciSeconds / 10).ToString + " s"
        Game.txtTime.Left = Game.Width - Game.txtTime.Width - 17
        Game.txtLevel.Text = "Level : " + Difficulty.ToString
        LiveCheck()
    End Sub
    Public Sub LiveCheck()
        Select Case Lives
            Case < 1
                For i As Integer = 0 To 9
                    LiveArray(i).Visible = False
                Next
            Case < 10
                For i As Integer = 0 To Lives - 1
                    LiveArray(i).Visible = True
                Next
                For i As Integer = Lives To 9
                    LiveArray(i).Visible = False
                Next
            Case Else
                Lives = 10
                For i As Integer = 0 To 9
                    LiveArray(i).Visible = True
                Next
        End Select
    End Sub
    Public Sub LevelUp()
        Game.DeciSecond.Enabled = False
        Game.Tick.Enabled = False
        Game.txtPaused.Visible = True
        Game.txtPaused.Text = "Completed Level " + Level.ToString
    End Sub
    Public Sub DifficultyChange()
        Game.EnemySpawn.Interval = 8192 / (2 * Difficulty)
    End Sub
    Public Sub ColourShift()
        Dim red As Integer
        Dim blue As Integer
        Dim green As Integer
        If DeciSeconds < 51 Then
            red = DeciSeconds * 2
            green = DeciSeconds * 3
            blue = DeciSeconds * 5
        Else
            red = 102
            green = 152
            blue = 255
        End If
        Game.BackColor = Color.FromArgb(red, green, blue)
    End Sub

End Module
