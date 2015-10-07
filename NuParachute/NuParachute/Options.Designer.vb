<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.numLength = New System.Windows.Forms.NumericUpDown()
        Me.muteOption = New System.Windows.Forms.CheckBox()
        Me.disableLightningPwr = New System.Windows.Forms.CheckBox()
        Me.gameLengthLbl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.disableTimePwr = New System.Windows.Forms.CheckBox()
        Me.disableInvinciblePwr = New System.Windows.Forms.CheckBox()
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(509, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(118, 54)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'numLength
        '
        Me.numLength.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numLength.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numLength.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLength.Location = New System.Drawing.Point(282, 35)
        Me.numLength.Name = "numLength"
        Me.numLength.Size = New System.Drawing.Size(72, 51)
        Me.numLength.TabIndex = 5
        Me.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numLength.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'muteOption
        '
        Me.muteOption.AutoSize = True
        Me.muteOption.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.muteOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.muteOption.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muteOption.Location = New System.Drawing.Point(12, 162)
        Me.muteOption.Name = "muteOption"
        Me.muteOption.Size = New System.Drawing.Size(206, 51)
        Me.muteOption.TabIndex = 12
        Me.muteOption.Text = "Mute audio?"
        Me.muteOption.UseVisualStyleBackColor = True
        '
        'disableLightningPwr
        '
        Me.disableLightningPwr.AutoSize = True
        Me.disableLightningPwr.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.disableLightningPwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.disableLightningPwr.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disableLightningPwr.Location = New System.Drawing.Point(12, 312)
        Me.disableLightningPwr.Name = "disableLightningPwr"
        Me.disableLightningPwr.Size = New System.Drawing.Size(365, 46)
        Me.disableLightningPwr.TabIndex = 13
        Me.disableLightningPwr.Text = "Disable lightning powerup?"
        Me.disableLightningPwr.UseVisualStyleBackColor = True
        '
        'gameLengthLbl
        '
        Me.gameLengthLbl.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.gameLengthLbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gameLengthLbl.Enabled = False
        Me.gameLengthLbl.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameLengthLbl.Location = New System.Drawing.Point(12, 12)
        Me.gameLengthLbl.Name = "gameLengthLbl"
        Me.gameLengthLbl.Size = New System.Drawing.Size(264, 96)
        Me.gameLengthLbl.TabIndex = 15
        Me.gameLengthLbl.Text = "Game Length"
        Me.gameLengthLbl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 33)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Determines how long Arcade mode lasts for."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 33)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mutes all ingame audio"
        '
        'disableTimePwr
        '
        Me.disableTimePwr.AutoSize = True
        Me.disableTimePwr.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.disableTimePwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.disableTimePwr.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disableTimePwr.Location = New System.Drawing.Point(12, 462)
        Me.disableTimePwr.Name = "disableTimePwr"
        Me.disableTimePwr.Size = New System.Drawing.Size(422, 51)
        Me.disableTimePwr.TabIndex = 18
        Me.disableTimePwr.Text = "Disable stop-time powerup?"
        Me.disableTimePwr.UseVisualStyleBackColor = True
        '
        'disableInvinciblePwr
        '
        Me.disableInvinciblePwr.AutoSize = True
        Me.disableInvinciblePwr.BackgroundImage = Global.NuPrachute.My.Resources.Resources.Cloud
        Me.disableInvinciblePwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.disableInvinciblePwr.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disableInvinciblePwr.Location = New System.Drawing.Point(12, 612)
        Me.disableInvinciblePwr.Name = "disableInvinciblePwr"
        Me.disableInvinciblePwr.Size = New System.Drawing.Size(444, 51)
        Me.disableInvinciblePwr.TabIndex = 19
        Me.disableInvinciblePwr.Text = "Disable invincibility powerup?"
        Me.disableInvinciblePwr.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 797)
        Me.Controls.Add(Me.disableInvinciblePwr)
        Me.Controls.Add(Me.disableTimePwr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gameLengthLbl)
        Me.Controls.Add(Me.disableLightningPwr)
        Me.Controls.Add(Me.muteOption)
        Me.Controls.Add(Me.numLength)
        Me.Controls.Add(Me.btnHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents numLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents muteOption As CheckBox
    Friend WithEvents disableLightningPwr As CheckBox
    Friend WithEvents gameLengthLbl As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents disableTimePwr As CheckBox
    Friend WithEvents disableInvinciblePwr As CheckBox
End Class
