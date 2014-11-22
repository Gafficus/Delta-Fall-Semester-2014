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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstContinents = New System.Windows.Forms.ListBox()
        Me.btnAscending = New System.Windows.Forms.Button()
        Me.btnDescending = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Continent_Project.My.Resources.Resources.Continents
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lstContinents
        '
        Me.lstContinents.Enabled = False
        Me.lstContinents.FormattingEnabled = True
        Me.lstContinents.ItemHeight = 20
        Me.lstContinents.Location = New System.Drawing.Point(251, 12)
        Me.lstContinents.Name = "lstContinents"
        Me.lstContinents.Size = New System.Drawing.Size(131, 144)
        Me.lstContinents.TabIndex = 3
        '
        'btnAscending
        '
        Me.btnAscending.Location = New System.Drawing.Point(12, 172)
        Me.btnAscending.Name = "btnAscending"
        Me.btnAscending.Size = New System.Drawing.Size(157, 34)
        Me.btnAscending.TabIndex = 0
        Me.btnAscending.Text = "&Ascending Order"
        Me.btnAscending.UseVisualStyleBackColor = True
        '
        'btnDescending
        '
        Me.btnDescending.Location = New System.Drawing.Point(175, 172)
        Me.btnDescending.Name = "btnDescending"
        Me.btnDescending.Size = New System.Drawing.Size(157, 34)
        Me.btnDescending.TabIndex = 1
        Me.btnDescending.Text = "&Descending Order"
        Me.btnDescending.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 227)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDescending)
        Me.Controls.Add(Me.btnAscending)
        Me.Controls.Add(Me.lstContinents)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Continents"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstContinents As System.Windows.Forms.ListBox
    Friend WithEvents btnAscending As System.Windows.Forms.Button
    Friend WithEvents btnDescending As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
