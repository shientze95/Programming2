Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim endpoint, a As Single
        Dim bookname As String
        endpoint = InputBox("How many books do you want to add?")
        For a = 1 To endpoint
            bookname = InputBox("What is the name of your no. " & a & " book?")
            lbBook.Items.Add(bookname)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbBook.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim remove As String
        remove = InputBox("What book do you want to remove?")
        lbBook.Items.Remove(remove)
    End Sub
End Class
