Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DataLokasi
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MenuAdmin.Show()
    End Sub
    Private Sub KondisiAwal()
        ComboBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub DisplayLokasi()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From lokasi ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        LokasiDGV.DataSource = Ds.Tables(0)
        LokasiDGV.Columns(0).Width = 75
        LokasiDGV.Columns(1).Width = 100
        LokasiDGV.Columns(2).Width = 125
        LokasiDGV.Columns(3).Width = 210
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim jenisLapangan As String
            cmd = New OdbcCommand("Select JenisLapangan from lapangan where KodeLapangan = '" & ComboBox1.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                jenisLapangan = Rd("JenisLapangan").ToString()
            Else
                MsgBox("error")
            End If
            Dim Input As String = "INSERT INTO lokasi (Kodelapangan, JenisLapangan, lokasi) VALUES (?, ?, ?)"

            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox2.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayLokasi()
                KondisiAwal()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0

    Private Sub GetKode()
        Call Koneksi()

        Dim Da = New OdbcDataAdapter("Select * from lapangan", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "lapangan")
        ComboBox1.DataSource = Ds.Tables("lapangan")
        ComboBox1.DisplayMember = "KodeLapangan"
        ComboBox1.ValueMember = "KodeLapangan"
        ComboBox1.Refresh()
    End Sub
    Private Sub GetLapangan()
        Call Koneksi()
        Dim jenisLapangan As String
        cmd = New OdbcCommand("Select JenisLapangan from lapangan where KodeLapangan = '" & ComboBox1.SelectedValue.ToString() & "'", Conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            jenisLapangan = Rd("JenisLapangan").ToString()
            TextBox2.Text = jenisLapangan
        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub
    Private Sub LokasiDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LokasiDGV.CellMouseClick
        Dim row As DataGridViewRow = LokasiDGV.Rows(e.RowIndex)
        ComboBox1.Text = row.Cells(1).Value.ToString
        TextBox3.Text = row.Cells(2).Value.ToString
        TextBox2.Text = row.Cells(3).Value.ToString

        If ComboBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim update As String = "UPDATE lokasi SET Kodelapangan = ?, JenisLapangan = ?, lokasi = ? where id=" & key & ""
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox2.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayLokasi()
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
            Dim Delete As String = "delete from lokasi where id= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", vbInformation, "Berhasil")
            DisplayLokasi()
            KondisiAwal()
        End If
    End Sub
    Private Sub DataLapangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLokasi()
        GetKode()
        KondisiAwal()
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        GetLapangan()
    End Sub
End Class