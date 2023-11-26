<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLogin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenuLogin))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(53, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(705, 325)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(446, 241)
        Label2.Name = "Label2"
        Label2.Size = New Size(206, 25)
        Label2.TabIndex = 18
        Label2.Text = "Login Sebagai Pegawai"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(62, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 25)
        Label1.TabIndex = 17
        Label1.Text = "Login Sebagai Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(433, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(47, 37)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(228, 175)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' MenuLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "MenuLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MenuLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
