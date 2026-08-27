<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlSalaryDeductionView = New System.Windows.Forms.Panel()
        Me.pnlLimitReached = New System.Windows.Forms.Panel()
        Me.lblLimitReachedCount = New System.Windows.Forms.Label()
        Me.lblLimitReachedTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.pnlPendingDeductions = New System.Windows.Forms.Label()
        Me.pnlTotalEmployees = New System.Windows.Forms.Panel()
        Me.lblTotalEmployeesCount = New System.Windows.Forms.Label()
        Me.lblTotalEmployees = New System.Windows.Forms.Label()
        Me.dgvTextBoxColumn = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbRoleFilter = New System.Windows.Forms.ComboBox()
        Me.flowLayoutPanelActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEdit1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlDashboardView = New System.Windows.Forms.Panel()
        Me.pnlInventoryAlerts = New System.Windows.Forms.Panel()
        Me.lblInventoryAlerts = New System.Windows.Forms.Label()
        Me.pnlRecentTransactions = New System.Windows.Forms.Panel()
        Me.btnViewAll = New System.Windows.Forms.Label()
        Me.dgvRecentTransactions = New System.Windows.Forms.DataGridView()
        Me.colTransactionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cardSalaryDeduction = New System.Windows.Forms.Panel()
        Me.lblSalaryDeductionVal = New System.Windows.Forms.Label()
        Me.lblDeductTitle = New System.Windows.Forms.Label()
        Me.cardItemsSold = New System.Windows.Forms.Panel()
        Me.lblItemsSoldVal = New System.Windows.Forms.Label()
        Me.lblItemsTitle = New System.Windows.Forms.Label()
        Me.cardTransactions = New System.Windows.Forms.Panel()
        Me.lblTransactionsVal = New System.Windows.Forms.Label()
        Me.lblTransTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTodaySalesVal = New System.Windows.Forms.Label()
        Me.lblSalesTitle = New System.Windows.Forms.Label()
        Me.pnlInventoryView = New System.Windows.Forms.Panel()
        Me.pnlReportsView = New System.Windows.Forms.Panel()
        Me.pnlSettingsView = New System.Windows.Forms.Panel()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblTitleDashboard = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSalaryDeduction = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.colEmpNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSDRemaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductionStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colPeriodStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeriodEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlSalaryDeductionView.SuspendLayout()
        Me.pnlLimitReached.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlTotalEmployees.SuspendLayout()
        CType(Me.dgvTextBoxColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowLayoutPanelActions.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlDashboardView.SuspendLayout()
        Me.pnlInventoryAlerts.SuspendLayout()
        Me.pnlRecentTransactions.SuspendLayout()
        CType(Me.dgvRecentTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cardSalaryDeduction.SuspendLayout()
        Me.cardItemsSold.SuspendLayout()
        Me.cardTransactions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.pnlSalaryDeductionView)
        Me.pnlMainContent.Controls.Add(Me.pnlDashboardView)
        Me.pnlMainContent.Controls.Add(Me.pnlInventoryView)
        Me.pnlMainContent.Controls.Add(Me.pnlReportsView)
        Me.pnlMainContent.Controls.Add(Me.pnlSettingsView)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1067, 554)
        Me.pnlMainContent.TabIndex = 0
        '
        'pnlSalaryDeductionView
        '
        Me.pnlSalaryDeductionView.AutoSize = True
        Me.pnlSalaryDeductionView.Controls.Add(Me.pnlLimitReached)
        Me.pnlSalaryDeductionView.Controls.Add(Me.Panel3)
        Me.pnlSalaryDeductionView.Controls.Add(Me.pnlTotalEmployees)
        Me.pnlSalaryDeductionView.Controls.Add(Me.dgvTextBoxColumn)
        Me.pnlSalaryDeductionView.Controls.Add(Me.txtSearch)
        Me.pnlSalaryDeductionView.Controls.Add(Me.cmbRoleFilter)
        Me.pnlSalaryDeductionView.Controls.Add(Me.flowLayoutPanelActions)
        Me.pnlSalaryDeductionView.Controls.Add(Me.pnlHeader)
        Me.pnlSalaryDeductionView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSalaryDeductionView.Location = New System.Drawing.Point(0, 0)
        Me.pnlSalaryDeductionView.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSalaryDeductionView.Name = "pnlSalaryDeductionView"
        Me.pnlSalaryDeductionView.Size = New System.Drawing.Size(1067, 554)
        Me.pnlSalaryDeductionView.TabIndex = 0
        '
        'pnlLimitReached
        '
        Me.pnlLimitReached.Controls.Add(Me.lblLimitReachedCount)
        Me.pnlLimitReached.Controls.Add(Me.lblLimitReachedTitle)
        Me.pnlLimitReached.Location = New System.Drawing.Point(803, 75)
        Me.pnlLimitReached.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLimitReached.Name = "pnlLimitReached"
        Me.pnlLimitReached.Size = New System.Drawing.Size(223, 103)
        Me.pnlLimitReached.TabIndex = 7
        '
        'lblLimitReachedCount
        '
        Me.lblLimitReachedCount.AutoSize = True
        Me.lblLimitReachedCount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimitReachedCount.ForeColor = System.Drawing.Color.Gold
        Me.lblLimitReachedCount.Location = New System.Drawing.Point(89, 52)
        Me.lblLimitReachedCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimitReachedCount.Name = "lblLimitReachedCount"
        Me.lblLimitReachedCount.Size = New System.Drawing.Size(33, 37)
        Me.lblLimitReachedCount.TabIndex = 4
        Me.lblLimitReachedCount.Text = "0"
        '
        'lblLimitReachedTitle
        '
        Me.lblLimitReachedTitle.AutoSize = True
        Me.lblLimitReachedTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimitReachedTitle.ForeColor = System.Drawing.Color.White
        Me.lblLimitReachedTitle.Location = New System.Drawing.Point(32, 14)
        Me.lblLimitReachedTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimitReachedTitle.Name = "lblLimitReachedTitle"
        Me.lblLimitReachedTitle.Size = New System.Drawing.Size(154, 25)
        Me.lblLimitReachedTitle.TabIndex = 0
        Me.lblLimitReachedTitle.Text = "LIMIT REACHED"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblPendingCount)
        Me.Panel3.Controls.Add(Me.pnlPendingDeductions)
        Me.Panel3.Location = New System.Drawing.Point(553, 75)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 103)
        Me.Panel3.TabIndex = 7
        '
        'lblPendingCount
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCount.ForeColor = System.Drawing.Color.Gold
        Me.lblPendingCount.Location = New System.Drawing.Point(87, 52)
        Me.lblPendingCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(33, 37)
        Me.lblPendingCount.TabIndex = 3
        Me.lblPendingCount.Text = "0"
        '
        'pnlPendingDeductions
        '
        Me.pnlPendingDeductions.AutoSize = True
        Me.pnlPendingDeductions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPendingDeductions.ForeColor = System.Drawing.Color.White
        Me.pnlPendingDeductions.Location = New System.Drawing.Point(15, 17)
        Me.pnlPendingDeductions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pnlPendingDeductions.Name = "pnlPendingDeductions"
        Me.pnlPendingDeductions.Size = New System.Drawing.Size(199, 23)
        Me.pnlPendingDeductions.TabIndex = 2
        Me.pnlPendingDeductions.Text = "PENDING DEDUCTIONS"
        '
        'pnlTotalEmployees
        '
        Me.pnlTotalEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTotalEmployees.Controls.Add(Me.lblTotalEmployeesCount)
        Me.pnlTotalEmployees.Controls.Add(Me.lblTotalEmployees)
        Me.pnlTotalEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTotalEmployees.Location = New System.Drawing.Point(300, 75)
        Me.pnlTotalEmployees.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTotalEmployees.Name = "pnlTotalEmployees"
        Me.pnlTotalEmployees.Size = New System.Drawing.Size(223, 103)
        Me.pnlTotalEmployees.TabIndex = 6
        '
        'lblTotalEmployeesCount
        '
        Me.lblTotalEmployeesCount.AutoSize = True
        Me.lblTotalEmployeesCount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployeesCount.ForeColor = System.Drawing.Color.Gold
        Me.lblTotalEmployeesCount.Location = New System.Drawing.Point(85, 52)
        Me.lblTotalEmployeesCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalEmployeesCount.Name = "lblTotalEmployeesCount"
        Me.lblTotalEmployeesCount.Size = New System.Drawing.Size(33, 37)
        Me.lblTotalEmployeesCount.TabIndex = 1
        Me.lblTotalEmployeesCount.Text = "0"
        '
        'lblTotalEmployees
        '
        Me.lblTotalEmployees.AutoSize = True
        Me.lblTotalEmployees.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployees.ForeColor = System.Drawing.Color.White
        Me.lblTotalEmployees.Location = New System.Drawing.Point(17, 14)
        Me.lblTotalEmployees.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalEmployees.Name = "lblTotalEmployees"
        Me.lblTotalEmployees.Size = New System.Drawing.Size(180, 25)
        Me.lblTotalEmployees.TabIndex = 0
        Me.lblTotalEmployees.Text = "TOTAL EMPLOYEES"
        '
        'dgvTextBoxColumn
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dgvTextBoxColumn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTextBoxColumn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTextBoxColumn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvTextBoxColumn.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvTextBoxColumn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTextBoxColumn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTextBoxColumn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTextBoxColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTextBoxColumn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmpNo, Me.colName, Me.colPosition, Me.colSDRemaining, Me.colStatus, Me.DeductionStatus, Me.colPeriodStart, Me.colPeriodEnd})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTextBoxColumn.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvTextBoxColumn.Location = New System.Drawing.Point(284, 262)
        Me.dgvTextBoxColumn.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTextBoxColumn.Name = "dgvTextBoxColumn"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTextBoxColumn.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTextBoxColumn.RowHeadersVisible = False
        Me.dgvTextBoxColumn.RowHeadersWidth = 51
        Me.dgvTextBoxColumn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTextBoxColumn.Size = New System.Drawing.Size(779, 277)
        Me.dgvTextBoxColumn.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.Location = New System.Drawing.Point(840, 230)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(204, 22)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = "🔍 Search employee name or ID..."
        '
        'cmbRoleFilter
        '
        Me.cmbRoleFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbRoleFilter.ForeColor = System.Drawing.Color.White
        Me.cmbRoleFilter.FormattingEnabled = True
        Me.cmbRoleFilter.Items.AddRange(New Object() {"All Roles ", "Teacher", "Staff"})
        Me.cmbRoleFilter.Location = New System.Drawing.Point(840, 197)
        Me.cmbRoleFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRoleFilter.Name = "cmbRoleFilter"
        Me.cmbRoleFilter.Size = New System.Drawing.Size(204, 24)
        Me.cmbRoleFilter.TabIndex = 2
        '
        'flowLayoutPanelActions
        '
        Me.flowLayoutPanelActions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flowLayoutPanelActions.Controls.Add(Me.btnEdit1)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnAdd)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnView)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnDelete)
        Me.flowLayoutPanelActions.Location = New System.Drawing.Point(295, 210)
        Me.flowLayoutPanelActions.Margin = New System.Windows.Forms.Padding(4)
        Me.flowLayoutPanelActions.Name = "flowLayoutPanelActions"
        Me.flowLayoutPanelActions.Size = New System.Drawing.Size(481, 38)
        Me.flowLayoutPanelActions.TabIndex = 1
        '
        'btnEdit1
        '
        Me.btnEdit1.BackColor = System.Drawing.Color.SeaGreen
        Me.btnEdit1.FlatAppearance.BorderSize = 0
        Me.btnEdit1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEdit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit1.Location = New System.Drawing.Point(4, 4)
        Me.btnEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Size = New System.Drawing.Size(108, 31)
        Me.btnEdit1.TabIndex = 3
        Me.btnEdit1.Text = "EDIT"
        Me.btnEdit1.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(120, 4)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 31)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnView.Location = New System.Drawing.Point(236, 4)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(108, 31)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(352, 4)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 31)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(271, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(796, 63)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(9, 31)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(295, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manage employees and salary deductions  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE SALARY DEDUCTION MANAGEMENT"
        '
        'pnlDashboardView
        '
        Me.pnlDashboardView.Controls.Add(Me.pnlInventoryAlerts)
        Me.pnlDashboardView.Controls.Add(Me.pnlRecentTransactions)
        Me.pnlDashboardView.Controls.Add(Me.Chart1)
        Me.pnlDashboardView.Controls.Add(Me.cardSalaryDeduction)
        Me.pnlDashboardView.Controls.Add(Me.cardItemsSold)
        Me.pnlDashboardView.Controls.Add(Me.cardTransactions)
        Me.pnlDashboardView.Controls.Add(Me.Panel1)
        Me.pnlDashboardView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboardView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDashboardView.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboardView.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDashboardView.Name = "pnlDashboardView"
        Me.pnlDashboardView.Size = New System.Drawing.Size(1067, 554)
        Me.pnlDashboardView.TabIndex = 0
        '
        'pnlInventoryAlerts
        '
        Me.pnlInventoryAlerts.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.pnlInventoryAlerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInventoryAlerts.Controls.Add(Me.lblInventoryAlerts)
        Me.pnlInventoryAlerts.Location = New System.Drawing.Point(687, 121)
        Me.pnlInventoryAlerts.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlInventoryAlerts.Name = "pnlInventoryAlerts"
        Me.pnlInventoryAlerts.Size = New System.Drawing.Size(363, 211)
        Me.pnlInventoryAlerts.TabIndex = 7
        '
        'lblInventoryAlerts
        '
        Me.lblInventoryAlerts.AutoSize = True
        Me.lblInventoryAlerts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryAlerts.ForeColor = System.Drawing.Color.Gold
        Me.lblInventoryAlerts.Location = New System.Drawing.Point(80, 15)
        Me.lblInventoryAlerts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventoryAlerts.Name = "lblInventoryAlerts"
        Me.lblInventoryAlerts.Size = New System.Drawing.Size(170, 23)
        Me.lblInventoryAlerts.TabIndex = 0
        Me.lblInventoryAlerts.Text = "INVENTORY ALERTS"
        '
        'pnlRecentTransactions
        '
        Me.pnlRecentTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.pnlRecentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRecentTransactions.Controls.Add(Me.btnViewAll)
        Me.pnlRecentTransactions.Controls.Add(Me.dgvRecentTransactions)
        Me.pnlRecentTransactions.Location = New System.Drawing.Point(271, 346)
        Me.pnlRecentTransactions.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRecentTransactions.Name = "pnlRecentTransactions"
        Me.pnlRecentTransactions.Size = New System.Drawing.Size(790, 206)
        Me.pnlRecentTransactions.TabIndex = 6
        '
        'btnViewAll
        '
        Me.btnViewAll.AutoSize = True
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnViewAll.Location = New System.Drawing.Point(687, 11)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(83, 20)
        Me.btnViewAll.TabIndex = 1
        Me.btnViewAll.Text = "View All →"
        '
        'dgvRecentTransactions
        '
        Me.dgvRecentTransactions.AllowUserToAddRows = False
        Me.dgvRecentTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentTransactions.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTransactionNo, Me.colTransactionDate, Me.colPaymentMethod, Me.colAmount, Me.colStatus1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentTransactions.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRecentTransactions.GridColor = System.Drawing.Color.Gray
        Me.dgvRecentTransactions.Location = New System.Drawing.Point(9, 33)
        Me.dgvRecentTransactions.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRecentTransactions.MultiSelect = False
        Me.dgvRecentTransactions.Name = "dgvRecentTransactions"
        Me.dgvRecentTransactions.ReadOnly = True
        Me.dgvRecentTransactions.RowHeadersVisible = False
        Me.dgvRecentTransactions.RowHeadersWidth = 51
        Me.dgvRecentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentTransactions.Size = New System.Drawing.Size(764, 167)
        Me.dgvRecentTransactions.TabIndex = 0
        '
        'colTransactionNo
        '
        Me.colTransactionNo.HeaderText = "Transaction No."
        Me.colTransactionNo.MinimumWidth = 6
        Me.colTransactionNo.Name = "colTransactionNo"
        Me.colTransactionNo.ReadOnly = True
        '
        'colTransactionDate
        '
        Me.colTransactionDate.HeaderText = "Date"
        Me.colTransactionDate.MinimumWidth = 6
        Me.colTransactionDate.Name = "colTransactionDate"
        Me.colTransactionDate.ReadOnly = True
        '
        'colPaymentMethod
        '
        Me.colPaymentMethod.HeaderText = "Payment"
        Me.colPaymentMethod.MinimumWidth = 6
        Me.colPaymentMethod.Name = "colPaymentMethod"
        Me.colPaymentMethod.ReadOnly = True
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.MinimumWidth = 6
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'colStatus1
        '
        Me.colStatus1.HeaderText = "Status"
        Me.colStatus1.MinimumWidth = 6
        Me.colStatus1.Name = "colStatus1"
        Me.colStatus1.ReadOnly = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.AxisX.Title = "Day"
        ChartArea1.AxisY.Title = "Sales (₱)"
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(284, 121)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(389, 212)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'cardSalaryDeduction
        '
        Me.cardSalaryDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardSalaryDeduction.Controls.Add(Me.lblSalaryDeductionVal)
        Me.cardSalaryDeduction.Controls.Add(Me.lblDeductTitle)
        Me.cardSalaryDeduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardSalaryDeduction.Location = New System.Drawing.Point(855, 15)
        Me.cardSalaryDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.cardSalaryDeduction.Name = "cardSalaryDeduction"
        Me.cardSalaryDeduction.Size = New System.Drawing.Size(191, 101)
        Me.cardSalaryDeduction.TabIndex = 4
        '
        'lblSalaryDeductionVal
        '
        Me.lblSalaryDeductionVal.AutoSize = True
        Me.lblSalaryDeductionVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryDeductionVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblSalaryDeductionVal.Location = New System.Drawing.Point(49, 62)
        Me.lblSalaryDeductionVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalaryDeductionVal.Name = "lblSalaryDeductionVal"
        Me.lblSalaryDeductionVal.Size = New System.Drawing.Size(96, 41)
        Me.lblSalaryDeductionVal.TabIndex = 1
        Me.lblSalaryDeductionVal.Text = "₱0.00"
        '
        'lblDeductTitle
        '
        Me.lblDeductTitle.AutoSize = True
        Me.lblDeductTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeductTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblDeductTitle.Location = New System.Drawing.Point(27, 11)
        Me.lblDeductTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeductTitle.Name = "lblDeductTitle"
        Me.lblDeductTitle.Size = New System.Drawing.Size(124, 46)
        Me.lblDeductTitle.TabIndex = 0
        Me.lblDeductTitle.Text = "SALARY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " DEDUCTIONS"
        '
        'cardItemsSold
        '
        Me.cardItemsSold.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardItemsSold.Controls.Add(Me.lblItemsSoldVal)
        Me.cardItemsSold.Controls.Add(Me.lblItemsTitle)
        Me.cardItemsSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardItemsSold.Location = New System.Drawing.Point(656, 15)
        Me.cardItemsSold.Margin = New System.Windows.Forms.Padding(4)
        Me.cardItemsSold.Name = "cardItemsSold"
        Me.cardItemsSold.Size = New System.Drawing.Size(191, 98)
        Me.cardItemsSold.TabIndex = 3
        '
        'lblItemsSoldVal
        '
        Me.lblItemsSoldVal.AutoSize = True
        Me.lblItemsSoldVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsSoldVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblItemsSoldVal.Location = New System.Drawing.Point(73, 62)
        Me.lblItemsSoldVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemsSoldVal.Name = "lblItemsSoldVal"
        Me.lblItemsSoldVal.Size = New System.Drawing.Size(35, 41)
        Me.lblItemsSoldVal.TabIndex = 1
        Me.lblItemsSoldVal.Text = "0"
        '
        'lblItemsTitle
        '
        Me.lblItemsTitle.AutoSize = True
        Me.lblItemsTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblItemsTitle.Location = New System.Drawing.Point(37, 11)
        Me.lblItemsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemsTitle.Name = "lblItemsTitle"
        Me.lblItemsTitle.Size = New System.Drawing.Size(110, 23)
        Me.lblItemsTitle.TabIndex = 0
        Me.lblItemsTitle.Text = "ITEMS SOLD"
        '
        'cardTransactions
        '
        Me.cardTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardTransactions.Controls.Add(Me.lblTransactionsVal)
        Me.cardTransactions.Controls.Add(Me.lblTransTitle)
        Me.cardTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardTransactions.Location = New System.Drawing.Point(460, 15)
        Me.cardTransactions.Margin = New System.Windows.Forms.Padding(4)
        Me.cardTransactions.Name = "cardTransactions"
        Me.cardTransactions.Size = New System.Drawing.Size(188, 98)
        Me.cardTransactions.TabIndex = 2
        '
        'lblTransactionsVal
        '
        Me.lblTransactionsVal.AutoSize = True
        Me.lblTransactionsVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionsVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTransactionsVal.Location = New System.Drawing.Point(79, 62)
        Me.lblTransactionsVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactionsVal.Name = "lblTransactionsVal"
        Me.lblTransactionsVal.Size = New System.Drawing.Size(35, 41)
        Me.lblTransactionsVal.TabIndex = 1
        Me.lblTransactionsVal.Text = "0"
        '
        'lblTransTitle
        '
        Me.lblTransTitle.AutoSize = True
        Me.lblTransTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblTransTitle.Location = New System.Drawing.Point(25, 11)
        Me.lblTransTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransTitle.Name = "lblTransTitle"
        Me.lblTransTitle.Size = New System.Drawing.Size(140, 23)
        Me.lblTransTitle.TabIndex = 0
        Me.lblTransTitle.Text = "TRANSACTIONS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTodaySalesVal)
        Me.Panel1.Controls.Add(Me.lblSalesTitle)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(275, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 98)
        Me.Panel1.TabIndex = 0
        '
        'lblTodaySalesVal
        '
        Me.lblTodaySalesVal.AutoSize = True
        Me.lblTodaySalesVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaySalesVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTodaySalesVal.Location = New System.Drawing.Point(40, 62)
        Me.lblTodaySalesVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTodaySalesVal.Name = "lblTodaySalesVal"
        Me.lblTodaySalesVal.Size = New System.Drawing.Size(96, 41)
        Me.lblTodaySalesVal.TabIndex = 1
        Me.lblTodaySalesVal.Text = "₱0.00"
        '
        'lblSalesTitle
        '
        Me.lblSalesTitle.AutoSize = True
        Me.lblSalesTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblSalesTitle.Location = New System.Drawing.Point(28, 11)
        Me.lblSalesTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesTitle.Name = "lblSalesTitle"
        Me.lblSalesTitle.Size = New System.Drawing.Size(126, 23)
        Me.lblSalesTitle.TabIndex = 0
        Me.lblSalesTitle.Text = "TODAY'S SALE"
        '
        'pnlInventoryView
        '
        Me.pnlInventoryView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventoryView.Location = New System.Drawing.Point(0, 0)
        Me.pnlInventoryView.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlInventoryView.Name = "pnlInventoryView"
        Me.pnlInventoryView.Size = New System.Drawing.Size(1067, 554)
        Me.pnlInventoryView.TabIndex = 0
        '
        'pnlReportsView
        '
        Me.pnlReportsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReportsView.Location = New System.Drawing.Point(0, 0)
        Me.pnlReportsView.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlReportsView.Name = "pnlReportsView"
        Me.pnlReportsView.Size = New System.Drawing.Size(1067, 554)
        Me.pnlReportsView.TabIndex = 0
        '
        'pnlSettingsView
        '
        Me.pnlSettingsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsView.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsView.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSettingsView.Name = "pnlSettingsView"
        Me.pnlSettingsView.Size = New System.Drawing.Size(1067, 554)
        Me.pnlSettingsView.TabIndex = 0
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.Gold
        Me.pnlSidebar.Controls.Add(Me.lblTitleDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnSalaryDeduction)
        Me.pnlSidebar.Controls.Add(Me.btnInventory)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(267, 554)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblTitleDashboard
        '
        Me.lblTitleDashboard.AutoSize = True
        Me.lblTitleDashboard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDashboard.Location = New System.Drawing.Point(75, 11)
        Me.lblTitleDashboard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleDashboard.Name = "lblTitleDashboard"
        Me.lblTitleDashboard.Size = New System.Drawing.Size(192, 19)
        Me.lblTitleDashboard.TabIndex = 0
        Me.lblTitleDashboard.Text = "LYCEUM OF ALABANG"
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(24, 507)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(216, 28)
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(24, 471)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(216, 28)
        Me.btnSettings.TabIndex = 29
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(24, 137)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(216, 28)
        Me.btnReports.TabIndex = 28
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnSalaryDeduction
        '
        Me.btnSalaryDeduction.FlatAppearance.BorderSize = 0
        Me.btnSalaryDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalaryDeduction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalaryDeduction.Location = New System.Drawing.Point(0, 172)
        Me.btnSalaryDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalaryDeduction.Name = "btnSalaryDeduction"
        Me.btnSalaryDeduction.Size = New System.Drawing.Size(263, 31)
        Me.btnSalaryDeduction.TabIndex = 27
        Me.btnSalaryDeduction.Text = "Employee Salary Deduction"
        Me.btnSalaryDeduction.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(24, 101)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(216, 28)
        Me.btnInventory.TabIndex = 25
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Location = New System.Drawing.Point(24, 65)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(216, 28)
        Me.btnDashboard.TabIndex = 21
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'colEmpNo
        '
        Me.colEmpNo.HeaderText = "Employee No"
        Me.colEmpNo.MinimumWidth = 6
        Me.colEmpNo.Name = "colEmpNo"
        Me.colEmpNo.Width = 142
        '
        'colName
        '
        Me.colName.HeaderText = "Full Name"
        Me.colName.MinimumWidth = 6
        Me.colName.Name = "colName"
        Me.colName.Width = 117
        '
        'colPosition
        '
        Me.colPosition.HeaderText = "Position"
        Me.colPosition.MinimumWidth = 6
        Me.colPosition.Name = "colPosition"
        Me.colPosition.Width = 99
        '
        'colSDRemaining
        '
        Me.colSDRemaining.HeaderText = "SD Remaining"
        Me.colSDRemaining.MinimumWidth = 6
        Me.colSDRemaining.Name = "colSDRemaining"
        Me.colSDRemaining.Width = 147
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 86
        '
        'DeductionStatus
        '
        Me.DeductionStatus.HeaderText = "Deduction Status"
        Me.DeductionStatus.Items.AddRange(New Object() {"PENDING", "COMPLETE"})
        Me.DeductionStatus.MinimumWidth = 6
        Me.DeductionStatus.Name = "DeductionStatus"
        Me.DeductionStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeductionStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeductionStatus.Width = 170
        '
        'colPeriodStart
        '
        Me.colPeriodStart.HeaderText = "Period Start"
        Me.colPeriodStart.MinimumWidth = 6
        Me.colPeriodStart.Name = "colPeriodStart"
        Me.colPeriodStart.Width = 128
        '
        'colPeriodEnd
        '
        Me.colPeriodEnd.HeaderText = "Period End"
        Me.colPeriodEnd.MinimumWidth = 6
        Me.colPeriodEnd.Name = "colPeriodEnd"
        Me.colPeriodEnd.Width = 121
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlMainContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlMainContent.PerformLayout()
        Me.pnlSalaryDeductionView.ResumeLayout(False)
        Me.pnlSalaryDeductionView.PerformLayout()
        Me.pnlLimitReached.ResumeLayout(False)
        Me.pnlLimitReached.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlTotalEmployees.ResumeLayout(False)
        Me.pnlTotalEmployees.PerformLayout()
        CType(Me.dgvTextBoxColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowLayoutPanelActions.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlDashboardView.ResumeLayout(False)
        Me.pnlInventoryAlerts.ResumeLayout(False)
        Me.pnlInventoryAlerts.PerformLayout()
        Me.pnlRecentTransactions.ResumeLayout(False)
        Me.pnlRecentTransactions.PerformLayout()
        CType(Me.dgvRecentTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cardSalaryDeduction.ResumeLayout(False)
        Me.cardSalaryDeduction.PerformLayout()
        Me.cardItemsSold.ResumeLayout(False)
        Me.cardItemsSold.PerformLayout()
        Me.cardTransactions.ResumeLayout(False)
        Me.cardTransactions.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSalaryDeduction As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlDashboardView As Panel
    Friend WithEvents pnlInventoryView As Panel
    Friend WithEvents pnlSalaryDeductionView As Panel
    Friend WithEvents pnlReportsView As Panel
    Friend WithEvents pnlSettingsView As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSalesTitle As Label
    Friend WithEvents cardTransactions As Panel
    Friend WithEvents lblTransactionsVal As Label
    Friend WithEvents lblTransTitle As Label
    Friend WithEvents lblTodaySalesVal As Label
    Friend WithEvents cardSalaryDeduction As Panel
    Friend WithEvents lblSalaryDeductionVal As Label
    Friend WithEvents lblDeductTitle As Label
    Friend WithEvents cardItemsSold As Panel
    Friend WithEvents lblItemsSoldVal As Label
    Friend WithEvents lblItemsTitle As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents lblTitleDashboard As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents flowLayoutPanelActions As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbRoleFilter As ComboBox
    Friend WithEvents dgvTextBoxColumn As DataGridView
    Friend WithEvents pnlLimitReached As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlTotalEmployees As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTotalEmployees As Label
    Friend WithEvents lblTotalEmployeesCount As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents pnlPendingDeductions As Label
    Friend WithEvents lblLimitReachedTitle As Label
    Friend WithEvents lblLimitReachedCount As Label
    Friend WithEvents pnlRecentTransactions As Panel
    Friend WithEvents dgvRecentTransactions As DataGridView
    Friend WithEvents colTransactionNo As DataGridViewTextBoxColumn
    Friend WithEvents colTransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents colPaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colStatus1 As DataGridViewTextBoxColumn
    Friend WithEvents pnlInventoryAlerts As Panel
    Friend WithEvents btnViewAll As Label
    Friend WithEvents lblInventoryAlerts As Label
    Friend WithEvents colEmpNo As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colPosition As DataGridViewTextBoxColumn
    Friend WithEvents colSDRemaining As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents DeductionStatus As DataGridViewComboBoxColumn
    Friend WithEvents colPeriodStart As DataGridViewTextBoxColumn
    Friend WithEvents colPeriodEnd As DataGridViewTextBoxColumn
End Class
