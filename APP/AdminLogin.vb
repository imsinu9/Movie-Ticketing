Imports System.Data.SqlClient

Public Class AdminLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_Sql = "Select password from administrator where username='" & txtusername.Text & "' and password='" & txtPassword.Text & "' "
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_Reader = o_cmd.ExecuteReader

        If o_Reader.Read = False Then
            MsgBox("Enter correct Username & Password")
            txtusername.Text = ""
            txtPassword.Text = ""
            txtusername.Focus()
            o_Reader.Close()
            Exit Sub
        End If
        administator.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Close()

    End Sub

    Private Sub Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        txtusername.Focus()
        btnok.Enabled = False
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtusername.Text = "" Or txtPassword.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True
        End If

    End Sub

    Private Sub txtusername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.GotFocus
        Welcome.Hide()
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        If txtusername.Text = "" Or txtPassword.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True
        End If
    End Sub
End Class

