Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Jadwal
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    Private Sub GetData()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from jadwal", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        JadwalDGV.DataSource = Ds.Tables(0)
        JadwalDGV.Columns(0).Width = 75
        JadwalDGV.Columns(1).Width = 100
        JadwalDGV.Columns(2).Width = 100
        JadwalDGV.Columns(3).Width = 100
        JadwalDGV.Columns(4).Width = 100
    End Sub
    Dim key = 0
    Private Sub KondisiAwal()
        DateTimePicker1.Value = Now
    End Sub
    Private Sub Jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
        GetData()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Koneksi()
        Dim Da = New OdbcDataAdapter("Select * from jadwal where TanggalMain= '" & DateTimePicker1.Value.ToString() & "'", Conn)
        Ds.Clear()
        Ds = New DataSet
        Da.Fill(Ds, "jadwal")
        JadwalDGV.DataSource = Ds.Tables("jadwal")
    End Sub
End Class