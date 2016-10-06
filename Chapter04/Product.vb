Public Class Product
    Private _Name As String
    Private _Price As Decimal
    Private _ImageUrl As String

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(Value As String)
            _Name = Value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return _Price
        End Get
        Set(Value As Decimal)
            _Price = Value
        End Set
    End Property

    Public Property ImageUrl() As String
        Get
            Return _ImageUrl
        End Get
        Set(Value As String)
            _ImageUrl = Value
        End Set
    End Property

    Public Function GetHtml() As String
        Dim HtmlString As String
        HtmlString = "<h1>" & _Name & "</h1><br>"
        HtmlString &= "<h3>Costs: " & _Price.ToString() & "</h3><br>"
        HtmlString &= "<img src=" & _ImageUrl & ">"
        Return HtmlString
    End Function

    Public Sub New(name As String, price As Decimal)
        ' These parameters have the same name as the property procedures,
        ' but that doesn't cause a problem. The local variables have priority.
        _Name = name
        _Price = price
    End Sub

End Class
