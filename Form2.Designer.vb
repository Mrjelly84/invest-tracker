<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InvestTrackDataSet = New Investment_tracker.InvestTrackDataSet()
        Me.InvestmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentsTableAdapter = New Investment_tracker.InvestTrackDataSetTableAdapters.InvestmentsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TickerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvestmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricePerShareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSharesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TickerDataGridViewTextBoxColumn, Me.InvestmentTypeDataGridViewTextBoxColumn, Me.PricePerShareDataGridViewTextBoxColumn, Me.PurchaseDateDataGridViewTextBoxColumn, Me.NumSharesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvestmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'InvestTrackDataSet
        '
        Me.InvestTrackDataSet.DataSetName = "InvestTrackDataSet"
        Me.InvestTrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvestmentsBindingSource
        '
        Me.InvestmentsBindingSource.DataMember = "Investments"
        Me.InvestmentsBindingSource.DataSource = Me.InvestTrackDataSet
        '
        'InvestmentsTableAdapter
        '
        Me.InvestmentsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TickerDataGridViewTextBoxColumn
        '
        Me.TickerDataGridViewTextBoxColumn.DataPropertyName = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.HeaderText = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.Name = "TickerDataGridViewTextBoxColumn"
        Me.TickerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvestmentTypeDataGridViewTextBoxColumn
        '
        Me.InvestmentTypeDataGridViewTextBoxColumn.DataPropertyName = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.HeaderText = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.Name = "InvestmentTypeDataGridViewTextBoxColumn"
        Me.InvestmentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PricePerShareDataGridViewTextBoxColumn
        '
        Me.PricePerShareDataGridViewTextBoxColumn.DataPropertyName = "PricePerShare"
        Me.PricePerShareDataGridViewTextBoxColumn.HeaderText = "PricePerShare"
        Me.PricePerShareDataGridViewTextBoxColumn.Name = "PricePerShareDataGridViewTextBoxColumn"
        Me.PricePerShareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaseDateDataGridViewTextBoxColumn
        '
        Me.PurchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.Name = "PurchaseDateDataGridViewTextBoxColumn"
        Me.PurchaseDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumSharesDataGridViewTextBoxColumn
        '
        Me.NumSharesDataGridViewTextBoxColumn.DataPropertyName = "NumShares"
        Me.NumSharesDataGridViewTextBoxColumn.HeaderText = "NumShares"
        Me.NumSharesDataGridViewTextBoxColumn.Name = "NumSharesDataGridViewTextBoxColumn"
        Me.NumSharesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 316)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Investment List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InvestTrackDataSet As InvestTrackDataSet
    Friend WithEvents InvestmentsBindingSource As BindingSource
    Friend WithEvents InvestmentsTableAdapter As InvestTrackDataSetTableAdapters.InvestmentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TickerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvestmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricePerShareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumSharesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
