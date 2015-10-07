Public Class skinSelectionMenu
    Dim mouseIsDown As Boolean
    Dim pickedUpCamo As Boolean
    Dim pickedUpRed As Boolean
    Dim pickedUpGreen As Boolean
    Dim pickedUpYellow As Boolean
    Dim pickedUpPink As Boolean
    Dim differenceX As Integer
    Dim differenceY As Integer
    Dim initialCamoPositionX As Integer
    Dim initialCamoPositionY As Integer
    Dim currentPositionX As Integer
    Dim currentPositionY As Integer
    Dim initialCamoX As Integer
    Dim initialCamoY As Integer
    Dim initialPinkX As Integer
    Dim initialPinkY As Integer
    Dim initialGreenX As Integer
    Dim initialGreenY As Integer
    Dim initialRedX As Integer
    Dim initialRedY As Integer
    Dim initialYellowX As Integer
    Dim initialYellowY As Integer
    Private Sub camoParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles camo.MouseDown 'Handles static coordinates and pickedUpcamo status for camo
        pickedUpCamo = True
        initialCamoPositionX = MousePosition.X
        initialCamoPositionY = MousePosition.Y
        initialCamoX = camo.Left
        initialCamoY = camo.Top
    End Sub
    Private Sub exitSkinBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub greenParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles green.MouseDown
        mouseIsDown = True
        pickedUpGreen = True
        initialCamoPositionX = MousePosition.X
        initialCamoPositionY = MousePosition.Y
        initialGreenX = green.Left
        initialGreenY = green.Top
    End Sub
    Private Sub pinkParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles pink.MouseDown
        mouseIsDown = True
        pickedUpPink = True
        initialCamoPositionX = MousePosition.X
        initialCamoPositionY = MousePosition.Y
        initialPinkX = pink.Left
        initialPinkY = pink.Top
    End Sub
    Private Sub redParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles red.MouseDown
        mouseIsDown = True
        pickedUpRed = True
        initialCamoPositionX = MousePosition.X
        initialCamoPositionY = MousePosition.Y
        initialRedX = red.Left
        initialRedY = red.Top
    End Sub
    Private Sub skinSelectionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        red.AllowDrop = True
        green.AllowDrop = True
        yellow.AllowDrop = True
        pink.AllowDrop = True
        camo.AllowDrop = True
        parachuteColour.AllowDrop = True
        shirtColour.AllowDrop = True
    End Sub
    Private Sub yellowParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles yellow.MouseDown
        mouseIsDown = True
        pickedUpYellow = True
        initialCamoPositionX = MousePosition.X
        initialCamoPositionY = MousePosition.Y
        initialYellowX = yellow.Left
        initialYellowY = yellow.Top
    End Sub
    Private Sub exitSkinsBtn_Click(sender As Object, e As EventArgs) Handles exitSkinsBtn.Click
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub exitSkinsBtn_VisibleChanged(sender As Object, e As EventArgs) Handles exitSkinsBtn.VisibleChanged 'Background change for button
        exitSkinsBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        exitSkinsBtn.FlatAppearance.BorderSize = 0
        exitSkinsBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        exitSkinsBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        exitSkinsBtn.BackColor = Color.Transparent
    End Sub
    Private Sub camo_MouseUp(sender As Object, e As MouseEventArgs) Handles camo.MouseUp 'Resets position after letting go of mouse.
        pickedUpCamo = False
        camo.Left = initialCamoX
        camo.Top = initialCamoY
    End Sub
    Private Sub skinTimer_Tick(sender As Object, e As EventArgs) Handles skinTimer.Tick 'Handles movement and image replacement
        currentPositionX = MousePosition.X
        currentPositionY = MousePosition.Y
        differenceX = currentPositionX - initialCamoPositionX
        differenceY = currentPositionY - initialCamoPositionY
        If pickedUpCamo = True Then
            camo.Left = initialCamoX + differenceX
            camo.Top = initialCamoY + differenceY
        ElseIf pickedUpPink = True Then
            pink.Left = initialPinkX + differenceX
            pink.Top = initialPinkY + differenceY
        ElseIf pickedUpRed = True Then
            red.Left = initialRedX + differenceX
            red.Top = initialRedY + differenceY
        ElseIf pickedUpGreen = True Then
            green.Left = initialGreenX + differenceX
            green.Top = initialGreenY + differenceY
        ElseIf pickedUpYellow = True Then
            yellow.Left = initialYellowX + differenceX
            yellow.Top = initialYellowY + differenceY
        End If
        If camo.Left < shirtColour.Left And camo.Left > (shirtColour.Left - shirtColour.Width) Then
            If camo.Top < shirtColour.Top And camo.Top > (shirtColour.Top - shirtColour.Height) Then
                shirtColour.Image = camo.Image
                shirtNumber = 0
            End If
        ElseIf pink.Left < shirtColour.Left And pink.Left > (shirtColour.Left - shirtColour.Width) Then
            If pink.Top < shirtColour.Top And pink.Top > (shirtColour.Top - shirtColour.Height) Then
                shirtColour.Image = pink.Image
                shirtNumber = 1
            End If
        ElseIf red.Left < shirtColour.Left And red.Left > (shirtColour.Left - shirtColour.Width) Then
            If red.Top < shirtColour.Top And red.Top > (shirtColour.Top - shirtColour.Height) Then
                shirtColour.Image = red.Image
                shirtNumber = 2
            End If
        ElseIf green.Left < shirtColour.Left And green.Left > (shirtColour.Left - shirtColour.Width) Then
            If green.Top < shirtColour.Top And green.Top > (shirtColour.Top - shirtColour.Height) Then
                shirtColour.Image = green.Image
                shirtNumber = 3
            End If
        ElseIf yellow.Left < shirtColour.Left And yellow.Left > (shirtColour.Left - shirtColour.Width) Then
            If yellow.Top < shirtColour.Top And yellow.Top > (shirtColour.Top - shirtColour.Height) Then
                shirtColour.Image = yellow.Image
                shirtNumber = 4
            End If
        ElseIf camo.Left < parachuteColour.Left And camo.Left > (parachuteColour.Left - parachuteColour.Width) Then
            If camo.Top < parachuteColour.Top And camo.Top > (parachuteColour.Top - parachuteColour.Height) Then
                parachuteColour.Image = camo.Image
                parachuteNumber = 0
            End If
        ElseIf pink.Left < parachuteColour.Left And pink.Left > (parachuteColour.Left - parachuteColour.Width) Then
            If pink.Top < parachuteColour.Top And pink.Top > (parachuteColour.Top - parachuteColour.Height) Then
                parachuteColour.Image = pink.Image
                parachuteNumber = 1
            End If
        ElseIf red.Left < parachuteColour.Left And red.Left > (parachuteColour.Left - parachuteColour.Width) Then
            If red.Top < parachuteColour.Top And red.Top > (parachuteColour.Top - parachuteColour.Height) Then
                parachuteColour.Image = red.Image
                parachuteNumber = 2
            End If
        ElseIf green.Left < parachuteColour.Left And green.Left > (parachuteColour.Left - parachuteColour.Width) Then
            If green.Top < parachuteColour.Top And green.Top > (parachuteColour.Top - parachuteColour.Height) Then
                parachuteColour.Image = green.Image
                parachuteNumber = 3
            End If
        ElseIf yellow.Left < parachuteColour.Left And yellow.Left > (parachuteColour.Left - parachuteColour.Width) Then
            If yellow.Top < parachuteColour.Top And yellow.Top > (parachuteColour.Top - parachuteColour.Height) Then
                parachuteColour.Image = yellow.Image
                parachuteNumber = 4
            End If
        End If
        parachutist.Image = Skins(parachuteNumber, shirtNumber)
        ' PSEUDOCODE FOR PARACHUTIST IMAGE
        ' IF parachuteNumber = x AND shirtNumber = y THEN
        '   parachute.Image = possibleDesignList[z]
        'ELSEIF bla bla bla
        'ENDIF
        'Note that this is general idea. If you have better idea please feel free to implement.
    End Sub

    Private Sub pink_MouseUp(sender As Object, e As MouseEventArgs) Handles pink.MouseUp
        pickedUpPink = False
        pink.Left = initialPinkX
        pink.Top = initialPinkY
    End Sub

    Private Sub green_MouseUp(sender As Object, e As MouseEventArgs) Handles green.MouseUp
        pickedUpGreen = False
        green.Left = initialGreenX
        green.Top = initialGreenY
    End Sub

    Private Sub red_MouseUp(sender As Object, e As MouseEventArgs) Handles red.MouseUp
        pickedUpRed = False
        red.Left = initialRedX
        red.Top = initialRedY
    End Sub

    Private Sub yellow_MouseUp(sender As Object, e As MouseEventArgs) Handles yellow.MouseUp
        pickedUpYellow = False
        yellow.Left = initialYellowX
        yellow.Top = initialYellowY
    End Sub
End Class