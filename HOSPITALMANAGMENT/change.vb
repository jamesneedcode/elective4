Imports System.Data.OleDb

Public Class change
    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String
    Private Sub cbshow_CheckedChanged(sender As Object, e As EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked Then

            txtnew.UseSystemPasswordChar = False
        Else

            txtnew.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtnew.Text <> "" Then

            checkDuplicate()
            If duplicateRec = "yes" Then


                If clicked = "Email" Then

                    utos = New OleDbCommand("Update [User] Set User_Email ='" & txtnew.Text & "' Where   UserID=" & Txtid.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("Success to Change!")

                ElseIf clicked = "FullName" Then

                    utos = New OleDbCommand("Update [User] Set FullName ='" & txtnew.Text & "' Where   UserID=" & Txtid.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("Success to Change!")


                Else clicked = "Password"


                    utos = New OleDbCommand("Update [User] Set user_Password ='" & txtnew.Text & "' Where   UserID=" & Txtid.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("Success to Change!")


                End If

                main.Show()
                Me.Close()
            Else
                MessageBox.Show("Cannot save Duplicate fields!")
            End If
        Else
            MessageBox.Show("Cannot save empty fields!")
        End If

    End Sub

    Function checkDuplicate()
        da = New OleDbDataAdapter("SELECT * FROM  [User] WHERE UserID=" & Txtid.Text, konek)
        ds = New DataSet
        da.Fill(ds, "User")
        If ds.Tables("User").Rows.Count >= 1 Then
            duplicateRec = "yes"
        Else
            duplicateRec = "no"
        End If
        Return True
    End Function
    Private Sub change_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        edituser.Show()
    End Sub


End Class