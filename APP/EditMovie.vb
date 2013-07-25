Imports System.Data.SqlClient
Public Class EditMovie

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub




    Private Sub EditMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        LoadData()
    End Sub
    Private Sub LoadData()
        btnok.Enabled = False
        txtid.Text = ""
        txtname.Text = ""

        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select movie_Id,movie_name,active from movie_details"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("movie_Id") & "")
            Lv.SubItems.Add(o_Reader("Movie_Name") & "")
            Lv.SubItems.Add(o_Reader("Active") & "")
        End While
        o_Reader.Close()

    End Sub

    Private Sub ListView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        btnok.Enabled = True
        Dim RNo As Integer

        RNo = ListView1.SelectedItems(0).Text

        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader

        s_sql = "select movie_name,active from movie_details where movie_id=" & Val(RNo)
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader

        If o_reader.Read Then
            txtid.Text = RNo
            txtname.Text = o_reader("Movie_Name") & ""
            ComboBox1.Text = o_reader("active")
        End If

        o_reader.Close()
    End Sub

    

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_Sql As String
        Dim o_cmd As SqlCommand

        s_Sql = "Update movie_details set active=@active where movie_id=" & Val(txtid.Text)
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_cmd.Parameters.Add(New SqlParameter("@active", ComboBox1.Text))
        o_cmd.ExecuteNonQuery()

        MsgBox("Record Updated")
        LoadData()
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class