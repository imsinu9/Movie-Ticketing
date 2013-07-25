Imports System.Data.SqlClient

Public Class LogIn



    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        Welcome.Show()
        Me.Close()

    End Sub


    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Connect()
        txtusername.Focus()
        btnok.Enabled = False

    End Sub

    Private Sub txtusername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.GotFocus

        Welcome.Hide()

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click


        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_Sql = "Select password from login where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "' "
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_Reader = o_cmd.ExecuteReader

        If o_Reader.Read = False Then
            MsgBox("Enter correct Username & Password")
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
            o_Reader.Close()
            Exit Sub
        End If


        Welcome.Show()
        Welcome.Label1.Visible = True
        Welcome.LinkLabel1.Visible = True
        Welcome.LinkLabel2.Visible = True
        Welcome.Button2.Visible = False
        Welcome.PictureBox2.Visible = False
        Welcome.PictureBox1.Visible = True
        Welcome.Button1.Visible = False
        Welcome.Button3.Visible = True
        Welcome.Close.Visible = False
        Welcome.LinkLabel5.Visible = True


        Me.Close()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()
    End Sub
    

   

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True
        End If

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True
        End If
    End Sub

    
End Class