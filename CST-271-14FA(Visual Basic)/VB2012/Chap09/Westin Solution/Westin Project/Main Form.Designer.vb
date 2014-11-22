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
        Me.lstForEachParts = New System.Windows.Forms.ListBox()
        Me.lstForParts = New System.Windows.Forms.ListBox()
        Me.btnForEach = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstForEachParts
        '
        Me.lstForEachParts.FormattingEnabled = True
        Me.lstForEachParts.ItemHeight = 17
        Me.lstForEachParts.Location = New System.Drawing.Point(30, 39)
        Me.lstForEachParts.Name = "lstForEachParts"
        Me.lstForEachParts.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstForEachParts.Size = New System.Drawing.Size(59, 208)
        Me.lstForEachParts.TabIndex = 3
        '
        'lstForParts
        '
        Me.lstForParts.FormattingEnabled = True
        Me.lstForParts.ItemHeight = 17
        Me.lstForParts.Location = New System.Drawing.Point(133, 39)
        Me.lstForParts.Name = "lstForParts"
        Me.lstForParts.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstForParts.Size = New System.Drawing.Size(59, 208)
        Me.lstForParts.TabIndex = 4
        '
        'btnForEach
        '
        Me.btnForEach.Location = New System.Drawing.Point(243, 39)
        Me.btnForEach.Name = "btnForEach"
        Me.btnForEach.Size = New System.Drawing.Size(90, 30)
        Me.btnForEach.TabIndex = 0
        Me.btnForEach.Text = "For &Each"
        Me.btnForEach.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(243, 80)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(90, 30)
        Me.btnFor.TabIndex = 1
        Me.btnFor.Text = "&For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(243, 121)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 280)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.btnForEach)
        Me.Controls.Add(Me.lstForParts)
        Me.Controls.Add(Me.lstForEachParts)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Westin Parts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstForEachParts As System.Windows.Forms.ListBox
    Friend WithEvents lstForParts As System.Windows.Forms.ListBox
    Friend WithEvents btnForEach As System.Windows.Forms.Button
    Friend WithEvents btnFor As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
