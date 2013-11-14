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
        Me.lbDisplay = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDisplay
        '
        Me.lbDisplay.FormattingEnabled = True
        Me.lbDisplay.Location = New System.Drawing.Point(12, 12)
        Me.lbDisplay.Name = "lbDisplay"
        Me.lbDisplay.Size = New System.Drawing.Size(260, 212)
        Me.lbDisplay.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 230)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(260, 23)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lbDisplay)
        Me.Name = "frmMain"
        Me.Text = "Fibonacci Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
