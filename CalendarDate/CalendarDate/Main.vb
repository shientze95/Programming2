Public Class frmMain

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim datenow As Integer
        datenow = txtDate.Text
        If datenow > 0 And datenow < 32 Then
            MsgBox("The date is valid!")
        ElseIf datenow < 1 Or datenow > 31 Then
            MsgBox("The date is invalid!")
        End If
    End Sub
End Class
