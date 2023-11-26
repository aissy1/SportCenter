Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DataLapangan
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    Private Sub KondisiAwal()
        TextBox1.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub DisplayLapangan()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From lapangan ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        LapanganDGV.DataSource = Ds.Tables(0)
        LapanganDGV.Columns(0).Width = 75
        LapanganDGV.Columns(1).Width = 150
        LapanganDGV.Columns(2).Width = 150
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim Input As String = "INSERT INTO lapangan (Kodelapangan, JenisLapangan) VALUES (?, ?)"

            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayLapangan()
                KondisiAwal()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0
    Private Sub LAPANGANDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LapanganDGV.CellMouseClick
        Dim row As DataGridViewRow = LapanganDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        ComboBox1.Text = row.Cells(2).Value.ToString
        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim update As String = "UPDATE lapangan SET Kodelapangan = ?, JenisLapangan = ? where id=" & key & ""
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayLapangan()
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
            Dim Delete As String = "delete from lapangan where id= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", vbInformation, "Berhasil")
            DisplayLapangan()
            KondisiAwal()
        End If
    End Sub
    Private Sub DataLapangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLapangan()
        KondisiAwal()
    End Sub
End Class