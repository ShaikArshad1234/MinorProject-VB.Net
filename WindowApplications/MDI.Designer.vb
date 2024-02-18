<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollegeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndisciplineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentOffenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.BackupRestoreToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.StudentToolStripMenuItem, Me.CollegeToolStripMenuItem, Me.CourseToolStripMenuItem, Me.BatchToolStripMenuItem, Me.IndisciplineToolStripMenuItem, Me.SemesterToolStripMenuItem, Me.OffenceToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.MasterToolStripMenuItem.Text = "&Master "
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'CollegeToolStripMenuItem
        '
        Me.CollegeToolStripMenuItem.Name = "CollegeToolStripMenuItem"
        Me.CollegeToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.CollegeToolStripMenuItem.Text = "College"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.CourseToolStripMenuItem.Text = "Course"
        '
        'BatchToolStripMenuItem
        '
        Me.BatchToolStripMenuItem.Name = "BatchToolStripMenuItem"
        Me.BatchToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.BatchToolStripMenuItem.Text = "Batch"
        '
        'IndisciplineToolStripMenuItem
        '
        Me.IndisciplineToolStripMenuItem.Name = "IndisciplineToolStripMenuItem"
        Me.IndisciplineToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.IndisciplineToolStripMenuItem.Text = "Indiscipline"
        '
        'SemesterToolStripMenuItem
        '
        Me.SemesterToolStripMenuItem.Name = "SemesterToolStripMenuItem"
        Me.SemesterToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.SemesterToolStripMenuItem.Text = "Semester"
        '
        'OffenceToolStripMenuItem
        '
        Me.OffenceToolStripMenuItem.Name = "OffenceToolStripMenuItem"
        Me.OffenceToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.OffenceToolStripMenuItem.Text = "Offence"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentOffenceToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(117, 25)
        Me.TransactionToolStripMenuItem.Text = "&Transactions"
        '
        'StudentOffenceToolStripMenuItem
        '
        Me.StudentOffenceToolStripMenuItem.Name = "StudentOffenceToolStripMenuItem"
        Me.StudentOffenceToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.StudentOffenceToolStripMenuItem.Text = "Student Offence"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'BackupRestoreToolStripMenuItem
        '
        Me.BackupRestoreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupRestoreToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.BackupRestoreToolStripMenuItem.Name = "BackupRestoreToolStripMenuItem"
        Me.BackupRestoreToolStripMenuItem.Size = New System.Drawing.Size(139, 25)
        Me.BackupRestoreToolStripMenuItem.Text = "&Backup &Restore"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(51, 25)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(37, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT DISCIPLINE MANAGEMENT SYSTEM"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(544, 389)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.Text = "MDI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollegeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndisciplineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SemesterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentOffenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
