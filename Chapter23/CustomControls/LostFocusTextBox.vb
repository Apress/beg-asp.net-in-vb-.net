Namespace AdvancedControls

    Public Class LostFocusTextBox
        Inherits TextBox

        Protected Overrides Sub AddAttributesToRender(ByVal writer As HtmlTextWriter)
            MyBase.AddAttributesToRender(writer)
            writer.AddAttribute("OnBlur", "javascript:alert('You Lost Focus')")
        End Sub

    End Class

End Namespace