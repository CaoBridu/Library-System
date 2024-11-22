Public Class Book
    Public Property CoverImage As String
    Public Property Title As String

    Public Sub New(CoverImage As String, Title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CoverImage = CoverImage
        Me.Title = Title

    End Sub
End Class
