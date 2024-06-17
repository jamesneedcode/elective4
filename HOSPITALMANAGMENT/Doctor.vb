Imports System.Data.OleDb

Public Class Doctor
    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String
 
    Private Sub brnCancel_Click(sender As Object, e As EventArgs) Handles brnCancel.Click
        Me.Close()
        main.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtexp.Text <> "" Then
            checkDuplicate()
            If duplicateRec <> "yes" Then
                If trans = "Edit" Then
                    'put your edit code here
                    utos = New OleDbCommand("Update tblDoctor SET Last_Name =' " & txtlastname.Text & "',First_Name='" & txtfirstName.Text & "',Middle_Name='" & txtmiddlename.Text & "',Date_of_Birth='" & dateselect.Value.ToString("MM/dd/yyyy") & "',Gender='" & gender.Text & "',Address='" & txtaddress.Text & "',Phone_Number='" & txtphonenumber.Text & "',Nationality= '" & txtnationality.Text & "',Specialization= '" & cbSpecialty.Text & "',Qualification = '" & cbquali.Text & "',Years_of_Experience = " & txtexp.Text & " Where Doctor_ID = " & txtid.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("Record has been Update!")
                    currentdoctor.txtidshow.Clear()

                Else

                    'put your add code here
                    utos = New OleDbCommand("INSERT INTO tblDoctor VALUES(" & txtid.Text & ",'" & txtlastname.Text & "','" & txtfirstName.Text & "','" & txtmiddlename.Text & "','" & dateselect.Value.ToString("MM/dd/yyyy") & "','" & gender.Text & "','" & txtaddress.Text & "','" & txtphonenumber.Text & "','" & txtnationality.Text & "','" & cbSpecialty.Text & "','" & cbquali.Text & "'," & txtexp.Text & ")", konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("New Record Saved!")
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
        da = New OleDbDataAdapter("SELECT * FROM tblDoctor WHERE Last_Name =' " & txtlastname.Text & "' and First_Name='" & txtfirstName.Text & "' and Middle_Name= '" & txtmiddlename.Text & "' and Gender='" & gender.Text & "' and Address='" & txtaddress.Text & "' and Phone_Number='" & txtphonenumber.Text & "' and Nationality= '" & txtnationality.Text & "' and Specialization= '" & cbSpecialty.Text & "' and Qualification = '" & cbquali.Text & "' and Years_of_Experience = " & txtexp.Text, konek)
        ds = New DataSet
        da.Fill(ds, "tblDoctor")
        If ds.Tables("tblDoctor").Rows.Count >= 1 Then
            duplicateRec = "yes"
        Else
            duplicateRec = "no"
        End If
        Return True


    End Function
    Private Sub Doctor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()
    End Sub

    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class