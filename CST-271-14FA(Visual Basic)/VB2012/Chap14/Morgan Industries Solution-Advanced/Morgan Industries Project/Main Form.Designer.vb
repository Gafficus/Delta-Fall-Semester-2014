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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmployeesDataSet = New Morgan_Industries_Project.EmployeesDataSet()
        Me.TblEmployBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployTableAdapter = New Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter()
        Me.TableAdapterManager = New Morgan_Industries_Project.EmployeesDataSetTableAdapters.TableAdapterManager()
        Me.TblEmployDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnDept = New System.Windows.Forms.Button()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.btnPart = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeesDataSet
        '
        Me.EmployeesDataSet.DataSetName = "EmployeesDataSet"
        Me.EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEmployBindingSource
        '
        Me.TblEmployBindingSource.DataMember = "tblEmploy"
        Me.TblEmployBindingSource.DataSource = Me.EmployeesDataSet
        '
        'TblEmployTableAdapter
        '
        Me.TblEmployTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblEmployTableAdapter = Me.TblEmployTableAdapter
        Me.TableAdapterManager.UpdateOrder = Morgan_Industries_Project.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblEmployDataGridView
        '
        Me.TblEmployDataGridView.AllowUserToAddRows = False
        Me.TblEmployDataGridView.AllowUserToDeleteRows = False
        Me.TblEmployDataGridView.AutoGenerateColumns = False
        Me.TblEmployDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblEmployDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblEmployDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TblEmployDataGridView.DataSource = Me.TblEmployBindingSource
        Me.TblEmployDataGridView.Location = New System.Drawing.Point(12, 23)
        Me.TblEmployDataGridView.Name = "TblEmployDataGridView"
        Me.TblEmployDataGridView.ReadOnly = True
        Me.TblEmployDataGridView.RowHeadersVisible = False
        Me.TblEmployDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblEmployDataGridView.Size = New System.Drawing.Size(655, 428)
        Me.TblEmployDataGridView.TabIndex = 5
        '
        'btnDept
        '
        Me.btnDept.Location = New System.Drawing.Point(707, 128)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(89, 29)
        Me.btnDept.TabIndex = 3
        Me.btnDept.Text = "&Department"
        Me.btnDept.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.Location = New System.Drawing.Point(707, 93)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(89, 29)
        Me.btnFull.TabIndex = 2
        Me.btnFull.Text = "&Full-time"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'btnPart
        '
        Me.btnPart.Location = New System.Drawing.Point(707, 58)
        Me.btnPart.Name = "btnPart"
        Me.btnPart.Size = New System.Drawing.Size(89, 29)
        Me.btnPart.TabIndex = 1
        Me.btnPart.Text = "&Part-time"
        Me.btnPart.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(707, 23)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(89, 29)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "&All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(707, 163)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 29)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Emp_Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hired"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hired"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Rate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pay Rate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 83
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 68
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 64
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 481)
        Me.Controls.Add(Me.btnDept)
        Me.Controls.Add(Me.btnFull)
        Me.Controls.Add(Me.btnPart)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TblEmployDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan Industries"
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployeesDataSet As Morgan_Industries_Project.EmployeesDataSet
    Friend WithEvents TblEmployBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployTableAdapter As Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter
    Friend WithEvents TableAdapterManager As Morgan_Industries_Project.EmployeesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblEmployDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Friend WithEvents btnFull As System.Windows.Forms.Button
    Friend WithEvents btnPart As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
