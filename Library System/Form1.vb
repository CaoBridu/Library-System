Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Book1 As New Book("path", "Nian")
        BookTable.Controls.Add(Book1)
        BookTable.Controls.Add(New Book("path", "Test"))
    End Sub
End Class
