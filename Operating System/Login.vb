Public Class Login
    Dim GBCount As Integer = 0
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If GBCount = 0 Then
            Power_Options1.Show()
        ElseIf GBCount = 1 Then
            Power_Options1.Hide()
        End If
        GBCount = GBCount + 1
        If GBCount = 2 Then GBCount = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "bhudson" And
                TextBox2.Text = "bighudbrett" Then
            Me.WindowState = FormWindowState.Minimized
            Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
            taskKill.WindowStyle = ProcessWindowStyle.Hidden
            Dim Process As Process = New Process()
            Process.StartInfo = taskKill
            Process.Start()
            Process.WaitForExit()
            Login_Wait.Show()
        Else
            TextBox2.Clear()
            MsgBox("HEY YOU!!! YES YOU LEARN YOUR PASSWORD")
        End If
    End Sub
End Class