Imports System.Data.Odbc

Public Class MenuAdmin
    Private Sub ADMIN_Click(sender As Object, e As EventArgs) Handles ADMIN.Click
        Dim obj As New DataAdmin
        obj.Show()
        Me.Close()
    End Sub
    Private Sub PEGAWAI_Click(sender As Object, e As EventArgs) Handles PEGAWAI.Click
        Dim obj As New DataPegawai
        obj.Show()
        Me.Close()
    End Sub
    Private Sub TARIF_Click(sender As Object, e As EventArgs) Handles TARIF.Click
        Dim obj As New DataTarif
        obj.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim obj As New DataLokasi
        obj.Show()
        Me.Close()
    End Sub
    Public Sub Logout()
        LabelUser.Text = ""
        MenuLogin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Logout()
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        cmd = New OdbcCommand("Select * from admin where Username='" & My.Settings.UserID.ToString() & "'", Conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Dim nama As String = Rd("NamaAdmin").ToString()
            LabelUser.Text = nama
            LabelRole.Text = "Admin"
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim obj As New DataLaporan
        obj.Show()
        Me.Hide()
    End Sub
End Class