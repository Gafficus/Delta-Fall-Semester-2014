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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnPatron = New System.Windows.Forms.Button()
        Me.btnSeatNumber = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDeleteSeat = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.txtPatron = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.PlayDataSet = New Addison_Playhouse_Project.PlayDataSet()
        Me.TblReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblReservationsTableAdapter = New Addison_Playhouse_Project.PlayDataSetTableAdapters.tblReservationsTableAdapter()
        Me.TableAdapterManager = New Addison_Playhouse_Project.PlayDataSetTableAdapters.TableAdapterManager()
        Me.TblReservationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PlayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblReservationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(397, 433)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAll)
        Me.GroupBox3.Controls.Add(Me.btnPatron)
        Me.GroupBox3.Controls.Add(Me.btnSeatNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(336, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 131)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View record(s)"
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(15, 94)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(105, 29)
        Me.btnAll.TabIndex = 2
        Me.btnAll.Text = "A&ll"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnPatron
        '
        Me.btnPatron.Location = New System.Drawing.Point(15, 59)
        Me.btnPatron.Name = "btnPatron"
        Me.btnPatron.Size = New System.Drawing.Size(105, 29)
        Me.btnPatron.TabIndex = 1
        Me.btnPatron.Text = "Pa&tron"
        Me.btnPatron.UseVisualStyleBackColor = True
        '
        'btnSeatNumber
        '
        Me.btnSeatNumber.Location = New System.Drawing.Point(15, 24)
        Me.btnSeatNumber.Name = "btnSeatNumber"
        Me.btnSeatNumber.Size = New System.Drawing.Size(105, 29)
        Me.btnSeatNumber.TabIndex = 0
        Me.btnSeatNumber.Text = "Seat &Number"
        Me.btnSeatNumber.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.lblDeleteSeat)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 387)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 79)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delete a record"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(110, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblDeleteSeat
        '
        Me.lblDeleteSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeleteSeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblReservationsBindingSource, "Seat", True))
        Me.lblDeleteSeat.Location = New System.Drawing.Point(54, 27)
        Me.lblDeleteSeat.Name = "lblDeleteSeat"
        Me.lblDeleteSeat.Size = New System.Drawing.Size(50, 25)
        Me.lblDeleteSeat.TabIndex = 1
        Me.lblDeleteSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 30)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(36, 17)
        Label4.TabIndex = 0
        Label4.Text = "Seat:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.txtSeat)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.txtPatron)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a record"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(104, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 25)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(36, 17)
        Label1.TabIndex = 0
        Label1.Text = "&Seat:"
        '
        'txtSeat
        '
        Me.txtSeat.Location = New System.Drawing.Point(63, 28)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(35, 25)
        Me.txtSeat.TabIndex = 1
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(11, 62)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(49, 17)
        Label2.TabIndex = 2
        Label2.Text = "&Patron:"
        '
        'txtPatron
        '
        Me.txtPatron.Location = New System.Drawing.Point(63, 59)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(100, 25)
        Me.txtPatron.TabIndex = 3
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(11, 93)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 17)
        Label3.TabIndex = 4
        Label3.Text = "Ph&one:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(63, 90)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 25)
        Me.txtPhone.TabIndex = 5
        '
        'PlayDataSet
        '
        Me.PlayDataSet.DataSetName = "PlayDataSet"
        Me.PlayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblReservationsBindingSource
        '
        Me.TblReservationsBindingSource.DataMember = "tblReservations"
        Me.TblReservationsBindingSource.DataSource = Me.PlayDataSet
        '
        'TblReservationsTableAdapter
        '
        Me.TblReservationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblReservationsTableAdapter = Me.TblReservationsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Addison_Playhouse_Project.PlayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblReservationsDataGridView
        '
        Me.TblReservationsDataGridView.AllowUserToAddRows = False
        Me.TblReservationsDataGridView.AllowUserToDeleteRows = False
        Me.TblReservationsDataGridView.AutoGenerateColumns = False
        Me.TblReservationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblReservationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblReservationsDataGridView.DataSource = Me.TblReservationsBindingSource
        Me.TblReservationsDataGridView.Location = New System.Drawing.Point(40, 12)
        Me.TblReservationsDataGridView.Name = "TblReservationsDataGridView"
        Me.TblReservationsDataGridView.ReadOnly = True
        Me.TblReservationsDataGridView.RowHeadersVisible = False
        Me.TblReservationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblReservationsDataGridView.Size = New System.Drawing.Size(432, 220)
        Me.TblReservationsDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Seat"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Seat"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Patron"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patron"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 499)
        Me.Controls.Add(Me.TblReservationsDataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addison Playhouse"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PlayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblReservationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnPatron As System.Windows.Forms.Button
    Friend WithEvents btnSeatNumber As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblDeleteSeat As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSeat As System.Windows.Forms.TextBox
    Friend WithEvents txtPatron As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents PlayDataSet As Addison_Playhouse_Project.PlayDataSet
    Friend WithEvents TblReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblReservationsTableAdapter As Addison_Playhouse_Project.PlayDataSetTableAdapters.tblReservationsTableAdapter
    Friend WithEvents TableAdapterManager As Addison_Playhouse_Project.PlayDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblReservationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
