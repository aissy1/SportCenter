<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdmin))
        PictureBox7 = New PictureBox()
        LabelUser = New Label()
        Panel1 = New Panel()
        LabelRole = New Label()
        Username = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TARIF = New PictureBox()
        PEGAWAI = New PictureBox()
        ADMIN = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        PictureBox3 = New PictureBox()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(TARIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(PEGAWAI, ComponentModel.ISupportInitialize).BeginInit()
        CType(ADMIN, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelUser.ForeColor = SystemColors.ButtonHighlight
        LabelUser.ImageAlign = ContentAlignment.MiddleRight
        LabelUser.Location = New Point(355, 68)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(54, 28)
        LabelUser.TabIndex = 20
        LabelUser.Text = "User"
        LabelUser.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(LabelRole)
        Panel1.Controls.Add(LabelUser)
        Panel1.Controls.Add(Username)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(146, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1233, 217)
        Panel1.TabIndex = 29
        ' 
        ' LabelRole
        ' 
        LabelRole.AutoSize = True
        LabelRole.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelRole.ForeColor = SystemColors.ButtonHighlight
        LabelRole.ImageAlign = ContentAlignment.MiddleRight
        LabelRole.Location = New Point(355, 111)
        LabelRole.Name = "LabelRole"
        LabelRole.Size = New Size(74, 28)
        LabelRole.TabIndex = 21
        LabelRole.Text = "Admin"
        LabelRole.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Username.ForeColor = SystemColors.ButtonHighlight
        Username.ImageAlign = ContentAlignment.MiddleRight
        Username.Location = New Point(214, 68)
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
        Label1.Location = New Point(266, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 28)
        Label1.TabIndex = 8
        Label1.Text = "Role :"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumSeaGreen
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(1155, 540)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 25
        Label5.Text = "TARIF"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSeaGreen
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(311, 540)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 23
        Label3.Text = "Admin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumSeaGreen
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(729, 540)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 24
        Label4.Text = "PEGAWAI"
        ' 
        ' TARIF
        ' 
        TARIF.BackColor = Color.Lavender
        TARIF.Cursor = Cursors.Hand
        TARIF.Image = CType(resources.GetObject("TARIF.Image"), Image)
        TARIF.Location = New Point(986, 315)
        TARIF.Name = "TARIF"
        TARIF.Size = New Size(393, 211)
        TARIF.SizeMode = PictureBoxSizeMode.CenterImage
        TARIF.TabIndex = 22
        TARIF.TabStop = False
        ' 
        ' PEGAWAI
        ' 
        PEGAWAI.BackColor = Color.Lavender
        PEGAWAI.Cursor = Cursors.Hand
        PEGAWAI.Image = CType(resources.GetObject("PEGAWAI.Image"), Image)
        PEGAWAI.Location = New Point(571, 315)
        PEGAWAI.Name = "PEGAWAI"
        PEGAWAI.Size = New Size(393, 211)
        PEGAWAI.SizeMode = PictureBoxSizeMode.CenterImage
        PEGAWAI.TabIndex = 21
        PEGAWAI.TabStop = False
        ' 
        ' ADMIN
        ' 
        ADMIN.BackColor = Color.Lavender
        ADMIN.Cursor = Cursors.Hand
        ADMIN.Image = CType(resources.GetObject("ADMIN.Image"), Image)
        ADMIN.Location = New Point(146, 315)
        ADMIN.Name = "ADMIN"
        ADMIN.Size = New Size(393, 211)
        ADMIN.SizeMode = PictureBoxSizeMode.CenterImage
        ADMIN.TabIndex = 20
        ADMIN.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Lavender
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(331, 594)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(393, 211)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumSeaGreen
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(497, 822)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 32
        Label2.Text = "LOKASI"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1402, 49)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(81, 73)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumSeaGreen
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(974, 822)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 34
        Label6.Text = "LAPORAN"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Lavender
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(808, 594)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(393, 211)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' MenuAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(1508, 885)
        Controls.Add(Label6)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(TARIF)
        Controls.Add(PEGAWAI)
        Controls.Add(ADMIN)
        Name = "MenuAdmin"
        ShowIcon = False
        Text = "MenuAdmin"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(TARIF, ComponentModel.ISupportInitialize).EndInit()
        CType(PEGAWAI, ComponentModel.ISupportInitialize).EndInit()
        CType(ADMIN, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelRole As Label
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TARIF As PictureBox
    Friend WithEvents PEGAWAI As PictureBox
    Friend WithEvents ADMIN As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
