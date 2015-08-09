Module Subs
    Public Sub Reset()

    End Sub
    Public Sub Pause()
        If Paused = False Then
            Game.DeciSecond.Enabled = False
            Game.Tick.Enabled = False
            Game.Spawn.Enabled = False
            Paused = True
            Game.txtPaused.Visible = True
        Else
            Game.DeciSecond.Enabled = True
            Game.Tick.Enabled = True
            Game.Spawn.Enabled = True
            Paused = False
            Game.txtPaused.Visible = False
        End If
    End Sub
    Public Sub LabelUpdate()
        Game.txtLives.Text = "Lives : " + Lives.ToString
        Game.txtLives.Left = Game.Width - Game.txtLives.Width - 17
        Game.txtTime.Text = "Time : " + (DeciSeconds / 10).ToString + " s"
        Game.txtTime.Left = Game.Width - Game.txtTime.Width - 17
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
End Module
