Public Class Offence
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtoffencetype.Text = ""
        txtoffencedescribe.Text = ""
        txtoffenceid.Text = ""
        txtoffencetype.Enabled = True
        txtoffencedescribe.Enabled = True
        txtoffenceid.Enabled = True

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSearch.Enabled = False
        If txtoffencetype.Text <> "" And IsNumeric(txtoffencetype.Text) Then
            Me.Erp.SetError(Me.txtoffencetype, String.Empty)
            If txtoffencedescribe.Text <> "" Then
                Me.Erp.SetError(Me.txtoffencedescribe, String.Empty)
                If txtoffenceid.Text <> "" Then
                    Me.Erp.SetError(Me.txtoffenceid, String.Empty)
                    conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                    rs.Open("select * from Offence where offenceid=' " + txtoffencetype.Text + " '", conn)
                    If rs.EOF Then
                        conn.Execute("insert into Offence values(' " + txtoffencetype.Text + " ',' " + txtoffencedescribe.Text + " ','" + txtoffenceid.Text + " ')")
                        MsgBox("Record Successfully Added", vbOKOnly)
                        conn.Execute("Commit")
                    Else
                        MsgBox("Record Already Exists", vbOKCancel)

                    End If
                    conn.Close()
                    Call clear()
                Else
                    Me.Erp.SetError(Me.txtoffencetype, "Please Enter offencetype")
                End If
            Else
                Me.Erp.SetError(Me.txtoffencedescribe, "Please Enter offencedescribe")
            End If
        Else
            Me.Erp.SetError(Me.txtoffenceid, "Please Enter offenceid")
        End If
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        txtoffencetype.Enabled = False
        txtoffencedescribe.Enabled = False
        txtoffenceid.Enabled = False
        btnDelete.Enabled = False
        btnSearch.Enabled = False
        btnAdd.Enabled = False
        txtNewoffencedescribe.Show()
        If txtNewoffencedescribe.Text <> "" Then
            Me.Erp.SetError(Me.txtNewoffencedescribe, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Offence set offencedescribe=' " + txtNewoffencedescribe.Text + " 'where offencetype=('" + txtoffencetype.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtoffencetype.Enabled = True
                txtoffencedescribe.Enabled = True
                txtoffenceid.Enabled = True
                txtNewoffencedescribe.Hide()
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnAdd.Enabled = True

                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewoffencedescribe.Text = ""
                txtoffencetype.Enabled = True
                txtoffencedescribe.Enabled = True
                txtoffenceid.Enabled = True
                txtNewoffencedescribe.Hide()
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnAdd.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewoffencedescribe, "Please Enter Newoffencedescribe")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        If txtoffencetype.Text <> "" Then
            Me.Erp.SetError(Me.txtoffencetype, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Offence where offencetype='" + txtoffencetype.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtoffencedescribe.Text = rs.Fields.Item("offencedescribe").Value
                txtoffenceid.Text = rs.Fields.Item("offenceid").Value
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtoffencetype, "Please Enter offencetype")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Offence where offencetype=('" + txtoffencetype.Text + "')")
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

    Private Sub Offence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewoffencedescribe.Hide()
        txtNewoffencedescribe.Select()
    End Sub
End Class