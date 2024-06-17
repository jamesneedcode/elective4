Imports System.Data.OleDb

Public Class notesrecord
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub notesrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Private Sub notesrecord_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadRecord()
    End Sub
    Function loadRecord()

        da = New OleDbDataAdapter("Select * FROM tblNotes ", konek)
        ds = New DataSet
        da.Fill(ds, ("tblNotes"))
        dgvnotes.DataSource = ds.Tables("tblNotes").DefaultView
        Return True
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        main.Show()

    End Sub

    Private Sub txtidshow_TextChanged(sender As Object, e As EventArgs) Handles txtidshow.TextChanged

    End Sub



    Private Sub dgvnotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvnotes.CellClick
        If e.RowIndex <> -1 Then
            txtidshow.Text = ds.Tables("tblNotes").Rows(e.RowIndex).Item(0).ToString
            Patientsnotes.txtnoteIDs.Text = ds.Tables("tblNotes").Rows(e.RowIndex).Item(0).ToString
            Patientsnotes.txtPatientIDs.Text = ds.Tables("tblNotes").Rows(e.RowIndex).Item(1).ToString
            Patientsnotes.txtDoctorIDs.Text = ds.Tables("tblNotes").Rows(e.RowIndex).Item(2).ToString
            Patientsnotes.TxtnotedContents.Text = ds.Tables("tblNotes").Rows(e.RowIndex).Item(3).ToString
            Patientsnotes.DTPNoteDates.Value = ds.Tables("tblNotes").Rows(e.RowIndex).Item(4).ToString


        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click


        If txtidshow.Text <> "" Then
            trans = "Edit"
            Patientsnotes.txtnoteIDs.Hide()
                Patientsnotes.lbnoteid.Hide()
            Patientsnotes.ShowDialog()

            Me.Close()

        Else
            MessageBox.Show("Please Select Record to Edit!")
        End If
    End Sub

    Private Sub dgvnotes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvnotes.CellContentClick

    End Sub
End Class
