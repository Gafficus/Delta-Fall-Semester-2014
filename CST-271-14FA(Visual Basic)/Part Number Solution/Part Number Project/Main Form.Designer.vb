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
        Me.txtPartNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDelivery = New System.Windows.Forms.ListBox()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Part number:"
        '
        'txtPartNum
        '
        Me.txtPartNum.Location = New System.Drawing.Point(32, 54)
        Me.txtPartNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPartNum.Name = "txtPartNum"
        Me.txtPartNum.Size = New System.Drawing.Size(125, 25)
        Me.txtPartNum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Delivery method:"
        '
        'lstDelivery
        '
        Me.lstDelivery.FormattingEnabled = True
        Me.lstDelivery.ItemHeight = 17
        Me.lstDelivery.Location = New System.Drawing.Point(32, 124)
        Me.lstDelivery.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDelivery.Name = "lstDelivery"
        Me.lstDelivery.Size = New System.Drawing.Size(125, 89)
        Me.lstDelivery.TabIndex = 5
        '
        'btnDelivery
        '
        Me.btnDelivery.Location = New System.Drawing.Point(186, 34)
        Me.btnDelivery.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(100, 34)
        Me.btnDelivery.TabIndex = 2
        Me.btnDelivery.Text = "&Select Delivery"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 72)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDelivery
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 244)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelivery)
        Me.Controls.Add(Me.lstDelivery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPartNum)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Part Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPartNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstDelivery As System.Windows.Forms.ListBox
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
