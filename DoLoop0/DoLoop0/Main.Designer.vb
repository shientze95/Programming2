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
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.txtStep = New System.Windows.Forms.TextBox()
        Me.lblStep = New System.Windows.Forms.Label()
        Me.btnValue2 = New System.Windows.Forms.Button()
        Me.rdPre = New System.Windows.Forms.RadioButton()
        Me.rdPost = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lbDisplay
        '
        Me.lbDisplay.FormattingEnabled = True
        Me.lbDisplay.Location = New System.Drawing.Point(12, 88)
        Me.lbDisplay.Name = "lbDisplay"
        Me.lbDisplay.Size = New System.Drawing.Size(445, 199)
        Me.lbDisplay.TabIndex = 0
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(13, 13)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(32, 13)
        Me.lblStart.TabIndex = 1
        Me.lblStart.Text = "Start:"
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(58, 10)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 20)
        Me.txtStart.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(175, 10)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(116, 32)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display (Do While)"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(58, 36)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtEnd.TabIndex = 5
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(13, 39)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(29, 13)
        Me.lblEnd.TabIndex = 4
        Me.lblEnd.Text = "End:"
        '
        'txtStep
        '
        Me.txtStep.Location = New System.Drawing.Point(58, 62)
        Me.txtStep.Name = "txtStep"
        Me.txtStep.Size = New System.Drawing.Size(100, 20)
        Me.txtStep.TabIndex = 7
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(13, 65)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(32, 13)
        Me.lblStep.TabIndex = 6
        Me.lblStep.Text = "Step:"
        '
        'btnValue2
        '
        Me.btnValue2.Location = New System.Drawing.Point(175, 50)
        Me.btnValue2.Name = "btnValue2"
        Me.btnValue2.Size = New System.Drawing.Size(116, 32)
        Me.btnValue2.TabIndex = 8
        Me.btnValue2.Text = "Display (Do Until)"
        Me.btnValue2.UseVisualStyleBackColor = True
        '
        'rdPre
        '
        Me.rdPre.AutoSize = True
        Me.rdPre.Checked = True
        Me.rdPre.Location = New System.Drawing.Point(297, 18)
        Me.rdPre.Name = "rdPre"
        Me.rdPre.Size = New System.Drawing.Size(65, 17)
        Me.rdPre.TabIndex = 11
        Me.rdPre.TabStop = True
        Me.rdPre.Text = "Pre-Test"
        Me.rdPre.UseVisualStyleBackColor = True
        '
        'rdPost
        '
        Me.rdPost.AutoSize = True
        Me.rdPost.Location = New System.Drawing.Point(297, 58)
        Me.rdPost.Name = "rdPost"
        Me.rdPost.Size = New System.Drawing.Size(70, 17)
        Me.rdPost.TabIndex = 12
        Me.rdPost.Text = "Post-Test"
        Me.rdPost.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 300)
        Me.Controls.Add(Me.rdPost)
        Me.Controls.Add(Me.rdPre)
        Me.Controls.Add(Me.btnValue2)
        Me.Controls.Add(Me.txtStep)
        Me.Controls.Add(Me.lblStep)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lbDisplay)
        Me.Name = "frmMain"
        Me.Text = "Do Loops :D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents txtStep As System.Windows.Forms.TextBox
    Friend WithEvents lblStep As System.Windows.Forms.Label
    Friend WithEvents btnValue2 As System.Windows.Forms.Button
    Friend WithEvents rdPre As System.Windows.Forms.RadioButton
    Friend WithEvents rdPost As System.Windows.Forms.RadioButton

End Class
