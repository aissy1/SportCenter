Imports System.Data.Odbc
Public Class Login
    Public Sub KondisiAwal()
        ID.Text = ""
        Pass.Text = ""
    End Sub
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        If ID.Text = "" Or Pass.Text = "" Then
            MsgBox("ID atau Password Harus diisi!")
        Else
            Call Koneksi()
            cmd = New OdbcCommand("Select * from admin where username='" & ID.Text & "'and password='" & Pass.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                My.Settings.UserID = ID.Text
                My.Settings.Save()
                menuAdmin.Show()
                Me.Hide()
            Else
                MsgBox("Id atau Password Salah")
                KondisiAwal()
            End If
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuLogin.Show()
        Me.Close()
    End Sub
End Class