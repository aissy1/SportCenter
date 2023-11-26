<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPelanggan
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        PELANGGANDGV = New DataGridView()
        Panel1 = New Panel()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        CType(PELANGGANDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(218, 214)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(350, 214)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(480, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 13
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(599, 214)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 14
        Button4.Text = "CLOSE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PELANGGANDGV
        ' 
        PELANGGANDGV.AllowUserToOrderColumns = True
        PELANGGANDGV.BackgroundColor = SystemColors.HighlightText
        PELANGGANDGV.BorderStyle = BorderStyle.Fixed3D
        PELANGGANDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PELANGGANDGV.GridColor = SystemColors.ActiveCaptionText
        PELANGGANDGV.Location = New Point(72, 265)
        PELANGGANDGV.Name = "PELANGGANDGV"
        PELANGGANDGV.RowHeadersWidth = 51
        PELANGGANDGV.RowTemplate.Height = 29
        PELANGGANDGV.Size = New Size(739, 226)
        PELANGGANDGV.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(72, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(739, 163)
        Panel1.TabIndex = 16
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(503, 65)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 27)
        TextBox5.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(404, 68)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 19)
        Label5.TabIndex = 19
        Label5.Text = "No HP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(404, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 19)
        Label4.TabIndex = 18
        Label4.Text = "Umur"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(503, 23)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(94, 27)
        TextBox4.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(122, 109)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 27)
        TextBox3.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(122, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(32, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 19)
        Label3.TabIndex = 14
        Label3.Text = "Alamat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(32, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 19)
        Label2.TabIndex = 13
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(32, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 19)
        Label1.TabIndex = 12
        Label1.Text = "Email"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(122, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 11
        ' 
        ' DataPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(870, 539)
        Controls.Add(Panel1)
        Controls.Add(PELANGGANDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "DataPelanggan"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataPelanggan"
        CType(PELANGGANDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PELANGGANDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
