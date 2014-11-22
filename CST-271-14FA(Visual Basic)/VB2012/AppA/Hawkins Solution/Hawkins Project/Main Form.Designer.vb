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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtSpent = New System.Windows.Forms.TextBox()
        Me.txtEarned = New System.Windows.Forms.TextBox()
        Me.txtBegin = New System.Windows.Forms.TextBox()
        Me.lblEnding = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 222)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 34)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(186, 183)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(103, 34)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        '
        'txtSpent
        '
        Me.txtSpent.Location = New System.Drawing.Point(33, 158)
        Me.txtSpent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSpent.Name = "txtSpent"
        Me.txtSpent.Size = New System.Drawing.Size(131, 25)
        Me.txtSpent.TabIndex = 5
        '
        'txtEarned
        '
        Me.txtEarned.Location = New System.Drawing.Point(33, 96)
        Me.txtEarned.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEarned.Name = "txtEarned"
        Me.txtEarned.Size = New System.Drawing.Size(131, 25)
        Me.txtEarned.TabIndex = 3
        '
        'txtBegin
        '
        Me.txtBegin.Location = New System.Drawing.Point(33, 39)
        Me.txtBegin.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBegin.Name = "txtBegin"
        Me.txtBegin.Size = New System.Drawing.Size(131, 25)
        Me.txtBegin.TabIndex = 1
        '
        'lblEnding
        '
        Me.lblEnding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnding.Location = New System.Drawing.Point(33, 222)
        Me.lblEnding.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnding.Name = "lblEnding"
        Me.lblEnding.Size = New System.Drawing.Size(131, 30)
        Me.lblEnding.TabIndex = 9
        Me.lblEnding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ending balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Money &spent:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Money &earned:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Beginning balance:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 280)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtSpent)
        Me.Controls.Add(Me.txtEarned)
        Me.Controls.Add(Me.txtBegin)
        Me.Controls.Add(Me.lblEnding)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ending Balance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtSpent As System.Windows.Forms.TextBox
    Friend WithEvents txtEarned As System.Windows.Forms.TextBox
    Friend WithEvents txtBegin As System.Windows.Forms.TextBox
    Friend WithEvents lblEnding As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
