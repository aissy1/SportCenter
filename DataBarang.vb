Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DataBarang
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBarang()
    End Sub
    Private Sub DisplayBarang()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select KodeBarang, JenisBarang, Jumlah, Kondisi From barang ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        BarangDGV.DataSource = Ds.Tables(0)
        BarangDGV.Columns(0).Width = 100
        BarangDGV.Columns(1).Width = 200
        BarangDGV.Columns(2).Width = 140
        BarangDGV.Columns(3).Width = 150
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim Input As String = "INSERT INTO barang (KodeBarang, JenisBarang, Jumlah, Kondisi) VALUES (?, ?, ?, ?)"

            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param4", ComboBox1.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayBarang()
                KondisiAwal()
            End Using

            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0
    Private Sub BarangDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BarangDGV.CellMouseClick
        Dim row As DataGridViewRow = BarangDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(0).Value.ToString
        TextBox2.Text = row.Cells(1).Value.ToString
        TextBox3.Text = row.Cells(2).Value.ToString
        ComboBox1.Text = row.Cells(3).Value.ToString
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim update As String = "UPDATE barang SET KodeBarang = ?, JenisBarang = ?, Jumlah = ?, Kondisi = ? where KodeBarang = ?"
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param4", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param5", TextBox1.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayBarang()
                KondisiAwal()
            End Using

            MsgBox("Update Data Berhasil !", vbInformation, "Berhasil")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text Then
            MsgBox("Tidak Ada Data Yang Ingin Dihapus")
        Else
            Call Koneksi()
            Dim Delete As String = "delete from barang where KodeBarang= " & TextBox1.Text & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", vbInformation, "Berhasil")
            DisplayBarang()
            KondisiAwal()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SEWA.Show()
        Me.Hide()
    End Sub
End Class