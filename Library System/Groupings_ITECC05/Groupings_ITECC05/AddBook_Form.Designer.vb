<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBook_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        BookCover_PictureBox = New PictureBox()
        ClearAll_Button = New Button()
        AddBook_Button = New Button()
        SummaryText_Box = New TextBox()
        Summary_Label = New Label()
        Genre_ComboBox = New ComboBox()
        Author_TextBox = New TextBox()
        Title_TextBox = New TextBox()
        Genre_Label = New Label()
        Author_Label = New Label()
        Title_Label = New Label()
        OpenFD = New OpenFileDialog()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(BookCover_PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(853, 640)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(BookCover_PictureBox)
        Panel2.Controls.Add(ClearAll_Button)
        Panel2.Controls.Add(AddBook_Button)
        Panel2.Controls.Add(SummaryText_Box)
        Panel2.Controls.Add(Summary_Label)
        Panel2.Controls.Add(Genre_ComboBox)
        Panel2.Controls.Add(Author_TextBox)
        Panel2.Controls.Add(Title_TextBox)
        Panel2.Controls.Add(Genre_Label)
        Panel2.Controls.Add(Author_Label)
        Panel2.Controls.Add(Title_Label)
        Panel2.Font = New Font("Segoe UI", 15.0F)
        Panel2.Location = New Point(16, 19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(819, 600)
        Panel2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(14, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 31)
        Button2.TabIndex = 30
        Button2.Text = "Return to Dashboard"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(612, 270)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 53)
        Button1.TabIndex = 29
        Button1.Text = "Add Book Cover"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BookCover_PictureBox
        ' 
        BookCover_PictureBox.BackColor = Color.Transparent
        BookCover_PictureBox.BackgroundImageLayout = ImageLayout.Center
        BookCover_PictureBox.BorderStyle = BorderStyle.FixedSingle
        BookCover_PictureBox.Location = New Point(612, 56)
        BookCover_PictureBox.Name = "BookCover_PictureBox"
        BookCover_PictureBox.Size = New Size(195, 208)
        BookCover_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        BookCover_PictureBox.TabIndex = 28
        BookCover_PictureBox.TabStop = False
        ' 
        ' ClearAll_Button
        ' 
        ClearAll_Button.Location = New Point(409, 500)
        ClearAll_Button.Name = "ClearAll_Button"
        ClearAll_Button.Size = New Size(185, 65)
        ClearAll_Button.TabIndex = 27
        ClearAll_Button.Text = "Clear All"
        ClearAll_Button.UseVisualStyleBackColor = True
        ' 
        ' AddBook_Button
        ' 
        AddBook_Button.Location = New Point(189, 500)
        AddBook_Button.Name = "AddBook_Button"
        AddBook_Button.Size = New Size(185, 65)
        AddBook_Button.TabIndex = 26
        AddBook_Button.Text = "Add Book"
        AddBook_Button.UseVisualStyleBackColor = True
        ' 
        ' SummaryText_Box
        ' 
        SummaryText_Box.Location = New Point(189, 194)
        SummaryText_Box.Multiline = True
        SummaryText_Box.Name = "SummaryText_Box"
        SummaryText_Box.Size = New Size(405, 269)
        SummaryText_Box.TabIndex = 25
        ' 
        ' Summary_Label
        ' 
        Summary_Label.AutoSize = True
        Summary_Label.Font = New Font("Sylfaen", 20.25F)
        Summary_Label.Location = New Point(14, 194)
        Summary_Label.Name = "Summary_Label"
        Summary_Label.Size = New Size(129, 35)
        Summary_Label.TabIndex = 24
        Summary_Label.Text = "Summary:"
        ' 
        ' Genre_ComboBox
        ' 
        Genre_ComboBox.Font = New Font("Segoe UI", 15.0F)
        Genre_ComboBox.FormattingEnabled = True
        Genre_ComboBox.ItemHeight = 28
        Genre_ComboBox.Items.AddRange(New Object() {"Romance", "Fantasy", "Drama", "Horror", "Comedy", "Action", "History"})
        Genre_ComboBox.Location = New Point(189, 148)
        Genre_ComboBox.Name = "Genre_ComboBox"
        Genre_ComboBox.Size = New Size(405, 36)
        Genre_ComboBox.TabIndex = 23
        ' 
        ' Author_TextBox
        ' 
        Author_TextBox.Location = New Point(189, 103)
        Author_TextBox.Multiline = True
        Author_TextBox.Name = "Author_TextBox"
        Author_TextBox.Size = New Size(405, 35)
        Author_TextBox.TabIndex = 21
        ' 
        ' Title_TextBox
        ' 
        Title_TextBox.Location = New Point(189, 56)
        Title_TextBox.Multiline = True
        Title_TextBox.Name = "Title_TextBox"
        Title_TextBox.Size = New Size(405, 35)
        Title_TextBox.TabIndex = 20
        ' 
        ' Genre_Label
        ' 
        Genre_Label.AutoSize = True
        Genre_Label.Font = New Font("Sylfaen", 20.25F)
        Genre_Label.Location = New Point(14, 149)
        Genre_Label.Name = "Genre_Label"
        Genre_Label.Size = New Size(89, 35)
        Genre_Label.TabIndex = 18
        Genre_Label.Text = "Genre:"
        ' 
        ' Author_Label
        ' 
        Author_Label.AutoSize = True
        Author_Label.Font = New Font("Sylfaen", 20.25F)
        Author_Label.Location = New Point(14, 103)
        Author_Label.Name = "Author_Label"
        Author_Label.Size = New Size(167, 35)
        Author_Label.TabIndex = 16
        Author_Label.Text = "Book Author:"
        ' 
        ' Title_Label
        ' 
        Title_Label.AutoSize = True
        Title_Label.Font = New Font("Sylfaen", 20.25F)
        Title_Label.Location = New Point(14, 56)
        Title_Label.Name = "Title_Label"
        Title_Label.Size = New Size(140, 35)
        Title_Label.TabIndex = 15
        Title_Label.Text = "Book Title:"
        ' 
        ' OpenFD
        ' 
        OpenFD.FileName = "OpenFD"
        ' 
        ' AddBook_Form
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(877, 658)
        Controls.Add(Panel1)
        Name = "AddBook_Form"
        Text = "Add Book"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BookCover_PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Summary_Label As Label
    Friend WithEvents Genre_ComboBox As ComboBox
    Friend WithEvents Author_TextBox As TextBox
    Friend WithEvents Title_TextBox As TextBox
    Friend WithEvents Genre_Label As Label
    Friend WithEvents Author_Label As Label
    Friend WithEvents Title_Label As Label
    Friend WithEvents SummaryText_Box As TextBox
    Friend WithEvents ClearAll_Button As Button
    Friend WithEvents AddBook_Button As Button
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents BookCover_PictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
