Public Class Indiscipline
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtTypesOfIndiscipline.Text = ""
        txtTypesOfIndiscipline.Enabled = True

    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSearch.Enabled = False
        If txtTypesOfIndiscipline.Text <> "" Then
            Me.Erp.SetError(Me.txtTypesOfIndiscipline, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select * from Indiscipline where TypesOfIndiscipline=' " + txtTypesOfIndiscipline.Text + " '", conn)
            If rs.EOF Then
                conn.Execute("insert into Indiscipline values(' " + txtTypesOfIndiscipline.Text + "')")
                MsgBox("Record Successfully Added", vbOKOnly)
                conn.Execute("Commit")
            Else
                MsgBox("Record Already Exists", vbOKCancel)

            End If
            conn.Close()
            Call clear()
        Else
            Me.Erp.SetError(Me.txtTypesOfIndiscipline, "Please Enter TypesOfIndiscipline")
        End If
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        txtTypesOfIndiscipline.Enabled = False
        btnDelete.Enabled = False
        btnSearch.Enabled = False
        btnADD.Enabled = False
        txtNewTypesOfIndiscipline.Show()
        If txtNewTypesOfIndiscipline.Text <> "" Then
            Me.Erp.SetError(Me.txtNewTypesOfIndiscipline, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Indiscipline set TypesOfIndiscipline=' " + txtTypesOfIndiscipline.Text + " '")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtTypesOfIndiscipline.Enabled = True
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                txtNewTypesOfIndiscipline.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewTypesOfIndiscipline.Text = ""
                txtTypesOfIndiscipline.Enabled = True
                txtNewTypesOfIndiscipline.Hide()
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewTypesOfIndiscipline, "Please Enter NewTypesOfIndiscipline")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        If txtTypesOfIndiscipline.Text <> "" Then
            Me.Erp.SetError(Me.txtTypesOfIndiscipline, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Indiscipline where TypesOfIndiscipline='" + txtTypesOfIndiscipline.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtTypesOfIndiscipline, "Please Enter TypesOfIndiscipline")
        End If
    End Sub

    Private Sub Indiscipline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewTypesOfIndiscipline.Hide()
        txtNewTypesOfIndiscipline.Select()
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Call clear()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Indiscipline where TypesOfIndiscipline='" + txtTypesOfIndiscipline.Text + "'")
            MsgBox("Record Delete Successfully", vbOKOnly)
            btnSearch.Enabled = False
            btnUpdate.Enabled = False
            btnADD.Enabled = False
            Call clear()
        ElseIf rs = vbCancel Then
            MsgBox("Delete Cancelled", vbInformation)
            btnSearch.Enabled = True
            btnUpdate.Enabled = True
            btnADD.Enabled = True
            Call clear()
        End If
        conn.Close()
    End Sub

End Class