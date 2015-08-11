Module Classes

    Public Class Enemy
        'Variables
        Private Helicopter As Boolean
        Private Enemy2 As Boolean
        Private Image As Image
        Private Top As Integer
        Private Left As Integer
        Private Height As Integer
        Private Width As Integer
        Private FromLeft As Boolean = True
        Private Exist As Boolean = True
        'End Variables

        Public Sub New(Type)
            Randomize()
            Dim random As Integer = CInt(Math.Floor((2 - 1 + 1) * Rnd())) + 2
            If Type = "Helicopter" Then
                Image = My.Resources.HelicopterSmall
                Height = Image.Height * 3
                Width = Image.Width * 3
                Top = CInt(Math.Floor(((Game.Height - 64 - Height) - (64 + Height) + 1) * Rnd())) + (64 + Height)
                If random = 2 Then
                    FromLeft = False
                End If
                If FromLeft = True Then
                    Left = 0 - Width
                Else
                    Left = Game.Width + Width
                    Width = -Width
                End If
            End If

        End Sub

        Public Sub Move()
            If GameScroll = True Then
                Top -= CharacterDropSpeed
            End If
            If FromLeft = True Then
                Left += HelicopterMoveSpeed
            Else
                Left -= HelicopterMoveSpeed
            End If
        End Sub

        Public Sub CollisionDetect()
            If Exist = True Then
                If FromLeft = True Then
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

            If Game.Character.Top >= Game.Height - 64 - Game.Character.Height Then
                GameWin = True
            End If
        End Sub

        Public Sub Draw(e As PaintEventArgs)
            e.Graphics.DrawImage(Image, Left, Top, Width, Height)
        End Sub

        Public Sub Remove()

        End Sub
    End Class

    Public Class Background

    End Class

    Public Class Powerup

    End Class
End Module
