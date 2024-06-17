Public Class main


    Private Sub DOCTORRECORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOCTORRECORDToolStripMenuItem.Click
        currentdoctor.Show()
        Me.Hide()
    End Sub

    Private Sub NEWPATIENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWPATIENTToolStripMenuItem.Click
        Patient.Show()
        Patient.txtid.Visible = True
        Patient.lbID.Visible = True
        Me.Hide()

    End Sub

    Private Sub PATIENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PATIENTToolStripMenuItem1.Click
        frmpatientsrecords.Show()
        Me.Hide()





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub NEWDOCTORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWDOCTORToolStripMenuItem.Click


        Doctor.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub NEWNOTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWNOTESToolStripMenuItem.Click
        trans = "Add"
        Patientsnotes.Show()
        Me.Hide()

    End Sub


    Private Sub AppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentToolStripMenuItem.Click
        Appointment.Show()
        trans = "Add"
        Me.Hide()
    End Sub

    Private Sub PATIENTNOTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PATIENTNOTESToolStripMenuItem.Click
        notesrecord.Show()
        Me.Hide()
    End Sub

    Private Sub APOINTMENTRECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APOINTMENTRECORDSToolStripMenuItem.Click
        appointmentrecord.Show()
        Me.Hide()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        loginform.Show()
        loginform.password.Clear()
        loginform.email.Clear()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsermanagemnetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsermanagemnetToolStripMenuItem.Click

        If admin = "Yes" Then
            userManagement.btnedit.Visible = False
            userManagement.btDelete.Visible = True

        End If
        Me.Close()
        userManagement.Show()
    End Sub
End Class
