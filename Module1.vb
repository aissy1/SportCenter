Imports System.Data.Common
Imports System.Data.Odbc
Module Module1
    Public Conn As New OdbcConnection
    Public Da As DataAdapter
    Public Ds As DataSet
    Public Dt As DataTable
    Public Rd As OdbcdataReader
    Public cmd As OdbcCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=sport center;Server=localhost;uid=root;"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        Else
            MsgBox("koneksi gagal", vbCritical)
        End If
    End Sub

End Module


