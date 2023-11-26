Imports System.Data.Odbc
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Booking
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    Private Sub KondisiAwal()
        TextBox2.Text = ""
        ComboBox5.Text = ""
        ComboBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DateTimePicker1.Value = Now
    End Sub
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBooking()
        KondisiAwal()
        GetLapangan()
    End Sub
    Private Sub DisplayBooking()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From Booking ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        BookingDGV.DataSource = Ds.Tables(0)
        BookingDGV.Columns(0).Width = 100
        BookingDGV.Columns(1).Width = 200
        BookingDGV.Columns(2).Width = 140
        BookingDGV.Columns(3).Width = 150
        BookingDGV.Columns(4).Width = 150
        BookingDGV.Columns(5).Width = 150
        BookingDGV.Columns(6).Width = 141
    End Sub
    Private Sub GetLapangan()
        Call Koneksi()
        Dim Da = New OdbcDataAdapter("Select * From lapangan", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "lapangan")
        ComboBox1.DataSource = Ds.Tables("lapangan")
        ComboBox1.DisplayMember = "KodeLapangan"
        ComboBox1.ValueMember = "KodeLapangan"
        ComboBox1.Refresh()
    End Sub
    Private Sub GetTarif()
        Call Koneksi()
        If ComboBox5.SelectedIndex = 1 Then
            cmd = New OdbcCommand("Select TarifSpesial from tarif where KodeLapangan = '" & ComboBox1.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Dim Tarif As String = Rd("TarifSpesial").ToString()
                TextBox3.Text = Tarif
            End If
        Else
            cmd = New OdbcCommand("Select TarifUmum from tarif where KodeLapangan = '" & ComboBox1.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Dim Tarif As String = Rd("TarifUmum").ToString()
                TextBox3.Text = Tarif
            End If
            Rd.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or ComboBox5.Text = "" Or ComboBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or DateTimePicker1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim newBookingId As Long
            Dim datetimeNow = Now
            Dim datetimeMain = DateTimePicker1.Value.Date
            Dim timeMainString As String = ComboBox3.Text
            Dim timeMain As DateTime
            Dim timeMainSpan As TimeSpan
            If DateTime.TryParseExact(timeMainString, "HH.mm", CultureInfo.InvariantCulture, DateTimeStyles.None, timeMain) Then
                timeMainSpan = timeMain.TimeOfDay
            End If

            Dim durasiBermain As Double = Convert.ToDouble(ComboBox2.Text)
            Dim durasi As TimeSpan = TimeSpan.FromHours(durasiBermain)
            Dim waktuawal As DateTime = datetimeMain.Add(timeMainSpan)
            Dim waktuSelesai As DateTime = waktuawal.Add(durasi)

            Dim Input As String = "INSERT INTO booking (Nama, KodeLapangan, Waktu, TanggalMain, WaktuMain, WaktuSelesai, Tarif, Durasi, Bayar) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param3", datetimeNow)
                cmd.Parameters.AddWithValue("@param4", datetimeMain)
                cmd.Parameters.AddWithValue("@param5", timeMainSpan)
                cmd.Parameters.AddWithValue("@param6", waktuSelesai)
                cmd.Parameters.AddWithValue("@param7", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param8", durasiBermain)
                cmd.Parameters.AddWithValue("@param9", ComboBox4.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayBooking()
                KondisiAwal()
            End Using

            Using cmdGetLastId As New OdbcCommand("SELECT KodeBooking FROM booking ORDER BY KodeBooking DESC LIMIT 1", Conn)
                newBookingId = Convert.ToInt32(cmdGetLastId.ExecuteScalar())
            End Using

            ' Memindahkan data dari booking ke jadwal berdasarkan ID baru
            Using cmdInsertIntoJadwal As New OdbcCommand("INSERT INTO jadwal (KodeJadwal, KodeLapangan, TanggalMain, WaktuMain, WaktuSelesai) " &
                                            "SELECT KodeBooking, KodeLapangan, TanggalMain, WaktuMain, WaktuSelesai " &
                                            "FROM booking WHERE KodeBooking = ?", Conn)
                cmdInsertIntoJadwal.Parameters.AddWithValue("@BookingId", newBookingId)
                cmdInsertIntoJadwal.ExecuteNonQuery()
            End Using
            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0
    Public Sub CountTotal()
        If TextBox3.Text <> "" Then
            If Not String.IsNullOrEmpty(TextBox3.Text) AndAlso Not String.IsNullOrEmpty(ComboBox2.Text) Then
                Dim total As Integer = (Convert.ToInt32(TextBox3.Text)) * (Convert.ToInt32(ComboBox2.Text))
                TextBox1.Text = total
            Else
                MessageBox.Show("Nilai tidak boleh kosong.")
            End If
        End If
    End Sub
    Private Sub BookingDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BookingDGV.CellMouseClick

        Dim row As DataGridViewRow = BookingDGV.Rows(e.RowIndex)
        Dim jamMain = row.Cells(5).Value
        Dim jamMenitDetik As DateTime = DateTime.ParseExact(jamMain.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture)
        Dim jamMenit As String = jamMenitDetik.ToString("HH:mm")
        TextBox2.Text = row.Cells(1).Value.ToString
        ComboBox1.Text = row.Cells(2).Value.ToString
        DateTimePicker1.Text = row.Cells(4).Value.ToString
        TextBox1.Text = row.Cells(7).Value.ToString
        ComboBox2.Text = row.Cells(8).Value.ToString
        ComboBox4.Text = row.Cells(9).Value.ToString
        ComboBox3.Text = jamMenit

        If TextBox2.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or ComboBox5.Text = "" Or ComboBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or DateTimePicker1.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            Dim datetimeNow = Now
            Dim dateMain = DateTimePicker1.Value
            Dim timeMainString As String = ComboBox3.Text
            Dim timeMain As DateTime
            Dim timeMainSpan As TimeSpan
            If DateTime.TryParseExact(timeMainString, "HH.mm", CultureInfo.InvariantCulture, DateTimeStyles.None, timeMain) Then
                timeMainSpan = timeMain.TimeOfDay
            End If

            Dim durasiBermain As Double = Convert.ToDouble(ComboBox2.Text)
            Dim durasi As TimeSpan = TimeSpan.FromHours(durasiBermain)
            Dim waktuawal As DateTime = dateMain.Add(timeMainSpan)
            Dim waktuSelesai As DateTime = waktuawal.Add(durasi)

            Dim update As String = "UPDATE booking SET Nama = ?, KodeLapangan = ?, Waktu = ?, TanggalMain = ?, WaktuMain = ?, WaktuSelesai = ?, Tarif = ?, Durasi = ?, Bayar = ? where KodeBooking = ?"
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param2", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param3", datetimeNow)
                cmd.Parameters.AddWithValue("@param4", dateMain)
                cmd.Parameters.AddWithValue("@param5", timeMainSpan)
                cmd.Parameters.AddWithValue("@param6", waktuSelesai)
                cmd.Parameters.AddWithValue("@param7", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param8", durasiBermain)
                cmd.Parameters.AddWithValue("@param9", ComboBox4.Text)
                cmd.Parameters.AddWithValue("@param10", key)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayBooking()
                KondisiAwal()
            End Using
            Using cmd As New OdbcCommand("Update jadwal SET KodeLapangan = ?, TanggalMain = ?, WaktuMain = ?, WaktuSelesai = ? where KodeJadwal = ?", Conn)
                cmd.Parameters.AddWithValue("@param1", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param2", dateMain)
                cmd.Parameters.AddWithValue("@param3", timeMainSpan)
                cmd.Parameters.AddWithValue("@param4", waktuSelesai)
                cmd.Parameters.AddWithValue("@param5", key)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Data telah Diperbarui", vbInformation, "Berhasil")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Tidak Ada Data Yang Ingin Dihapus")
        Else
            Call Koneksi()
            Dim Delete As String = "delete from booking where KodeBooking= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            Dim Delete1 As String = "delete from booking where KodeJadwal= " & key & ""
            cmd = New OdbcCommand(Delete1, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", vbInformation, "Berhasil")
            DisplayBooking()
            KondisiAwal()
        End If
    End Sub

    Dim WithEvents print As New PrintDocument
    Dim ppd As New PrintPreviewDialog
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ppd.Document = print
        ppd.ShowDialog()
    End Sub
    Private Sub ComboBox5_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox5.SelectionChangeCommitted
        GetTarif()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CountTotal()
    End Sub

    Private Sub print_PrintPage(sender As Object, e As PrintPageEventArgs) Handles print.PrintPage
        Dim jenisLapangan As String
        Dim time As DateTime = Now
        Dim kasir As String = My.Settings.UserID
        Dim pelanggan As String = TextBox2.Text
        Dim KodeLapangan As String = ComboBox1.Text
        Dim Total As String = TextBox1.Text
        Dim timeMainString As String = ComboBox3.Text
        Dim tanggalMain As String = DateTimePicker1.Value
        Dim Durasi As String = ComboBox2.Text

        Call Koneksi()
        cmd = New OdbcCommand("Select JenisLapangan from lapangan where KodeLapangan ='" & KodeLapangan & "'", Conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            jenisLapangan = Rd("JenisLapangan").ToString()
        End If

        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10B As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftMargin As Integer = print.DefaultPageSettings.Margins.Left
        Dim centerMargin As Integer = print.DefaultPageSettings.PaperSize.Width / 2
        Dim rightMargin As Integer = print.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim batas As String
        batas = "================================="

        e.Graphics.DrawString("Sport Center", f14, Brushes.Black, centerMargin, 5, tengah)
        e.Graphics.DrawString("Sport Center", f10B, Brushes.Black, centerMargin, 30, tengah)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 10, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 60)
        e.Graphics.DrawString(kasir, f10, Brushes.Black, 120, 60)

        e.Graphics.DrawString("Nama Pelanggan", f10, Brushes.Black, 10, 80)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 80)
        e.Graphics.DrawString(pelanggan, f10, Brushes.Black, 120, 80)

        e.Graphics.DrawString("Kode Lapangan", f10, Brushes.Black, 10, 100)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 100)
        e.Graphics.DrawString(KodeLapangan, f10, Brushes.Black, 120, 100)

        e.Graphics.DrawString("Waktu Transaksi", f10, Brushes.Black, 10, 120)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 120)
        e.Graphics.DrawString(time, f10, Brushes.Black, 120, 120)

        e.Graphics.DrawString("Tanggal Main", f10, Brushes.Black, 10, 140)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 140)
        e.Graphics.DrawString(tanggalMain, f10, Brushes.Black, 120, 140)

        e.Graphics.DrawString("Waktu Main", f10, Brushes.Black, 10, 160)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 160)
        e.Graphics.DrawString(timeMainString, f10, Brushes.Black, 120, 160)

        e.Graphics.DrawString(batas, f14, Brushes.Black, 0, 185)

        e.Graphics.DrawString(Durasi, f10B, Brushes.Black, 20, 205)
        e.Graphics.DrawString("Lapangan " + jenisLapangan, f10B, Brushes.Black, centerMargin, 205, tengah)
        e.Graphics.DrawString(Total, f10B, Brushes.Black, 240, 205)

        e.Graphics.DrawString(batas, f14, Brushes.Black, 0, 225)

        e.Graphics.DrawString("TERIMA KASIH ", f10B, Brushes.Black, centerMargin, 265, tengah)
        e.Graphics.DrawString("DITUNGGU KEDATANGANNYA", f10B, Brushes.Black, centerMargin, 285, tengah)
        e.Graphics.DrawString("KEMBALI", f10B, Brushes.Black, centerMargin, 305, tengah)

    End Sub

    Private Sub print_BeginPrint(sender As Object, e As PrintEventArgs) Handles print.BeginPrint
        Dim PaperSetting As New PageSettings
        PaperSetting.PaperSize = New PaperSize("custom", 300, 350)
        print.DefaultPageSettings = PaperSetting
    End Sub
End Class