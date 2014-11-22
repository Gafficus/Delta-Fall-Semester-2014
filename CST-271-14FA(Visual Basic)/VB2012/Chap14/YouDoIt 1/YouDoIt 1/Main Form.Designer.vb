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
        Me.NamesDataSet = New YouDoIt_1.NamesDataSet()
        Me.TblNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblNamesTableAdapter = New YouDoIt_1.NamesDataSetTableAdapters.tblNamesTableAdapter()
        Me.TableAdapterManager = New YouDoIt_1.NamesDataSetTableAdapters.TableAdapterManager()
        Me.TblNamesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNamesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NamesDataSet
        '
        Me.NamesDataSet.DataSetName = "NamesDataSet"
        Me.NamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblNamesBindingSource
        '
        Me.TblNamesBindingSource.DataMember = "tblNames"
        Me.TblNamesBindingSource.DataSource = Me.NamesDataSet
        '
        'TblNamesTableAdapter
        '
        Me.TblNamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblNamesTableAdapter = Me.TblNamesTableAdapter
        Me.TableAdapterManager.UpdateOrder = YouDoIt_1.NamesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblNamesDataGridView
        '
        Me.TblNamesDataGridView.AllowUserToAddRows = False
        Me.TblNamesDataGridView.AllowUserToDeleteRows = False
        Me.TblNamesDataGridView.AutoGenerateColumns = False
        Me.TblNamesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblNamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblNamesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblNamesDataGridView.DataSource = Me.TblNamesBindingSource
        Me.TblNamesDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.TblNamesDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblNamesDataGridView.Name = "TblNamesDataGridView"
        Me.TblNamesDataGridView.ReadOnly = True
        Me.TblNamesDataGridView.RowHeadersVisible = False
        Me.TblNamesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblNamesDataGridView.Size = New System.Drawing.Size(399, 288)
        Me.TblNamesDataGridView.StandardTab = True
        Me.TblNamesDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 534)
        Me.Controls.Add(Me.TblNamesDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Names"
        CType(Me.NamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNamesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NamesDataSet As YouDoIt_1.NamesDataSet
    Friend WithEvents TblNamesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblNamesTableAdapter As YouDoIt_1.NamesDataSetTableAdapters.tblNamesTableAdapter
    Friend WithEvents TableAdapterManager As YouDoIt_1.NamesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblNamesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
