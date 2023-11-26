<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLapangan
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
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        LapanganDGV = New DataGridView()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        CType(LapanganDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(516, 151)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 22
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
        Button3.Location = New Point(397, 151)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 21
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
        Button2.Location = New Point(267, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 20
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
        Button1.Location = New Point(135, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 19
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LapanganDGV
        ' 
        LapanganDGV.BackgroundColor = SystemColors.HighlightText
        LapanganDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LapanganDGV.Location = New Point(57, 216)
        LapanganDGV.Name = "LapanganDGV"
        LapanganDGV.RowHeadersWidth = 51
        LapanganDGV.RowTemplate.Height = 29
        LapanganDGV.Size = New Size(610, 188)
        LapanganDGV.TabIndex = 24
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(34, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(671, 101)
        Panel1.TabIndex = 25
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Futsal", "Badminton", "Basket"})
        ComboBox1.Location = New Point(483, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(364, 38)
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(145, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 24
        ' 
        ' DataLapangan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(747, 450)
        Controls.Add(Panel1)
        Controls.Add(LapanganDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "DataLapangan"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataLapangan"
        CType(LapanganDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LapanganDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
