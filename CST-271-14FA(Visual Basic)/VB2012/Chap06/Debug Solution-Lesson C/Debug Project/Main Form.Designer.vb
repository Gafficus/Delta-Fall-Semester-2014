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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPositive = New System.Windows.Forms.Label()
        Me.lblNegative = New System.Windows.Forms.Label()
        Me.lblZero = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of positive integers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of negative integers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of zeros:"
        '
        'lblPositive
        '
        Me.lblPositive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPositive.Location = New System.Drawing.Point(31, 56)
        Me.lblPositive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPositive.Name = "lblPositive"
        Me.lblPositive.Size = New System.Drawing.Size(45, 34)
        Me.lblPositive.TabIndex = 3
        Me.lblPositive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNegative
        '
        Me.lblNegative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNegative.Location = New System.Drawing.Point(31, 135)
        Me.lblNegative.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNegative.Name = "lblNegative"
        Me.lblNegative.Size = New System.Drawing.Size(45, 34)
        Me.lblNegative.TabIndex = 5
        Me.lblNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblZero
        '
        Me.lblZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZero.Location = New System.Drawing.Point(31, 215)
        Me.lblZero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZero.Name = "lblZero"
        Me.lblZero.Size = New System.Drawing.Size(45, 34)
        Me.lblZero.TabIndex = 7
        Me.lblZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(185, 185)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(116, 29)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "&Enter Integers"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 220)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 29)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 283)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblZero)
        Me.Controls.Add(Me.lblNegative)
        Me.Controls.Add(Me.lblPositive)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Swat The Bugs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPositive As System.Windows.Forms.Label
    Friend WithEvents lblNegative As System.Windows.Forms.Label
    Friend WithEvents lblZero As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
