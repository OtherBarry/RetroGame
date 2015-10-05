<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.numDropSpeed = New System.Windows.Forms.NumericUpDown()
        Me.numCharSpeed = New System.Windows.Forms.NumericUpDown()
        Me.numEnSpeed = New System.Windows.Forms.NumericUpDown()
        Me.numLength = New System.Windows.Forms.NumericUpDown()
        Me.numLives = New System.Windows.Forms.NumericUpDown()
        Me.dropSpeedLbl = New System.Windows.Forms.Label()
        Me.charSpeedLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.muteOption = New System.Windows.Forms.CheckBox()
        Me.disablePowerups = New System.Windows.Forms.CheckBox()
        Me.optionInfoBox = New System.Windows.Forms.RichTextBox()
        CType(Me.numDropSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCharSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEnSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 29)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'numDropSpeed
        '
        Me.numDropSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDropSpeed.Location = New System.Drawing.Point(148, 97)
        Me.numDropSpeed.Name = "numDropSpeed"
        Me.numDropSpeed.Size = New System.Drawing.Size(131, 26)
        Me.numDropSpeed.TabIndex = 2
        Me.numDropSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDropSpeed.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'numCharSpeed
        '
        Me.numCharSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCharSpeed.Location = New System.Drawing.Point(148, 197)
        Me.numCharSpeed.Name = "numCharSpeed"
        Me.numCharSpeed.Size = New System.Drawing.Size(131, 26)
        Me.numCharSpeed.TabIndex = 3
        Me.numCharSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numCharSpeed.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'numEnSpeed
        '
        Me.numEnSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEnSpeed.Location = New System.Drawing.Point(148, 300)
        Me.numEnSpeed.Name = "numEnSpeed"
        Me.numEnSpeed.Size = New System.Drawing.Size(131, 26)
        Me.numEnSpeed.TabIndex = 4
        Me.numEnSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numEnSpeed.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'numLength
        '
        Me.numLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLength.Location = New System.Drawing.Point(148, 402)
        Me.numLength.Name = "numLength"
        Me.numLength.Size = New System.Drawing.Size(131, 26)
        Me.numLength.TabIndex = 5
        Me.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numLength.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'numLives
        '
        Me.numLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLives.Location = New System.Drawing.Point(148, 500)
        Me.numLives.Name = "numLives"
        Me.numLives.Size = New System.Drawing.Size(131, 26)
        Me.numLives.TabIndex = 6
        Me.numLives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numLives.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'dropSpeedLbl
        '
        Me.dropSpeedLbl.AutoSize = True
        Me.dropSpeedLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropSpeedLbl.Location = New System.Drawing.Point(12, 97)
        Me.dropSpeedLbl.Name = "dropSpeedLbl"
        Me.dropSpeedLbl.Size = New System.Drawing.Size(95, 20)
        Me.dropSpeedLbl.TabIndex = 7
        Me.dropSpeedLbl.Text = "Drop Speed"
        '
        'charSpeedLbl
        '
        Me.charSpeedLbl.AutoSize = True
        Me.charSpeedLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.charSpeedLbl.Location = New System.Drawing.Point(12, 197)
        Me.charSpeedLbl.Name = "charSpeedLbl"
        Me.charSpeedLbl.Size = New System.Drawing.Size(130, 20)
        Me.charSpeedLbl.TabIndex = 8
        Me.charSpeedLbl.Text = "Character Speed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Helicopter Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Game Length"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lives"
        '
        'muteOption
        '
        Me.muteOption.AutoSize = True
        Me.muteOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muteOption.Location = New System.Drawing.Point(409, 99)
        Me.muteOption.Name = "muteOption"
        Me.muteOption.Size = New System.Drawing.Size(116, 24)
        Me.muteOption.TabIndex = 12
        Me.muteOption.Text = "Mute audio?"
        Me.muteOption.UseVisualStyleBackColor = True
        '
        'disablePowerups
        '
        Me.disablePowerups.AutoSize = True
        Me.disablePowerups.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disablePowerups.Location = New System.Drawing.Point(409, 199)
        Me.disablePowerups.Name = "disablePowerups"
        Me.disablePowerups.Size = New System.Drawing.Size(163, 24)
        Me.disablePowerups.TabIndex = 13
        Me.disablePowerups.Text = "Disable powerups?"
        Me.disablePowerups.UseVisualStyleBackColor = True
        '
        'optionInfoBox
        '
        Me.optionInfoBox.Location = New System.Drawing.Point(177, 552)
        Me.optionInfoBox.Name = "optionInfoBox"
        Me.optionInfoBox.Size = New System.Drawing.Size(276, 96)
        Me.optionInfoBox.TabIndex = 14
        Me.optionInfoBox.Text = ""
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 768)
        Me.Controls.Add(Me.optionInfoBox)
        Me.Controls.Add(Me.disablePowerups)
        Me.Controls.Add(Me.muteOption)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.charSpeedLbl)
        Me.Controls.Add(Me.dropSpeedLbl)
        Me.Controls.Add(Me.numLives)
        Me.Controls.Add(Me.numLength)
        Me.Controls.Add(Me.numEnSpeed)
        Me.Controls.Add(Me.numCharSpeed)
        Me.Controls.Add(Me.numDropSpeed)
        Me.Controls.Add(Me.btnHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        CType(Me.numDropSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCharSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEnSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents numDropSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCharSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents numEnSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents numLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents numLives As System.Windows.Forms.NumericUpDown
    Friend WithEvents dropSpeedLbl As System.Windows.Forms.Label
    Friend WithEvents charSpeedLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents muteOption As CheckBox
    Friend WithEvents disablePowerups As CheckBox
    Friend WithEvents optionInfoBox As RichTextBox
End Class
