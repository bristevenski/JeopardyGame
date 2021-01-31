<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyDouble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyDouble))
        Me.frmTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dailyLbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'frmTimer
        '
        Me.frmTimer.Interval = 5000
        '
        'dailyLbl1
        '
        Me.dailyLbl1.AutoSize = True
        Me.dailyLbl1.BackColor = System.Drawing.Color.Transparent
        Me.dailyLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 63.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyLbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.dailyLbl1.Location = New System.Drawing.Point(105, 154)
        Me.dailyLbl1.Name = "dailyLbl1"
        Me.dailyLbl1.Size = New System.Drawing.Size(291, 96)
        Me.dailyLbl1.TabIndex = 0
        Me.dailyLbl1.Text = "DAILY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 63.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(40, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 96)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DOUBLE!"
        '
        'DailyDouble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Jeopardy.My.Resources.Resources.border
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dailyLbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DailyDouble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DailyDouble"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frmTimer As System.Windows.Forms.Timer
    Friend WithEvents dailyLbl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
