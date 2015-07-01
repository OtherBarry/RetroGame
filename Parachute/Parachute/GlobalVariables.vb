Module GlobalVariables
    'All Variablees used more than once should be placed here.
    'Start General Variables
    Public GameActive As Boolean = False
    'End General Variables

    'Start Game Balance
    Public CharacterDropSpeed As Decimal = 0.64
    Public HelicopterMoveSpeed As Decimal = 1.92
    Public CharacterMoveSpeed As Decimal = 2
    Public Difficulty As Integer = 1.5
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
            Copters(CopterCount).Top = CInt(Math.Floor((308 - 24 + 1) * Rnd())) + 24
            Copters(CopterCount).Left = -64
            Copters(CopterCount).Name = "Copter" + CopterCount.ToString
            screenMain.Controls.Add(Copters(CopterCount))
        End If
    End Sub
    Public Sub GameOver()
        GameActive = False
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
    End Sub
    'End Subprograms
End Module
