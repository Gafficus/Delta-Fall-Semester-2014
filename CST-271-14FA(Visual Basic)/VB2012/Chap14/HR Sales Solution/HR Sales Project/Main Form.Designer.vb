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
        Me.SalesDataSet = New HR_Sales_Project.SalesDataSet()
        Me.TblSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSalesTableAdapter = New HR_Sales_Project.SalesDataSetTableAdapters.tblSalesTableAdapter()
        Me.TableAdapterManager = New HR_Sales_Project.SalesDataSetTableAdapters.TableAdapterManager()
        Me.TblSalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "SalesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSalesBindingSource
        '
        Me.TblSalesBindingSource.DataMember = "tblSales"
        Me.TblSalesBindingSource.DataSource = Me.SalesDataSet
        '
        'TblSalesTableAdapter
        '
        Me.TblSalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblSalesTableAdapter = Me.TblSalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = HR_Sales_Project.SalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSalesDataGridView
        '
        Me.TblSalesDataGridView.AllowUserToAddRows = False
        Me.TblSalesDataGridView.AllowUserToDeleteRows = False
        Me.TblSalesDataGridView.AutoGenerateColumns = False
        Me.TblSalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblSalesDataGridView.DataSource = Me.TblSalesBindingSource
        Me.TblSalesDataGridView.Location = New System.Drawing.Point(2, 4)
        Me.TblSalesDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblSalesDataGridView.Name = "TblSalesDataGridView"
        Me.TblSalesDataGridView.ReadOnly = True
        Me.TblSalesDataGridView.RowHeadersVisible = False
        Me.TblSalesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblSalesDataGridView.Size = New System.Drawing.Size(443, 259)
        Me.TblSalesDataGridView.StandardTab = True
        Me.TblSalesDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RecordNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RecordNum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "YearNum"
        Me.DataGridViewTextBoxColumn2.HeaderText = "YearNum"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MonthNum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MonthNum"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sales"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sales"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(728, 53)
        Me.txtSales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(74, 27)
        Me.txtSales.TabIndex = 7
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(644, 53)
        Me.txtMonth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(59, 27)
        Me.txtMonth.TabIndex = 5
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(564, 53)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(59, 27)
        Me.txtYear.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(725, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(641, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Month:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Year:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(732, 124)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 33)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(656, 124)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 33)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(488, 53)
        Me.txtRecord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.Size = New System.Drawing.Size(59, 27)
        Me.txtRecord.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Record:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 309)
        Me.Controls.Add(Me.txtRecord)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TblSalesDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR Sales"
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalesDataSet As HR_Sales_Project.SalesDataSet
    Friend WithEvents TblSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSalesTableAdapter As HR_Sales_Project.SalesDataSetTableAdapters.tblSalesTableAdapter
    Friend WithEvents TableAdapterManager As HR_Sales_Project.SalesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtRecord As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
