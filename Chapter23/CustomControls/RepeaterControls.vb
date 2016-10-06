Imports System.ComponentModel

Namespace AdvancedControls

    Public Class ConfigurableRepeaterControl
        Inherits System.Web.UI.WebControls.WebControl

        Public Sub New()
            Viewstate("RepeatTimes") = 3
            Viewstate("Text") = "Text"
        End Sub

        Public Property RepeatTimes() As Integer
            Get
                Return CType(Viewstate("RepeatTimes"), Integer)
            End Get
            Set(ByVal Value As Integer)
                Viewstate("RepeatTimes") = Value
            End Set
        End Property

        Public Property Text() As String
            Get
                Return CType(Viewstate("Text"), String)
            End Get
            Set(ByVal Value As String)
                Viewstate("Text") = Value
            End Set
        End Property

        Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
            MyBase.RenderContents(writer)
            Dim i As Integer
            For i = 1 To CType(Viewstate("RepeatTimes"), Integer)
                writer.Write(CType(Viewstate("Text"), String) & "<br>")
            Next
        End Sub

    End Class


    Public Class AdaptiveRepeater
        Inherits System.Web.UI.WebControls.WebControl

        Private _RepeatTimes As Integer = 3

        <Category("Layout"), Description("Sets the number of times Text will be repeated")> _
        Public Property RepeatTimes() As Integer
            Get
                Return _RepeatTimes
            End Get
            Set(ByVal Value As Integer)
                _RepeatTimes = Value
            End Set
        End Property

        Private _Text As String = "Text"
        Public Property Text() As String
            Get
                Return _Text
            End Get
            Set(ByVal Value As String)
                _Text = Value
            End Set
        End Property

        Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
            MyBase.RenderContents(writer)

            If Me.Page.Request.Browser.JavaScript = True Then
                writer.Write("<i>You support JavaScript.</i><br>")
            End If

            If Me.Page.Request.Browser.Browser = "IE" Then
                writer.Write("<i>Output configured for IE.</i><br>")
            ElseIf Me.Page.Request.Browser.Browser = "Netscape" Then
                writer.Write("<i>Output configured for Netscape.</i><br>")
            End If

            Dim i As Integer
            For i = 1 To _RepeatTimes
                writer.Write(_Text & "<br>")
            Next

        End Sub

    End Class
End Namespace