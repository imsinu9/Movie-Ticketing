
Public Class Welcome



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Background.Show()
        If g = 0 Then
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            Button2.Visible = True
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            Label1.Visible = False
            Button1.Visible = True
            Button3.Visible = False
            LinkLabel5.Visible = False
            g = 1
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        DefaultPage.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        AdvancedBooking.Show()
        Me.Hide()

    End Sub

   
    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close.Click
        End
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AdminLogin.Show()

    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        TeleID.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LogIn.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        g = 0


        LinkLabel1.Visible = False
        LinkLabel2.Visible = False
        Button2.Visible = True
        PictureBox2.Visible = True
        PictureBox1.Visible = False
        Label1.Visible = False
        Button1.Visible = True
        Button3.Visible = False
        Close.Visible = True
        LinkLabel5.Visible = False
    End Sub
End Class