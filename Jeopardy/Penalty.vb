Public Class Penalty
    Private _mainForm As Jeopardy
    Private _error As Boolean

    Public WriteOnly Property MainForm As Jeopardy
        Set(value As Jeopardy)
            _mainForm = value
        End Set
    End Property

    Private Sub team1Txt_MouseClick(sender As Object, e As MouseEventArgs) Handles team1Txt.MouseClick
        team1Txt.Clear()
        team1Err.Clear()
        _error = False
    End Sub

    Private Sub team2Txt_MouseClick(sender As Object, e As MouseEventArgs) Handles team2Txt.MouseClick
        team2Txt.Clear()
        team2Err.Clear()
        _error = False
    End Sub

    Private Sub team3Txt_MouseClick(sender As Object, e As MouseEventArgs) Handles team3Txt.MouseClick
        team3Txt.Clear()
        team3Err.Clear()
        _error = False
    End Sub

    Private Sub team4Txt_MouseClick(sender As Object, e As MouseEventArgs) Handles team4Txt.MouseClick
        team4Txt.Clear()
        team4Err.Clear()
        _error = False
    End Sub

    Private Sub team5Txt_MouseClick(sender As Object, e As MouseEventArgs) Handles team5Txt.MouseClick
        team5Txt.Clear()
        team5Err.Clear()
        _error = False
    End Sub

    Private Sub HandleInvalidInput(e As KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Back) Then
            e.Handled = False
        ElseIf e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
            Beep()
            MessageBox.Show("Penalty must be a positive integer.")
        End If
    End Sub

    Private Sub team1Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles team1Txt.KeyPress
        HandleInvalidInput(e)
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        If _mainForm.Team1 < team1Txt.Text Then
            team1Err.SetError(team1Txt, "Penalty cannot be larger than the current score!")
            _error = True
        End If

        If _mainForm.Team2 < team2Txt.Text Then
            team2Err.SetError(team2Txt, "Penalty cannot be larger than the current score!")
            _error = True
        End If

        If _mainForm.Team3 < team3Txt.Text Then
            team3Err.SetError(team3Txt, "Penalty cannot be larger than the current score!")
            _error = True
        End If

        If _mainForm.Team4 < team4Txt.Text Then
            team4Err.SetError(team4Txt, "Penalty cannot be larger than the current score!")
            _error = True
        End If

        If _mainForm.Team5 < team5Txt.Text Then
            team5Err.SetError(team5Txt, "Penalty cannot be larger than the current score!")
            _error = True
        End If

        If Not _error Then
            _mainForm.Team1Penalty = team1Txt.Text
            _mainForm.Team2Penalty = team2Txt.Text
            _mainForm.Team3Penalty = team3Txt.Text
            _mainForm.Team4Penalty = team4Txt.Text
            _mainForm.Team5Penalty = team5Txt.Text
            _mainForm.SetPenalty()
            Me.Close()
            _mainForm.Show()
            _mainForm.BringToFront()
        End If
    End Sub

    Private Sub Penalty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        team1Score.Text = "Current Score: " & _mainForm.Team1
        team2Score.Text = "Current Score: " & _mainForm.Team2
        team3Score.Text = "Current Score: " & _mainForm.Team3
        team4Score.Text = "Current Score: " & _mainForm.Team4
        team5Score.Text = "Current Score: " & _mainForm.Team5
    End Sub

    Private Sub team1Txt_Leave(sender As Object, e As EventArgs) Handles team1Txt.Leave
        If team1Txt.TextLength = 0 Then
            team1Txt.Text = "0"
        End If
    End Sub

    Private Sub team2Txt_Leave(sender As Object, e As EventArgs) Handles team2Txt.Leave
        If team2Txt.TextLength = 0 Then
            team2Txt.Text = "0"
        End If
    End Sub

    Private Sub team3Txt_Leave(sender As Object, e As EventArgs) Handles team3Txt.Leave
        If team3Txt.TextLength = 0 Then
            team3Txt.Text = "0"
        End If
    End Sub

    Private Sub team4Txt_Leave(sender As Object, e As EventArgs) Handles team4Txt.Leave
        If team4Txt.TextLength = 0 Then
            team4Txt.Text = "0"
        End If
    End Sub

    Private Sub team5Txt_Leave(sender As Object, e As EventArgs) Handles team5Txt.Leave
        If team5Txt.TextLength = 0 Then
            team5Txt.Text = "0"
        End If
    End Sub
End Class