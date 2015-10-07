<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class skinSelectionMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skinSelectionMenu))
        Me.titleLabelSkins = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shirtColour = New System.Windows.Forms.PictureBox()
        Me.parachuteColour = New System.Windows.Forms.PictureBox()
        Me.parachutist = New System.Windows.Forms.PictureBox()
        Me.camo = New System.Windows.Forms.PictureBox()
        Me.pink = New System.Windows.Forms.PictureBox()
        Me.yellow = New System.Windows.Forms.PictureBox()
        Me.green = New System.Windows.Forms.PictureBox()
        Me.red = New System.Windows.Forms.PictureBox()
        Me.exitSkinsBtn = New System.Windows.Forms.Button()
        Me.skinTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.shirtColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parachuteColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parachutist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.camo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabelSkins
        '
        Me.titleLabelSkins.AutoSize = True
        Me.titleLabelSkins.Font = New System.Drawing.Font("Segoe Print", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabelSkins.Location = New System.Drawing.Point(12, 9)
        Me.titleLabelSkins.Name = "titleLabelSkins"
        Me.titleLabelSkins.Size = New System.Drawing.Size(429, 65)
        Me.titleLabelSkins.TabIndex = 0
        Me.titleLabelSkins.Text = "Choose how you look!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 64)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Choose your colour!"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 65)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Try the parachute and the shirt"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 69)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Drag the colours over the character to change colours"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shirtColour
        '
        Me.shirtColour.BackColor = System.Drawing.Color.White
        Me.shirtColour.Location = New System.Drawing.Point(289, 312)
        Me.shirtColour.Name = "shirtColour"
        Me.shirtColour.Size = New System.Drawing.Size(17, 29)
        Me.shirtColour.TabIndex = 23
        Me.shirtColour.TabStop = False
        '
        'parachuteColour
        '
        Me.parachuteColour.BackColor = System.Drawing.Color.White
        Me.parachuteColour.Location = New System.Drawing.Point(273, 237)
        Me.parachuteColour.Name = "parachuteColour"
        Me.parachuteColour.Size = New System.Drawing.Size(55, 25)
        Me.parachuteColour.TabIndex = 22
        Me.parachuteColour.TabStop = False
        '
        'parachutist
        '
        Me.parachutist.BackgroundImage = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.parachutist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parachutist.Location = New System.Drawing.Point(261, 228)
        Me.parachutist.Name = "parachutist"
        Me.parachutist.Size = New System.Drawing.Size(81, 137)
        Me.parachutist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.parachutist.TabIndex = 21
        Me.parachutist.TabStop = False
        '
        'camo
        '
        Me.camo.Image = Global.NuPrachute.My.Resources.Resources.camo
        Me.camo.Location = New System.Drawing.Point(503, 154)
        Me.camo.Name = "camo"
        Me.camo.Size = New System.Drawing.Size(50, 50)
        Me.camo.TabIndex = 13
        Me.camo.TabStop = False
        '
        'pink
        '
        Me.pink.Image = Global.NuPrachute.My.Resources.Resources.pink
        Me.pink.Location = New System.Drawing.Point(381, 154)
        Me.pink.Name = "pink"
        Me.pink.Size = New System.Drawing.Size(50, 50)
        Me.pink.TabIndex = 12
        Me.pink.TabStop = False
        '
        'yellow
        '
        Me.yellow.Image = Global.NuPrachute.My.Resources.Resources.yellow
        Me.yellow.Location = New System.Drawing.Point(261, 154)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(50, 50)
        Me.yellow.TabIndex = 11
        Me.yellow.TabStop = False
        '
        'green
        '
        Me.green.Image = Global.NuPrachute.My.Resources.Resources.white
        Me.green.Location = New System.Drawing.Point(157, 154)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(50, 50)
        Me.green.TabIndex = 27
        Me.green.TabStop = False
        '
        'red
        '
        Me.red.Image = Global.NuPrachute.My.Resources.Resources.red
        Me.red.Location = New System.Drawing.Point(51, 154)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(50, 50)
        Me.red.TabIndex = 9
        Me.red.TabStop = False
        '
        'exitSkinsBtn
        '
        Me.exitSkinsBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.exitSkinsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitSkinsBtn.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitSkinsBtn.Location = New System.Drawing.Point(484, 12)
        Me.exitSkinsBtn.Name = "exitSkinsBtn"
        Me.exitSkinsBtn.Size = New System.Drawing.Size(112, 47)
        Me.exitSkinsBtn.TabIndex = 8
        Me.exitSkinsBtn.Text = "Exit"
        Me.exitSkinsBtn.UseVisualStyleBackColor = True
        '
        'skinTimer
        '
        Me.skinTimer.Enabled = True
        Me.skinTimer.Interval = 1
        '
        'skinSelectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.parachutist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.camo)
        Me.Controls.Add(Me.pink)
        Me.Controls.Add(Me.yellow)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.exitSkinsBtn)
        Me.Controls.Add(Me.titleLabelSkins)
        Me.Controls.Add(Me.parachuteColour)
        Me.Controls.Add(Me.shirtColour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "skinSelectionMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "skinSelectionMenu"
        CType(Me.shirtColour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parachuteColour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parachutist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.camo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabelSkins As Label
    Friend WithEvents exitSkinsBtn As Button
    Friend WithEvents red As PictureBox
    Friend WithEvents green As PictureBox
    Friend WithEvents yellow As PictureBox
    Friend WithEvents pink As PictureBox
    Friend WithEvents camo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents parachutist As PictureBox
    Friend WithEvents parachuteColour As PictureBox
    Friend WithEvents shirtColour As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents skinTimer As Timer
End Class
