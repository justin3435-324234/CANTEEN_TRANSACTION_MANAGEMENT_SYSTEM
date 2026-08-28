<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.flowLayoutPanelActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEdit1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.flowLayoutPanelActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayoutPanelActions
        '
        Me.flowLayoutPanelActions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flowLayoutPanelActions.Controls.Add(Me.btnEdit1)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnAdd)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnView)
        Me.flowLayoutPanelActions.Controls.Add(Me.btnDelete)
        Me.flowLayoutPanelActions.Location = New System.Drawing.Point(220, 210)
        Me.flowLayoutPanelActions.Name = "flowLayoutPanelActions"
        Me.flowLayoutPanelActions.Size = New System.Drawing.Size(361, 31)
        Me.flowLayoutPanelActions.TabIndex = 2
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
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(90, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 25)
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
        Me.btnView.Location = New System.Drawing.Point(177, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(81, 25)
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
        Me.btnDelete.Location = New System.Drawing.Point(264, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 25)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.flowLayoutPanelActions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.flowLayoutPanelActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowLayoutPanelActions As FlowLayoutPanel
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
End Class
