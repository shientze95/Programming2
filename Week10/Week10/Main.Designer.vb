<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GAdd = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtT3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtT2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtT1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GDisplay = New System.Windows.Forms.GroupBox()
        Me.ShowT3 = New System.Windows.Forms.Label()
        Me.ShowT2 = New System.Windows.Forms.Label()
        Me.ShowT1 = New System.Windows.Forms.Label()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbName = New System.Windows.Forms.ComboBox()
        Me.GAdd.SuspendLayout()
        Me.GDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'GAdd
        '
        Me.GAdd.Controls.Add(Me.btnAdd)
        Me.GAdd.Controls.Add(Me.txtT3)
        Me.GAdd.Controls.Add(Me.Label4)
        Me.GAdd.Controls.Add(Me.txtT2)
        Me.GAdd.Controls.Add(Me.Label3)
        Me.GAdd.Controls.Add(Me.txtT1)
        Me.GAdd.Controls.Add(Me.Label2)
        Me.GAdd.Controls.Add(Me.txtName)
        Me.GAdd.Controls.Add(Me.Label1)
        Me.GAdd.Location = New System.Drawing.Point(13, 13)
        Me.GAdd.Name = "GAdd"
        Me.GAdd.Size = New System.Drawing.Size(166, 178)
        Me.GAdd.TabIndex = 0
        Me.GAdd.TabStop = False
        Me.GAdd.Text = "Add Student Record"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(52, 125)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtT3
        '
        Me.txtT3.Location = New System.Drawing.Point(52, 98)
        Me.txtT3.Name = "txtT3"
        Me.txtT3.Size = New System.Drawing.Size(100, 20)
        Me.txtT3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Test 3:"
        '
        'txtT2
        '
        Me.txtT2.Location = New System.Drawing.Point(52, 72)
        Me.txtT2.Name = "txtT2"
        Me.txtT2.Size = New System.Drawing.Size(100, 20)
        Me.txtT2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Test 2:"
        '
        'txtT1
        '
        Me.txtT1.Location = New System.Drawing.Point(52, 46)
        Me.txtT1.Name = "txtT1"
        Me.txtT1.Size = New System.Drawing.Size(100, 20)
        Me.txtT1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test 1:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(52, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GDisplay
        '
        Me.GDisplay.Controls.Add(Me.ShowT3)
        Me.GDisplay.Controls.Add(Me.ShowT2)
        Me.GDisplay.Controls.Add(Me.ShowT1)
        Me.GDisplay.Controls.Add(Me.txtSummary)
        Me.GDisplay.Controls.Add(Me.btnSummary)
        Me.GDisplay.Controls.Add(Me.btnResults)
        Me.GDisplay.Controls.Add(Me.Label5)
        Me.GDisplay.Controls.Add(Me.Label6)
        Me.GDisplay.Controls.Add(Me.Label7)
        Me.GDisplay.Controls.Add(Me.cbName)
        Me.GDisplay.Location = New System.Drawing.Point(186, 13)
        Me.GDisplay.Name = "GDisplay"
        Me.GDisplay.Size = New System.Drawing.Size(285, 307)
        Me.GDisplay.TabIndex = 1
        Me.GDisplay.TabStop = False
        Me.GDisplay.Text = "Display Student Record"
        '
        'ShowT3
        '
        Me.ShowT3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShowT3.Location = New System.Drawing.Point(53, 98)
        Me.ShowT3.Name = "ShowT3"
        Me.ShowT3.Size = New System.Drawing.Size(100, 20)
        Me.ShowT3.TabIndex = 19
        Me.ShowT3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShowT2
        '
        Me.ShowT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShowT2.Location = New System.Drawing.Point(53, 72)
        Me.ShowT2.Name = "ShowT2"
        Me.ShowT2.Size = New System.Drawing.Size(100, 20)
        Me.ShowT2.TabIndex = 18
        Me.ShowT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShowT1
        '
        Me.ShowT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShowT1.Location = New System.Drawing.Point(53, 46)
        Me.ShowT1.Name = "ShowT1"
        Me.ShowT1.Size = New System.Drawing.Size(100, 20)
        Me.ShowT1.TabIndex = 17
        Me.ShowT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSummary
        '
        Me.txtSummary.Location = New System.Drawing.Point(52, 124)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.Size = New System.Drawing.Size(227, 177)
        Me.txtSummary.TabIndex = 16
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(159, 46)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(120, 23)
        Me.btnSummary.TabIndex = 15
        Me.btnSummary.Text = "Display Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(159, 20)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(120, 23)
        Me.btnResults.TabIndex = 14
        Me.btnResults.Text = "Display Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Test 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Test 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Test 1:"
        '
        'cbName
        '
        Me.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbName.FormattingEnabled = True
        Me.cbName.Location = New System.Drawing.Point(6, 20)
        Me.cbName.Name = "cbName"
        Me.cbName.Size = New System.Drawing.Size(146, 21)
        Me.cbName.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 329)
        Me.Controls.Add(Me.GDisplay)
        Me.Controls.Add(Me.GAdd)
        Me.Name = "frmMain"
        Me.Text = "Student Record"
        Me.GAdd.ResumeLayout(False)
        Me.GAdd.PerformLayout()
        Me.GDisplay.ResumeLayout(False)
        Me.GDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GAdd As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtT3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtT2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtT1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents ShowT3 As System.Windows.Forms.Label
    Friend WithEvents ShowT2 As System.Windows.Forms.Label
    Friend WithEvents ShowT1 As System.Windows.Forms.Label
    Friend WithEvents txtSummary As System.Windows.Forms.TextBox
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbName As System.Windows.Forms.ComboBox

End Class
