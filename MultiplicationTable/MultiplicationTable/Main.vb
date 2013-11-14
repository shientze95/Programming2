Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbDisplay.Items.Clear()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim loopno, multno, startno, endno, resno As Double
        Dim displayitem As String
        Double.TryParse(cbS.SelectedItem, multno)
        Double.TryParse(txtStart.Text, startno)
        Double.TryParse(txtEnd.Text, endno)
        If startno > endno Then
            MessageBox.Show("Start number greater than end number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For loopno = startno To endno Step 1
                resno = multno * loopno
                displayitem = CStr(multno) & "x" & CStr(loopno) & "=" & CStr(resno)
                lbDisplay.Items.Add(displayitem)
            Next
        End If
        
    End Sub
End Class
