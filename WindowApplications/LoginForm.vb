Imports Oracle.ManagedDataAccess.Client
Public Class LoginForm
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUserName1.Text = ""
        txtPassword1.Text = ""
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername1.Text <> "" Then
            Me.ErrorProvider1.SetError(Me.txtUsername1, "")
            If txtPassword1.Text <> "" Then
                Me.ErrorProvider1.SetError(Me.txtPassword1, "")
                Login()
            Else
                Me.ErrorProvider1.SetError(Me.txtPassword1, "Please Enter Password")
            End If
        Else
            Me.ErrorProvider1.SetError(Me.txtUsername1, "Please Enter Username")
        End If
    End Sub
    Public Sub Login()
        Dim conn As OracleConnection = New OracleConnection("DATA SOURCE=10.199.20.3:1521/mother;USER ID=043303;PASSWORD=043303")
        Dim cmd As OracleCommand = New OracleCommand("select *from login1 Where Username='" + txtUsername1.Text + "' and Password='" + txtPassword1.Text + "'", conn)
        cmd.CommandType = CommandType.Text
        conn.Open()
        Dim reader As OracleDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            MsgBox("User Found, Login Successfull")
            MDI.Show()
        Else
            MsgBox("User not Found")
        End If
        conn.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class