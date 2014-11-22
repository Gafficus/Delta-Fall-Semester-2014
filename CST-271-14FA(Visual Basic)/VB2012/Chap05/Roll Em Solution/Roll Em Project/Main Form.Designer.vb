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
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.picSixDots = New System.Windows.Forms.PictureBox()
        Me.picFiveDots = New System.Windows.Forms.PictureBox()
        Me.picFourDots = New System.Windows.Forms.PictureBox()
        Me.picThreeDots = New System.Windows.Forms.PictureBox()
        Me.picTwoDots = New System.Windows.Forms.PictureBox()
        Me.picOneDot = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSixDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFiveDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFourDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThreeDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwoDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOneDot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDie2
        '
        Me.picDie2.Location = New System.Drawing.Point(158, 41)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(61, 61)
        Me.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDie2.TabIndex = 7
        Me.picDie2.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.Location = New System.Drawing.Point(67, 41)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(61, 61)
        Me.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDie1.TabIndex = 6
        Me.picDie1.TabStop = False
        '
        'picSixDots
        '
        Me.picSixDots.Image = Global.Roll_Em_Project.My.Resources.Resources.Six
        Me.picSixDots.Location = New System.Drawing.Point(182, 234)
        Me.picSixDots.Name = "picSixDots"
        Me.picSixDots.Size = New System.Drawing.Size(61, 61)
        Me.picSixDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSixDots.TabIndex = 5
        Me.picSixDots.TabStop = False
        '
        'picFiveDots
        '
        Me.picFiveDots.Image = Global.Roll_Em_Project.My.Resources.Resources.Five
        Me.picFiveDots.Location = New System.Drawing.Point(115, 234)
        Me.picFiveDots.Name = "picFiveDots"
        Me.picFiveDots.Size = New System.Drawing.Size(61, 61)
        Me.picFiveDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFiveDots.TabIndex = 4
        Me.picFiveDots.TabStop = False
        '
        'picFourDots
        '
        Me.picFourDots.Image = Global.Roll_Em_Project.My.Resources.Resources.Four
        Me.picFourDots.Location = New System.Drawing.Point(48, 234)
        Me.picFourDots.Name = "picFourDots"
        Me.picFourDots.Size = New System.Drawing.Size(61, 61)
        Me.picFourDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFourDots.TabIndex = 3
        Me.picFourDots.TabStop = False
        '
        'picThreeDots
        '
        Me.picThreeDots.Image = Global.Roll_Em_Project.My.Resources.Resources.Three
        Me.picThreeDots.Location = New System.Drawing.Point(182, 167)
        Me.picThreeDots.Name = "picThreeDots"
        Me.picThreeDots.Size = New System.Drawing.Size(61, 61)
        Me.picThreeDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThreeDots.TabIndex = 2
        Me.picThreeDots.TabStop = False
        '
        'picTwoDots
        '
        Me.picTwoDots.Image = Global.Roll_Em_Project.My.Resources.Resources.Two
        Me.picTwoDots.Location = New System.Drawing.Point(115, 167)
        Me.picTwoDots.Name = "picTwoDots"
        Me.picTwoDots.Size = New System.Drawing.Size(61, 61)
        Me.picTwoDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTwoDots.TabIndex = 1
        Me.picTwoDots.TabStop = False
        '
        'picOneDot
        '
        Me.picOneDot.Image = Global.Roll_Em_Project.My.Resources.Resources.One
        Me.picOneDot.Location = New System.Drawing.Point(48, 167)
        Me.picOneDot.Name = "picOneDot"
        Me.picOneDot.Size = New System.Drawing.Size(61, 61)
        Me.picOneDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOneDot.TabIndex = 0
        Me.picOneDot.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(52, 119)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(106, 30)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "&Roll the Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(164, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 30)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(260, 41)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 61)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 316)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.picSixDots)
        Me.Controls.Add(Me.picFiveDots)
        Me.Controls.Add(Me.picFourDots)
        Me.Controls.Add(Me.picThreeDots)
        Me.Controls.Add(Me.picTwoDots)
        Me.Controls.Add(Me.picOneDot)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll 'Em Game"
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSixDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFiveDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFourDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThreeDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwoDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOneDot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picOneDot As System.Windows.Forms.PictureBox
    Friend WithEvents picTwoDots As System.Windows.Forms.PictureBox
    Friend WithEvents picThreeDots As System.Windows.Forms.PictureBox
    Friend WithEvents picFourDots As System.Windows.Forms.PictureBox
    Friend WithEvents picFiveDots As System.Windows.Forms.PictureBox
    Friend WithEvents picSixDots As System.Windows.Forms.PictureBox
    Friend WithEvents picDie1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
