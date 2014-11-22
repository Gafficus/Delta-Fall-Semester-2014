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
        Me.txtEarth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJupiter = New System.Windows.Forms.Label()
        Me.lblVenus = New System.Windows.Forms.Label()
        Me.lblMars = New System.Windows.Forms.Label()
        Me.lblMoon = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your earth &weight:"
        '
        'txtEarth
        '
        Me.txtEarth.Location = New System.Drawing.Point(148, 31)
        Me.txtEarth.Name = "txtEarth"
        Me.txtEarth.Size = New System.Drawing.Size(49, 25)
        Me.txtEarth.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jupiter:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Venus:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mars:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Moon:"
        '
        'lblJupiter
        '
        Me.lblJupiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJupiter.Location = New System.Drawing.Point(83, 101)
        Me.lblJupiter.Name = "lblJupiter"
        Me.lblJupiter.Size = New System.Drawing.Size(70, 30)
        Me.lblJupiter.TabIndex = 6
        Me.lblJupiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVenus
        '
        Me.lblVenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVenus.Location = New System.Drawing.Point(83, 139)
        Me.lblVenus.Name = "lblVenus"
        Me.lblVenus.Size = New System.Drawing.Size(70, 30)
        Me.lblVenus.TabIndex = 8
        Me.lblVenus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMars
        '
        Me.lblMars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMars.Location = New System.Drawing.Point(83, 177)
        Me.lblMars.Name = "lblMars"
        Me.lblMars.Size = New System.Drawing.Size(70, 30)
        Me.lblMars.TabIndex = 10
        Me.lblMars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoon
        '
        Me.lblMoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoon.Location = New System.Drawing.Point(83, 217)
        Me.lblMoon.Name = "lblMoon"
        Me.lblMoon.Size = New System.Drawing.Size(70, 30)
        Me.lblMoon.TabIndex = 12
        Me.lblMoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(167, 92)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(111, 36)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "&Display Weights"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(167, 134)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Your weight on:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 280)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblMoon)
        Me.Controls.Add(Me.lblMars)
        Me.Controls.Add(Me.lblVenus)
        Me.Controls.Add(Me.lblJupiter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEarth)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allenton Observatory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEarth As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblJupiter As System.Windows.Forms.Label
    Friend WithEvents lblVenus As System.Windows.Forms.Label
    Friend WithEvents lblMars As System.Windows.Forms.Label
    Friend WithEvents lblMoon As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
