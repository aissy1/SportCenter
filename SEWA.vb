Imports System.Data.Odbc
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SEWA
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
        MainMenu.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataBarang.Show()
        Me.Close()
    End Sub
    Private Sub GetBarang()
        Call Koneksi()
        Dim Da = New OdbcDataAdapter("Select * From barang", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "barang")
        ComboBox1.DataSource = Ds.Tables("barang")
        ComboBox1.DisplayMember = "JenisBarang"
        ComboBox1.ValueMember = "JenisBarang"
        ComboBox1.Refresh()
    End Sub
    Private Sub GetJmlh()
        Call Koneksi()
        Dim Da = New OdbcDataAdapter("Select * From barang where JenisBarang ='" & ComboBox1.SelectedValue.ToString() & "'", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "barang")
        ComboBox2.DataSource = Ds.Tables("barang")
        ComboBox2.DisplayMember = "Jumlah"
        ComboBox2.ValueMember = "Jumlah"
        Max = "Jumlah"
        ComboBox2.Refresh()
    End Sub
    Dim Max = 0
    Private Sub KondisiAwal()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub Datasewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
        DisplaySewa()
        GetBarang()
        GetJmlh()
    End Sub
    Private Sub DisplaySewa()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From sewa ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        SewaDGV.DataSource = Ds.Tables(0)
        SewaDGV.Columns(0).Width = 20
        SewaDGV.Columns(1).Width = 150
        SewaDGV.Columns(2).Width = 100
        SewaDGV.Columns(3).Width = 52
        SewaDGV.Columns(4).Width = 120
        SewaDGV.Columns(5).Width = 150
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox3.Text = "" Or ComboBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim jumlahBarangSebelum As Integer = UpdateJmlh(ComboBox1.Text)
            Dim currentDateAndTime As DateTime = Now
            Dim formattedDateTime As String = currentDateAndTime.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Input As String = "INSERT INTO sewa (Penyewa, JenisBarang, Jumlah, Status, waktu) VALUES (?, ?, ?, ?, ?)"

            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param3", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@param4", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@param5", formattedDateTime)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
            End Using
            Dim selisihJumlah As Integer = jumlahBarangSebelum - ComboBox2.Text
            Dim Da As String = "UPDATE barang SET Jumlah = ? WHERE JenisBarang = ?"
            Using cmd As New OdbcCommand(Da, Conn)
                cmd.Parameters.AddWithValue("@param1", selisihJumlah)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
            DisplaySewa()
            KondisiAwal()
        End If
    End Sub
    Dim key = 0
    Private Sub SewaDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SewaDGV.CellMouseClick
        Dim row As DataGridViewRow = SewaDGV.Rows(e.RowIndex)
        ComboBox1.Text = row.Cells(2).Value.ToString
        TextBox1.Text = row.Cells(1).Value.ToString
        ComboBox2.Text = row.Cells(3).Value.ToString
        ComboBox3.Text = row.Cells(4).Value.ToString
        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Function UpdateJmlh(jenisBarang As String) As Integer
        Call Koneksi()
        Dim Da As String = "SELECT Jumlah FROM barang WHERE JenisBarang = ?"
        Using cmd As New OdbcCommand(Da, Conn)
            cmd.Parameters.AddWithValue("@param1", jenisBarang)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return Convert.ToInt32(result)
            Else
                Return 0
            End If
        End Using
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or ComboBox3.Text = "" Or ComboBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim jumlahBarangSebelum As Integer = UpdateJmlh(ComboBox1.Text)
            Dim currentDateAndTime As DateTime = Now
            Dim formattedDateTime As String = currentDateAndTime.ToString("yyyy-MM-dd HH:mm:ss")
            Dim update As String = "UPDATE sewa SET Penyewa = ?, JenisBarang = ?, Jumlah = ?, Status = ?, Waktu =?  where Penyewa = ?"
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param3", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@param4", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@param5", formattedDateTime)
                cmd.Parameters.AddWithValue("@param6", TextBox1.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
            End Using
            If ComboBox3.Text = "Dikembalikan" Then
                Dim selisihJumlah As Integer = jumlahBarangSebelum + ComboBox2.Text
                Dim Da As String = "UPDATE barang SET Jumlah = ? WHERE JenisBarang = ?"
                Using cmd As New OdbcCommand(Da, Conn)
                    cmd.Parameters.AddWithValue("@param1", selisihJumlah)
                    cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End If
            MsgBox("Update Data Berhasil !", vbInformation, "Berhasil")
            DisplaySewa()
            KondisiAwal()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Tidak Ada Data Yang Ingin Dihapus")
        Else
            Call Koneksi()
            Dim Delete As String = "delete from sewa where id= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", vbInformation, "Berhasil")
            DisplaySewa()
            KondisiAwal()
        End If
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        GetJmlh()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class