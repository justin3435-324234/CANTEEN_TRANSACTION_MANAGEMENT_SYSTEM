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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlDashboardView = New System.Windows.Forms.Panel()
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
        Me.pnlSalaryDeductionView = New System.Windows.Forms.Panel()
        Me.pnlReportsView = New System.Windows.Forms.Panel()
        Me.pnlSettingsView = New System.Windows.Forms.Panel()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSalaryDeduction = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.lblTitleDashboard = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flowLayoutPanelActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnEdit1 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cmbRoleFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvTextBoxColumn = New System.Windows.Forms.DataGridView()
        Me.colEmpNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSDRemaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductionStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pnlTotalEmployees = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlLimitReached = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTotalEmployees = New System.Windows.Forms.Label()
        Me.lblTotalEmployeesCount = New System.Windows.Forms.Label()
        Me.pnlPendingDeductions = New System.Windows.Forms.Label()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.lblLimitReachedTitle = New System.Windows.Forms.Label()
        Me.lblLimitReachedCount = New System.Windows.Forms.Label()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlDashboardView.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cardSalaryDeduction.SuspendLayout()
        Me.cardItemsSold.SuspendLayout()
        Me.cardTransactions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSalaryDeductionView.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.flowLayoutPanelActions.SuspendLayout()
        CType(Me.dgvTextBoxColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalEmployees.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlLimitReached.SuspendLayout()
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
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(800, 450)
        Me.pnlMainContent.TabIndex = 0
        '
        'pnlDashboardView
        '
        Me.pnlDashboardView.Controls.Add(Me.Chart1)
        Me.pnlDashboardView.Controls.Add(Me.cardSalaryDeduction)
        Me.pnlDashboardView.Controls.Add(Me.cardItemsSold)
        Me.pnlDashboardView.Controls.Add(Me.cardTransactions)
        Me.pnlDashboardView.Controls.Add(Me.Panel1)
        Me.pnlDashboardView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboardView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDashboardView.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboardView.Name = "pnlDashboardView"
        Me.pnlDashboardView.Size = New System.Drawing.Size(800, 450)
        Me.pnlDashboardView.TabIndex = 0
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(303, 111)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(378, 202)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'cardSalaryDeduction
        '
        Me.cardSalaryDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardSalaryDeduction.Controls.Add(Me.lblSalaryDeductionVal)
        Me.cardSalaryDeduction.Controls.Add(Me.lblDeductTitle)
        Me.cardSalaryDeduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardSalaryDeduction.Location = New System.Drawing.Point(641, 12)
        Me.cardSalaryDeduction.Name = "cardSalaryDeduction"
        Me.cardSalaryDeduction.Size = New System.Drawing.Size(143, 93)
        Me.cardSalaryDeduction.TabIndex = 4
        '
        'lblSalaryDeductionVal
        '
        Me.lblSalaryDeductionVal.AutoSize = True
        Me.lblSalaryDeductionVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryDeductionVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblSalaryDeductionVal.Location = New System.Drawing.Point(37, 50)
        Me.lblSalaryDeductionVal.Name = "lblSalaryDeductionVal"
        Me.lblSalaryDeductionVal.Size = New System.Drawing.Size(78, 32)
        Me.lblSalaryDeductionVal.TabIndex = 1
        Me.lblSalaryDeductionVal.Text = "₱0.00"
        '
        'lblDeductTitle
        '
        Me.lblDeductTitle.AutoSize = True
        Me.lblDeductTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeductTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblDeductTitle.Location = New System.Drawing.Point(20, 9)
        Me.lblDeductTitle.Name = "lblDeductTitle"
        Me.lblDeductTitle.Size = New System.Drawing.Size(95, 34)
        Me.lblDeductTitle.TabIndex = 0
        Me.lblDeductTitle.Text = "SALARY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " DEDUCTIONS"
        '
        'cardItemsSold
        '
        Me.cardItemsSold.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardItemsSold.Controls.Add(Me.lblItemsSoldVal)
        Me.cardItemsSold.Controls.Add(Me.lblItemsTitle)
        Me.cardItemsSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardItemsSold.Location = New System.Drawing.Point(492, 12)
        Me.cardItemsSold.Name = "cardItemsSold"
        Me.cardItemsSold.Size = New System.Drawing.Size(143, 93)
        Me.cardItemsSold.TabIndex = 3
        '
        'lblItemsSoldVal
        '
        Me.lblItemsSoldVal.AutoSize = True
        Me.lblItemsSoldVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsSoldVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblItemsSoldVal.Location = New System.Drawing.Point(55, 50)
        Me.lblItemsSoldVal.Name = "lblItemsSoldVal"
        Me.lblItemsSoldVal.Size = New System.Drawing.Size(28, 32)
        Me.lblItemsSoldVal.TabIndex = 1
        Me.lblItemsSoldVal.Text = "0"
        '
        'lblItemsTitle
        '
        Me.lblItemsTitle.AutoSize = True
        Me.lblItemsTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblItemsTitle.Location = New System.Drawing.Point(28, 9)
        Me.lblItemsTitle.Name = "lblItemsTitle"
        Me.lblItemsTitle.Size = New System.Drawing.Size(84, 17)
        Me.lblItemsTitle.TabIndex = 0
        Me.lblItemsTitle.Text = "ITEMS SOLD"
        '
        'cardTransactions
        '
        Me.cardTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardTransactions.Controls.Add(Me.lblTransactionsVal)
        Me.cardTransactions.Controls.Add(Me.lblTransTitle)
        Me.cardTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cardTransactions.Location = New System.Drawing.Point(345, 12)
        Me.cardTransactions.Name = "cardTransactions"
        Me.cardTransactions.Size = New System.Drawing.Size(141, 93)
        Me.cardTransactions.TabIndex = 2
        '
        'lblTransactionsVal
        '
        Me.lblTransactionsVal.AutoSize = True
        Me.lblTransactionsVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionsVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTransactionsVal.Location = New System.Drawing.Point(59, 50)
        Me.lblTransactionsVal.Name = "lblTransactionsVal"
        Me.lblTransactionsVal.Size = New System.Drawing.Size(28, 32)
        Me.lblTransactionsVal.TabIndex = 1
        Me.lblTransactionsVal.Text = "0"
        '
        'lblTransTitle
        '
        Me.lblTransTitle.AutoSize = True
        Me.lblTransTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblTransTitle.Location = New System.Drawing.Point(19, 9)
        Me.lblTransTitle.Name = "lblTransTitle"
        Me.lblTransTitle.Size = New System.Drawing.Size(106, 17)
        Me.lblTransTitle.TabIndex = 0
        Me.lblTransTitle.Text = "TRANSACTIONS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTodaySalesVal)
        Me.Panel1.Controls.Add(Me.lblSalesTitle)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(206, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 93)
        Me.Panel1.TabIndex = 0
        '
        'lblTodaySalesVal
        '
        Me.lblTodaySalesVal.AutoSize = True
        Me.lblTodaySalesVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaySalesVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTodaySalesVal.Location = New System.Drawing.Point(30, 50)
        Me.lblTodaySalesVal.Name = "lblTodaySalesVal"
        Me.lblTodaySalesVal.Size = New System.Drawing.Size(78, 32)
        Me.lblTodaySalesVal.TabIndex = 1
        Me.lblTodaySalesVal.Text = "₱0.00"
        '
        'lblSalesTitle
        '
        Me.lblSalesTitle.AutoSize = True
        Me.lblSalesTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblSalesTitle.Location = New System.Drawing.Point(21, 9)
        Me.lblSalesTitle.Name = "lblSalesTitle"
        Me.lblSalesTitle.Size = New System.Drawing.Size(97, 17)
        Me.lblSalesTitle.TabIndex = 0
        Me.lblSalesTitle.Text = "TODAY'S SALE"
        '
        'pnlInventoryView
        '
        Me.pnlInventoryView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventoryView.Location = New System.Drawing.Point(0, 0)
        Me.pnlInventoryView.Name = "pnlInventoryView"
        Me.pnlInventoryView.Size = New System.Drawing.Size(800, 450)
        Me.pnlInventoryView.TabIndex = 0
        '
        'pnlSalaryDeductionView
        '
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
        Me.pnlSalaryDeductionView.Name = "pnlSalaryDeductionView"
        Me.pnlSalaryDeductionView.Size = New System.Drawing.Size(800, 450)
        Me.pnlSalaryDeductionView.TabIndex = 0
        '
        'pnlReportsView
        '
        Me.pnlReportsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReportsView.Location = New System.Drawing.Point(0, 0)
        Me.pnlReportsView.Name = "pnlReportsView"
        Me.pnlReportsView.Size = New System.Drawing.Size(800, 450)
        Me.pnlReportsView.TabIndex = 0
        '
        'pnlSettingsView
        '
        Me.pnlSettingsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsView.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsView.Name = "pnlSettingsView"
        Me.pnlSettingsView.Size = New System.Drawing.Size(800, 450)
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
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 450)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(18, 412)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(162, 23)
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(18, 383)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(162, 23)
        Me.btnSettings.TabIndex = 29
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(18, 111)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(162, 23)
        Me.btnReports.TabIndex = 28
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnSalaryDeduction
        '
        Me.btnSalaryDeduction.FlatAppearance.BorderSize = 0
        Me.btnSalaryDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalaryDeduction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalaryDeduction.Location = New System.Drawing.Point(0, 140)
        Me.btnSalaryDeduction.Name = "btnSalaryDeduction"
        Me.btnSalaryDeduction.Size = New System.Drawing.Size(197, 25)
        Me.btnSalaryDeduction.TabIndex = 27
        Me.btnSalaryDeduction.Text = "Employee Salary Deduction"
        Me.btnSalaryDeduction.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(18, 82)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(162, 23)
        Me.btnInventory.TabIndex = 25
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Location = New System.Drawing.Point(18, 53)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(162, 23)
        Me.btnDashboard.TabIndex = 21
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'lblTitleDashboard
        '
        Me.lblTitleDashboard.AutoSize = True
        Me.lblTitleDashboard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDashboard.Location = New System.Drawing.Point(56, 9)
        Me.lblTitleDashboard.Name = "lblTitleDashboard"
        Me.lblTitleDashboard.Size = New System.Drawing.Size(141, 15)
        Me.lblTitleDashboard.TabIndex = 0
        Me.lblTitleDashboard.Text = "LYCEUM OF ALABANG"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(203, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(597, 51)
        Me.pnlHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE SALARY DEDUCTION MANAGEMENT"
        '
        'flowLayoutPanelActions
        '
        Me.flowLayoutPanelActions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flowLayoutPanelActions.Controls.Add(Me.btnEdit1)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnEdit)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnView)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnDelete)
        Me.flowLayoutPanelActions.Location = New System.Drawing.Point(221, 171)
        Me.flowLayoutPanelActions.Name = "flowLayoutPanelActions"
        Me.flowLayoutPanelActions.Size = New System.Drawing.Size(361, 31)
        Me.flowLayoutPanelActions.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(90, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(81, 25)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "ADD"
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnView.Location = New System.Drawing.Point(177, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(81, 25)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = False
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
        Me.btnEdit1.Location = New System.Drawing.Point(3, 3)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Size = New System.Drawing.Size(81, 25)
        Me.btnEdit1.TabIndex = 3
        Me.btnEdit1.Text = "EDIT"
        Me.btnEdit1.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(264, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 25)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cmbRoleFilter
        '
        Me.cmbRoleFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbRoleFilter.ForeColor = System.Drawing.Color.White
        Me.cmbRoleFilter.FormattingEnabled = True
        Me.cmbRoleFilter.Items.AddRange(New Object() {"All Roles ", "Teacher", "Staff"})
        Me.cmbRoleFilter.Location = New System.Drawing.Point(630, 160)
        Me.cmbRoleFilter.Name = "cmbRoleFilter"
        Me.cmbRoleFilter.Size = New System.Drawing.Size(154, 21)
        Me.cmbRoleFilter.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.Location = New System.Drawing.Point(630, 187)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 20)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = "🔍 Search employee name or ID..."
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
        Me.dgvTextBoxColumn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmpNo, Me.colName, Me.colPosition, Me.colSDRemaining, Me.colStatus, Me.DeductionStatus})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTextBoxColumn.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvTextBoxColumn.Location = New System.Drawing.Point(213, 213)
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
        Me.dgvTextBoxColumn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTextBoxColumn.Size = New System.Drawing.Size(584, 225)
        Me.dgvTextBoxColumn.TabIndex = 5
        '
        'colEmpNo
        '
        Me.colEmpNo.HeaderText = "Employee No"
        Me.colEmpNo.Name = "colEmpNo"
        Me.colEmpNo.Width = 114
        '
        'colName
        '
        Me.colName.HeaderText = "Full Name"
        Me.colName.Name = "colName"
        Me.colName.Width = 94
        '
        'colPosition
        '
        Me.colPosition.HeaderText = "Position"
        Me.colPosition.Name = "colPosition"
        Me.colPosition.Width = 82
        '
        'colSDRemaining
        '
        Me.colSDRemaining.HeaderText = "SD Remaining"
        Me.colSDRemaining.Name = "colSDRemaining"
        Me.colSDRemaining.Width = 117
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 71
        '
        'DeductionStatus
        '
        Me.DeductionStatus.HeaderText = "Deduction Status"
        Me.DeductionStatus.Items.AddRange(New Object() {"PENDING", "COMPLETE"})
        Me.DeductionStatus.Name = "DeductionStatus"
        Me.DeductionStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeductionStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeductionStatus.Width = 137
        '
        'pnlTotalEmployees
        '
        Me.pnlTotalEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTotalEmployees.Controls.Add(Me.lblTotalEmployeesCount)
        Me.pnlTotalEmployees.Controls.Add(Me.lblTotalEmployees)
        Me.pnlTotalEmployees.Location = New System.Drawing.Point(225, 61)
        Me.pnlTotalEmployees.Name = "pnlTotalEmployees"
        Me.pnlTotalEmployees.Size = New System.Drawing.Size(167, 84)
        Me.pnlTotalEmployees.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblPendingCount)
        Me.Panel3.Controls.Add(Me.pnlPendingDeductions)
        Me.Panel3.Location = New System.Drawing.Point(415, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(167, 84)
        Me.Panel3.TabIndex = 7
        '
        'pnlLimitReached
        '
        Me.pnlLimitReached.Controls.Add(Me.lblLimitReachedCount)
        Me.pnlLimitReached.Controls.Add(Me.lblLimitReachedTitle)
        Me.pnlLimitReached.Location = New System.Drawing.Point(602, 61)
        Me.pnlLimitReached.Name = "pnlLimitReached"
        Me.pnlLimitReached.Size = New System.Drawing.Size(167, 84)
        Me.pnlLimitReached.TabIndex = 7
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(7, 25)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(234, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manage employees and salary deductions  "
        '
        'lblTotalEmployees
        '
        Me.lblTotalEmployees.AutoSize = True
        Me.lblTotalEmployees.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployees.ForeColor = System.Drawing.Color.White
        Me.lblTotalEmployees.Location = New System.Drawing.Point(13, 11)
        Me.lblTotalEmployees.Name = "lblTotalEmployees"
        Me.lblTotalEmployees.Size = New System.Drawing.Size(141, 20)
        Me.lblTotalEmployees.TabIndex = 0
        Me.lblTotalEmployees.Text = "TOTAL EMPLOYEES"
        '
        'lblTotalEmployeesCount
        '
        Me.lblTotalEmployeesCount.AutoSize = True
        Me.lblTotalEmployeesCount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployeesCount.ForeColor = System.Drawing.Color.Gold
        Me.lblTotalEmployeesCount.Location = New System.Drawing.Point(64, 42)
        Me.lblTotalEmployeesCount.Name = "lblTotalEmployeesCount"
        Me.lblTotalEmployeesCount.Size = New System.Drawing.Size(25, 30)
        Me.lblTotalEmployeesCount.TabIndex = 1
        Me.lblTotalEmployeesCount.Text = "0"
        '
        'pnlPendingDeductions
        '
        Me.pnlPendingDeductions.AutoSize = True
        Me.pnlPendingDeductions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPendingDeductions.ForeColor = System.Drawing.Color.White
        Me.pnlPendingDeductions.Location = New System.Drawing.Point(11, 14)
        Me.pnlPendingDeductions.Name = "pnlPendingDeductions"
        Me.pnlPendingDeductions.Size = New System.Drawing.Size(153, 17)
        Me.pnlPendingDeductions.TabIndex = 2
        Me.pnlPendingDeductions.Text = "PENDING DEDUCTIONS"
        '
        'lblPendingCount
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCount.ForeColor = System.Drawing.Color.Gold
        Me.lblPendingCount.Location = New System.Drawing.Point(65, 42)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(25, 30)
        Me.lblPendingCount.TabIndex = 3
        Me.lblPendingCount.Text = "0"
        '
        'lblLimitReachedTitle
        '
        Me.lblLimitReachedTitle.AutoSize = True
        Me.lblLimitReachedTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimitReachedTitle.ForeColor = System.Drawing.Color.White
        Me.lblLimitReachedTitle.Location = New System.Drawing.Point(24, 11)
        Me.lblLimitReachedTitle.Name = "lblLimitReachedTitle"
        Me.lblLimitReachedTitle.Size = New System.Drawing.Size(122, 20)
        Me.lblLimitReachedTitle.TabIndex = 0
        Me.lblLimitReachedTitle.Text = "LIMIT REACHED"
        '
        'lblLimitReachedCount
        '
        Me.lblLimitReachedCount.AutoSize = True
        Me.lblLimitReachedCount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimitReachedCount.ForeColor = System.Drawing.Color.Gold
        Me.lblLimitReachedCount.Location = New System.Drawing.Point(67, 42)
        Me.lblLimitReachedCount.Name = "lblLimitReachedCount"
        Me.lblLimitReachedCount.Size = New System.Drawing.Size(25, 30)
        Me.lblLimitReachedCount.TabIndex = 4
        Me.lblLimitReachedCount.Text = "0"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlMainContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlDashboardView.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cardSalaryDeduction.ResumeLayout(False)
        Me.cardSalaryDeduction.PerformLayout()
        Me.cardItemsSold.ResumeLayout(False)
        Me.cardItemsSold.PerformLayout()
        Me.cardTransactions.ResumeLayout(False)
        Me.cardTransactions.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSalaryDeductionView.ResumeLayout(False)
        Me.pnlSalaryDeductionView.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.flowLayoutPanelActions.ResumeLayout(False)
        CType(Me.dgvTextBoxColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalEmployees.ResumeLayout(False)
        Me.pnlTotalEmployees.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlLimitReached.ResumeLayout(False)
        Me.pnlLimitReached.PerformLayout()
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
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbRoleFilter As ComboBox
    Friend WithEvents dgvTextBoxColumn As DataGridView
    Friend WithEvents colEmpNo As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colPosition As DataGridViewTextBoxColumn
    Friend WithEvents colSDRemaining As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents DeductionStatus As DataGridViewComboBoxColumn
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
End Class
