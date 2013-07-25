<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BookingManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowseByShowDatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowseBYMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovieManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovieStatuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeAdminPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingManagerToolStripMenuItem, Me.ShowManagementToolStripMenuItem, Me.StaffManagementToolStripMenuItem, Me.MovieManagementToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(888, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BookingManagerToolStripMenuItem
        '
        Me.BookingManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseByShowDatesToolStripMenuItem, Me.BrowseBYMovieToolStripMenuItem})
        Me.BookingManagerToolStripMenuItem.Name = "BookingManagerToolStripMenuItem"
        Me.BookingManagerToolStripMenuItem.Size = New System.Drawing.Size(173, 23)
        Me.BookingManagerToolStripMenuItem.Text = "Booking Management"
        '
        'BrowseByShowDatesToolStripMenuItem
        '
        Me.BrowseByShowDatesToolStripMenuItem.Name = "BrowseByShowDatesToolStripMenuItem"
        Me.BrowseByShowDatesToolStripMenuItem.Size = New System.Drawing.Size(255, 24)
        Me.BrowseByShowDatesToolStripMenuItem.Text = "Browse by Show Dates"
        '
        'BrowseBYMovieToolStripMenuItem
        '
        Me.BrowseBYMovieToolStripMenuItem.Name = "BrowseBYMovieToolStripMenuItem"
        Me.BrowseBYMovieToolStripMenuItem.Size = New System.Drawing.Size(255, 24)
        Me.BrowseBYMovieToolStripMenuItem.Text = "Browse BY Movie"
        '
        'ShowManagementToolStripMenuItem
        '
        Me.ShowManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddShowToolStripMenuItem, Me.EditShowToolStripMenuItem, Me.UpdateDateToolStripMenuItem})
        Me.ShowManagementToolStripMenuItem.Name = "ShowManagementToolStripMenuItem"
        Me.ShowManagementToolStripMenuItem.Size = New System.Drawing.Size(155, 23)
        Me.ShowManagementToolStripMenuItem.Text = "Show Management"
        '
        'AddShowToolStripMenuItem
        '
        Me.AddShowToolStripMenuItem.Name = "AddShowToolStripMenuItem"
        Me.AddShowToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.AddShowToolStripMenuItem.Text = "Change Movie Shows"
        '
        'EditShowToolStripMenuItem
        '
        Me.EditShowToolStripMenuItem.Name = "EditShowToolStripMenuItem"
        Me.EditShowToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.EditShowToolStripMenuItem.Text = "Edit Show Time"
        '
        'UpdateDateToolStripMenuItem
        '
        Me.UpdateDateToolStripMenuItem.Name = "UpdateDateToolStripMenuItem"
        Me.UpdateDateToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.UpdateDateToolStripMenuItem.Text = "Update Date"
        '
        'StaffManagementToolStripMenuItem
        '
        Me.StaffManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewUserToolStripMenuItem, Me.ViewToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.StaffManagementToolStripMenuItem.Name = "StaffManagementToolStripMenuItem"
        Me.StaffManagementToolStripMenuItem.Size = New System.Drawing.Size(148, 23)
        Me.StaffManagementToolStripMenuItem.Text = "Staff Management"
        '
        'AddNewUserToolStripMenuItem
        '
        Me.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        Me.AddNewUserToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.AddNewUserToolStripMenuItem.Text = "Add New User"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.ViewToolStripMenuItem.Text = "View / Edit User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'MovieManagementToolStripMenuItem
        '
        Me.MovieManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMovieToolStripMenuItem, Me.MovieStatuToolStripMenuItem, Me.ChangePriceToolStripMenuItem})
        Me.MovieManagementToolStripMenuItem.Name = "MovieManagementToolStripMenuItem"
        Me.MovieManagementToolStripMenuItem.Size = New System.Drawing.Size(157, 23)
        Me.MovieManagementToolStripMenuItem.Text = "Movie Management"
        '
        'AddMovieToolStripMenuItem
        '
        Me.AddMovieToolStripMenuItem.Name = "AddMovieToolStripMenuItem"
        Me.AddMovieToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.AddMovieToolStripMenuItem.Text = "Add Movie"
        '
        'MovieStatuToolStripMenuItem
        '
        Me.MovieStatuToolStripMenuItem.Name = "MovieStatuToolStripMenuItem"
        Me.MovieStatuToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.MovieStatuToolStripMenuItem.Text = "Movie Status"
        '
        'ChangePriceToolStripMenuItem
        '
        Me.ChangePriceToolStripMenuItem.Name = "ChangePriceToolStripMenuItem"
        Me.ChangePriceToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.ChangePriceToolStripMenuItem.Text = "Change Price"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeAdminPasswordToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(130, 23)
        Me.AccountToolStripMenuItem.Text = "Admin Account"
        '
        'ChangeAdminPasswordToolStripMenuItem
        '
        Me.ChangeAdminPasswordToolStripMenuItem.Name = "ChangeAdminPasswordToolStripMenuItem"
        Me.ChangeAdminPasswordToolStripMenuItem.Size = New System.Drawing.Size(271, 24)
        Me.ChangeAdminPasswordToolStripMenuItem.Text = "Change Admin Password"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(271, 24)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'administator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = Global.Box_Office.My.Resources.Resources.Inox_logo_1901
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(888, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "administator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRATOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BookingManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseByShowDatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovieManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovieStatuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseBYMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeAdminPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
