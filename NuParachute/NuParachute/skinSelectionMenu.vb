Public Class skinSelectionMenu
    Dim mouseIsDown As Boolean
    Private Sub camoParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles camoParachute.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub camoParachute_MouseMove(sender As Object, e As MouseEventArgs) Handles camoParachute.MouseMove
        If mouseIsDown = True Then
            camoParachute.DoDragDrop(camoParachute.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub camoShirt_MouseDown(sender As Object, e As MouseEventArgs) Handles camoShirt.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub camoShirt_MouseMove(sender As Object, e As MouseEventArgs) Handles camoShirt.MouseMove
        If mouseIsDown = True Then
            camoShirt.DoDragDrop(camoShirt.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub exitSkinBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub greenParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles greenParachute.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub greenParachute_MouseMove(sender As Object, e As MouseEventArgs) Handles greenParachute.MouseMove
        If mouseIsDown = True Then
            greenParachute.DoDragDrop(greenParachute.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub greenShirt_MouseDown(sender As Object, e As MouseEventArgs) Handles greenShirt.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub greenShirt_MouseMove(sender As Object, e As MouseEventArgs) Handles greenShirt.MouseMove
        If mouseIsDown = True Then
            greenShirt.DoDragDrop(greenShirt.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub parachuteColour_DragDrop(sender As Object, e As DragEventArgs) Handles parachuteColour.DragDrop
        parachuteColour.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub
    Private Sub parachuteColour_DragEnter(sender As Object, e As DragEventArgs) Handles parachuteColour.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub pinkParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles pinkParachute.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub pinkParachute_MouseMove(sender As Object, e As MouseEventArgs) Handles pinkParachute.MouseMove
        If mouseIsDown = True Then
            pinkParachute.DoDragDrop(pinkParachute.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub pinkShirt_MouseDown(sender As Object, e As MouseEventArgs) Handles pinkShirt.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub pinkShirt_MouseMove(sender As Object, e As MouseEventArgs) Handles pinkShirt.MouseMove
        If mouseIsDown = True Then
            pinkShirt.DoDragDrop(pinkShirt.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub redParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles redParachute.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub redParachute_MouseMove(sender As Object, e As MouseEventArgs) Handles redParachute.MouseMove
        If mouseIsDown = True Then
            redParachute.DoDragDrop(redParachute.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub redShirt_MouseDown(sender As Object, e As MouseEventArgs) Handles redShirt.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub redShirt_MouseMove(sender As Object, e As MouseEventArgs) Handles redShirt.MouseMove
        If mouseIsDown = True Then
            redShirt.DoDragDrop(redShirt.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub shirtColour_DragDrop(sender As Object, e As DragEventArgs) Handles shirtColour.DragDrop
        shirtColour.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub
    Private Sub shirtColour_DragEnter(sender As Object, e As DragEventArgs) Handles shirtColour.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub skinSelectionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redParachute.AllowDrop = True
        greenParachute.AllowDrop = True
        yellowParachute.AllowDrop = True
        pinkParachute.AllowDrop = True
        camoParachute.AllowDrop = True
        redShirt.AllowDrop = True
        greenShirt.AllowDrop = True
        yellowShirt.AllowDrop = True
        pinkShirt.AllowDrop = True
        camoShirt.AllowDrop = True
        parachuteColour.AllowDrop = True
        shirtColour.AllowDrop = True
    End Sub
    Private Sub yellowParachute_MouseDown(sender As Object, e As MouseEventArgs) Handles yellowParachute.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub yellowParachute_MouseMove(sender As Object, e As MouseEventArgs) Handles yellowParachute.MouseMove
        If mouseIsDown = True Then
            yellowParachute.DoDragDrop(yellowParachute.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub yellowShirt_MouseDown(sender As Object, e As MouseEventArgs) Handles yellowShirt.MouseDown
        mouseIsDown = True
    End Sub
    Private Sub yellowShirt_MouseMove(sender As Object, e As MouseEventArgs) Handles yellowShirt.MouseMove
        If mouseIsDown = True Then
            yellowShirt.DoDragDrop(yellowShirt.Image, DragDropEffects.Copy)
        End If
        mouseIsDown = False
    End Sub
    Private Sub exitSkinsBtn_Click(sender As Object, e As EventArgs) Handles exitSkinsBtn.Click
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub exitSkinsBtn_VisibleChanged(sender As Object, e As EventArgs) Handles exitSkinsBtn.VisibleChanged
        exitSkinsBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
        exitSkinsBtn.FlatAppearance.BorderSize = 0
        exitSkinsBtn.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        exitSkinsBtn.FlatAppearance.MouseOverBackColor = Color.LightBlue
        exitSkinsBtn.BackColor = Color.Transparent
    End Sub
    ' The clusterpoop above is basically an incredibly crude way of drag and drop. I discovered the technique I learnt only really works efficiently with 2 picture boxes, so as you can tell was not a lot of fun doing it for 10.
    Dim parachuteDesignNumber As Integer
    ' As I don't know how you're going to order your designs, I'm kinda forced to leave the rest up to you from here. Simple array should do the trick but I trust you
    'Audio stil needs to be done as well.
    'If you have any suggestions, recommendations or other notes that you'd like to share with me please do so as soon as you can. I'm not entirely happy with the UI but it's the best I can do
    ' with a short time constraint. If you have an idea that I can do quickly I'll do it.
    'Also yes, I'm aware that half the colours in the skinSelectionMenu don't actually have to be there. I'm tired leave me alone, I"ll delete half of it tomorrow or you can do it IDM
    'Oh, and if you can please implement a way to return to menu after pause/death in game. Extremely important future that I tried to add but failed so I'll see if you can do it
    'Apologies for any crude, sloppy work as well as my overall lack of impact in this project as a whole. I'll try my best to actually do something next time!

End Class