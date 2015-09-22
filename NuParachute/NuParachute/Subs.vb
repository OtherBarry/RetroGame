Module Subs
    Public Sub Reset()
        Enemies.Clear()
        Backgrounds.Clear()
        DeciSeconds = 0
        Player.Reset()
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
        'Dim DiffString As String
        'If Difficulty = 5 Then
        '    DiffString = "Very Easy"
        'ElseIf Difficulty = 4
        '    DiffString = "Easy"
        'ElseIf Difficulty = 2
        '    DiffString = "Hard"
        'ElseIf Difficulty = 1
        '    DiffString = "Very Hard"
        'Else
        '    DiffString = "Medium"
        'End If
        'playMenuForm.lblDifficulty.Text = "Current Difficulty = " + DiffString
        'playMenuForm.lblDifficulty.Left = (Main.Width / 2) - (playMenuForm.lblDifficulty.Width / 2)
    End Sub
End Module
