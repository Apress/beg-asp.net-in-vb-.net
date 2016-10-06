Public Class ButtonGrid
    Inherits WebControl
    Implements IPostBackEventHandler

    Event GridClick(ByVal ButtonName As String)

    Public Sub New()
        Viewstate("Rows") = 2
        Viewstate("Cols") = 2
    End Sub

    Public Overridable Overloads Sub RaisePostBackEvent(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        RaiseEvent GridClick(eventArgument)
    End Sub

    Public Property Cols() As Integer
        Get
            Return CType(Viewstate("Cols"), Integer)
        End Get
        Set(ByVal Value As Integer)
            Viewstate("Cols") = Value
        End Set
    End Property

    Public Property Rows() As Integer
        Get
            Return CType(Viewstate("Rows"), Integer)
        End Get
        Set(ByVal Value As Integer)
            Viewstate("Rows") = Value
        End Set
    End Property

    Protected Overrides Sub CreateChildControls()
        Dim i, j, k As Integer

        For i = 1 To CType(Viewstate("Rows"), Integer)

            For j = 1 To CType(Viewstate("Cols"), Integer)
                k += 1
                Dim ctrlB As New Button()
                ctrlB.Width = Unit.Pixel(60)
                ctrlB.Text = k.ToString()
                ctrlB.Attributes("OnClick") = Page.GetPostBackEventReference(Me, ctrlB.Text)

                ' Add a button.
                Me.Controls.Add(ctrlB)
            Next

            ' Add a line break.
            Dim ctrlL As New LiteralControl("<br>")
            Me.Controls.Add(ctrlL)
        Next
    End Sub

End Class
