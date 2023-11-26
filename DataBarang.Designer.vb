<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBarang
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
        BarangDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Button5 = New Button()
        CType(BarangDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BarangDGV
        ' 
        BarangDGV.AllowUserToOrderColumns = True
        BarangDGV.BackgroundColor = SystemColors.HighlightText
        BarangDGV.BorderStyle = BorderStyle.Fixed3D
        BarangDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BarangDGV.GridColor = SystemColors.ActiveCaptionText
        BarangDGV.Location = New Point(50, 237)
        BarangDGV.Name = "BarangDGV"
        BarangDGV.RowHeadersWidth = 51
        BarangDGV.RowTemplate.Height = 29
        BarangDGV.Size = New Size(739, 188)
        BarangDGV.TabIndex = 30
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(615, 185)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 29
        Button4.Text = "CLOSE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(380, 185)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 28
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
        Button2.Location = New Point(250, 185)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 27
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
        Button1.Location = New Point(118, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 26
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(50, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(739, 119)
        Panel1.TabIndex = 31
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Bagus", "Rusak"})
        ComboBox1.Location = New Point(563, 23)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(408, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 19)
        Label4.TabIndex = 38
        Label4.Text = "Kondisi Barang"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(563, 61)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 27)
        TextBox3.TabIndex = 37
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(135, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(408, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 19)
        Label3.TabIndex = 35
        Label3.Text = "Jumlah"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(21, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 19)
        Label2.TabIndex = 34
        Label2.Text = "Jenis Barang"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(21, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 19)
        Label1.TabIndex = 33
        Label1.Text = "Kode Barang"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(135, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 32
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(498, 185)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 32
        Button5.Text = "SEWA"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' DataBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(859, 475)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        Controls.Add(BarangDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "DataBarang"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataBarang"
        CType(BarangDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BarangDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button5 As Button
End Class
