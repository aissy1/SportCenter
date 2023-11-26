Imports System.Data.Odbc

Public Class DataPegawai
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MenuAdmin.Show()
    End Sub
    Private Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub Datapegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayMember()
    End Sub
    Private Sub DisplayMember()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From pegawai ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        PegawaiDGV.DataSource = Ds.Tables(0)
        PegawaiDGV.Columns(0).Width = 62
        PegawaiDGV.Columns(1).Width = 120
        PegawaiDGV.Columns(2).Width = 50
        PegawaiDGV.Columns(3).Width = 150
        PegawaiDGV.Columns(4).Width = 50
        PegawaiDGV.Columns(5).Width = 90
        PegawaiDGV.Columns(6).Width = 70
    End Sub
    Private Sub InputAdmin()
        If ComboBox1.Text = "Admin" Then
            Call Koneksi()
            Dim input As String = "INSERT INTO admin (NamaAdmin) VALUES (?)"
            Using cmd As New OdbcCommand(input, Conn)
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim Input As String = "INSERT INTO pegawai (NamaPegawai, Alamat, password, Umur, NoHandphone, jabatan) VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox4.Text)
                cmd.Parameters.AddWithValue("@param5", TextBox5.Text)
                cmd.Parameters.AddWithValue("@param6", ComboBox1.Text)
                ' Menjalankan perintah
                InputAdmin()
                cmd.ExecuteNonQuery()
                DisplayMember()
                KondisiAwal()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0
    Private Sub pegawaiDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PegawaiDGV.CellMouseClick
        Dim row As DataGridViewRow = PegawaiDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox4.Text = row.Cells(2).Value.ToString
        TextBox2.Text = row.Cells(3).Value.ToString
        ComboBox1.Text = row.Cells(4).Value.ToString
        TextBox5.Text = row.Cells(5).Value.ToString
        TextBox3.Text = row.Cells(6).Value.ToString
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
            Dim update As String = "UPDATE pegawai SET NamaPegawai = ?, Alamat  = ?, password  = ?, Umur = ?, NoHandphone = ?, jabatan = ? where IdPegawai=" & key & ""
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox4.Text)
                cmd.Parameters.AddWithValue("@param5", TextBox5.Text)
                cmd.Parameters.AddWithValue("@param6", ComboBox1.Text)
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
            Dim Delete As String = "delete from pegawai where IdPegawai= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Membership Telah Dihapus", vbInformation, "Berhasil")
            DisplayMember()
            KondisiAwal()
        End If
    End Sub

End Class