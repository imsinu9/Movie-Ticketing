Imports System.Data.SqlClient
Public Class changePrice

    Private Sub changePrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
    End Sub
    Private Sub loaddata()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        Dim lv As ListViewItem
        s_sql = "SELECT Audi_Class.Class_Name,Audi_Class.Price,audi_class.class_id FROM Show_Time INNER JOIN Audi_Class ON Show_Time.Show_ID = Audi_Class.Show_ID inner join Movie_Schedule on Movie_Schedule.Show_ID= Show_Time.Show_ID where Show_Time.Show_Time='" & cboShowTime.Text & "'and movie_schedule.mdate='" & dtpk.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader
        ListView1.Items.Clear()

        While o_reader.Read
            lv = ListView1.Items.Add(o_reader("class_id") & "")
            lv.SubItems.Add(o_reader("class_name") & "")
            lv.SubItems.Add(o_reader("Price") & "")
        End While
        o_reader.Close()

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Fillmovie()

        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet


        s_Sql = "SELECT Movie_Details.Movie_Name FROM  Movie_Details INNER Join Movie_Schedule ON Movie_Details.Movie_ID = Movie_Schedule.Movie_ID where movie_schedule.mdate='" & dtpk.Text & "' and Movie_Details.Active='Yes' group by movie_details.movie_name"
        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)

        cboMovieName.DataSource = o_data.Tables(0)
        cboMovieName.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cboMovieName.ValueMember = o_data.Tables(0).Columns(0).ColumnName

    End Sub

    Private Sub Fillshowtime()
        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet

        s_Sql = "SELECT Show_Time.Show_Time AS Expr1 FROM  Movie_Schedule INNER JOIN Show_Time ON Movie_Schedule.Show_ID = Show_Time.Show_ID INNER JOIN Movie_Details ON Movie_Schedule.Movie_ID = Movie_Details.Movie_ID where Movie_Schedule.Show_ID<=24 and Movie_Details.Movie_Name='" & cboMovieName.SelectedValue & "'"

        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)
        cboShowTime.DataSource = o_data.Tables(0)
        cboShowTime.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cboShowTime.ValueMember = o_data.Tables(0).Columns(0).ColumnName

    End Sub


    Private Sub cboMovieName_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMovieName.DropDownClosed
        Fillshowtime()
    End Sub

    Private Sub cboShowTime_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboShowTime.DropDownClosed
        loaddata()
    End Sub


    Private Sub ListView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim user As Integer
        user = ListView1.SelectedItems(0).Text

        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader

        s_sql = "SELECT class_name,price from audi_class where class_id=" & Val(user) & ""
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader

        If o_reader.Read Then
            TextBox1.Text = Val(user)
            txtclass.Text = o_reader("class_name") & ""
            txtprice.Text = o_reader("Price") & ""
        End If

        o_reader.Close()

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_Sql As String
        Dim o_cmd As SqlCommand

        s_Sql = "Update audi_class set price=@price where class_id=" & Val(TextBox1.Text)
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_cmd.Parameters.Add(New SqlParameter("@price", Val(txtprice.Text)))
        o_cmd.ExecuteNonQuery()

        MsgBox("Record Updated")
        loaddata()
    End Sub

    Private Sub btnexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        dtpk.Focus()

    End Sub

    Private Sub dtpk_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpk.ValueChanged
        Fillmovie()
    End Sub
End Class
