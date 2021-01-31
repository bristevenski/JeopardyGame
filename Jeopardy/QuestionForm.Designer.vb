<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuestionForm))
        Me.doneBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.team3ChckBox = New System.Windows.Forms.CheckBox()
        Me.team4ChckBox = New System.Windows.Forms.CheckBox()
        Me.team2ChckBox = New System.Windows.Forms.CheckBox()
        Me.team1ChckBox = New System.Windows.Forms.CheckBox()
        Me.teamGroupBox = New System.Windows.Forms.GroupBox()
        Me.answerPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.team5ChckBox = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.answerBtn = New System.Windows.Forms.Button()
        Me.muteBtn = New System.Windows.Forms.Button()
        Me.mainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.questionTxt = New System.Windows.Forms.TextBox()
        Me.questionLbl = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.timerTxt = New System.Windows.Forms.TextBox()
        Me.teamGroupBox.SuspendLayout()
        Me.answerPanel.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'doneBtn
        '
        Me.doneBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.doneBtn.BackColor = System.Drawing.Color.White
        Me.mainPanel.SetColumnSpan(Me.doneBtn, 2)
        Me.doneBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.doneBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneBtn.Location = New System.Drawing.Point(751, 727)
        Me.doneBtn.Name = "doneBtn"
        Me.doneBtn.Size = New System.Drawing.Size(122, 50)
        Me.doneBtn.TabIndex = 0
        Me.doneBtn.Text = "DONE"
        Me.doneBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.White
        Me.mainPanel.SetColumnSpan(Me.backBtn, 2)
        Me.backBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(879, 727)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(122, 50)
        Me.backBtn.TabIndex = 3
        Me.backBtn.Text = "BACK"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'team3ChckBox
        '
        Me.team3ChckBox.AutoSize = True
        Me.team3ChckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team3ChckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3ChckBox.ForeColor = System.Drawing.Color.White
        Me.team3ChckBox.Location = New System.Drawing.Point(213, 3)
        Me.team3ChckBox.Name = "team3ChckBox"
        Me.team3ChckBox.Size = New System.Drawing.Size(186, 53)
        Me.team3ChckBox.TabIndex = 4
        Me.team3ChckBox.Text = "Team 3"
        Me.team3ChckBox.UseVisualStyleBackColor = True
        '
        'team4ChckBox
        '
        Me.team4ChckBox.AutoSize = True
        Me.team4ChckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team4ChckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4ChckBox.ForeColor = System.Drawing.Color.White
        Me.team4ChckBox.Location = New System.Drawing.Point(213, 62)
        Me.team4ChckBox.Name = "team4ChckBox"
        Me.team4ChckBox.Size = New System.Drawing.Size(186, 53)
        Me.team4ChckBox.TabIndex = 5
        Me.team4ChckBox.Text = "Team 4"
        Me.team4ChckBox.UseVisualStyleBackColor = True
        '
        'team2ChckBox
        '
        Me.team2ChckBox.AutoSize = True
        Me.team2ChckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team2ChckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2ChckBox.ForeColor = System.Drawing.Color.White
        Me.team2ChckBox.Location = New System.Drawing.Point(23, 62)
        Me.team2ChckBox.Name = "team2ChckBox"
        Me.team2ChckBox.Size = New System.Drawing.Size(184, 53)
        Me.team2ChckBox.TabIndex = 6
        Me.team2ChckBox.Text = "Team 2"
        Me.team2ChckBox.UseVisualStyleBackColor = True
        '
        'team1ChckBox
        '
        Me.team1ChckBox.AutoSize = True
        Me.team1ChckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team1ChckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1ChckBox.ForeColor = System.Drawing.Color.White
        Me.team1ChckBox.Location = New System.Drawing.Point(23, 3)
        Me.team1ChckBox.Name = "team1ChckBox"
        Me.team1ChckBox.Size = New System.Drawing.Size(184, 53)
        Me.team1ChckBox.TabIndex = 7
        Me.team1ChckBox.Text = "Team 1"
        Me.team1ChckBox.UseVisualStyleBackColor = True
        '
        'teamGroupBox
        '
        Me.teamGroupBox.Controls.Add(Me.answerPanel)
        Me.teamGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teamGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.teamGroupBox.Location = New System.Drawing.Point(312, 572)
        Me.teamGroupBox.Name = "teamGroupBox"
        Me.mainPanel.SetRowSpan(Me.teamGroupBox, 3)
        Me.teamGroupBox.Size = New System.Drawing.Size(408, 205)
        Me.teamGroupBox.TabIndex = 9
        Me.teamGroupBox.TabStop = False
        Me.teamGroupBox.Text = "Answered Correctly"
        '
        'answerPanel
        '
        Me.answerPanel.ColumnCount = 3
        Me.answerPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.answerPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5!))
        Me.answerPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5!))
        Me.answerPanel.Controls.Add(Me.team5ChckBox, 1, 2)
        Me.answerPanel.Controls.Add(Me.team2ChckBox, 1, 1)
        Me.answerPanel.Controls.Add(Me.team3ChckBox, 2, 0)
        Me.answerPanel.Controls.Add(Me.team4ChckBox, 2, 1)
        Me.answerPanel.Controls.Add(Me.team1ChckBox, 1, 0)
        Me.answerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.answerPanel.Location = New System.Drawing.Point(3, 25)
        Me.answerPanel.Name = "answerPanel"
        Me.answerPanel.RowCount = 3
        Me.answerPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.answerPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.answerPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.answerPanel.Size = New System.Drawing.Size(402, 177)
        Me.answerPanel.TabIndex = 8
        '
        'team5ChckBox
        '
        Me.team5ChckBox.AutoSize = True
        Me.answerPanel.SetColumnSpan(Me.team5ChckBox, 2)
        Me.team5ChckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team5ChckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5ChckBox.ForeColor = System.Drawing.Color.White
        Me.team5ChckBox.Location = New System.Drawing.Point(23, 121)
        Me.team5ChckBox.Name = "team5ChckBox"
        Me.team5ChckBox.Size = New System.Drawing.Size(376, 53)
        Me.team5ChckBox.TabIndex = 8
        Me.team5ChckBox.Text = "Team 5"
        Me.team5ChckBox.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'answerBtn
        '
        Me.answerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.answerBtn.BackColor = System.Drawing.Color.White
        Me.mainPanel.SetColumnSpan(Me.answerBtn, 2)
        Me.answerBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.answerBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerBtn.Location = New System.Drawing.Point(797, 673)
        Me.answerBtn.Name = "answerBtn"
        Me.answerBtn.Size = New System.Drawing.Size(158, 48)
        Me.answerBtn.TabIndex = 14
        Me.answerBtn.Text = "ANSWER"
        Me.answerBtn.UseVisualStyleBackColor = False
        '
        'muteBtn
        '
        Me.muteBtn.BackgroundImage = CType(resources.GetObject("muteBtn.BackgroundImage"), System.Drawing.Image)
        Me.muteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.muteBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.muteBtn.Location = New System.Drawing.Point(3, 727)
        Me.muteBtn.Name = "muteBtn"
        Me.muteBtn.Size = New System.Drawing.Size(45, 50)
        Me.muteBtn.TabIndex = 16
        Me.muteBtn.UseVisualStyleBackColor = True
        '
        'mainPanel
        '
        Me.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainPanel.ColumnCount = 10
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.5!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.5!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainPanel.Controls.Add(Me.backBtn, 7, 5)
        Me.mainPanel.Controls.Add(Me.questionTxt, 0, 1)
        Me.mainPanel.Controls.Add(Me.questionLbl, 0, 0)
        Me.mainPanel.Controls.Add(Me.answerBtn, 6, 4)
        Me.mainPanel.Controls.Add(Me.doneBtn, 5, 5)
        Me.mainPanel.Controls.Add(Me.timeLbl, 1, 3)
        Me.mainPanel.Controls.Add(Me.timerTxt, 1, 4)
        Me.mainPanel.Controls.Add(Me.muteBtn, 0, 5)
        Me.mainPanel.Controls.Add(Me.teamGroupBox, 3, 3)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.RowCount = 6
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.mainPanel.Size = New System.Drawing.Size(1036, 780)
        Me.mainPanel.TabIndex = 17
        '
        'questionTxt
        '
        Me.questionTxt.BackColor = System.Drawing.Color.Navy
        Me.questionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mainPanel.SetColumnSpan(Me.questionTxt, 10)
        Me.questionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.questionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionTxt.ForeColor = System.Drawing.Color.White
        Me.questionTxt.Location = New System.Drawing.Point(3, 81)
        Me.questionTxt.Multiline = True
        Me.questionTxt.Name = "questionTxt"
        Me.questionTxt.ReadOnly = True
        Me.questionTxt.Size = New System.Drawing.Size(1030, 384)
        Me.questionTxt.TabIndex = 15
        Me.questionTxt.Text = "*Question Text*"
        Me.questionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'questionLbl
        '
        Me.questionLbl.AutoSize = True
        Me.mainPanel.SetColumnSpan(Me.questionLbl, 10)
        Me.questionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.questionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionLbl.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.questionLbl.Location = New System.Drawing.Point(3, 0)
        Me.questionLbl.Name = "questionLbl"
        Me.questionLbl.Size = New System.Drawing.Size(1030, 78)
        Me.questionLbl.TabIndex = 1
        Me.questionLbl.Text = "*Category/Value*"
        Me.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.BackColor = System.Drawing.Color.Transparent
        Me.timeLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLbl.ForeColor = System.Drawing.Color.White
        Me.timeLbl.Location = New System.Drawing.Point(54, 569)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(201, 101)
        Me.timeLbl.TabIndex = 11
        Me.timeLbl.Text = "Seconds Remaining:"
        Me.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerTxt
        '
        Me.timerTxt.BackColor = System.Drawing.Color.DarkRed
        Me.timerTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timerTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerTxt.ForeColor = System.Drawing.Color.Black
        Me.timerTxt.Location = New System.Drawing.Point(54, 673)
        Me.timerTxt.Name = "timerTxt"
        Me.timerTxt.ReadOnly = True
        Me.mainPanel.SetRowSpan(Me.timerTxt, 2)
        Me.timerTxt.Size = New System.Drawing.Size(201, 80)
        Me.timerTxt.TabIndex = 10
        Me.timerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuestionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuestionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.teamGroupBox.ResumeLayout(False)
        Me.answerPanel.ResumeLayout(False)
        Me.answerPanel.PerformLayout()
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents doneBtn As System.Windows.Forms.Button
    Friend WithEvents backBtn As System.Windows.Forms.Button
    Friend WithEvents team3ChckBox As System.Windows.Forms.CheckBox
    Friend WithEvents team4ChckBox As System.Windows.Forms.CheckBox
    Friend WithEvents team2ChckBox As System.Windows.Forms.CheckBox
    Friend WithEvents team1ChckBox As System.Windows.Forms.CheckBox
    Friend WithEvents teamGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents answerBtn As System.Windows.Forms.Button
    Friend WithEvents muteBtn As System.Windows.Forms.Button
    Friend WithEvents mainPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents questionTxt As System.Windows.Forms.TextBox
    Friend WithEvents questionLbl As System.Windows.Forms.Label
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents timerTxt As System.Windows.Forms.TextBox
    Friend WithEvents answerPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents team5ChckBox As System.Windows.Forms.CheckBox
End Class
