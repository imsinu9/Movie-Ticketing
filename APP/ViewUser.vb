Imports System.Data.SqlClient

Public Class ViewUser
    Dim Status As String

    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select User_ID, Name, username, password from login where username like'" & txtsusername.Text & "%'"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("User_ID") & "")
            Lv.SubItems.Add(o_Reader("Name") & "")
            Lv.SubItems.Add(o_Reader("Username") & "")
            Lv.SubItems.Add(o_Reader("Password") & "")
        End While
        o_Reader.Close()
    End Sub

    Private Sub clear()
        txtsusername.Text = ""
        txtname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtuserid.Text = ""
        txtsusername.Focus()

        btnok.Enabled = False

    End Sub

    Private Sub ViewUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")

        End If
    End Sub
    

    Private Sub ViewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        LoadData()

        btnok.Enabled = False

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()

    End Sub

    
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        administator.Show()
        Me.Close()
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If txtname.Text = "" Or txtpassword.Text = "" Or txtusername.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True

        End If
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        If txtname.Text = "" Or txtpassword.Text = "" Or txtusername.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True

        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtname.Text = "" Or txtpassword.Text = "" Or txtusername.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True

        End If
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_Sql As String
        Dim o_cmd As SqlCommand

        s_Sql = "Update login set Name=@Name,  password=@password where User_ID='" & Val(txtuserid.Text) & "'"
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_cmd.Parameters.Add(New SqlParameter("@Name", txtname.Text))
        o_cmd.Parameters.Add(New SqlParameter("@username", txtusername.Text))
        o_cmd.Parameters.Add(New SqlParameter("@password", txtpassword.Text))
        
        o_cmd.ExecuteNonQuery()

        MsgBox("Record Updated")

        clear()
        LoadData()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        Dim user As String
        user = ListView1.SelectedItems(0).Text
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        s_sql = " Select * from login where User_ID='" & Val(user) & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader

        If o_reader.Read Then
            txtuserid.Text = Val(user)
            txtname.Text = o_reader("Name") & ""
            txtusername.Text = o_reader("Username") & ""
            txtpassword.Text = o_reader("Password") & ""
        End If

        o_reader.Close()
    End Sub

    
    Private Sub txtsusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsusername.TextChanged
        LoadData()

    End Sub

    
End Class