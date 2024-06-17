Imports System.Data.OleDb
Module Module1
    Public konstr = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\DBhospital.mdb"
    Public konek As New OleDbConnection(konstr)
    Public trans As String
    Public admin As String
    Public clicked As String


    Function konnecksyon()
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
        Return True
    End Function
End Module
