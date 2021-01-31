Imports Microsoft.Win32

Public Class QuestionForm
    Protected Friend _mainForm As Jeopardy
    Private _question As Integer
    Private _points As Integer
    Private _dataSet As New DataSet
    Private _adapter As New OleDb.OleDbDataAdapter
    Private _connection As New OleDb.OleDbConnection
    Private sql As String
    Private _time As Integer = INIT_TIME
    Private _answer As Boolean = False
    Private _muted As Boolean = False
    Private _isDouble As Boolean = False
    Private _muteTime As Integer = INIT_TIME
    Private _double(5) As Integer
    Private _rand As New Random
    Private _doubleFrm As DailyDouble
    Private _finalFrm As Final
    Protected Friend _notDone As Boolean = True
    Private _last As Boolean = False

    Private Const DOUBLE_AMT As Integer = 5         'number of daily doubles to occur
    Private Const INIT_TIME As Integer = 120000
    Private Const DOUBLE_TIME As Integer = 2000
    Private Const TOTAL_QUESTIONS As Integer = 25
    Private Const DAILY_DBL As Integer = 2


    Public WriteOnly Property MainForm As Jeopardy
        Set(value As Jeopardy)
            _mainForm = value
        End Set
    End Property

    Public WriteOnly Property Question As Integer
        Set(value As Integer)
            _question = value
        End Set
    End Property

    Private Sub QuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font

        answerPanel.Top = (teamGroupBox.Height - answerPanel.Height) / 2
        answerPanel.Left = (teamGroupBox.Width - answerPanel.Width) / 2

        For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
            _double(i) = _rand.Next(1, TOTAL_QUESTIONS)
        Next
        _connection = _mainForm.con
        sql = "select * from Jeopardy"
        _adapter = New OleDb.OleDbDataAdapter(sql, _connection)
        _adapter.Fill(_dataSet, "Jeopardy")


        timerTxt.Text = 120
        StartQuestion()

        doneBtn.Enabled = False
        team1ChckBox.Enabled = False
        team2ChckBox.Enabled = False
        team3ChckBox.Enabled = False
        team4ChckBox.Enabled = False
        team5ChckBox.Enabled = False

        If Not _muted Then
            Try
                My.Computer.Audio.Play(My.Resources.Jeopardy_theme_song, AudioPlayMode.BackgroundLoop)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub SetUpDoubleForm()
        _doubleFrm = New DailyDouble
        _doubleFrm.Show()
        _doubleFrm.BringToFront()
        _isDouble = True
    End Sub

    Private Sub SetQuestion()
        Select Case _question
            Case 11
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(0).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(0).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 1 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(0).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 12
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(1).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(1).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(1).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 2 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(1).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 13
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(2).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(2).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(2).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 3 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(2).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 14
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(3).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(3).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(3).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 4 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(3).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 15
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(4).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(4).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(4).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 5 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(4).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(0).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 21
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(5).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(5).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 6 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(5).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 22
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(6).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(6).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(6).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 7 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(6).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 23
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(7).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(7).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(7).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 8 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(7).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 24
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(8).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(8).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(8).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 9 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(8).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 25
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(9).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(9).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(9).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 10 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(9).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(5).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 31
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(10).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(10).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 11 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(10).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 32
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(11).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(11).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(11).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 12 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(11).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 33
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(12).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(12).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(12).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 13 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(12).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 34
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(13).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(13).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(13).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 14 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(13).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 35
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(14).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(14).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(14).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 15 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(14).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(10).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 41
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(15).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(15).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 16 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(15).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 42
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(16).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(16).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(16).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 17 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(16).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 43
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(17).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(17).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(17).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 18 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(17).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 44
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(18).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(18).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(18).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 19 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(18).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 45
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(19).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(19).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(19).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 20 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(19).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(15).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 51
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(20).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(20).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 21 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(20).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 52
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(21).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(21).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(21).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 22 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(21).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 53
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(22).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(22).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(22).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 23 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(22).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 54
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(23).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(23).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(23).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 24 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(23).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _points & " Points"
                    End If
                Next
            Case 55
                questionTxt.Text = _dataSet.Tables("Jeopardy").Rows(24).Item(2)
                questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _dataSet.Tables("Jeopardy").Rows(24).Item(1) & " Points"
                _points = _dataSet.Tables("Jeopardy").Rows(24).Item(1)
                For i As Integer = 0 To DOUBLE_AMT - 1 Step 1
                    If _double(i) = 25 Then
                        SetUpDoubleForm()
                        _points = _dataSet.Tables("Jeopardy").Rows(24).Item(1) * DAILY_DBL
                        questionLbl.Text = _dataSet.Tables("Jeopardy").Rows(20).Item(4) & " " & _points & " Points"
                    End If
                Next
        End Select
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        My.Computer.Audio.Stop()
        Timer1.Stop()
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
        team1ChckBox.Checked = False
        team2ChckBox.Checked = False
        team3ChckBox.Checked = False
        team4ChckBox.Checked = False
        team5ChckBox.Checked = False
    End Sub

    Private Sub doneBtn_Click(sender As Object, e As EventArgs) Handles doneBtn.Click
        My.Computer.Audio.Stop()
        doneBtn.Enabled = False
        backBtn.Enabled = False
        If Not team1ChckBox.Checked And Not team2ChckBox.Checked And Not team3ChckBox.Checked And Not team4ChckBox.Checked And Not team5ChckBox.Checked Then
            Dim result As Microsoft.VisualBasic.MsgBoxResult
            result = MsgBox("No points given. Do you want to continue?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                EndQuestion()
            Else
                doneBtn.Enabled = True
                backBtn.Enabled = True
            End If
        Else
            EndQuestion()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _time -= 1000
        Dim _timeTxt As Integer = _time / 1000
        timerTxt.Text = _timeTxt
        If _time = 0 Then
            My.Computer.Audio.Stop()
            Timer1.Stop()
        End If
    End Sub

    Public Sub StartQuestion()
        questionLbl.Left = (Me.ClientSize.Width - questionLbl.Width) / 2
        doneBtn.Focus()
        _isDouble = False
        SetQuestion()
        If _isDouble Then
            _time = INIT_TIME + DOUBLE_TIME
            _muteTime = INIT_TIME + DOUBLE_TIME
            timerTxt.Text = (INIT_TIME + DOUBLE_TIME) / 1000
        Else
            _time = INIT_TIME
            _muteTime = INIT_TIME
            timerTxt.Text = INIT_TIME / 1000
        End If

        answerBtn.Enabled = True
        doneBtn.Enabled = False
        team1ChckBox.Enabled = False
        team2ChckBox.Enabled = False
        team3ChckBox.Enabled = False
        team4ChckBox.Enabled = False
        team5ChckBox.Enabled = False

        Timer1.Interval = 1000
        Timer1.Start()
        If Not _muted Then
            Try
                My.Computer.Audio.Play(My.Resources.Jeopardy_theme_song, AudioPlayMode.BackgroundLoop)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ShowAnswer()
        Select Case _question
            Case 11
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(0).Item(3)
            Case 12
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(1).Item(3)
            Case 13
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(2).Item(3)
            Case 14
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(3).Item(3)
            Case 15
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(4).Item(3)
            Case 21
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(5).Item(3)
            Case 22
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(6).Item(3)
            Case 23
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(7).Item(3)
            Case 24
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(8).Item(3)
            Case 25
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(9).Item(3)
            Case 31
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(10).Item(3)
            Case 32
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(11).Item(3)
            Case 33
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(12).Item(3)
            Case 34
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(13).Item(3)
            Case 35
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(14).Item(3)
            Case 41
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(15).Item(3)
            Case 42
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(16).Item(3)
            Case 43
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(17).Item(3)
            Case 44
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(18).Item(3)
            Case 45
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(19).Item(3)
            Case 51
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(20).Item(3)
            Case 52
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(21).Item(3)
            Case 53
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(22).Item(3)
            Case 54
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(23).Item(3)
            Case 55
                questionTxt.Text &= vbNewLine & vbNewLine & _dataSet.Tables("Jeopardy").Rows(24).Item(3)
        End Select

        team1ChckBox.Enabled = True
        team2ChckBox.Enabled = True
        team3ChckBox.Enabled = True
        team4ChckBox.Enabled = True
        team5ChckBox.Enabled = True
    End Sub

    Private Sub answerBtn_Click(sender As Object, e As EventArgs) Handles answerBtn.Click
        If Not _answer Then
            doneBtn.Enabled = True
            My.Computer.Audio.Stop()
            Timer1.Stop()
            ShowAnswer()
            timerTxt.Clear()
            answerBtn.Enabled = False
            doneBtn.Focus()
            Me.Update()
        End If
    End Sub

    Private Sub muteBtn_Click(sender As Object, e As EventArgs) Handles muteBtn.Click
        If Not _muted Then
            My.Computer.Audio.Stop()
            Try
                muteBtn.Image = My.Resources.unmute
                muteBtn.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                muteBtn.Image = My.Resources.mute
                My.Computer.Audio.Play(My.Resources.Jeopardy_theme_song, AudioPlayMode.BackgroundLoop)
                muteBtn.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            _muteTime = _time
        End If
        _muted = Not _muted
    End Sub

    Private Sub EndQuestion()
        doneBtn.Enabled = True
        backBtn.Enabled = True
        Dim _final As Boolean = _mainForm.Final
        Dim _end As Boolean = _mainForm.EndGame
        _mainForm.DisableEnableButton(_question, False)
        If _end Then
            _mainForm.FinalQuestion(team1ChckBox.Checked, team2ChckBox.Checked, team3ChckBox.Checked, team4ChckBox.Checked, team5ChckBox.Checked)
            Me.Hide()
            _mainForm.Show()
            _mainForm.BringToFront()
            team1ChckBox.Checked = False
            team2ChckBox.Checked = False
            team3ChckBox.Checked = False
            team4ChckBox.Checked = False
            team5ChckBox.Checked = False
            Return
        Else
            If team1ChckBox.Checked Then
                _mainForm.Team1 = _points
            End If
            If team2ChckBox.Checked Then
                _mainForm.Team2 = _points
            End If
            If team3ChckBox.Checked Then
                _mainForm.Team3 = _points
            End If
            If team4ChckBox.Checked Then
                _mainForm.Team4 = _points
            End If
            If team5ChckBox.Checked Then
                _mainForm.Team5 = _points
            End If
        End If

        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()

        If _final Then
            _finalFrm = New Final
            _finalFrm.MainForm = _mainForm
            _finalFrm.Show()
            _finalFrm.BringToFront()
            _last = True
        End If

        team1ChckBox.Checked = False
        team2ChckBox.Checked = False
        team3ChckBox.Checked = False
        team4ChckBox.Checked = False
        team5ChckBox.Checked = False
    End Sub
End Class