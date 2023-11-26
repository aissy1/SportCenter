Public Class MenuLogin
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim obj As New Login0
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub MenuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class