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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.DeciSecond = New System.Windows.Forms.Timer(Me.components)
        Me.Tick = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.txtPaused = New System.Windows.Forms.Label()
        Me.EnemySpawn = New System.Windows.Forms.Timer(Me.components)
        Me.Live0 = New System.Windows.Forms.PictureBox()
        Me.Live4 = New System.Windows.Forms.PictureBox()
        Me.Live3 = New System.Windows.Forms.PictureBox()
        Me.Live2 = New System.Windows.Forms.PictureBox()
        Me.Live1 = New System.Windows.Forms.PictureBox()
        Me.Live8 = New System.Windows.Forms.PictureBox()
        Me.Live7 = New System.Windows.Forms.PictureBox()
        Me.Live6 = New System.Windows.Forms.PictureBox()
        Me.Live5 = New System.Windows.Forms.PictureBox()
        Me.Live9 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live9, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Live0
        '
        Me.Live0.BackColor = System.Drawing.Color.Black
        Me.Live0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live0.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live0.Location = New System.Drawing.Point(614, 20)
        Me.Live0.Name = "Live0"
        Me.Live0.Size = New System.Drawing.Size(14, 24)
        Me.Live0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live0.TabIndex = 8
        Me.Live0.TabStop = False
        '
        'Live4
        '
        Me.Live4.BackColor = System.Drawing.Color.Black
        Me.Live4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live4.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live4.Location = New System.Drawing.Point(534, 20)
        Me.Live4.Name = "Live4"
        Me.Live4.Size = New System.Drawing.Size(14, 24)
        Me.Live4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live4.TabIndex = 9
        Me.Live4.TabStop = False
        '
        'Live3
        '
        Me.Live3.BackColor = System.Drawing.Color.Black
        Me.Live3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live3.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live3.Location = New System.Drawing.Point(554, 20)
        Me.Live3.Name = "Live3"
        Me.Live3.Size = New System.Drawing.Size(14, 24)
        Me.Live3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live3.TabIndex = 10
        Me.Live3.TabStop = False
        '
        'Live2
        '
        Me.Live2.BackColor = System.Drawing.Color.Black
        Me.Live2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live2.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live2.Location = New System.Drawing.Point(574, 20)
        Me.Live2.Name = "Live2"
        Me.Live2.Size = New System.Drawing.Size(14, 24)
        Me.Live2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live2.TabIndex = 11
        Me.Live2.TabStop = False
        '
        'Live1
        '
        Me.Live1.BackColor = System.Drawing.Color.Black
        Me.Live1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live1.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live1.Location = New System.Drawing.Point(594, 20)
        Me.Live1.Name = "Live1"
        Me.Live1.Size = New System.Drawing.Size(14, 24)
        Me.Live1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live1.TabIndex = 12
        Me.Live1.TabStop = False
        '
        'Live8
        '
        Me.Live8.BackColor = System.Drawing.Color.Black
        Me.Live8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live8.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live8.Location = New System.Drawing.Point(454, 20)
        Me.Live8.Name = "Live8"
        Me.Live8.Size = New System.Drawing.Size(14, 24)
        Me.Live8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live8.TabIndex = 13
        Me.Live8.TabStop = False
        '
        'Live7
        '
        Me.Live7.BackColor = System.Drawing.Color.Black
        Me.Live7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live7.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live7.Location = New System.Drawing.Point(474, 20)
        Me.Live7.Name = "Live7"
        Me.Live7.Size = New System.Drawing.Size(14, 24)
        Me.Live7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live7.TabIndex = 14
        Me.Live7.TabStop = False
        '
        'Live6
        '
        Me.Live6.BackColor = System.Drawing.Color.Black
        Me.Live6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live6.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live6.Location = New System.Drawing.Point(494, 20)
        Me.Live6.Name = "Live6"
        Me.Live6.Size = New System.Drawing.Size(14, 24)
        Me.Live6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live6.TabIndex = 15
        Me.Live6.TabStop = False
        '
        'Live5
        '
        Me.Live5.BackColor = System.Drawing.Color.Black
        Me.Live5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live5.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live5.Location = New System.Drawing.Point(514, 20)
        Me.Live5.Name = "Live5"
        Me.Live5.Size = New System.Drawing.Size(14, 24)
        Me.Live5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live5.TabIndex = 16
        Me.Live5.TabStop = False
        '
        'Live9
        '
        Me.Live9.BackColor = System.Drawing.Color.Black
        Me.Live9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Live9.Image = Global.NuPrachute.My.Resources.Resources.ParachuterSmall
        Me.Live9.Location = New System.Drawing.Point(434, 20)
        Me.Live9.Name = "Live9"
        Me.Live9.Size = New System.Drawing.Size(14, 24)
        Me.Live9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Live9.TabIndex = 17
        Me.Live9.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 768)
        Me.Controls.Add(Me.Live9)
        Me.Controls.Add(Me.Live5)
        Me.Controls.Add(Me.Live6)
        Me.Controls.Add(Me.Live7)
        Me.Controls.Add(Me.Live8)
        Me.Controls.Add(Me.Live1)
        Me.Controls.Add(Me.Live2)
        Me.Controls.Add(Me.Live3)
        Me.Controls.Add(Me.Live4)
        Me.Controls.Add(Me.Live0)
        Me.Controls.Add(Me.txtPaused)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeciSecond As System.Windows.Forms.Timer
    Friend WithEvents Tick As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTitle As Label
    Friend WithEvents txtLevel As Label
    Friend WithEvents txtTime As Label
    Friend WithEvents txtPaused As Label
    Friend WithEvents EnemySpawn As Timer
    Friend WithEvents Live0 As PictureBox
    Friend WithEvents Live4 As PictureBox
    Friend WithEvents Live3 As PictureBox
    Friend WithEvents Live2 As PictureBox
    Friend WithEvents Live1 As PictureBox
    Friend WithEvents Live8 As PictureBox
    Friend WithEvents Live7 As PictureBox
    Friend WithEvents Live6 As PictureBox
    Friend WithEvents Live5 As PictureBox
    Friend WithEvents Live9 As PictureBox
End Class
