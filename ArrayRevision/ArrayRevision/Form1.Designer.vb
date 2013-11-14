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
        Me.btnQ1 = New System.Windows.Forms.Button()
        Me.btnQ2 = New System.Windows.Forms.Button()
        Me.btnQ3 = New System.Windows.Forms.Button()
        Me.lbLOL = New System.Windows.Forms.ListBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.btnQ4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQ1
        '
        Me.btnQ1.Location = New System.Drawing.Point(13, 13)
        Me.btnQ1.Name = "btnQ1"
        Me.btnQ1.Size = New System.Drawing.Size(75, 23)
        Me.btnQ1.TabIndex = 0
        Me.btnQ1.Text = "Question 1"
        Me.btnQ1.UseVisualStyleBackColor = True
        '
        'btnQ2
        '
        Me.btnQ2.Location = New System.Drawing.Point(13, 42)
        Me.btnQ2.Name = "btnQ2"
        Me.btnQ2.Size = New System.Drawing.Size(75, 82)
        Me.btnQ2.TabIndex = 1
        Me.btnQ2.Text = "Question 2"
        Me.btnQ2.UseVisualStyleBackColor = True
        '
        'btnQ3
        '
        Me.btnQ3.Location = New System.Drawing.Point(95, 101)
        Me.btnQ3.Name = "btnQ3"
        Me.btnQ3.Size = New System.Drawing.Size(121, 23)
        Me.btnQ3.TabIndex = 2
        Me.btnQ3.Text = "Question 3"
        Me.btnQ3.UseVisualStyleBackColor = True
        '
        'lbLOL
        '
        Me.lbLOL.FormattingEnabled = True
        Me.lbLOL.Location = New System.Drawing.Point(95, 13)
        Me.lbLOL.Name = "lbLOL"
        Me.lbLOL.Size = New System.Drawing.Size(121, 82)
        Me.lbLOL.TabIndex = 3
        '
        'txtQ4
        '
        Me.txtQ4.Location = New System.Drawing.Point(223, 13)
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(100, 20)
        Me.txtQ4.TabIndex = 4
        '
        'btnQ4
        '
        Me.btnQ4.Location = New System.Drawing.Point(223, 40)
        Me.btnQ4.Name = "btnQ4"
        Me.btnQ4.Size = New System.Drawing.Size(100, 23)
        Me.btnQ4.TabIndex = 5
        Me.btnQ4.Text = "Question 4"
        Me.btnQ4.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 133)
        Me.Controls.Add(Me.btnQ4)
        Me.Controls.Add(Me.txtQ4)
        Me.Controls.Add(Me.lbLOL)
        Me.Controls.Add(Me.btnQ3)
        Me.Controls.Add(Me.btnQ2)
        Me.Controls.Add(Me.btnQ1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQ1 As System.Windows.Forms.Button
    Friend WithEvents btnQ2 As System.Windows.Forms.Button
    Friend WithEvents btnQ3 As System.Windows.Forms.Button
    Friend WithEvents lbLOL As System.Windows.Forms.ListBox
    Friend WithEvents txtQ4 As System.Windows.Forms.TextBox
    Friend WithEvents btnQ4 As System.Windows.Forms.Button

End Class
