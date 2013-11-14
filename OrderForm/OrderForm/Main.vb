Public Class frmMain
#Region "Declaration"
    Dim categories As String() = {"Snacks", "Rice", "Noodles"}
    Dim snacks As String() = {"Fries", "Garlic Bread", "Fired Chicken Wing", "Spring Roll"}
    Dim rice As String() = {"Chicken Rice", "Fried Rice", "Curry Rice", "Thai Chicken Rice"}
    Dim noodles As String() = {"Fired Seafood Noodle", "Chicken Noodle", "Beef Noodle", "Prawn Noodle"}
    Dim tsnacks, trice, tnoodles, total As Double
#End Region
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each x As String In categories
            cbCat.Items.Add(x)
        Next
        cbCat.SelectedIndex = 0
    End Sub

    Private Sub cbCat_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCat.SelectedValueChanged
        lbDish.Items.Clear()
        If cbCat.SelectedItem = "Snacks" Then
            For Each x As String In snacks
                lbDish.Items.Add(x)
            Next
        ElseIf cbCat.SelectedItem = "Rice" Then
            For Each x As String In rice
                lbDish.Items.Add(x)
            Next
        ElseIf cbCat.SelectedItem = "Noodles" Then
            For Each x As String In noodles
                lbDish.Items.Add(x)
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim item, format, cat As String
        Dim count As Double

        If lbDish.SelectedItem Is Nothing Then
            MsgBox("Please select an item!")
        Else
            item = lbDish.SelectedItem
            Double.TryParse(txtCount.Text, count)
            If count = 0 Then
                MsgBox("Quantity must be greater than 0!")
            Else
                format = item & " x " & count.ToString()
                cat = cbCat.SelectedItem
                Select Case cat
                    Case "Snacks"
                        tsnacks += (1 * count)
                    Case "Rice"
                        trice += (1 * count)
                    Case "Noodles"
                        tnoodles += (1 * count)
                End Select
                lbList.Items.Add(format)
            End If
        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        total = (tsnacks * 2.5) + (trice * 4) + (tnoodles * 3.5)
        lblTotal.Text = total.ToString("C2")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lbDish.Items.Clear()
        lbList.Items.Clear()
        total = 0
        trice = 0
        tsnacks = 0
        tnoodles = 0
        txtCount.Text = "0"
    End Sub
End Class
