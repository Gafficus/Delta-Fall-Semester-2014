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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblSalespeople = New System.Windows.Forms.Label()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Car_Emporium_Project.My.Resources.Resources.Car
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Highest commission paid:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Salespeople paid highest commission:"
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighest.Location = New System.Drawing.Point(369, 28)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(121, 24)
        Me.lblHighest.TabIndex = 4
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalespeople
        '
        Me.lblSalespeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalespeople.Location = New System.Drawing.Point(451, 67)
        Me.lblSalespeople.Name = "lblSalespeople"
        Me.lblSalespeople.Size = New System.Drawing.Size(39, 24)
        Me.lblSalespeople.TabIndex = 5
        Me.lblSalespeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(242, 111)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(121, 32)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "&Get Highest"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(369, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 32)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 167)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.lblSalespeople)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Emporium"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblSalespeople As System.Windows.Forms.Label
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
