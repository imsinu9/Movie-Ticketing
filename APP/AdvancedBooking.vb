Imports System.Data.SqlClient
Public Class AdvancedBooking

    Dim asd As String


    Private Sub Clear()
        cboDate.SelectedIndex = (0)
        cboMovieName.SelectedIndex = (0)
        cboShowTime.SelectedIndex = (0)
        txtNo_of_Seats.Text = ""
        txtSeatname.Text = ""
        txtAvailableClub.Text = ""
        txtAvailableExecutive.Text = ""
        txtAvailablePremium.Text = ""
        txtPriceClub.Text = ""
        txtPriceExecutive.Text = ""
        txtPricePremium.Text = ""
        txtAudi.Text = ""
        txtamnt.Text = ""
        cboDate.Focus()

    End Sub


    Private Sub txtNo_of_Seats_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNo_of_Seats.GotFocus

        AvailableSeats1()
        AvailableSeats2()
        AvailableSeats3()
        Price1()
        Price2()
        Price3()

        If rdoClub.Checked = False And rdoPremium.Checked = False And rdoExecutive.Checked = False Then
            rdoPremium.Focus()
            txtNo_of_Seats.Enabled = False
        ElseIf rdoClub.Checked = False And rdoPremium.Checked = False And rdoExecutive.Enabled = False Then
            rdoPremium.Focus()
            txtNo_of_Seats.Enabled = False

        End If
    End Sub

    Private Sub txtNo_of_Seats_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNo_of_Seats.KeyPress

        e.KeyChar = CheckNumeric(e.KeyChar, txtNo_of_Seats.Text)

    End Sub




    Private Sub AdvancedBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Connect()
        getnewbookingid()
        Filldate()
        btnamount.Enabled = False
        btnsubmit.Enabled = False
        btnseatselection.Enabled = False
        txtNo_of_Seats.Enabled = False


    End Sub


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click

        Welcome.Show()
        Me.Close()

    End Sub

    Private Sub btnseatselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseatselection.Click
        n = Val(txtNo_of_Seats.Text)
        i = 1
        
        If txtAudi.Text = "Audi1" Then
            seat210.Show()
            Me.Hide()
        End If

        If txtAudi.Text = "Audi2" Then
            seat210.Show()
            Me.Hide()
        End If

        If txtAudi.Text = "Audi3" Then
            seat210.Show()
            Me.Hide()
        End If

        If txtAudi.Text = "Audi4" Then
            seat165.Show()
            Me.Hide()
        End If

        If txtAudi.Text = "Audi5" Then
            seat165.Show()
            Me.Hide()
        End If

    End Sub

    Public Function AvailableSeats1()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader
        If txtAudi.Text = "Audi1" Then
            s_Sql = "Select 105-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=1 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi2" Then
            s_Sql = "Select 105-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=2 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi3" Then
            s_Sql = "Select 105-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=3 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi4" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=4 and ac.Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailablePremium.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi5" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=5 and ac.Class_Name='Premium')"
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
        If txtAudi.Text = "Audi1" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=1 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi2" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=2 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi3" Then
            s_Sql = "Select 90-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=3 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi4" Then
            s_Sql = "Select 75-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=4 and ac.Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_reader = o_cmd.ExecuteReader
            If o_reader.Read = True Then
                txtAvailableClub.Text = o_reader(0)
            End If
            o_reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi5" Then
            s_Sql = "Select 75-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=5 and ac.Class_Name='Club')"
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
        If txtAudi.Text = "Audi1" Then
            s_Sql = "Select 15-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=1 and ac.Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailableExecutive.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi2" Then
            s_Sql = "Select 15-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=2 and ac.Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtAvailableExecutive.Text = o_Reader(0)
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi3" Then
            s_Sql = "Select 15-(Select count(Booking_ID) as Available from Seat_Selection SS,Show_Time ST,Audi_Class ac where SS.Show_ID=ST.Show_ID and ss.Class_ID=ac.Class_ID and SS.mdate='" & cboDate.Text & "' and ST.Show_Time='" & cboShowTime.Text & "' and  SS.Audi_ID=3 and ac.Class_Name='Executive')"
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
        If txtAudi.Text = "Audi1" Or txtAudi.Text = "Audi2" Or txtAudi.Text = "Audi3" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on(AC.Show_ID = ST.Show_ID) where ST.Show_Time='" & cboShowTime.Text & "' and AC.Class_Name ='Premium'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPricePremium.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi4" Or txtAudi.Text = "Audi5" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on (AC.Show_ID = ST.Show_ID ) where ST.Show_Time='" & cboShowTime.Text & "' and AC.Class_Name ='Premium'"
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
        If txtAudi.Text = "Audi1" Or txtAudi.Text = "Audi2" Or txtAudi.Text = "Audi3" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on(AC.Show_ID = ST.Show_ID) where ST.Show_Time='" & cboShowTime.Text & "' and AC.Class_Name ='Club'"
            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader
            If o_Reader.Read = True Then
                txtPriceClub.Text = o_Reader("Price")
            End If
            o_Reader.Close()
            Return True
        ElseIf txtAudi.Text = "Audi4" Or txtAudi.Text = "Audi5" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on (AC.Show_ID = ST.Show_ID ) where ST.Show_Time='" & cboShowTime.Text & "' and AC.Class_Name ='Club'"
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
        If txtAudi.Text = "Audi1" Or txtAudi.Text = "Audi2" Or txtAudi.Text = "Audi3" Then
            s_Sql = "Select AC.Price from Audi_Class AC left outer join Show_Time ST on(AC.Show_ID = ST.Show_ID) where ST.Show_Time='" & cboShowTime.Text & "' and AC.Class_Name ='Executive'"
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

   
    Private Sub cboShowTime_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboShowTime.DropDownClosed
        Fillaudi()
        txtNo_of_Seats.Text = ""
        txtSeatname.Text = ""
        txtAvailableClub.Text = ""
        txtAvailableExecutive.Text = ""
        txtAvailablePremium.Text = ""
        txtPriceClub.Text = ""
        txtPriceExecutive.Text = ""
        txtPricePremium.Text = ""
        txtamnt.Text = ""

    End Sub

    Private Sub cboDate_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDate.DropDownClosed
        txtAudi.Text = ""
        cboMovieName.Text = ""
        txtAvailableClub.Text = ""
        txtAvailableExecutive.Text = ""
        txtAvailablePremium.Text = ""
        txtPriceClub.Text = ""
        txtPriceExecutive.Text = ""
        txtPricePremium.Text = ""

        txtNo_of_Seats.Text = ""
        txtSeatname.Text = ""
        txtamnt.Text = ""
        Fillmovie()
    End Sub

    Private Sub cboMovieName_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMovieName.DropDownClosed
        txtAudi.Text = ""
        txtNo_of_Seats.Text = ""
        txtSeatname.Text = ""
        txtAvailableClub.Text = ""
        txtAvailableExecutive.Text = ""
        txtAvailablePremium.Text = ""
        txtPriceClub.Text = ""
        txtPriceExecutive.Text = ""
        txtPricePremium.Text = ""
        txtamnt.Text = ""
        Fillshowtime()
    End Sub

    Private Sub Fillmovie()

        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet


        s_Sql = "SELECT Movie_Details.Movie_Name FROM  Movie_Details INNER Join Movie_Schedule ON Movie_Details.Movie_ID = Movie_Schedule.Movie_ID where movie_schedule.mdate= '" & cboDate.SelectedValue & "' and Movie_Details.Active='Yes' group by movie_details.movie_name"
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

    Private Sub Filldate()
        Dim s_Sql As String
        Dim o_adapter As SqlDataAdapter
        Dim o_data As Data.DataSet

        s_Sql = "SELECT mdate from movie_schedule group by mdate"
        o_adapter = New SqlDataAdapter(s_Sql, o_con)
        o_data = New Data.DataSet
        o_adapter.Fill(o_data)
        cboDate.DataSource = o_data.Tables(0)
        cboDate.DisplayMember = o_data.Tables(0).Columns(0).ColumnName
        cboDate.ValueMember = o_data.Tables(0).Columns(0).ColumnName

    End Sub

    Private Sub Fillaudi()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader
        s_sql = "SELECT Audi_Detail.Audi_Name FROM Audi INNER JOIN Show_Time ON Audi.Show_ID = Show_Time.Show_ID INNER JOIN Audi_Detail ON Audi.Audi_ID = Audi_Detail.Audi_ID where Show_Time.Show_Time = '" & cboShowTime.SelectedValue & "'"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader
        If o_reader.Read Then
            txtAudi.Text = o_reader("Audi_Name")
        End If

        o_reader.Close()

    End Sub

    Private Sub txtNo_of_Seats_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNo_of_Seats.Leave
        If rdoPremium.Checked = True Then
            If Val(txtNo_of_Seats.Text) > Val(txtAvailablePremium.Text) Then
                MsgBox("Number of seats should be less then Available Seats")
                txtNo_of_Seats.Text = ""
                txtNo_of_Seats.Focus()
            End If
        End If

        If rdoClub.Checked = True Then
            If Val(txtNo_of_Seats.Text) > Val(txtAvailableClub.Text) Then
                MsgBox("Number of seats should be less then Available Seats")
                txtNo_of_Seats.Text = ""
                txtNo_of_Seats.Focus()
            End If
        End If

        If rdoExecutive.Checked = True Then
            If Val(txtNo_of_Seats.Text) > Val(txtAvailableExecutive.Text) Then
                MsgBox("Number of seats should be less then Available Seats")
                txtNo_of_Seats.Text = ""
                txtNo_of_Seats.Focus()
            End If
        End If

    End Sub

    Private Sub btnamount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamount.Click
        If txtSeatname.Text = "" Then
            
        Else
            a = Val(txtNo_of_Seats.Text)
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

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Clear()

    End Sub

    
    Private Sub txtNo_of_Seats_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo_of_Seats.TextChanged
        If txtNo_of_Seats.Text = "" Then
            btnamount.Enabled = False
            btnseatselection.Enabled = False
            btnsubmit.Enabled = False

        Else
            btnseatselection.Enabled = True

        End If
    End Sub

    Private Sub txtSeatname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeatname.TextChanged
        If txtSeatname.Text.StartsWith(",") Then
            txtSeatname.Text = txtSeatname.Text.Remove(0, 1)
        End If
       
        If txtSeatname.Text = "" Then
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
        AvailableSeats1()
        AvailableSeats2()
        AvailableSeats3()
        Price1()
        Price2()
        Price3()
        h = 1
        txtNo_of_Seats.Enabled = True
        txtNo_of_Seats.Text = ""
    End Sub

    Private Sub rdoClub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoClub.CheckedChanged
        AvailableSeats1()
        AvailableSeats2()
        AvailableSeats3()
        Price1()
        Price2()
        Price3()
        h = 2
        txtNo_of_Seats.Enabled = True
        txtNo_of_Seats.Text = ""
    End Sub

    Private Sub rdoExecutive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoExecutive.CheckedChanged
        AvailableSeats1()
        AvailableSeats2()
        AvailableSeats3()
        Price1()
        Price2()
        Price3()
        h = 3
        txtNo_of_Seats.Enabled = True
        txtNo_of_Seats.Text = ""
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

        o_cmd.Parameters.Add(New SqlParameter("@mdate", cboDate.Text))
        o_cmd.Parameters.Add(New SqlParameter("@bookingid", txtbookid.Text))

        Dim o_Reader1 As SqlDataReader
        s_sql1 = "select Audi_ID from Audi_Detail where Audi_Name='" & txtAudi.Text & "'"
        o_cmd1 = New SqlCommand(s_sql1, o_con)
        o_Reader1 = o_cmd1.ExecuteReader

        If o_Reader1.Read = True Then

            audiid = o_Reader1("Audi_ID")
            o_cmd.Parameters.Add(New SqlParameter("@Audi_ID", o_Reader1("Audi_ID")))
        End If
        o_Reader1.Close()


        Dim o_Reader2 As SqlDataReader
        s_sql2 = "select ST.Show_ID from Show_Time ST,Movie_Schedule MS where MS.Show_ID=ST.Show_ID and ST.Show_Time='" & cboShowTime.Text & "' and MS.mdate='" & cboDate.Text & "'"
        o_cmd2 = New SqlCommand(s_sql2, o_con)
        o_Reader2 = o_cmd2.ExecuteReader
        If o_Reader2.Read = True Then
            showid = o_Reader2(0)
            o_cmd.Parameters.Add(New SqlParameter("@Show_ID", o_Reader2(0)))
        End If
        o_Reader2.Close()

        o_cmd.Parameters.Add(New SqlParameter("@MovieName", cboMovieName.Text))
        Dim o_Reader3 As SqlDataReader
        If rdoPremium.Checked = True Then
            s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & cboShowTime.Text & "' and MS.mdate='" & cboDate.Text & "' and ac.Class_Name='Premium'"
        ElseIf rdoClub.Checked = True Then
            s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & cboShowTime.Text & "' and MS.mdate='" & cboDate.Text & "' and ac.Class_Name='Club'"
        Else
            s_sql3 = "select ac.Class_ID from Show_Time ST,Movie_Schedule MS,Audi_Class ac where MS.Show_ID=ST.Show_ID and ac.Show_ID=ST.Show_ID and ST.Show_Time='" & cboShowTime.Text & "' and MS.mdate='" & cboDate.Text & "' and ac.Class_Name='Executive'"
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

        o_cmd.Parameters.Add(New SqlParameter("@No_of_Seats", txtNo_of_Seats.Text))
        o_cmd.ExecuteNonQuery()


        Dim seat As String
        Dim seat1() As String
        Dim i As Integer
        seat = txtSeatname.Text
        seat1 = Split(seat, ",")

        Dim s_Sql5 As String
        Dim s_sql9 As String

        Dim o_cmd5 As SqlCommand
        Dim o_cmd9 As SqlCommand



        Dim o_Reader9 As SqlDataReader

        date1 = cboDate.Text
        bookid = txtbookid.Text

        For i = LBound(seat1) To UBound(seat1)

            s_Sql5 = "Insert into Seat_Selection (mDate,Booking_ID,Audi_ID ,Show_ID,Class_ID,Seat_ID) values('" & date1 & "'," & bookid & "," & audiid & "," & showid & "," & classid & ",@seatid)"
            o_cmd5 = New SqlCommand(s_Sql5, o_con)

            s_sql9 = "Select Seat_ID from Seat_ID where Seat_Name='" & seat1(i) & "'  and Audi_Name='" & txtAudi.Text & "'"
            o_cmd9 = New SqlCommand(s_sql9, o_con)
            o_Reader9 = o_cmd9.ExecuteReader
            If o_Reader9.Read = True Then
                o_cmd5.Parameters.Add(New SqlParameter("@seatid", o_Reader9("Seat_ID")))
            End If
            o_Reader9.Close()
            o_cmd5.ExecuteNonQuery()
        Next
        MsgBox("TICKET BOOKED...")
        print.txtpdate.Text = cboDate.Text
        print.txtpname.Text = cboMovieName.Text
        print.txtptime.Text = cboShowTime.Text
        If (rdoPremium.Checked = True) Then
            print.txtpclass.Text = "Premium"
        ElseIf (rdoExecutive.Checked = True) Then
            print.txtpclass.Text = "Executive"
        ElseIf rdoClub.Checked = True Then
            print.txtpclass.Text = "Club"
        End If
        print.txtpaudi.Text = txtAudi.Text
        print.txtseat.Text = txtSeatname.Text
        print.txtamt.Text = txtamnt.Text
        print.Show()

        Me.Close()
    End Sub
    Private Sub getnewbookingid()
        Dim s_sql As String
        Dim o_cmd As SqlCommand
        Dim o_reader As SqlDataReader

        s_sql = "select max(booking_id) from Seat_Book"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_reader = o_cmd.ExecuteReader
        If o_reader.Read Then
            txtbookid.Text = Val(o_reader(0) & "") + 3
        Else
            txtbookid.Text = "101180"
        End If
        o_reader.Close()
    End Sub

    Private Sub txtAudi_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAudi.TextChanged

        If txtAudi.Text = "Audi1" Or txtAudi.Text = "Audi2" Or txtAudi.Text = "Audi3" Then
            rdoExecutive.Visible = True
            txtAvailableExecutive.Visible = True
            txtPriceExecutive.Visible = True
        End If

        If txtAudi.Text = "Audi4" Or txtAudi.Text = "Audi5" Then
            rdoExecutive.Visible = False
            txtAvailableExecutive.Visible = False
            txtPriceExecutive.Visible = False
        End If


    End Sub

    Private Sub txtAvailablePremium_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAvailablePremium.TextChanged

    End Sub
End Class