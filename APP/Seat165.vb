Imports System.Data.SqlClient
Public Class seat165

    Dim m As Integer
    Dim o As Integer



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If i = 1 Then
            AdvancedBooking.Show()
            Me.Close()
        ElseIf i = 2 Then
            CurrentBooking.Show()
            Me.Close()
        ElseIf i = 3 Then
            TeleBooking.Show()
            Me.Close()
        End If
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checkcolor()
        If m + 1 < n Then
            MsgBox(" No Of Selected Seat Should Be = " & n)
            Exit Sub
        End If
        If i = 1 Then
            AdvancedBooking.Show()
        ElseIf i = 2 Then
            CurrentBooking.Show()
        ElseIf i = 3 Then
            TeleBooking.Show()
        End If


        Me.Close()

    End Sub

    Private Sub A1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.Click

        If A1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A1.BackColor = Color.LawnGreen
        End If
    End Sub


    Private Sub A2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.Click
        If A2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.Click
        If A3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.Click
        If A4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5.Click

        If A5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6.Click
        If A6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A7.Click
        If A7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A8.Click
        If A8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A9.Click
        If A9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A10.Click
        If A10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A11.Click
        If A11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A12.Click
        If A12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A13.Click
        If A13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A14.Click
        If A14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A15.Click
        If A15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            A15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If B1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        If B2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        If B3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        If B4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        If B5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        If B6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B7.Click
        If B7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B8.Click
        If B8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B9.Click
        If B9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B10.Click
        If B10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B11.Click
        If B11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B12.Click
        If B12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B13.Click
        If B13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B14.Click
        If B14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub B15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B15.Click
        If B15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            B15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        If C1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.Click
        If C2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3.Click
        If C3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.Click
        If C4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5.Click
        If C5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6.Click
        If C6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C7.Click
        If C7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C8.Click
        If C8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C9.Click
        If C9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C10.Click
        If C10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C11.Click
        If C11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C12.Click
        If C12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C13.Click
        If C13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C14.Click
        If C14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub C15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C15.Click
        If C15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            C15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click
        If D1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D1.BackColor = Color.LawnGreen
        End If
    End Sub


    Private Sub D2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2.Click
        If D2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3.Click
        If D3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4.Click
        If D4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5.Click
        If D5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6.Click
        If D6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D7.Click
        If D7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D8.Click
        If D8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D9.Click
        If D9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D10.Click
        If D10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D11.Click
        If D11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D12.Click
        If D12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D13.Click
        If D13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D14.Click
        If D14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub D15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D15.Click
        If D15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            D15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        If E1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2.Click
        If E2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3.Click
        If E3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4.Click
        If E4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5.Click
        If E5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6.Click
        If E6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E7.Click
        If E7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E8.Click
        If E8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E9.Click
        If E9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E10.Click
        If E10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E11.Click
        If E11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E12.Click
        If E12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E13.Click
        If E13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E14.Click
        If E14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub E15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E15.Click
        If E15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            E15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1.Click
        If F1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2.Click
        If F2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3.Click
        If F3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4.Click
        If F4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5.Click
        If F5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6.Click
        If F6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F7.Click
        If F7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F8.Click
        If F8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F9.Click
        If F9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F10.Click
        If F10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F11.Click
        If F11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F12.Click
        If F12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F13.Click
        If F13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F14.Click
        If F14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub F15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F15.Click
        If F15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            F15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H1.Click
        If H1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2.Click
        If H2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3.Click
        If H3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4.Click
        If H4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5.Click
        If H5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6.Click
        If H6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H7.Click
        If H7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H8.Click
        If H8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H9.Click
        If H9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H10.Click
        If H10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H11.Click
        If H11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H12.Click
        If H12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H13.Click
        If H13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H14.Click
        If H14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub H15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H15.Click
        If H15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            H15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I1.Click
        If I1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I2.Click
        If I2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I3.Click
        If I3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I4.Click
        If I4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I5.Click
        If I5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I6.Click
        If I6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I7.Click
        If I7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I8.Click
        If I8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I9.Click
        If I9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I10.Click
        If I10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I11.Click
        If I11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I12.Click
        If I12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I13.Click
        If I13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I14.Click
        If I14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub I15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I15.Click
        If I15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            I15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J1.Click
        If J1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J2.Click
        If J2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J3.Click
        If J3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J4.Click
        If J4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J5.Click
        If J5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J6.Click
        If J6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J7.Click
        If J7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J8.Click
        If J8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J9.Click
        If J9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J10.Click
        If J10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J11.Click
        If J11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J12.Click
        If J12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J13.Click
        If J13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J14.Click
        If J14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub J15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J15.Click
        If J15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            J15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K1.Click
        If K1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K2.Click
        If K2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K3.Click
        If K3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K4.Click
        If K4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K5.Click
        If K5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K6.Click
        If K6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K7.Click
        If K7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K8.Click
        If K8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K9.Click
        If K9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K10.Click
        If K10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K11.Click
        If K11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K12.Click
        If K12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K13.Click
        If K13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K14.Click
        If K14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub K15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K15.Click
        If K15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            K15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        If G1.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G1.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.Click
        If G2.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G2.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3.Click
        If G3.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G3.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4.Click
        If G4.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G4.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5.Click
        If G5.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G5.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6.Click
        If G6.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G6.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G7.Click
        If G7.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G7.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G8.Click
        If G8.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G8.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G9.Click
        If G9.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G9.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G10.Click
        If G10.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G10.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G11.Click
        If G11.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G11.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G12.Click
        If G12.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G12.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G13.Click
        If G13.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G13.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G14.Click
        If G14.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G14.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub G15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G15.Click
        If G15.BackColor = Color.LightSteelBlue Then

            noofseatselected()
            If o = 1 Then
                Exit Sub
            End If
            G15.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub A1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.DoubleClick


        A1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub seat165_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        selectclass()

        If i = 1 Then
            fillred()
        ElseIf i = 2 Then
            fillred3()
        ElseIf i = 3 Then
            fillred2()
        End If
    End Sub
    Private Sub checkcolor()
        If i = 1 Then
            AdvancedBooking.txtSeatname.Text = ""
            If A1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = "A1"

            End If



            If A2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A2"
            End If
            If A3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A3"
            End If
            If A4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A4"
            End If
            If A5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A5"
            End If
            If A6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A6"
            End If
            If A7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A7"
            End If
            If A8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A8"
            End If
            If A9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A9"
            End If
            If A10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A10"
            End If
            If A11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A11"
            End If
            If A12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A12"
            End If
            If A13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A13"
            End If
            If A14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A14"
            End If
            If A15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "A15"
            End If

            If B1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B1"

            End If

            If B2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B2"
            End If
            If B3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B3"
            End If
            If B4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B4"
            End If
            If B5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B5"
            End If
            If B6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B6"
            End If
            If B7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B7"
            End If
            If B8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B8"
            End If
            If B9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B9"
            End If
            If B10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B10"
            End If
            If B11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B11"
            End If
            If B12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B12"
            End If
            If B13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B13"
            End If
            If B14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B14"
            End If
            If B15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "B15"
            End If
            If C1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C1"

            End If

            If C2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C2"
            End If
            If C3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C3"
            End If
            If C4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C4"
            End If
            If C5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C5"
            End If
            If C6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C6"
            End If
            If C7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C7"
            End If
            If C8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C8"
            End If
            If C9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C9"
            End If
            If C10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C10"
            End If
            If C11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C11"
            End If
            If C12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C12"
            End If
            If C13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C13"
            End If
            If C14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C14"
            End If
            If C15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "C15"
            End If
            If D1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D1"

            End If

            If D2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D2"
            End If
            If D3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D3"
            End If
            If D4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D4"
            End If
            If D5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D5"
            End If
            If D6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D6"
            End If
            If D7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D7"
            End If
            If D8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D8"
            End If
            If D9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D9"
            End If
            If D10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D10"
            End If
            If D11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D11"
            End If
            If D12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D12"
            End If
            If D13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D13"
            End If
            If D14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D14"
            End If
            If D15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "D15"
            End If
            If E1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E1"

            End If

            If E2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E2"
            End If
            If E3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E3"
            End If
            If E4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E4"
            End If
            If E5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E5"
            End If
            If E6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E6"
            End If
            If E7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E7"
            End If
            If E8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E8"
            End If
            If E9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E9"
            End If
            If E10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E10"
            End If
            If E11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E11"
            End If
            If E12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E12"
            End If
            If E13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E13"
            End If
            If E14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E14"
            End If
            If E15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "E15"
            End If
            If F1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F1"

            End If

            If F2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F2"
            End If
            If F3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F3"
            End If
            If F4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F4"
            End If
            If F5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F5"
            End If
            If F6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F6"
            End If
            If F7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F7"
            End If
            If F8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F8"
            End If
            If F9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F9"
            End If
            If F10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F10"
            End If
            If F11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F11"
            End If
            If F12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F12"
            End If
            If F13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F13"
            End If
            If F14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F14"
            End If
            If F15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "F15"
            End If

            If G1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G1"

            End If

            If G2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G2"
            End If
            If G3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G3"
            End If
            If G4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G4"
            End If
            If G5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G5"
            End If
            If G6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G6"
            End If
            If G7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G7"
            End If
            If G8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G8"
            End If
            If G9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G9"
            End If
            If G10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G10"
            End If
            If G11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G11"
            End If
            If G12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G12"
            End If
            If G13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G13"
            End If
            If G14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G14"
            End If
            If G15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "G15"
            End If

            If H1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H1"

            End If

            If H2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H2"
            End If
            If H3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H3"
            End If
            If H4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H4"
            End If
            If H5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H5"
            End If
            If H6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H6"
            End If
            If H7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H7"
            End If
            If H8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H8"
            End If
            If H9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H9"
            End If
            If H10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H10"
            End If
            If H11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H11"
            End If
            If H12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H12"
            End If
            If H13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H13"
            End If
            If H14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H14"
            End If
            If H15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "H15"
            End If


            If I1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I1"

            End If

            If I2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I2"
            End If
            If I3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I3"
            End If
            If I4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I4"
            End If
            If I5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I5"
            End If
            If I6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I6"
            End If
            If I7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I7"
            End If
            If I8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I8"
            End If
            If I9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I9"
            End If
            If I10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I10"
            End If
            If I11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I11"
            End If
            If I12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I12"
            End If
            If I13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I13"
            End If
            If I14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I14"
            End If
            If I15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "I15"
            End If


            If J1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J1"

            End If

            If J2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J2"
            End If
            If J3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J3"
            End If
            If J4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J4"
            End If
            If J5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J5"
            End If
            If J6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J6"
            End If
            If J7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J7"
            End If
            If J8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J8"
            End If
            If J9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J9"
            End If
            If J10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J10"
            End If
            If J11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J11"
            End If
            If J12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J12"
            End If
            If J13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J13"
            End If
            If J14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J14"
            End If
            If J15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "J15"
            End If


            If K1.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K1"

            End If

            If K2.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K2"
            End If
            If K3.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K3"
            End If
            If K4.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K4"
            End If
            If K5.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K5"
            End If
            If K6.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K6"
            End If
            If K7.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K7"
            End If
            If K8.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K8"
            End If
            If K9.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K9"
            End If
            If K10.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K10"
            End If
            If K11.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K11"
            End If
            If K12.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K12"
            End If
            If K13.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K13"
            End If
            If K14.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K14"
            End If
            If K15.BackColor = Color.LawnGreen Then
                AdvancedBooking.txtSeatname.Text = AdvancedBooking.txtSeatname.Text & "," & "K15"
            End If
        ElseIf i = 2 Then
            CurrentBooking.txtcrtSeatname.Text = ""
            If A1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = "A1"

            End If



            If A2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A2"
            End If
            If A3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A3"
            End If
            If A4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A4"
            End If
            If A5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A5"
            End If
            If A6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A6"
            End If
            If A7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A7"
            End If
            If A8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A8"
            End If
            If A9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A9"
            End If
            If A10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A10"
            End If
            If A11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A11"
            End If
            If A12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A12"
            End If
            If A13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A13"
            End If
            If A14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A14"
            End If
            If A15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "A15"
            End If

            If B1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B1"

            End If

            If B2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B2"
            End If
            If B3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B3"
            End If
            If B4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B4"
            End If
            If B5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B5"
            End If
            If B6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B6"
            End If
            If B7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B7"
            End If
            If B8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B8"
            End If
            If B9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B9"
            End If
            If B10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B10"
            End If
            If B11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B11"
            End If
            If B12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B12"
            End If
            If B13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B13"
            End If
            If B14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B14"
            End If
            If B15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "B15"
            End If
            If C1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C1"

            End If

            If C2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C2"
            End If
            If C3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C3"
            End If
            If C4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C4"
            End If
            If C5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C5"
            End If
            If C6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C6"
            End If
            If C7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C7"
            End If
            If C8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C8"
            End If
            If C9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C9"
            End If
            If C10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C10"
            End If
            If C11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C11"
            End If
            If C12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C12"
            End If
            If C13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C13"
            End If
            If C14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C14"
            End If
            If C15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "C15"
            End If
            If D1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D1"

            End If

            If D2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D2"
            End If
            If D3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D3"
            End If
            If D4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D4"
            End If
            If D5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D5"
            End If
            If D6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D6"
            End If
            If D7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D7"
            End If
            If D8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D8"
            End If
            If D9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D9"
            End If
            If D10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D10"
            End If
            If D11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D11"
            End If
            If D12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D12"
            End If
            If D13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D13"
            End If
            If D14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D14"
            End If
            If D15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "D15"
            End If
            If E1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E1"

            End If

            If E2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E2"
            End If
            If E3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E3"
            End If
            If E4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E4"
            End If
            If E5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E5"
            End If
            If E6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E6"
            End If
            If E7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E7"
            End If
            If E8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E8"
            End If
            If E9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E9"
            End If
            If E10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E10"
            End If
            If E11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E11"
            End If
            If E12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E12"
            End If
            If E13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E13"
            End If
            If E14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E14"
            End If
            If E15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "E15"
            End If
            If F1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F1"

            End If

            If F2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F2"
            End If
            If F3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F3"
            End If
            If F4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F4"
            End If
            If F5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F5"
            End If
            If F6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F6"
            End If
            If F7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F7"
            End If
            If F8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F8"
            End If
            If F9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F9"
            End If
            If F10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F10"
            End If
            If F11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F11"
            End If
            If F12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F12"
            End If
            If F13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F13"
            End If
            If F14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F14"
            End If
            If F15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "F15"
            End If

            If G1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G1"

            End If

            If G2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G2"
            End If
            If G3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G3"
            End If
            If G4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G4"
            End If
            If G5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G5"
            End If
            If G6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G6"
            End If
            If G7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G7"
            End If
            If G8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G8"
            End If
            If G9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G9"
            End If
            If G10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G10"
            End If
            If G11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G11"
            End If
            If G12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G12"
            End If
            If G13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G13"
            End If
            If G14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G14"
            End If
            If G15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "G15"
            End If

            If H1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H1"

            End If

            If H2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H2"
            End If
            If H3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H3"
            End If
            If H4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H4"
            End If
            If H5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H5"
            End If
            If H6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H6"
            End If
            If H7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H7"
            End If
            If H8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H8"
            End If
            If H9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H9"
            End If
            If H10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H10"
            End If
            If H11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H11"
            End If
            If H12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H12"
            End If
            If H13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H13"
            End If
            If H14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H14"
            End If
            If H15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "H15"
            End If


            If I1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I1"

            End If

            If I2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I2"
            End If
            If I3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I3"
            End If
            If I4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I4"
            End If
            If I5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I5"
            End If
            If I6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I6"
            End If
            If I7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I7"
            End If
            If I8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I8"
            End If
            If I9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I9"
            End If
            If I10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I10"
            End If
            If I11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I11"
            End If
            If I12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I12"
            End If
            If I13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I13"
            End If
            If I14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I14"
            End If
            If I15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "I15"
            End If


            If J1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J1"

            End If

            If J2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J2"
            End If
            If J3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J3"
            End If
            If J4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J4"
            End If
            If J5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J5"
            End If
            If J6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J6"
            End If
            If J7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J7"
            End If
            If J8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J8"
            End If
            If J9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J9"
            End If
            If J10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J10"
            End If
            If J11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J11"
            End If
            If J12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J12"
            End If
            If J13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J13"
            End If
            If J14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J14"
            End If
            If J15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "J15"
            End If


            If K1.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K1"

            End If

            If K2.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K2"
            End If
            If K3.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K3"
            End If
            If K4.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K4"
            End If
            If K5.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K5"
            End If
            If K6.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K6"
            End If
            If K7.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K7"
            End If
            If K8.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K8"
            End If
            If K9.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K9"
            End If
            If K10.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K10"
            End If
            If K11.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K11"
            End If
            If K12.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K12"
            End If
            If K13.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K13"
            End If
            If K14.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K14"
            End If
            If K15.BackColor = Color.LawnGreen Then
                CurrentBooking.txtcrtSeatname.Text = CurrentBooking.txtcrtSeatname.Text & "," & "K15"
            End If
        ElseIf i = 3 Then

            TeleBooking.txtphnseatnam.Text = ""
            If A1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = "A1"

            End If



            If A2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A2"
            End If
            If A3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A3"
            End If
            If A4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A4"
            End If
            If A5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A5"
            End If
            If A6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A6"
            End If
            If A7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A7"
            End If
            If A8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A8"
            End If
            If A9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A9"
            End If
            If A10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A10"
            End If
            If A11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A11"
            End If
            If A12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A12"
            End If
            If A13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A13"
            End If
            If A14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A14"
            End If
            If A15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "A15"
            End If

            If B1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B1"

            End If

            If B2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B2"
            End If
            If B3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B3"
            End If
            If B4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B4"
            End If
            If B5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B5"
            End If
            If B6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B6"
            End If
            If B7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B7"
            End If
            If B8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B8"
            End If
            If B9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B9"
            End If
            If B10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B10"
            End If
            If B11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B11"
            End If
            If B12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B12"
            End If
            If B13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B13"
            End If
            If B14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B14"
            End If
            If B15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "B15"
            End If
            If C1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C1"

            End If

            If C2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C2"
            End If
            If C3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C3"
            End If
            If C4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C4"
            End If
            If C5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C5"
            End If
            If C6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C6"
            End If
            If C7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C7"
            End If
            If C8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C8"
            End If
            If C9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C9"
            End If
            If C10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C10"
            End If
            If C11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C11"
            End If
            If C12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C12"
            End If
            If C13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C13"
            End If
            If C14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C14"
            End If
            If C15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "C15"
            End If
            If D1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D1"

            End If

            If D2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D2"
            End If
            If D3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D3"
            End If
            If D4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D4"
            End If
            If D5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D5"
            End If
            If D6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D6"
            End If
            If D7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D7"
            End If
            If D8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D8"
            End If
            If D9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D9"
            End If
            If D10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D10"
            End If
            If D11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D11"
            End If
            If D12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D12"
            End If
            If D13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D13"
            End If
            If D14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D14"
            End If
            If D15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "D15"
            End If
            If E1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E1"

            End If

            If E2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E2"
            End If
            If E3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E3"
            End If
            If E4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E4"
            End If
            If E5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E5"
            End If
            If E6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E6"
            End If
            If E7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E7"
            End If
            If E8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E8"
            End If
            If E9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E9"
            End If
            If E10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E10"
            End If
            If E11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E11"
            End If
            If E12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E12"
            End If
            If E13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E13"
            End If
            If E14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E14"
            End If
            If E15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "E15"
            End If
            If F1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F1"

            End If

            If F2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F2"
            End If
            If F3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F3"
            End If
            If F4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F4"
            End If
            If F5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F5"
            End If
            If F6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F6"
            End If
            If F7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F7"
            End If
            If F8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F8"
            End If
            If F9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F9"
            End If
            If F10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F10"
            End If
            If F11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F11"
            End If
            If F12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F12"
            End If
            If F13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F13"
            End If
            If F14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F14"
            End If
            If F15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "F15"
            End If

            If G1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G1"

            End If

            If G2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G2"
            End If
            If G3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G3"
            End If
            If G4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G4"
            End If
            If G5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G5"
            End If
            If G6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G6"
            End If
            If G7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G7"
            End If
            If G8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G8"
            End If
            If G9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G9"
            End If
            If G10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G10"
            End If
            If G11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G11"
            End If
            If G12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G12"
            End If
            If G13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G13"
            End If
            If G14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G14"
            End If
            If G15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "G15"
            End If

            If H1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H1"

            End If

            If H2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H2"
            End If
            If H3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H3"
            End If
            If H4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H4"
            End If
            If H5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H5"
            End If
            If H6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H6"
            End If
            If H7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H7"
            End If
            If H8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H8"
            End If
            If H9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H9"
            End If
            If H10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H10"
            End If
            If H11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H11"
            End If
            If H12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H12"
            End If
            If H13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H13"
            End If
            If H14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H14"
            End If
            If H15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "H15"
            End If


            If I1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I1"

            End If

            If I2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I2"
            End If
            If I3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I3"
            End If
            If I4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I4"
            End If
            If I5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I5"
            End If
            If I6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I6"
            End If
            If I7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I7"
            End If
            If I8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I8"
            End If
            If I9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I9"
            End If
            If I10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I10"
            End If
            If I11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I11"
            End If
            If I12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I12"
            End If
            If I13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I13"
            End If
            If I14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I14"
            End If
            If I15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "I15"
            End If


            If J1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J1"

            End If

            If J2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J2"
            End If
            If J3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J3"
            End If
            If J4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J4"
            End If
            If J5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J5"
            End If
            If J6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J6"
            End If
            If J7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J7"
            End If
            If J8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J8"
            End If
            If J9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J9"
            End If
            If J10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J10"
            End If
            If J11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J11"
            End If
            If J12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J12"
            End If
            If J13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J13"
            End If
            If J14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J14"
            End If
            If J15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "J15"
            End If


            If K1.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K1"

            End If

            If K2.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K2"
            End If
            If K3.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K3"
            End If
            If K4.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K4"
            End If
            If K5.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K5"
            End If
            If K6.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K6"
            End If
            If K7.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K7"
            End If
            If K8.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K8"
            End If
            If K9.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K9"
            End If
            If K10.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K10"
            End If
            If K11.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K11"
            End If
            If K12.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K12"
            End If
            If K13.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K13"
            End If
            If K14.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K14"
            End If
            If K15.BackColor = Color.LawnGreen Then
                TeleBooking.txtphnseatnam.Text = TeleBooking.txtphnseatnam.Text & "," & "K15"
            End If
        End If
    End Sub

    Private Sub selectclass()
        If h = 2 Then
            A1.BackColor = Color.SlateGray
            A1.Enabled = False
            A2.BackColor = Color.SlateGray
            A2.Enabled = False
            A3.BackColor = Color.SlateGray
            A3.Enabled = False
            A4.BackColor = Color.SlateGray
            A4.Enabled = False
            A5.BackColor = Color.SlateGray
            A5.Enabled = False
            A6.BackColor = Color.SlateGray
            A6.Enabled = False
            A7.BackColor = Color.SlateGray
            A7.Enabled = False
            A8.BackColor = Color.SlateGray
            A8.Enabled = False
            A9.BackColor = Color.SlateGray
            A9.Enabled = False
            A10.BackColor = Color.SlateGray
            A10.Enabled = False
            A11.BackColor = Color.SlateGray
            A11.Enabled = False
            A12.BackColor = Color.SlateGray
            A12.Enabled = False
            A13.BackColor = Color.SlateGray
            A13.Enabled = False
            A14.BackColor = Color.SlateGray
            A14.Enabled = False
            A15.BackColor = Color.SlateGray
            A15.Enabled = False

            B1.BackColor = Color.SlateGray
            B1.Enabled = False
            B2.BackColor = Color.SlateGray
            B2.Enabled = False
            B3.BackColor = Color.SlateGray
            B3.Enabled = False
            B4.BackColor = Color.SlateGray
            B4.Enabled = False
            B5.BackColor = Color.SlateGray
            B5.Enabled = False
            B6.BackColor = Color.SlateGray
            B6.Enabled = False
            B7.BackColor = Color.SlateGray
            B7.Enabled = False
            B8.BackColor = Color.SlateGray
            B8.Enabled = False
            B9.BackColor = Color.SlateGray
            B9.Enabled = False
            B10.BackColor = Color.SlateGray
            B10.Enabled = False
            B11.BackColor = Color.SlateGray
            B11.Enabled = False
            B12.BackColor = Color.SlateGray
            B12.Enabled = False
            B13.BackColor = Color.SlateGray
            B13.Enabled = False
            B14.BackColor = Color.SlateGray
            B14.Enabled = False
            B15.BackColor = Color.SlateGray
            B15.Enabled = False


            C1.BackColor = Color.SlateGray
            C1.Enabled = False
            C2.BackColor = Color.SlateGray
            C2.Enabled = False
            C3.BackColor = Color.SlateGray
            C3.Enabled = False
            C4.BackColor = Color.SlateGray
            C4.Enabled = False
            C5.BackColor = Color.SlateGray
            C5.Enabled = False
            C6.BackColor = Color.SlateGray
            C6.Enabled = False
            C7.BackColor = Color.SlateGray
            C7.Enabled = False
            C8.BackColor = Color.SlateGray
            C8.Enabled = False
            C9.BackColor = Color.SlateGray
            C9.Enabled = False
            C10.BackColor = Color.SlateGray
            C10.Enabled = False
            C11.BackColor = Color.SlateGray
            C11.Enabled = False
            C12.BackColor = Color.SlateGray
            C12.Enabled = False
            C13.BackColor = Color.SlateGray
            C13.Enabled = False
            C14.BackColor = Color.SlateGray
            C14.Enabled = False
            C15.BackColor = Color.SlateGray
            C15.Enabled = False


            D1.BackColor = Color.SlateGray
            D1.Enabled = False
            D2.BackColor = Color.SlateGray
            D2.Enabled = False
            D3.BackColor = Color.SlateGray
            D3.Enabled = False
            D4.BackColor = Color.SlateGray
            D4.Enabled = False
            D5.BackColor = Color.SlateGray
            D5.Enabled = False
            D6.BackColor = Color.SlateGray
            D6.Enabled = False
            D7.BackColor = Color.SlateGray
            D7.Enabled = False
            D8.BackColor = Color.SlateGray
            D8.Enabled = False
            D9.BackColor = Color.SlateGray
            D9.Enabled = False
            D10.BackColor = Color.SlateGray
            D10.Enabled = False
            D11.BackColor = Color.SlateGray
            D11.Enabled = False
            D12.BackColor = Color.SlateGray
            D12.Enabled = False
            D13.BackColor = Color.SlateGray
            D13.Enabled = False
            D14.BackColor = Color.SlateGray
            D14.Enabled = False
            D15.BackColor = Color.SlateGray
            D15.Enabled = False

            E1.BackColor = Color.SlateGray
            E1.Enabled = False
            E2.BackColor = Color.SlateGray
            E2.Enabled = False
            E3.BackColor = Color.SlateGray
            E3.Enabled = False
            E4.BackColor = Color.SlateGray
            E4.Enabled = False
            E5.BackColor = Color.SlateGray
            E5.Enabled = False
            E6.BackColor = Color.SlateGray
            E6.Enabled = False
            E7.BackColor = Color.SlateGray
            E7.Enabled = False
            E8.BackColor = Color.SlateGray
            E8.Enabled = False
            E9.BackColor = Color.SlateGray
            E9.Enabled = False
            E10.BackColor = Color.SlateGray
            E10.Enabled = False
            E11.BackColor = Color.SlateGray
            E11.Enabled = False
            E12.BackColor = Color.SlateGray
            E12.Enabled = False
            E13.BackColor = Color.SlateGray
            E13.Enabled = False
            E14.BackColor = Color.SlateGray
            E14.Enabled = False
            E15.BackColor = Color.SlateGray
            E15.Enabled = False

            F1.BackColor = Color.SlateGray
            F1.Enabled = False
            F2.BackColor = Color.SlateGray
            F2.Enabled = False
            F3.BackColor = Color.SlateGray
            F3.Enabled = False
            F4.BackColor = Color.SlateGray
            F4.Enabled = False
            F5.BackColor = Color.SlateGray
            F5.Enabled = False
            F6.BackColor = Color.SlateGray
            F6.Enabled = False
            F7.BackColor = Color.SlateGray
            F7.Enabled = False
            F8.BackColor = Color.SlateGray
            F8.Enabled = False
            F9.BackColor = Color.SlateGray
            F9.Enabled = False
            F10.BackColor = Color.SlateGray
            F10.Enabled = False
            F11.BackColor = Color.SlateGray
            F11.Enabled = False
            F12.BackColor = Color.SlateGray
            F12.Enabled = False
            F13.BackColor = Color.SlateGray
            F13.Enabled = False
            F14.BackColor = Color.SlateGray
            F14.Enabled = False
            F15.BackColor = Color.SlateGray
            F15.Enabled = False
        End If
        If h = 1 Then
            G1.BackColor = Color.SlateGray
            G1.Enabled = False
            G2.BackColor = Color.SlateGray
            G2.Enabled = False
            G3.BackColor = Color.SlateGray
            G3.Enabled = False
            G4.BackColor = Color.SlateGray
            G4.Enabled = False
            G5.BackColor = Color.SlateGray
            G5.Enabled = False
            G6.BackColor = Color.SlateGray
            G6.Enabled = False
            G7.BackColor = Color.SlateGray
            G7.Enabled = False
            G8.BackColor = Color.SlateGray
            G8.Enabled = False
            G9.BackColor = Color.SlateGray
            G9.Enabled = False
            G10.BackColor = Color.SlateGray
            G10.Enabled = False
            G11.BackColor = Color.SlateGray
            G11.Enabled = False
            G12.BackColor = Color.SlateGray
            G12.Enabled = False
            G13.BackColor = Color.SlateGray
            G13.Enabled = False
            G14.BackColor = Color.SlateGray
            G14.Enabled = False
            G15.BackColor = Color.SlateGray
            G15.Enabled = False


            H1.BackColor = Color.SlateGray
            H1.Enabled = False
            H2.BackColor = Color.SlateGray
            H2.Enabled = False
            H3.BackColor = Color.SlateGray
            H3.Enabled = False
            H4.BackColor = Color.SlateGray
            H4.Enabled = False
            H5.BackColor = Color.SlateGray
            H5.Enabled = False
            H6.BackColor = Color.SlateGray
            H6.Enabled = False
            H7.BackColor = Color.SlateGray
            H7.Enabled = False
            H8.BackColor = Color.SlateGray
            H8.Enabled = False
            H9.BackColor = Color.SlateGray
            H9.Enabled = False
            H10.BackColor = Color.SlateGray
            H10.Enabled = False
            H11.BackColor = Color.SlateGray
            H11.Enabled = False
            H12.BackColor = Color.SlateGray
            H12.Enabled = False
            H13.BackColor = Color.SlateGray
            H13.Enabled = False
            H14.BackColor = Color.SlateGray
            H14.Enabled = False
            H15.BackColor = Color.SlateGray
            H15.Enabled = False

            I1.BackColor = Color.SlateGray
            I1.Enabled = False
            I2.BackColor = Color.SlateGray
            I2.Enabled = False
            I3.BackColor = Color.SlateGray
            I3.Enabled = False
            I4.BackColor = Color.SlateGray
            I4.Enabled = False
            I5.BackColor = Color.SlateGray
            I5.Enabled = False
            I6.BackColor = Color.SlateGray
            I6.Enabled = False
            I7.BackColor = Color.SlateGray
            I7.Enabled = False
            I8.BackColor = Color.SlateGray
            I8.Enabled = False
            I9.BackColor = Color.SlateGray
            I9.Enabled = False
            I10.BackColor = Color.SlateGray
            I10.Enabled = False
            I11.BackColor = Color.SlateGray
            I11.Enabled = False
            I12.BackColor = Color.SlateGray
            I12.Enabled = False
            I13.BackColor = Color.SlateGray
            I13.Enabled = False
            I14.BackColor = Color.SlateGray
            I14.Enabled = False
            I15.BackColor = Color.SlateGray
            I15.Enabled = False

            J1.BackColor = Color.SlateGray
            J1.Enabled = False
            J2.BackColor = Color.SlateGray
            J2.Enabled = False
            J3.BackColor = Color.SlateGray
            J3.Enabled = False
            J4.BackColor = Color.SlateGray
            J4.Enabled = False
            J5.BackColor = Color.SlateGray
            J5.Enabled = False
            J6.BackColor = Color.SlateGray
            J6.Enabled = False
            J7.BackColor = Color.SlateGray
            J7.Enabled = False
            J8.BackColor = Color.SlateGray
            J8.Enabled = False
            J9.BackColor = Color.SlateGray
            J9.Enabled = False
            J10.BackColor = Color.SlateGray
            J10.Enabled = False
            J11.BackColor = Color.SlateGray
            J11.Enabled = False
            J12.BackColor = Color.SlateGray
            J12.Enabled = False
            J13.BackColor = Color.SlateGray
            J13.Enabled = False
            J14.BackColor = Color.SlateGray
            J14.Enabled = False
            J15.BackColor = Color.SlateGray
            J15.Enabled = False

            K1.BackColor = Color.SlateGray
            K1.Enabled = False
            K2.BackColor = Color.SlateGray
            K2.Enabled = False
            K3.BackColor = Color.SlateGray
            K3.Enabled = False
            K4.BackColor = Color.SlateGray
            K4.Enabled = False
            K5.BackColor = Color.SlateGray
            K5.Enabled = False
            K6.BackColor = Color.SlateGray
            K6.Enabled = False
            K7.BackColor = Color.SlateGray
            K7.Enabled = False
            K8.BackColor = Color.SlateGray
            K8.Enabled = False
            K9.BackColor = Color.SlateGray
            K9.Enabled = False
            K10.BackColor = Color.SlateGray
            K10.Enabled = False
            K11.BackColor = Color.SlateGray
            K11.Enabled = False
            K12.BackColor = Color.SlateGray
            K12.Enabled = False
            K13.BackColor = Color.SlateGray
            K13.Enabled = False
            K14.BackColor = Color.SlateGray
            K14.Enabled = False
            K15.BackColor = Color.SlateGray
            K15.Enabled = False

        End If
    End Sub

    Private Sub A10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A10.DoubleClick

        A10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A11.DoubleClick

        A11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A12.DoubleClick

        A12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A13.DoubleClick

        A13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A14.DoubleClick

        A14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A15.DoubleClick

        A15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A2.DoubleClick

        A2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A3.DoubleClick

        A3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A4.DoubleClick

        A4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A5.DoubleClick

        A5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A6.DoubleClick

        A6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A7.DoubleClick

        A7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A8.DoubleClick

        A8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub A9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles A9.DoubleClick

        A9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B1.DoubleClick

        B1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B10.DoubleClick
        B1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B11.DoubleClick
        B11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B12.DoubleClick
        B12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B13.DoubleClick
        B13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B14.DoubleClick
        B14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B15.DoubleClick
        B15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B2.DoubleClick
        B2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B3.DoubleClick
        B3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B4.DoubleClick
        B4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B5.DoubleClick
        B5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B6.DoubleClick
        B6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B7.DoubleClick
        B7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B8.DoubleClick
        B8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub B9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles B9.DoubleClick
        B9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1.DoubleClick
        C1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C10.DoubleClick
        C10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C11.DoubleClick
        C11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C12.DoubleClick
        C12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C13.DoubleClick
        C13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C14.DoubleClick
        C14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C15.DoubleClick
        C15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C2.DoubleClick
        C2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C3.DoubleClick
        C3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C4.DoubleClick
        C4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C5.DoubleClick
        C5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C6.DoubleClick
        C6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C7.DoubleClick
        C7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C8.DoubleClick
        C8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub C9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C9.DoubleClick
        C9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D1.DoubleClick
        D1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D10.DoubleClick
        D10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D11.DoubleClick
        D11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D12.DoubleClick
        D12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D13.DoubleClick
        D13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D14.DoubleClick
        D14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D15.DoubleClick
        D15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D2.DoubleClick
        D2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D3.DoubleClick
        D3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D4.DoubleClick
        D4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D5.DoubleClick
        D5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D6.DoubleClick
        D6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D7.DoubleClick
        D7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D8.DoubleClick
        D8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub D9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles D9.DoubleClick
        D9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E1.DoubleClick
        E1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E10.DoubleClick
        E10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E11.DoubleClick
        E11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E12.DoubleClick
        E12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E13.DoubleClick
        E13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E14.DoubleClick
        E14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E15.DoubleClick
        E15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E2.DoubleClick
        E2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E3.DoubleClick
        E3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E4.DoubleClick
        E4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E5.DoubleClick
        E5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E6.DoubleClick
        E6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E7.DoubleClick
        E7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E8.DoubleClick
        E8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub E9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles E9.DoubleClick
        E9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1.DoubleClick
        F1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F10.DoubleClick
        F10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F11.DoubleClick
        F11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F12.DoubleClick
        F12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F13.DoubleClick
        F13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F14.DoubleClick
        F14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F15.DoubleClick
        F15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F2.DoubleClick
        F2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F3.DoubleClick
        F3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F4.DoubleClick
        F4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F5.DoubleClick
        F5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F6.DoubleClick
        F6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F7.DoubleClick
        F7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F8.DoubleClick
        F8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub F9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles F9.DoubleClick
        F9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G1.DoubleClick
        G1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G10.DoubleClick
        G10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G11.DoubleClick
        G11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G12.DoubleClick
        G12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G13.DoubleClick
        G13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G14.DoubleClick
        G14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G15.DoubleClick
        G15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G2.DoubleClick
        G2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G3.DoubleClick
        G3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G4.DoubleClick
        G4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G5.DoubleClick
        G5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G6.DoubleClick
        G6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G7.DoubleClick
        G7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G8.DoubleClick
        G8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub G9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles G9.DoubleClick
        G9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H1.DoubleClick
        H1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H10.DoubleClick
        H10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H11.DoubleClick
        H11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H12.DoubleClick
        H12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H13.DoubleClick
        H13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H14.DoubleClick
        H14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H15.DoubleClick
        H15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H2.DoubleClick
        H2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H3.DoubleClick
        H3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H4.DoubleClick
        H4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H5.DoubleClick
        H5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H6.DoubleClick
        H6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H7.DoubleClick
        H7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H8.DoubleClick
        H8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub H9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles H9.DoubleClick
        H9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I1.DoubleClick
        I1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I10.DoubleClick
        I10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I11.DoubleClick
        I11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I12.DoubleClick
        I12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I13.DoubleClick
        I13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I14.DoubleClick
        I14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I15.DoubleClick
        I15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I2.DoubleClick
        I2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I3.DoubleClick
        I3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I4.DoubleClick
        I4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I5.DoubleClick
        I5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I6.DoubleClick
        I6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I7.DoubleClick
        I7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I8.DoubleClick
        I8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub I9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles I9.DoubleClick
        I9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J1.DoubleClick
        J1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J10.DoubleClick
        J10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J11.DoubleClick
        J11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J12.DoubleClick
        J12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J13.DoubleClick
        J13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J14.DoubleClick
        J14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J15.DoubleClick
        J15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J2.DoubleClick
        J2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J3.DoubleClick
        J3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J4.DoubleClick
        J4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J5.DoubleClick
        J5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J6.DoubleClick
        J6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J7.DoubleClick
        J7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J8.DoubleClick
        J8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub J9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles J9.DoubleClick
        J9.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K1.DoubleClick
        K1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K10.DoubleClick
        K10.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K11.DoubleClick
        K11.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K12.DoubleClick
        K12.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K13.DoubleClick
        K13.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K14_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K14.DoubleClick
        K14.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K15.DoubleClick
        K15.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K2.DoubleClick
        K2.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K3.DoubleClick
        K3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K4.DoubleClick
        K4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K5.DoubleClick
        K5.BackColor = Color.LightSteelBlue
    End Sub


    Private Sub K6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K6.DoubleClick
        K6.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K7.DoubleClick
        K7.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K8.DoubleClick
        K8.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub K9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles K9.DoubleClick
        K9.BackColor = Color.LightSteelBlue
    End Sub
    Private Sub noofseatselected()
        m = 0
        o = 0
        If A1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If A3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If A4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If A5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If A6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If A7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If A15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If B15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If C15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If D14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If D15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If E14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If E15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If F14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If F15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If G1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If G14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If G15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If H1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If H14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If H15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If I1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If I14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If I15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If J1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If J14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If J15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If K1.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K2.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K3.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K4.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K5.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K6.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K7.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K8.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K9.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K10.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K11.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K12.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K13.BackColor = Color.LawnGreen Then
            m = m + 1
        End If

        If K14.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If K15.BackColor = Color.LawnGreen Then
            m = m + 1
        End If
        If n = m Then
            MsgBox("You cannot select more Seats")

            o = 1

        End If

    End Sub

    Private Sub reset()
        If A1.BackColor = Color.LawnGreen Then
            A1.BackColor = Color.LightSteelBlue
        End If
        If A2.BackColor = Color.LawnGreen Then
            A2.BackColor = Color.LightSteelBlue
        End If
        If A3.BackColor = Color.LawnGreen Then
            A3.BackColor = Color.LightSteelBlue
        End If
        If A4.BackColor = Color.LawnGreen Then
            A4.BackColor = Color.LightSteelBlue
        End If
        If A5.BackColor = Color.LawnGreen Then
            A5.BackColor = Color.LightSteelBlue
        End If
        If A6.BackColor = Color.LawnGreen Then
            A6.BackColor = Color.LightSteelBlue
        End If
        If A7.BackColor = Color.LawnGreen Then
            A7.BackColor = Color.LightSteelBlue
        End If
        If A8.BackColor = Color.LawnGreen Then
            A8.BackColor = Color.LightSteelBlue
        End If
        If A9.BackColor = Color.LawnGreen Then
            A9.BackColor = Color.LightSteelBlue
        End If
        If A10.BackColor = Color.LawnGreen Then
            A10.BackColor = Color.LightSteelBlue
        End If
        If A11.BackColor = Color.LawnGreen Then
            A11.BackColor = Color.LightSteelBlue
        End If
        If A12.BackColor = Color.LawnGreen Then
            A12.BackColor = Color.LightSteelBlue
        End If
        If A13.BackColor = Color.LawnGreen Then
            A13.BackColor = Color.LightSteelBlue
        End If
        If A14.BackColor = Color.LawnGreen Then
            A14.BackColor = Color.LightSteelBlue
        End If
        If A15.BackColor = Color.LawnGreen Then
            A15.BackColor = Color.LightSteelBlue
        End If
        If J1.BackColor = Color.LawnGreen Then
            J1.BackColor = Color.LightSteelBlue
        End If
        If J2.BackColor = Color.LawnGreen Then
            J2.BackColor = Color.LightSteelBlue
        End If
        If J3.BackColor = Color.LawnGreen Then
            J3.BackColor = Color.LightSteelBlue
        End If
        If J4.BackColor = Color.LawnGreen Then
            J4.BackColor = Color.LightSteelBlue
        End If
        If J5.BackColor = Color.LawnGreen Then
            J5.BackColor = Color.LightSteelBlue
        End If
        If J6.BackColor = Color.LawnGreen Then
            J6.BackColor = Color.LightSteelBlue
        End If
        If J7.BackColor = Color.LawnGreen Then
            J7.BackColor = Color.LightSteelBlue
        End If
        If J8.BackColor = Color.LawnGreen Then
            J8.BackColor = Color.LightSteelBlue
        End If
        If J9.BackColor = Color.LawnGreen Then
            J9.BackColor = Color.LightSteelBlue
        End If
        If J10.BackColor = Color.LawnGreen Then
            J10.BackColor = Color.LightSteelBlue
        End If
        If J11.BackColor = Color.LawnGreen Then
            J11.BackColor = Color.LightSteelBlue
        End If
        If J12.BackColor = Color.LawnGreen Then
            J12.BackColor = Color.LightSteelBlue
        End If
        If J13.BackColor = Color.LawnGreen Then
            J13.BackColor = Color.LightSteelBlue
        End If
        If J14.BackColor = Color.LawnGreen Then
            J14.BackColor = Color.LightSteelBlue
        End If
        If J15.BackColor = Color.LawnGreen Then
            J15.BackColor = Color.LightSteelBlue
        End If

        If B1.BackColor = Color.LawnGreen Then
            B1.BackColor = Color.LightSteelBlue
        End If
        If B2.BackColor = Color.LawnGreen Then
            B2.BackColor = Color.LightSteelBlue
        End If
        If B3.BackColor = Color.LawnGreen Then
            B3.BackColor = Color.LightSteelBlue
        End If
        If B4.BackColor = Color.LawnGreen Then
            B4.BackColor = Color.LightSteelBlue
        End If
        If B5.BackColor = Color.LawnGreen Then
            B5.BackColor = Color.LightSteelBlue
        End If
        If B6.BackColor = Color.LawnGreen Then
            B6.BackColor = Color.LightSteelBlue
        End If
        If B7.BackColor = Color.LawnGreen Then
            B7.BackColor = Color.LightSteelBlue
        End If
        If B8.BackColor = Color.LawnGreen Then
            B8.BackColor = Color.LightSteelBlue
        End If
        If B9.BackColor = Color.LawnGreen Then
            B9.BackColor = Color.LightSteelBlue
        End If
        If B10.BackColor = Color.LawnGreen Then
            B10.BackColor = Color.LightSteelBlue
        End If
        If B11.BackColor = Color.LawnGreen Then
            B11.BackColor = Color.LightSteelBlue
        End If
        If B12.BackColor = Color.LawnGreen Then
            B12.BackColor = Color.LightSteelBlue
        End If
        If B13.BackColor = Color.LawnGreen Then
            B13.BackColor = Color.LightSteelBlue
        End If
        If B14.BackColor = Color.LawnGreen Then
            B14.BackColor = Color.LightSteelBlue
        End If
        If B15.BackColor = Color.LawnGreen Then
            B15.BackColor = Color.LightSteelBlue
        End If

        If C1.BackColor = Color.LawnGreen Then
            C1.BackColor = Color.LightSteelBlue
        End If
        If C2.BackColor = Color.LawnGreen Then
            C2.BackColor = Color.LightSteelBlue
        End If
        If C3.BackColor = Color.LawnGreen Then
            C3.BackColor = Color.LightSteelBlue
        End If
        If C4.BackColor = Color.LawnGreen Then
            C4.BackColor = Color.LightSteelBlue
        End If
        If C5.BackColor = Color.LawnGreen Then
            C5.BackColor = Color.LightSteelBlue
        End If
        If C6.BackColor = Color.LawnGreen Then
            C6.BackColor = Color.LightSteelBlue
        End If
        If C7.BackColor = Color.LawnGreen Then
            C7.BackColor = Color.LightSteelBlue
        End If
        If C8.BackColor = Color.LawnGreen Then
            C8.BackColor = Color.LightSteelBlue
        End If
        If C9.BackColor = Color.LawnGreen Then
            C9.BackColor = Color.LightSteelBlue
        End If
        If C10.BackColor = Color.LawnGreen Then
            C10.BackColor = Color.LightSteelBlue
        End If
        If C11.BackColor = Color.LawnGreen Then
            C11.BackColor = Color.LightSteelBlue
        End If
        If C12.BackColor = Color.LawnGreen Then
            C12.BackColor = Color.LightSteelBlue
        End If
        If C13.BackColor = Color.LawnGreen Then
            C13.BackColor = Color.LightSteelBlue
        End If
        If C14.BackColor = Color.LawnGreen Then
            C14.BackColor = Color.LightSteelBlue
        End If
        If C15.BackColor = Color.LawnGreen Then
            C15.BackColor = Color.LightSteelBlue
        End If

        If D1.BackColor = Color.LawnGreen Then
            D1.BackColor = Color.LightSteelBlue
        End If
        If D2.BackColor = Color.LawnGreen Then
            D2.BackColor = Color.LightSteelBlue
        End If
        If D3.BackColor = Color.LawnGreen Then
            D3.BackColor = Color.LightSteelBlue
        End If
        If D4.BackColor = Color.LawnGreen Then
            D4.BackColor = Color.LightSteelBlue
        End If
        If D5.BackColor = Color.LawnGreen Then
            D5.BackColor = Color.LightSteelBlue
        End If
        If D6.BackColor = Color.LawnGreen Then
            D6.BackColor = Color.LightSteelBlue
        End If
        If D7.BackColor = Color.LawnGreen Then
            D7.BackColor = Color.LightSteelBlue
        End If
        If D8.BackColor = Color.LawnGreen Then
            D8.BackColor = Color.LightSteelBlue
        End If
        If D9.BackColor = Color.LawnGreen Then
            D9.BackColor = Color.LightSteelBlue
        End If
        If D10.BackColor = Color.LawnGreen Then
            D10.BackColor = Color.LightSteelBlue
        End If
        If D11.BackColor = Color.LawnGreen Then
            D11.BackColor = Color.LightSteelBlue
        End If
        If D12.BackColor = Color.LawnGreen Then
            D12.BackColor = Color.LightSteelBlue
        End If
        If D13.BackColor = Color.LawnGreen Then
            D13.BackColor = Color.LightSteelBlue
        End If
        If D14.BackColor = Color.LawnGreen Then
            D14.BackColor = Color.LightSteelBlue
        End If
        If D15.BackColor = Color.LawnGreen Then
            D15.BackColor = Color.LightSteelBlue
        End If

        If E1.BackColor = Color.LawnGreen Then
            E1.BackColor = Color.LightSteelBlue
        End If
        If E2.BackColor = Color.LawnGreen Then
            E2.BackColor = Color.LightSteelBlue
        End If
        If E3.BackColor = Color.LawnGreen Then
            E3.BackColor = Color.LightSteelBlue
        End If
        If E4.BackColor = Color.LawnGreen Then
            E4.BackColor = Color.LightSteelBlue
        End If
        If E5.BackColor = Color.LawnGreen Then
            E5.BackColor = Color.LightSteelBlue
        End If
        If E6.BackColor = Color.LawnGreen Then
            E6.BackColor = Color.LightSteelBlue
        End If
        If E7.BackColor = Color.LawnGreen Then
            E7.BackColor = Color.LightSteelBlue
        End If
        If E8.BackColor = Color.LawnGreen Then
            E8.BackColor = Color.LightSteelBlue
        End If
        If E9.BackColor = Color.LawnGreen Then
            E9.BackColor = Color.LightSteelBlue
        End If
        If E10.BackColor = Color.LawnGreen Then
            E10.BackColor = Color.LightSteelBlue
        End If
        If E11.BackColor = Color.LawnGreen Then
            E11.BackColor = Color.LightSteelBlue
        End If
        If E12.BackColor = Color.LawnGreen Then
            E12.BackColor = Color.LightSteelBlue
        End If
        If E13.BackColor = Color.LawnGreen Then
            E13.BackColor = Color.LightSteelBlue
        End If
        If E14.BackColor = Color.LawnGreen Then
            E14.BackColor = Color.LightSteelBlue
        End If
        If E15.BackColor = Color.LawnGreen Then
            E15.BackColor = Color.LightSteelBlue
        End If

        If F1.BackColor = Color.LawnGreen Then
            F1.BackColor = Color.LightSteelBlue
        End If
        If F2.BackColor = Color.LawnGreen Then
            F2.BackColor = Color.LightSteelBlue
        End If
        If F3.BackColor = Color.LawnGreen Then
            F3.BackColor = Color.LightSteelBlue
        End If
        If F4.BackColor = Color.LawnGreen Then
            F4.BackColor = Color.LightSteelBlue
        End If
        If F5.BackColor = Color.LawnGreen Then
            F5.BackColor = Color.LightSteelBlue
        End If
        If F6.BackColor = Color.LawnGreen Then
            F6.BackColor = Color.LightSteelBlue
        End If
        If F7.BackColor = Color.LawnGreen Then
            F7.BackColor = Color.LightSteelBlue
        End If
        If F8.BackColor = Color.LawnGreen Then
            F8.BackColor = Color.LightSteelBlue
        End If
        If F9.BackColor = Color.LawnGreen Then
            F9.BackColor = Color.LightSteelBlue
        End If
        If F10.BackColor = Color.LawnGreen Then
            F10.BackColor = Color.LightSteelBlue
        End If
        If F11.BackColor = Color.LawnGreen Then
            F11.BackColor = Color.LightSteelBlue
        End If
        If F12.BackColor = Color.LawnGreen Then
            F12.BackColor = Color.LightSteelBlue
        End If
        If F13.BackColor = Color.LawnGreen Then
            F13.BackColor = Color.LightSteelBlue
        End If
        If F14.BackColor = Color.LawnGreen Then
            F14.BackColor = Color.LightSteelBlue
        End If
        If F15.BackColor = Color.LawnGreen Then
            F15.BackColor = Color.LightSteelBlue
        End If

        If G1.BackColor = Color.LawnGreen Then
            G1.BackColor = Color.LightSteelBlue
        End If
        If G2.BackColor = Color.LawnGreen Then
            G2.BackColor = Color.LightSteelBlue
        End If
        If G3.BackColor = Color.LawnGreen Then
            G3.BackColor = Color.LightSteelBlue
        End If
        If G4.BackColor = Color.LawnGreen Then
            G4.BackColor = Color.LightSteelBlue
        End If
        If G5.BackColor = Color.LawnGreen Then
            G5.BackColor = Color.LightSteelBlue
        End If
        If G6.BackColor = Color.LawnGreen Then
            G6.BackColor = Color.LightSteelBlue
        End If
        If G7.BackColor = Color.LawnGreen Then
            G7.BackColor = Color.LightSteelBlue
        End If
        If G8.BackColor = Color.LawnGreen Then
            G8.BackColor = Color.LightSteelBlue
        End If
        If G9.BackColor = Color.LawnGreen Then
            G9.BackColor = Color.LightSteelBlue
        End If
        If G10.BackColor = Color.LawnGreen Then
            G10.BackColor = Color.LightSteelBlue
        End If
        If G11.BackColor = Color.LawnGreen Then
            G11.BackColor = Color.LightSteelBlue
        End If
        If G12.BackColor = Color.LawnGreen Then
            G12.BackColor = Color.LightSteelBlue
        End If
        If G13.BackColor = Color.LawnGreen Then
            G13.BackColor = Color.LightSteelBlue
        End If
        If G14.BackColor = Color.LawnGreen Then
            G14.BackColor = Color.LightSteelBlue
        End If
        If G15.BackColor = Color.LawnGreen Then
            G15.BackColor = Color.LightSteelBlue
        End If

        If H1.BackColor = Color.LawnGreen Then
            H1.BackColor = Color.LightSteelBlue
        End If
        If H2.BackColor = Color.LawnGreen Then
            H2.BackColor = Color.LightSteelBlue
        End If
        If H3.BackColor = Color.LawnGreen Then
            H3.BackColor = Color.LightSteelBlue
        End If
        If H4.BackColor = Color.LawnGreen Then
            H4.BackColor = Color.LightSteelBlue
        End If
        If H5.BackColor = Color.LawnGreen Then
            H5.BackColor = Color.LightSteelBlue
        End If
        If H6.BackColor = Color.LawnGreen Then
            H6.BackColor = Color.LightSteelBlue
        End If
        If H7.BackColor = Color.LawnGreen Then
            H7.BackColor = Color.LightSteelBlue
        End If
        If H8.BackColor = Color.LawnGreen Then
            H8.BackColor = Color.LightSteelBlue
        End If
        If H9.BackColor = Color.LawnGreen Then
            H9.BackColor = Color.LightSteelBlue
        End If
        If H10.BackColor = Color.LawnGreen Then
            H10.BackColor = Color.LightSteelBlue
        End If
        If H11.BackColor = Color.LawnGreen Then
            H11.BackColor = Color.LightSteelBlue
        End If
        If H12.BackColor = Color.LawnGreen Then
            H12.BackColor = Color.LightSteelBlue
        End If
        If H13.BackColor = Color.LawnGreen Then
            H13.BackColor = Color.LightSteelBlue
        End If
        If H14.BackColor = Color.LawnGreen Then
            H14.BackColor = Color.LightSteelBlue
        End If
        If H15.BackColor = Color.LawnGreen Then
            H15.BackColor = Color.LightSteelBlue
        End If

        If I1.BackColor = Color.LawnGreen Then
            I1.BackColor = Color.LightSteelBlue
        End If
        If I2.BackColor = Color.LawnGreen Then
            I2.BackColor = Color.LightSteelBlue
        End If
        If I3.BackColor = Color.LawnGreen Then
            I3.BackColor = Color.LightSteelBlue
        End If
        If I4.BackColor = Color.LawnGreen Then
            I4.BackColor = Color.LightSteelBlue
        End If
        If I5.BackColor = Color.LawnGreen Then
            I5.BackColor = Color.LightSteelBlue
        End If
        If I6.BackColor = Color.LawnGreen Then
            I6.BackColor = Color.LightSteelBlue
        End If
        If I7.BackColor = Color.LawnGreen Then
            I7.BackColor = Color.LightSteelBlue
        End If
        If I8.BackColor = Color.LawnGreen Then
            I8.BackColor = Color.LightSteelBlue
        End If
        If I9.BackColor = Color.LawnGreen Then
            I9.BackColor = Color.LightSteelBlue
        End If
        If I10.BackColor = Color.LawnGreen Then
            I10.BackColor = Color.LightSteelBlue
        End If
        If I11.BackColor = Color.LawnGreen Then
            I11.BackColor = Color.LightSteelBlue
        End If
        If I12.BackColor = Color.LawnGreen Then
            I12.BackColor = Color.LightSteelBlue
        End If
        If I13.BackColor = Color.LawnGreen Then
            I13.BackColor = Color.LightSteelBlue
        End If
        If I14.BackColor = Color.LawnGreen Then
            I14.BackColor = Color.LightSteelBlue
        End If
        If I15.BackColor = Color.LawnGreen Then
            I15.BackColor = Color.LightSteelBlue
        End If

        If K1.BackColor = Color.LawnGreen Then
            K1.BackColor = Color.LightSteelBlue
        End If
        If K2.BackColor = Color.LawnGreen Then
            K2.BackColor = Color.LightSteelBlue
        End If
        If K3.BackColor = Color.LawnGreen Then
            K3.BackColor = Color.LightSteelBlue
        End If
        If K4.BackColor = Color.LawnGreen Then
            K4.BackColor = Color.LightSteelBlue
        End If
        If K5.BackColor = Color.LawnGreen Then
            K5.BackColor = Color.LightSteelBlue
        End If
        If K6.BackColor = Color.LawnGreen Then
            K6.BackColor = Color.LightSteelBlue
        End If
        If K7.BackColor = Color.LawnGreen Then
            K7.BackColor = Color.LightSteelBlue
        End If
        If K8.BackColor = Color.LawnGreen Then
            K8.BackColor = Color.LightSteelBlue
        End If
        If K9.BackColor = Color.LawnGreen Then
            K9.BackColor = Color.LightSteelBlue
        End If
        If K10.BackColor = Color.LawnGreen Then
            K10.BackColor = Color.LightSteelBlue
        End If
        If K11.BackColor = Color.LawnGreen Then
            K11.BackColor = Color.LightSteelBlue
        End If
        If K12.BackColor = Color.LawnGreen Then
            K12.BackColor = Color.LightSteelBlue
        End If
        If K13.BackColor = Color.LawnGreen Then
            K13.BackColor = Color.LightSteelBlue
        End If
        If K14.BackColor = Color.LawnGreen Then
            K14.BackColor = Color.LightSteelBlue
        End If
        If K15.BackColor = Color.LawnGreen Then
            K15.BackColor = Color.LightSteelBlue
        End If



    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        reset()
    End Sub
    Private Sub fillred()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        If h = 1 Then
            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F15.BackColor = Color.Red
            End If
            o_Reader.Close()
        ElseIf h = 2 Then

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K1'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K2'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K3'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K4'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K5'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K6'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K7'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K8'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K9'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K10'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K11'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K12'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K13'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K14'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K15'and ss.mdate = '" & AdvancedBooking.cboDate.SelectedValue & "' and st.Show_time='" & AdvancedBooking.cboShowTime.SelectedValue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K15.BackColor = Color.Red
            End If
            o_Reader.Close()
        End If
    End Sub

    Private Sub fillred2()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        If h = 1 Then
            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F15.BackColor = Color.Red
            End If
            o_Reader.Close()
        ElseIf h = 2 Then

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K1'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K2'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K3'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K4'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K5'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K6'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K7'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K8'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K9'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K10'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K11'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K12'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K13'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K14'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K15'and ss.mdate = '" & telebooking.cbophndate.selectedvalue & "' and st.Show_time='" & telebooking.cbophnstime.selectedvalue & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K15.BackColor = Color.Red
            End If
            o_Reader.Close()
        End If
    End Sub

    Private Sub fillred3()

        Dim s_Sql As String
        Dim o_cmd As SqlCommand
        Dim o_Reader As SqlDataReader

        If h = 1 Then
            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'A15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                A15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'B15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                B15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'C15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                C15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'D15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                D15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'E15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                E15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'F15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                F15.BackColor = Color.Red
            End If
            o_Reader.Close()
        ElseIf h = 2 Then

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'G15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                G15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'H15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                H15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'I15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                I15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'J15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                J15.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K1'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K1.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K2'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K2.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K3'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K3.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K4'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K4.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K5'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K5.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K6'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K6.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K7'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K7.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K8'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K8.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K9'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K9.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K10'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K10.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K11'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K11.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K12'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K12.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K13'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K13.BackColor = Color.Red
            End If
            o_Reader.Close()


            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K14'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K14.BackColor = Color.Red
            End If
            o_Reader.Close()

            s_Sql = "select ss.seat_id from Seat_Selection ss, Seat_ID si,Show_Time st  where ss.Seat_ID = si.seat_id and si.Seat_Name = 'K15'and ss.mdate = '" & currentbooking.txtcrtdate.text & "' and st.Show_time='" & currentbooking.txtcrtshowtime.text & "' and ss.Show_ID=st.Show_ID "

            o_cmd = New SqlCommand(s_Sql, o_con)
            o_Reader = o_cmd.ExecuteReader()
            If o_Reader.Read = True Then

                K15.BackColor = Color.Red
            End If
            o_Reader.Close()
        End If
    End Sub
End Class