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
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnParameterized = New System.Windows.Forms.Button()
        Me.lblHireDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMonth = New System.Windows.Forms.ListBox()
        Me.lstDay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(171, 26)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(202, 31)
        Me.btnDefault.TabIndex = 4
        Me.btnDefault.Text = "Display &Hire Date - Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(171, 108)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 31)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        '
        'btnParameterized
        '
        Me.btnParameterized.Location = New System.Drawing.Point(171, 67)
        Me.btnParameterized.Margin = New System.Windows.Forms.Padding(2)
        Me.btnParameterized.Name = "btnParameterized"
        Me.btnParameterized.Size = New System.Drawing.Size(202, 31)
        Me.btnParameterized.TabIndex = 5
        Me.btnParameterized.Text = "Display Hire Date - &Parameterized"
        '
        'lblHireDate
        '
        Me.lblHireDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHireDate.Location = New System.Drawing.Point(25, 177)
        Me.lblHireDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHireDate.Name = "lblHireDate"
        Me.lblHireDate.Size = New System.Drawing.Size(110, 30)
        Me.lblHireDate.TabIndex = 8
        Me.lblHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hire date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Day:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Month:"
        '
        'lstMonth
        '
        Me.lstMonth.FormattingEnabled = True
        Me.lstMonth.ItemHeight = 15
        Me.lstMonth.Location = New System.Drawing.Point(25, 45)
        Me.lstMonth.Name = "lstMonth"
        Me.lstMonth.Size = New System.Drawing.Size(51, 79)
        Me.lstMonth.TabIndex = 9
        '
        'lstDay
        '
        Me.lstDay.FormattingEnabled = True
        Me.lstDay.ItemHeight = 15
        Me.lstDay.Location = New System.Drawing.Point(84, 45)
        Me.lstDay.Name = "lstDay"
        Me.lstDay.Size = New System.Drawing.Size(51, 79)
        Me.lstDay.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 241)
        Me.Controls.Add(Me.lstDay)
        Me.Controls.Add(Me.lstMonth)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnParameterized)
        Me.Controls.Add(Me.lblHireDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hire Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnParameterized As System.Windows.Forms.Button
    Friend WithEvents lblHireDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMonth As System.Windows.Forms.ListBox
    Friend WithEvents lstDay As System.Windows.Forms.ListBox

End Class
