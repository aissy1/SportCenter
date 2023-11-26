<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEWA
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
        ComboBox1 = New ComboBox()
        SewaDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        Button5 = New Button()
        CType(SewaDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(141, 17)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 28)
        ComboBox1.TabIndex = 47
        ' 
        ' SewaDGV
        ' 
        SewaDGV.AllowUserToOrderColumns = True
        SewaDGV.BackgroundColor = SystemColors.HighlightText
        SewaDGV.BorderStyle = BorderStyle.Fixed3D
        SewaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SewaDGV.GridColor = SystemColors.ActiveCaptionText
        SewaDGV.Location = New Point(66, 253)
        SewaDGV.Name = "SewaDGV"
        SewaDGV.RowHeadersWidth = 51
        SewaDGV.RowTemplate.Height = 29
        SewaDGV.Size = New Size(739, 188)
        SewaDGV.TabIndex = 45
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(517, 201)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 44
        Button4.Text = "DATA"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(398, 201)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 43
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
        Button2.Location = New Point(268, 201)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 42
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
        Button1.Location = New Point(136, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 41
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(360, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 19)
        Label5.TabIndex = 40
        Label5.Text = "Status Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(360, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 19)
        Label3.TabIndex = 36
        Label3.Text = "Jumlah"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(23, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 19)
        Label2.TabIndex = 35
        Label2.Text = "Jenis Barang"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(141, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 33
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(112, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(664, 157)
        Panel1.TabIndex = 49
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Dipinjam", "Dikembalikan"})
        ComboBox3.Location = New Point(480, 60)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(149, 28)
        ComboBox3.TabIndex = 52
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(480, 17)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(85, 28)
        ComboBox2.TabIndex = 51
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(23, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 19)
        Label4.TabIndex = 50
        Label4.Text = "Nama Penyewa"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(640, 201)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 50
        Button5.Text = "CLOSE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' SEWA
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(864, 474)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        Controls.Add(SewaDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "SEWA"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "SEWA"
        CType(SewaDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SewaDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
