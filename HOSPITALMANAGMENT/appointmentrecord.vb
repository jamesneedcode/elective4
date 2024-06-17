Imports System.Data.OleDb

Public Class appointmentrecord
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet


    Private Sub appointmentrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Private Sub appointmentrecord_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadRecord()
    End Sub

    Function loadRecord()

        da = New OleDbDataAdapter("Select * FROM tblAppointment ", konek)
        ds = New DataSet
        da.Fill(ds, ("tblAppointment"))
        dgvAppointment.DataSource = ds.Tables("tblAppointment").DefaultView
        Return True
    End Function
    Private Sub dgvAppointment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointment.CellClick
        If e.RowIndex <> -1 Then
            Txtpointer.Text = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(0).ToString

            Appointment.txtAppointment.Text = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(0).ToString
            Appointment.txtPatientIDs.Text = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(1).ToString
            Appointment.txtDoctorIDs.Text = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(2).ToString
            Appointment.DTPDates.Value = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(3).ToString
            Appointment.cbStatus.Text = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(4).ToString
            Appointment.TxtRemarks.Text = ds.Tables("tblAppointment").Rows(e.RowIndex).Item(5).ToString


        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Appointment.txtAppointment.Visible = False
        Appointment.lbappointment.Visible = False


        If Txtpointer.Text <> "" Then
            trans = "edit"
            Appointment.ShowDialog()

        Else
            MessageBox.Show("Please Select Record to Edit!")
        End If
    End Sub
End Class