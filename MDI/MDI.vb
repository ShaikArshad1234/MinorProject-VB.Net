Public Class MDI

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Staff.Show()
    End Sub
    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Student.Show()
    End Sub

    Private Sub CollegeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegeToolStripMenuItem.Click
        College.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        Course.Show()
    End Sub

    Private Sub BatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchToolStripMenuItem.Click
        Batch.Show()
    End Sub
    Private Sub IndisciplineToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndisciplineToolStripMenuItem.Click
        Indiscipline.Show()
    End Sub
    
    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class