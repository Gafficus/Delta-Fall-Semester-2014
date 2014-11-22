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
        Me.txtGuests = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTable10 = New System.Windows.Forms.Label()
        Me.lblTable5 = New System.Windows.Forms.Label()
        Me.lblRemain = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of &guests:"
        '
        'txtGuests
        '
        Me.txtGuests.Location = New System.Drawing.Point(154, 27)
        Me.txtGuests.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGuests.Name = "txtGuests"
        Me.txtGuests.Size = New System.Drawing.Size(57, 27)
        Me.txtGuests.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tables for 10:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tables for 5:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Guests remaining:"
        '
        'lblTable10
        '
        Me.lblTable10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTable10.Location = New System.Drawing.Point(18, 121)
        Me.lblTable10.Name = "lblTable10"
        Me.lblTable10.Size = New System.Drawing.Size(58, 36)
        Me.lblTable10.TabIndex = 7
        Me.lblTable10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTable5
        '
        Me.lblTable5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTable5.Location = New System.Drawing.Point(146, 121)
        Me.lblTable5.Name = "lblTable5"
        Me.lblTable5.Size = New System.Drawing.Size(58, 36)
        Me.lblTable5.TabIndex = 8
        Me.lblTable5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemain
        '
        Me.lblRemain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemain.Location = New System.Drawing.Point(264, 121)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(58, 36)
        Me.lblRemain.TabIndex = 9
        Me.lblRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(237, 18)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(86, 38)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(329, 18)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 194)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblRemain)
        Me.Controls.Add(Me.lblTable5)
        Me.Controls.Add(Me.lblTable10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGuests)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Framington Parties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGuests As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTable10 As System.Windows.Forms.Label
    Friend WithEvents lblTable5 As System.Windows.Forms.Label
    Friend WithEvents lblRemain As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
