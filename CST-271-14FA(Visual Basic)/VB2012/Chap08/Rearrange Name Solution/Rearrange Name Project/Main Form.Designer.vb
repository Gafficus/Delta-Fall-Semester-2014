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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRearrangedName = New System.Windows.Forms.Label()
        Me.btnRearrange = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name (first, space, last):"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(29, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 25)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rearranged name (last, comma, space, first):"
        '
        'lblRearrangedName
        '
        Me.lblRearrangedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRearrangedName.Location = New System.Drawing.Point(29, 117)
        Me.lblRearrangedName.Name = "lblRearrangedName"
        Me.lblRearrangedName.Size = New System.Drawing.Size(268, 34)
        Me.lblRearrangedName.TabIndex = 5
        Me.lblRearrangedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRearrange
        '
        Me.btnRearrange.Location = New System.Drawing.Point(29, 169)
        Me.btnRearrange.Name = "btnRearrange"
        Me.btnRearrange.Size = New System.Drawing.Size(148, 34)
        Me.btnRearrange.TabIndex = 2
        Me.btnRearrange.Text = "&Rearrange Name"
        Me.btnRearrange.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 169)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 235)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRearrange)
        Me.Controls.Add(Me.lblRearrangedName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rearrange Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRearrangedName As System.Windows.Forms.Label
    Friend WithEvents btnRearrange As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
