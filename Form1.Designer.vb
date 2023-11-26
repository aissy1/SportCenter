<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        PELANGGAN = New PictureBox()
        LAPANGAN = New PictureBox()
        BARANG = New PictureBox()
        Jadwal = New PictureBox()
        SEWA = New PictureBox()
        BOOKING = New PictureBox()
        Username = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        PictureBox7 = New PictureBox()
        LabelNomor = New Label()
        LabelPegawai = New Label()
        LabelUser = New Label()
        PictureBox2 = New PictureBox()
        CType(PELANGGAN, ComponentModel.ISupportInitialize).BeginInit()
        CType(LAPANGAN, ComponentModel.ISupportInitialize).BeginInit()
        CType(BARANG, ComponentModel.ISupportInitialize).BeginInit()
        CType(Jadwal, ComponentModel.ISupportInitialize).BeginInit()
        CType(SEWA, ComponentModel.ISupportInitialize).BeginInit()
        CType(BOOKING, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PELANGGAN
        ' 
        PELANGGAN.BackColor = Color.Lavender
        PELANGGAN.Cursor = Cursors.Hand
        PELANGGAN.Image = CType(resources.GetObject("PELANGGAN.Image"), Image)
        PELANGGAN.Location = New Point(144, 399)
        PELANGGAN.Name = "PELANGGAN"
        PELANGGAN.Size = New Size(393, 211)
        PELANGGAN.SizeMode = PictureBoxSizeMode.CenterImage
        PELANGGAN.TabIndex = 0
        PELANGGAN.TabStop = False
        ' 
        ' LAPANGAN
        ' 
        LAPANGAN.BackColor = Color.Lavender
        LAPANGAN.Cursor = Cursors.Hand
        LAPANGAN.Image = CType(resources.GetObject("LAPANGAN.Image"), Image)
        LAPANGAN.Location = New Point(715, 399)
        LAPANGAN.Name = "LAPANGAN"
        LAPANGAN.Size = New Size(393, 211)
        LAPANGAN.SizeMode = PictureBoxSizeMode.CenterImage
        LAPANGAN.TabIndex = 1
        LAPANGAN.TabStop = False
        ' 
        ' BARANG
        ' 
        BARANG.BackColor = Color.Lavender
        BARANG.Cursor = Cursors.Hand
        BARANG.Image = CType(resources.GetObject("BARANG.Image"), Image)
        BARANG.Location = New Point(1253, 399)
        BARANG.Name = "BARANG"
        BARANG.Size = New Size(393, 211)
        BARANG.SizeMode = PictureBoxSizeMode.CenterImage
        BARANG.TabIndex = 2
        BARANG.TabStop = False
        ' 
        ' Jadwal
        ' 
        Jadwal.BackColor = Color.Lavender
        Jadwal.Cursor = Cursors.Hand
        Jadwal.Image = CType(resources.GetObject("Jadwal.Image"), Image)
        Jadwal.Location = New Point(144, 690)
        Jadwal.Name = "Jadwal"
        Jadwal.Size = New Size(393, 211)
        Jadwal.SizeMode = PictureBoxSizeMode.CenterImage
        Jadwal.TabIndex = 3
        Jadwal.TabStop = False
        ' 
        ' SEWA
        ' 
        SEWA.BackColor = Color.Lavender
        SEWA.Cursor = Cursors.Hand
        SEWA.Image = CType(resources.GetObject("SEWA.Image"), Image)
        SEWA.Location = New Point(715, 690)
        SEWA.Name = "SEWA"
        SEWA.Size = New Size(393, 211)
        SEWA.SizeMode = PictureBoxSizeMode.CenterImage
        SEWA.TabIndex = 4
        SEWA.TabStop = False
        ' 
        ' BOOKING
        ' 
        BOOKING.BackColor = Color.Lavender
        BOOKING.Cursor = Cursors.Hand
        BOOKING.Image = CType(resources.GetObject("BOOKING.Image"), Image)
        BOOKING.Location = New Point(1253, 690)
        BOOKING.Name = "BOOKING"
        BOOKING.Size = New Size(393, 211)
        BOOKING.SizeMode = PictureBoxSizeMode.CenterImage
        BOOKING.TabIndex = 5
        BOOKING.TabStop = False
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Username.ForeColor = SystemColors.ButtonHighlight
        Username.ImageAlign = ContentAlignment.MiddleRight
        Username.Location = New Point(229, 51)
        Username.Name = "Username"
        Username.Size = New Size(117, 28)
        Username.TabIndex = 7
        Username.Text = "Username :"
        Username.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(229, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 28)
        Label1.TabIndex = 8
        Label1.Text = "Role :"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.ImageAlign = ContentAlignment.MiddleRight
        Label2.Location = New Point(229, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 28)
        Label2.TabIndex = 9
        Label2.Text = "Nomor :"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSeaGreen
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(285, 613)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 13
        Label3.Text = "MEMBERSHIP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumSeaGreen
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(861, 613)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 14
        Label4.Text = "LAPANGAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumSeaGreen
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(1417, 613)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 15
        Label5.Text = "BARANG"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumSeaGreen
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(261, 904)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 20)
        Label6.TabIndex = 16
        Label6.Text = "JADWAL LAPANGAN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumSeaGreen
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(861, 904)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 20)
        Label7.TabIndex = 17
        Label7.Text = "PERSEWAAN"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumSeaGreen
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(1417, 904)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 18
        Label8.Text = "BOOKING"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(LabelNomor)
        Panel1.Controls.Add(LabelPegawai)
        Panel1.Controls.Add(LabelUser)
        Panel1.Controls.Add(Username)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(278, 108)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1233, 217)
        Panel1.TabIndex = 19
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(64, 51)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(125, 114)
        PictureBox7.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox7.TabIndex = 23
        PictureBox7.TabStop = False
        ' 
        ' LabelNomor
        ' 
        LabelNomor.AutoSize = True
        LabelNomor.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNomor.ForeColor = SystemColors.ButtonHighlight
        LabelNomor.ImageAlign = ContentAlignment.MiddleRight
        LabelNomor.Location = New Point(352, 137)
        LabelNomor.Name = "LabelNomor"
        LabelNomor.Size = New Size(120, 28)
        LabelNomor.TabIndex = 22
        LabelNomor.Text = "081111111"
        LabelNomor.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelPegawai
        ' 
        LabelPegawai.AutoSize = True
        LabelPegawai.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPegawai.ForeColor = SystemColors.ButtonHighlight
        LabelPegawai.ImageAlign = ContentAlignment.MiddleRight
        LabelPegawai.Location = New Point(352, 94)
        LabelPegawai.Name = "LabelPegawai"
        LabelPegawai.Size = New Size(90, 28)
        LabelPegawai.TabIndex = 21
        LabelPegawai.Text = "Pegawai"
        LabelPegawai.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelUser.ForeColor = SystemColors.ButtonHighlight
        LabelUser.ImageAlign = ContentAlignment.MiddleRight
        LabelUser.Location = New Point(352, 51)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(54, 28)
        LabelUser.TabIndex = 20
        LabelUser.Text = "User"
        LabelUser.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1661, 108)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(81, 73)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' MainMenu
        ' 
        AccessibleRole = AccessibleRole.Sound
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(1902, 1033)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(BOOKING)
        Controls.Add(SEWA)
        Controls.Add(Jadwal)
        Controls.Add(BARANG)
        Controls.Add(LAPANGAN)
        Controls.Add(PELANGGAN)
        Name = "MainMenu"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        WindowState = FormWindowState.Maximized
        CType(PELANGGAN, ComponentModel.ISupportInitialize).EndInit()
        CType(LAPANGAN, ComponentModel.ISupportInitialize).EndInit()
        CType(BARANG, ComponentModel.ISupportInitialize).EndInit()
        CType(Jadwal, ComponentModel.ISupportInitialize).EndInit()
        CType(SEWA, ComponentModel.ISupportInitialize).EndInit()
        CType(BOOKING, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PELANGGAN As PictureBox
    Friend WithEvents LAPANGAN As PictureBox
    Friend WithEvents BARANG As PictureBox
    Friend WithEvents Jadwal As PictureBox
    Friend WithEvents SEWA As PictureBox
    Friend WithEvents BOOKING As PictureBox
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelNomor As Label
    Friend WithEvents LabelPegawai As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
