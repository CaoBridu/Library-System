Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Book1 As New Book("C:\Users\CSAR1018026\Desktop\OIP.jpg", "Nian")
        BookTable.Controls.Add(Book1)
    End Sub

    Private Sub BookTable_Paint(sender As Object, e As PaintEventArgs) Handles BookTable.Paint
    End Sub


End Class
