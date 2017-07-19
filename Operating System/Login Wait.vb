Public Class Login_Wait
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
            BTN.Show()
            Me.Close()
        Else
            Me.ProgressBar1.Increment(1)
            Dim x As Integer
            x = 100 * (Me.ProgressBar1.Value / Me.ProgressBar1.Maximum)
            Label3.Text = x & "%"
        End If


    End Sub
End Class