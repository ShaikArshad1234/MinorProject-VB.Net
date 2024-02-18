Public Class College
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtCollegeCode.Text = ""
        txtCollegeName.Text = ""
        txtCollegeCode.Enabled = True
        txtCollegeName.Enabled = True
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        btnSearch.Enabled = False
        If txtCollegeCode.Text <> "" And IsNumeric(txtCollegeCode.Text) Then
            Me.Erp.SetError(Me.txtCollegeCode, String.Empty)
            If txtCollegeName.Text <> "" Then
                Me.Erp.SetError(Me.txtCollegeName, String.Empty)
                conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                rs.Open("select * from College where CollegeCode=' " + txtCollegeCode.Text + " '", conn)
                If rs.EOF Then
                    conn.Execute("insert into College values(' " + txtCollegeCode.Text + " ',' " + txtCollegeName.Text + " ')")
                    MsgBox("Record Successfully Added", vbOKOnly)
                    conn.Execute("Commit")
                Else
                    MsgBox("Record Already Exists", vbOKCancel)

                End If
                conn.Close()
                Call clear()
            Else
                Me.Erp.SetError(Me.txtCollegeCode, "Please Enter CollegeCode")
            End If
        Else
            Me.Erp.SetError(Me.txtCollegeName, "Please Enter CollegeName")
        End If
        btnDELETE.Enabled = True
        btnUPDATE.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        txtCollegeCode.Enabled = False
        txtCollegeName.Enabled = False
        btnDELETE.Enabled = False
        btnSearch.Enabled = False
        btnADD.Enabled = False
        txtNewCollegeName.Show()
        If txtNewCollegeName.Text <> "" Then
            Me.Erp.SetError(Me.txtNewCollegeName, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update College set CollegeName=' " + txtNewCollegeName.Text + " 'where CollegeCode=('" + txtCollegeCode.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtCollegeCode.Enabled = True
                txtCollegeName.Enabled = True
                btnDELETE.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                txtNewCollegeName.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewCollegeName.Text = ""
                txtCollegeCode.Enabled = True
                txtCollegeName.Enabled = True
                txtNewCollegeName.Hide()
                btnDELETE.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewCollegeName, "Please Enter NewCollegeName")
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from College where CollegeCode=('" + txtCollegeCode.Text + "')")
            MsgBox("Record Delete Successfully", vbOKOnly)
            btnSearch.Enabled = False
            btnUPDATE.Enabled = False
            btnADD.Enabled = False
            Call clear()
        ElseIf rs = vbCancel Then
            MsgBox("Delete Cancelled", vbInformation)
            btnSearch.Enabled = True
            btnUPDATE.Enabled = True
            btnADD.Enabled = True
            Call clear()
        End If
        conn.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        If txtCollegeCode.Text <> "" Then
            Me.Erp.SetError(Me.txtCollegeCode, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from College where CollegeCode='" + txtCollegeCode.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtCollegeName.Text = rs.Fields.Item("CollegeName").Value
                btnDELETE.Enabled = True
                btnUPDATE.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtCollegeCode, "Please Enter CollegeCode")
        End If
    End Sub

    Private Sub txt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewCollegeName.Hide()
        txtNewCollegeName.Select()

    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Call clear()
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub
End Class