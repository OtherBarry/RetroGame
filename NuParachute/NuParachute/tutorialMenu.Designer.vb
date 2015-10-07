<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutorialMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tutorialMenu))
        Me.exitTutorialBtn = New System.Windows.Forms.Button()
        Me.helicopterImage = New System.Windows.Forms.PictureBox()
        Me.enemyLbl = New System.Windows.Forms.Label()
        Me.helicopterInformation = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.powerupLbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.characterInfo = New System.Windows.Forms.Label()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.playGameBtn = New System.Windows.Forms.Button()
        CType(Me.helicopterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitTutorialBtn
        '
        Me.exitTutorialBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.exitTutorialBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitTutorialBtn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitTutorialBtn.Location = New System.Drawing.Point(643, 552)
        Me.exitTutorialBtn.Name = "exitTutorialBtn"
        Me.exitTutorialBtn.Size = New System.Drawing.Size(225, 120)
        Me.exitTutorialBtn.TabIndex = 10
        Me.exitTutorialBtn.Text = "Return to menu"
        Me.exitTutorialBtn.UseVisualStyleBackColor = True
        '
        'helicopterImage
        '
        Me.helicopterImage.BackgroundImage = Global.NuPrachute.My.Resources.Resources.HelicopterSmall
        Me.helicopterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.helicopterImage.Location = New System.Drawing.Point(19, 70)
        Me.helicopterImage.Name = "helicopterImage"
        Me.helicopterImage.Size = New System.Drawing.Size(150, 72)
        Me.helicopterImage.TabIndex = 11
        Me.helicopterImage.TabStop = False
        '
        'enemyLbl
        '
        Me.enemyLbl.AutoSize = True
        Me.enemyLbl.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enemyLbl.Location = New System.Drawing.Point(12, 15)
        Me.enemyLbl.Name = "enemyLbl"
        Me.enemyLbl.Size = New System.Drawing.Size(103, 37)
        Me.enemyLbl.TabIndex = 12
        Me.enemyLbl.Text = "Enemies"
        '
        'helicopterInformation
        '
        Me.helicopterInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.helicopterInformation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.helicopterInformation.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helicopterInformation.Location = New System.Drawing.Point(184, 70)
        Me.helicopterInformation.Name = "helicopterInformation"
        Me.helicopterInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.helicopterInformation.Size = New System.Drawing.Size(428, 79)
        Me.helicopterInformation.TabIndex = 13
        Me.helicopterInformation.Text = "The basic common enemy of the game. These mean suckers will fly towards you at a " &
    "moderate speed. They ain't too scary on their own but they got a lot of numbers!" &
    "" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.NuPrachute.My.Resources.Resources.PlaneSmall
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(19, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 72)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(184, 169)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(428, 72)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = "The more advanced units of the game! While few in number, these fellas move at to" &
    "p speed and are very good at sniping you when you least expect it, so watch out!" &
    "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'powerupLbl
        '
        Me.powerupLbl.AutoSize = True
        Me.powerupLbl.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.powerupLbl.Location = New System.Drawing.Point(12, 267)
        Me.powerupLbl.Name = "powerupLbl"
        Me.powerupLbl.Size = New System.Drawing.Size(120, 37)
        Me.powerupLbl.TabIndex = 16
        Me.powerupLbl.Text = "Powerups"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Speed
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(19, 320)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(117, 320)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox2.Size = New System.Drawing.Size(495, 72)
        Me.RichTextBox2.TabIndex = 18
        Me.RichTextBox2.Text = "The speed powerup! This speeds up your characters movespeed for 3 seconds. Useful" &
    " for dodging those pesky planes at the last second!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Freeze
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(19, 420)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(117, 420)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox3.Size = New System.Drawing.Size(495, 72)
        Me.RichTextBox3.TabIndex = 20
        Me.RichTextBox3.Text = "The freeze powerup! Stop time for 3 seconds to dodge all those flying enemies!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) &
    "" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(117, 520)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox4.Size = New System.Drawing.Size(495, 72)
        Me.RichTextBox4.TabIndex = 21
        Me.RichTextBox4.Text = "The invincibility powerup! Be safe from harm for 3 seconds. Perfect time for a br" &
    "eather!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.NuPrachute.My.Resources.Resources.invincibility
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(19, 520)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(643, 435)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 74)
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'characterInfo
        '
        Me.characterInfo.AutoSize = True
        Me.characterInfo.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.characterInfo.Location = New System.Drawing.Point(636, 385)
        Me.characterInfo.Name = "characterInfo"
        Me.characterInfo.Size = New System.Drawing.Size(63, 37)
        Me.characterInfo.TabIndex = 24
        Me.characterInfo.Text = "You!"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.Location = New System.Drawing.Point(741, 435)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox5.Size = New System.Drawing.Size(495, 72)
        Me.RichTextBox5.TabIndex = 25
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(632, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Gamemodes"
        '
        'RichTextBox6
        '
        Me.RichTextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.Location = New System.Drawing.Point(639, 70)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox6.Size = New System.Drawing.Size(597, 322)
        Me.RichTextBox6.TabIndex = 27
        Me.RichTextBox6.Text = resources.GetString("RichTextBox6.Text")
        '
        'playGameBtn
        '
        Me.playGameBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.playGameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.playGameBtn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playGameBtn.Location = New System.Drawing.Point(1011, 552)
        Me.playGameBtn.Name = "playGameBtn"
        Me.playGameBtn.Size = New System.Drawing.Size(225, 120)
        Me.playGameBtn.TabIndex = 28
        Me.playGameBtn.Text = "Go play!"
        Me.playGameBtn.UseVisualStyleBackColor = True
        '
        'tutorialMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 691)
        Me.Controls.Add(Me.playGameBtn)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.characterInfo)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.powerupLbl)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.helicopterInformation)
        Me.Controls.Add(Me.enemyLbl)
        Me.Controls.Add(Me.helicopterImage)
        Me.Controls.Add(Me.exitTutorialBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tutorialMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tutorialMenu"
        CType(Me.helicopterImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitTutorialBtn As System.Windows.Forms.Button
    Friend WithEvents helicopterImage As PictureBox
    Friend WithEvents enemyLbl As Label
    Friend WithEvents helicopterInformation As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents powerupLbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents characterInfo As Label
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents playGameBtn As Button
End Class
