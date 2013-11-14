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
        Me.gbGender = New System.Windows.Forms.GroupBox()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.gbActivity = New System.Windows.Forms.GroupBox()
        Me.radI = New System.Windows.Forms.RadioButton()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbGender.SuspendLayout()
        Me.gbActivity.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGender
        '
        Me.gbGender.Controls.Add(Me.radM)
        Me.gbGender.Controls.Add(Me.radF)
        Me.gbGender.Location = New System.Drawing.Point(13, 13)
        Me.gbGender.Name = "gbGender"
        Me.gbGender.Size = New System.Drawing.Size(119, 70)
        Me.gbGender.TabIndex = 0
        Me.gbGender.TabStop = False
        Me.gbGender.Text = "Gender"
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Location = New System.Drawing.Point(7, 44)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(48, 17)
        Me.radM.TabIndex = 1
        Me.radM.TabStop = True
        Me.radM.Text = "Male"
        Me.radM.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Checked = True
        Me.radF.Location = New System.Drawing.Point(7, 20)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(59, 17)
        Me.radF.TabIndex = 0
        Me.radF.TabStop = True
        Me.radF.Text = "Female"
        Me.radF.UseVisualStyleBackColor = True
        '
        'gbActivity
        '
        Me.gbActivity.Controls.Add(Me.radI)
        Me.gbActivity.Controls.Add(Me.radA)
        Me.gbActivity.Location = New System.Drawing.Point(138, 14)
        Me.gbActivity.Name = "gbActivity"
        Me.gbActivity.Size = New System.Drawing.Size(133, 70)
        Me.gbActivity.TabIndex = 1
        Me.gbActivity.TabStop = False
        Me.gbActivity.Text = "Activity"
        '
        'radI
        '
        Me.radI.AutoSize = True
        Me.radI.Location = New System.Drawing.Point(7, 44)
        Me.radI.Name = "radI"
        Me.radI.Size = New System.Drawing.Size(63, 17)
        Me.radI.TabIndex = 1
        Me.radI.TabStop = True
        Me.radI.Text = "Inactive"
        Me.radI.UseVisualStyleBackColor = True
        '
        'radA
        '
        Me.radA.AutoSize = True
        Me.radA.Checked = True
        Me.radA.Location = New System.Drawing.Point(7, 20)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(55, 17)
        Me.radA.TabIndex = 0
        Me.radA.TabStop = True
        Me.radA.Text = "Active"
        Me.radA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(13, 106)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(119, 20)
        Me.txtWeight.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Daily Calories:"
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Location = New System.Drawing.Point(13, 150)
        Me.lblDisplay.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(119, 20)
        Me.lblDisplay.TabIndex = 5
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(138, 89)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(133, 37)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calories" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(138, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 190)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbActivity)
        Me.Controls.Add(Me.gbGender)
        Me.Name = "frmMain"
        Me.Text = "Willow Health Club"
        Me.gbGender.ResumeLayout(False)
        Me.gbGender.PerformLayout()
        Me.gbActivity.ResumeLayout(False)
        Me.gbActivity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbGender As System.Windows.Forms.GroupBox
    Friend WithEvents radM As System.Windows.Forms.RadioButton
    Friend WithEvents radF As System.Windows.Forms.RadioButton
    Friend WithEvents gbActivity As System.Windows.Forms.GroupBox
    Friend WithEvents radI As System.Windows.Forms.RadioButton
    Friend WithEvents radA As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
