Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Security.Cryptography

Public Class loginform
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet



    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        'for admin
        If email.Text = "admin" Then
            admin = "Yes"
        End If


        If email.Text = "" Then

            MessageBox.Show("PLease Enter Your Email")
        Else

            If password.Text = "" Then

                MessageBox.Show("PLease Enter Your Password")

            Else
                da = New OleDbDataAdapter("SELECT * FROM [User] WHERE user_Password='" & password.Text & "' AND User_Email='" & email.Text & "'", konek)
                ds = New DataSet
                da.Fill(ds, "User")


                If ds.Tables("User").Rows.Count = 1 Then
                    main.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect Password or Email don't Exist!")
                End If
            End If
        End If


    End Sub






    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs)
        If cbshow.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub




    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        trans = "Add"
        signup.Show()
        Me.Hide
    End Sub
End Class