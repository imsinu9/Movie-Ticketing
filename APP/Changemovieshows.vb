Imports System.Data.SqlClient

Public Class Changemovieshows
    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "SELECT     Movie_Schedule.Show_ID, Show_Time.Show_Time, Movie_Details.Movie_Name FROM Movie_Schedule INNER JOIN Movie_Details ON Movie_Schedule.Movie_ID = Movie_Details.Movie_ID INNER JOIN Show_Time ON Movie_Schedule.Show_ID = Show_Time.Show_ID where  mdate ='" & dtp1.Text & "'and movie_details.movie_name='" & cbomoviename.Text & "' and movie_details.active='Yes'"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("Show_ID") & "")
            Lv.SubItems.Add(o_Reader("Show_Time") & "")
            Lv.SubItems.Add(o_Reader("Movie_Name") & "")

        End While
        o_Reader.Close()
        txt1.Text = ""

    End Sub
    Private Sub Addshow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()


        Fillmovie()
        LoadData()

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim RNo As Integer

        RNo = ListView1.SelectedItems(0).Text

        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader

        s_sql = "select show_time from show_time where show_id=" & Val(RNo)
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader


        If o_reader.Read Then
            txtid.Text = RNo
            txt1.Text = o_reader("show_time") & ""

        End If

        o_reader.Close()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Fillmovie()

        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet


        s_Sql = "SELECT Movie_Details.Movie_Name FROM  Movie_Details INNER Join Movie_Schedule ON Movie_Details.Movie_ID = Movie_Schedule.Movie_ID where movie_schedule.mdate= '" & dtp1.Text & "'group by movie_details.movie_name"
        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)

        cboMovieName.DataSource = o_data.Tables(0)
        cboMovieName.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cbomoviename.ValueMember = o_data.Tables(0).Columns(0).ColumnName
    End Sub



    Private Sub FillmovieNew()

        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet


        s_Sql = "SELECT Movie_Details.Movie_Name FROM  Movie_Details INNER Join Movie_Schedule ON Movie_Details.Movie_ID = Movie_Schedule.Movie_ID where movie_schedule.mdate= '" & dtp1.Text & "'and movie_details.active='Yes' group by movie_details.movie_name"
        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)

        cbomovie1.DataSource = o_data.Tables(0)
        cbomovie1.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cbomovie1.ValueMember = o_data.Tables(0).Columns(0).ColumnName
    End Sub

    Private Sub cbomoviename_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbomoviename.DropDownClosed

    End Sub


    Private Sub cbomoviename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomoviename.SelectedIndexChanged
        LoadData()
        FillmovieNew()
    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged
        LoadData()
        Fillmovie()
    End Sub





    Private Sub LoadData2()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "SELECT     Movie_Schedule.Show_ID, Show_Time.Show_Time, Movie_Details.Movie_Name FROM Movie_Schedule INNER JOIN Movie_Details ON Movie_Schedule.Movie_ID = Movie_Details.Movie_ID INNER JOIN Show_Time ON Movie_Schedule.Show_ID = Show_Time.Show_ID where Movie_Details.Active='yes'and mdate ='" & dtp1.Text & "'and movie_details.movie_name='" & cbomovie1.Text & "'"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView2.Items.Clear()

        While o_Reader.Read
            Lv = ListView2.Items.Add(o_Reader("Show_ID") & "")
            Lv.SubItems.Add(o_Reader("Show_Time") & "")
            Lv.SubItems.Add(o_Reader("Movie_Name") & "")

        End While
        o_Reader.Close()
    End Sub




    Private Sub cbomovie1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomovie1.SelectedIndexChanged

        movie2()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_sql = "select movie_id from movie_details where movie_name='" & cbomovie1.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader

        While o_Reader.Read
            txtmid.Text = o_Reader(0)
        End While
        o_Reader.Close()

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txt1.Text = "" Then
            MsgBox("Select Show Time..")
            Exit Sub

        End If
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_sql = "update movie_schedule set movie_id =" & txtmid.Text & "where show_id=" & txtid.Text
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader

        While o_Reader.Read
            txtmid.Text = o_Reader(0)
        End While
        o_Reader.Close()
        MsgBox(" Record Updated")
        LoadData2()
        LoadData()


    End Sub
    Private Sub movie2()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "SELECT     Movie_Schedule.Show_ID, Show_Time.Show_Time, Movie_Details.Movie_Name FROM Movie_Schedule INNER JOIN Movie_Details ON Movie_Schedule.Movie_ID = Movie_Details.Movie_ID INNER JOIN Show_Time ON Movie_Schedule.Show_ID = Show_Time.Show_ID where Movie_Details.Active='yes'and mdate ='" & dtp1.Text & "'and movie_details.movie_name='" & cbomovie1.Text & "'"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        ListView2.Items.Clear()

        While o_Reader.Read
            Lv = ListView2.Items.Add(o_Reader("Show_ID") & "")
            Lv.SubItems.Add(o_Reader("Show_Time") & "")
            Lv.SubItems.Add(o_Reader("Movie_Name") & "")

        End While
        o_Reader.Close()

    End Sub


End Class