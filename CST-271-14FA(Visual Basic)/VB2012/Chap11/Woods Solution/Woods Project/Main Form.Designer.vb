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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSalaryId = New System.Windows.Forms.Label()
        Me.lblHoursId = New System.Windows.Forms.Label()
        Me.lblRateId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lstHours = New System.Windows.Forms.ListBox()
        Me.lstRate = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstSalary = New System.Windows.Forms.ListBox()
        Me.radSalaried = New System.Windows.Forms.RadioButton()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num&ber:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(211, 98)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(70, 27)
        Me.txtNum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(307, 98)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(289, 27)
        Me.txtName.TabIndex = 3
        '
        'lblSalaryId
        '
        Me.lblSalaryId.AutoSize = True
        Me.lblSalaryId.Location = New System.Drawing.Point(219, 69)
        Me.lblSalaryId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalaryId.Name = "lblSalaryId"
        Me.lblSalaryId.Size = New System.Drawing.Size(100, 20)
        Me.lblSalaryId.TabIndex = 6
        Me.lblSalaryId.Text = "&Annual salary:"
        Me.lblSalaryId.Visible = False
        '
        'lblHoursId
        '
        Me.lblHoursId.AutoSize = True
        Me.lblHoursId.Location = New System.Drawing.Point(13, 69)
        Me.lblHoursId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoursId.Name = "lblHoursId"
        Me.lblHoursId.Size = New System.Drawing.Size(51, 20)
        Me.lblHoursId.TabIndex = 1
        Me.lblHoursId.Text = "&Hours:"
        '
        'lblRateId
        '
        Me.lblRateId.AutoSize = True
        Me.lblRateId.Location = New System.Drawing.Point(111, 69)
        Me.lblRateId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRateId.Name = "lblRateId"
        Me.lblRateId.Size = New System.Drawing.Size(42, 20)
        Me.lblRateId.TabIndex = 3
        Me.lblRateId.Text = "&Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(631, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gross pay:"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(634, 98)
        Me.lblGross.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(101, 29)
        Me.lblGross.TabIndex = 8
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstHours
        '
        Me.lstHours.FormattingEnabled = True
        Me.lstHours.ItemHeight = 20
        Me.lstHours.Location = New System.Drawing.Point(13, 94)
        Me.lstHours.Margin = New System.Windows.Forms.Padding(2)
        Me.lstHours.Name = "lstHours"
        Me.lstHours.Size = New System.Drawing.Size(81, 164)
        Me.lstHours.TabIndex = 2
        '
        'lstRate
        '
        Me.lstRate.FormattingEnabled = True
        Me.lstRate.ItemHeight = 20
        Me.lstRate.Location = New System.Drawing.Point(115, 94)
        Me.lstRate.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRate.Name = "lstRate"
        Me.lstRate.Size = New System.Drawing.Size(81, 164)
        Me.lstRate.TabIndex = 4
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(603, 451)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(102, 34)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(710, 451)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 34)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        '
        'lstSalary
        '
        Me.lstSalary.FormattingEnabled = True
        Me.lstSalary.ItemHeight = 20
        Me.lstSalary.Location = New System.Drawing.Point(219, 94)
        Me.lstSalary.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSalary.Name = "lstSalary"
        Me.lstSalary.Size = New System.Drawing.Size(114, 164)
        Me.lstSalary.TabIndex = 7
        Me.lstSalary.Visible = False
        '
        'radSalaried
        '
        Me.radSalaried.Location = New System.Drawing.Point(219, 26)
        Me.radSalaried.Margin = New System.Windows.Forms.Padding(2)
        Me.radSalaried.Name = "radSalaried"
        Me.radSalaried.Size = New System.Drawing.Size(166, 36)
        Me.radSalaried.TabIndex = 5
        Me.radSalaried.Text = "&Salaried employee"
        '
        'radHourly
        '
        Me.radHourly.Checked = True
        Me.radHourly.Location = New System.Drawing.Point(18, 26)
        Me.radHourly.Margin = New System.Windows.Forms.Padding(2)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(165, 36)
        Me.radHourly.TabIndex = 0
        Me.radHourly.TabStop = True
        Me.radHourly.Text = "Hourl&y employee"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSalaried)
        Me.GroupBox1.Controls.Add(Me.lblSalaryId)
        Me.GroupBox1.Controls.Add(Me.radHourly)
        Me.GroupBox1.Controls.Add(Me.lstSalary)
        Me.GroupBox1.Controls.Add(Me.lblHoursId)
        Me.GroupBox1.Controls.Add(Me.lblRateId)
        Me.GroupBox1.Controls.Add(Me.lstHours)
        Me.GroupBox1.Controls.Add(Me.lstRate)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 171)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(390, 284)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txtReport
        '
        Me.txtReport.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReport.Location = New System.Drawing.Point(446, 196)
        Me.txtReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReport.Size = New System.Drawing.Size(365, 209)
        Me.txtReport.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Report:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Woods_Project.My.Resources.Resources.Woods
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 513)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Woods Manufacturing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblSalaryId As System.Windows.Forms.Label
    Friend WithEvents lblHoursId As System.Windows.Forms.Label
    Friend WithEvents lblRateId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lstHours As System.Windows.Forms.ListBox
    Friend WithEvents lstRate As System.Windows.Forms.ListBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstSalary As System.Windows.Forms.ListBox
    Friend WithEvents radSalaried As System.Windows.Forms.RadioButton
    Friend WithEvents radHourly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
