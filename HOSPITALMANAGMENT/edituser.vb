Public Class edituser
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        userManagement.Show()
    End Sub

    Private Sub btnemail_Click(sender As Object, e As EventArgs) Handles btnemail.Click
        clicked = "Email"
        change.lbnew.Text = "Enter New Email"
        change.Show()
        Me.Close()

    End Sub

    Private Sub btnpassword_Click(sender As Object, e As EventArgs) Handles btnpassword.Click
        clicked = "Password"
        change.lbnew.Text = "Enter New Password"
        change.txtnew.UseSystemPasswordChar = False
        change.cbshow.Visible = True

        change.Show()
        Me.Close()
    End Sub

    Private Sub btnFullname_Click(sender As Object, e As EventArgs) Handles btnFullname.Click
        clicked = "FullName"
        change.lbnew.Text = "Enter New FullName"
        change.Show()
        Me.Close()
    End Sub
End Class