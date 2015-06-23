Public Class screenMain
    Dim Counter As Integer = 0
    'Input Response Sub
    Private Sub screenMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Left/Right controls
        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            'Check that it's on screen
            If Character.Left < (Me.Width - Character.Width) Then
                Character.Left = Character.Left + CharacterMoveSpeed
            End If
        ElseIf e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            'Check that it's on screen
            If Character.Left > 0 Then
                Character.Left = Character.Left - CharacterMoveSpeed
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
        Character.Top = Character.Top + CharacterDropSpeed
        For i As Integer = 1 To CopterCount
            Copters(i).Left += HelicopterMoveSpeed
        Next
        For i As Integer = 1 To CloudCount
            Clouds(i).Top -= CharacterMoveSpeed
        Next
        'Collision Detection
        For i As Integer = 1 To CopterCount
            If (Character.Left + Character.Width) > Copters(i).Left And Character.Left < (Copters(i).Left + Copters(i).Width) And (Character.Top + Character.Height) > Copters(i).Top And Character.Top < (Copters(i).Top + Copters(i).Height) Then
                timeScroll.Enabled = False
                MsgBox("Game Over")
            End If
        Next
        If Character.Top = Me.Height - Character.Height Then
            timeScroll.Enabled = False
            MsgBox("Congrations! You Done It!")
        End If
    End Sub
    ' This Sub Handles generating Entities
    Private Sub timeCopter_Tick(sender As Object, e As EventArgs) Handles timeCopterGen.Tick
        Randomize()
        Counter += 1
        'Copter Generation
        If Counter Mod 2 = 0 Then
            CopterCount += 1
            Copters(CopterCount) = New PictureBox
            Copters(CopterCount).Image = My.Resources.HelicoptereSmall
            Copters(CopterCount).Height = 26
            Copters(CopterCount).Width = 64
            Copters(CopterCount).SizeMode = PictureBoxSizeMode.StretchImage
            Copters(CopterCount).Top = CInt(Math.Floor((384 - 0 + 1) * Rnd())) + 0
            Copters(CopterCount).Left = -64
            Copters(CopterCount).Name = "Copter" + CopterCount.ToString
            Me.Controls.Add(Copters(CopterCount))
        End If
        'Cloud Generation
        CloudCount += 1
        Clouds(CloudCount) = New PictureBox
        Clouds(CloudCount).Image = My.Resources.pixelCloudV2
        Clouds(CloudCount).Height = 50
        Clouds(CloudCount).Width = 75
        Clouds(CloudCount).SizeMode = PictureBoxSizeMode.StretchImage
        Clouds(CloudCount).Top = 384
        Clouds(CloudCount).Left = CInt(Math.Floor((320 - 0 + 1) * Rnd())) + 0
        Clouds(CloudCount).Name = "Cloud" + CloudCount.ToString
        Me.Controls.Add(Clouds(CloudCount))
    End Sub
End Class
