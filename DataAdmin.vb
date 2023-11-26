Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DataAdmin
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MenuAdmin.Show()
    End Sub
    Private Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub DataAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayMember()
        KondisiAwal()
    End Sub
    Private Sub DisplayMember()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From admin ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        AdminDGV.DataSource = Ds.Tables(0)
        AdminDGV.Columns(0).Width = 60
        AdminDGV.Columns(1).Width = 150
        AdminDGV.Columns(2).Width = 125
        AdminDGV.Columns(3).Width = 120
    End Sub
    Private Sub Validasi()
        Call Koneksi()
        cmd = New OdbcCommand("Select username from admin where username='" & TextBox1.Text & "'", Conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            username = Rd("username").ToString()
        End If
    End Sub
    Dim username As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        ElseIf TextBox1.Text = username Then
            MsgBox("Terdapat Kesamaan Informasi Pada Username !", vbInformation, "Gagal")
            DisplayMember()
            KondisiAwal()
        Else
            Call Koneksi()
            Validasi()
            Dim Input As String = "INSERT INTO admin (NamaAdmin, username, Password) VALUES (?, ?, ?)"
            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox2.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayMember()
                KondisiAwal()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0
    Private Sub AdminDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AdminDGV.CellMouseClick
        Dim row As DataGridViewRow = AdminDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(2).Value.ToString
        TextBox2.Text = row.Cells(3).Value.ToString
        TextBox3.Text = row.Cells(1).Value.ToString
        If TextBox3.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Validasi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        ElseIf TextBox1.Text = username Then
            MsgBox("Terdapat Kesamaan Informasi Pada Username !", vbInformation, "Gagal")
            DisplayMember()
            KondisiAwal()
        Else
            Call Koneksi()
            Dim update As String = "UPDATE admin SET NamaAdmin= ?, username= ?, Password= ? where Id=" & key & ""
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox2.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayMember()
                KondisiAwal()
            End Using

            MsgBox("Update Data Berhasil !", vbInformation, "Berhasil")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Tidak Ada Data Yang Ingin Dihapus")
        Else
            Call Koneksi()
            Dim Delete As String = "delete from admin where Id= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Membership Telah Dihapus", vbInformation, "Berhasil")
            DisplayMember()
            KondisiAwal()
        End If
    End Sub

End Class