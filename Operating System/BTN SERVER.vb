Public Class BTN
    Dim GBCount As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Boot.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub ControlPanelToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start("control")
    End Sub

    Private Sub Start_menu1_Load(sender As Object, e As EventArgs) Handles Start_menu1.Load

    End Sub

    Private Sub Form1_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GBCount = 0 Then
            Start_menu1.Show()
        ElseIf GBCount = 1 Then
            Start_menu1.Hide()
        End If
        GBCount = GBCount + 1
        If GBCount = 2 Then GBCount = 0

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("Control")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeOfDay

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub Time_Click(sender As Object, e As EventArgs) Handles Time.Click

    End Sub

    Private Sub LWin(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If GBCount = 0 Then
            Start_menu1.Show()
        ElseIf GBCount = 1 Then
            Start_menu1.Hide()
        End If
        GBCount = GBCount + 1
        If GBCount = 2 Then GBCount = 0
    End Sub
End Class
