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
        Me.txtLetters = New System.Windows.Forms.TextBox()
        Me.lblLettersWithSpaces = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter 5 letters:"
        '
        'txtLetters
        '
        Me.txtLetters.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLetters.Location = New System.Drawing.Point(34, 49)
        Me.txtLetters.MaxLength = 5
        Me.txtLetters.Name = "txtLetters"
        Me.txtLetters.Size = New System.Drawing.Size(77, 25)
        Me.txtLetters.TabIndex = 1
        '
        'lblLettersWithSpaces
        '
        Me.lblLettersWithSpaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLettersWithSpaces.Location = New System.Drawing.Point(34, 92)
        Me.lblLettersWithSpaces.Name = "lblLettersWithSpaces"
        Me.lblLettersWithSpaces.Size = New System.Drawing.Size(124, 33)
        Me.lblLettersWithSpaces.TabIndex = 4
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(139, 46)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(108, 28)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "&Insert Spaces"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(253, 46)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 154)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lblLettersWithSpaces)
        Me.Controls.Add(Me.txtLetters)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debugging Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLetters As System.Windows.Forms.TextBox
    Friend WithEvents lblLettersWithSpaces As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
