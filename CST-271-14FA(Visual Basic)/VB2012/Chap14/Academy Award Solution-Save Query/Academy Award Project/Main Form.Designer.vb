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
        Me.MoviesDataSet = New Academy_Award_Project.MoviesDataSet()
        Me.TblMoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMoviesTableAdapter = New Academy_Award_Project.MoviesDataSetTableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager = New Academy_Award_Project.MoviesDataSetTableAdapters.TableAdapterManager()
        Me.TblMoviesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radAll = New System.Windows.Forms.RadioButton()
        Me.radForYear = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        CType(Me.MoviesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MoviesDataSet
        '
        Me.MoviesDataSet.DataSetName = "MoviesDataSet"
        Me.MoviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMoviesBindingSource
        '
        Me.TblMoviesBindingSource.DataMember = "tblMovies"
        Me.TblMoviesBindingSource.DataSource = Me.MoviesDataSet
        '
        'TblMoviesTableAdapter
        '
        Me.TblMoviesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblMoviesTableAdapter = Me.TblMoviesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Academy_Award_Project.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMoviesDataGridView
        '
        Me.TblMoviesDataGridView.AllowUserToAddRows = False
        Me.TblMoviesDataGridView.AllowUserToDeleteRows = False
        Me.TblMoviesDataGridView.AutoGenerateColumns = False
        Me.TblMoviesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.TblMoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMoviesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblMoviesDataGridView.DataSource = Me.TblMoviesBindingSource
        Me.TblMoviesDataGridView.Location = New System.Drawing.Point(29, 27)
        Me.TblMoviesDataGridView.Name = "TblMoviesDataGridView"
        Me.TblMoviesDataGridView.ReadOnly = True
        Me.TblMoviesDataGridView.RowHeadersVisible = False
        Me.TblMoviesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblMoviesDataGridView.Size = New System.Drawing.Size(591, 270)
        Me.TblMoviesDataGridView.StandardTab = True
        Me.TblMoviesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "YearWon"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Year Won"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Movie Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 97
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DirectedBy"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Director"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RunningTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Length"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 72
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(766, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.btnDisplay)
        Me.GroupBox1.Controls.Add(Me.radForYear)
        Me.GroupBox1.Controls.Add(Me.radAll)
        Me.GroupBox1.Location = New System.Drawing.Point(647, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'radAll
        '
        Me.radAll.AutoSize = True
        Me.radAll.Checked = True
        Me.radAll.Location = New System.Drawing.Point(14, 28)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(40, 21)
        Me.radAll.TabIndex = 1
        Me.radAll.TabStop = True
        Me.radAll.Text = "&All"
        Me.radAll.UseVisualStyleBackColor = True
        '
        'radForYear
        '
        Me.radForYear.AutoSize = True
        Me.radForYear.Location = New System.Drawing.Point(14, 56)
        Me.radForYear.Name = "radForYear"
        Me.radForYear.Size = New System.Drawing.Size(75, 21)
        Me.radForYear.TabIndex = 2
        Me.radForYear.Text = "For &Year"
        Me.radForYear.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(101, 28)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 27)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(14, 83)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(56, 25)
        Me.txtYear.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TblMoviesDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Academy Award Winners"
        CType(Me.MoviesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MoviesDataSet As Academy_Award_Project.MoviesDataSet
    Friend WithEvents TblMoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter As Academy_Award_Project.MoviesDataSetTableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager As Academy_Award_Project.MoviesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblMoviesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents radForYear As System.Windows.Forms.RadioButton
    Friend WithEvents radAll As System.Windows.Forms.RadioButton

End Class
