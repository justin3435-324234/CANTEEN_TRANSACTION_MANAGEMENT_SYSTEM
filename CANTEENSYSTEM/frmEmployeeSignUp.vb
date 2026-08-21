Imports System.Windows.Forms
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class frmEmployeeSignUp
    Inherits Form

    Public Property EmployeeNumber As String = ""
    Public Property FullName As String = ""
    Public Property Position As String = ""
    Public Property EmployeeType As String = ""

    Friend WithEvents txtEmpNo As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents txtEmployeeType As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblEmpNo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmpType As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblEmpNoPrefix As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.lblEmpNoPrefix = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmpType = New System.Windows.Forms.Label()
        Me.txtEmployeeType = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(70, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(376, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "NEW EMPLOYEE REGISTRATION"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(70, 55)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(297, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Enter employee details for salary deduction"
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpNo.ForeColor = System.Drawing.Color.White
        Me.lblEmpNo.Location = New System.Drawing.Point(70, 100)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(254, 23)
        Me.lblEmpNo.TabIndex = 2
        Me.lblEmpNo.Text = "Employee Number (TCH-XXX):"
        '
        'lblEmpNoPrefix
        '
        Me.lblEmpNoPrefix.AutoSize = True
        Me.lblEmpNoPrefix.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpNoPrefix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblEmpNoPrefix.Location = New System.Drawing.Point(70, 128)
        Me.lblEmpNoPrefix.Name = "lblEmpNoPrefix"
        Me.lblEmpNoPrefix.Size = New System.Drawing.Size(57, 25)
        Me.lblEmpNoPrefix.TabIndex = 3
        Me.lblEmpNoPrefix.Text = "TCH-"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEmpNo.Location = New System.Drawing.Point(115, 125)
        Me.txtEmpNo.MaxLength = 3
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(80, 32)
        Me.txtEmpNo.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(70, 180)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(96, 23)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Full Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtName.Location = New System.Drawing.Point(70, 205)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 32)
        Me.txtName.TabIndex = 7
        '
        'lblEmpType
        '
        Me.lblEmpType.AutoSize = True
        Me.lblEmpType.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpType.ForeColor = System.Drawing.Color.White
        Me.lblEmpType.Location = New System.Drawing.Point(70, 245)
        Me.lblEmpType.Name = "lblEmpType"
        Me.lblEmpType.Size = New System.Drawing.Size(136, 23)
        Me.lblEmpType.TabIndex = 8
        Me.lblEmpType.Text = "Employee Type:"
        '
        'txtEmployeeType
        '
        Me.txtEmployeeType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEmployeeType.Location = New System.Drawing.Point(70, 270)
        Me.txtEmployeeType.Name = "txtEmployeeType"
        Me.txtEmployeeType.Size = New System.Drawing.Size(280, 32)
        Me.txtEmployeeType.TabIndex = 9
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(70, 310)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(78, 23)
        Me.lblPosition.TabIndex = 10
        Me.lblPosition.Text = "Position:"
        '
        'cmbPosition
        '
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbPosition.Items.AddRange(New Object() {"Teacher", "Staff", "Admin", "Security", "Maintenance", "Canteen Staff", "Librarian", "Nurse", "Guidance Counselor", "IT Personnel"})
        Me.cmbPosition.Location = New System.Drawing.Point(70, 335)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(280, 33)
        Me.cmbPosition.TabIndex = 11
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(70, 385)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(130, 40)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "REGISTER"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(220, 385)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEmployeeSignUp
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Controls.Add(Me.lblEmpNoPrefix)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmpType)
        Me.Controls.Add(Me.txtEmployeeType)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Sign Up - Salary Deduction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Only allow digits
    Private Sub txtEmpNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Auto-format to 3 digits with leading zeros
    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        If txtEmpNo.Text.Length > 0 AndAlso Not Char.IsDigit(txtEmpNo.Text.Last()) Then
            txtEmpNo.Text = Regex.Replace(txtEmpNo.Text, "\D", "")
            txtEmpNo.SelectionStart = txtEmpNo.Text.Length
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim empNoDigits As String = txtEmpNo.Text.Trim()

        ' Validate employee number
        If empNoDigits.Length <> 3 Then
            MessageBox.Show("Employee number must be exactly 3 digits (e.g., 001, 002).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmpNo.Focus()
            Exit Sub
        End If

        ' Validate sequential numbering
        If Not IsValidSequence(empNoDigits) Then
            Exit Sub
        End If

        ' Validate name
        If String.IsNullOrWhiteSpace(txtName.Text.Trim()) Then
            MessageBox.Show("Full Name is required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Exit Sub
        End If

        ' Validate employee type
        If String.IsNullOrWhiteSpace(txtEmployeeType.Text.Trim()) Then
            MessageBox.Show("Employee Type is required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmployeeType.Focus()
            Exit Sub
        End If

        ' Set properties with TCH- prefix
        EmployeeNumber = "TCH-" & empNoDigits
        FullName = txtName.Text.Trim()
        EmployeeType = txtEmployeeType.Text.Trim()
        If cmbPosition.SelectedItem IsNot Nothing Then Position = cmbPosition.SelectedItem.ToString()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Function IsValidSequence(empNoDigits As String) As Boolean
        Dim num As Integer
        If Not Integer.TryParse(empNoDigits, num) Then
            MessageBox.Show("Invalid number format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if already exists in SalesTracker
        For Each emp As SalesTracker.Employee In SalesTracker.Employees
            Dim existingNum As String = emp.EmpNo
            If existingNum.StartsWith("TCH-") Then
                Dim existingDigits As String = existingNum.Substring(4)
                If existingDigits = empNoDigits Then
                    MessageBox.Show("Employee number TCH-" & empNoDigits & " already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEmpNo.Focus()
                    Return False
                End If
            End If
        Next

        ' Find highest existing number
        Dim maxNum As Integer = 0
        For Each emp As SalesTracker.Employee In SalesTracker.Employees
            Dim existingNum As String = emp.EmpNo
            If existingNum.StartsWith("TCH-") Then
                Dim existingDigits As String = existingNum.Substring(4)
                Dim existingInt As Integer
                If Integer.TryParse(existingDigits, existingInt) Then
                    If existingInt > maxNum Then maxNum = existingInt
                End If
            End If
        Next

        ' Must be next sequential number
        If maxNum > 0 AndAlso num <> maxNum + 1 Then
            Dim expectedNext As String = (maxNum + 1).ToString("D3")
            MessageBox.Show("Employee numbers must be sequential. Next available number is TCH-" & expectedNext & ".", "Invalid Sequence", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmpNo.Focus()
            Return False
        End If

        ' If no employees yet, must start with 001
        If maxNum = 0 AndAlso num <> 1 Then
            MessageBox.Show("First employee must be TCH-001.", "Invalid Sequence", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmpNo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class