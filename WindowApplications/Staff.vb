Public Class Staff
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtstaffid.Text = ""
        txtstaffname.Text = ""
        txtdepartment.Text = ""
        txtcollege.Text = ""
        txtstaffid.Enabled = True
        txtstaffname.Enabled = True
        txtdepartment.Enabled = True
        txtcollege.Enabled = True

    End Sub
    Private Sub btnADD_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        btnSearch.Enabled = False
        If txtStaffId.Text <> "" And IsNumeric(txtStaffId.Text) Then
            Me.Erp.SetError(Me.txtStaffId, String.Empty)
            If txtStaffName.Text <> "" Then
                Me.Erp.SetError(Me.txtStaffName, String.Empty)
                If txtDepartment.Text <> "" Then
                    Me.Erp.SetError(Me.txtDepartment, String.Empty)
                    If txtCollege.Text <> "" Then
                        Me.Erp.SetError(Me.txtCollege, String.Empty)
                        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                        rs.Open("select * from Staff where StaffId=' " + txtStaffId.Text + " '", conn)
                        If rs.EOF Then
                            conn.Execute("insert into Staff values(' " + txtStaffId.Text + " ',' " + txtStaffName.Text + " ','" + txtDepartment.Text + " ',' " + txtCollege.Text + " ')")
                            MsgBox("Record Successfully Added", vbOKOnly)
                            conn.Execute("Commit")
                        Else
                            MsgBox("Record Already Exists", vbOKCancel)

                        End If
                        conn.Close()
                        Call clear()
                    Else
                        Me.Erp.SetError(Me.txtStaffId, "Please Enter StaffId")
                    End If
                Else
                    Me.Erp.SetError(Me.txtStaffName, "Please Enter StaffName")
                End If
            Else
                Me.Erp.SetError(Me.txtDepartment, "Please Enter Department")
            End If
        Else
            Me.Erp.SetError(Me.txtCollege, "Please Enter College")
        End If
        btnDELETE.Enabled = True
        btnUPDATE.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnUPDATE_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        txtStaffId.Enabled = False
        txtStaffName.Enabled = False
        txtDepartment.Enabled = False
        txtCollege.Enabled = False
        btnDELETE.Enabled = False
        btnSearch.Enabled = False
        btnADD.Enabled = False
        txtNewStaffName.Show()
        If txtNewStaffName.Text <> "" Then
            Me.Erp.SetError(Me.txtNewStaffName, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Staff set StaffName=' " + txtNewStaffName.Text + " 'where StaffId=('" + txtStaffId.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtStaffId.Enabled = True
                txtStaffName.Enabled = True
                txtDepartment.Enabled = True
                txtCollege.Enabled = True
                btnDELETE.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                txtNewStaffName.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewStaffName.Text = ""
                txtStaffId.Enabled = True
                txtStaffName.Enabled = True
                txtDepartment.Enabled = True
                txtCollege.Enabled = True
                txtNewStaffName.Hide()
                btnDELETE.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewStaffName, "Please Enter NewStaffName")
        End If

    End Sub
    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Staff where StaffId=('" + txtstaffid.Text + "')")
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        If txtStaffId.Text <> "" Then
            Me.Erp.SetError(Me.txtStaffId, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Staff where StaffId='" + txtStaffId.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtStaffName.Text = rs.Fields.Item("StaffName").Value
                txtDepartment.Text = rs.Fields.Item("Department").Value
                txtCollege.Text = rs.Fields.Item("College").Value
                btnDELETE.Enabled = True
                btnUPDATE.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtStaffId, "Please Enter StaffId")
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Call clear()

    End Sub

    Private Sub btnEXIT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewStaffName.Hide()
        txtNewStaffName.Select()
    End Sub
End Class

