Imports System.Data.SqlClient

Public Class CurrentBooking



    Private Sub clear()
        txtcrtNo_of_Seats.Text = ""
        txtcrtSeatname.Text = ""
        txtAvailableClub.Text = ""
        txtAvailableExecutive.Text = ""
        txtAvailablePremium.Text = ""
        txtPriceClub.Text = ""
        txtPriceExecutive.Text = ""
        txtPricePremium.Text = ""
        txtamnt.Text = ""
        AvailableSeats1()
        AvailableSeats2()
        AvailableSeats3()
        Price1()
        Price2()
        Price3()
        GroupBox2.Focus()
    End Sub

   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        getnewbookingid()


        Fillaudi()

        rdoPremium.Focus()


        btnseatselection.Enabled = False
        btnamount.Enabled = False
        btnsubmit.Enabled = False
        txtcrtNo_of_Seats.Enabled = False

        AvailableSeats1()
        AvailableSeats2()
        AvailableSeats3()
        Price1()
        Price2()
        Price3()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseatselection.Click
        n = Val(txtcrtNo_of_Seats.Text)
        i = 2

        If txtcrtAudi.Text = "Audi1" Then
            seat210.Show()
            Me.Hide()
        End If
        If txtcrtAudi.Text = "Audi2" Then
            seat210.Show()
            Me.Hide()
        End If
        If txtcrtAudi.Text = "Audi3" Then
            seat210.Show()
            Me.Hide()
        End If
        If txtcrtAudi.Text = "Audi4" Then
            seat165.Show()
            Me.Hide()
        End If
        If txtcrtAudi.Text = "Audi5" Then
            seat165.Show()
            Me.Hide()
        End If
    End Sub

    Public Function AvailableSeats1()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        If txtcrtAudi.Text = "Audi1" Then
            s_Sql = "Select 105-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=1 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi2" Then
            s_Sql = "Select 105-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=2 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi3" Then
            s_Sql = "Select 105-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=3 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi4" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=4 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi5" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=5 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        Else
            Return False
        End If

    End Function

    Public Function AvailableSeats2()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        If txtcrtAudi.Text = "Audi1" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=1 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi2" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=2 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi3" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=3 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi4" Then
            s_Sql = "Select 75-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=4 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi5" Then
            s_Sql = "Select 75-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=5 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        Else
            Return False
        End If

    End Function

    Public Function AvailableSeats3()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        If txtcrtAudi.Text = "Audi1" Then
            s_Sql = "Select 15-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=1 and ac.Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailableExecutive.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi2" Then
            s_Sql = "Select 15-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=2 and ac.Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailableExecutive.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi3" Then
            s_Sql = "Select 15-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & txtcrtdate.Text & "' and ST.Show_Time='" & txtcrtshowtime.Text & "' and  SS.Audi_ID=3 and ac.Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailableExecutive.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        Else
            Return False
        End If

    End Function


    Public Function Price1()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        If txtcrtAudi.Text = "Audi1" Or txtcrtAudi.Text = "Audi2" Or txtcrtAudi.Text = "Audi3" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on(AC.Show_ID = ST.Show_ID) where ST.Show_Time='" & txtcrtshowtime.Text & "' and AC.Class_Name ='Premium'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPricePremium.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi4" Or txtcrtAudi.Text = "Audi5" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on (AC.Show_ID = ST.Show_ID ) where ST.Show_Time='" & txtcrtshowtime.Text & "' and AC.Class_Name ='Premium'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPricePremium.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Price2()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        If txtcrtAudi.Text = "Audi1" Or txtcrtAudi.Text = "Audi2" Or txtcrtAudi.Text = "Audi3" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on(AC.Show_ID = ST.Show_ID) where ST.Show_Time='" & txtcrtshowtime.Text & "' and AC.Class_Name ='Club'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPriceClub.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        ElseIf txtcrtAudi.Text = "Audi4" Or txtcrtAudi.Text = "Audi5" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on (AC.Show_ID = ST.Show_ID ) where ST.Show_Time='" & txtcrtshowtime.Text & "' and AC.Class_Name ='Club'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPriceClub.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Price3()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        If txtcrtAudi.Text = "Audi1" Or txtcrtAudi.Text = "Audi2" Or txtcrtAudi.Text = "Audi3" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on(AC.Show_ID = ST.Show_ID) where ST.Show_Time='" & txtcrtshowtime.Text & "' and AC.Class_Name ='Executive'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPriceExecutive.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        Else
            Return False
        End If

    End Function


    Public Sub Fillaudi()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        s_sql = "SELECT Audi_Detail.Audi_Name FROM Audi INNER JOIN Show_Time ON Audi.Show_ID = Show_Time.Show_ID INNER JOIN Audi_Detail ON Audi.Audi_ID = Audi_Detail.Audi_ID where Show_Time.Show_Time = '" & txtcrtshowtime.Text & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader
        If o_reader.Read Then
            txtcrtAudi.Text = o_reader("Audi_Name")
        End If

        o_reader.Close()

    End Sub


    Private Sub btnamount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamount.Click

        If txtcrtSeatname.Text = "" Then

        Else
            a = Val(txtcrtNo_of_Seats.Text)
            If rdoPremium.Checked = True Then
                b = Val(txtPricePremium.Text)
                c = a * b
            End If

            If rdoClub.Checked = True Then
                b = Val(txtPriceClub.Text)
                c = a * b
            End If


            If rdoExecutive.Checked = True Then
                b = Val(txtPriceExecutive.Text)
                c = a * b

            End If
            txtamnt.Text = c
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Public Sub fillmovie()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        s_sql = "SELECT Movie_Details.Movie_Name FROM Movie_Schedule INNER JOIN Movie_Details ON Movie_Schedule.Movie_ID = Movie_Details.Movie_ID INNER JOIN Show_Time ON Movie_Schedule.Show_ID = Show_Time.Show_ID where Show_Time.Show_Time='" & txtcrtshowtime.Text & "' group by Movie_Name"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader
        If o_reader.Read Then
            txtcrtMoviename.Text = o_reader("Movie_Name")
        End If

        o_reader.Close()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        

        DefaultPage.Show()
        Me.Close()

    End Sub

    Private Sub txtcrtNo_of_Seats_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcrtNo_of_Seats.GotFocus
        If rdoClub.Checked = False And rdoPremium.Checked = False And rdoExecutive.Checked = False Then
            txtcrtNo_of_Seats.Enabled = False
        ElseIf rdoClub.Checked = False And rdoPremium.Checked = False And rdoExecutive.Enabled = False Then
            txtcrtNo_of_Seats.Enabled = False

        End If
    End Sub

    Private Sub txtcrtNo_of_Seats_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcrtNo_of_Seats.KeyPress
        e.KeyChar = CheckNumeric(e.KeyChar, txtcrtNo_of_Seats.Text)
    End Sub

    Private Sub txtcrtNo_of_Seats_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcrtNo_of_Seats.Leave
        If rdoPremium.Checked = True Then
            If Val(txtcrtNo_of_Seats.Text) > Val(txtAvailablePremium.Text) Then
                MsgBox("Number of seats should be less then Available Seats")
                txtcrtNo_of_Seats.Text = ""
                txtcrtNo_of_Seats.Focus()
            End If
        End If

        If rdoClub.Checked = True Then
            If Val(txtcrtNo_of_Seats.Text) > Val(txtAvailableClub.Text) Then
                MsgBox("Number of seats should be less then Available Seats")
                txtcrtNo_of_Seats.Text = ""
                txtcrtNo_of_Seats.Focus()
            End If
        End If

        If rdoExecutive.Checked = True Then
            If Val(txtcrtNo_of_Seats.Text) > Val(txtAvailableExecutive.Text) Then
                MsgBox("Number of seats should be less then Available Seats")
                txtcrtNo_of_Seats.Text = ""
                txtcrtNo_of_Seats.Focus()
            End If
        End If

    End Sub


    Private Sub txtcrtNo_of_Seats_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcrtNo_of_Seats.TextChanged
        If txtcrtNo_of_Seats.Text = "" Then
            txtcrtSeatname.Text = ""
            txtamnt.Text = ""
            btnamount.Enabled = False
            btnseatselection.Enabled = False
            btnsubmit.Enabled = False

        Else
            btnseatselection.Enabled = True

        End If
    End Sub

    Private Sub txtcrtSeatname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcrtSeatname.TextChanged
        If txtcrtSeatname.Text.StartsWith(",") Then
            txtcrtSeatname.Text = txtcrtSeatname.Text.Remove(0, 1)
        End If
        
        If txtcrtSeatname.Text = "" Then
            txtamnt.Text = ""
            btnamount.Enabled = False
            btnsubmit.Enabled = False

        Else
            btnamount.Enabled = True
        End If
    End Sub

    Private Sub txtamnt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamnt.TextChanged
        If txtamnt.Text = "" Then
            btnsubmit.Enabled = False

        Else
            btnsubmit.Enabled = True

        End If
    End Sub

    Private Sub rdoPremium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPremium.CheckedChanged
        h = 1
        txtcrtNo_of_Seats.Enabled = True
        txtcrtNo_of_Seats.Text = ""
    End Sub

    Private Sub rdoClub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoClub.CheckedChanged
        h = 2
        txtcrtNo_of_Seats.Enabled = True
        txtcrtNo_of_Seats.Text = ""
    End Sub

    Private Sub rdoExecutive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoExecutive.CheckedChanged
        h = 3
        txtcrtNo_of_Seats.Enabled = True
        txtcrtNo_of_Seats.Text = ""
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        Dim s_Sql As String
        Dim s_sql1 As String
        Dim s_sql2 As String
        Dim s_sql3 As String
        Dim o_cmd As SqlCommand
        Dim o_cmd1 As SqlCommand
        Dim o_cmd2 As SqlCommand
        Dim o_cmd3 As SqlCommand

        Dim audiid As Integer
        Dim classid As Integer
        Dim showid As Integer
        Dim date1 As String
        Dim bookid As Integer

        s_Sql = "Insert into Seat_Book (mDate,booking_id,Audi_ID,Show_ID,Movie_Name,Class_ID,Price,No_of_Seats) values(@mdate,@bookingid,@Audi_ID,@Show_ID,@MovieName,@Class_ID,@Price,@No_of_Seats) "
        o_cmd = New SqlCommand(s_Sql, o_con)

        o_cmd.Parameters.Add(New SqlParameter("@mdate", txtcrtdate.Text))
        o_cmd.Parameters.Add(New SqlParameter("@bookingid", txtcrtbookid.Text))

        Dim o_Reader1 As SqlDataReader
        s_sql1 = "select Audi_ID from Audi_Detail where Audi_Name='" & txtcrtAudi.Text & "'"
        o_cmd1 = New SqlCommand(s_sql1, o_con)
        o_Reader1 = o_cmd1.ExecuteReader

        If o_Reader1.Read = True Then

            audiid = o_Reader1("Audi_ID")
            o_cmd.Parameters.Add(New SqlParameter("@Audi_ID", o_Reader1("Audi_ID")))
        End If
        o_Reader1.Close()


        Dim o_Reader2 As SqlDataReader
        s_sql2 = "select ST.Show_ID from Show_Time ST,Movie_Schedule MS where MS.Show_ID=ST.Show_ID and ST.Show_Time='" & txtcrtshowtime.Text & "' and MS.mdate='" & txtcrtdate.Text & "'"
        o_cmd2 = New SqlCommand(s_sql2, o_con)
        o_Reader2 = o_cmd2.ExecuteReader
        If o_Reader2.Read = True Then
            showid = o_Reader2(0)
            o_cmd.Parameters.Add(New SqlParameter("@Show_ID", o_Reader2(0)))
        End If
        o_Reader2.Close()

        o_cmd.Parameters.Add(New SqlParameter("@MovieName", txtcrtMoviename.Text))
        Dim o_Reader3 As SqlDataReader
        If rdoPremium.Checked = True Then
            s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & txtcrtshowtime.Text & "' and MS.mdate='" & txtcrtdate.Text & "' and ac.Class_Name='Premium'"
        ElseIf rdoClub.Checked = True Then
            s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & txtcrtshowtime.Text & "' and MS.mdate='" & txtcrtdate.Text & "'and ac.Class_Name='Club'"
        Else
            s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & txtcrtshowtime.Text & "' and MS.mdate='" & txtcrtdate.Text & "'and ac.Class_Name='Executive'"
        End If
        o_cmd3 = New SqlCommand(s_sql3, o_con)
        o_Reader3 = o_cmd3.ExecuteReader

        If o_Reader3.Read = True Then
            classid = o_Reader3(0)
            o_cmd.Parameters.Add(New SqlParameter("@Class_ID", o_Reader3(0)))
        End If
        o_Reader3.Close()

        If rdoPremium.Checked = True Then
            o_cmd.Parameters.Add(New SqlParameter("@Price", txtPricePremium.Text))
        End If

        If rdoClub.Checked = True Then
            o_cmd.Parameters.Add(New SqlParameter("@Price", txtPriceClub.Text))
        End If

        If rdoExecutive.Checked = True Then
            o_cmd.Parameters.Add(New SqlParameter("@Price", txtPriceExecutive.Text))
        End If

        o_cmd.Parameters.Add(New SqlParameter("@No_of_Seats", txtcrtNo_of_Seats.Text))
        o_cmd.ExecuteNonQuery()


        Dim seat As String
        Dim seat1() As String
        Dim i As Integer
        seat = txtcrtSeatname.Text
        seat1 = Split(seat, ",")

        Dim s_Sql5 As String
        Dim s_sql9 As String

        Dim o_cmd5 As SqlCommand
        Dim o_cmd9 As SqlCommand

        Dim o_Reader9 As SqlDataReader

        date1 = txtcrtdate.Text
        bookid = txtcrtbookid.Text

        For i = LBound(seat1) To UBound(seat1)

            s_Sql5 = "Insert into Seat_Selection (mDate,Booking_ID,Audi_ID ,Show_ID,Class_ID,Seat_ID) values('" & date1 & "'," & bookid & "," & audiid & "," & showid & "," & classid & ",@seatid)"
            o_cmd5 = New SqlCommand(s_Sql5, o_con)

            s_sql9 = "Select Seat_ID from Seat_ID where Seat_Name='" & seat1(i) & "'  and Audi_Name='" & txtcrtAudi.Text & "'"
            o_cmd9 = New SqlCommand(s_sql9, o_con)
            o_Reader9 = o_cmd9.ExecuteReader
            If o_Reader9.Read = True Then
                o_cmd5.Parameters.Add(New SqlParameter("@seatid", o_Reader9("Seat_ID")))
            End If
            o_Reader9.Close()
            o_cmd5.ExecuteNonQuery()
        Next
        MsgBox("TICKET BOOKED")
        print.txtpdate.Text = txtcrtdate.Text
        print.txtpname.Text = txtcrtMoviename.Text
        print.txtptime.Text = txtcrtshowtime.Text
        If (rdoPremium.Checked = True) Then
            print.txtpclass.Text = "Premium"
        ElseIf (rdoExecutive.Checked = True) Then
            print.txtpclass.Text = "Executive"
        ElseIf rdoClub.Checked = True Then
            print.txtpclass.Text = "Club"
        End If

        print.txtpaudi.Text = txtcrtAudi.Text
        print.txtseat.Text = txtcrtSeatname.Text
        print.txtamt.Text = txtamnt.Text
        print.Show()
        Me.Close()

    End Sub
    Private Sub getnewbookingid()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader

        s_sql = "select max(booking_id) from seat_book"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader
        If o_reader.Read Then
            txtcrtbookid.Text = Val(o_reader(0) & "") + 3
        Else
            txtcrtbookid.Text = "101180"
        End If
        o_reader.Close()
    End Sub

    Private Sub txtcrtAudi_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcrtAudi.TextChanged
        If txtcrtAudi.Text = "Audi1" Or txtcrtAudi.Text = "Audi2" Or txtcrtAudi.Text = "Audi3" Then
            rdoExecutive.Visible = True
            txtAvailableExecutive.Visible = True
            txtPriceExecutive.Visible = True
        End If

        If txtcrtAudi.Text = "Audi4" Or txtcrtAudi.Text = "Audi5" Then
            rdoExecutive.Visible = False
            txtAvailableExecutive.Visible = False
            txtPriceExecutive.Visible = False
        End If
    End Sub
End Class