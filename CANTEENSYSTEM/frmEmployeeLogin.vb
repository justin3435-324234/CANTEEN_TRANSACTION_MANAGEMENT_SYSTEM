Imports System.Windows.Forms
Imports System.Drawing

Public Class frmEmployeeLogin
    Inherits Form

    Public Property EmployeeNumber As String = ""
    Public Property EmployeeName As String = ""
    Public Property EmployeePosition As String = ""
    Public Property EmployeeSDRemaining As Decimal = 0
    Public Property EmployeeStatus As String = ""
    Public Property EmployeeDeductionStatus As String = ""
    Public Property IsValidLogin As Boolean = False

    Friend WithEvents txtEmpNo As TextBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblEmpNo As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents btnCancel As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(130, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(215, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "EMPLOYEE LOGIN"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(80, 55)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(288, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Enter your credentials for salary deduction"
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpNo.ForeColor = System.Drawing.Color.White
        Me.lblEmpNo.Location = New System.Drawing.Point(60, 100)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(308, 23)
        Me.lblEmpNo.TabIndex = 2
        Me.lblEmpNo.Text = "Employee Number (001 or TCH-001):"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEmpNo.Location = New System.Drawing.Point(60, 125)
        Me.txtEmpNo.MaxLength = 7
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(280, 32)
        Me.txtEmpNo.TabIndex = 3
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPin.ForeColor = System.Drawing.Color.White
        Me.lblPin.Location = New System.Drawing.Point(60, 165)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(106, 23)
        Me.lblPin.TabIndex = 5
        Me.lblPin.Text = "4-Digit PIN:"
        '
        'txtPin
        '
        Me.txtPin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPin.Location = New System.Drawing.Point(60, 190)
        Me.txtPin.MaxLength = 4
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.Size = New System.Drawing.Size(280, 32)
        Me.txtPin.TabIndex = 6
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(60, 245)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(130, 40)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(210, 245)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEmployeeLogin
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 332)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCancel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Login - Salary Deduction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        Dim text As String = txtEmpNo.Text.Trim().ToUpper()

        ' Auto-format: if user types only digits, add TCH- prefix
        If text.Length > 0 AndAlso text.Length <= 3 AndAlso IsNumeric(text) Then
            ' Don't auto-format while typing, just allow
        ElseIf text.Length = 3 AndAlso IsNumeric(text) Then
            ' Auto-complete to TCH-XXX
            txtEmpNo.Text = "TCH-" & text
            txtEmpNo.SelectionStart = txtEmpNo.Text.Length
        ElseIf text.StartsWith("TCH-") AndAlso text.Length > 4 Then
            ' Ensure only digits after TCH-
            Dim afterPrefix As String = text.Substring(4)
            Dim digitsOnly As String = New String(afterPrefix.Where(Function(c) Char.IsDigit(c)).ToArray())
            If digitsOnly.Length > 3 Then digitsOnly = digitsOnly.Substring(0, 3)
            txtEmpNo.Text = "TCH-" & digitsOnly
            txtEmpNo.SelectionStart = txtEmpNo.Text.Length
        End If
    End Sub

    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim empNoInput As String = txtEmpNo.Text.Trim().ToUpper()
        Dim pin As String = txtPin.Text.Trim()

        ' Normalize input: accept "001" or "TCH-001"
        Dim normalizedEmpNo As String = NormalizeEmployeeNumber(empNoInput)
        If String.IsNullOrEmpty(normalizedEmpNo) Then
            MessageBox.Show("Please enter a valid Employee Number (e.g., 001 or TCH-001).", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmpNo.Focus()
            Exit Sub
        End If

        ' Validate PIN
        If String.IsNullOrWhiteSpace(pin) OrElse pin.Length <> 4 OrElse Not IsNumeric(pin) Then
            MessageBox.Show("Please enter a valid 4-digit PIN.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPin.Focus()
            Exit Sub
        End If

        ' Validate against SalesTracker employees
        For Each emp As SalesTracker.Employee In SalesTracker.Employees
            If emp.EmpNo.Equals(normalizedEmpNo, StringComparison.OrdinalIgnoreCase) Then
                EmployeeNumber = emp.EmpNo
                EmployeeName = emp.FullName
                EmployeePosition = emp.Position
                EmployeeSDRemaining = emp.SDRemaining
                EmployeeStatus = emp.Status
                EmployeeDeductionStatus = emp.DeductionStatus
                IsValidLogin = True
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Exit Sub
            End If
        Next

        ' Not found
        MessageBox.Show("Employee not found. Please check your Employee Number.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtEmpNo.Focus()
        txtEmpNo.SelectAll()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function NormalizeEmployeeNumber(input As String) As String
        If String.IsNullOrWhiteSpace(input) Then Return ""

        Dim upperInput As String = input.Trim().ToUpper()

        ' If already in TCH-XXX format
        If upperInput.StartsWith("TCH-") Then
            Dim suffix As String = upperInput.Substring(4)
            If suffix.Length = 3 AndAlso IsNumeric(suffix) Then
                Return "TCH-" & suffix
            End If
            Return ""
        End If

        ' If just 3 digits
        If upperInput.Length = 3 AndAlso IsNumeric(upperInput) Then
            Return "TCH-" & upperInput
        End If

        Return ""
    End Function
End Class