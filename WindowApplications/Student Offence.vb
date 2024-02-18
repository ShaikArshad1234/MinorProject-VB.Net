Public Class Transaction
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        cbStudent.Text = ""
        cbCourse.Text = ""
        cbBatch.Text = ""
        cbCollege.Text = ""
        cbOffence.Text = ""
        cbSemester.Text = ""
        cbStaff.Text = ""
        cbIndiscipline.Text = ""
        cbRemark.Text = ""
        cbStudent.Enabled = True
        cbCourse.Enabled = True
        cbBatch.Enabled = True
        cbCollege.Enabled = True
        cbOffence.Enabled = True
        cbSemester.Enabled = True
        cbStaff.Enabled = True
        cbIndiscipline.Enabled = True
        cbRemark.Enabled = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSearch.Enabled = False
        If cbStudent.Text <> "" And IsNumeric(cbStudent.Text) Then
            Me.Erp.SetError(Me.cbStudent, String.Empty)
            If cbCourse.Text <> "" Then
                Me.Erp.SetError(Me.cbCourse, String.Empty)
                If cbBatch.Text <> "" Then
                    Me.Erp.SetError(Me.cbBatch, String.Empty)
                    If cbCollege.Text <> "" Then
                        Me.Erp.SetError(Me.cbCollege, String.Empty)
                        If cbOffence.Text <> "" Then
                            Me.Erp.SetError(Me.cbOffence, String.Empty)
                            If cbSemester.Text <> "" Then
                                Me.Erp.SetError(Me.cbSemester, String.Empty)
                                If cbStaff.Text <> "" Then
                                    Me.Erp.SetError(Me.cbStaff, String.Empty)
                                    If cbIndiscipline.Text <> "" Then
                                        Me.Erp.SetError(Me.cbIndiscipline, String.Empty)
                                        If cbRemark.Text <> "" Then
                                            Me.Erp.SetError(Me.cbRemark, String.Empty)
                                            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                                            rs.Open("select * from StudentOffence where stdId=' " + cbStudent.Text + " '", conn)
                                            If rs.EOF Then
                                                conn.Execute("insert into StudentOffence values(' " + cbStudent.Text + " ',' " + cbCourse.Text + " ','" + cbBatch.Text + " ',' " + cbCollege.Text + " ',' " + cbOffence.Text + " ',' " + cbSemester.Text + " ',' " + cbStaff.Text + " ',' " + cbIndiscipline.Text + " ','" + cbRemark.Text + "')")
                                                MsgBox("Record Successfully Added", vbOKOnly)
                                                conn.Execute("Commit")
                                            Else
                                                MsgBox("Record Already Exists", vbOKCancel)

                                            End If
                                            conn.Close()
                                            Call clear()
                                        Else
                                            Me.Erp.SetError(Me.cbStudent, "Please Enter StudentId")
                                        End If
                                    Else
                                        Me.Erp.SetError(Me.cbCourse, "Please Enter Course")
                                    End If
                                Else
                                    Me.Erp.SetError(Me.cbBatch, "Please Enter Batch")
                                End If
                            Else
                                Me.Erp.SetError(Me.cbCollege, "Please Enter College")
                            End If
                        Else
                            Me.Erp.SetError(Me.cbOffence, "Please Enter Offence")
                        End If
                    Else
                        Me.Erp.SetError(Me.cbSemester, "Please Enter Semester")
                    End If
                Else
                    Me.Erp.SetError(Me.cbStaff, "Please Enter Staff")
                End If
            Else
                Me.Erp.SetError(Me.cbIndiscipline, "Please Enter Indiscipline")
            End If
        Else
            Me.Erp.SetError(Me.cbRemark, "Please Enter Remark")
        End If
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        cbStudent.Enabled = False
        cbCourse.Enabled = False
        cbBatch.Enabled = False
        cbCollege.Enabled = False
        cbOffence.Enabled = False
        cbSemester.Enabled = False
        cbStaff.Enabled = False
        cbIndiscipline.Enabled = False
        cbRemark.Enabled = False
        cbNewCourse.Show()
        If cbNewCourse.Text <> "" Then
            Me.Erp.SetError(Me.cbNewCourse, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update StudentOffence set Course=' " + cbNewCourse.Text + " 'where stdId=('" + cbStudent.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                cbStudent.Enabled = True
                cbCourse.Enabled = True
                cbBatch.Enabled = True
                cbCollege.Enabled = True
                cbOffence.Enabled = True
                cbSemester.Enabled = True
                cbStaff.Enabled = True
                cbIndiscipline.Enabled = True
                cbRemark.Enabled = True
                cbNewCourse.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                cbNewCourse.Text = ""
                cbStudent.Enabled = True
                cbCourse.Enabled = True
                cbBatch.Enabled = True
                cbCollege.Enabled = True
                cbOffence.Enabled = True
                cbSemester.Enabled = True
                cbStaff.Enabled = True
                cbIndiscipline.Enabled = True
                cbRemark.Enabled = True
                cbNewCourse.Hide()
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnAdd.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.cbNewCourse, "Please Enter NewCourse")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        If cbStudent.Text <> "" Then
            Me.Erp.SetError(Me.cbStudent, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from StudentOffence where StdId='" + cbStudent.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                cbCourse.Text = rs.Fields.Item("Course").Value
                cbBatch.Text = rs.Fields.Item("Batch").Value
                cbCollege.Text = rs.Fields.Item("College").Value
                cbOffence.Text = rs.Fields.Item("Offence").Value
                cbSemester.Text = rs.Fields.Item("Semester").Value
                cbStaff.Text = rs.Fields.Item("Staff").Value
                cbIndiscipline.Text = rs.Fields.Item("indiscipline").Value
                cbRemark.Text = rs.Fields.Item("Remark").Value
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.cbStudent, "Please Enter StudentId")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from StudentOffence where StdId=('" + cbStudent.Text + "')")
            MsgBox("Record Delete Successfully", vbOKOnly)
            btnSearch.Enabled = False
            btnUpdate.Enabled = False
            btnAdd.Enabled = False
            Call clear()
        ElseIf rs = vbCancel Then
            MsgBox("Delete Cancelled", vbInformation)
            btnSearch.Enabled = True
            btnUpdate.Enabled = True
            btnAdd.Enabled = True
            Call clear()
        End If
        conn.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNewCourse.Hide()
        cbNewCourse.Select()
    End Sub
End Class