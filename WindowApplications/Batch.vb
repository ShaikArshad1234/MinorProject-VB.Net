Public Class Batch

    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub clear()
        txtBatch.Text = ""
        txtBatchId.Text = ""
        txtBatch.Enabled = True
        txtBatchId.Enabled = True
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSearch.Enabled = False
        If txtBatch.Text <> "" Then
            Me.Erp.SetError(Me.txtBatch, String.Empty)
            If txtBatchId.Text <> "" Then
                Me.Erp.SetError(Me.txtBatchId, String.Empty)
                conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
                rs.Open("select * from Batch where Batch=' " + txtBatch.Text + " '", conn)
                If rs.EOF Then
                    conn.Execute("insert into Batch values(' " + txtBatch.Text + " ',' " + txtBatchId.Text + " ')")
                    MsgBox("Record Successfully Added", vbOKOnly)
                    conn.Execute("Commit")
                Else
                    MsgBox("Record Already Exists", vbOKCancel)

                End If
                conn.Close()
                Call clear()
            Else
                Me.Erp.SetError(Me.txtBatch, "Please Enter Batch")
            End If
        Else
            Me.Erp.SetError(Me.txtBatchId, "Please Enter BatchId")
        End If
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        txtBatch.Enabled = False
        txtBatchId.Enabled = False
        btnDelete.Enabled = False
        btnSearch.Enabled = False
        btnADD.Enabled = False
        txtNewBatchId.Show()
        If txtNewBatchId.Text <> "" Then
            Me.Erp.SetError(Me.txtNewBatchId, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            Dim RS As String = MsgBox("Are You Sure to Update Record ?", vbOKCancel)
            If RS = vbOK Then
                conn.Execute("update Batch set BatchId=' " + txtNewBatchId.Text + " 'where Batch=('" + txtBatch.Text + " ')")
                MsgBox("Record Update Successfully", vbOKOnly)
                txtBatch.Enabled = True
                txtBatchId.Enabled = True
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                txtNewBatchId.Hide()
                Call clear()
            Else
                MsgBox("Update Cancelled", vbInformation)
                txtNewBatchId.Text = ""
                txtBatch.Enabled = True
                txtBatchId.Enabled = True
                txtNewBatchId.Hide()
                btnDelete.Enabled = True
                btnSearch.Enabled = True
                btnADD.Enabled = True
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtNewBatchId, "Please Enter NewBatchId")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        If txtBatch.Text <> "" Then
            Me.Erp.SetError(Me.txtBatch, String.Empty)
            conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
            rs.Open("select*from Batch where Batch='" + txtBatch.Text + "'", conn)
            If Not rs.EOF Then
                MsgBox("User Found", vbOKOnly)
                txtBatchId.Text = rs.Fields.Item("BatchId").Value
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
            Else
                MsgBox("User Not Found", vbOKOnly)
                Call clear()
            End If
            conn.Close()
        Else
            Me.Erp.SetError(Me.txtBatch, "Please Enter Batch")
        End If

    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Call clear()
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub Batch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewBatchId.Hide()
        txtNewBatchId.Select()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim rs As String = MsgBox("Are You Sure to Delete This Record ?", vbOKCancel)
        conn.Open("PROVIDER= oraOLEDB.Oracle;DATA SOURCE=10.199.20.3:1521/mother;PERSIST SECURITY INFO=True;USER ID=043303;PASSWORD=043303")
        If rs = vbOK Then
            conn.Execute("delete from Batch where Batch=('" + txtBatch.Text + "')")
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