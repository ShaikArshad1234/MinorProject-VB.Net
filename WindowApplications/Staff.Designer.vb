<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNewStaffName = New System.Windows.Forms.Label()
        Me.txtNewStaff = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.txtCollege = New System.Windows.Forms.TextBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.Erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtNewStaffName = New System.Windows.Forms.TextBox()
        CType(Me.Erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(188, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Master"
        '
        'lblNewStaffName
        '
        Me.lblNewStaffName.AutoSize = True
        Me.lblNewStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewStaffName.Location = New System.Drawing.Point(116, 84)
        Me.lblNewStaffName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNewStaffName.Name = "lblNewStaffName"
        Me.lblNewStaffName.Size = New System.Drawing.Size(70, 20)
        Me.lblNewStaffName.TabIndex = 1
        Me.lblNewStaffName.Text = "Staff Id"
        '
        'txtNewStaff
        '
        Me.txtNewStaff.AutoSize = True
        Me.txtNewStaff.Location = New System.Drawing.Point(117, 129)
        Me.txtNewStaff.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtNewStaff.Name = "txtNewStaff"
        Me.txtNewStaff.Size = New System.Drawing.Size(100, 20)
        Me.txtNewStaff.TabIndex = 2
        Me.txtNewStaff.Text = "Staff Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "College"
        '
        'txtStaffId
        '
        Me.txtStaffId.Location = New System.Drawing.Point(248, 81)
        Me.txtStaffId.Margin = New System.Windows.Forms.Padding(5)
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.Size = New System.Drawing.Size(164, 26)
        Me.txtStaffId.TabIndex = 1
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(248, 129)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(164, 26)
        Me.txtStaffName.TabIndex = 2
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(248, 185)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(164, 26)
        Me.txtDepartment.TabIndex = 3
        '
        'txtCollege
        '
        Me.txtCollege.Location = New System.Drawing.Point(248, 239)
        Me.txtCollege.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCollege.Name = "txtCollege"
        Me.txtCollege.Size = New System.Drawing.Size(164, 26)
        Me.txtCollege.TabIndex = 4
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.Location = New System.Drawing.Point(126, 296)
        Me.btnADD.Margin = New System.Windows.Forms.Padding(5)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(95, 35)
        Me.btnADD.TabIndex = 9
        Me.btnADD.Text = "&Add"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPDATE.Location = New System.Drawing.Point(278, 296)
        Me.btnUPDATE.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(91, 35)
        Me.btnUPDATE.TabIndex = 10
        Me.btnUPDATE.Text = "&Update"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.Location = New System.Drawing.Point(278, 358)
        Me.btnDELETE.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(91, 35)
        Me.btnDELETE.TabIndex = 11
        Me.btnDELETE.Text = "&Delete"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnCLEAR
        '
        Me.btnCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.Location = New System.Drawing.Point(126, 358)
        Me.btnCLEAR.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(95, 38)
        Me.btnCLEAR.TabIndex = 12
        Me.btnCLEAR.Text = "&Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnEXIT
        '
        Me.btnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.Location = New System.Drawing.Point(405, 361)
        Me.btnEXIT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(88, 35)
        Me.btnEXIT.TabIndex = 13
        Me.btnEXIT.Text = "E&xit"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'Erp
        '
        Me.Erp.ContainerControl = Me
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(405, 296)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 35)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtNewStaffName
        '
        Me.txtNewStaffName.Location = New System.Drawing.Point(442, 129)
        Me.txtNewStaffName.Name = "txtNewStaffName"
        Me.txtNewStaffName.Size = New System.Drawing.Size(123, 26)
        Me.txtNewStaffName.TabIndex = 5
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 409)
        Me.Controls.Add(Me.txtNewStaffName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.btnDELETE)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.txtCollege)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtStaffId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewStaff)
        Me.Controls.Add(Me.lblNewStaffName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.Erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNewStaffName As System.Windows.Forms.Label
    Friend WithEvents txtNewStaff As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStaffId As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents txtCollege As System.Windows.Forms.TextBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents Erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtNewStaffName As System.Windows.Forms.TextBox
End Class
