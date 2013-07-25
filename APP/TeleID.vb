Imports System.Data.SqlClient
Public Class TeleID

    Private Sub txtteleid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtteleid.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar

        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtteleid.TextChanged
        If txtteleid.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True

        End If
    End Sub

    Private Sub TeleID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        btnok.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Close()

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_sql As String
        Dim o_cmd As sqlcommand
        Dim o_Reader As sqldatareader

        s_sql = "Select Booking_ID from phone where Booking_ID='" & txtteleid.Text & "' "
        o_cmd = New SqlCommand(s_sql, o_con)
        o_Reader = o_cmd.ExecuteReader
        If o_Reader.Read = True Then

            TeleConfirm.txtTeleID.Text = txtteleid.Text
            TeleConfirm.Show()
            Me.Close()
        Else
            MsgBox("Invalid Tele ID")
            txtteleid.Text = ""
            txtteleid.Focus()
        End If
        o_Reader.Close()

    End Sub
End Class