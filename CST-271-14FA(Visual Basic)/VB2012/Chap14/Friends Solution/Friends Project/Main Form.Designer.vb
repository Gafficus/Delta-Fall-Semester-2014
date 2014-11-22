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
        Me.FriendsDataSet = New Friends_Project.FriendsDataSet()
        Me.TblFriendsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFriendsTableAdapter = New Friends_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter()
        Me.TableAdapterManager = New Friends_Project.FriendsDataSetTableAdapters.TableAdapterManager()
        Me.TblFriendsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFriendsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.UpdateOrder = Friends_Project.FriendsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblFriendsDataGridView
        '
        Me.TblFriendsDataGridView.AllowUserToAddRows = False
        Me.TblFriendsDataGridView.AllowUserToDeleteRows = False
        Me.TblFriendsDataGridView.AutoGenerateColumns = False
        Me.TblFriendsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblFriendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblFriendsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblFriendsDataGridView.DataSource = Me.TblFriendsBindingSource
        Me.TblFriendsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblFriendsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblFriendsDataGridView.Name = "TblFriendsDataGridView"
        Me.TblFriendsDataGridView.ReadOnly = True
        Me.TblFriendsDataGridView.RowHeadersVisible = False
        Me.TblFriendsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblFriendsDataGridView.Size = New System.Drawing.Size(396, 438)
        Me.TblFriendsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 49
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Last"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "First"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 438)
        Me.Controls.Add(Me.TblFriendsDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Friends"
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFriendsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FriendsDataSet As Friends_Project.FriendsDataSet
    Friend WithEvents TblFriendsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFriendsTableAdapter As Friends_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter
    Friend WithEvents TableAdapterManager As Friends_Project.FriendsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblFriendsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
