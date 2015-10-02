Module Subs
    Public Sub Reset()
        Enemies.Clear()
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
                Game.txtPaused.Text = "You Lose"
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
    End Sub
    Public Sub LabelUpdate()
        Game.txtLives.Text = "Lives Remaining : " + Lives.ToString
        Game.txtLives.Left = Game.Width - Game.txtLives.Width - 17
        Game.txtTime.Text = "Time : " + (DeciSeconds / 10).ToString + " s"
        Game.txtTime.Left = Game.Width - Game.txtTime.Width - 17
        Game.txtLevel.Text = "Level : " + Difficulty.ToString
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

End Module
