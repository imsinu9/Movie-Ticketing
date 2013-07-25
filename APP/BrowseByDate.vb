Imports System.Data.SqlClient

Public Class BrowseByDate

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()

    End Sub
    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select sb.Movie_Name  ,st.Show_Time ,(select SUM(sb.Amount )) from Movie_Schedule ms,Show_Time st,Seat_Book sb where ms.Show_ID =st.Show_ID and sb.Show_ID =st.Show_ID and sb.mDate ='" & DateTimePicker1.Text & "' group by sb.Movie_Name , st.Show_Time "

        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader()
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("Movie_Name"))
            Lv.SubItems.Add(o_Reader("Show_Time"))
            Lv.SubItems.Add(o_Reader(2))
        End While
        o_Reader.Close()

    End Sub

    Private Sub BrowseByDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
    End Sub
End Class