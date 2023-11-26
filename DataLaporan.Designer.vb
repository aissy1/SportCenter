<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLaporan
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
        LaporanDGV = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button3 = New Button()
        Button2 = New Button()
        CType(LaporanDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LaporanDGV
        ' 
        LaporanDGV.BackgroundColor = SystemColors.HighlightText
        LaporanDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LaporanDGV.Location = New Point(75, 240)
        LaporanDGV.Name = "LaporanDGV"
        LaporanDGV.RowHeadersWidth = 51
        LaporanDGV.RowTemplate.Height = 29
        LaporanDGV.Size = New Size(800, 320)
        LaporanDGV.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Location = New Point(111, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(716, 125)
        Panel1.TabIndex = 40
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
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(474, 171)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 42
        Button3.Text = "CLOSE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(360, 171)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 41
        Button2.Text = "SEARCH"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataLaporan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(932, 633)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(LaporanDGV)
        Name = "DataLaporan"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataLaporan"
        CType(LaporanDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LaporanDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
