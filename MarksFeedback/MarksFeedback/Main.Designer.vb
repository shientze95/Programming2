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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(12, 12)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(260, 23)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Enter Your Mark"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(13, 42)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(259, 20)
        Me.txtFeedback.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 80)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.btnCheck)
        Me.Name = "frmMain"
        Me.Text = "Feedback on marks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox

End Class
