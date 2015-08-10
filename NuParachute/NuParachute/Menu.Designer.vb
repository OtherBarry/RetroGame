<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 100)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnIncrease
        '
        Me.btnIncrease.Font = New System.Drawing.Font("Mistral", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnIncrease.Location = New System.Drawing.Point(200, 200)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(50, 50)
        Me.btnIncrease.TabIndex = 1
        Me.btnIncrease.Text = ">"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Font = New System.Drawing.Font("Mistral", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnDecrease.Location = New System.Drawing.Point(50, 200)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(50, 50)
        Me.btnDecrease.TabIndex = 2
        Me.btnDecrease.Text = "<"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Location = New System.Drawing.Point(83, 170)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(130, 13)
        Me.lblDifficulty.TabIndex = 4
        Me.lblDifficulty.Text = "Current Difficulty : Medium"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnIncrease As Button
    Friend WithEvents btnDecrease As Button
    Friend WithEvents lblDifficulty As Label
End Class
