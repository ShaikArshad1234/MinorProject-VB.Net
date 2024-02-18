Imports Oracle.ManagedDataAccess.Client
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As OracleConnection = New OracleConnection("DATA SOURCE=10.199.20.3:1521/mother;USER ID=043303;PASSWORD=043303")
        conn.Open()
        MsgBox("Data Base Connected")
        conn.Close()
    End Sub
End Class
