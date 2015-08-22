Module Classes
    'This is where we run the stuff specific to each individual object

    Public Class Enemy
        'Variables
        Private Helicopter As Boolean
        Private Enemy2 As Boolean
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Private HorizontalSpeed As Integer
        Private FromLeft As Boolean = True
        Private Exist As Boolean = True
        'End Variables
        'This sub is run whenever a new enemy is created
        Public Sub New(ByVal Type As String)
            Randomize()
            Dim random As Integer = CInt(Math.Floor((2 - 1 + 1) * Rnd())) + 2 ' This randomly generates a 1 or a 2, which determines the direction the enemy comes from
            If Type = "Helicopter" Then
                Image = My.Resources.HelicopterSmall
                Height = Image.Height * 3
                Width = Image.Width * 3
                Top = CInt(Math.Floor(((Game.Height - 64 - Height) - (64 + Height) + 1) * Rnd())) + (64 + Height)
                HorizontalSpeed = 4
                If random = 2 Then
                    FromLeft = False
                End If
                If FromLeft = True Then
                    Left = 0 - Width
                Else
                    Left = Game.Width + Width
                    Width = -Width 'This is the ghetto way of flipping images 
                End If
                'Once we have more enemies, there will be many more elseIf's here
            End If

        End Sub

        Public Sub Move()
            If GameScroll = True Then
                Top -= ScrollSpeed
            End If
            If FromLeft = True Then
                Left += HorizontalSpeed
            Else
                Left -= HorizontalSpeed
            End If
        End Sub

        Public Sub CollisionDetect()
            If Exist = True Then 'Ensures that the enemy in question is classified as existing
                If FromLeft = True Then 'due to the ghetto image flipping, we have to have 2 very similar lines of code
                    If (Game.Character.Left + Game.Character.Width) > Left And Game.Character.Left < (Left + Width) And (Game.Character.Top + Game.Character.Height) > Top And Game.Character.Top < (Top + Height) Then
                        Collision = True
                        Lives -= 1
                        Width = 0
                        Height = 0
                        Exist = False
                    End If
                Else
                    If (Game.Character.Left + Game.Character.Width) > (Left + Width) And Game.Character.Left < Left And (Game.Character.Top + Game.Character.Height) > Top And Game.Character.Top < (Top + Height) Then
                        Collision = True
                        Lives -= 1
                        Width = 0
                        Height = 0
                        Exist = False
                    End If
                End If
            End If

            If Game.Character.Top >= Game.Height - 64 - Game.Character.Height Then 'If your dude hits the bottom you win
                GameWin = True
            End If
        End Sub

        Public Sub Draw(e As PaintEventArgs) 'This sub actually draws the enemies
            e.Graphics.DrawImage(Image, Left, Top, Width, Height)
        End Sub

    End Class

    Public Class Background
        'Start Variables
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Private Exist As Boolean = True
        'End variables
        Public Sub New(ByVal Type As String)
            If Type = "Cloud" Then
                Image = My.Resources.pixelCloudV2
                Height = 0
                Width = 0
                Top = Game.Height + Height - 64
                Exist = False
                Randomize()
                Dim random As Integer = CInt(Math.Floor(((5 - 1) + 1) * Rnd())) + 5 'randomly decides wether a cloud should be generated or not. Currently set to about 20% clouds. Or it might be 50/50, not quite sure how the maths works
                If DeciSeconds Mod random = 0 Then
                    Height = My.Resources.pixelCloudV2.Height * 3
                    Width = My.Resources.pixelCloudV2.Width * 3
                    Exist = True
                End If
                Randomize()
                Left = CInt(Math.Floor(((Game.Width - Width) - (0) + 1) * Rnd())) + (0)
            End If
        End Sub
        Public Sub Draw(e As PaintEventArgs)
            e.Graphics.DrawImage(Image, Left, Top, Width, Height)
        End Sub
        Public Sub Move()
            If GameScroll = True And Exist = True Then
                Top -= ScrollSpeed
            End If
        End Sub
    End Class

    Public Class Powerup
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Private Type As String
        Private Exist As Boolean = True

        Public Sub New(ByVal pType As String)
            If pType = "Speed" Then
                Type = "Speed"
                Image = My.Resources.Speed
                Width = 50
                Height = 50
                Top = 0
                Left = 0
            End If
        End Sub

        Public Sub Move()
            If DeciSeconds Mod 50 = 0 Then
                Top = CInt(Math.Floor((576 - 128 + 1) * Rnd())) + 128
                Left = CInt(Math.Floor((608 - 32 + 1) * Rnd())) + 32
                If Speed = True Then
                    Speed = False
                End If
                If Exist = False Then
                    Width = 50
                    Height = 50
                End If
            End If
            If GameScroll = True Then
                Top -= ScrollSpeed
            End If
        End Sub

        Public Sub CollisionDetect()
            If (Game.Character.Left + Game.Character.Width) > Left And Game.Character.Left < (Left + Width) And (Game.Character.Top + Game.Character.Height) > Top And Game.Character.Top < (Top + Height) Then
                Width = 0
                Height = 0
                Exist = False
                Speed = True
            End If
        End Sub

        Public Sub Draw(e As PaintEventArgs)
            e.Graphics.DrawImage(Image, Left, Top, Width, Height)
        End Sub
    End Class

    Public Class Parachuter
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Private HorizontalSpeed As Integer
        Public Sub New()
            Image = My.Resources.ParachuterSmall
            Height = Image.Height * 3
            Width = Image.Width * 3
            Top = 80
            Left = (Game.Width / 2) / (Width / 2)
        End Sub
        Public Sub Move()
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
                Game.Character.Top += ScrollSpeed
            End If
        End Sub
        Public Sub Draw(e As PaintEventArgs)
            e.Graphics.DrawImage(Image, Left, Top, Width, Height)
        End Sub
    End Class

End Module
