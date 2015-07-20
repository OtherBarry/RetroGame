Public Class screenMain
    'Input Response Sub
    Private Sub screenMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If GameActive = True Then
                GameOver()
            End If
            GameReset()
        ElseIf e.KeyCode = Keys.P And GameActive = True Then
            If timeCopterGen.Enabled = True Or timeScroll.Enabled = True Then
                timeCopterGen.Enabled = False
                timeScroll.Enabled = False
            Else
                timeCopterGen.Enabled = True
                timeScroll.Enabled = True
            End If
        End If
    End Sub

    Private Sub screenMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        timeScroll.Enabled = True
        timeCopterGen.Enabled = True
    End Sub
    'This sub will handle object scrolling,
    'as I imagine it'll be better to have all the enemies scroll
    'rather than the player, as otherwise it'll be too short
    Private Sub timeScroll_Tick(sender As Object, e As EventArgs) Handles timeScroll.Tick
        'Entity Movment
        Counter2 = Counter2 + 1
        For i As Integer = 1 To CopterCount
            If i Mod 2 = 0 Then
                Copters(i).Left += HelicopterMoveSpeed
            Else
                Copters(i).Left = Copters(i).Left - HelicopterMoveSpeed
            End If
            If GameActive = True Then
                Copters(i).BringToFront()
            End If
        Next
        If GameScroll = True Then
            For i As Integer = 1 To CopterCount
                Copters(i).Top -= CharacterDropSpeed
            Next
            For i As Integer = 1 To CloudCount
                Clouds(i).Top -= CharacterMoveSpeed
            Next
            If WindCount > 0 Then
                Winds(WindCount).Top -= CharacterDropSpeed
            End If
        Else
            If GameActive = True Then
                Character.Top = Character.Top + CharacterDropSpeed
            End If
        End If
        'Left/Right controls
        If GetKeyState(65) < 0 OrElse GetKeyState(37) < 0 Then
            If Character.Left > 0 Then
                Character.Left -= CharacterMoveSpeed
            End If
        End If
        If GetKeyState(68) < 0 OrElse GetKeyState(39) < 0 Then
            If Character.Left < (Me.Width - Character.Width) Then
                Character.Left += CharacterMoveSpeed
            End If
        End If
        'Collision Detection
        For i As Integer = 1 To CopterCount
            If (Character.Left + Character.Width) > Copters(i).Left And Character.Left < (Copters(i).Left + Copters(i).Width) And (Character.Top + Character.Height) > Copters(i).Top And Character.Top < (Copters(i).Top + Copters(i).Height) Then
                LoadScreenLabel.Text = "You Lose"
                LoadScreenCountdown.Text = "Press Escape To Restart"
                GameActive = False
                GameOver()
            End If
        Next
        If Character.Top = Me.Height - Character.Height Then
            LoadScreenLabel.Text = "You Win!"
            LoadScreenCountdown.Text = "Press Escape To Restart"
            GameActive = False
            GameOver()
        End If
        If WindCount > 0 Then
            If (Character.Top + Character.Height) > Winds(WindCount).Top And Character.Top < (Winds(WindCount).Top + Winds(WindCount).Height) Then
                If WindCount Mod 2 = 0 And Winds(WindCount).Left - Character.Left < 80 Then
                    Character.Left = Character.Left - CharacterMoveSpeed * 2
                Else
                    If Character.Left - Winds(WindCount).Left < 80 Then
                        Character.Left = Character.Left + CharacterMoveSpeed * 2
                    End If
                End If
            End If
        End If
    End Sub
    ' This Sub Handles generating Entities
    Private Sub timeCopter_Tick(sender As Object, e As EventArgs) Handles timeCopterGen.Tick
        Counter += 1
        Countdown -= 1
        If Countdown = 0 Then
            Countdown = 5
            If GameActive = False Then
                LoadScreenPic.Visible = False
                LoadScreenLabel.Visible = False
                LoadScreenCountdown.Visible = False
                GameActive = True
            End If
        End If
        LoadScreenCountdown.Text = "Drop Zone in... " + Countdown.ToString
        CopterGen()
        CloudGen()
        CloudGen()
        WindGen()
        If GameLength <= Counter * 2 And GameActive = True Then
            GameScroll = False
        End If
    End Sub

End Class
