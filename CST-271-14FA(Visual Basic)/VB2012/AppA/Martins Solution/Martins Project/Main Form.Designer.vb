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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGainLoss = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtShares = New System.Windows.Forms.TextBox()
        Me.txtOpening = New System.Windows.Forms.TextBox()
        Me.txtClosing = New System.Windows.Forms.TextBox()
        Me.btnGainLoss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock &name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Shares:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Opening price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Closing price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gain (Loss):"
        '
        'lblGainLoss
        '
        Me.lblGainLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGainLoss.Location = New System.Drawing.Point(29, 160)
        Me.lblGainLoss.Name = "lblGainLoss"
        Me.lblGainLoss.Size = New System.Drawing.Size(100, 30)
        Me.lblGainLoss.TabIndex = 11
        Me.lblGainLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(84, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(87, 25)
        Me.txtName.TabIndex = 1
        '
        'txtShares
        '
        Me.txtShares.Location = New System.Drawing.Point(222, 39)
        Me.txtShares.Name = "txtShares"
        Me.txtShares.Size = New System.Drawing.Size(87, 25)
        Me.txtShares.TabIndex = 3
        '
        'txtOpening
        '
        Me.txtOpening.Location = New System.Drawing.Point(84, 100)
        Me.txtOpening.Name = "txtOpening"
        Me.txtOpening.Size = New System.Drawing.Size(87, 25)
        Me.txtOpening.TabIndex = 5
        '
        'txtClosing
        '
        Me.txtClosing.Location = New System.Drawing.Point(218, 100)
        Me.txtClosing.Name = "txtClosing"
        Me.txtClosing.Size = New System.Drawing.Size(87, 25)
        Me.txtClosing.TabIndex = 7
        '
        'btnGainLoss
        '
        Me.btnGainLoss.Location = New System.Drawing.Point(145, 152)
        Me.btnGainLoss.Name = "btnGainLoss"
        Me.btnGainLoss.Size = New System.Drawing.Size(157, 41)
        Me.btnGainLoss.TabIndex = 8
        Me.btnGainLoss.Text = "Calculate &Gain/(Loss)"
        Me.btnGainLoss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(308, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 224)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGainLoss)
        Me.Controls.Add(Me.txtClosing)
        Me.Controls.Add(Me.txtOpening)
        Me.Controls.Add(Me.txtShares)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblGainLoss)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Martins Gain/Loss Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblGainLoss As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtShares As System.Windows.Forms.TextBox
    Friend WithEvents txtOpening As System.Windows.Forms.TextBox
    Friend WithEvents txtClosing As System.Windows.Forms.TextBox
    Friend WithEvents btnGainLoss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
