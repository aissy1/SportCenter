Imports System.Data.Odbc
Public Class DataPelanggan
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    Private Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub DataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayMember()
    End Sub
    Private Sub DisplayMember()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From pelanggan ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        PELANGGANDGV.DataSource = Ds.Tables(0)
        PELANGGANDGV.Columns(0).Width = 75
        PELANGGANDGV.Columns(1).Width = 150
        PELANGGANDGV.Columns(2).Width = 150
        PELANGGANDGV.Columns(3).Width = 50
        PELANGGANDGV.Columns(4).Width = 120
        PELANGGANDGV.Columns(5).Width = 90
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim Input As String = "INSERT INTO pelanggan (email, NamaMember, Umur, Alamat, NoHandphone) VALUES (?, ?, ?, ?, ?)"
            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox4.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param5", TextBox5.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayMember()
                KondisiAwal()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0

    Private Sub PELANGGANDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PELANGGANDGV.CellMouseClick
        Dim row As DataGridViewRow = PELANGGANDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(4).Value.ToString
        TextBox4.Text = row.Cells(3).Value.ToString
        TextBox5.Text = row.Cells(5).Value.ToString
        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim update As String = "UPDATE pelanggan SET email = ?, NamaMember = ?, Umur = ?, Alamat = ?, NoHandphone = ? where IdMember=" & key & ""
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox4.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param5", TextBox5.Text)
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
            Dim Delete As String = "delete from pelanggan where IdMember= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Membership Telah Dihapus", vbInformation, "Berhasil")
            DisplayMember()
            KondisiAwal()
        End If
    End Sub
End Class