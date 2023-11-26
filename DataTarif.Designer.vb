<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTarif
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
        TextBox1 = New TextBox()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        TarifDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(TarifDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(58, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(739, 119)
        Panel1.TabIndex = 38
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InactiveCaption
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Enabled = False
        TextBox1.Location = New Point(155, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 27)
        TextBox1.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(35, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 19)
        Label4.TabIndex = 41
        Label4.Text = "Jenis Lapangan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(154, 24)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 40
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(553, 67)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 27)
        TextBox3.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(399, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 19)
        Label2.TabIndex = 38
        Label2.Text = "Tarif Spesial /jam"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(553, 24)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 27)
        TextBox2.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(399, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 19)
        Label3.TabIndex = 35
        Label3.Text = "Tarif Umum /jam"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(35, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 19)
        Label1.TabIndex = 33
        Label1.Text = "Kode Lapangan"
        ' 
        ' TarifDGV
        ' 
        TarifDGV.AllowUserToOrderColumns = True
        TarifDGV.BackgroundColor = SystemColors.HighlightText
        TarifDGV.BorderStyle = BorderStyle.Fixed3D
        TarifDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TarifDGV.GridColor = SystemColors.ActiveCaptionText
        TarifDGV.Location = New Point(58, 226)
        TarifDGV.Name = "TarifDGV"
        TarifDGV.RowHeadersWidth = 51
        TarifDGV.RowTemplate.Height = 29
        TarifDGV.Size = New Size(739, 188)
        TarifDGV.TabIndex = 37
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(590, 174)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 36
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
        Button3.Location = New Point(459, 174)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 35
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
        Button2.Location = New Point(329, 174)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 34
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
        Button1.Location = New Point(197, 174)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 33
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataTarif
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(854, 437)
        Controls.Add(Panel1)
        Controls.Add(TarifDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "DataTarif"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataTarif"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(TarifDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TarifDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
