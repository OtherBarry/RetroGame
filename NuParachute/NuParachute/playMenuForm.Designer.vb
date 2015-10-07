<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class playMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(playMenuForm))
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.playMenuReturnBtn = New System.Windows.Forms.Button()
        Me.campaignPlayBtn = New System.Windows.Forms.Button()
        Me.endlessPlayBtn = New System.Windows.Forms.Button()
        Me.arcadePlayBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tutorialRedirectBtn = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIncrease
        '
        Me.btnIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnIncrease.Location = New System.Drawing.Point(562, 189)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(50, 50)
        Me.btnIncrease.TabIndex = 7
        Me.btnIncrease.Text = ">"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnDecrease.Location = New System.Drawing.Point(12, 189)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(50, 50)
        Me.btnDecrease.TabIndex = 8
        Me.btnDecrease.Text = "<"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(182, 189)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(239, 28)
        Me.lblDifficulty.TabIndex = 9
        Me.lblDifficulty.Text = "Current Difficulty : Medium"
        '
        'playMenuReturnBtn
        '
        Me.playMenuReturnBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.playMenuReturnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.playMenuReturnBtn.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playMenuReturnBtn.Location = New System.Drawing.Point(524, 12)
        Me.playMenuReturnBtn.Name = "playMenuReturnBtn"
        Me.playMenuReturnBtn.Size = New System.Drawing.Size(88, 43)
        Me.playMenuReturnBtn.TabIndex = 13
        Me.playMenuReturnBtn.Text = "Menu"
        Me.playMenuReturnBtn.UseVisualStyleBackColor = True
        '
        'campaignPlayBtn
        '
        Me.campaignPlayBtn.BackColor = System.Drawing.Color.Transparent
        Me.campaignPlayBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.campaignPlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.campaignPlayBtn.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campaignPlayBtn.Location = New System.Drawing.Point(12, 86)
        Me.campaignPlayBtn.Name = "campaignPlayBtn"
        Me.campaignPlayBtn.Size = New System.Drawing.Size(195, 84)
        Me.campaignPlayBtn.TabIndex = 14
        Me.campaignPlayBtn.Text = "Campaign"
        Me.campaignPlayBtn.UseVisualStyleBackColor = False
        '
        'endlessPlayBtn
        '
        Me.endlessPlayBtn.BackColor = System.Drawing.Color.Transparent
        Me.endlessPlayBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.endlessPlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.endlessPlayBtn.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endlessPlayBtn.Location = New System.Drawing.Point(213, 86)
        Me.endlessPlayBtn.Name = "endlessPlayBtn"
        Me.endlessPlayBtn.Size = New System.Drawing.Size(195, 84)
        Me.endlessPlayBtn.TabIndex = 15
        Me.endlessPlayBtn.Text = "Endless"
        Me.endlessPlayBtn.UseVisualStyleBackColor = False
        '
        'arcadePlayBtn
        '
        Me.arcadePlayBtn.BackColor = System.Drawing.Color.Transparent
        Me.arcadePlayBtn.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.arcadePlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.arcadePlayBtn.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arcadePlayBtn.Location = New System.Drawing.Point(414, 86)
        Me.arcadePlayBtn.Name = "arcadePlayBtn"
        Me.arcadePlayBtn.Size = New System.Drawing.Size(195, 84)
        Me.arcadePlayBtn.TabIndex = 16
        Me.arcadePlayBtn.Text = "Arcade"
        Me.arcadePlayBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NOTE: Only affects Endless and Arcade gamemodes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tutorialRedirectBtn
        '
        Me.tutorialRedirectBtn.BackColor = System.Drawing.Color.White
        Me.tutorialRedirectBtn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tutorialRedirectBtn.Location = New System.Drawing.Point(12, 12)
        Me.tutorialRedirectBtn.Name = "tutorialRedirectBtn"
        Me.tutorialRedirectBtn.Size = New System.Drawing.Size(278, 68)
        Me.tutorialRedirectBtn.TabIndex = 18
        Me.tutorialRedirectBtn.Text = "If you haven't seen the tutorial yet, click here to have a look!"
        Me.tutorialRedirectBtn.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.NuPrachute.My.Resources.Resources.HelicopterSmall
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(333, 19)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(75, 36)
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'playMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 291)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.tutorialRedirectBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.arcadePlayBtn)
        Me.Controls.Add(Me.endlessPlayBtn)
        Me.Controls.Add(Me.campaignPlayBtn)
        Me.Controls.Add(Me.playMenuReturnBtn)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.btnIncrease)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "playMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "playMenuForm"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIncrease As Button
    Friend WithEvents btnDecrease As Button
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents playMenuReturnBtn As Button
    Friend WithEvents campaignPlayBtn As Button
    Friend WithEvents endlessPlayBtn As Button
    Friend WithEvents arcadePlayBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tutorialRedirectBtn As Button
    Friend WithEvents PictureBox7 As PictureBox
End Class
