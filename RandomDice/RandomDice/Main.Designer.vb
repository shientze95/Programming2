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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TrackBar()
        Me.tb2 = New System.Windows.Forms.TrackBar()
        Me.btnResult = New System.Windows.Forms.Button()
        CType(Me.tb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose a number in the trackbar and click the result."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DIE 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIE 2:"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(55, 29)
        Me.tb1.Maximum = 6
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(104, 45)
        Me.tb1.TabIndex = 3
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(55, 80)
        Me.tb2.Maximum = 6
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(104, 45)
        Me.tb2.TabIndex = 4
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(56, 131)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(103, 23)
        Me.btnResult.TabIndex = 5
        Me.btnResult.Text = "Result"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 165)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Dice"
        CType(Me.tb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb1 As System.Windows.Forms.TrackBar
    Friend WithEvents tb2 As System.Windows.Forms.TrackBar
    Friend WithEvents btnResult As System.Windows.Forms.Button

End Class
