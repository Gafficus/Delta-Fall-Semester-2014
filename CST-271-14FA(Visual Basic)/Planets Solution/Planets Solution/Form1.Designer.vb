<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblEarthWeight = New System.Windows.Forms.Label()
        Me.txtEarthWeight = New System.Windows.Forms.TextBox()
        Me.lblPlanetWeight = New System.Windows.Forms.Label()
        Me.cmbPlanetWeight = New System.Windows.Forms.ComboBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEarthWeight
        '
        Me.lblEarthWeight.AutoSize = True
        Me.lblEarthWeight.Location = New System.Drawing.Point(13, 41)
        Me.lblEarthWeight.Name = "lblEarthWeight"
        Me.lblEarthWeight.Size = New System.Drawing.Size(72, 13)
        Me.lblEarthWeight.TabIndex = 0
        Me.lblEarthWeight.Text = "&Earth Weight:"
        '
        'txtEarthWeight
        '
        Me.txtEarthWeight.Location = New System.Drawing.Point(16, 58)
        Me.txtEarthWeight.Name = "txtEarthWeight"
        Me.txtEarthWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtEarthWeight.TabIndex = 1
        '
        'lblPlanetWeight
        '
        Me.lblPlanetWeight.AutoSize = True
        Me.lblPlanetWeight.Location = New System.Drawing.Point(152, 41)
        Me.lblPlanetWeight.Name = "lblPlanetWeight"
        Me.lblPlanetWeight.Size = New System.Drawing.Size(61, 13)
        Me.lblPlanetWeight.TabIndex = 0
        Me.lblPlanetWeight.Text = "&Weight On:"
        '
        'cmbPlanetWeight
        '
        Me.cmbPlanetWeight.FormattingEnabled = True
        Me.cmbPlanetWeight.Location = New System.Drawing.Point(155, 58)
        Me.cmbPlanetWeight.Name = "cmbPlanetWeight"
        Me.cmbPlanetWeight.Size = New System.Drawing.Size(121, 21)
        Me.cmbPlanetWeight.TabIndex = 2
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeight.Location = New System.Drawing.Point(155, 98)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(110, 30)
        Me.lblWeight.TabIndex = 3
        '
        'lblExit
        '
        Me.lblExit.Location = New System.Drawing.Point(181, 227)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(75, 23)
        Me.lblExit.TabIndex = 4
        Me.lblExit.Text = "&Exit"
        Me.lblExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.cmbPlanetWeight)
        Me.Controls.Add(Me.txtEarthWeight)
        Me.Controls.Add(Me.lblPlanetWeight)
        Me.Controls.Add(Me.lblEarthWeight)
        Me.Name = "Form1"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEarthWeight As System.Windows.Forms.Label
    Friend WithEvents txtEarthWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblPlanetWeight As System.Windows.Forms.Label
    Friend WithEvents cmbPlanetWeight As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Button

End Class
