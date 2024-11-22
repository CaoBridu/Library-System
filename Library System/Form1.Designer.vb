<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        BookTable = New TableLayoutPanel()
        SuspendLayout()
        ' 
        ' BookTable
        ' 
        BookTable.ColumnCount = 5
        BookTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        BookTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        BookTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        BookTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        BookTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        BookTable.Location = New Point(0, -1)
        BookTable.Name = "BookTable"
        BookTable.RowCount = 4
        BookTable.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        BookTable.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        BookTable.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        BookTable.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        BookTable.Size = New Size(1074, 647)
        BookTable.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1074, 648)
        Controls.Add(BookTable)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BookTable As TableLayoutPanel

End Class
