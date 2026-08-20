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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.pnlMainContent.SuspendLayout()
        Me.pnlDashboardView.SuspendLayout()
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
        ChartArea4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer))
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Enabled = False
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(303, 111)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
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
        Me.btnReports.Location = New System.Drawing.Point(18, 258)
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
        Me.btnSalaryDeduction.Location = New System.Drawing.Point(3, 198)
        Me.btnSalaryDeduction.Name = "btnSalaryDeduction"
        Me.btnSalaryDeduction.Size = New System.Drawing.Size(197, 41)
        Me.btnSalaryDeduction.TabIndex = 27
        Me.btnSalaryDeduction.Text = "Employee SalaryDeduction Management"
        Me.btnSalaryDeduction.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(18, 169)
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
        Me.btnDashboard.Location = New System.Drawing.Point(18, 140)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(162, 23)
        Me.btnDashboard.TabIndex = 21
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
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
        Me.pnlSidebar.ResumeLayout(False)
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
End Class
