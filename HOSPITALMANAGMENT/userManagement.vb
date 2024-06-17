Imports System.Data.OleDb

Public Class userManagement

    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String



    Private Sub userManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecorduser()
    End Sub
    Private Sub userManagement_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()
        loadRecorduser()
    End Sub
    Function loadRecorduser()
        If admin = "Yes" Then
            da = New OleDbDataAdapter("Select * FROM [User]", konek)
            ds = New DataSet
            da.Fill(ds, "User")
            dgvuser.DataSource = ds.Tables("User").DefaultView
        Else
            da = New OleDbDataAdapter("Select UserID,FullName,User_Email FROM [User] where User_Email='" & loginform.email.Text & "'", konek)
            ds = New DataSet
            da.Fill(ds, "User")
            dgvuser.DataSource = ds.Tables("User").DefaultView
        End If
        Return True
    End Function


    Private Sub dgvpatientrec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellClick


        If e.RowIndex <> -1 Then
            txtidshow.Text = ds.Tables("User").Rows(e.RowIndex).Item(0).ToString
            change.Txtid.Text = ds.Tables("User").Rows(e.RowIndex).Item(0).ToString
        End If

    End Sub



    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click

        If txtidshow.Text <> "" Then
            If MessageBox.Show("Are you want delete record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                utos = New OleDbCommand("Delete From [User] Where UserID=" & txtidshow.Text, konek)
                utos.ExecuteNonQuery()
                MessageBox.Show(" Record has been Delete!")
            End If
        Else
            MessageBox.Show("Please Select Record to Delete!")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtidshow.Text <> "" Then
            Me.Close()
            edituser.Show()

        Else
            MessageBox.Show("Please click the  Record to Edit!")
        End If
    End Sub



    Private Sub dgvuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellContentClick

    End Sub

    
End Class