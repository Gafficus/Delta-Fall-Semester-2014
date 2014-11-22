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
        Me.lblSales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnComm5 = New System.Windows.Forms.Button()
        Me.btnComm10 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sales:"
        '
        'lblSales
        '
        Me.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSales.Location = New System.Drawing.Point(36, 64)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(93, 32)
        Me.lblSales.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Commission:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(36, 156)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(93, 32)
        Me.lblCommission.TabIndex = 7
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(202, 37)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(147, 34)
        Me.btnSales.TabIndex = 0
        Me.btnSales.Text = "&Display Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnComm5
        '
        Me.btnComm5.Location = New System.Drawing.Point(202, 77)
        Me.btnComm5.Name = "btnComm5"
        Me.btnComm5.Size = New System.Drawing.Size(147, 34)
        Me.btnComm5.TabIndex = 1
        Me.btnComm5.Text = "&5% Commission"
        Me.btnComm5.UseVisualStyleBackColor = True
        '
        'btnComm10
        '
        Me.btnComm10.Location = New System.Drawing.Point(202, 117)
        Me.btnComm10.Name = "btnComm10"
        Me.btnComm10.Size = New System.Drawing.Size(147, 34)
        Me.btnComm10.TabIndex = 2
        Me.btnComm10.Text = "&10% Commission"
        Me.btnComm10.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(202, 157)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 226)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnComm10)
        Me.Controls.Add(Me.btnComm5)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scope Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnComm5 As System.Windows.Forms.Button
    Friend WithEvents btnComm10 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
