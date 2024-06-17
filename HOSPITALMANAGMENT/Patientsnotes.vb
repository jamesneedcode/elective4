Imports System.Data.OleDb
Imports System.Deployment.Application

Public Class Patientsnotes

    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        main.Show()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtPatientIDs.Text <> "" And txtDoctorIDs.Text <> "" And TxtnotedContents.Text <> "" Then
            checkDuplicate()
            If duplicateRec <> "yes" Then
                If trans = "Edit" Then

                    'put your edit code here
                    txtnoteIDs.Hide()
                    lbnoteid.Hide()
                    utos = New OleDbCommand("Update tblNotes  SET Patient_ID =" & txtPatientIDs.Text & ",doctor_ID=" & txtDoctorIDs.Text & ",Note_Content ='" & TxtnotedContents.Text & "',Note_Date= '" & DTPNoteDates.Value.ToString("MM/dd/yyyy") & "'Where Note_ID= " & txtnoteIDs.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("Record has been Update!")
                Else
                    'put your add code here

                    utos = New OleDbCommand("INSERT INTO tblNotes VALUES(" & txtnoteIDs.Text & "," & txtPatientIDs.Text & "," & txtDoctorIDs.Text & ",'" & TxtnotedContents.Text & "','" & DTPNoteDates.Value.ToString("MM/dd/yyyy") & "')", konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("New Record Saved!")
                End If
                main.Show()
                Me.Close()
            Else
                MessageBox.Show("Cannot save duplicate record!")
            End If
        Else
            MessageBox.Show("Cannot save empty fields!")
        End If
    End Sub




    Function checkDuplicate()
        da = New OleDbDataAdapter("SELECT * FROM tblNotes WHERE Patient_ID =" & txtPatientIDs.Text & "AND Note_Content ='" & TxtnotedContents.Text & "'", konek)
        ds = New DataSet
        da.Fill(ds, "tblNotes")
        If ds.Tables("tblNotes").Rows.Count >= 1 Then
            duplicateRec = "yes"
        Else
            duplicateRec = "no"
        End If
        Return True
    End Function
    Private Sub Patientsnotes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()

    End Sub

    Private Sub TxtnotedContents_TextChanged(sender As Object, e As EventArgs) Handles TxtnotedContents.TextChanged

    End Sub
End Class