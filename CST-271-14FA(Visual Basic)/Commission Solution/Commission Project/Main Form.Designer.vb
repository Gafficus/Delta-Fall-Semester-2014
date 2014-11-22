<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.menFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommisionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Commission:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(136, 57)
        Me.lblCommission.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(74, 25)
        Me.lblCommission.TabIndex = 3
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(42, 57)
        Me.txtSales.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(74, 25)
        Me.txtSales.TabIndex = 1
        '
        'menFile
        '
        Me.menFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CalculateToolStripMenuItem})
        Me.menFile.Location = New System.Drawing.Point(0, 0)
        Me.menFile.Name = "menFile"
        Me.menFile.Size = New System.Drawing.Size(257, 24)
        Me.menFile.TabIndex = 4
        Me.menFile.Text = "File"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommisionToolStripMenuItem, Me.CommisionToolStripMenuItem1})
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CommisionToolStripMenuItem
        '
        Me.CommisionToolStripMenuItem.Name = "CommisionToolStripMenuItem"
        Me.CommisionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CommisionToolStripMenuItem.Text = "2% Commision"
        '
        'CommisionToolStripMenuItem1
        '
        Me.CommisionToolStripMenuItem1.Name = "CommisionToolStripMenuItem1"
        Me.CommisionToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.CommisionToolStripMenuItem1.Text = "5% Commision"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 119)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menFile)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.menFile
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commission Calculator"
        Me.menFile.ResumeLayout(False)
        Me.menFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents menFile As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommisionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
