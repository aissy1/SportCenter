<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jadwal
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
        JadwalDGV = New DataGridView()
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        CType(JadwalDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' JadwalDGV
        ' 
        JadwalDGV.BackgroundColor = SystemColors.HighlightText
        JadwalDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        JadwalDGV.Location = New Point(125, 272)
        JadwalDGV.Name = "JadwalDGV"
        JadwalDGV.RowHeadersWidth = 51
        JadwalDGV.RowTemplate.Height = 29
        JadwalDGV.Size = New Size(649, 188)
        JadwalDGV.TabIndex = 33
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(325, 212)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 31
        Button4.Text = "SEARCH"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(446, 212)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 38
        Button5.Text = "CLOSE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Location = New Point(91, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(716, 125)
        Panel1.TabIndex = 39
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(148, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 19)
        Label1.TabIndex = 43
        Label1.Text = "Tanggal Main"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Location = New Point(269, 40)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(282, 27)
        DateTimePicker1.TabIndex = 40
        ' 
        ' Jadwal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(897, 522)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(JadwalDGV)
        Controls.Add(Button4)
        Name = "Jadwal"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Jadwal"
        CType(JadwalDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents JadwalDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
