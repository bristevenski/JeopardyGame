Imports Microsoft.Win32

Public Class Jeopardy
    Private _frmQuestion As QuestionForm
    Protected Friend con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Friend Shared _command As New OleDb.OleDbCommand
    Friend Shared _builder As OleDb.OleDbCommandBuilder
    Friend Shared _adapter As New OleDb.OleDbDataAdapter
    Friend Shared _table As New DataTable("Jeopardy")
    Friend Shared _dataSet As New DataSet
    Dim sql As String
    Private _team1 As Integer = 0
    Private _team2 As Integer = 0
    Private _team3 As Integer = 0
    Private _team4 As Integer = 0
    Private _team5 As Integer = 0
    Private _1Wgr As Integer = 0
    Private _2Wgr As Integer = 0
    Private _3Wgr As Integer = 0
    Private _4Wgr As Integer = 0
    Private _5Wgr As Integer = 0
    Private _1Pen As Integer = 0
    Private _2Pen As Integer = 0
    Private _3Pen As Integer = 0
    Private _4Pen As Integer = 0
    Private _5Pen As Integer = 0
    Private _numDisabled As Integer = 0
    Private _final As Boolean = False
    Private _end As Boolean = False

    Public ReadOnly Property Final As Boolean
        Get
            If _numDisabled = 23 Then
                _final = True
            End If
            Return _final
        End Get
    End Property

    Public ReadOnly Property EndGame As Boolean
        Get
            If _numDisabled = 24 Then
                _end = True
            End If
            Return _end
        End Get

    End Property
    Public Property Team1 As Integer
        Set(value As Integer)
            _team1 += value
            team1Score.Text = _team1
        End Set
        Get
            Return _team1
        End Get
    End Property

    Public Property Team2 As Integer
        Set(value As Integer)
            _team2 += value
            team2Score.Text = _team2
        End Set
        Get
            Return _team2
        End Get
    End Property

    Public Property Team3 As Integer
        Set(value As Integer)
            _team3 += value
            team3Score.Text = _team3
        End Set
        Get
            Return _team3
        End Get
    End Property

    Public Property Team4 As Integer
        Set(value As Integer)
            _team4 += value
            team4Score.Text = _team4
        End Set
        Get
            Return _team4
        End Get
    End Property

    Public Property Team5 As Integer
        Set(value As Integer)
            _team5 += value
            team5Score.Text = _team5
        End Set
        Get
            Return _team5
        End Get
    End Property

    Public WriteOnly Property Team1Wager As Integer
        Set(value As Integer)
            _1Wgr = value
        End Set
    End Property

    Public WriteOnly Property Team2Wager As Integer
        Set(value As Integer)
            _2Wgr = value
        End Set
    End Property

    Public WriteOnly Property Team3Wager As Integer
        Set(value As Integer)
            _3Wgr = value
        End Set
    End Property

    Public WriteOnly Property Team4Wager As Integer
        Set(value As Integer)
            _4Wgr = value
        End Set
    End Property

    Public WriteOnly Property Team5Wager As Integer
        Set(value As Integer)
            _5Wgr = value
        End Set
    End Property

    Public WriteOnly Property Team1Penalty As Integer
        Set(value As Integer)
            _1Pen = value
        End Set
    End Property

    Public WriteOnly Property Team2Penalty As Integer
        Set(value As Integer)
            _2Pen = value
        End Set
    End Property

    Public WriteOnly Property Team3Penalty As Integer
        Set(value As Integer)
            _3Pen = value
        End Set
    End Property

    Public WriteOnly Property Team4Penalty As Integer
        Set(value As Integer)
            _4Pen = value
        End Set
    End Property

    Public WriteOnly Property Team5Penalty As Integer
        Set(value As Integer)
            _5Pen = value
        End Set
    End Property

    Private Sub Jeopardy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font

        mainPanel.Top = (ClientSize.Height - mainPanel.Height) / 2
        mainPanel.Left = (ClientSize.Width - mainPanel.Width) / 2

        scorePanel.Top = (scoreGroupBox.Height - scorePanel.Height) / 2
        scorePanel.Left = (scoreGroupBox.Width - scorePanel.Width) / 2

        _frmQuestion = New QuestionForm
        _frmQuestion.MainForm = Me

        Dim connected As Boolean = False
        Dim dbLoc As String = ""

        While Not connected
            Try
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbLoc

                _command.CommandType = CommandType.Text
                _command.CommandText = "Select * from Jeopardy"
                _command.Connection = con
                _adapter.SelectCommand = _command
                _builder = New OleDb.OleDbCommandBuilder(_adapter)
                _adapter.Fill(_table)
                _dataSet.Tables.Add(_table)

                connected = True
            Catch ex As Exception
                Dim openDB As New OpenFileDialog
                If openDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dbLoc = openDB.FileName
                Else
                    Exit While
                End If
            End Try
        End While
        
        If Not connected Then
            MsgBox("No database selected!")
            Application.Exit()
        End If

        ResetTeamInfo()

        setUpFormText()

    End Sub

    Private Sub ResetTeamInfo()
        team1Score.Text = _team1
        team2Score.Text = _team2
        team3Score.Text = _team3
        team4Score.Text = _team4
        team5Score.Text = _team5

        firstTeam.Visible = False
        secondTeam.Visible = False
        thirdTeam.Visible = False
        fourthTeam.Visible = False
        fifthTeam.Visible = False

        team1Place.Visible = False
        team2Place.Visible = False
        team3Place.Visible = False
        team4Place.Visible = False
        team5Place.Visible = False
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Dim result As Microsoft.VisualBasic.MsgBoxResult
        result = MsgBox("Are you sure you want to reset?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            _team1 = 0
            _team2 = 0
            _team3 = 0
            _team4 = 0
            _team5 = 0

            DisableEnableButton(11, True)
            DisableEnableButton(12, True)
            DisableEnableButton(13, True)
            DisableEnableButton(14, True)
            DisableEnableButton(15, True)

            DisableEnableButton(21, True)
            DisableEnableButton(22, True)
            DisableEnableButton(23, True)
            DisableEnableButton(24, True)
            DisableEnableButton(25, True)

            DisableEnableButton(31, True)
            DisableEnableButton(32, True)
            DisableEnableButton(33, True)
            DisableEnableButton(34, True)
            DisableEnableButton(35, True)

            DisableEnableButton(41, True)
            DisableEnableButton(42, True)
            DisableEnableButton(43, True)
            DisableEnableButton(44, True)
            DisableEnableButton(45, True)

            DisableEnableButton(51, True)
            DisableEnableButton(52, True)
            DisableEnableButton(53, True)
            DisableEnableButton(54, True)
            DisableEnableButton(55, True)

            ResetTeamInfo()

            _final = False
            _end = False
            _1Wgr = 0
            _2Wgr = 0
            _3Wgr = 0
            _4Wgr = 0
            _numDisabled = 0

            Me.Update()
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim result As Microsoft.VisualBasic.MsgBoxResult
        result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
            Return
        End If
    End Sub

    Private Sub setUpFormText()
        C1Q1Btn.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(1)
        C1Q2Btn.Text = _dataSet.Tables("Jeopardy").Rows(1).Item(1)
        C1Q3Btn.Text = _dataSet.Tables("Jeopardy").Rows(2).Item(1)
        C1Q4Btn.Text = _dataSet.Tables("Jeopardy").Rows(3).Item(1)
        C1Q5Btn.Text = _dataSet.Tables("Jeopardy").Rows(4).Item(1)

        C2Q1Btn.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(1)
        C2Q2Btn.Text = _dataSet.Tables("Jeopardy").Rows(6).Item(1)
        C2Q3Btn.Text = _dataSet.Tables("Jeopardy").Rows(7).Item(1)
        C2Q4Btn.Text = _dataSet.Tables("Jeopardy").Rows(8).Item(1)
        C2Q5Btn.Text = _dataSet.Tables("Jeopardy").Rows(9).Item(1)

        C3Q1Btn.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(1)
        C3Q2Btn.Text = _dataSet.Tables("Jeopardy").Rows(11).Item(1)
        C3Q3Btn.Text = _dataSet.Tables("Jeopardy").Rows(12).Item(1)
        C3Q4Btn.Text = _dataSet.Tables("Jeopardy").Rows(13).Item(1)
        C3Q5Btn.Text = _dataSet.Tables("Jeopardy").Rows(14).Item(1)

        C4Q1Btn.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(1)
        C4Q2Btn.Text = _dataSet.Tables("Jeopardy").Rows(16).Item(1)
        C4Q3Btn.Text = _dataSet.Tables("Jeopardy").Rows(17).Item(1)
        C4Q4Btn.Text = _dataSet.Tables("Jeopardy").Rows(18).Item(1)
        C4Q5Btn.Text = _dataSet.Tables("Jeopardy").Rows(19).Item(1)

        C5Q1Btn.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(1)
        C5Q2Btn.Text = _dataSet.Tables("Jeopardy").Rows(21).Item(1)
        C5Q3Btn.Text = _dataSet.Tables("Jeopardy").Rows(22).Item(1)
        C5Q4Btn.Text = _dataSet.Tables("Jeopardy").Rows(23).Item(1)
        C5Q5Btn.Text = _dataSet.Tables("Jeopardy").Rows(24).Item(1)

        cat1Lbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4)
        cat2Lbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4)
        cat3Lbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4)
        cat4Lbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4)
        cat5Lbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4)
    End Sub

    Public Sub DisableEnableButton(ByVal _button As Integer, ByVal _enable As Boolean)
        Dim _b As New Button

        Select Case _button
            Case 11
                _b = C1Q1Btn
            Case 12
                _b = C1Q2Btn
            Case 13
                _b = C1Q3Btn
            Case 14
                _b = C1Q4Btn
            Case 15
                _b = C1Q5Btn
            Case 21
                _b = C2Q1Btn
            Case 22
                _b = C2Q2Btn
            Case 23
                _b = C2Q3Btn
            Case 24
                _b = C2Q4Btn
            Case 25
                _b = C2Q5Btn
            Case 31
                _b = C3Q1Btn
            Case 32
                _b = C3Q2Btn
            Case 33
                _b = C3Q3Btn
            Case 34
                _b = C3Q4Btn
            Case 35
                _b = C3Q5Btn
            Case 41
                _b = C4Q1Btn
            Case 42
                _b = C4Q2Btn
            Case 43
                _b = C4Q3Btn
            Case 44
                _b = C4Q4Btn
            Case 45
                _b = C4Q5Btn
            Case 51
                _b = C5Q1Btn
            Case 52
                _b = C5Q2Btn
            Case 53
                _b = C5Q3Btn
            Case 54
                _b = C5Q4Btn
            Case 55
                _b = C5Q5Btn
        End Select

        _b.Enabled = _enable
        If _enable Then
            _b.BackColor = Color.White
        Else
            _b.BackColor = Color.Red
            _numDisabled += 1
        End If

    End Sub

    Private Sub C1Q1Btn_Click(sender As Object, e As EventArgs) Handles C1Q1Btn.Click
        _frmQuestion.Question = 11
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C1Q2Btn_Click(sender As Object, e As EventArgs) Handles C1Q2Btn.Click
        _frmQuestion.Question = 12
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C1Q3Btn_Click(sender As Object, e As EventArgs) Handles C1Q3Btn.Click
        _frmQuestion.Question = 13
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C1Q4Btn_Click(sender As Object, e As EventArgs) Handles C1Q4Btn.Click
        _frmQuestion.Question = 14
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C1Q5Btn_Click(sender As Object, e As EventArgs) Handles C1Q5Btn.Click
        _frmQuestion.Question = 15
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C2Q1Btn_Click(sender As Object, e As EventArgs) Handles C2Q1Btn.Click
        _frmQuestion.Question = 21
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C2Q2Btn_Click(sender As Object, e As EventArgs) Handles C2Q2Btn.Click
        _frmQuestion.Question = 22
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C2Q3Btn_Click(sender As Object, e As EventArgs) Handles C2Q3Btn.Click
        _frmQuestion.Question = 23
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C2Q4Btn_Click(sender As Object, e As EventArgs) Handles C2Q4Btn.Click
        _frmQuestion.Question = 24
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C2Q5Btn_Click(sender As Object, e As EventArgs) Handles C2Q5Btn.Click
        _frmQuestion.Question = 25
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C3Q1Btn_Click(sender As Object, e As EventArgs) Handles C3Q1Btn.Click
        _frmQuestion.Question = 31
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C3Q2Btn_Click(sender As Object, e As EventArgs) Handles C3Q2Btn.Click
        _frmQuestion.Question = 32
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C3Q3Btn_Click(sender As Object, e As EventArgs) Handles C3Q3Btn.Click
        _frmQuestion.Question = 33
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C3Q4Btn_Click(sender As Object, e As EventArgs) Handles C3Q4Btn.Click
        _frmQuestion.Question = 34
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C3Q5Btn_Click(sender As Object, e As EventArgs) Handles C3Q5Btn.Click
        _frmQuestion.Question = 35
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C4Q1Btn_Click(sender As Object, e As EventArgs) Handles C4Q1Btn.Click
        _frmQuestion.Question = 41
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C4Q2Btn_Click(sender As Object, e As EventArgs) Handles C4Q2Btn.Click
        _frmQuestion.Question = 42
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C4Q3Btn_Click(sender As Object, e As EventArgs) Handles C4Q3Btn.Click
        _frmQuestion.Question = 43
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C4Q4Btn_Click(sender As Object, e As EventArgs) Handles C4Q4Btn.Click
        _frmQuestion.Question = 44
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C4Q5Btn_Click(sender As Object, e As EventArgs) Handles C4Q5Btn.Click
        _frmQuestion.Question = 45
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C5Q1Btn_Click(sender As Object, e As EventArgs) Handles C5Q1Btn.Click
        _frmQuestion.Question = 51
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C5Q2Btn_Click(sender As Object, e As EventArgs) Handles C5Q2Btn.Click
        _frmQuestion.Question = 52
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C5Q3Btn_Click(sender As Object, e As EventArgs) Handles C5Q3Btn.Click
        _frmQuestion.Question = 53
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C5Q4Btn_Click(sender As Object, e As EventArgs) Handles C5Q4Btn.Click
        _frmQuestion.Question = 54
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Private Sub C5Q5Btn_Click(sender As Object, e As EventArgs) Handles C5Q5Btn.Click
        _frmQuestion.Question = 55
        Me.Hide()
        _frmQuestion.Show()
        _frmQuestion.BringToFront()
        _frmQuestion.StartQuestion()
    End Sub

    Sub FinalQuestion(_1Right As Boolean, _2Right As Boolean, _3Right As Boolean, _4Right As Boolean, _5Right As Boolean)
        If _1Right Then
            _team1 += _1Wgr
        Else
            _team1 -= _1Wgr
        End If
        If _2Right Then
            _team2 += _2Wgr
        Else
            _team2 -= _2Wgr
        End If
        If _3Right Then
            _team3 += _3Wgr
        Else
            _team3 -= _3Wgr
        End If
        If _4Right Then
            _team4 += _4Wgr
        Else
            _team4 -= _4Wgr
        End If

        If _5Right Then
            _team5 += _5Wgr
        Else
            _team5 -= _5Wgr
        End If

        Dim _max As Integer = -1
        Dim _first As Integer = 0
        Dim _second As Integer = 0
        Dim _third As Integer = 0
        Dim _fourth As Integer = 0
        Dim _fifth As Integer = 0

        ' Determine first place
        If _team1 > _max Then
            _max = _team1
            _first = 1
        End If
        If _team2 > _max Then
            _max = _team2
            _first = 2
        End If
        If _team3 > _max Then
            _max = _team3
            _first = 3
        End If
        If _team4 > _max Then
            _max = _team4
            _first = 4
        End If
        If _team5 > _max Then
            _max = _team5
            _first = 5
        End If

        ' Determine second place
        _max = -1
        If _team1 > _max And _first <> 1 Then
            _max = _team1
            _second = 1
        End If
        If _team2 > _max And _first <> 2 Then
            _max = _team2
            _second = 2
        End If
        If _team3 > _max And _first <> 3 Then
            _max = _team3
            _second = 3
        End If
        If _team4 > _max And _first <> 4 Then
            _max = _team4
            _second = 4
        End If
        If _team5 > _max And _first <> 5 Then
            _max = _team5
            _second = 5
        End If

        ' Determine third place
        _max = -1
        If _team1 > _max And _first <> 1 And _second <> 1 Then
            _max = _team1
            _third = 1
        End If
        If _team2 > _max And _first <> 2 And _second <> 2 Then
            _max = _team2
            _third = 2
        End If
        If _team3 > _max And _first <> 3 And _second <> 3 Then
            _max = _team3
            _third = 3
        End If
        If _team4 > _max And _first <> 4 And _second <> 4 Then
            _max = _team4
            _third = 4
        End If
        If _team5 > _max And _first <> 5 And _second <> 5 Then
            _max = _team5
            _third = 5
        End If

        ' Determine fourth place
        _max = -1
        If _team1 > _max And _first <> 1 And _second <> 1 And _third <> 1 Then
            _max = _team1
            _fourth = 1
        End If
        If _team2 > _max And _first <> 2 And _second <> 2 And _third <> 2 Then
            _max = _team2
            _fourth = 2
        End If
        If _team3 > _max And _first <> 3 And _second <> 3 And _third <> 3 Then
            _max = _team3
            _fourth = 3
        End If
        If _team4 > _max And _first <> 4 And _second <> 4 And _third <> 4 Then
            _max = _team4
            _fourth = 4
        End If
        If _team5 > _max And _first <> 5 And _second <> 5 And _third <> 5 Then
            _max = _team5
            _fourth = 5
        End If

        ' Determine fifth place
        _max = -1
        If _team1 > _max And _first <> 1 And _second <> 1 And _third <> 1 And _fourth <> 1 Then
            _max = _team1
            _fifth = 1
        End If
        If _team2 > _max And _first <> 2 And _second <> 2 And _third <> 2 And _fourth <> 2 Then
            _max = _team2
            _fifth = 2
        End If
        If _team3 > _max And _first <> 3 And _second <> 3 And _third <> 3 And _fourth <> 3 Then
            _max = _team3
            _fifth = 3
        End If
        If _team4 > _max And _first <> 4 And _second <> 4 And _third <> 4 And _fourth <> 4 Then
            _max = _team4
            _fifth = 4
        End If
        If _team5 > _max And _first <> 5 And _second <> 5 And _third <> 5 And _fourth <> 5 Then
            _max = _team5
            _fifth = 5
        End If

        If _first = 1 Then
            firstTeam.Text = "First"
        ElseIf _first = 2 Then
            secondTeam.Text = "First"
        ElseIf _first = 3 Then
            thirdTeam.Text = "First"
        ElseIf _first = 4 Then
            fourthTeam.Text = "First"
        ElseIf _first = 5 Then
            fifthTeam.Text = "First"
        End If

        If _second = 1 Then
            firstTeam.Text = "Second"
        ElseIf _second = 2 Then
            secondTeam.Text = "Second"
        ElseIf _second = 3 Then
            thirdTeam.Text = "Second"
        ElseIf _second = 4 Then
            fourthTeam.Text = "Second"
        ElseIf _second = 5 Then
            fifthTeam.Text = "Second"
        End If

        If _third = 1 Then
            firstTeam.Text = "Third"
        ElseIf _third = 2 Then
            secondTeam.Text = "Third"
        ElseIf _third = 3 Then
            thirdTeam.Text = "Third"
        ElseIf _third = 4 Then
            fourthTeam.Text = "Third"
        ElseIf _third = 5 Then
            fifthTeam.Text = "Third"
        End If

        If _fourth = 1 Then
            firstTeam.Text = "Fourth"
        ElseIf _fourth = 2 Then
            secondTeam.Text = "Fourth"
        ElseIf _fourth = 3 Then
            thirdTeam.Text = "Fourth"
        ElseIf _fourth = 4 Then
            fourthTeam.Text = "Fourth"
        ElseIf _fourth = 5 Then
            fifthTeam.Text = "Fourth"
        End If

        If _fifth = 1 Then
            firstTeam.Text = "Fifth"
        ElseIf _fifth = 2 Then
            secondTeam.Text = "Fifth"
        ElseIf _fifth = 3 Then
            thirdTeam.Text = "Fifth"
        ElseIf _fifth = 4 Then
            fourthTeam.Text = "Fifth"
        ElseIf _fifth = 5 Then
            fifthTeam.Text = "Fifth"
        End If

        firstTeam.Visible = True
        secondTeam.Visible = True
        thirdTeam.Visible = True
        fourthTeam.Visible = True
        fifthTeam.Visible = True

        team1Place.Visible = True
        team2Place.Visible = True
        team3Place.Visible = True
        team4Place.Visible = True
        team5Place.Visible = True

        team1Score.Text = _team1
        team2Score.Text = _team2
        team3Score.Text = _team3
        team4Score.Text = _team4
        team5Score.Text = _team5
    End Sub

    Private Sub penaltyBtn_Click(sender As Object, e As EventArgs) Handles penaltyBtn.Click
        Dim _pen As Penalty = New Penalty
        _pen.MainForm = Me
        Me.Hide()
        _pen.Show()
        _pen.BringToFront()
    End Sub

    Protected Friend Sub SetPenalty()
        _team1 -= _1Pen
        _team2 -= _2Pen
        _team3 -= _3Pen
        _team4 -= _4Pen
        _team5 -= _5Pen

        _1Pen = 0
        _2Pen = 0
        _3Pen = 0
        _4Pen = 0
        _5Pen = 0

        ResetTeamInfo()
    End Sub
End Class