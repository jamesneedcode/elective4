Imports System.Data.OleDb
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class signup
    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String


    Function checkDuplicate()

        da = New OleDbDataAdapter("SELECT * FROM [User] WHERE User_Email='" & txtEmail.Text & "' or UserID=" & txtuserid.Text, konek)

        da.Fill(ds, "User")
        If ds.Tables("User").Rows.Count >= 1 Then
            duplicateRec = "yes"
        Else
            duplicateRec = "no"
        End If
        Return True
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtuserid.Text <> "" And txtEmail.Text <> "" Then
            checkDuplicate()
            If duplicateRec <> "yes" Then

                Dim utos As New OleDbCommand("INSERT INTO [User] VALUES (" & txtuserid.Text & ", '" & txtPassword.Text & "','" & txtFullname.Text & "','" & txtEmail.Text & "')", konek)
                utos.ExecuteNonQuery()

                MessageBox.Show("New Record Saved!")

                Me.Close()
                loginform.Show()

            Else

                MessageBox.Show("Cannot save duplicate record!")
                Me.Close()
                loginform.Show()


            End If
        Else
            MessageBox.Show("Cannot save empty fields!")
        End If
    End Sub




    Private Sub signup_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()
    End Sub

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        loginform.Show()
        Me.Close()

    End Sub

    Private Sub cbshow_CheckedChanged(sender As Object, e As EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        If cbshow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class