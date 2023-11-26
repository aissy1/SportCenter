<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Panel1 = New Panel()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        BookingDGV = New DataGridView()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(BookingDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(ComboBox5)
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(299, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(868, 218)
        Panel1.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(678, 62)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(112, 27)
        TextBox3.TabIndex = 26
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(578, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(124, 27)
        TextBox1.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(479, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 19)
        Label8.TabIndex = 57
        Label8.Text = "Total"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"Umum", "Spesial"})
        ComboBox5.Location = New Point(578, 62)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(94, 28)
        ComboBox5.TabIndex = 56
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Lunas", "DP"})
        ComboBox4.Location = New Point(578, 140)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(94, 28)
        ComboBox4.TabIndex = 55
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"7.00", "8.00", "9.00", "10.00", "11.00", "13.00", "14.00", "15.00", "16.00", "17.00", "18.00", "19.00", "20.00", "21.00", "22.00", "23.00"})
        ComboBox3.Location = New Point(174, 145)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(94, 28)
        ComboBox3.TabIndex = 54
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(53, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 19)
        Label1.TabIndex = 53
        Label1.Text = "WaktuMain"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        ComboBox2.Location = New Point(578, 17)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(94, 28)
        ComboBox2.TabIndex = 51
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(53, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 19)
        Label3.TabIndex = 51
        Label3.Text = "Kode Lapangan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(174, 64)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 28)
        ComboBox1.TabIndex = 50
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(479, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 19)
        Label7.TabIndex = 48
        Label7.Text = "Bayar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(53, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 19)
        Label6.TabIndex = 47
        Label6.Text = "Tanggal Main"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Location = New Point(174, 102)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(258, 27)
        DateTimePicker1.TabIndex = 46
        DateTimePicker1.Value = New Date(2023, 10, 22, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(479, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 19)
        Label5.TabIndex = 19
        Label5.Text = "Durasi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(479, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 19)
        Label4.TabIndex = 18
        Label4.Text = "Tarif"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(53, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 19)
        Label2.TabIndex = 13
        Label2.Text = "Nama"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(174, 17)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 11
        ' 
        ' BookingDGV
        ' 
        BookingDGV.AllowUserToOrderColumns = True
        BookingDGV.BackgroundColor = SystemColors.HighlightText
        BookingDGV.BorderStyle = BorderStyle.Fixed3D
        BookingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BookingDGV.GridColor = SystemColors.ActiveCaptionText
        BookingDGV.Location = New Point(96, 328)
        BookingDGV.Name = "BookingDGV"
        BookingDGV.RowHeadersWidth = 51
        BookingDGV.RowTemplate.Height = 29
        BookingDGV.Size = New Size(1241, 373)
        BookingDGV.TabIndex = 21
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(635, 278)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 19
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(505, 278)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 18
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(373, 278)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 17
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(763, 278)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 23
        Button5.Text = "PRINT"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button6.Cursor = Cursors.Hand
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ForeColor = SystemColors.ControlLightLight
        Button6.Location = New Point(997, 278)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 24
        Button6.Text = "CLOSE"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(879, 278)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 25
        Button4.Text = "COUNT"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Booking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(1422, 756)
        Controls.Add(Button4)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        Controls.Add(BookingDGV)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Booking"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Booking"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(BookingDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BookingDGV As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
