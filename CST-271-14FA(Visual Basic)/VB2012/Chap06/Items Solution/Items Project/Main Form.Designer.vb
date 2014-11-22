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
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveAt = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Names:"
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 20
        Me.lstNames.Location = New System.Drawing.Point(85, 71)
        Me.lstNames.Margin = New System.Windows.Forms.Padding(2)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(190, 184)
        Me.lstNames.TabIndex = 1
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(310, 66)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(130, 38)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "&Insert"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(310, 109)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(130, 38)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "&Remove"
        '
        'btnRemoveAt
        '
        Me.btnRemoveAt.Location = New System.Drawing.Point(310, 154)
        Me.btnRemoveAt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveAt.Name = "btnRemoveAt"
        Me.btnRemoveAt.Size = New System.Drawing.Size(130, 38)
        Me.btnRemoveAt.TabIndex = 4
        Me.btnRemoveAt.Text = "Remove &At"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(310, 199)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 38)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 288)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(310, 244)
        Me.btnCount.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(130, 38)
        Me.btnCount.TabIndex = 6
        Me.btnCount.Text = "&Count"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 372)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemoveAt)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Methods and Property of the Items Collection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAt As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCount As System.Windows.Forms.Button

End Class
