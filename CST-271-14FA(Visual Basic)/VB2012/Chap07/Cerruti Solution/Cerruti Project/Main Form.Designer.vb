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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFwt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstHours = New System.Windows.Forms.ListBox()
        Me.lstRates = New System.Windows.Forms.ListBox()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radMarried = New System.Windows.Forms.RadioButton()
        Me.cboAllowances = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(629, 296)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(549, 296)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(76, 35)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "&Calculate"
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(400, 49)
        Me.lblNet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(112, 35)
        Me.lblNet.TabIndex = 7
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Net pay:"
        '
        'lblFica
        '
        Me.lblFica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFica.Location = New System.Drawing.Point(272, 49)
        Me.lblFica.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(112, 35)
        Me.lblFica.TabIndex = 5
        Me.lblFica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "FICA:"
        '
        'lblFwt
        '
        Me.lblFwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFwt.Location = New System.Drawing.Point(144, 49)
        Me.lblFwt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFwt.Name = "lblFwt"
        Me.lblFwt.Size = New System.Drawing.Size(112, 35)
        Me.lblFwt.TabIndex = 3
        Me.lblFwt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FWT:"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(16, 49)
        Me.lblGross.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(112, 35)
        Me.lblGross.TabIndex = 1
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gross pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(599, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Allowances:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Hours:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(17, 52)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 25)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Name:"
        '
        'lstHours
        '
        Me.lstHours.FormattingEnabled = True
        Me.lstHours.ItemHeight = 17
        Me.lstHours.Location = New System.Drawing.Point(403, 49)
        Me.lstHours.Margin = New System.Windows.Forms.Padding(2)
        Me.lstHours.Name = "lstHours"
        Me.lstHours.Size = New System.Drawing.Size(61, 72)
        Me.lstHours.TabIndex = 5
        '
        'lstRates
        '
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.ItemHeight = 17
        Me.lstRates.Location = New System.Drawing.Point(492, 49)
        Me.lstRates.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(78, 72)
        Me.lstRates.TabIndex = 7
        '
        'radSingle
        '
        Me.radSingle.Checked = True
        Me.radSingle.Location = New System.Drawing.Point(304, 30)
        Me.radSingle.Margin = New System.Windows.Forms.Padding(2)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(84, 22)
        Me.radSingle.TabIndex = 2
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "&Single"
        '
        'radMarried
        '
        Me.radMarried.Location = New System.Drawing.Point(304, 62)
        Me.radMarried.Margin = New System.Windows.Forms.Padding(2)
        Me.radMarried.Name = "radMarried"
        Me.radMarried.Size = New System.Drawing.Size(84, 22)
        Me.radMarried.TabIndex = 3
        Me.radMarried.Text = "&Married"
        '
        'cboAllowances
        '
        Me.cboAllowances.FormattingEnabled = True
        Me.cboAllowances.Location = New System.Drawing.Point(603, 49)
        Me.cboAllowances.Name = "cboAllowances"
        Me.cboAllowances.Size = New System.Drawing.Size(54, 25)
        Me.cboAllowances.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cerruti_Project.My.Resources.Resources.Cerruti
        Me.PictureBox1.Location = New System.Drawing.Point(141, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cboAllowances)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.radMarried)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lstRates)
        Me.GroupBox1.Controls.Add(Me.lstHours)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFica)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblGross)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblFwt)
        Me.GroupBox2.Controls.Add(Me.lblNet)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 375)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerruti Company"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFica As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblFwt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstHours As System.Windows.Forms.ListBox
    Friend WithEvents lstRates As System.Windows.Forms.ListBox
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents radMarried As System.Windows.Forms.RadioButton
    Friend WithEvents cboAllowances As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
