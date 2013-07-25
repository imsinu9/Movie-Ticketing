Imports System.Data.SqlClient
Module Module1
    Public o_con As SqlConnection
    Public g As Integer
    Public d As Integer
    Public n As Integer
    Public h As Integer
    Public i As Integer
    Public a As Integer
    Public b As Integer
    Public c As Integer





    Public Function Connect()
        Try
            o_con = New SqlConnection
            o_con.ConnectionString = "SERVER=.\sqlexpress; Database=Movie Ticket; Trusted_Connection=True"
            o_con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function CheckNumeric(ByVal KC As String, ByVal Str As String)
        If KC = "." Then
            Return ""

        End If

        If KC >= "0" And KC <= "9" Or Asc(KC) = 8 Then
            Return KC

        Else
            Return ""
        End If

    End Function
    Public Function AvailableSeats1(ByVal audi As String, ByVal Date1 As Date, ByRef seat As Integer)
        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        If audi = "Audi1" Then
            s_Sql = "Select 105-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='1' and Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi2" Then
            s_Sql = "Select 105-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " and Audi_ID='2' and Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi3" Then
            s_Sql = "Select 105-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='3' and Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi4" Then
            s_Sql = "Select 90-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='4' and Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi5" Then
            s_Sql = "Select 90-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='5' and Class_Name='Premium')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        Else
            Return False
        End If
    End Function
    Public Function AvailableSeats2(ByVal audi As String, ByVal Date1 As Date, ByRef seat As Integer)
        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        If audi = "Audi1" Then
            s_Sql = "Select 90-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='1' and Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi2" Then
            s_Sql = "Select 90-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='2' and Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi3" Then
            s_Sql = "Select 90-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='3' and Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi4" Then
            s_Sql = "Select 75-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='4' and Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi5" Then
            s_Sql = "Select 75-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='5' and Class_Name='Club')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        Else
            Return False
        End If
    End Function
    Public Function AvailableSeats3(ByVal audi As String, ByVal Date1 As Date, ByRef seat As Integer)
        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        If audi = "Audi1" Then
            s_Sql = "Select 15-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='1' and Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi2" Then
            s_Sql = "Select 15-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='2' and Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        ElseIf audi = "Audi3" Then
            s_Sql = "Select 15-(Select count(Booking_ID) from Seat_Selection where Date=" & Date1 & " Audi_ID='3' and Class_Name='Executive')"
            o_cmd = New SqlCommand(s_Sql, o_con)
            seat = s_Sql
            Return True
        Else
            Return False
        End If
    End Function
End Module
