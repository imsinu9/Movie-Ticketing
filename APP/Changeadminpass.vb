Imports System.Data.SqlClient

Public Class Changeadminpass
    Private Sub clear()
        txtnewpass.Text = ""
        txtconfrmpass.Text = ""
        txtnewpass.Focus()

    End Sub

    Private Sub Changeadminpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        txtpassword.Focus()
        txtusername.Visible = False
        Label1.Visible = False
        lblconfrmpass.Visible = False
        lblnewpass.Visible = False
        txtconfrmpass.Visible = False
        txtnewpass.Visible = False
        btnclear.Visible = False
        btnok.Visible = False
        btnok1.Enabled = False
    End Sub



    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        administator.Show()
        Me.Close()
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "" Then
            btnok1.Enabled = False
        Else
            btnok1.Enabled = True

        End If
    End Sub

    Private Sub btnok1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok1.Click
        
        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader


        s_Sql = "Select admin_id, password from administrator where  password='" & txtpassword.Text & "' "
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        If o_Reader.Read Then

            txtnewpass.Visible = True
            txtconfrmpass.Visible = True
            txtusername.Visible = True
            Label1.Visible = True
            btnok.Visible = True
            btnclear.Visible = True
            lblconfrmpass.Visible = True
            lblnewpass.Visible = True
            lblenterpass.Visible = False
            btnok1.Visible = False
            txtpassword.Visible = False
            txtusername.Text = o_Reader(0)

        Else
            MsgBox("Enter correct Password..")

        End If
        o_Reader.Close()


    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If Len(txtnewpass.Text) < 5 Then
            MsgBox("Password too short, Enter minimumum 6 characters..")
            txtpassword.Text = ""
            txtconfrmpass.Text = ""
            txtpassword.Focus()
            Exit Sub
        End If
        If Len(txtconfrmpass.Text) < 5 Then
            MsgBox("Password too short, Enter minimumum 6 characters..")
            txtpassword.Text = ""
            txtconfrmpass.Text = ""
            txtpassword.Focus()

        End If


        If txtnewpass.Text <> txtconfrmpass.Text Then
            txtpassword.Text = ""
            txtconfrmpass.Text = ""
            txtpassword.Focus()
            MsgBox("Enter same Password..")
            Exit Sub
        End If
        Dim o_cmd As SqlCommand
        Dim s_sql1 As String

        s_sql1 = "Update administrator set password=@password where Admin_ID='" & txtusername.Text & "'"
        o_cmd = New SqlCommand(s_sql1, o_con)

        o_cmd.Parameters.Add(New SqlParameter("@password", txtnewpass.Text))

        o_cmd.ExecuteNonQuery()

        MsgBox("Password Updated")
        Me.Close()

    End Sub

End Class