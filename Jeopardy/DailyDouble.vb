Public Class DailyDouble
    Dim t As Timer = New Timer()

    Private Sub DailyDouble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t.Interval = 2000
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
    End Sub

    Private Sub HandleTimerTick(sender As Object, e As EventArgs)
        t.Stop()
        Me.Close()
    End Sub
End Class