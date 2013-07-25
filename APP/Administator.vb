Imports System.Data.SqlClient
Public Class administator

    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUserToolStripMenuItem.Click
        NewUser.Show()
    End Sub


    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        DeleteUser.Show()

    End Sub

    Private Sub BrowseByShowDatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseByShowDatesToolStripMenuItem.Click
        BrowseByDate.Show()
    End Sub

    Private Sub EditShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditShowToolStripMenuItem.Click
        EditShow.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        ViewUser.Show()

    End Sub

    Private Sub AddShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShowToolStripMenuItem.Click
        Changemovieshows.Show()
    End Sub

    Private Sub AddMovieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMovieToolStripMenuItem.Click
        AddMovie.Show()

    End Sub

    Private Sub MovieStatuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovieStatuToolStripMenuItem.Click
        EditMovie.Show()

    End Sub


    Private Sub ChangeAdminPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeAdminPasswordToolStripMenuItem.Click
        Changeadminpass.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub BrowseBYMovieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseBYMovieToolStripMenuItem.Click
        BrowseByMovie.Show()

    End Sub

    Private Sub UpdateDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateDateToolStripMenuItem.Click
        update_date.Show()
    End Sub

    Private Sub ChangePriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePriceToolStripMenuItem.Click
        changePrice.Show()
    End Sub

    Private Sub BookingManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingManagerToolStripMenuItem.Click

    End Sub

    Private Sub administator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
    End Sub
End Class