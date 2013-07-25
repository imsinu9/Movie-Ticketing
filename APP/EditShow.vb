Imports System.Data.SqlClient
Public Class EditShow


    Private Sub EditShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select st.Show_Time,md.Movie_Name,ad.Audi_Name from Movie_Schedule ms,Show_Time st,Movie_Details md,Audi_Detail ad where st.Show_ID=ms.Show_ID and md.Movie_ID=ms.Movie_ID and ms.Audi_ID=ad.Audi_ID and ms.mdate='" & DateTimePicker1.Text & "'"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("Show_Time") & "")
            Lv.SubItems.Add(o_Reader("Movie_Name") & "")
            Lv.SubItems.Add(o_Reader("Audi_Name") & "")
        End While
        o_Reader.Close()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        Dim stime As String
        stime = ListView1.SelectedItems(0).Text
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        s_sql = " select st.Show_Time,st.Show_ID from Movie_Schedule ms,Show_Time st where st.Show_ID=ms.Show_ID and st.Show_Time='" & stime & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader

        If o_reader.Read Then
            txtstime.Text = o_reader("Show_Time")
            txtshowid.Text = o_reader("Show_ID")
        End If
        o_reader.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s_Sql As String
        Dim o_cmd As SqlCommand

        s_Sql = "Update Show_Time set Show_Time=@stime where Show_ID=" & Val(txtshowid.Text)
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_cmd.Parameters.Add(New SqlParameter("@stime", txtstime.Text))
        o_cmd.ExecuteNonQuery()

        MsgBox("Record Updated")

        clear()
        LoadData()
    End Sub
    Private Sub clear()
        txtstime.Text = ""
        txtshowid.Text = ""
        txtstime.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()
    End Sub
End Class