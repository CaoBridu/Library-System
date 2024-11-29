Imports MySql.Data.MySqlClient

Public Class AddBook_Form
    Dim MySqlConn As MySqlConnection
    Dim Reader As MySqlDataReader
    Dim Command As MySqlCommand
    Dim Query As String


    Dim Current_DB As String = "insert-database-name-here"
    Dim Table_Name As String = "insert-table-name-here"


    Dim Title As String
    Dim Author As String
    Dim Genre As String
    Dim Summary As String

    'PhotoPath will be assigned to FileName, the FilePath of the selected book cover.
    Dim PhotoPath As String


    Private Sub a_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Genre_ComboBox.SelectedIndexChanged
        Genre = Genre_ComboBox.SelectedItem.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Title_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Title_TextBox.TextChanged
        Title = Title_TextBox.Text
    End Sub

    Private Sub Author_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Author_TextBox.TextChanged
        Author = Author_TextBox.Text
    End Sub

    Private Sub AddBook_Button_Click(sender As Object, e As EventArgs) Handles AddBook_Button.Click

        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        'Add nalang Logic for connecting to Database and Performing The Query

        Try
            MySqlConn.Open()
            MessageBox.Show($"Connection To MySql Database ({Current_DB}) Successfully Established!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Query = $"insert into {Current_DB}.{Table_Name} (fields) values()...."
        Command = New MySqlCommand(Query, MySqlConn)

        Try
            MessageBox.Show($"Book Added Successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub SummaryText_Box_TextChanged(sender As Object, e As EventArgs) Handles SummaryText_Box.TextChanged
        Summary = SummaryText_Box.Text
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFD.FileOk

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BookCover_PictureBox.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        OpenFD.InitialDirectory = "C:\"
        OpenFD.Title = "Select a Book Cover"
        OpenFD.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFD.ShowDialog()
        Try
            PhotoPath = OpenFD.FileName
            BookCover_PictureBox.Image = Image.FromFile(PhotoPath)
            BookCover_PictureBox.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub ClearAll_Button_Click(sender As Object, e As EventArgs) Handles ClearAll_Button.Click
        Title_TextBox.Text = ""
        Author_TextBox.Text = ""
        Genre_ComboBox.ResetText()
        SummaryText_Box.Text = ""
        BookCover_PictureBox.Image = Nothing
    End Sub
End Class
