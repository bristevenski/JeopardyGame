<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Final
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Final))
        Me.headingLbl = New System.Windows.Forms.Label()
        Me.team1Lbl = New System.Windows.Forms.Label()
        Me.team2Lbl = New System.Windows.Forms.Label()
        Me.team3Lbl = New System.Windows.Forms.Label()
        Me.team4Lbl = New System.Windows.Forms.Label()
        Me.team1Txt = New System.Windows.Forms.TextBox()
        Me.team2Txt = New System.Windows.Forms.TextBox()
        Me.team3Txt = New System.Windows.Forms.TextBox()
        Me.team4Txt = New System.Windows.Forms.TextBox()
        Me.wagerLbl = New System.Windows.Forms.Label()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.team1Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.team2Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.team3Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.team4Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.team1Score = New System.Windows.Forms.Label()
        Me.team2Score = New System.Windows.Forms.Label()
        Me.team3Score = New System.Windows.Forms.Label()
        Me.team4Score = New System.Windows.Forms.Label()
        Me.team5Score = New System.Windows.Forms.Label()
        Me.team5Txt = New System.Windows.Forms.TextBox()
        Me.team5Lbl = New System.Windows.Forms.Label()
        Me.team5Err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.team1Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.team2Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.team3Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.team4Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.team5Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headingLbl
        '
        Me.headingLbl.AutoSize = True
        Me.headingLbl.BackColor = System.Drawing.Color.Transparent
        Me.headingLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headingLbl.ForeColor = System.Drawing.Color.Black
        Me.headingLbl.Location = New System.Drawing.Point(70, 9)
        Me.headingLbl.Name = "headingLbl"
        Me.headingLbl.Size = New System.Drawing.Size(460, 55)
        Me.headingLbl.TabIndex = 0
        Me.headingLbl.Text = "FINAL JEOPARDY!"
        '
        'team1Lbl
        '
        Me.team1Lbl.AutoSize = True
        Me.team1Lbl.BackColor = System.Drawing.Color.Transparent
        Me.team1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1Lbl.ForeColor = System.Drawing.Color.MediumBlue
        Me.team1Lbl.Location = New System.Drawing.Point(101, 127)
        Me.team1Lbl.Name = "team1Lbl"
        Me.team1Lbl.Size = New System.Drawing.Size(144, 42)
        Me.team1Lbl.TabIndex = 1
        Me.team1Lbl.Text = "Team 1"
        '
        'team2Lbl
        '
        Me.team2Lbl.AutoSize = True
        Me.team2Lbl.BackColor = System.Drawing.Color.Transparent
        Me.team2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2Lbl.ForeColor = System.Drawing.Color.MediumBlue
        Me.team2Lbl.Location = New System.Drawing.Point(101, 232)
        Me.team2Lbl.Name = "team2Lbl"
        Me.team2Lbl.Size = New System.Drawing.Size(144, 42)
        Me.team2Lbl.TabIndex = 2
        Me.team2Lbl.Text = "Team 2"
        '
        'team3Lbl
        '
        Me.team3Lbl.AutoSize = True
        Me.team3Lbl.BackColor = System.Drawing.Color.Transparent
        Me.team3Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3Lbl.ForeColor = System.Drawing.Color.MediumBlue
        Me.team3Lbl.Location = New System.Drawing.Point(101, 337)
        Me.team3Lbl.Name = "team3Lbl"
        Me.team3Lbl.Size = New System.Drawing.Size(144, 42)
        Me.team3Lbl.TabIndex = 3
        Me.team3Lbl.Text = "Team 3"
        '
        'team4Lbl
        '
        Me.team4Lbl.AutoSize = True
        Me.team4Lbl.BackColor = System.Drawing.Color.Transparent
        Me.team4Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4Lbl.ForeColor = System.Drawing.Color.MediumBlue
        Me.team4Lbl.Location = New System.Drawing.Point(101, 442)
        Me.team4Lbl.Name = "team4Lbl"
        Me.team4Lbl.Size = New System.Drawing.Size(144, 42)
        Me.team4Lbl.TabIndex = 4
        Me.team4Lbl.Text = "Team 4"
        '
        'team1Txt
        '
        Me.team1Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1Txt.Location = New System.Drawing.Point(291, 124)
        Me.team1Txt.Name = "team1Txt"
        Me.team1Txt.Size = New System.Drawing.Size(222, 49)
        Me.team1Txt.TabIndex = 5
        Me.team1Txt.Text = "0"
        '
        'team2Txt
        '
        Me.team2Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2Txt.Location = New System.Drawing.Point(291, 229)
        Me.team2Txt.Name = "team2Txt"
        Me.team2Txt.Size = New System.Drawing.Size(222, 49)
        Me.team2Txt.TabIndex = 6
        Me.team2Txt.Text = "0"
        '
        'team3Txt
        '
        Me.team3Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3Txt.Location = New System.Drawing.Point(291, 334)
        Me.team3Txt.Name = "team3Txt"
        Me.team3Txt.Size = New System.Drawing.Size(222, 49)
        Me.team3Txt.TabIndex = 7
        Me.team3Txt.Text = "0"
        '
        'team4Txt
        '
        Me.team4Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4Txt.Location = New System.Drawing.Point(291, 439)
        Me.team4Txt.Name = "team4Txt"
        Me.team4Txt.Size = New System.Drawing.Size(222, 49)
        Me.team4Txt.TabIndex = 8
        Me.team4Txt.Text = "0"
        '
        'wagerLbl
        '
        Me.wagerLbl.AutoSize = True
        Me.wagerLbl.BackColor = System.Drawing.Color.Transparent
        Me.wagerLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wagerLbl.ForeColor = System.Drawing.Color.MediumBlue
        Me.wagerLbl.Location = New System.Drawing.Point(199, 55)
        Me.wagerLbl.Name = "wagerLbl"
        Me.wagerLbl.Size = New System.Drawing.Size(203, 55)
        Me.wagerLbl.TabIndex = 9
        Me.wagerLbl.Text = "Wagers:"
        '
        'okBtn
        '
        Me.okBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okBtn.Location = New System.Drawing.Point(12, 608)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(89, 50)
        Me.okBtn.TabIndex = 0
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'team1Err
        '
        Me.team1Err.ContainerControl = Me
        '
        'team2Err
        '
        Me.team2Err.ContainerControl = Me
        '
        'team3Err
        '
        Me.team3Err.ContainerControl = Me
        '
        'team4Err
        '
        Me.team4Err.ContainerControl = Me
        '
        'team1Score
        '
        Me.team1Score.AutoSize = True
        Me.team1Score.BackColor = System.Drawing.Color.Transparent
        Me.team1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1Score.Location = New System.Drawing.Point(248, 176)
        Me.team1Score.Name = "team1Score"
        Me.team1Score.Size = New System.Drawing.Size(120, 39)
        Me.team1Score.TabIndex = 10
        Me.team1Score.Text = "Label1"
        '
        'team2Score
        '
        Me.team2Score.AutoSize = True
        Me.team2Score.BackColor = System.Drawing.Color.Transparent
        Me.team2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2Score.Location = New System.Drawing.Point(248, 281)
        Me.team2Score.Name = "team2Score"
        Me.team2Score.Size = New System.Drawing.Size(120, 39)
        Me.team2Score.TabIndex = 11
        Me.team2Score.Text = "Label2"
        '
        'team3Score
        '
        Me.team3Score.AutoSize = True
        Me.team3Score.BackColor = System.Drawing.Color.Transparent
        Me.team3Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3Score.Location = New System.Drawing.Point(248, 386)
        Me.team3Score.Name = "team3Score"
        Me.team3Score.Size = New System.Drawing.Size(120, 39)
        Me.team3Score.TabIndex = 12
        Me.team3Score.Text = "Label3"
        '
        'team4Score
        '
        Me.team4Score.AutoSize = True
        Me.team4Score.BackColor = System.Drawing.Color.Transparent
        Me.team4Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4Score.Location = New System.Drawing.Point(248, 491)
        Me.team4Score.Name = "team4Score"
        Me.team4Score.Size = New System.Drawing.Size(120, 39)
        Me.team4Score.TabIndex = 13
        Me.team4Score.Text = "Label4"
        '
        'team5Score
        '
        Me.team5Score.AutoSize = True
        Me.team5Score.BackColor = System.Drawing.Color.Transparent
        Me.team5Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5Score.Location = New System.Drawing.Point(248, 595)
        Me.team5Score.Name = "team5Score"
        Me.team5Score.Size = New System.Drawing.Size(120, 39)
        Me.team5Score.TabIndex = 16
        Me.team5Score.Text = "Label4"
        '
        'team5Txt
        '
        Me.team5Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5Txt.Location = New System.Drawing.Point(291, 543)
        Me.team5Txt.Name = "team5Txt"
        Me.team5Txt.Size = New System.Drawing.Size(222, 49)
        Me.team5Txt.TabIndex = 15
        Me.team5Txt.Text = "0"
        '
        'team5Lbl
        '
        Me.team5Lbl.AutoSize = True
        Me.team5Lbl.BackColor = System.Drawing.Color.Transparent
        Me.team5Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5Lbl.ForeColor = System.Drawing.Color.MediumBlue
        Me.team5Lbl.Location = New System.Drawing.Point(101, 546)
        Me.team5Lbl.Name = "team5Lbl"
        Me.team5Lbl.Size = New System.Drawing.Size(144, 42)
        Me.team5Lbl.TabIndex = 14
        Me.team5Lbl.Text = "Team 5"
        '
        'team5Err
        '
        Me.team5Err.ContainerControl = Me
        '
        'Final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Jeopardy.My.Resources.Resources.border
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.team5Score)
        Me.Controls.Add(Me.team5Txt)
        Me.Controls.Add(Me.team5Lbl)
        Me.Controls.Add(Me.team4Score)
        Me.Controls.Add(Me.team3Score)
        Me.Controls.Add(Me.team2Score)
        Me.Controls.Add(Me.team1Score)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.wagerLbl)
        Me.Controls.Add(Me.team4Txt)
        Me.Controls.Add(Me.team3Txt)
        Me.Controls.Add(Me.team2Txt)
        Me.Controls.Add(Me.team1Txt)
        Me.Controls.Add(Me.team4Lbl)
        Me.Controls.Add(Me.team3Lbl)
        Me.Controls.Add(Me.team2Lbl)
        Me.Controls.Add(Me.team1Lbl)
        Me.Controls.Add(Me.headingLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Final"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final"
        CType(Me.team1Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.team2Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.team3Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.team4Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.team5Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents headingLbl As System.Windows.Forms.Label
    Friend WithEvents team1Lbl As System.Windows.Forms.Label
    Friend WithEvents team2Lbl As System.Windows.Forms.Label
    Friend WithEvents team3Lbl As System.Windows.Forms.Label
    Friend WithEvents team4Lbl As System.Windows.Forms.Label
    Friend WithEvents team1Txt As System.Windows.Forms.TextBox
    Friend WithEvents team2Txt As System.Windows.Forms.TextBox
    Friend WithEvents team3Txt As System.Windows.Forms.TextBox
    Friend WithEvents team4Txt As System.Windows.Forms.TextBox
    Friend WithEvents wagerLbl As System.Windows.Forms.Label
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents team1Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents team2Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents team3Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents team4Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents team4Score As System.Windows.Forms.Label
    Friend WithEvents team3Score As System.Windows.Forms.Label
    Friend WithEvents team2Score As System.Windows.Forms.Label
    Friend WithEvents team1Score As System.Windows.Forms.Label
    Friend WithEvents team5Score As System.Windows.Forms.Label
    Friend WithEvents team5Txt As System.Windows.Forms.TextBox
    Friend WithEvents team5Lbl As System.Windows.Forms.Label
    Friend WithEvents team5Err As System.Windows.Forms.ErrorProvider
End Class
