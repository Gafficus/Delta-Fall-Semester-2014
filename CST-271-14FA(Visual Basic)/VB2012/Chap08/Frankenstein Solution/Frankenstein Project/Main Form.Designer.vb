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
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picHeadTorso = New System.Windows.Forms.PictureBox()
        Me.picHeadTorsoOneArm = New System.Windows.Forms.PictureBox()
        Me.picHeadTorsoTwoArms = New System.Windows.Forms.PictureBox()
        Me.picHeadTorsoArmsOneLeg = New System.Windows.Forms.PictureBox()
        Me.picFullBody = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeadTorso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeadTorsoOneArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeadTorsoTwoArms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeadTorsoArmsOneLeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFullBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHead
        '
        Me.picHead.Image = Global.Frankenstein_Project.My.Resources.Resources.Head
        Me.picHead.Location = New System.Drawing.Point(12, 132)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(230, 290)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHead.TabIndex = 0
        Me.picHead.TabStop = False
        '
        'picHeadTorso
        '
        Me.picHeadTorso.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorso
        Me.picHeadTorso.Location = New System.Drawing.Point(12, 279)
        Me.picHeadTorso.Name = "picHeadTorso"
        Me.picHeadTorso.Size = New System.Drawing.Size(230, 290)
        Me.picHeadTorso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeadTorso.TabIndex = 1
        Me.picHeadTorso.TabStop = False
        '
        'picHeadTorsoOneArm
        '
        Me.picHeadTorsoOneArm.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorsoOneArm
        Me.picHeadTorsoOneArm.Location = New System.Drawing.Point(248, 279)
        Me.picHeadTorsoOneArm.Name = "picHeadTorsoOneArm"
        Me.picHeadTorsoOneArm.Size = New System.Drawing.Size(230, 290)
        Me.picHeadTorsoOneArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeadTorsoOneArm.TabIndex = 2
        Me.picHeadTorsoOneArm.TabStop = False
        '
        'picHeadTorsoTwoArms
        '
        Me.picHeadTorsoTwoArms.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorsoTwoArms
        Me.picHeadTorsoTwoArms.Location = New System.Drawing.Point(433, 279)
        Me.picHeadTorsoTwoArms.Name = "picHeadTorsoTwoArms"
        Me.picHeadTorsoTwoArms.Size = New System.Drawing.Size(230, 290)
        Me.picHeadTorsoTwoArms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeadTorsoTwoArms.TabIndex = 3
        Me.picHeadTorsoTwoArms.TabStop = False
        '
        'picHeadTorsoArmsOneLeg
        '
        Me.picHeadTorsoArmsOneLeg.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorsoArmsOneLeg
        Me.picHeadTorsoArmsOneLeg.Location = New System.Drawing.Point(639, 279)
        Me.picHeadTorsoArmsOneLeg.Name = "picHeadTorsoArmsOneLeg"
        Me.picHeadTorsoArmsOneLeg.Size = New System.Drawing.Size(230, 290)
        Me.picHeadTorsoArmsOneLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeadTorsoArmsOneLeg.TabIndex = 4
        Me.picHeadTorsoArmsOneLeg.TabStop = False
        '
        'picFullBody
        '
        Me.picFullBody.Image = Global.Frankenstein_Project.My.Resources.Resources.FullBody
        Me.picFullBody.Location = New System.Drawing.Point(839, 279)
        Me.picFullBody.Name = "picFullBody"
        Me.picFullBody.Size = New System.Drawing.Size(230, 290)
        Me.picFullBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFullBody.TabIndex = 5
        Me.picFullBody.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Secret word:"
        '
        'lblWord
        '
        Me.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWord.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(254, 71)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(160, 34)
        Me.lblWord.TabIndex = 7
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncorrect
        '
        Me.lblIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncorrect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(456, 71)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(207, 34)
        Me.lblIncorrect.TabIndex = 9
        Me.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Incorrect letters:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Enter a letter:"
        '
        'txtLetter
        '
        Me.txtLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLetter.Location = New System.Drawing.Point(346, 149)
        Me.txtLetter.MaxLength = 1
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(32, 25)
        Me.txtLetter.TabIndex = 11
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(385, 146)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(89, 28)
        Me.btnCheck.TabIndex = 12
        Me.btnCheck.Text = "&Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 571)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtLetter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picFullBody)
        Me.Controls.Add(Me.picHeadTorsoArmsOneLeg)
        Me.Controls.Add(Me.picHeadTorsoTwoArms)
        Me.Controls.Add(Me.picHeadTorsoOneArm)
        Me.Controls.Add(Me.picHeadTorso)
        Me.Controls.Add(Me.picHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frankenstein Game"
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeadTorso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeadTorsoOneArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeadTorsoTwoArms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeadTorsoArmsOneLeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFullBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picHead As System.Windows.Forms.PictureBox
    Friend WithEvents picHeadTorso As System.Windows.Forms.PictureBox
    Friend WithEvents picHeadTorsoOneArm As System.Windows.Forms.PictureBox
    Friend WithEvents picHeadTorsoTwoArms As System.Windows.Forms.PictureBox
    Friend WithEvents picHeadTorsoArmsOneLeg As System.Windows.Forms.PictureBox
    Friend WithEvents picFullBody As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLetter As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button

End Class
