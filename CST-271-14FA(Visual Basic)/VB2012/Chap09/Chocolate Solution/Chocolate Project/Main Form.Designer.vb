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
        Me.lstPounds = New System.Windows.Forms.ListBox()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnForEachNext = New System.Windows.Forms.Button()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.btnAscending = New System.Windows.Forms.Button()
        Me.btnDescending = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstPounds
        '
        Me.lstPounds.FormattingEnabled = True
        Me.lstPounds.ItemHeight = 17
        Me.lstPounds.Location = New System.Drawing.Point(23, 58)
        Me.lstPounds.Name = "lstPounds"
        Me.lstPounds.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstPounds.Size = New System.Drawing.Size(46, 123)
        Me.lstPounds.TabIndex = 7
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(160, 46)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(119, 27)
        Me.btnForNext.TabIndex = 0
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnForEachNext
        '
        Me.btnForEachNext.Location = New System.Drawing.Point(160, 76)
        Me.btnForEachNext.Name = "btnForEachNext"
        Me.btnForEachNext.Size = New System.Drawing.Size(119, 27)
        Me.btnForEachNext.TabIndex = 1
        Me.btnForEachNext.Text = "For &Each...Next"
        Me.btnForEachNext.UseVisualStyleBackColor = True
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(160, 106)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(119, 27)
        Me.btnDoLoop.TabIndex = 2
        Me.btnDoLoop.Text = "&Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'btnAscending
        '
        Me.btnAscending.Location = New System.Drawing.Point(160, 136)
        Me.btnAscending.Name = "btnAscending"
        Me.btnAscending.Size = New System.Drawing.Size(119, 27)
        Me.btnAscending.TabIndex = 3
        Me.btnAscending.Text = "&Ascending Sort"
        Me.btnAscending.UseVisualStyleBackColor = True
        '
        'btnDescending
        '
        Me.btnDescending.Location = New System.Drawing.Point(160, 166)
        Me.btnDescending.Name = "btnDescending"
        Me.btnDescending.Size = New System.Drawing.Size(119, 27)
        Me.btnDescending.TabIndex = 4
        Me.btnDescending.Text = "De&scending Sort"
        Me.btnDescending.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(160, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 27)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pounds:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDescending)
        Me.Controls.Add(Me.btnAscending)
        Me.Controls.Add(Me.btnDoLoop)
        Me.Controls.Add(Me.btnForEachNext)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.lstPounds)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chocolate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPounds As System.Windows.Forms.ListBox
    Friend WithEvents btnForNext As System.Windows.Forms.Button
    Friend WithEvents btnForEachNext As System.Windows.Forms.Button
    Friend WithEvents btnDoLoop As System.Windows.Forms.Button
    Friend WithEvents btnAscending As System.Windows.Forms.Button
    Friend WithEvents btnDescending As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
