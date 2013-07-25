Imports System.Data.SqlClient
Public Class AddMovie

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmoviename.TextChanged
        If txtmoviename.Text = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True

        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtmoviename.Text = ""
        cborating.SelectedIndex = 0
        cboactive.SelectedIndex = 0
        dtprelsdate.Value = Today
        txtmoviename.Focus()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub movieedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        btnok.Enabled = False

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim s_sql As String
        Dim o_cmd As SqlCommand

        s_sql = "Insert into Movie_Details (Movie_Name,Release_Date,Active) values ('" & txtmoviename.Text & cborating.Text & "','" & dtprelsdate.Text & "','" & cboactive.Text & "')"
        o_cmd = New SqlCommand(s_sql, o_con)
        o_cmd.ExecuteNonQuery()
        MsgBox("Movie Added")

        administator.Show()
        Me.Close()
    End Sub
End Class