Public Class start_menu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("explorer.exe")
        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        support.show
    End Sub

    Private Sub start_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Browser.Show()
    End Sub
End Class
