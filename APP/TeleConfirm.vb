
Imports System.Data.SqlClient
Public Class TeleConfirm

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Welcome.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TeleID.Show()
        Me.Close()
    End Sub

    Private Sub TeleConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()


        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        s_sql = "Select p.mdate,ad.Audi_Name,st.Show_Time,p.Movie_Name,ac.Class_Name,p.Price,p.No_of_Seats,p.Amount from phone p,Audi_Class ac,Show_Time st,Movie_Schedule ms,audi_detail ad where p.Audi_ID=ad.Audi_ID and p.Show_ID=st.Show_ID and p.Class_ID=ac.Class_ID and p.Booking_ID='" & TeleID.txtteleid.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        If o_Reader.Read = True Then
            txtteledate.Text = o_Reader(0)
            txtteleaudi.Text = o_Reader(1)
            txttelestime.Text = o_Reader(2)
            txttelemovie.Text = o_Reader(3)
            txtteleclass.Text = o_Reader(4)
            txtteleprice.Text = o_Reader(5)
            txtteleno_of_seats.Text = o_Reader(6)
            txtamnt.Text = o_Reader(7)
        End If
        o_Reader.Close()

        Dim s_Sql1 As String
        Dim o_cmd1 As SqlCommand
        Dim o_reader1 As SqlDataReader


        s_Sql1 = "select si.Seat_Name from Seat_ID si,Seat_Selection ss where si.Seat_ID =ss.Seat_ID and ss.Booking_ID ='" & TeleID.txtteleid.Text & "'"

        o_cmd1 = New SqlCommand(s_Sql1, o_con)
        o_reader1 = o_cmd1.ExecuteReader
        While o_reader1.Read
            txtteleseatname.Text = txtteleseatname.Text & o_reader1(0) & " "
        End While
        o_reader1.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        s_sql = "Delete from phone where booking_ID='" & txtTeleID.Text & "' "
        o_cmd = New SqlCommand(s_sql, o_con)
        o_cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim s_sql1 As String
        Dim s_sql2 As String
        Dim s_sql3 As String
        Dim o_cmd1 As SqlCommand
        Dim o_cmd2 As SqlCommand
        Dim o_cmd3 As SqlCommand
        Dim o_Reader As SqlDataReader
        s_Sql = "Insert into Seat_Book (mDate,booking_ID,Audi_ID,Show_ID,Movie_Name,Class_ID,Price,No_of_Seats) values(@mdate,@bookid,@Audi_ID,@Show_ID,@MovieName,@Class_ID,@Price,@No_of_Seats) "
        o_cmd = New SqlCommand(s_Sql, o_con)
        o_cmd.Parameters.Add(New SqlParameter("@mdate", txtteledate.Text))
        o_cmd.Parameters.Add(New SqlParameter("@bookid", txtTeleID.Text))

        s_sql1 = "select Audi_ID from Audi_Detail where Audi_Name='" & txtteleaudi.Text & "'"
        o_cmd1 = New SqlCommand(s_sql1, o_con)
        o_Reader = o_cmd1.ExecuteReader
        If o_Reader.Read = True Then
            o_cmd.Parameters.Add(New SqlParameter("@Audi_ID", o_Reader("Audi_ID")))
        End If
        o_Reader.Close()

        s_sql2 = "select ST.Show_ID from Show_Time ST,Movie_Schedule MS where MS.Show_ID=ST.Show_ID and ST.Show_Time='" & txttelestime.Text & "' and MS.mdate='" & txtteledate.Text & "'"
        o_cmd2 = New SqlCommand(s_sql1, o_con)
        o_Reader = o_cmd2.ExecuteReader
        If o_Reader.Read = True Then
            o_cmd.Parameters.Add(New SqlParameter("@Show_ID", o_Reader(0)))
        End If
        o_Reader.Close()

        o_cmd.Parameters.Add(New SqlParameter("@MovieName", txttelemovie.Text))

        s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & txttelestime.Text & "' and MS.mdate='" & txttelestime.Text & "'"
        o_cmd3 = New SqlCommand(s_sql1, o_con)
        o_Reader = o_cmd2.ExecuteReader
        If o_Reader.Read = True Then
            o_cmd.Parameters.Add(New SqlParameter("@class_ID", o_Reader(0)))
        End If
        o_Reader.Close()

        o_cmd.Parameters.Add(New SqlParameter("@Price", txtteleprice.Text))
        o_cmd.Parameters.Add(New SqlParameter("@No_of_Seats", txtteleno_of_seats.Text))

        o_cmd.ExecuteNonQuery()

        MsgBox("Ticket Confirmed..")

        print.txtpdate.Text = txtteledate.Text
        print.txtpname.Text = txttelemovie.Text
        print.txtptime.Text = txttelestime.Text
        print.txtpclass.Text = txtteleclass.Text
        print.txtpaudi.Text = txtteleaudi.Text
        print.txtseat.Text = txtteleseatname.Text
        print.txtseat.Text = print.txtseat.Text.Replace(" ", ",")
        print.txtseat.Text = print.txtseat.Text.Remove(Len(print.txtseat.Text) - 1, 1)
        print.txtamt.Text = txtamnt.Text
        print.Show()
        Me.Close()

    End Sub


    Private Sub txtTeleID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTeleID.TextChanged
       
    End Sub
End Class