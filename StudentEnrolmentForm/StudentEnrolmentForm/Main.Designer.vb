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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.StudentList = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(106, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(106, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter your ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb3)
        Me.GroupBox1.Controls.Add(Me.cb2)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 95)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pre-Requisite Unit"
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(15, 65)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(86, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Mathematics"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(15, 42)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(42, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "BM"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(15, 19)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(93, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Programming I"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'StudentList
        '
        Me.StudentList.FormattingEnabled = True
        Me.StudentList.Location = New System.Drawing.Point(212, 10)
        Me.StudentList.Name = "StudentList"
        Me.StudentList.Size = New System.Drawing.Size(120, 147)
        Me.StudentList.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Total No of Students"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 191)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StudentList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Student Enrolment Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents StudentList As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
