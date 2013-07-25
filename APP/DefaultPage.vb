Imports System.Data.SqlClient
Public Class DefaultPage

    Private Sub DefaultPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        LoadData()
        txtdate.Text = Date.Today
        btnnext.Enabled = False
    End Sub
    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select ms.mdate,md.Movie_Name,st.Show_Time from Movie_Schedule ms,Show_Time st,Movie_Details md where ms.Show_ID =st.Show_ID and ms.Movie_ID=md.Movie_ID and ms.mDate ='" & Date.Today & "' order by md.Movie_Name"

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader()
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("mdate"))
            Lv.SubItems.Add(o_Reader("Movie_Name"))
            Lv.SubItems.Add(o_Reader("Show_Time"))
        End While
        o_Reader.Close()

    End Sub

    Private Sub txtdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.TextChanged

        Fillmovie()

    End Sub
    Private Sub Fillshowtime()
        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet

        s_Sql = "SELECT Show_Time.Show_Time AS Expr1 FROM  Movie_Schedule INNER JOIN Show_Time ON Movie_Schedule.Show_ID = Show_Time.Show_ID INNER JOIN Movie_Details ON Movie_Schedule.Movie_ID = Movie_Details.Movie_ID where Movie_Schedule.Show_ID<=24 and Movie_Details.Movie_Name='" & cboMovie.SelectedValue & "'"

        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)
        cbostime.DataSource = o_data.Tables(0)
        cbostime.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cbostime.ValueMember = o_data.Tables(0).Columns(0).ColumnName

    End Sub
    Private Sub Fillmovie()

        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet


        s_Sql = "SELECT Movie_Details.Movie_Name FROM  Movie_Details INNER Join Movie_Schedule ON Movie_Details.Movie_ID = Movie_Schedule.Movie_ID where movie_schedule.mdate= '" & txtdate.Text & "' group by movie_details.movie_name"
        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)

        cboMovie.DataSource = o_data.Tables(0)
        cboMovie.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cboMovie.ValueMember = o_data.Tables(0).Columns(0).ColumnName

    End Sub

    Private Sub Clear()
        txtdate.Text = ""
        cboMovie.SelectedIndex = (0)
        cbostime.SelectedIndex = (0)
        txtdate.Focus()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub cbostime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbostime.SelectedIndexChanged
        btnnext.Enabled = True
    End Sub

    Private Sub cboMovie_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMovie.DropDownClosed
        Fillshowtime()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click


        CurrentBooking.txtcrtdate.Text = txtdate.Text
        CurrentBooking.txtcrtMoviename.Text = cboMovie.Text
        CurrentBooking.txtcrtshowtime.Text = cbostime.Text
        CurrentBooking.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Welcome.Show()
        Me.Close()
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TeleBooking.Show()
        Me.Close()

    End Sub

    Private Sub cboMovie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMovie.SelectedIndexChanged

    End Sub
End Class