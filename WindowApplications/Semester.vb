Public Class Semester
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtSemesterCode.Text = ""
        txtSemesterName.Text = ""
        txtSemesterCode.Enabled = True
        txtSemesterName.Enabled = True
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        If txtSemesterCode.Text <> "" And IsNumeric(txtSemesterCode.Text) Then
            Me.Erp.SetError(Me.txtSemesterCode, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Semester where SemesterCode='" + txtSemesterCode.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtSemesterName.Text = rs.Fields.Item("SemesterName").Value
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtSemesterCode, "Please Enter SemesterCode")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        btnSearch.Enabled = False
        If txtSemesterCode.Text <> "" Then
            Me.Erp.SetError(Me.txtSemesterCode, String.Empty)
            If txtSemesterName.Text <> "" Then
                Me.Erp.SetError(Me.txtSemesterName, String.Empty)
                conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                rs.Open("select * from Semester where SemesterCode=' " + txtSemesterCode.Text + " '", conn)
                If rs.EOF Then
                    conn.Execute("insert into Semester values(' " + txtSemesterCode.Text + " ',' " + txtSemesterName.Text + " ')")
                    MsgBox("Record Successfully Added", vbOKOnly)
                    conn.Execute("Commit")
                Else
                    MsgBox("Record Already Exists", vbOKCancel)

                End If
                conn.Close()
                Call clear()
            Else
                Me.Erp.SetError(Me.txtSemesterCode, "Please Enter SemesterCode")
            End If
        Else
            Me.Erp.SetError(Me.txtSemesterName, "Please Enter SemesterName")
        End If
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        txtSemesterCode.Enabled = False
        txtSemesterName.Enabled = False
        btnDelete.Enabled = False
        btnSearch.Enabled = False
        btnAdd.Enabled = False
        txtNewSemesterName.Show()
        If txtNewSemesterName.Text <> "" Then
            Me.Erp.SetError(Me.txtNewSemesterName, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Semester set SemesterName=' " + txtNewSemesterName.Text + " 'where SemesterCode=('" + txtSemesterCode.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtSemesterCode.Enabled = True
                txtSemesterName.Enabled = True
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnAdd.Enabled = True
                txtNewSemesterName.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewSemesterName.Text = ""
                txtSemesterCode.Enabled = True
                txtSemesterName.Enabled = True
                txtNewSemesterName.Hide()
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnAdd.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewSemesterName, "Please Enter NewSemesterName")
        End If

    End Sub

    Private Sub Semester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewSemesterName.Hide()
        txtNewSemesterName.Select()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clear()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Semester where SemesterCode=('" + txtSemesterCode.Text + "')")
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
End Class