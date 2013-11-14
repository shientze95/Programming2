Public Class frmMain
#Region "Declaration"
    Dim DateFormat As String() = {"dd-mm-yyyy", "dd/mm/yyyy", "01-Jan-1980"}
    Dim IC, DD, MM, YYYY, DOB As String
#End Region
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbFormat.DataSource = DateFormat
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        IC = txtIC.Text
        If IC.Length < 14 Then
            MsgBox("Invalid IC number.")
        Else
            DD = IC.Substring(4, 2)
            MM = IC.Substring(2, 2)
            YYYY = "19" + IC.Substring(0, 2)
            If lbFormat.SelectedItem = DateFormat(0) Then
                DOB = DD + "-" + MM + "-" + YYYY
            ElseIf lbFormat.SelectedItem = DateFormat(1) Then
                DOB = DD + "/" + MM + "/" + YYYY
            ElseIf lbFormat.SelectedItem = DateFormat(2) Then
                MM = FormatMonth(MM)
                If MM = "ERR" Then
                    MsgBox("Your IC number is invalid!")
                Else
                    DOB = DD + "-" + MM + "-" + YYYY
                End If

            End If
            lblDOB.Text = DOB
        End If
    End Sub

    Private Sub txtIC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIC.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

    End Sub

    Private Function FormatMonth(ByVal Month As String)
        Select Case Month
            Case "01"
                Month = "Jan"
            Case "02"
                Month = "Feb"
            Case "03"
                Month = "Mar"
            Case "04"
                Month = "Apr"
            Case "05"
                Month = "May"
            Case "06"
                Month = "Jun"
            Case "07"
                Month = "Jul"
            Case "08"
                Month = "Aug"
            Case "09"
                Month = "Sep"
            Case "10"
                Month = "Oct"
            Case "11"
                Month = "Nov"
            Case "12"
                Month = "Dec"
            Case Else
                Month = "ERR"
        End Select
        Return Month
    End Function
End Class
