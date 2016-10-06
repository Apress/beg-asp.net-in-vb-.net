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

    Public Function GetCategories() As DataSet
        Dim Query As String = "SELECT * FROM Categories"
        Dim ds As DataSet = FillDataSet(Query, "Categories")
        Return ds
    End Function

    Public Overloads Function GetItems() As DataSet
        Dim Query As String = "SELECT * FROM Categories"
        Dim ds As DataSet = FillDataSet(Query, "Items")
        Return ds
    End Function

    Public Overloads Function GetItems(ByVal categoryID As Double) as DataSet
        Dim Query As String = "SELECT * FROM Items "
        Query &= "WHERE Category_ID='" & categoryID & "'"
        Dim ds As DataSet = FillDataSet(Query, "Items")
        Return ds
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
