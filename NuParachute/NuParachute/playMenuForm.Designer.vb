<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class playMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(playMenuForm))
        Me.campaignBox = New System.Windows.Forms.TextBox()
        Me.arcadeBox = New System.Windows.Forms.TextBox()
        Me.endlessBox = New System.Windows.Forms.TextBox()
        Me.gameSelectionBox = New System.Windows.Forms.RichTextBox()
        Me.infoTextBox = New System.Windows.Forms.RichTextBox()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.playMenuReturnBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'campaignBox
        '
        Me.campaignBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.campaignBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campaignBox.Location = New System.Drawing.Point(12, 517)
        Me.campaignBox.Name = "campaignBox"
        Me.campaignBox.ReadOnly = True
        Me.campaignBox.Size = New System.Drawing.Size(181, 38)
        Me.campaignBox.TabIndex = 2
        Me.campaignBox.Text = "Campaign"
        Me.campaignBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'arcadeBox
        '
        Me.arcadeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.arcadeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arcadeBox.Location = New System.Drawing.Point(219, 517)
        Me.arcadeBox.Name = "arcadeBox"
        Me.arcadeBox.ReadOnly = True
        Me.arcadeBox.Size = New System.Drawing.Size(181, 38)
        Me.arcadeBox.TabIndex = 3
        Me.arcadeBox.Text = "Arcade"
        Me.arcadeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'endlessBox
        '
        Me.endlessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.endlessBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endlessBox.Location = New System.Drawing.Point(431, 517)
        Me.endlessBox.Name = "endlessBox"
        Me.endlessBox.ReadOnly = True
        Me.endlessBox.Size = New System.Drawing.Size(181, 38)
        Me.endlessBox.TabIndex = 4
        Me.endlessBox.Text = "Endless"
        Me.endlessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gameSelectionBox
        '
        Me.gameSelectionBox.BackColor = System.Drawing.Color.Black
        Me.gameSelectionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gameSelectionBox.EnableAutoDragDrop = True
        Me.gameSelectionBox.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameSelectionBox.ForeColor = System.Drawing.Color.White
        Me.gameSelectionBox.Location = New System.Drawing.Point(178, 12)
        Me.gameSelectionBox.Name = "gameSelectionBox"
        Me.gameSelectionBox.ReadOnly = True
        Me.gameSelectionBox.Size = New System.Drawing.Size(258, 202)
        Me.gameSelectionBox.TabIndex = 5
        Me.gameSelectionBox.Text = "Drag your desired gamemode here!"
        '
        'infoTextBox
        '
        Me.infoTextBox.BackColor = System.Drawing.Color.Yellow
        Me.infoTextBox.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoTextBox.Location = New System.Drawing.Point(178, 220)
        Me.infoTextBox.Name = "infoTextBox"
        Me.infoTextBox.ReadOnly = True
        Me.infoTextBox.Size = New System.Drawing.Size(258, 291)
        Me.infoTextBox.TabIndex = 6
        Me.infoTextBox.Text = ""
        '
        'btnIncrease
        '
        Me.btnIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnIncrease.Location = New System.Drawing.Point(468, 561)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(50, 50)
        Me.btnIncrease.TabIndex = 7
        Me.btnIncrease.Text = ">"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnDecrease.Location = New System.Drawing.Point(120, 561)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(50, 50)
        Me.btnDecrease.TabIndex = 8
        Me.btnDecrease.Text = "<"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(190, 585)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(229, 18)
        Me.lblDifficulty.TabIndex = 9
        Me.lblDifficulty.Text = "Current Difficulty : Medium"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.NuPrachute.My.Resources.Resources.pixelCloudV2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(478, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 48)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.NuPrachute.My.Resources.Resources.pixelCloudV2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(48, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 48)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.NuPrachute.My.Resources.Resources.HelicopterSmall
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(454, 272)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(94, 44)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'playMenuReturnBtn
        '
        Me.playMenuReturnBtn.Location = New System.Drawing.Point(12, 12)
        Me.playMenuReturnBtn.Name = "playMenuReturnBtn"
        Me.playMenuReturnBtn.Size = New System.Drawing.Size(75, 23)
        Me.playMenuReturnBtn.TabIndex = 13
        Me.playMenuReturnBtn.Text = "Menu"
        Me.playMenuReturnBtn.UseVisualStyleBackColor = True
        '
        'playMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 729)
        Me.Controls.Add(Me.playMenuReturnBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.infoTextBox)
        Me.Controls.Add(Me.gameSelectionBox)
        Me.Controls.Add(Me.endlessBox)
        Me.Controls.Add(Me.arcadeBox)
        Me.Controls.Add(Me.campaignBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "playMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "playMenuForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents campaignBox As TextBox
    Friend WithEvents arcadeBox As TextBox
    Friend WithEvents endlessBox As TextBox
    Friend WithEvents gameSelectionBox As RichTextBox
    Friend WithEvents infoTextBox As RichTextBox
    Friend WithEvents btnIncrease As Button
    Friend WithEvents btnDecrease As Button
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents playMenuReturnBtn As Button
End Class
