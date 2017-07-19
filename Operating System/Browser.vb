Public Class Browser
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WebBrowser1.Navigate("http://www.google.com")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        WebBrowser1.Select()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        Dim objTextBox As RichTextBox = Me.ActiveControl
        'Copy the text to the clipboard and clear the field
        objTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        Dim objTextBox As RichTextBox = Me.ActiveControl
        'Copy the text to the clipboard and clear the field
        objTextBox.Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        Dim objTextBox As RichTextBox = Me.ActiveControl
        'Copy the text to the clipboard and clear the field
        objTextBox.Cut()
    End Sub
End Class