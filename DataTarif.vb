Imports System.Data.Odbc
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DataTarif
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MenuAdmin.Show()
    End Sub
    Private Sub KondisiAwal()
        ComboBox1.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub DataTarif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTarif()
        KondisiAwal()
        GetKDLapangan()
    End Sub
    Private Sub DisplayTarif()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From tarif ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        TarifDGV.DataSource = Ds.Tables(0)
        TarifDGV.Columns(0).Width = 100
        TarifDGV.Columns(1).Width = 200
        TarifDGV.Columns(2).Width = 140
        TarifDGV.Columns(3).Width = 150
        TarifDGV.Columns(4).Width = 150
    End Sub

    Private Sub GetKDLapangan()
        Call Koneksi()
        Dim Da = New OdbcDataAdapter("Select * from lapangan ", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "lapangan")
        ComboBox1.DataSource = Ds.Tables("lapangan")
        ComboBox1.DisplayMember = "KodeLapangan"
        ComboBox1.ValueMember = "KodeLapangan"
        ComboBox1.Refresh()
    End Sub
    Private Sub GetLapangan()
        Call Koneksi()
        cmd = New OdbcCommand("Select JenisLapangan from lapangan where KodeLapangan='" & ComboBox1.SelectedValue.ToString() & "'", Conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            TextBox1.Text = Rd("JenisLapangan").ToString()
        Else
            MsgBox("error")
        End If
    End Sub
    Private jenisLapangan As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Semua Informasi Harus Di isi")
        Else
            Call Koneksi()
            GetLapangan()
            Dim Input As String = "INSERT INTO tarif (KodeLapangan, JenisLapangan, TarifUmum, TarifSpesial) VALUES (?, ?, ?, ?)"

            Using cmd As New OdbcCommand(Input, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox3.Text)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayTarif()
                KondisiAwal()
            End Using

            MsgBox("Data Berhasil Ditambahkan!", vbInformation, "Berhasil")
        End If
    End Sub
    Dim key = 0
    Private Sub TarifDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TarifDGV.CellMouseClick
        Dim row As DataGridViewRow = TarifDGV.Rows(e.RowIndex)
        ComboBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(3).Value.ToString
        TextBox3.Text = row.Cells(4).Value.ToString
        GetLapangan()
        If TextBox1.Text = " " Then
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
            GetLapangan()
            Dim update As String = "UPDATE tarif SET KodeLapangan = ?, JenisLapangan = ?, TarifUmum = ?, TarifSpesial = ?  where id = ?"
            Using cmd As New OdbcCommand(update, Conn)
                ' Mengatur parameter dengan nilai dari TextBox
                cmd.Parameters.AddWithValue("@param1", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@param2", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param5", key)
                ' Menjalankan perintah
                cmd.ExecuteNonQuery()
                DisplayTarif()
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
            Dim Delete As String = "delete from tarif where id= " & key & ""
            cmd = New OdbcCommand(Delete, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", vbInformation, "Berhasil")
            DisplayTarif()
            KondisiAwal()
        End If
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        GetLapangan()
    End Sub
End Class