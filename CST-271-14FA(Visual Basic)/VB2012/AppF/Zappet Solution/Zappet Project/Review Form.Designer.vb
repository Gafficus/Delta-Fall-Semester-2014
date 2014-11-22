<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReview
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBillZip = New System.Windows.Forms.Label()
        Me.lblBillState = New System.Windows.Forms.Label()
        Me.lblBillCity = New System.Windows.Forms.Label()
        Me.lblBillAddress = New System.Windows.Forms.Label()
        Me.lblBillName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblShipZip = New System.Windows.Forms.Label()
        Me.lblShipState = New System.Windows.Forms.Label()
        Me.lblShipCity = New System.Windows.Forms.Label()
        Me.lblShipAddress = New System.Windows.Forms.Label()
        Me.lblShipName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBillZip)
        Me.GroupBox1.Controls.Add(Me.lblBillState)
        Me.GroupBox1.Controls.Add(Me.lblBillCity)
        Me.GroupBox1.Controls.Add(Me.lblBillAddress)
        Me.GroupBox1.Controls.Add(Me.lblBillName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 231)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing information"
        '
        'lblBillZip
        '
        Me.lblBillZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillZip.Location = New System.Drawing.Point(182, 166)
        Me.lblBillZip.Name = "lblBillZip"
        Me.lblBillZip.Size = New System.Drawing.Size(104, 26)
        Me.lblBillZip.TabIndex = 9
        '
        'lblBillState
        '
        Me.lblBillState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillState.Location = New System.Drawing.Point(80, 167)
        Me.lblBillState.Name = "lblBillState"
        Me.lblBillState.Size = New System.Drawing.Size(50, 26)
        Me.lblBillState.TabIndex = 8
        '
        'lblBillCity
        '
        Me.lblBillCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillCity.Location = New System.Drawing.Point(80, 125)
        Me.lblBillCity.Name = "lblBillCity"
        Me.lblBillCity.Size = New System.Drawing.Size(206, 25)
        Me.lblBillCity.TabIndex = 7
        '
        'lblBillAddress
        '
        Me.lblBillAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillAddress.Location = New System.Drawing.Point(80, 83)
        Me.lblBillAddress.Name = "lblBillAddress"
        Me.lblBillAddress.Size = New System.Drawing.Size(206, 25)
        Me.lblBillAddress.TabIndex = 6
        '
        'lblBillName
        '
        Me.lblBillName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillName.Location = New System.Drawing.Point(80, 41)
        Me.lblBillName.Name = "lblBillName"
        Me.lblBillName.Size = New System.Drawing.Size(206, 25)
        Me.lblBillName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ZIP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblShipZip)
        Me.GroupBox2.Controls.Add(Me.lblShipState)
        Me.GroupBox2.Controls.Add(Me.lblShipCity)
        Me.GroupBox2.Controls.Add(Me.lblShipAddress)
        Me.GroupBox2.Controls.Add(Me.lblShipName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 231)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shipping information"
        '
        'lblShipZip
        '
        Me.lblShipZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipZip.Location = New System.Drawing.Point(182, 166)
        Me.lblShipZip.Name = "lblShipZip"
        Me.lblShipZip.Size = New System.Drawing.Size(104, 26)
        Me.lblShipZip.TabIndex = 9
        '
        'lblShipState
        '
        Me.lblShipState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipState.Location = New System.Drawing.Point(80, 167)
        Me.lblShipState.Name = "lblShipState"
        Me.lblShipState.Size = New System.Drawing.Size(50, 26)
        Me.lblShipState.TabIndex = 8
        '
        'lblShipCity
        '
        Me.lblShipCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipCity.Location = New System.Drawing.Point(80, 125)
        Me.lblShipCity.Name = "lblShipCity"
        Me.lblShipCity.Size = New System.Drawing.Size(206, 28)
        Me.lblShipCity.TabIndex = 7
        '
        'lblShipAddress
        '
        Me.lblShipAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipAddress.Location = New System.Drawing.Point(80, 83)
        Me.lblShipAddress.Name = "lblShipAddress"
        Me.lblShipAddress.Size = New System.Drawing.Size(206, 28)
        Me.lblShipAddress.TabIndex = 6
        '
        'lblShipName
        '
        Me.lblShipName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipName.Location = New System.Drawing.Point(80, 41)
        Me.lblShipName.Name = "lblShipName"
        Me.lblShipName.Size = New System.Drawing.Size(206, 28)
        Me.lblShipName.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(148, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "ZIP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(638, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 31)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 327)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmReview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zappet - Billing/Shipping Review"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBillZip As System.Windows.Forms.Label
    Friend WithEvents lblBillState As System.Windows.Forms.Label
    Friend WithEvents lblBillCity As System.Windows.Forms.Label
    Friend WithEvents lblBillAddress As System.Windows.Forms.Label
    Friend WithEvents lblBillName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblShipZip As System.Windows.Forms.Label
    Friend WithEvents lblShipState As System.Windows.Forms.Label
    Friend WithEvents lblShipCity As System.Windows.Forms.Label
    Friend WithEvents lblShipAddress As System.Windows.Forms.Label
    Friend WithEvents lblShipName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
