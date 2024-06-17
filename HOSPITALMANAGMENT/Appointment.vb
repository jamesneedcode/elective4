Imports System.Data.OleDb
Imports System.Deployment.Application
Imports System.Diagnostics.Eventing.Reader

Public Class Appointment
    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub bbtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If txtPatientIDs.Text <> "" And txtDoctorIDs.Text <> "" And cbStatus.Text <> "" Then

            checkDuplicate()
            If duplicateRec <> "yes" Then
                If trans = "Add" Then

                    'put your add code here
                    utos = New OleDbCommand("INSERT INTO tblAppointment VALUES(" & txtAppointment.Text & "," & txtPatientIDs.Text & "," & txtDoctorIDs.Text & ",'" & DTPDates.Value.ToString("MM/dd/yyyy") & "','" & cbStatus.Text & "','" & TxtRemarks.Text & "')", konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("New Record Saved!")
                Else

                    txtAppointment.Hide()
                    lbappointment.Hide()

                    utos = New OleDbCommand("Update tblAppointment SET Patient_ID =" & txtPatientIDs.Text & ",Doctor_ID=" & txtDoctorIDs.Text & ",Appointment_Date='" & DTPDates.Value.ToString("MM/dd/yyyy") & "',Status='" & cbStatus.Text & "',Remarks='" & TxtRemarks.Text & "'Where  Apointment_ID=" & txtAppointment.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("Record has been Update!")
                End If
                Me.Close()
                main.Show()

            Else
                MessageBox.Show("Cannot save duplicate record!")
            End If
        Else
            MessageBox.Show("Cannot save empty fields!")
        End If
    End Sub




    Function checkDuplicate()
        da = New OleDbDataAdapter("SELECT * FROM tblAppointment WHERE Apointment_ID=" & txtAppointment.Text & " And Patient_ID =" & txtPatientIDs.Text & " And Doctor_ID=" & txtDoctorIDs.Text & " And Status='" & cbStatus.Text & "' And Remarks='" & TxtRemarks.Text & "'", konek)
        da.Fill(ds, "tblAppointment")
        If ds.Tables("tblAppointment").Rows.Count >= 1 Then
            duplicateRec = "yes"
        Else
            duplicateRec = "no"
        End If
        Return True
    End Function

    Private Sub Appointment_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()

    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trans = "add"
    End Sub
End Class