Module GlobalVariables
    'All Variablees used more than once should be placed here.
    'Start General Variables
    Public GameActive As Boolean = False
    Public GameScroll As Boolean = True
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As IntPtr) As Short
    Public Countdown As Integer = 5
    'End General Variables

    'Start Game Balance
    Public CharacterDropSpeed As Decimal = 0.64
    Public HelicopterMoveSpeed As Decimal = 1.92
    Public CharacterMoveSpeed As Decimal = 2
    Public Difficulty As Integer = 1
    Public Seconds As Integer = 60
    Public GameLength As Integer = CInt(Math.Floor((1000 / screenMain.timeCopterGen.Interval) * (Seconds - (350 / (CharacterDropSpeed * 1000 / screenMain.timeScroll.Interval)))))
    'End Game Balance

    'Start Object Generation
    Public Counter As Integer = 0
    Public Copters(500) As PictureBox
    Public CopterCount As Integer = 0
    Public Clouds(500) As PictureBox
    Public CloudCount As Integer = 0
    'End Object Generation

    'Begin Subprograms
    Public Sub CloudGen()
        Randomize()
        CloudCount += 1
        Clouds(CloudCount) = New PictureBox
        Clouds(CloudCount).Image = My.Resources.pixelCloudV2
        Clouds(CloudCount).Height = 50
        Clouds(CloudCount).Width = 75
        Clouds(CloudCount).SizeMode = PictureBoxSizeMode.StretchImage
        Clouds(CloudCount).Top = 384
        Clouds(CloudCount).Left = CInt(Math.Floor((320 - 0 + 1) * Rnd())) + 0
        Clouds(CloudCount).Name = "Cloud" + CloudCount.ToString
        screenMain.Controls.Add(Clouds(CloudCount))
    End Sub
    Public Sub CopterGen()
        If Counter Mod (Difficulty * 2) = 0 Then
            Randomize()
            CopterCount += 1
            Copters(CopterCount) = New PictureBox
            Copters(CopterCount).Image = My.Resources.HelicoptereSmall
            Copters(CopterCount).Height = 26
            Copters(CopterCount).Width = 64
            Copters(CopterCount).SizeMode = PictureBoxSizeMode.StretchImage
            Copters(CopterCount).Top = CInt(Math.Floor((308 - 100 + 1) * Rnd())) + 100
            If CopterCount Mod 2 = 0 Then
                Copters(CopterCount).Left = -64
            Else
                Copters(CopterCount).Left = 384
                Copters(CopterCount).Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            End If
            Copters(CopterCount).Name = "Copter" + CopterCount.ToString
            screenMain.Controls.Add(Copters(CopterCount))
        End If
    End Sub
    Public Sub GameOver()
        screenMain.timeCopterGen.Enabled = False
        screenMain.timeScroll.Enabled = False
        screenMain.LoadScreenPic.Visible = True
        screenMain.LoadScreenLabel.Visible = True
        screenMain.LoadScreenCountdown.Visible = True
        screenMain.LoadScreenPic.BringToFront()
        screenMain.LoadScreenLabel.BringToFront()
        screenMain.LoadScreenCountdown.BringToFront()
        screenMain.LoadScreenLabel.Left = (screenMain.Width / 2) - (screenMain.LoadScreenLabel.Width / 2)
        screenMain.LoadScreenCountdown.Left = (screenMain.Width / 2) - (screenMain.LoadScreenCountdown.Width / 2)
        GameScroll = False
    End Sub
    Public Sub GameReset()
        Counter = 0
        For i As Integer = 1 To CloudCount
            screenMain.Controls.Remove(Clouds(i))
        Next
        For i As Integer = 1 To CopterCount
            screenMain.Controls.Remove(Copters(i))
        Next
        CloudCount = 1
        CopterCount = 1
        Countdown = 5
        screenMain.Character.Top = 10
        screenMain.LoadScreenLabel.Text = "Parachute"
        screenMain.LoadScreenCountdown.Text = "Drop Zone in... " + Countdown.ToString
        screenMain.timeCopterGen.Enabled = True
        screenMain.timeScroll.Enabled = True
        screenMain.LoadScreenLabel.Left = (screenMain.Width / 2) - (screenMain.LoadScreenLabel.Width / 2)
        screenMain.LoadScreenCountdown.Left = (screenMain.Width / 2) - (screenMain.LoadScreenCountdown.Width / 2)
        GameScroll = True
    End Sub
    'End Subprograms
End Module
