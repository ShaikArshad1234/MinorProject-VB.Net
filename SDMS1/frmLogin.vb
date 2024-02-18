Imports Oracle.ManagedDataAccess.Client
Public Class frmLogin
    Dim conn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As OracleConnection = New OracleConnection("DATA SOURCE=10.199.20.3:1521/mother;USER ID=043303;PASSWORD=043303")
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUserName1.Text <> "" Then
            Me.ErpLog.SetError(Me.txtUserName1, String.Empty)
            If txtPassword1.Text <> "" Then
                Me.ErpLog.SetError(Me.txtPassword1, String.Empty)
                login()
            Else
                Me.ErpLog.SetError(Me.txtPassword1, "Please Enter Password")
                Return
            End If
        Else
            Me.ErpLog.SetError(Me.txtUserName1, "Please Enter Login")
            Return
        End If
        Me.Hide()
    End Sub
    Public Sub login()
        conn = New ADODB.Connection
        rs = New ADODB.Recordset
        conn.Open("provider= MSDAORA;DATA SOURCE=10.199.20.3:1521/mother;Persist Security Info = True; USER ID=043303;PASSWORD=043303")
        MsgBox("Database  Connected", vbOKOnly, "MTICA")
        rs.Open("select *from Login Where Username='" + txtUserName.Text + "' and txtPassword1='" + txtPassword.Text + "'", conn)
        If Not rs.EOF Then
            Me.Hide()
        Else
            MsgBox("Username or Password invalid")
        End If
        conn.Close()
    End Sub
    Private Sub Clear()
        txtUserName1.Text = ""
        txtPassword1.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class