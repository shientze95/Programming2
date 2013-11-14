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
        Me.btnDate = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(13, 13)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(259, 23)
        Me.btnDate.TabIndex = 0
        Me.btnDate.Text = "Enter the date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(13, 42)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(259, 20)
        Me.txtDate.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 74)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnDate)
        Me.Name = "frmMain"
        Me.Text = "Calendar Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox

End Class
