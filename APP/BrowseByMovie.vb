Imports System.Data.SqlClient
Public Class BrowseByMovie

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub BrowseByMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        Fillmovie()
    End Sub
    Private Sub Fillmovie()

        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet


        s_Sql = "SELECT Movie_Details.Movie_Name FROM  Movie_Details INNER Join Movie_Schedule ON Movie_Details.Movie_ID = Movie_Schedule.Movie_ID where Movie_Details.Active='Yes' group by movie_details.movie_name "
        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)

        cboMovieName.DataSource = o_data.Tables(0)
        cboMovieName.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cboMovieName.ValueMember = o_data.Tables(0).Columns(0).ColumnName

    End Sub

    Private Sub cboMovieName_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMovieName.DropDownClosed
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_sql = "Select Release_Date from  Movie_Details where Movie_Name='" & cboMovieName.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        If o_Reader.Read = True Then
            txtreldate.Text = o_Reader(0)
        End If
        o_Reader.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_sql = "Select sum(Amount) from  Seat_Book where Movie_Name='" & cboMovieName.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        If o_Reader.Read = True Then
            txtcollection.Text = o_Reader(0) & ""
        End If
        o_Reader.Close()
    End Sub
End Class