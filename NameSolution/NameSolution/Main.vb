Public Class frmMain
#Region "Declaration"
    Dim Names As String() = {"Fanny Chia", "Josephine Lee", "Julia Tan", "Justin Lau", "Thomas Kho"}
    Dim ShowName As String()
#End Region
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearItems()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbNames.DataSource = Names

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        ClearItems()
        lblName.Text = "First Name"
        For Each Name As String In Names
            ShowName = Name.Split(" ")
            lbShow.Items.Add(ShowName(0))
        Next
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        ClearItems()
        lblName.Text = "Last Name"
        For Each Name As String In Names
            ShowName = Name.Split(" ")
            lbShow.Items.Add(ShowName(1))
        Next
    End Sub

    Private Sub ClearItems()
        lbShow.Items.Clear()
        lblName.Text = vbNullString
    End Sub
End Class
