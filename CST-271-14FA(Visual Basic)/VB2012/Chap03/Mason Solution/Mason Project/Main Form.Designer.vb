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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblReg1ProjSales = New System.Windows.Forms.Label()
        Me.lblReg2ProjSales = New System.Windows.Forms.Label()
        Me.lblReg3ProjSales = New System.Windows.Forms.Label()
        Me.txtReg1Sales = New System.Windows.Forms.TextBox()
        Me.txtReg1IncPer = New System.Windows.Forms.TextBox()
        Me.txtReg2Sales = New System.Windows.Forms.TextBox()
        Me.txtReg2IncPer = New System.Windows.Forms.TextBox()
        Me.txtReg3Sales = New System.Windows.Forms.TextBox()
        Me.txtReg3IncPer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Region &1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Region &2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Region &3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Increase Percentage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "(in decimal form)"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(250, 229)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(83, 35)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(339, 229)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(428, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 35)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Projected Sales"
        '
        'lblReg1ProjSales
        '
        Me.lblReg1ProjSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReg1ProjSales.Location = New System.Drawing.Point(401, 68)
        Me.lblReg1ProjSales.Name = "lblReg1ProjSales"
        Me.lblReg1ProjSales.Size = New System.Drawing.Size(110, 26)
        Me.lblReg1ProjSales.TabIndex = 16
        Me.lblReg1ProjSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg2ProjSales
        '
        Me.lblReg2ProjSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReg2ProjSales.Location = New System.Drawing.Point(401, 113)
        Me.lblReg2ProjSales.Name = "lblReg2ProjSales"
        Me.lblReg2ProjSales.Size = New System.Drawing.Size(110, 26)
        Me.lblReg2ProjSales.TabIndex = 17
        Me.lblReg2ProjSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg3ProjSales
        '
        Me.lblReg3ProjSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReg3ProjSales.Location = New System.Drawing.Point(401, 158)
        Me.lblReg3ProjSales.Name = "lblReg3ProjSales"
        Me.lblReg3ProjSales.Size = New System.Drawing.Size(110, 26)
        Me.lblReg3ProjSales.TabIndex = 18
        Me.lblReg3ProjSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReg1Sales
        '
        Me.txtReg1Sales.Location = New System.Drawing.Point(127, 68)
        Me.txtReg1Sales.Name = "txtReg1Sales"
        Me.txtReg1Sales.Size = New System.Drawing.Size(75, 27)
        Me.txtReg1Sales.TabIndex = 1
        '
        'txtReg1IncPer
        '
        Me.txtReg1IncPer.Location = New System.Drawing.Point(257, 68)
        Me.txtReg1IncPer.Name = "txtReg1IncPer"
        Me.txtReg1IncPer.Size = New System.Drawing.Size(55, 27)
        Me.txtReg1IncPer.TabIndex = 2
        '
        'txtReg2Sales
        '
        Me.txtReg2Sales.Location = New System.Drawing.Point(127, 113)
        Me.txtReg2Sales.Name = "txtReg2Sales"
        Me.txtReg2Sales.Size = New System.Drawing.Size(75, 27)
        Me.txtReg2Sales.TabIndex = 4
        '
        'txtReg2IncPer
        '
        Me.txtReg2IncPer.Location = New System.Drawing.Point(257, 113)
        Me.txtReg2IncPer.Name = "txtReg2IncPer"
        Me.txtReg2IncPer.Size = New System.Drawing.Size(55, 27)
        Me.txtReg2IncPer.TabIndex = 5
        '
        'txtReg3Sales
        '
        Me.txtReg3Sales.Location = New System.Drawing.Point(127, 158)
        Me.txtReg3Sales.Name = "txtReg3Sales"
        Me.txtReg3Sales.Size = New System.Drawing.Size(75, 27)
        Me.txtReg3Sales.TabIndex = 7
        '
        'txtReg3IncPer
        '
        Me.txtReg3IncPer.Location = New System.Drawing.Point(257, 158)
        Me.txtReg3IncPer.Name = "txtReg3IncPer"
        Me.txtReg3IncPer.Size = New System.Drawing.Size(55, 27)
        Me.txtReg3IncPer.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 294)
        Me.Controls.Add(Me.txtReg3IncPer)
        Me.Controls.Add(Me.txtReg3Sales)
        Me.Controls.Add(Me.txtReg2IncPer)
        Me.Controls.Add(Me.txtReg2Sales)
        Me.Controls.Add(Me.txtReg1IncPer)
        Me.Controls.Add(Me.txtReg1Sales)
        Me.Controls.Add(Me.lblReg3ProjSales)
        Me.Controls.Add(Me.lblReg2ProjSales)
        Me.Controls.Add(Me.lblReg1ProjSales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mason Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblReg1ProjSales As System.Windows.Forms.Label
    Friend WithEvents lblReg2ProjSales As System.Windows.Forms.Label
    Friend WithEvents lblReg3ProjSales As System.Windows.Forms.Label
    Friend WithEvents txtReg1Sales As System.Windows.Forms.TextBox
    Friend WithEvents txtReg1IncPer As System.Windows.Forms.TextBox
    Friend WithEvents txtReg2Sales As System.Windows.Forms.TextBox
    Friend WithEvents txtReg2IncPer As System.Windows.Forms.TextBox
    Friend WithEvents txtReg3Sales As System.Windows.Forms.TextBox
    Friend WithEvents txtReg3IncPer As System.Windows.Forms.TextBox

End Class
