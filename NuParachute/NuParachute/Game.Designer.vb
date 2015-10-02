<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.DeciSecond = New System.Windows.Forms.Timer(Me.components)
        Me.Tick = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtLives = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.txtPaused = New System.Windows.Forms.Label()
        Me.EnemySpawn = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeciSecond
        '
        '
        'Tick
        '
        Me.Tick.Interval = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(0, 704)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(640, 64)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'txtLives
        '
        Me.txtLives.AutoSize = True
        Me.txtLives.BackColor = System.Drawing.Color.Black
        Me.txtLives.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLives.ForeColor = System.Drawing.Color.White
        Me.txtLives.Location = New System.Drawing.Point(471, 17)
        Me.txtLives.Name = "txtLives"
        Me.txtLives.Size = New System.Drawing.Size(157, 30)
        Me.txtLives.TabIndex = 3
        Me.txtLives.Text = "Lives : 3"
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.BackColor = System.Drawing.Color.Black
        Me.txtTitle.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(17, 17)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(157, 30)
        Me.txtTitle.TabIndex = 4
        Me.txtTitle.Text = "Parachute"
        '
        'txtLevel
        '
        Me.txtLevel.AutoSize = True
        Me.txtLevel.BackColor = System.Drawing.Color.Black
        Me.txtLevel.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.ForeColor = System.Drawing.Color.White
        Me.txtLevel.Location = New System.Drawing.Point(17, 721)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(125, 30)
        Me.txtLevel.TabIndex = 5
        Me.txtLevel.Text = "Level 1"
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.BackColor = System.Drawing.Color.Black
        Me.txtTime.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.White
        Me.txtTime.Location = New System.Drawing.Point(471, 721)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(157, 30)
        Me.txtTime.TabIndex = 6
        Me.txtTime.Text = "Time : 0s"
        '
        'txtPaused
        '
        Me.txtPaused.AutoSize = True
        Me.txtPaused.Font = New System.Drawing.Font("Constantia", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaused.Location = New System.Drawing.Point(188, 343)
        Me.txtPaused.Name = "txtPaused"
        Me.txtPaused.Size = New System.Drawing.Size(264, 82)
        Me.txtPaused.TabIndex = 7
        Me.txtPaused.Text = "Paused"
        Me.txtPaused.Visible = False
        '
        'EnemySpawn
        '
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 768)
        Me.Controls.Add(Me.txtPaused)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtLives)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeciSecond As System.Windows.Forms.Timer
    Friend WithEvents Tick As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLives As Label
    Friend WithEvents txtTitle As Label
    Friend WithEvents txtLevel As Label
    Friend WithEvents txtTime As Label
    Friend WithEvents txtPaused As Label
    Friend WithEvents EnemySpawn As Timer
End Class
