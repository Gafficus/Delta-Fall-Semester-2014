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
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstNew = New System.Windows.Forms.ListBox()
        Me.btnOriginal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(134, 80)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 27)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'btnIncrease
        '
        Me.btnIncrease.Location = New System.Drawing.Point(134, 18)
        Me.btnIncrease.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(115, 27)
        Me.btnIncrease.TabIndex = 0
        Me.btnIncrease.Text = "&Increase Prices"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&New prices:"
        '
        'lstNew
        '
        Me.lstNew.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNew.FormattingEnabled = True
        Me.lstNew.ItemHeight = 16
        Me.lstNew.Location = New System.Drawing.Point(25, 39)
        Me.lstNew.Margin = New System.Windows.Forms.Padding(2)
        Me.lstNew.Name = "lstNew"
        Me.lstNew.Size = New System.Drawing.Size(61, 164)
        Me.lstNew.TabIndex = 4
        '
        'btnOriginal
        '
        Me.btnOriginal.Location = New System.Drawing.Point(134, 49)
        Me.btnOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOriginal.Name = "btnOriginal"
        Me.btnOriginal.Size = New System.Drawing.Size(115, 27)
        Me.btnOriginal.TabIndex = 1
        Me.btnOriginal.Text = "&Original Prices"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 225)
        Me.Controls.Add(Me.btnOriginal)
        Me.Controls.Add(Me.lstNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnIncrease)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABC Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnIncrease As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstNew As System.Windows.Forms.ListBox
    Friend WithEvents btnOriginal As System.Windows.Forms.Button

End Class
