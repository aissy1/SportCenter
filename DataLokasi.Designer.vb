<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLokasi
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
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        LokasiDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(LokasiDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(96, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(702, 117)
        Panel1.TabIndex = 31
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(145, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(81, 28)
        ComboBox1.TabIndex = 34
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(447, 34)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(220, 27)
        TextBox3.TabIndex = 33
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(376, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 19)
        Label2.TabIndex = 32
        Label2.Text = "Lokasi"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ButtonShadow
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(145, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(220, 27)
        TextBox2.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(28, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 19)
        Label4.TabIndex = 26
        Label4.Text = "Jenis Lapangan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(24, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 19)
        Label1.TabIndex = 25
        Label1.Text = "Kode Lapangan"
        ' 
        ' LokasiDGV
        ' 
        LokasiDGV.BackgroundColor = SystemColors.HighlightText
        LokasiDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LokasiDGV.Location = New Point(122, 243)
        LokasiDGV.Name = "LokasiDGV"
        LokasiDGV.RowHeadersWidth = 51
        LokasiDGV.RowTemplate.Height = 29
        LokasiDGV.Size = New Size(643, 188)
        LokasiDGV.TabIndex = 30
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(601, 176)
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
        Button3.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(474, 176)
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
        Button2.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(344, 176)
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
        Button1.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(212, 176)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 26
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataLokasi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(922, 474)
        Controls.Add(Panel1)
        Controls.Add(LokasiDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "DataLokasi"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataLokasi"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(LokasiDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LokasiDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
