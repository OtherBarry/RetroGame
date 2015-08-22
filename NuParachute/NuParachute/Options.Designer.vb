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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.numDropSpeed = New System.Windows.Forms.NumericUpDown()
        Me.numCharSpeed = New System.Windows.Forms.NumericUpDown()
        Me.numEnSpeed = New System.Windows.Forms.NumericUpDown()
        Me.numLength = New System.Windows.Forms.NumericUpDown()
        Me.numLives = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.numDropSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCharSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEnSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(280, 604)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'numDropSpeed
        '
        Me.numDropSpeed.Location = New System.Drawing.Point(260, 100)
        Me.numDropSpeed.Name = "numDropSpeed"
        Me.numDropSpeed.Size = New System.Drawing.Size(120, 20)
        Me.numDropSpeed.TabIndex = 2
        Me.numDropSpeed.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'numCharSpeed
        '
        Me.numCharSpeed.Location = New System.Drawing.Point(260, 200)
        Me.numCharSpeed.Name = "numCharSpeed"
        Me.numCharSpeed.Size = New System.Drawing.Size(120, 20)
        Me.numCharSpeed.TabIndex = 3
        Me.numCharSpeed.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'numEnSpeed
        '
        Me.numEnSpeed.Location = New System.Drawing.Point(260, 300)
        Me.numEnSpeed.Name = "numEnSpeed"
        Me.numEnSpeed.Size = New System.Drawing.Size(120, 20)
        Me.numEnSpeed.TabIndex = 4
        Me.numEnSpeed.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'numLength
        '
        Me.numLength.Location = New System.Drawing.Point(260, 400)
        Me.numLength.Name = "numLength"
        Me.numLength.Size = New System.Drawing.Size(120, 20)
        Me.numLength.TabIndex = 5
        Me.numLength.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'numLives
        '
        Me.numLives.Location = New System.Drawing.Point(260, 500)
        Me.numLives.Name = "numLives"
        Me.numLives.Size = New System.Drawing.Size(120, 20)
        Me.numLives.TabIndex = 6
        Me.numLives.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Drop Speed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Character Speed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Helicopter Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Game Length"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lives"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 768)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numLives)
        Me.Controls.Add(Me.numLength)
        Me.Controls.Add(Me.numEnSpeed)
        Me.Controls.Add(Me.numCharSpeed)
        Me.Controls.Add(Me.numDropSpeed)
        Me.Controls.Add(Me.btnHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Options"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
