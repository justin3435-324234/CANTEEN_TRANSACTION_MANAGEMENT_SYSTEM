Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard

    Private userRole As String

    Public Sub New(role As String)
        InitializeComponent()
        Me.userRole = role
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Force main view visibility
            pnlDashboardView.Visible = True
            pnlDashboardView.BringToFront()

            ' 2. Add emojis to sidebar button text
            AddEmojisToSidebar()

            ' 3. Dynamically attach gold borders to summary cards
            For Each ctrl As Control In pnlDashboardView.Controls
                If TypeOf ctrl Is Panel Then
                    AddHandler ctrl.Paint, AddressOf DrawCardGoldBorders
                End If
            Next

            ' 4. Apply modern chart styling
            StyleNativeDashboardChart()
            RefreshDashboardStats()

            ' 5. Set default active view
            SwitchView(pnlDashboardView, btnDashboard)

        Catch ex As Exception
            MessageBox.Show("Dashboard Load Error: " & ex.Message, "Design Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub frmDashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        RefreshDashboardStats()
    End Sub

    Private Sub RefreshDashboardStats()
        lblTodaySalesVal.Text = "₱" & SalesTracker.TotalSales.ToString("N2")
        lblItemsSoldVal.Text = SalesTracker.ItemsSold.ToString()
        UpdateDashboardChart()
    End Sub

    ' --- SIDEBAR EMOJI TEXT ASSIGNMENT ---
    Private Sub AddEmojisToSidebar()
        If btnDashboard IsNot Nothing Then btnDashboard.Text = "📊  Dashboard"



        If btnInventory IsNot Nothing Then btnInventory.Text = "📋  Inventory"
        If btnSalaryDeduction IsNot Nothing Then btnSalaryDeduction.Text = "💳 Employee Salary Deduction"
        If btnReports IsNot Nothing Then btnReports.Text = "📈  Reports"
        If btnSettings IsNot Nothing Then btnSettings.Text = "⚙️  Settings"
        If btnLogout IsNot Nothing Then btnLogout.Text = "🚪  Logout"
    End Sub

    ' --- SIDEBAR BUTTON CLICK HANDLERS ---
    Private Sub NavigationButtons_Click(sender As Object, e As EventArgs) Handles _
        btnDashboard.Click,
        btnInventory.Click,
        btnSalaryDeduction.Click,
        btnReports.Click,
        btnSettings.Click,
        btnLogout.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn Is Nothing Then Exit Sub

        ' Logout action
        If btn Is btnLogout Then
            Dim confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                Dim loginForm As New frmLogin()
                loginForm.Show()
                Me.Close()
            End If
            Exit Sub
        End If

        ' View switching
        Select Case btn.Name
            Case "btnDashboard"
                SwitchView(pnlDashboardView, btn)



            Case "btnInventory"
                If pnlInventoryView IsNot Nothing Then SwitchView(pnlInventoryView, btn)
            Case "btnSalaryDeduction"
                If pnlSalaryDeductionView IsNot Nothing Then SwitchView(pnlSalaryDeductionView, btn)
            Case "btnReports"
                If pnlReportsView IsNot Nothing Then SwitchView(pnlReportsView, btn)
            Case "btnSettings"
                If pnlSettingsView IsNot Nothing Then SwitchView(pnlSettingsView, btn)
        End Select
    End Sub

    ' --- VIEW SWITCHING ENGINE ---
    Private Sub SwitchView(activePanel As Panel, activeBtn As Button)
        If activePanel Is Nothing Then Exit Sub

        For Each ctrl As Control In pnlMainContent.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Visible = False
            End If
        Next

        activePanel.Visible = True
        activePanel.BringToFront()

        ' Highlight active button
        ResetSidebarButtonColors()
        If activeBtn IsNot Nothing Then
            activeBtn.BackColor = ColorTranslator.FromHtml("#102A5C") ' Dark Navy highlight
            activeBtn.ForeColor = ColorTranslator.FromHtml("#F5C21B") ' Gold text highlight
        End If
    End Sub

    Private Sub ResetSidebarButtonColors()
        Dim sidebarButtons As Button() = {
            btnDashboard,
            btnInventory, btnSalaryDeduction,
            btnReports, btnSettings
        }

        For Each btn In sidebarButtons
            If btn IsNot Nothing Then
                btn.BackColor = ColorTranslator.FromHtml("#F5C21B") ' Original Gold
                btn.ForeColor = Color.Black
            End If
        Next
    End Sub

    ' --- NATIVE CHART STYLING ---
    Private Sub StyleNativeDashboardChart()
        If Chart1 Is Nothing Then Exit Sub

        Chart1.BackColor = ColorTranslator.FromHtml("#102A5C")
        If Chart1.Legends.Count > 0 Then Chart1.Legends(0).Enabled = False

        Dim ca As ChartArea = Chart1.ChartAreas(0)
        ca.BackColor = ColorTranslator.FromHtml("#102A5C")

        ca.AxisX.LabelStyle.ForeColor = Color.White
        ca.AxisY.LabelStyle.ForeColor = Color.White
        ca.AxisX.LineColor = ColorTranslator.FromHtml("#1E3A70")
        ca.AxisY.LineColor = ColorTranslator.FromHtml("#1E3A70")
        ca.AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#1E3A70")
        ca.AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#1E3A70")
        ca.AxisX.Interval = 1
        ca.AxisX.Minimum = 1
        ca.AxisX.Maximum = 8

        Chart1.Series.Clear()

        ' Gold Sales Trend
        Dim seriesGold As New Series("Sales") With {
            .ChartType = SeriesChartType.SplineArea,
            .Color = Color.FromArgb(120, 245, 194, 27),
            .BorderColor = ColorTranslator.FromHtml("#F5C21B"),
            .BorderWidth = 2
        }

        ' Cyan Transaction Trend
        Dim seriesCyan As New Series("Transactions") With {
            .ChartType = SeriesChartType.SplineArea,
            .Color = Color.FromArgb(100, 0, 210, 255),
            .BorderColor = ColorTranslator.FromHtml("#00D2FF"),
            .BorderWidth = 2
        }

        Chart1.Series.Add(seriesGold)
        Chart1.Series.Add(seriesCyan)
    End Sub

    ' --- UPDATE CHART WITH TRACKED SALES (rolling window of 8) ---
    Private Sub UpdateDashboardChart()
        If Chart1 Is Nothing Then Exit Sub
        If Chart1.Series.Count < 2 Then Exit Sub

        Dim slots As Integer = 8
        Dim gold(8) As Double
        Dim cyan(8) As Double

        Dim saleCount As Integer = SalesTracker.SaleAmounts.Count
        For i As Integer = 0 To slots - 1
            Dim idx As Integer = saleCount - slots + i
            If idx >= 0 AndAlso idx < saleCount Then
                gold(i) = CDbl(SalesTracker.SaleAmounts(idx))
                cyan(i) = CDbl(SalesTracker.TransactionItems(idx))
            Else
                gold(i) = 0
                cyan(i) = 0
            End If
        Next

        Chart1.Series("Sales").Points.DataBindY(gold)
        Chart1.Series("Transactions").Points.DataBindY(cyan)

        Chart1.Invalidate()
    End Sub

    ' --- CARD GOLD BORDER DRAWING ---
    Private Sub DrawCardGoldBorders(sender As Object, e As PaintEventArgs)
        Dim pnl As Panel = TryCast(sender, Panel)
        If pnl Is Nothing Then Exit Sub

        If pnl.Height < 150 Then
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Using goldPen As New Pen(ColorTranslator.FromHtml("#F5C21B"), 2)
                e.Graphics.DrawRectangle(goldPen, 1, 1, pnl.Width - 3, pnl.Height - 3)
            End Using
        End If
    End Sub

End Class