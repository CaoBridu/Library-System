Public Class Book
    Public Sub New(ImagePath As String, Title As String)
        ' This call is required by the designer.
        InitializeComponent()

        PictureBox1.ImageLocation = ImagePath
        Label1.Text = Title

        AddHandler Me.MouseHover, AddressOf OnMouseHover
        AddHandler PictureBox1.MouseHover, AddressOf OnMouseHover
        AddHandler Label1.MouseHover, AddressOf OnMouseHover

        AddHandler Me.MouseLeave, AddressOf OnMouseLeave
        AddHandler PictureBox1.MouseLeave, AddressOf OnMouseLeave
        AddHandler Label1.MouseLeave, AddressOf OnMouseLeave
    End Sub

    Private Sub OnMouseHover(sender As Object, e As EventArgs)
        BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub OnMouseLeave(sender As Object, e As EventArgs)
        BorderStyle = BorderStyle.None
    End Sub
End Class
