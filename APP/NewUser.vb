Imports System.Data.SqlClient
Public Class NewUser

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtName.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtconfrmpass.Text = ""
        txtName.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Len(txtPassword.Text) < 6 Then
            MsgBox("Password too short,Enter minimumu 6 characters")
            txtPassword.Text = ""
            txtconfrmpass.Text = ""
            txtPassword.Focus()
            Exit Sub
        End If
        If Len(txtconfrmpass.Text) < 6 Then
            MsgBox("Password too short,Enter minimumu 6 characters")
            txtPassword.Text = ""
            txtconfrmpass.Text = ""
            txtPassword.Focus()

        End If


        If txtPassword.Text <> txtconfrmpass.Text Then
            txtPassword.Text = ""
            txtconfrmpass.Text = ""
            txtPassword.Focus()
            MsgBox("Enter same Password")
            Exit Sub
        End If


        Dim s_Sql As String
        Dim o_cmd As SqlCommand

        s_Sql = "Insert into Login(Name,username,password) values(@Name,@username,@password)"
        o_cmd = New SqlCommand(s_Sql, o_con)

        o_cmd.Parameters.Add(New SqlParameter("@Name", txtName.Text))
        o_cmd.Parameters.Add(New SqlParameter("@username", txtUserName.Text))
        o_cmd.Parameters.Add(New SqlParameter("@password", txtPassword.Text))
        o_cmd.ExecuteNonQuery()
        MsgBox("New record Created..")
        Me.Close()
        administator.Show()
    End Sub

    Private Sub NewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        Button1.Enabled = False

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress

        If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar

        Else
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If txtName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtconfrmpass.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True

        End If

    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        If txtName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtconfrmpass.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True

        End If

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtconfrmpass.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True

        End If


    End Sub

    Private Sub txtconfrmpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfrmpass.TextChanged
        If txtName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtconfrmpass.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True

        End If

    End Sub
End Class