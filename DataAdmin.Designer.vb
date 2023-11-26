<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataAdmin
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
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        AdminDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(AdminDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(31, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(739, 163)
        Panel1.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(122, 33)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 27)
        TextBox3.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(14, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 19)
        Label1.TabIndex = 21
        Label1.Text = "Nama Admin"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(503, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(404, 89)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 19)
        Label5.TabIndex = 19
        Label5.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(503, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(400, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 19)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' AdminDGV
        ' 
        AdminDGV.AllowUserToOrderColumns = True
        AdminDGV.BackgroundColor = SystemColors.HighlightText
        AdminDGV.BorderStyle = BorderStyle.Fixed3D
        AdminDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdminDGV.GridColor = SystemColors.ActiveCaptionText
        AdminDGV.Location = New Point(110, 250)
        AdminDGV.Name = "AdminDGV"
        AdminDGV.RowHeadersWidth = 51
        AdminDGV.RowTemplate.Height = 29
        AdminDGV.Size = New Size(580, 188)
        AdminDGV.TabIndex = 21
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(558, 200)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 20
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
        Button3.Location = New Point(439, 200)
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
        Button2.Location = New Point(309, 200)
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
        Button1.Location = New Point(177, 200)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 17
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(AdminDGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "DataAdmin"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataAdmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(AdminDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AdminDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
End Class
