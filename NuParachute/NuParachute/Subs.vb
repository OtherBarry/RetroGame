Module Subs
    Public Sub Reset()
        Enemies.Clear()
        DeciSeconds = 0
        Game.Character.Top = 75
        Game.Character.Left = 310
        Lives = 3
        GameScroll = True
        Collision = False
        GameWin = False
        Pause()
    End Sub
    Public Sub Pause()
        If Paused = False Then
            Game.DeciSecond.Enabled = False
            Game.Tick.Enabled = False
            Game.Milli.Enabled = False
            Paused = True
            Game.txtPaused.Visible = True
            If GameWin = True Then
                Game.txtPaused.Text = "You Win"
            ElseIf Collision = True
                Game.txtPaused.Text = "You Lose"
            Else
                Game.txtPaused.Text = "Paused"
            End If
        Else
            Game.DeciSecond.Enabled = True
            Game.Tick.Enabled = True
            Game.Milli.Enabled = True
            Paused = False
            Game.txtPaused.Visible = False
        End If

    End Sub
    Public Sub LabelUpdate()
        Game.txtLives.Text = "Lives : " + Lives.ToString
        Game.txtLives.Left = Game.Width - Game.txtLives.Width - 17
        Game.txtTime.Text = "Time : " + (DeciSeconds / 10).ToString + " s"
        Game.txtTime.Left = Game.Width - Game.txtTime.Width - 17
        Dim DiffString As String
        If Difficulty = 5 Then
            DiffString = "Very Easy"
        ElseIf Difficulty = 4
            DiffString = "Easy"
        ElseIf Difficulty = 2
            DiffString = "Hard"
        ElseIf Difficulty = 1
            DiffString = "Very Hard"
        Else
            DiffString = "Medium"
        End If
        Menu.lblDifficulty.Text = "Current Difficulty = " + DiffString
        Menu.lblDifficulty.Left = (Menu.Width / 2) - (Menu.lblDifficulty.Width / 2)
    End Sub

    Public Sub CharacterMove()
        If GetKeyState(65) < 0 OrElse GetKeyState(37) < 0 Then
            If Game.Character.Left > 0 Then
                Game.Character.Left -= CharacterMoveSpeed
            End If
        End If
        If GetKeyState(68) < 0 OrElse GetKeyState(39) < 0 Then
            If Game.Character.Left < (Game.Width - Game.Character.Width) Then
                Game.Character.Left += CharacterMoveSpeed
            End If
        End If
        If GameScroll = False Then
            Game.Character.Top += CharacterDropSpeed
        End If
    End Sub
    Public Sub Collide()


    End Sub
End Module
