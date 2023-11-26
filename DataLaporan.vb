Imports System.Data.Odbc

Public Class DataLaporan
    Private Sub DisplayLaporan()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from booking ORDER BY Waktu DESC ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        LaporanDGV.DataSource = Ds.Tables(0)
        LaporanDGV.Columns(0).Width = 80
        LaporanDGV.Columns(1).Width = 160
        LaporanDGV.Columns(2).Width = 100
        LaporanDGV.Columns(3).Width = 120
        LaporanDGV.Columns(4).Width = 80
        LaporanDGV.Columns(5).Width = 80
        LaporanDGV.Columns(6).Width = 120
        LaporanDGV.Columns(7).Width = 60
        LaporanDGV.Columns(8).Width = 50
        LaporanDGV.Columns(9).Width = 50
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MenuAdmin.Show()
    End Sub

    Private Sub KondisiAwal()
        DateTimePicker1.Value = Now
    End Sub

    Private Sub DataLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLaporan()
        KondisiAwal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Koneksi()
        Dim Da = New OdbcDataAdapter("Select * from booking where TanggalMain= '" & DateTimePicker1.Value.ToString() & "' ORDER BY TanggalMain DESC ", Conn)
        Ds.Clear()
        Ds = New DataSet
        Da.Fill(Ds, "booking")
        LaporanDGV.DataSource = Ds.Tables("booking")
    End Sub
End Class