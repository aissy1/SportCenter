Imports System.Data.Odbc

Public Class MainMenu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PELANGGAN.Click
        Me.Hide()
        DataPelanggan.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles LAPANGAN.Click
        Me.Hide()
        DataLapangan.Show()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles BARANG.Click
        DataBarang.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Jadwal.Click
        Dim obj As New Jadwal
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles SEWA.Click
        Dim obj As New SEWA
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles BOOKING.Click
        Dim obj As New Booking
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        cmd = New OdbcCommand("Select * from pegawai where NamaPegawai='" & My.Settings.UserID.ToString() & "'", Conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Dim nama As String = Rd("NamaPegawai").ToString()
            Dim jabatan As String = Rd("jabatan").ToString()
            Dim nomor As String = Rd("NoHandphone")
            LabelUser.Text = nama
            LabelPegawai.Text = jabatan
            LabelNomor.Text = nomor
        End If
    End Sub
    Public Sub Logout()
        MenuLogin.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Settings.UserID = ""
        My.Settings.Save()
        Dim obj As New MenuLogin
        obj.Show()
        Me.Hide()
    End Sub

End Class
