Namespace AdvancedControls

    Public Class TitledTextBox
        Inherits TextBox

        Protected Overrides Sub Render(ByVal writer As HtmlTextWriter)
            writer.Write("<h1>Here is a title</hi>")
            writer.Write("<br>")
            MyBase.Render(writer)
        End Sub

    End Class

End Namespace