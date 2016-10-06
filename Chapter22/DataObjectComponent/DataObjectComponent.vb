Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

Public Class DBUtil

    Private ConnectionString As String

    Public Sub New()
        ConnectionString = ConfigurationSettings.AppSettings("ConnectionString")
        If ConnectionString = "" Then
            Throw New ApplicationException("Missing ConnectionString variable in web.config file.")
        End If
    End Sub

    Public Function GetCategories() As Collection
        Dim Query As String = "SELECT * FROM Categories"
        Dim ds As DataSet = FillDataSet(Query, "Categories")
        Dim dr As DataRow
        Dim Categories As New Collection()

        For Each dr In ds.Tables("Categories").Rows
            Dim Entry As New Category()
            Entry.ID = dr("ID")
            Entry.Name = dr("Name")
            Categories.Add(Entry)
        Next

        Return Categories
    End Function

    Public Function GetItems(ByVal categoryID As Double) As Collection
        Dim Query As String = "SELECT * FROM Items "
        Query &= "INNER JOIN Categories ON Category_ID=Categories.ID "
        Query &= "WHERE Category_ID='" & categoryID & "'"
        Dim ds As DataSet = FillDataSet(Query, "Items")
        Dim dr As DataRow
        Dim Items As New Collection()

        For Each dr In ds.Tables("Items").Rows
            Dim Entry As New Item()
            Entry.ID = dr("ID")
            Entry.Title = dr("Title")
            Entry.Price = dr("Price")
            Entry.Description = dr("Description")
            Entry.Category = dr("Name")
            Items.Add(Entry)
        Next

        Return Items
    End Function

    Public Sub AddCategory(ByVal name As String)
        Dim Insert As String = "INSERT INTO Categories "
        Insert &= "(Name) VALUES ('" & name & "')"

        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(Insert, con)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Sub AddItem(ByVal title As String, ByVal description As String, _
                       ByVal price As Decimal, ByVal categoryID As Integer)
        Dim Insert As String = "INSERT INTO Items "
        Insert &= "(Title, Description, Price, Category_ID)"
        Insert &= "VALUES ('" & title & "', '" & description & "', "
        Insert &= price & ", '" & categoryID & "')"

        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(Insert, con)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Function FillDataSet(ByVal query As String, ByVal tableName As String) As DataSet
        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(cmd)

        Dim ds As New DataSet()
        adapter.Fill(ds, tableName)
        con.Close()

        Return ds
    End Function

    Public Function GetAveragePrice() As Decimal
        Dim Query As String = "SELECT AVG(Price) FROM Items"

        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(Query, con)

        con.Open()
        Dim Average As Decimal = cmd.ExecuteScalar()
        con.Close()

        Return Average
    End Function

    Public Function GetTotalItems() As Integer
        Dim Query As String = "SELECT Count(*) FROM Items"

        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(Query, con)

        con.Open()
        Dim Count As Integer = cmd.ExecuteScalar()
        con.Close()

        Return Count
    End Function

End Class


Public Class Item
    Public ID As Integer
    Public Price As Decimal
    Public Description As String

    Private _Title As String
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal Value As String)
            _Title = Value
        End Set
    End Property

    Private _Category As String
    Public Property Category() As String
        Get
            Return _Category
        End Get
        Set(ByVal Value As String)
            _Category = Value
        End Set
    End Property
End Class

Public Class Category

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal Value As Integer)
            _ID = Value
        End Set
    End Property

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
        End Set
    End Property

End Class
