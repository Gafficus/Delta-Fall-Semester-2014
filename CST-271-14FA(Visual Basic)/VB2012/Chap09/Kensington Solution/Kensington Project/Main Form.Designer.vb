<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtEarned = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPossible = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrade.Location = New System.Drawing.Point(143, 110)
        Me.lblGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(53, 27)
        Me.lblGrade.TabIndex = 8
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Grade:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(337, 107)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        '
        'btnDisplay
        '
        Me.btnDisplay.Enabled = False
        Me.btnDisplay.Location = New System.Drawing.Point(210, 107)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(123, 30)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "&Display Grade"
        '
        'txtEarned
        '
        Me.txtEarned.Location = New System.Drawing.Point(20, 110)
        Me.txtEarned.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEarned.Name = "txtEarned"
        Me.txtEarned.Size = New System.Drawing.Size(53, 27)
        Me.txtEarned.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&Earned points:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Possible points:"
        '
        'txtPossible
        '
        Me.txtPossible.Location = New System.Drawing.Point(137, 27)
        Me.txtPossible.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPossible.Name = "txtPossible"
        Me.txtPossible.Size = New System.Drawing.Size(54, 27)
        Me.txtPossible.TabIndex = 1
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(210, 24)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(170, 30)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "&Create Grading Scale"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 175)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtPossible)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtEarned)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Professor Kensington"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents txtEarned As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPossible As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button

End Class
