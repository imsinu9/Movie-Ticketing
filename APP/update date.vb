Imports System.Data.SqlClient
Public Class update_date
    

    Private Sub update_date_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    Private Sub dtpold_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpold.ValueChanged
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim Lv As ListViewItem

        s_sql = "select ms.mdate,st.Show_Time from Movie_Schedule ms,Show_Time st where ms.Show_ID =st.Show_ID and ms.mDate ='" & dtpold.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader()
        ListView1.Items.Clear()

        While o_Reader.Read
            Lv = ListView1.Items.Add(o_Reader("mdate"))
            Lv.SubItems.Add(o_Reader("Show_Time"))
        End While
        o_Reader.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        Dim s_sql1 As String
        Dim o_cmd1 As SqlCommand
        Dim j As Integer
        Dim showid(24) As Integer


        s_sql = "Select st.Show_ID from Movie_Schedule ms,Show_Time st where ms.Show_ID=st.Show_ID and ms.mdate='" & dtpold.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader()
        While o_Reader.Read
            showid(j) = o_Reader(0)
            j = j + 1
        End While
        o_Reader.Close()
        For k As Integer = LBound(showid) To UBound(showid)
            s_sql1 = "Update Movie_Schedule set mdate='" & DateValue(dtpnew.Value) & "' where Show_ID='" & showid(k) & "'"
            o_cmd1 = New SqlCommand(s_sql1, o_con)
            o_cmd1.ExecuteNonQuery()
        Next

        LoadData()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class