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
        Me.MusicBoxDataSet = New MusicBox_Project.MusicBoxDataSet()
        Me.TblBoxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBoxTableAdapter = New MusicBox_Project.MusicBoxDataSetTableAdapters.tblBoxTableAdapter()
        Me.TableAdapterManager = New MusicBox_Project.MusicBoxDataSetTableAdapters.TableAdapterManager()
        Me.TblBoxDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnShape = New System.Windows.Forms.Button()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.radGift = New System.Windows.Forms.RadioButton()
        Me.radPurchased = New System.Windows.Forms.RadioButton()
        Me.radOctagon = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radRound = New System.Windows.Forms.RadioButton()
        Me.radRectangle = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        CType(Me.MusicBoxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBoxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBoxDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MusicBoxDataSet
        '
        Me.MusicBoxDataSet.DataSetName = "MusicBoxDataSet"
        Me.MusicBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBoxBindingSource
        '
        Me.TblBoxBindingSource.DataMember = "tblBox"
        Me.TblBoxBindingSource.DataSource = Me.MusicBoxDataSet
        '
        'TblBoxTableAdapter
        '
        Me.TblBoxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBoxTableAdapter = Me.TblBoxTableAdapter
        Me.TableAdapterManager.UpdateOrder = MusicBox_Project.MusicBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBoxDataGridView
        '
        Me.TblBoxDataGridView.AllowUserToAddRows = False
        Me.TblBoxDataGridView.AllowUserToDeleteRows = False
        Me.TblBoxDataGridView.AutoGenerateColumns = False
        Me.TblBoxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblBoxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblBoxDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblBoxDataGridView.DataSource = Me.TblBoxBindingSource
        Me.TblBoxDataGridView.Location = New System.Drawing.Point(22, 15)
        Me.TblBoxDataGridView.Name = "TblBoxDataGridView"
        Me.TblBoxDataGridView.ReadOnly = True
        Me.TblBoxDataGridView.RowHeadersVisible = False
        Me.TblBoxDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblBoxDataGridView.Size = New System.Drawing.Size(563, 271)
        Me.TblBoxDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Shape"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Shape"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Source"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Source"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Song"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Song"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(614, 23)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(111, 30)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "&All Records"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnShape
        '
        Me.btnShape.Location = New System.Drawing.Point(15, 105)
        Me.btnShape.Name = "btnShape"
        Me.btnShape.Size = New System.Drawing.Size(111, 30)
        Me.btnShape.TabIndex = 3
        Me.btnShape.Text = "S&hape"
        Me.btnShape.UseVisualStyleBackColor = True
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(6, 87)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(111, 30)
        Me.btnSource.TabIndex = 2
        Me.btnSource.Text = "&Source"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'radGift
        '
        Me.radGift.AutoSize = True
        Me.radGift.Checked = True
        Me.radGift.Location = New System.Drawing.Point(11, 24)
        Me.radGift.Name = "radGift"
        Me.radGift.Size = New System.Drawing.Size(46, 21)
        Me.radGift.TabIndex = 0
        Me.radGift.TabStop = True
        Me.radGift.Text = "&Gift"
        Me.radGift.UseVisualStyleBackColor = True
        '
        'radPurchased
        '
        Me.radPurchased.AutoSize = True
        Me.radPurchased.Location = New System.Drawing.Point(11, 51)
        Me.radPurchased.Name = "radPurchased"
        Me.radPurchased.Size = New System.Drawing.Size(86, 21)
        Me.radPurchased.TabIndex = 1
        Me.radPurchased.Text = "&Purchased"
        Me.radPurchased.UseVisualStyleBackColor = True
        '
        'radOctagon
        '
        Me.radOctagon.AutoSize = True
        Me.radOctagon.Checked = True
        Me.radOctagon.Location = New System.Drawing.Point(15, 19)
        Me.radOctagon.Name = "radOctagon"
        Me.radOctagon.Size = New System.Drawing.Size(76, 21)
        Me.radOctagon.TabIndex = 0
        Me.radOctagon.TabStop = True
        Me.radOctagon.Text = "&Octagon"
        Me.radOctagon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRound)
        Me.GroupBox1.Controls.Add(Me.radRectangle)
        Me.GroupBox1.Controls.Add(Me.radOctagon)
        Me.GroupBox1.Controls.Add(Me.btnShape)
        Me.GroupBox1.Location = New System.Drawing.Point(614, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'radRound
        '
        Me.radRound.AutoSize = True
        Me.radRound.Location = New System.Drawing.Point(15, 73)
        Me.radRound.Name = "radRound"
        Me.radRound.Size = New System.Drawing.Size(64, 21)
        Me.radRound.TabIndex = 2
        Me.radRound.Text = "Roun&d"
        Me.radRound.UseVisualStyleBackColor = True
        '
        'radRectangle
        '
        Me.radRectangle.AutoSize = True
        Me.radRectangle.Location = New System.Drawing.Point(15, 46)
        Me.radRectangle.Name = "radRectangle"
        Me.radRectangle.Size = New System.Drawing.Size(83, 21)
        Me.radRectangle.TabIndex = 1
        Me.radRectangle.Text = "&Rectangle"
        Me.radRectangle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radGift)
        Me.GroupBox2.Controls.Add(Me.radPurchased)
        Me.GroupBox2.Controls.Add(Me.btnSource)
        Me.GroupBox2.Location = New System.Drawing.Point(786, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 137)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(792, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(792, 23)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(111, 30)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "&Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 311)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.TblBoxDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Box"
        CType(Me.MusicBoxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBoxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBoxDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicBoxDataSet As MusicBox_Project.MusicBoxDataSet
    Friend WithEvents TblBoxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBoxTableAdapter As MusicBox_Project.MusicBoxDataSetTableAdapters.tblBoxTableAdapter
    Friend WithEvents TableAdapterManager As MusicBox_Project.MusicBoxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblBoxDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnShape As System.Windows.Forms.Button
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents radGift As System.Windows.Forms.RadioButton
    Friend WithEvents radPurchased As System.Windows.Forms.RadioButton
    Friend WithEvents radOctagon As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radRound As System.Windows.Forms.RadioButton
    Friend WithEvents radRectangle As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCount As System.Windows.Forms.Button

End Class
