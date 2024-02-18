Public Class Student
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtStudentId.Text = ""
        txtStudentName.Text = ""
        txtCourse.Text = ""
        txtBatch.Text = ""
        txtAddress.Text = ""
        txtMobileNo.Text = ""
        txtEMailId.Text = ""
        txtParentMobileNo.Text = ""
        txtStudentId.Enabled = True
        txtStudentName.Enabled = True
        txtCourse.Enabled = True
        txtBatch.Enabled = True
        txtAddress.Enabled = True
        txtMobileNo.Enabled = True
        txtEMailId.Enabled = True
        txtParentMobileNo.Enabled = True
    End Sub


    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        btnSEARCH.Enabled = False
        If txtStudentId.Text <> "" And IsNumeric(txtStudentId.Text) Then
            Me.Erp.SetError(Me.txtStudentId, String.Empty)
            If txtStudentName.Text <> "" Then
                Me.Erp.SetError(Me.txtStudentName, String.Empty)
                If txtCourse.Text <> "" Then
                    Me.Erp.SetError(Me.txtCourse, String.Empty)
                    If txtBatch.Text <> "" And IsNumeric(txtBatch.Text) Then
                        Me.Erp.SetError(Me.txtBatch, String.Empty)
                        If txtAddress.Text <> "" Then
                            Me.Erp.SetError(Me.txtAddress, String.Empty)
                            If txtMobileNo.Text <> "" And IsNumeric(txtMobileNo.Text) Then
                                Me.Erp.SetError(Me.txtMobileNo, String.Empty)
                                If txtEMailId.Text <> "" Then
                                    Me.Erp.SetError(Me.txtEMailId, String.Empty)
                                    If txtParentMobileNo.Text <> "" And IsNumeric(txtParentMobileNo.Text) Then
                                        Me.Erp.SetError(Me.txtParentMobileNo, String.Empty)
                                        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                                        rs.Open("select * from Student where StudentId=' " + txtStudentId.Text + " '", conn)
                                        If rs.EOF Then
                                            conn.Execute("insert into Student values(' " + txtStudentId.Text + " ',' " + txtStudentName.Text + " ','" + txtCourse.Text + " ',' " + txtBatch.Text + " ',' " + txtAddress.Text + " ',' " + txtMobileNo.Text + " ',' " + txtEMailId.Text + " ',' " + txtParentMobileNo.Text + " ')")
                                            MsgBox("Record Successfully Added", vbOKOnly)
                                            conn.Execute("Commit")
                                        Else
                                            MsgBox("Record Already Exists", vbOKCancel)

                                        End If
                                        conn.Close()
                                        Call clear()
                                    Else
                                        Me.Erp.SetError(Me.txtStudentId, "Please Enter StudentId")
                                    End If
                                Else
                                    Me.Erp.SetError(Me.txtStudentName, "Please Enter StudentName")
                                End If
                            Else
                                Me.Erp.SetError(Me.txtCourse, "Please Enter Course")
                            End If
                        Else
                            Me.Erp.SetError(Me.txtBatch, "Please EnterBatch")
                        End If
                    Else
                        Me.Erp.SetError(Me.txtAddress, "Please Enter Address")
                    End If
                Else
                    Me.Erp.SetError(Me.txtMobileNo, "Please Enter MobileNo")
                End If
            Else
                Me.Erp.SetError(Me.txtEMailId, "Please Enter EMailId")
            End If
        Else
            Me.Erp.SetError(Me.txtParentMobileNo, "Please Enter ParentMobileNo")
        End If
        btnDELETE.Enabled = True
        btnUPDATE.Enabled = True
        btnSEARCH.Enabled = True

    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Student where StudentId=('" + txtStudentId.Text + "')")
            MsgBox("Record Delete Successfully", vbOKOnly)
            btnSEARCH.Enabled = False
            btnUPDATE.Enabled = False
            btnADD.Enabled = False
            Call clear()
        ElseIf rs = vbCancel Then
            MsgBox("Delete Cancelled", vbInformation)
            btnSEARCH.Enabled = True
            btnUPDATE.Enabled = True
            btnADD.Enabled = True
            Call clear()
        End If
        conn.Close()
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        txtStudentId.Enabled = False
        txtStudentName.Enabled = False
        txtCourse.Enabled = False
        txtBatch.Enabled = False
        txtAddress.Enabled = False
        txtMobileNo.Enabled = False
        txtEMailId.Enabled = False
        txtParentMobileNo.Enabled = False
        txtNewStudentName.Show()
        If txtNewStudentName.Text <> "" Then
            Me.Erp.SetError(Me.txtNewStudentName, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Student set StudentName=' " + txtNewStudentName.Text + " 'where StudentId=('" + txtStudentId.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtStudentId.Enabled = True
                txtStudentName.Enabled = True
                txtCourse.Enabled = True
                txtBatch.Enabled = True
                txtAddress.Enabled = True
                txtMobileNo.Enabled = True
                txtEMailId.Enabled = True
                txtParentMobileNo.Enabled = True
                txtNewStudentName.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewStudentName.Text = ""
                txtStudentId.Enabled = True
                txtStudentName.Enabled = True
                txtCourse.Enabled = True
                txtBatch.Enabled = True
                txtAddress.Enabled = True
                txtMobileNo.Enabled = True
                txtEMailId.Enabled = True
                txtParentMobileNo.Enabled = True
                txtNewStudentName.Hide()
                btnDELETE.Enabled = True
                btnSEARCH.Enabled = True
                btnADD.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewStudentName, "Please Enter NewStudentName")
        End If
    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        If txtStudentId.Text <> "" Then
            Me.Erp.SetError(Me.txtStudentId, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Student where StudentId='" + txtStudentId.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtStudentName.Text = rs.Fields.Item("StudentName").Value
                txtCourse.Text = rs.Fields.Item("Course").Value
                txtBatch.Text = rs.Fields.Item("Batch").Value
                txtAddress.Text = rs.Fields.Item("Address").Value
                txtMobileNo.Text = rs.Fields.Item("MobileNo").Value
                txtEMailId.Text = rs.Fields.Item("E_MailId").Value
                txtParentMobileNo.Text = rs.Fields.Item("ParentMobileNo").Value
                btnDELETE.Enabled = True
                btnUPDATE.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtStudentId, "Please Enter StudentId")
        End If
    End Sub

    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewStudentName.Hide()
        txtNewStudentName.Select()

    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Call clear()
    End Sub
End Class