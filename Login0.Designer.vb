<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login0
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login0))
        PictureBox3 = New PictureBox()
        Loginbtn = New Button()
        Pass = New TextBox()
        ID = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(631, 60)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 100)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' Loginbtn
        ' 
        Loginbtn.BackColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Loginbtn.Cursor = Cursors.Hand
        Loginbtn.FlatStyle = FlatStyle.Popup
        Loginbtn.ForeColor = SystemColors.ButtonHighlight
        Loginbtn.Location = New Point(704, 335)
        Loginbtn.Name = "Loginbtn"
        Loginbtn.Size = New Size(94, 29)
        Loginbtn.TabIndex = 13
        Loginbtn.Text = "LOGIN"
        Loginbtn.UseVisualStyleBackColor = False
        ' 
        ' Pass
        ' 
        Pass.Location = New Point(587, 276)
        Pass.Name = "Pass"
        Pass.PasswordChar = "*"c
        Pass.Size = New Size(224, 27)
        Pass.TabIndex = 12
        ' 
        ' ID
        ' 
        ID.Location = New Point(587, 204)
        ID.Name = "ID"
        ID.Size = New Size(224, 27)
        ID.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(587, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 10
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(587, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 9
        Label1.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(500, 500)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.FromArgb(CByte(1), CByte(22), CByte(79))
        Button1.Location = New Point(604, 335)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 15
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Login0
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(862, 503)
        Controls.Add(Button1)
        Controls.Add(PictureBox3)
        Controls.Add(Loginbtn)
        Controls.Add(Pass)
        Controls.Add(ID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Login0"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Pass As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
