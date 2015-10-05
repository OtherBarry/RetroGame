<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutorialMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tutorialMenu))
        Me.enemyLbl = New System.Windows.Forms.Label()
        Me.enemyInfo = New System.Windows.Forms.RichTextBox()
        Me.leftEnemyBtn = New System.Windows.Forms.Button()
        Me.rightEnemyBtn = New System.Windows.Forms.Button()
        Me.pwrUpInfo = New System.Windows.Forms.RichTextBox()
        Me.leftPwrUpBtn = New System.Windows.Forms.Button()
        Me.rightPwrUpBtn = New System.Windows.Forms.Button()
        Me.pwrUpLbl = New System.Windows.Forms.Label()
        Me.exitTutorialBtn = New System.Windows.Forms.Button()
        Me.pwrUpPic = New System.Windows.Forms.PictureBox()
        Me.enemyPic = New System.Windows.Forms.PictureBox()
        CType(Me.pwrUpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemyPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enemyLbl
        '
        Me.enemyLbl.AutoSize = True
        Me.enemyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enemyLbl.Location = New System.Drawing.Point(454, 526)
        Me.enemyLbl.Name = "enemyLbl"
        Me.enemyLbl.Size = New System.Drawing.Size(57, 20)
        Me.enemyLbl.TabIndex = 0
        Me.enemyLbl.Text = "Label1"
        '
        'enemyInfo
        '
        Me.enemyInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.enemyInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enemyInfo.Location = New System.Drawing.Point(359, 264)
        Me.enemyInfo.Name = "enemyInfo"
        Me.enemyInfo.Size = New System.Drawing.Size(265, 227)
        Me.enemyInfo.TabIndex = 2
        Me.enemyInfo.Text = ""
        '
        'leftEnemyBtn
        '
        Me.leftEnemyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftEnemyBtn.Location = New System.Drawing.Point(359, 497)
        Me.leftEnemyBtn.Name = "leftEnemyBtn"
        Me.leftEnemyBtn.Size = New System.Drawing.Size(75, 71)
        Me.leftEnemyBtn.TabIndex = 3
        Me.leftEnemyBtn.Text = "<"
        Me.leftEnemyBtn.UseVisualStyleBackColor = True
        '
        'rightEnemyBtn
        '
        Me.rightEnemyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightEnemyBtn.Location = New System.Drawing.Point(549, 497)
        Me.rightEnemyBtn.Name = "rightEnemyBtn"
        Me.rightEnemyBtn.Size = New System.Drawing.Size(75, 71)
        Me.rightEnemyBtn.TabIndex = 4
        Me.rightEnemyBtn.Text = ">"
        Me.rightEnemyBtn.UseVisualStyleBackColor = True
        '
        'pwrUpInfo
        '
        Me.pwrUpInfo.Location = New System.Drawing.Point(0, 264)
        Me.pwrUpInfo.Name = "pwrUpInfo"
        Me.pwrUpInfo.Size = New System.Drawing.Size(265, 227)
        Me.pwrUpInfo.TabIndex = 6
        Me.pwrUpInfo.Text = ""
        '
        'leftPwrUpBtn
        '
        Me.leftPwrUpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftPwrUpBtn.Location = New System.Drawing.Point(0, 497)
        Me.leftPwrUpBtn.Name = "leftPwrUpBtn"
        Me.leftPwrUpBtn.Size = New System.Drawing.Size(75, 71)
        Me.leftPwrUpBtn.TabIndex = 7
        Me.leftPwrUpBtn.Text = "<"
        Me.leftPwrUpBtn.UseVisualStyleBackColor = True
        '
        'rightPwrUpBtn
        '
        Me.rightPwrUpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightPwrUpBtn.Location = New System.Drawing.Point(190, 497)
        Me.rightPwrUpBtn.Name = "rightPwrUpBtn"
        Me.rightPwrUpBtn.Size = New System.Drawing.Size(75, 71)
        Me.rightPwrUpBtn.TabIndex = 8
        Me.rightPwrUpBtn.Text = ">"
        Me.rightPwrUpBtn.UseVisualStyleBackColor = True
        '
        'pwrUpLbl
        '
        Me.pwrUpLbl.AutoSize = True
        Me.pwrUpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwrUpLbl.Location = New System.Drawing.Point(94, 526)
        Me.pwrUpLbl.Name = "pwrUpLbl"
        Me.pwrUpLbl.Size = New System.Drawing.Size(77, 25)
        Me.pwrUpLbl.TabIndex = 9
        Me.pwrUpLbl.Text = "Label1"
        '
        'exitTutorialBtn
        '
        Me.exitTutorialBtn.Location = New System.Drawing.Point(276, 9)
        Me.exitTutorialBtn.Name = "exitTutorialBtn"
        Me.exitTutorialBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitTutorialBtn.TabIndex = 10
        Me.exitTutorialBtn.Text = "Menu"
        Me.exitTutorialBtn.UseVisualStyleBackColor = True
        '
        'pwrUpPic
        '
        Me.pwrUpPic.Location = New System.Drawing.Point(12, 37)
        Me.pwrUpPic.Name = "pwrUpPic"
        Me.pwrUpPic.Size = New System.Drawing.Size(253, 221)
        Me.pwrUpPic.TabIndex = 5
        Me.pwrUpPic.TabStop = False
        '
        'enemyPic
        '
        Me.enemyPic.Location = New System.Drawing.Point(359, 37)
        Me.enemyPic.Name = "enemyPic"
        Me.enemyPic.Size = New System.Drawing.Size(253, 221)
        Me.enemyPic.TabIndex = 1
        Me.enemyPic.TabStop = False
        '
        'tutorialMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 729)
        Me.Controls.Add(Me.exitTutorialBtn)
        Me.Controls.Add(Me.pwrUpLbl)
        Me.Controls.Add(Me.rightPwrUpBtn)
        Me.Controls.Add(Me.leftPwrUpBtn)
        Me.Controls.Add(Me.pwrUpInfo)
        Me.Controls.Add(Me.pwrUpPic)
        Me.Controls.Add(Me.rightEnemyBtn)
        Me.Controls.Add(Me.leftEnemyBtn)
        Me.Controls.Add(Me.enemyInfo)
        Me.Controls.Add(Me.enemyPic)
        Me.Controls.Add(Me.enemyLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tutorialMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tutorialMenu"
        CType(Me.pwrUpPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemyPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enemyLbl As System.Windows.Forms.Label
    Friend WithEvents enemyPic As System.Windows.Forms.PictureBox
    Friend WithEvents enemyInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents leftEnemyBtn As System.Windows.Forms.Button
    Friend WithEvents rightEnemyBtn As System.Windows.Forms.Button
    Friend WithEvents pwrUpPic As System.Windows.Forms.PictureBox
    Friend WithEvents pwrUpInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents leftPwrUpBtn As System.Windows.Forms.Button
    Friend WithEvents rightPwrUpBtn As System.Windows.Forms.Button
    Friend WithEvents pwrUpLbl As System.Windows.Forms.Label
    Friend WithEvents exitTutorialBtn As System.Windows.Forms.Button
End Class
