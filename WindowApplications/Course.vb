Public Class Course
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtCourseId.Text = ""
        txtCourseName.Text = ""
        txtCourseId.Enabled = True
        txtCourseName.Enabled = True
    End Sub
    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        btnSearch.Enabled = False
        If txtCourseId.Text <> "" And IsNumeric(txtCourseId.Text) Then
            Me.Erp.SetError(Me.txtCourseId, String.Empty)
            If txtCourseName.Text <> "" Then
                Me.Erp.SetError(Me.txtCourseName, String.Empty)
                conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                rs.Open("select * from Course where CourseId=' " + txtCourseId.Text + " '", conn)
                If rs.EOF Then
                    conn.Execute("insert into Course values(' " + txtCourseId.Text + " ',' " + txtCourseName.Text + " ')")
                    MsgBox("Record Successfully Added", vbOKOnly)
                    conn.Execute("Commit")
                Else
                    MsgBox("Record Already Exists", vbOKCancel)

                End If
                conn.Close()
                Call clear()
            Else
                Me.Erp.SetError(Me.txtCourseId, "Please Enter CourseId")
            End If
        Else
            Me.Erp.SetError(Me.txtCourseName, "Please Enter CourseName")
        End If
        btnDELETE.Enabled = True
        btnUPDATE.Enabled = True
        btnSearch.Enabled = True

    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        txtCourseId.Enabled = False
        txtCourseName.Enabled = False
        btnDELETE.Enabled = False
        btnSearch.Enabled = False
        btnADD.Enabled = False
        txtNewCourseName.Show()
        If txtNewCourseName.Text <> "" Then
            Me.Erp.SetError(Me.txtNewCourseName, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Course set CourseName=' " + txtNewCourseName.Text + " 'where CourseId=('" + txtCourseId.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtCourseId.Enabled = True
                txtCourseName.Enabled = True
                btnDELETE.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                txtNewCourseName.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewCourseName.Text = ""
                txtCourseId.Enabled = True
                txtCourseName.Enabled = True
                txtNewCourseName.Hide()
                btnDELETE.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewCourseName, "Please Enter NewCourseName")
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        If txtCourseId.Text <> "" Then
            Me.Erp.SetError(Me.txtCourseId, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Course where CourseId='" + txtCourseId.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtCourseName.Text = rs.Fields.Item("CourseName").Value
                btnDELETE.Enabled = True
                btnUPDATE.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtCourseId, "Please Enter CourseId")
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Course where CourseId=('" + txtCourseId.Text + "')")
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

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Call clear()

    End Sub

    Private Sub Course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewCourseName.Hide()
        txtNewCourseName.Select()

    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub
End Class