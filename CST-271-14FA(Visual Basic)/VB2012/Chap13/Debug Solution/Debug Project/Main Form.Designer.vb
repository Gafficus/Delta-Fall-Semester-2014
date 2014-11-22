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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.btnFill = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.FriendsDataSet = New Debug_Project.FriendsDataSet()
        Me.TblFriendsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFriendsTableAdapter = New Debug_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter()
        Me.TableAdapterManager = New Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 26)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 17)
        Label1.TabIndex = 40
        Label1.Text = "Number:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(24, 62)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 17)
        Label2.TabIndex = 42
        Label2.Text = "Last:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 93)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 17)
        Label3.TabIndex = 44
        Label3.Text = "First:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(24, 124)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 17)
        Label4.TabIndex = 46
        Label4.Text = "Address:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(24, 155)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(32, 17)
        Label5.TabIndex = 48
        Label5.Text = "City:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(24, 184)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(40, 17)
        Label6.TabIndex = 50
        Label6.Text = "State:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(172, 185)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 17)
        Label7.TabIndex = 52
        Label7.Text = "ZIP:"
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(323, 22)
        Me.btnFill.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(111, 29)
        Me.btnFill.TabIndex = 36
        Me.btnFill.Text = "&Fill"
        '
        'lblNumber
        '
        Me.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Number", True))
        Me.lblNumber.Location = New System.Drawing.Point(88, 26)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(70, 20)
        Me.lblNumber.TabIndex = 41
        '
        'lblLast
        '
        Me.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Last", True))
        Me.lblLast.Location = New System.Drawing.Point(88, 63)
        Me.lblLast.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(199, 20)
        Me.lblLast.TabIndex = 43
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "First", True))
        Me.lblFirst.Location = New System.Drawing.Point(88, 94)
        Me.lblFirst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(199, 20)
        Me.lblFirst.TabIndex = 45
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Address", True))
        Me.lblAddress.Location = New System.Drawing.Point(88, 125)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(199, 20)
        Me.lblAddress.TabIndex = 47
        '
        'lblCity
        '
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "City", True))
        Me.lblCity.Location = New System.Drawing.Point(88, 155)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(199, 20)
        Me.lblCity.TabIndex = 49
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "State", True))
        Me.lblState.Location = New System.Drawing.Point(88, 183)
        Me.lblState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(49, 20)
        Me.lblState.TabIndex = 51
        '
        'lblZip
        '
        Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "ZIP", True))
        Me.lblZip.Location = New System.Drawing.Point(204, 184)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(83, 20)
        Me.lblZip.TabIndex = 53
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 115)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 29)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "E&xit"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(323, 84)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(111, 29)
        Me.btnNext.TabIndex = 38
        Me.btnNext.Text = "&Next"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(323, 53)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(111, 29)
        Me.btnPrevious.TabIndex = 37
        Me.btnPrevious.Text = "&Previous"
        '
        'FriendsDataSet
        '
        Me.FriendsDataSet.DataSetName = "FriendsDataSet"
        Me.FriendsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFriendsBindingSource
        '
        Me.TblFriendsBindingSource.DataMember = "tblFriends"
        Me.TblFriendsBindingSource.DataSource = Me.FriendsDataSet
        '
        'TblFriendsTableAdapter
        '
        Me.TblFriendsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblFriendsTableAdapter = Me.TblFriendsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 240)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Swat the Bugs"
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents FriendsDataSet As Debug_Project.FriendsDataSet
    Friend WithEvents TblFriendsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFriendsTableAdapter As Debug_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter
    Friend WithEvents TableAdapterManager As Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager

End Class
