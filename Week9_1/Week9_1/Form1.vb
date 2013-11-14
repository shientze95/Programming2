Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Months As String() = {"JAN", "FEB", "MAR", "APR", "MAY", "JUN"}
        'For Each x As String In Months
        'lbMonths.Items.Add(x)
        'Next
        Dim Count As Integer
        'Do While Count <= Months.GetUpperBound(0)
        'lbMonths.Items.Add(Months(Count))
        'Count += 1
        'Loop
        Do Until Count > Months.GetUpperBound(0)
            lbMonths.Items.Add(Months(Count))
            Count += 1
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblShow.Text = lbMonths.SelectedItem
    End Sub
End Class
