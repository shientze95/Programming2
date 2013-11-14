Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim LBVal As String() = {"CPU", "Mouse", "Computer"}
        For Each Item As String In LBVal
            lbLOL.Items.Add(Item)
        Next
    End Sub

    Private Sub btnQ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ1.Click
        Dim MyInt As Integer() = {2, 5, 17}
        For Each X As Integer In MyInt
            MsgBox(X.ToString())
        Next
    End Sub

    Private Sub btnQ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ2.Click
        Dim vStr As String = "Visual Basic Introduction to Programming"
        Dim occur1, occur2 As Double
        occur1 = vStr.IndexOf("ro")
        occur2 = vStr.IndexOf("ro", CInt(occur1 + 1))
        MsgBox("The second occurence of 'ro' is at: " & occur2.ToString())
    End Sub

    Private Sub btnQ3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ3.Click
        Dim TheIndex As Integer
        Dim MyArray(lbLOL.Items.Count - 1) As String
        For Each Item As String In lbLOL.Items
            TheIndex = lbLOL.FindString(Item)
            MyArray(TheIndex) = Item
        Next
    End Sub


    Private Sub btnQ4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ4.Click
        Dim Factorial, Total As Double
        Double.TryParse(txtQ4.Text, Factorial)
        Select Case Factorial
            Case 0
                Total = 1
            Case Else
                Total = 1
                Do Until Factorial = 1
                    Total *= Factorial
                    Factorial -= 1
                Loop
        End Select
        MsgBox(Total.ToString())
    End Sub
End Class
