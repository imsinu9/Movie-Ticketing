Imports System.Data.SqlClient
Public Class DeleteUser

    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select username, Name from login"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("Username") & "")
            Lv.SubItems.Add(o_Reader("Name") & "")
           
        End While
        o_Reader.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub


    Private Sub DeleteUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        LoadData()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim s_Sql1 As String
        Dim o_reader As SqlDataReader
        s_Sql1 = " Select * from login where username='" & txtUserName.Text & "'"
        o_cmd = New SqlCommand(s_Sql1, o_con)
        o_reader = o_cmd.ExecuteReader
        If o_reader.Read Then
            s_Sql = "Delete from Login where username='" & txtUserName.Text & "' "
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_cmd.ExecuteNonQuery()
            MsgBox("Record Deleted")
            LoadData()
        Else
            MsgBox("Enter Correct Username")

        End If

       


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class