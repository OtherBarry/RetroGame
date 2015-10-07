Module Classes
    Public Class Enemy
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Private HorizontalSpeed As Integer
        Private FromLeft As Boolean = True
        Private Exist As Boolean = True
        Private Type As String
        Private random As Integer
        Public Sub New(ByVal Kind As String)
            Type = Kind
            If Type = "Helicopter" Then
                Image = My.Resources.HelicopterSmall
                Height = Image.Height * 3
                Width = Image.Width * 3
                HorizontalSpeed = 4
            ElseIf Type = "Plane"
                Image = My.Resources.PlaneSmall
                Height = 36
                Width = 75
                HorizontalSpeed = 8
            End If
            Randomize()
            Top = CInt(Math.Floor(((Game.Height - 64 - Height) - (64 + Height) + 1) * Rnd())) + (64 + Height)
            Randomize()
            random = CInt(Math.Floor((2 - 1 + 1) * Rnd())) + 2
            If random = 2 Then
                FromLeft = False
                Left = Game.Width + Width
                Width = -Width
            Else
                Left = 0 - Width
            End If
        End Sub
        Public Sub Move()
            If GameScroll = True Then
                Top -= ScrollSpeed
            End If
            If Player.Freeze = False Then
                If FromLeft = True Then
                    Left += HorizontalSpeed
                Else
                    Left -= HorizontalSpeed
                End If
            End If
            CollisionDetect()
        End Sub
        Private Sub CollisionDetect()
            If Exist = True Then
                If Type = "Helicopter" Then
                    If FromLeft = True Then
                        If Player.Hitbox.IntersectsWith(New Rectangle(Left + 33, Top, Width - 33, Height)) Or Player.Hitbox.IntersectsWith(New Rectangle(Left, Top + 14, 33, 15)) Then
                            Collide()
                        End If
                    Else
                        If Player.Hitbox.IntersectsWith(New Rectangle(Left + Width, Top, -Width - 33, Height)) Or Player.Hitbox.IntersectsWith(New Rectangle(Left - 33, Top + 14, 33, 15)) Then
                            Collide()
                        End If
                    End If
                ElseIf Type = "Plane"
                    If FromLeft = True Then
                        If Player.Hitbox.IntersectsWith(New Rectangle(Left, Top + 12, Width - 6, 12)) Or Player.Hitbox.IntersectsWith(New Rectangle(Left + 3, Top, 12, 30)) Or Player.Hitbox.IntersectsWith(New Rectangle(Left + 18, Top + 24, 27, 12)) Then
                            Collide()
                        End If
                    Else
                        If Player.Hitbox.IntersectsWith(New Rectangle(Left + Width + 6, Top + 12, -Width - 6, 12)) Or Player.Hitbox.IntersectsWith(New Rectangle(Left + Width + 60, Top, 12, 30)) Or Player.Hitbox.IntersectsWith(New Rectangle(Left + Width + 30, Top + 24, 27, 12)) Then
                            Collide()
                        End If
                    End If
                End If
            End If
        End Sub
        Private Sub Collide()
            If Player.Invincible = False Then
                Lives -= 1
                Exist = False
                Player.Invincible = True
                My.Computer.Audio.Play(My.Resources.Explosion, AudioPlayMode.Background)
            End If
        End Sub
        Public Sub Draw(e As PaintEventArgs)
            If Exist = True Then
                e.Graphics.DrawImage(Image, Left, Top, Width, Height)
                If DrawHitboxes = True Then
                    If Type = "Helicopter" Then
                        If FromLeft = True Then
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + 33, Top, Width - 33, Height))
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left, Top + 14, 33, 15))
                        Else
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + Width, Top, -Width - 33, Height))
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left - 33, Top + 14, 33, 15))
                        End If
                    ElseIf Type = "Plane"
                        If FromLeft = True Then
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left, Top + 12, Width - 6, 12))
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + 3, Top, 12, 30))
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + 18, Top + 24, 27, 12))
                        Else
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + Width + 6, Top + 12, -Width - 6, 12))
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + Width + 60, Top, 12, 30))
                            e.Graphics.DrawRectangle(Pens.Red, New Rectangle(Left + Width + 30, Top + 24, 27, 12))
                        End If
                    End If
                End If
            End If
        End Sub
    End Class
    Public Class Background
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer = 20
        Private Width As Integer = 40
        Private Exist As Boolean = True
        Private random As Integer
        Public Sub New(ByVal Type As String)
            If Type = "Cloud" Then
                Image = My.Resources.Cloud
                Top = Game.Height + Height - Game.PictureBox2.Height
                Exist = False
                Randomize()
                random = CInt(Math.Floor(((5 - 1) + 1) * Rnd())) + 5 'randomly decides wether a cloud should be generated or not. Currently set to about 20% clouds. Or it might be 50/50, not quite sure how the maths works
                If DeciSeconds Mod random = 0 Then
                    Exist = True
                End If
                Randomize()
                Left = CInt(Math.Floor(((Game.Width - Width) - (0) + 1) * Rnd())) + (0)
            End If
        End Sub
        Public Sub Draw(e As PaintEventArgs)
            If Exist = True Then
                e.Graphics.DrawImage(Image, Left, Top, Width, Height)
            End If
        End Sub
        Public Sub Move()
            If GameScroll = True And Exist = True Then
                Top -= ScrollSpeed
            End If
            CollisionDetect()
        End Sub
        Private Sub CollisionDetect()
            If Top < Game.PictureBox1.Height - Height Then
                Exist = False
            End If
        End Sub
    End Class
    Public Class Powerup
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Public Type As String
        Private Exist As Boolean = True
        Public Sub New(ByVal pType As String) 'Attempted to apply option menu setting here but failed. See if you can figure it out.
            Type = pType
            Width = 30
            Select Case Type
                Case "Speed"
                    Image = My.Resources.Speed
                    Width = 16
                Case "Invincibility"
                    Image = My.Resources.invincibility
                    Player.Invincible = True
                Case "Freeze"
                    Image = My.Resources.Freeze
            End Select
            Height = 30
            Randomize()
            Top = CInt(Math.Floor((576 - 128 + 1) * Rnd())) + 128
            Left = CInt(Math.Floor((608 - 32 + 1) * Rnd())) + 32

        End Sub
        Public Sub Move()
            If GameScroll = True Then
                Top -= ScrollSpeed
            End If
            CollisionDetect()
        End Sub
        Public Sub Respawn()
            Randomize()
            Top = CInt(Math.Floor((576 - 128 + 1) * Rnd())) + 128
            Left = CInt(Math.Floor((608 - 32 + 1) * Rnd())) + 32
        End Sub
        Public Sub CollisionDetect()
            If Player.Hitbox.IntersectsWith(New Rectangle(Left, Top, Width, Height)) Then
                Exist = False
                If Type = "Speed" Then
                    Player.Speed = True
                    My.Computer.Audio.Play(My.Resources.Speed1, AudioPlayMode.Background)
                ElseIf Type = "Invincibility" Then
                    Player.Invincible = True
                    My.Computer.Audio.Play(My.Resources.Invincibility1, AudioPlayMode.Background)
                ElseIf Type = "Freeze" Then
                    Player.Freeze = True
                    My.Computer.Audio.Play(My.Resources.Freeze1, AudioPlayMode.Background)
                End If
            End If
            If Exist = True And Top < Game.PictureBox1.Height - Height Then
                Respawn()
            ElseIf Exist = False And Player.Speed = False And Player.Invincible = False And Player.Freeze = False Then
                Exist = True
                Respawn()
            End If
        End Sub
        Public Sub Draw(e As PaintEventArgs)
            If Exist = True Then
                e.Graphics.DrawImage(Image, Left, Top, Width, Height)
            End If
        End Sub
    End Class
    Public Class Parachuter
        Public Image As Image
        Public Top As Integer
        Public Left As Integer
        Public Height As Integer
        Public Width As Integer
        Public HorizontalSpeed As Integer = 3
        Public Invincible As Boolean = False
        Private InvincTime As Integer = 0
        Public Speed As Boolean = False
        Private SpeedTime As Integer = 0
        Private Visible As Boolean = True
        Public Freeze As Boolean = False
        Public freezeTime As Integer = 0
        Public Hitbox As New Rectangle
        Public Sub New()
            Image = My.Resources.ParachuterSmall
            Height = Image.Height * 3
            Width = Image.Width * 3
            Top = 80
            Left = (Game.Width / 2) - (Width / 2)
            Hitbox = New Rectangle(Left, Top, Width, Height)
        End Sub
        Public Sub Move()
            If GetKeyState(65) < 0 OrElse GetKeyState(37) < 0 Then
                If Left > 0 Then
                    Left -= HorizontalSpeed
                End If
            End If
            If GetKeyState(68) < 0 OrElse GetKeyState(39) < 0 Then
                If Left < (Game.Width - 21) Then
                    Left += HorizontalSpeed
                End If
            End If
            If GameScroll = False Then
                Top += ScrollSpeed
            End If
            Hitbox = New Rectangle(Left, Top, Width, Height)
            CollisionDetect()
        End Sub
        Private Sub CollisionDetect()
            If Hitbox.IntersectsWith(New Rectangle(Game.PictureBox2.Left, Game.PictureBox2.Top, Game.PictureBox2.Width, Game.PictureBox2.Height)) Then
                GameState = "Win"
            End If
        End Sub
        Public Sub Draw(e As PaintEventArgs)
            e.Graphics.DrawImage(Image, Left, Top, Width, Height)
            If DrawHitboxes = True Then
                e.Graphics.DrawRectangle(Pens.Red, Hitbox)
            End If
        End Sub
        Public Sub Reset()
            Top = 80
            Left = (Game.Width / 2) - (Width / 2)
        End Sub
        Public Sub Time()
            If Invincible = True Then
                InvincTime += 1
                If Visible = True Then
                    Visible = False
                Else
                    Visible = True
                End If
                If InvincTime > 20 Then
                    InvincTime = 0
                    Invincible = False
                    Visible = True
                End If
            Else
                Visible = True
            End If
            If Speed = True Then
                HorizontalSpeed = 6
                SpeedTime += 1
                If SpeedTime > 30 Then
                    SpeedTime = 0
                    Speed = False
                End If
            Else
                HorizontalSpeed = 3
            End If
            If Freeze = True Then
                freezeTime += 1
                If freezeTime > 30 Then
                    freezeTime = 0
                    Freeze = False
                End If
            End If
            If Visible = True Then
                Height = Image.Height * 3
                Width = Image.Width * 3
            Else
                Height = 0
                Width = 0
            End If
        End Sub
    End Class
End Module