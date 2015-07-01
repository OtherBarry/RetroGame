<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenMain
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
        Me.components = New System.ComponentModel.Container()
        Me.timeScroll = New System.Windows.Forms.Timer(Me.components)
        Me.Character = New System.Windows.Forms.PictureBox()
        Me.timeCopterGen = New System.Windows.Forms.Timer(Me.components)
        Me.LoadScreenPic = New System.Windows.Forms.PictureBox()
        Me.LoadScreenLabel = New System.Windows.Forms.Label()
        Me.LoadScreenCountdown = New System.Windows.Forms.Label()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadScreenPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeScroll
        '
        Me.timeScroll.Interval = 17
        '
        'Character
        '
        Me.Character.Image = Global.Parachute.My.Resources.Resources.ParachuterSmall
        Me.Character.Location = New System.Drawing.Point(141, 12)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(14, 24)
        Me.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Character.TabIndex = 0
        Me.Character.TabStop = False
        '
        'timeCopterGen
        '
        Me.timeCopterGen.Interval = 756
        '
        'LoadScreenPic
        '
        Me.LoadScreenPic.Location = New System.Drawing.Point(-2, 0)
        Me.LoadScreenPic.Name = "LoadScreenPic"
        Me.LoadScreenPic.Size = New System.Drawing.Size(326, 388)
        Me.LoadScreenPic.TabIndex = 1
        Me.LoadScreenPic.TabStop = False
        '
        'LoadScreenLabel
        '
        Me.LoadScreenLabel.AutoSize = True
        Me.LoadScreenLabel.Font = New System.Drawing.Font("Playbill", 100.0!, System.Drawing.FontStyle.Bold)
        Me.LoadScreenLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LoadScreenLabel.Location = New System.Drawing.Point(-15, 111)
        Me.LoadScreenLabel.Name = "LoadScreenLabel"
        Me.LoadScreenLabel.Size = New System.Drawing.Size(362, 136)
        Me.LoadScreenLabel.TabIndex = 2
        Me.LoadScreenLabel.Text = "Parachute"
        '
        'LoadScreenCountdown
        '
        Me.LoadScreenCountdown.AutoSize = True
        Me.LoadScreenCountdown.Font = New System.Drawing.Font("Playbill", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadScreenCountdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LoadScreenCountdown.Location = New System.Drawing.Point(87, 220)
        Me.LoadScreenCountdown.Name = "LoadScreenCountdown"
        Me.LoadScreenCountdown.Size = New System.Drawing.Size(126, 27)
        Me.LoadScreenCountdown.TabIndex = 3
        Me.LoadScreenCountdown.Text = "Drop Zone in... 5"
        '
        'screenMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 384)
        Me.Controls.Add(Me.LoadScreenCountdown)
        Me.Controls.Add(Me.LoadScreenLabel)
        Me.Controls.Add(Me.LoadScreenPic)
        Me.Controls.Add(Me.Character)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screenMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadScreenPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Character As System.Windows.Forms.PictureBox
    Friend WithEvents timeScroll As System.Windows.Forms.Timer
    Friend WithEvents timeCopterGen As Timer
    Friend WithEvents LoadScreenPic As System.Windows.Forms.PictureBox
    Friend WithEvents LoadScreenLabel As System.Windows.Forms.Label
    Friend WithEvents LoadScreenCountdown As System.Windows.Forms.Label
End Class
