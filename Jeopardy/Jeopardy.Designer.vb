<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeopardy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeopardy))
        Me.scoreGroupBox = New System.Windows.Forms.GroupBox()
        Me.scorePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.fifthTeam = New System.Windows.Forms.Label()
        Me.team5Score = New System.Windows.Forms.Label()
        Me.team5Place = New System.Windows.Forms.Label()
        Me.team5Name = New System.Windows.Forms.Label()
        Me.fourthTeam = New System.Windows.Forms.Label()
        Me.team4Place = New System.Windows.Forms.Label()
        Me.team3Place = New System.Windows.Forms.Label()
        Me.team1Name = New System.Windows.Forms.Label()
        Me.team4Score = New System.Windows.Forms.Label()
        Me.thirdTeam = New System.Windows.Forms.Label()
        Me.team4Name = New System.Windows.Forms.Label()
        Me.team1Score = New System.Windows.Forms.Label()
        Me.team2Place = New System.Windows.Forms.Label()
        Me.team1Place = New System.Windows.Forms.Label()
        Me.team3Score = New System.Windows.Forms.Label()
        Me.secondTeam = New System.Windows.Forms.Label()
        Me.firstTeam = New System.Windows.Forms.Label()
        Me.Team2Name = New System.Windows.Forms.Label()
        Me.team3Name = New System.Windows.Forms.Label()
        Me.team2Score = New System.Windows.Forms.Label()
        Me.C3Q5Btn = New System.Windows.Forms.Button()
        Me.C4Q1Btn = New System.Windows.Forms.Button()
        Me.C3Q4Btn = New System.Windows.Forms.Button()
        Me.C4Q2Btn = New System.Windows.Forms.Button()
        Me.C3Q3Btn = New System.Windows.Forms.Button()
        Me.C4Q3Btn = New System.Windows.Forms.Button()
        Me.C1Q5Btn = New System.Windows.Forms.Button()
        Me.C4Q4Btn = New System.Windows.Forms.Button()
        Me.C3Q2Btn = New System.Windows.Forms.Button()
        Me.C5Q1Btn = New System.Windows.Forms.Button()
        Me.C3Q1Btn = New System.Windows.Forms.Button()
        Me.C5Q2Btn = New System.Windows.Forms.Button()
        Me.C2Q5Btn = New System.Windows.Forms.Button()
        Me.C5Q3Btn = New System.Windows.Forms.Button()
        Me.C2Q4Btn = New System.Windows.Forms.Button()
        Me.C4Q5Btn = New System.Windows.Forms.Button()
        Me.C2Q3Btn = New System.Windows.Forms.Button()
        Me.C5Q4Btn = New System.Windows.Forms.Button()
        Me.C2Q2Btn = New System.Windows.Forms.Button()
        Me.C2Q1Btn = New System.Windows.Forms.Button()
        Me.C1Q1Btn = New System.Windows.Forms.Button()
        Me.C1Q4Btn = New System.Windows.Forms.Button()
        Me.C1Q3Btn = New System.Windows.Forms.Button()
        Me.C1Q2Btn = New System.Windows.Forms.Button()
        Me.C5Q5Btn = New System.Windows.Forms.Button()
        Me.cat5Lbl = New System.Windows.Forms.Label()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.cat4Lbl = New System.Windows.Forms.Label()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.cat3Lbl = New System.Windows.Forms.Label()
        Me.cat1Lbl = New System.Windows.Forms.Label()
        Me.cat2Lbl = New System.Windows.Forms.Label()
        Me.mainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.penaltyBtn = New System.Windows.Forms.Button()
        Me.scoreGroupBox.SuspendLayout()
        Me.scorePanel.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'scoreGroupBox
        '
        Me.scoreGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scoreGroupBox.AutoSize = True
        Me.scoreGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.scoreGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.mainPanel.SetColumnSpan(Me.scoreGroupBox, 7)
        Me.scoreGroupBox.Controls.Add(Me.scorePanel)
        Me.scoreGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.scoreGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.scoreGroupBox.Name = "scoreGroupBox"
        Me.scoreGroupBox.Size = New System.Drawing.Size(1108, 150)
        Me.scoreGroupBox.TabIndex = 47
        Me.scoreGroupBox.TabStop = False
        Me.scoreGroupBox.Text = "Scores"
        '
        'scorePanel
        '
        Me.scorePanel.ColumnCount = 15
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.860465!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.906977!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.860465!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.906977!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.860465!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.906977!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.860465!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.906977!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.860465!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256!))
        Me.scorePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.906977!))
        Me.scorePanel.Controls.Add(Me.fifthTeam, 14, 1)
        Me.scorePanel.Controls.Add(Me.team5Score, 13, 1)
        Me.scorePanel.Controls.Add(Me.team5Place, 14, 0)
        Me.scorePanel.Controls.Add(Me.team5Name, 13, 0)
        Me.scorePanel.Controls.Add(Me.fourthTeam, 11, 1)
        Me.scorePanel.Controls.Add(Me.team4Place, 11, 0)
        Me.scorePanel.Controls.Add(Me.team3Place, 8, 0)
        Me.scorePanel.Controls.Add(Me.team1Name, 1, 0)
        Me.scorePanel.Controls.Add(Me.team4Score, 10, 1)
        Me.scorePanel.Controls.Add(Me.thirdTeam, 8, 1)
        Me.scorePanel.Controls.Add(Me.team4Name, 10, 0)
        Me.scorePanel.Controls.Add(Me.team1Score, 1, 1)
        Me.scorePanel.Controls.Add(Me.team2Place, 5, 0)
        Me.scorePanel.Controls.Add(Me.team1Place, 2, 0)
        Me.scorePanel.Controls.Add(Me.team3Score, 7, 1)
        Me.scorePanel.Controls.Add(Me.secondTeam, 5, 1)
        Me.scorePanel.Controls.Add(Me.firstTeam, 2, 1)
        Me.scorePanel.Controls.Add(Me.Team2Name, 4, 0)
        Me.scorePanel.Controls.Add(Me.team3Name, 7, 0)
        Me.scorePanel.Controls.Add(Me.team2Score, 4, 1)
        Me.scorePanel.Location = New System.Drawing.Point(9, 40)
        Me.scorePanel.Name = "scorePanel"
        Me.scorePanel.RowCount = 2
        Me.scorePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727!))
        Me.scorePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273!))
        Me.scorePanel.Size = New System.Drawing.Size(1048, 110)
        Me.scorePanel.TabIndex = 51
        '
        'fifthTeam
        '
        Me.fifthTeam.AutoEllipsis = True
        Me.fifthTeam.AutoSize = True
        Me.fifthTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fifthTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthTeam.Location = New System.Drawing.Point(961, 57)
        Me.fifthTeam.Name = "fifthTeam"
        Me.fifthTeam.Size = New System.Drawing.Size(84, 53)
        Me.fifthTeam.TabIndex = 54
        Me.fifthTeam.Text = "Label1"
        Me.fifthTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team5Score
        '
        Me.team5Score.AutoEllipsis = True
        Me.team5Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team5Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5Score.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.team5Score.Location = New System.Drawing.Point(854, 57)
        Me.team5Score.Name = "team5Score"
        Me.team5Score.Size = New System.Drawing.Size(101, 53)
        Me.team5Score.TabIndex = 53
        Me.team5Score.Text = "0"
        Me.team5Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team5Place
        '
        Me.team5Place.AutoEllipsis = True
        Me.team5Place.AutoSize = True
        Me.team5Place.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team5Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5Place.Location = New System.Drawing.Point(961, 0)
        Me.team5Place.Name = "team5Place"
        Me.team5Place.Size = New System.Drawing.Size(84, 57)
        Me.team5Place.TabIndex = 52
        Me.team5Place.Text = "Place:"
        Me.team5Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team5Name
        '
        Me.team5Name.AutoEllipsis = True
        Me.team5Name.AutoSize = True
        Me.team5Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team5Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team5Name.ForeColor = System.Drawing.Color.White
        Me.team5Name.Location = New System.Drawing.Point(854, 0)
        Me.team5Name.Name = "team5Name"
        Me.team5Name.Size = New System.Drawing.Size(101, 57)
        Me.team5Name.TabIndex = 51
        Me.team5Name.Text = "Team 5"
        Me.team5Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fourthTeam
        '
        Me.fourthTeam.AutoEllipsis = True
        Me.fourthTeam.AutoSize = True
        Me.fourthTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fourthTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthTeam.Location = New System.Drawing.Point(753, 57)
        Me.fourthTeam.Name = "fourthTeam"
        Me.fourthTeam.Size = New System.Drawing.Size(76, 53)
        Me.fourthTeam.TabIndex = 35
        Me.fourthTeam.Text = "Label1"
        Me.fourthTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team4Place
        '
        Me.team4Place.AutoEllipsis = True
        Me.team4Place.AutoSize = True
        Me.team4Place.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team4Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4Place.Location = New System.Drawing.Point(753, 0)
        Me.team4Place.Name = "team4Place"
        Me.team4Place.Size = New System.Drawing.Size(76, 57)
        Me.team4Place.TabIndex = 49
        Me.team4Place.Text = "Place:"
        Me.team4Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team3Place
        '
        Me.team3Place.AutoEllipsis = True
        Me.team3Place.AutoSize = True
        Me.team3Place.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team3Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3Place.Location = New System.Drawing.Point(545, 0)
        Me.team3Place.Name = "team3Place"
        Me.team3Place.Size = New System.Drawing.Size(76, 57)
        Me.team3Place.TabIndex = 50
        Me.team3Place.Text = "Place:"
        Me.team3Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team1Name
        '
        Me.team1Name.AutoEllipsis = True
        Me.team1Name.AutoSize = True
        Me.team1Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team1Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1Name.ForeColor = System.Drawing.Color.White
        Me.team1Name.Location = New System.Drawing.Point(22, 0)
        Me.team1Name.Name = "team1Name"
        Me.team1Name.Size = New System.Drawing.Size(101, 57)
        Me.team1Name.TabIndex = 38
        Me.team1Name.Text = "Team 1"
        Me.team1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team4Score
        '
        Me.team4Score.AutoEllipsis = True
        Me.team4Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team4Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4Score.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.team4Score.Location = New System.Drawing.Point(646, 57)
        Me.team4Score.Name = "team4Score"
        Me.team4Score.Size = New System.Drawing.Size(101, 53)
        Me.team4Score.TabIndex = 43
        Me.team4Score.Text = "0"
        Me.team4Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'thirdTeam
        '
        Me.thirdTeam.AutoEllipsis = True
        Me.thirdTeam.AutoSize = True
        Me.thirdTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thirdTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdTeam.Location = New System.Drawing.Point(545, 57)
        Me.thirdTeam.Name = "thirdTeam"
        Me.thirdTeam.Size = New System.Drawing.Size(76, 53)
        Me.thirdTeam.TabIndex = 36
        Me.thirdTeam.Text = "Label2"
        Me.thirdTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team4Name
        '
        Me.team4Name.AutoEllipsis = True
        Me.team4Name.AutoSize = True
        Me.team4Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team4Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team4Name.ForeColor = System.Drawing.Color.White
        Me.team4Name.Location = New System.Drawing.Point(646, 0)
        Me.team4Name.Name = "team4Name"
        Me.team4Name.Size = New System.Drawing.Size(101, 57)
        Me.team4Name.TabIndex = 41
        Me.team4Name.Text = "Team 4"
        Me.team4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team1Score
        '
        Me.team1Score.AutoEllipsis = True
        Me.team1Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1Score.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.team1Score.Location = New System.Drawing.Point(22, 57)
        Me.team1Score.Name = "team1Score"
        Me.team1Score.Size = New System.Drawing.Size(101, 53)
        Me.team1Score.TabIndex = 46
        Me.team1Score.Text = "0"
        Me.team1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team2Place
        '
        Me.team2Place.AutoEllipsis = True
        Me.team2Place.AutoSize = True
        Me.team2Place.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team2Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2Place.Location = New System.Drawing.Point(337, 0)
        Me.team2Place.Name = "team2Place"
        Me.team2Place.Size = New System.Drawing.Size(76, 57)
        Me.team2Place.TabIndex = 48
        Me.team2Place.Text = "Place:"
        Me.team2Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team1Place
        '
        Me.team1Place.AutoEllipsis = True
        Me.team1Place.AutoSize = True
        Me.team1Place.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team1Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1Place.Location = New System.Drawing.Point(129, 0)
        Me.team1Place.Name = "team1Place"
        Me.team1Place.Size = New System.Drawing.Size(76, 57)
        Me.team1Place.TabIndex = 47
        Me.team1Place.Text = "Place:"
        Me.team1Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team3Score
        '
        Me.team3Score.AutoEllipsis = True
        Me.team3Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team3Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3Score.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.team3Score.Location = New System.Drawing.Point(438, 57)
        Me.team3Score.Name = "team3Score"
        Me.team3Score.Size = New System.Drawing.Size(101, 53)
        Me.team3Score.TabIndex = 44
        Me.team3Score.Text = "0"
        Me.team3Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'secondTeam
        '
        Me.secondTeam.AutoEllipsis = True
        Me.secondTeam.AutoSize = True
        Me.secondTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.secondTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondTeam.Location = New System.Drawing.Point(337, 57)
        Me.secondTeam.Name = "secondTeam"
        Me.secondTeam.Size = New System.Drawing.Size(76, 53)
        Me.secondTeam.TabIndex = 37
        Me.secondTeam.Text = "Label3"
        Me.secondTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'firstTeam
        '
        Me.firstTeam.AutoEllipsis = True
        Me.firstTeam.AutoSize = True
        Me.firstTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.firstTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstTeam.Location = New System.Drawing.Point(129, 57)
        Me.firstTeam.Name = "firstTeam"
        Me.firstTeam.Size = New System.Drawing.Size(76, 53)
        Me.firstTeam.TabIndex = 38
        Me.firstTeam.Text = "Label4"
        Me.firstTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Team2Name
        '
        Me.Team2Name.AutoEllipsis = True
        Me.Team2Name.AutoSize = True
        Me.Team2Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Team2Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Team2Name.ForeColor = System.Drawing.Color.White
        Me.Team2Name.Location = New System.Drawing.Point(230, 0)
        Me.Team2Name.Name = "Team2Name"
        Me.Team2Name.Size = New System.Drawing.Size(101, 57)
        Me.Team2Name.TabIndex = 39
        Me.Team2Name.Text = "Team 2"
        Me.Team2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team3Name
        '
        Me.team3Name.AutoEllipsis = True
        Me.team3Name.AutoSize = True
        Me.team3Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team3Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team3Name.ForeColor = System.Drawing.Color.White
        Me.team3Name.Location = New System.Drawing.Point(438, 0)
        Me.team3Name.Name = "team3Name"
        Me.team3Name.Size = New System.Drawing.Size(101, 57)
        Me.team3Name.TabIndex = 40
        Me.team3Name.Text = "Team 3"
        Me.team3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'team2Score
        '
        Me.team2Score.AutoEllipsis = True
        Me.team2Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.team2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2Score.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.team2Score.Location = New System.Drawing.Point(230, 57)
        Me.team2Score.Name = "team2Score"
        Me.team2Score.Size = New System.Drawing.Size(101, 53)
        Me.team2Score.TabIndex = 45
        Me.team2Score.Text = "0"
        Me.team2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C3Q5Btn
        '
        Me.C3Q5Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C3Q5Btn.AutoSize = True
        Me.C3Q5Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C3Q5Btn.BackColor = System.Drawing.Color.White
        Me.C3Q5Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3Q5Btn.Location = New System.Drawing.Point(452, 549)
        Me.C3Q5Btn.Name = "C3Q5Btn"
        Me.C3Q5Btn.Size = New System.Drawing.Size(205, 72)
        Me.C3Q5Btn.TabIndex = 14
        Me.C3Q5Btn.Tag = "35"
        Me.C3Q5Btn.Text = "*Value*"
        Me.C3Q5Btn.UseVisualStyleBackColor = False
        '
        'C4Q1Btn
        '
        Me.C4Q1Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C4Q1Btn.AutoSize = True
        Me.C4Q1Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C4Q1Btn.BackColor = System.Drawing.Color.White
        Me.C4Q1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4Q1Btn.Location = New System.Drawing.Point(663, 237)
        Me.C4Q1Btn.Name = "C4Q1Btn"
        Me.C4Q1Btn.Size = New System.Drawing.Size(205, 72)
        Me.C4Q1Btn.TabIndex = 15
        Me.C4Q1Btn.Tag = "41"
        Me.C4Q1Btn.Text = "*Value*"
        Me.C4Q1Btn.UseVisualStyleBackColor = False
        '
        'C3Q4Btn
        '
        Me.C3Q4Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C3Q4Btn.AutoSize = True
        Me.C3Q4Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C3Q4Btn.BackColor = System.Drawing.Color.White
        Me.C3Q4Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3Q4Btn.Location = New System.Drawing.Point(452, 471)
        Me.C3Q4Btn.Name = "C3Q4Btn"
        Me.C3Q4Btn.Size = New System.Drawing.Size(205, 72)
        Me.C3Q4Btn.TabIndex = 13
        Me.C3Q4Btn.Tag = "34"
        Me.C3Q4Btn.Text = "*Value*"
        Me.C3Q4Btn.UseVisualStyleBackColor = False
        '
        'C4Q2Btn
        '
        Me.C4Q2Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C4Q2Btn.AutoSize = True
        Me.C4Q2Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C4Q2Btn.BackColor = System.Drawing.Color.White
        Me.C4Q2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4Q2Btn.Location = New System.Drawing.Point(663, 315)
        Me.C4Q2Btn.Name = "C4Q2Btn"
        Me.C4Q2Btn.Size = New System.Drawing.Size(205, 72)
        Me.C4Q2Btn.TabIndex = 16
        Me.C4Q2Btn.Tag = "42"
        Me.C4Q2Btn.Text = "*Value*"
        Me.C4Q2Btn.UseVisualStyleBackColor = False
        '
        'C3Q3Btn
        '
        Me.C3Q3Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C3Q3Btn.AutoSize = True
        Me.C3Q3Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C3Q3Btn.BackColor = System.Drawing.Color.White
        Me.C3Q3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3Q3Btn.Location = New System.Drawing.Point(452, 393)
        Me.C3Q3Btn.Name = "C3Q3Btn"
        Me.C3Q3Btn.Size = New System.Drawing.Size(205, 72)
        Me.C3Q3Btn.TabIndex = 12
        Me.C3Q3Btn.Tag = "33"
        Me.C3Q3Btn.Text = "*Value*"
        Me.C3Q3Btn.UseVisualStyleBackColor = False
        '
        'C4Q3Btn
        '
        Me.C4Q3Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C4Q3Btn.AutoSize = True
        Me.C4Q3Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C4Q3Btn.BackColor = System.Drawing.Color.White
        Me.C4Q3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4Q3Btn.Location = New System.Drawing.Point(663, 393)
        Me.C4Q3Btn.Name = "C4Q3Btn"
        Me.C4Q3Btn.Size = New System.Drawing.Size(205, 72)
        Me.C4Q3Btn.TabIndex = 17
        Me.C4Q3Btn.Tag = "43"
        Me.C4Q3Btn.Text = "*Value*"
        Me.C4Q3Btn.UseVisualStyleBackColor = False
        '
        'C1Q5Btn
        '
        Me.C1Q5Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Q5Btn.AutoSize = True
        Me.C1Q5Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C1Q5Btn.BackColor = System.Drawing.Color.White
        Me.C1Q5Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Q5Btn.Location = New System.Drawing.Point(30, 549)
        Me.C1Q5Btn.Name = "C1Q5Btn"
        Me.C1Q5Btn.Size = New System.Drawing.Size(205, 72)
        Me.C1Q5Btn.TabIndex = 11
        Me.C1Q5Btn.Tag = "15"
        Me.C1Q5Btn.Text = "*Value*"
        Me.C1Q5Btn.UseVisualStyleBackColor = False
        '
        'C4Q4Btn
        '
        Me.C4Q4Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C4Q4Btn.AutoSize = True
        Me.C4Q4Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C4Q4Btn.BackColor = System.Drawing.Color.White
        Me.C4Q4Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4Q4Btn.Location = New System.Drawing.Point(663, 471)
        Me.C4Q4Btn.Name = "C4Q4Btn"
        Me.C4Q4Btn.Size = New System.Drawing.Size(205, 72)
        Me.C4Q4Btn.TabIndex = 18
        Me.C4Q4Btn.Tag = "44"
        Me.C4Q4Btn.Text = "*Value*"
        Me.C4Q4Btn.UseVisualStyleBackColor = False
        '
        'C3Q2Btn
        '
        Me.C3Q2Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C3Q2Btn.AutoSize = True
        Me.C3Q2Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C3Q2Btn.BackColor = System.Drawing.Color.White
        Me.C3Q2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3Q2Btn.Location = New System.Drawing.Point(452, 315)
        Me.C3Q2Btn.Name = "C3Q2Btn"
        Me.C3Q2Btn.Size = New System.Drawing.Size(205, 72)
        Me.C3Q2Btn.TabIndex = 10
        Me.C3Q2Btn.Tag = "32"
        Me.C3Q2Btn.Text = "*Value*"
        Me.C3Q2Btn.UseVisualStyleBackColor = False
        '
        'C5Q1Btn
        '
        Me.C5Q1Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C5Q1Btn.AutoSize = True
        Me.C5Q1Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C5Q1Btn.BackColor = System.Drawing.Color.White
        Me.C5Q1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5Q1Btn.Location = New System.Drawing.Point(874, 237)
        Me.C5Q1Btn.Name = "C5Q1Btn"
        Me.C5Q1Btn.Size = New System.Drawing.Size(205, 72)
        Me.C5Q1Btn.TabIndex = 19
        Me.C5Q1Btn.Tag = "51"
        Me.C5Q1Btn.Text = "*Value*"
        Me.C5Q1Btn.UseVisualStyleBackColor = False
        '
        'C3Q1Btn
        '
        Me.C3Q1Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C3Q1Btn.AutoSize = True
        Me.C3Q1Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C3Q1Btn.BackColor = System.Drawing.Color.White
        Me.C3Q1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3Q1Btn.Location = New System.Drawing.Point(452, 237)
        Me.C3Q1Btn.Name = "C3Q1Btn"
        Me.C3Q1Btn.Size = New System.Drawing.Size(205, 72)
        Me.C3Q1Btn.TabIndex = 9
        Me.C3Q1Btn.Tag = "31"
        Me.C3Q1Btn.Text = "*Value*"
        Me.C3Q1Btn.UseVisualStyleBackColor = False
        '
        'C5Q2Btn
        '
        Me.C5Q2Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C5Q2Btn.AutoSize = True
        Me.C5Q2Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C5Q2Btn.BackColor = System.Drawing.Color.White
        Me.C5Q2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5Q2Btn.Location = New System.Drawing.Point(874, 315)
        Me.C5Q2Btn.Name = "C5Q2Btn"
        Me.C5Q2Btn.Size = New System.Drawing.Size(205, 72)
        Me.C5Q2Btn.TabIndex = 20
        Me.C5Q2Btn.Tag = "52"
        Me.C5Q2Btn.Text = "*Value*"
        Me.C5Q2Btn.UseVisualStyleBackColor = False
        '
        'C2Q5Btn
        '
        Me.C2Q5Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2Q5Btn.AutoSize = True
        Me.C2Q5Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C2Q5Btn.BackColor = System.Drawing.Color.White
        Me.C2Q5Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Q5Btn.Location = New System.Drawing.Point(241, 549)
        Me.C2Q5Btn.Name = "C2Q5Btn"
        Me.C2Q5Btn.Size = New System.Drawing.Size(205, 72)
        Me.C2Q5Btn.TabIndex = 8
        Me.C2Q5Btn.Tag = "25"
        Me.C2Q5Btn.Text = "*Value*"
        Me.C2Q5Btn.UseVisualStyleBackColor = False
        '
        'C5Q3Btn
        '
        Me.C5Q3Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C5Q3Btn.AutoSize = True
        Me.C5Q3Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C5Q3Btn.BackColor = System.Drawing.Color.White
        Me.C5Q3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5Q3Btn.Location = New System.Drawing.Point(874, 393)
        Me.C5Q3Btn.Name = "C5Q3Btn"
        Me.C5Q3Btn.Size = New System.Drawing.Size(205, 72)
        Me.C5Q3Btn.TabIndex = 21
        Me.C5Q3Btn.Tag = "53"
        Me.C5Q3Btn.Text = "*Value*"
        Me.C5Q3Btn.UseVisualStyleBackColor = False
        '
        'C2Q4Btn
        '
        Me.C2Q4Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2Q4Btn.AutoSize = True
        Me.C2Q4Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C2Q4Btn.BackColor = System.Drawing.Color.White
        Me.C2Q4Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Q4Btn.Location = New System.Drawing.Point(241, 471)
        Me.C2Q4Btn.Name = "C2Q4Btn"
        Me.C2Q4Btn.Size = New System.Drawing.Size(205, 72)
        Me.C2Q4Btn.TabIndex = 7
        Me.C2Q4Btn.Tag = "24"
        Me.C2Q4Btn.Text = "*Value*"
        Me.C2Q4Btn.UseVisualStyleBackColor = False
        '
        'C4Q5Btn
        '
        Me.C4Q5Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C4Q5Btn.AutoSize = True
        Me.C4Q5Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C4Q5Btn.BackColor = System.Drawing.Color.White
        Me.C4Q5Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4Q5Btn.Location = New System.Drawing.Point(663, 549)
        Me.C4Q5Btn.Name = "C4Q5Btn"
        Me.C4Q5Btn.Size = New System.Drawing.Size(205, 72)
        Me.C4Q5Btn.TabIndex = 22
        Me.C4Q5Btn.Tag = "45"
        Me.C4Q5Btn.Text = "*Value*"
        Me.C4Q5Btn.UseVisualStyleBackColor = False
        '
        'C2Q3Btn
        '
        Me.C2Q3Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2Q3Btn.AutoSize = True
        Me.C2Q3Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C2Q3Btn.BackColor = System.Drawing.Color.White
        Me.C2Q3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Q3Btn.Location = New System.Drawing.Point(241, 393)
        Me.C2Q3Btn.Name = "C2Q3Btn"
        Me.C2Q3Btn.Size = New System.Drawing.Size(205, 72)
        Me.C2Q3Btn.TabIndex = 6
        Me.C2Q3Btn.Tag = "23"
        Me.C2Q3Btn.Text = "*Value*"
        Me.C2Q3Btn.UseVisualStyleBackColor = False
        '
        'C5Q4Btn
        '
        Me.C5Q4Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C5Q4Btn.AutoSize = True
        Me.C5Q4Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C5Q4Btn.BackColor = System.Drawing.Color.White
        Me.C5Q4Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5Q4Btn.Location = New System.Drawing.Point(874, 471)
        Me.C5Q4Btn.Name = "C5Q4Btn"
        Me.C5Q4Btn.Size = New System.Drawing.Size(205, 72)
        Me.C5Q4Btn.TabIndex = 23
        Me.C5Q4Btn.Tag = "54"
        Me.C5Q4Btn.Text = "*Value*"
        Me.C5Q4Btn.UseVisualStyleBackColor = False
        '
        'C2Q2Btn
        '
        Me.C2Q2Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2Q2Btn.AutoSize = True
        Me.C2Q2Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C2Q2Btn.BackColor = System.Drawing.Color.White
        Me.C2Q2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Q2Btn.Location = New System.Drawing.Point(241, 315)
        Me.C2Q2Btn.Name = "C2Q2Btn"
        Me.C2Q2Btn.Size = New System.Drawing.Size(205, 72)
        Me.C2Q2Btn.TabIndex = 5
        Me.C2Q2Btn.Tag = "22"
        Me.C2Q2Btn.Text = "*Value*"
        Me.C2Q2Btn.UseVisualStyleBackColor = False
        '
        'C2Q1Btn
        '
        Me.C2Q1Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2Q1Btn.AutoSize = True
        Me.C2Q1Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C2Q1Btn.BackColor = System.Drawing.Color.White
        Me.C2Q1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Q1Btn.Location = New System.Drawing.Point(241, 237)
        Me.C2Q1Btn.Name = "C2Q1Btn"
        Me.C2Q1Btn.Size = New System.Drawing.Size(205, 72)
        Me.C2Q1Btn.TabIndex = 4
        Me.C2Q1Btn.Tag = "21"
        Me.C2Q1Btn.Text = "*Value*"
        Me.C2Q1Btn.UseVisualStyleBackColor = False
        '
        'C1Q1Btn
        '
        Me.C1Q1Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Q1Btn.AutoSize = True
        Me.C1Q1Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C1Q1Btn.BackColor = System.Drawing.Color.White
        Me.C1Q1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Q1Btn.Location = New System.Drawing.Point(30, 237)
        Me.C1Q1Btn.Name = "C1Q1Btn"
        Me.C1Q1Btn.Size = New System.Drawing.Size(205, 72)
        Me.C1Q1Btn.TabIndex = 25
        Me.C1Q1Btn.Tag = "11"
        Me.C1Q1Btn.Text = "*Value*"
        Me.C1Q1Btn.UseVisualStyleBackColor = False
        '
        'C1Q4Btn
        '
        Me.C1Q4Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Q4Btn.AutoSize = True
        Me.C1Q4Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C1Q4Btn.BackColor = System.Drawing.Color.White
        Me.C1Q4Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Q4Btn.Location = New System.Drawing.Point(30, 471)
        Me.C1Q4Btn.Name = "C1Q4Btn"
        Me.C1Q4Btn.Size = New System.Drawing.Size(205, 72)
        Me.C1Q4Btn.TabIndex = 3
        Me.C1Q4Btn.Tag = "14"
        Me.C1Q4Btn.Text = "*Value*"
        Me.C1Q4Btn.UseVisualStyleBackColor = False
        '
        'C1Q3Btn
        '
        Me.C1Q3Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Q3Btn.AutoSize = True
        Me.C1Q3Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C1Q3Btn.BackColor = System.Drawing.Color.White
        Me.C1Q3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Q3Btn.Location = New System.Drawing.Point(30, 393)
        Me.C1Q3Btn.Name = "C1Q3Btn"
        Me.C1Q3Btn.Size = New System.Drawing.Size(205, 72)
        Me.C1Q3Btn.TabIndex = 1
        Me.C1Q3Btn.Tag = "13"
        Me.C1Q3Btn.Text = "*Value*"
        Me.C1Q3Btn.UseVisualStyleBackColor = False
        '
        'C1Q2Btn
        '
        Me.C1Q2Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Q2Btn.AutoSize = True
        Me.C1Q2Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C1Q2Btn.BackColor = System.Drawing.Color.White
        Me.C1Q2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Q2Btn.Location = New System.Drawing.Point(30, 315)
        Me.C1Q2Btn.Name = "C1Q2Btn"
        Me.C1Q2Btn.Size = New System.Drawing.Size(205, 72)
        Me.C1Q2Btn.TabIndex = 0
        Me.C1Q2Btn.Tag = "12"
        Me.C1Q2Btn.Text = "*Value*"
        Me.C1Q2Btn.UseVisualStyleBackColor = False
        '
        'C5Q5Btn
        '
        Me.C5Q5Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C5Q5Btn.AutoSize = True
        Me.C5Q5Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.C5Q5Btn.BackColor = System.Drawing.Color.White
        Me.C5Q5Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5Q5Btn.Location = New System.Drawing.Point(874, 549)
        Me.C5Q5Btn.Name = "C5Q5Btn"
        Me.C5Q5Btn.Size = New System.Drawing.Size(205, 72)
        Me.C5Q5Btn.TabIndex = 24
        Me.C5Q5Btn.Tag = "55"
        Me.C5Q5Btn.Text = "*Value*"
        Me.C5Q5Btn.UseVisualStyleBackColor = False
        '
        'cat5Lbl
        '
        Me.cat5Lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cat5Lbl.AutoSize = True
        Me.cat5Lbl.BackColor = System.Drawing.Color.Transparent
        Me.cat5Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat5Lbl.ForeColor = System.Drawing.Color.White
        Me.cat5Lbl.Location = New System.Drawing.Point(874, 156)
        Me.cat5Lbl.Name = "cat5Lbl"
        Me.cat5Lbl.Size = New System.Drawing.Size(205, 78)
        Me.cat5Lbl.TabIndex = 29
        Me.cat5Lbl.Text = "*Category 5*"
        Me.cat5Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.AutoSize = True
        Me.exitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.exitBtn.BackColor = System.Drawing.Color.White
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(663, 705)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(205, 72)
        Me.exitBtn.TabIndex = 26
        Me.exitBtn.Text = "EXIT"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'cat4Lbl
        '
        Me.cat4Lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cat4Lbl.AutoSize = True
        Me.cat4Lbl.BackColor = System.Drawing.Color.Transparent
        Me.cat4Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat4Lbl.ForeColor = System.Drawing.Color.White
        Me.cat4Lbl.Location = New System.Drawing.Point(663, 156)
        Me.cat4Lbl.Name = "cat4Lbl"
        Me.cat4Lbl.Size = New System.Drawing.Size(205, 78)
        Me.cat4Lbl.TabIndex = 30
        Me.cat4Lbl.Text = "*Category 4*"
        Me.cat4Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resetBtn
        '
        Me.resetBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resetBtn.AutoSize = True
        Me.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.resetBtn.BackColor = System.Drawing.Color.White
        Me.resetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetBtn.Location = New System.Drawing.Point(874, 705)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(205, 72)
        Me.resetBtn.TabIndex = 27
        Me.resetBtn.Text = "RESET"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'cat3Lbl
        '
        Me.cat3Lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cat3Lbl.AutoSize = True
        Me.cat3Lbl.BackColor = System.Drawing.Color.Transparent
        Me.cat3Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat3Lbl.ForeColor = System.Drawing.Color.White
        Me.cat3Lbl.Location = New System.Drawing.Point(452, 156)
        Me.cat3Lbl.Name = "cat3Lbl"
        Me.cat3Lbl.Size = New System.Drawing.Size(205, 78)
        Me.cat3Lbl.TabIndex = 31
        Me.cat3Lbl.Text = "*Category 3*"
        Me.cat3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cat1Lbl
        '
        Me.cat1Lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cat1Lbl.AutoSize = True
        Me.cat1Lbl.BackColor = System.Drawing.Color.Transparent
        Me.cat1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat1Lbl.ForeColor = System.Drawing.Color.White
        Me.cat1Lbl.Location = New System.Drawing.Point(30, 156)
        Me.cat1Lbl.Name = "cat1Lbl"
        Me.cat1Lbl.Size = New System.Drawing.Size(205, 78)
        Me.cat1Lbl.TabIndex = 33
        Me.cat1Lbl.Text = "*Category 1*"
        Me.cat1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cat2Lbl
        '
        Me.cat2Lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cat2Lbl.AutoSize = True
        Me.cat2Lbl.BackColor = System.Drawing.Color.Transparent
        Me.cat2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat2Lbl.ForeColor = System.Drawing.Color.White
        Me.cat2Lbl.Location = New System.Drawing.Point(241, 156)
        Me.cat2Lbl.Name = "cat2Lbl"
        Me.cat2Lbl.Size = New System.Drawing.Size(205, 78)
        Me.cat2Lbl.TabIndex = 32
        Me.cat2Lbl.Text = "*Category 2*"
        Me.cat2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainPanel
        '
        Me.mainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainPanel.BackColor = System.Drawing.Color.Transparent
        Me.mainPanel.ColumnCount = 7
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5!))
        Me.mainPanel.Controls.Add(Me.penaltyBtn, 1, 8)
        Me.mainPanel.Controls.Add(Me.cat1Lbl, 1, 1)
        Me.mainPanel.Controls.Add(Me.cat2Lbl, 2, 1)
        Me.mainPanel.Controls.Add(Me.cat3Lbl, 3, 1)
        Me.mainPanel.Controls.Add(Me.resetBtn, 5, 8)
        Me.mainPanel.Controls.Add(Me.cat4Lbl, 4, 1)
        Me.mainPanel.Controls.Add(Me.C5Q5Btn, 5, 6)
        Me.mainPanel.Controls.Add(Me.C5Q4Btn, 5, 5)
        Me.mainPanel.Controls.Add(Me.exitBtn, 4, 8)
        Me.mainPanel.Controls.Add(Me.C4Q5Btn, 4, 6)
        Me.mainPanel.Controls.Add(Me.C4Q4Btn, 4, 5)
        Me.mainPanel.Controls.Add(Me.C4Q3Btn, 4, 4)
        Me.mainPanel.Controls.Add(Me.C3Q5Btn, 3, 6)
        Me.mainPanel.Controls.Add(Me.C3Q4Btn, 3, 5)
        Me.mainPanel.Controls.Add(Me.C5Q3Btn, 5, 4)
        Me.mainPanel.Controls.Add(Me.C1Q1Btn, 1, 2)
        Me.mainPanel.Controls.Add(Me.C5Q2Btn, 5, 3)
        Me.mainPanel.Controls.Add(Me.C1Q2Btn, 1, 3)
        Me.mainPanel.Controls.Add(Me.C4Q2Btn, 4, 3)
        Me.mainPanel.Controls.Add(Me.C1Q3Btn, 1, 4)
        Me.mainPanel.Controls.Add(Me.C1Q4Btn, 1, 5)
        Me.mainPanel.Controls.Add(Me.C4Q1Btn, 4, 2)
        Me.mainPanel.Controls.Add(Me.C5Q1Btn, 5, 2)
        Me.mainPanel.Controls.Add(Me.C1Q5Btn, 1, 6)
        Me.mainPanel.Controls.Add(Me.C2Q5Btn, 2, 6)
        Me.mainPanel.Controls.Add(Me.C2Q4Btn, 2, 5)
        Me.mainPanel.Controls.Add(Me.C3Q1Btn, 3, 2)
        Me.mainPanel.Controls.Add(Me.C3Q3Btn, 3, 4)
        Me.mainPanel.Controls.Add(Me.C2Q3Btn, 2, 4)
        Me.mainPanel.Controls.Add(Me.C2Q2Btn, 2, 3)
        Me.mainPanel.Controls.Add(Me.C3Q2Btn, 3, 3)
        Me.mainPanel.Controls.Add(Me.C2Q1Btn, 2, 2)
        Me.mainPanel.Controls.Add(Me.cat5Lbl, 5, 1)
        Me.mainPanel.Controls.Add(Me.scoreGroupBox, 0, 0)
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.RowCount = 9
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainPanel.Size = New System.Drawing.Size(1114, 780)
        Me.mainPanel.TabIndex = 48
        '
        'penaltyBtn
        '
        Me.penaltyBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.penaltyBtn.AutoSize = True
        Me.penaltyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.penaltyBtn.BackColor = System.Drawing.Color.White
        Me.penaltyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penaltyBtn.Location = New System.Drawing.Point(30, 705)
        Me.penaltyBtn.Name = "penaltyBtn"
        Me.penaltyBtn.Size = New System.Drawing.Size(205, 72)
        Me.penaltyBtn.TabIndex = 48
        Me.penaltyBtn.Text = "PENALTY"
        Me.penaltyBtn.UseVisualStyleBackColor = False
        '
        'Jeopardy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1114, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Jeopardy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeopardy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.scoreGroupBox.ResumeLayout(False)
        Me.scorePanel.ResumeLayout(False)
        Me.scorePanel.PerformLayout()
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scoreGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents team2Score As System.Windows.Forms.Label
    Friend WithEvents team1Score As System.Windows.Forms.Label
    Friend WithEvents team3Score As System.Windows.Forms.Label
    Friend WithEvents team1Name As System.Windows.Forms.Label
    Friend WithEvents team4Score As System.Windows.Forms.Label
    Friend WithEvents team4Name As System.Windows.Forms.Label
    Friend WithEvents Team2Name As System.Windows.Forms.Label
    Friend WithEvents team3Name As System.Windows.Forms.Label
    Friend WithEvents C3Q5Btn As System.Windows.Forms.Button
    Friend WithEvents C4Q1Btn As System.Windows.Forms.Button
    Friend WithEvents C3Q4Btn As System.Windows.Forms.Button
    Friend WithEvents C4Q2Btn As System.Windows.Forms.Button
    Friend WithEvents C3Q3Btn As System.Windows.Forms.Button
    Friend WithEvents C4Q3Btn As System.Windows.Forms.Button
    Friend WithEvents C1Q5Btn As System.Windows.Forms.Button
    Friend WithEvents C4Q4Btn As System.Windows.Forms.Button
    Friend WithEvents C3Q2Btn As System.Windows.Forms.Button
    Friend WithEvents C5Q1Btn As System.Windows.Forms.Button
    Friend WithEvents C3Q1Btn As System.Windows.Forms.Button
    Friend WithEvents C5Q2Btn As System.Windows.Forms.Button
    Friend WithEvents C2Q5Btn As System.Windows.Forms.Button
    Friend WithEvents C5Q3Btn As System.Windows.Forms.Button
    Friend WithEvents C2Q4Btn As System.Windows.Forms.Button
    Friend WithEvents C4Q5Btn As System.Windows.Forms.Button
    Friend WithEvents C2Q3Btn As System.Windows.Forms.Button
    Friend WithEvents C5Q4Btn As System.Windows.Forms.Button
    Friend WithEvents C2Q2Btn As System.Windows.Forms.Button
    Friend WithEvents C2Q1Btn As System.Windows.Forms.Button
    Friend WithEvents C1Q1Btn As System.Windows.Forms.Button
    Friend WithEvents C1Q4Btn As System.Windows.Forms.Button
    Friend WithEvents C1Q3Btn As System.Windows.Forms.Button
    Friend WithEvents C1Q2Btn As System.Windows.Forms.Button
    Friend WithEvents C5Q5Btn As System.Windows.Forms.Button
    Friend WithEvents cat5Lbl As System.Windows.Forms.Label
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents cat4Lbl As System.Windows.Forms.Label
    Friend WithEvents resetBtn As System.Windows.Forms.Button
    Friend WithEvents cat3Lbl As System.Windows.Forms.Label
    Friend WithEvents cat1Lbl As System.Windows.Forms.Label
    Friend WithEvents cat2Lbl As System.Windows.Forms.Label
    Friend WithEvents fourthTeam As System.Windows.Forms.Label
    Friend WithEvents thirdTeam As System.Windows.Forms.Label
    Friend WithEvents secondTeam As System.Windows.Forms.Label
    Friend WithEvents firstTeam As System.Windows.Forms.Label
    Friend WithEvents team3Place As System.Windows.Forms.Label
    Friend WithEvents team4Place As System.Windows.Forms.Label
    Friend WithEvents team2Place As System.Windows.Forms.Label
    Friend WithEvents team1Place As System.Windows.Forms.Label
    Friend WithEvents mainPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scorePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents fifthTeam As System.Windows.Forms.Label
    Friend WithEvents team5Score As System.Windows.Forms.Label
    Friend WithEvents team5Place As System.Windows.Forms.Label
    Friend WithEvents team5Name As System.Windows.Forms.Label
    Friend WithEvents penaltyBtn As System.Windows.Forms.Button

End Class

