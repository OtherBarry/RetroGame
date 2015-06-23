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
        CType(Me.Character, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.timeCopterGen.Interval = 1000
        '
        'screenMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 384)
        Me.Controls.Add(Me.Character)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screenMain"
        Me.Text = "Form1"
        CType(Me.Character, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Character As System.Windows.Forms.PictureBox
    Friend WithEvents timeScroll As System.Windows.Forms.Timer
    Friend WithEvents timeCopterGen As Timer
End Class
