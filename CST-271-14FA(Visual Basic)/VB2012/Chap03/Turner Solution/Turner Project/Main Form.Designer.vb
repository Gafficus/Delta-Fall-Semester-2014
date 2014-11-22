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
        Me.txtCurrent1 = New System.Windows.Forms.TextBox()
        Me.txtCurrent2 = New System.Windows.Forms.TextBox()
        Me.txtCurrent3 = New System.Windows.Forms.TextBox()
        Me.lblNew1 = New System.Windows.Forms.Label()
        Me.lblNew2 = New System.Windows.Forms.Label()
        Me.lblNew3 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Job Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Current Hourly Pay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Hourly Pay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "&2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "&3:"
        '
        'txtCurrent1
        '
        Me.txtCurrent1.Location = New System.Drawing.Point(118, 72)
        Me.txtCurrent1.Name = "txtCurrent1"
        Me.txtCurrent1.Size = New System.Drawing.Size(100, 27)
        Me.txtCurrent1.TabIndex = 1
        '
        'txtCurrent2
        '
        Me.txtCurrent2.Location = New System.Drawing.Point(118, 109)
        Me.txtCurrent2.Name = "txtCurrent2"
        Me.txtCurrent2.Size = New System.Drawing.Size(100, 27)
        Me.txtCurrent2.TabIndex = 3
        '
        'txtCurrent3
        '
        Me.txtCurrent3.Location = New System.Drawing.Point(118, 149)
        Me.txtCurrent3.Name = "txtCurrent3"
        Me.txtCurrent3.Size = New System.Drawing.Size(100, 27)
        Me.txtCurrent3.TabIndex = 5
        '
        'lblNew1
        '
        Me.lblNew1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNew1.Location = New System.Drawing.Point(277, 72)
        Me.lblNew1.Name = "lblNew1"
        Me.lblNew1.Size = New System.Drawing.Size(100, 27)
        Me.lblNew1.TabIndex = 11
        Me.lblNew1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNew2
        '
        Me.lblNew2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNew2.Location = New System.Drawing.Point(277, 109)
        Me.lblNew2.Name = "lblNew2"
        Me.lblNew2.Size = New System.Drawing.Size(100, 27)
        Me.lblNew2.TabIndex = 12
        Me.lblNew2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNew3
        '
        Me.lblNew3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNew3.Location = New System.Drawing.Point(277, 149)
        Me.lblNew3.Name = "lblNew3"
        Me.lblNew3.Size = New System.Drawing.Size(100, 27)
        Me.lblNew3.TabIndex = 13
        Me.lblNew3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(203, 298)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(89, 34)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 34)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Location = New System.Drawing.Point(26, 197)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(361, 54)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 357)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblNew3)
        Me.Controls.Add(Me.lblNew2)
        Me.Controls.Add(Me.lblNew1)
        Me.Controls.Add(Me.txtCurrent3)
        Me.Controls.Add(Me.txtCurrent2)
        Me.Controls.Add(Me.txtCurrent1)
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
        Me.Text = "Turner Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCurrent1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent3 As System.Windows.Forms.TextBox
    Friend WithEvents lblNew1 As System.Windows.Forms.Label
    Friend WithEvents lblNew2 As System.Windows.Forms.Label
    Friend WithEvents lblNew3 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
