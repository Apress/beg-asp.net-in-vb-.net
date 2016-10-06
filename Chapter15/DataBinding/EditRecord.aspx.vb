Imports System.Data
Imports System.data.OleDb
Public Class EditRecord
    Inherits System.Web.UI.Page
        Protected WithEvents lstProduct As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblRecordInfo As System.Web.UI.WebControls.Label
    Protected WithEvents lstCategory As System.Web.UI.WebControls.ListBox
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button
                Protected WithEvents lblChoose As System.Web.UI.WebControls.Label
            
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private strConnection As String = "Provider=SQLOLEDB.1;Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.IsPostBack = False Then

            ' Define the ADO.NET objects for selecting Products.
            Dim strCommand As String = "SELECT ProductID, ProductName FROM Products"
            Dim con As New OleDbConnection(strConnection)
            Dim com As New OleDbCommand(strCommand, con)

            ' Open the connection.
            con.Open()

            ' Define the binding.
            lstProduct.DataSource = com.ExecuteReader()
            lstProduct.DataTextField = "ProductName"
            lstProduct.DataValueField = "ProductID"
            lstProduct.DataBind()
            lstProduct.SelectedIndex = -1

            con.Close()

        End If

    End Sub

    Private Sub lstProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProduct.SelectedIndexChanged

        ' Create a command for selecting the matching product record.
        Dim strProductCommand As String
        strProductCommand = "SELECT ProductName, QuantityPerUnit, CategoryName FROM Products "
        strProductCommand &= "INNER JOIN Categories ON Categories.CategoryID=Products.CategoryID "
        strProductCommand &= "WHERE ProductID='" & lstProduct.SelectedItem.Value & " '"

        ' Create the Connection and Command objects.
        Dim con As New OleDbConnection(strConnection)
        Dim comProducts As New OleDbCommand(strProductCommand, con)

        ' Retrieve the information for the selected product.
        con.Open()
        Dim reader As OleDbDataReader = comProducts.ExecuteReader
        reader.Read()

        ' Update the display.
        lblRecordInfo.Text = "<b>Product:</b> " & reader("ProductName") & "<br>"
        lblRecordInfo.Text &= "<b>Quantity/Unit:</b> " & reader("QuantityPerUnit") & "<br>"
        lblRecordInfo.Text &= "<b>Category:</b> " & reader("CategoryName")

        ' Store the corresponding CategoryName for future reference.
        Dim strMatchCategory As String = reader("CategoryName")

        ' Close the reader.
        reader.Close()

        ' Create a new Command for selecting categories.
        Dim strCategoryCommand As String = "SELECT CategoryName, CategoryID FROM Categories"
        Dim comCategories As New OleDbCommand(strCategoryCommand, con)

        ' Retrieve the category information, and bind it.
        lstCategory.DataSource = comCategories.ExecuteReader()
        lstCategory.DataTextField = "CategoryName"
        lstCategory.DataValueField = "CategoryID"
        lstCategory.DataBind()
        con.Close()

        ' Highlight the matching category in the list.
        lstCategory.Items.FindByText(strMatchCategory).Selected = True

        lstCategory.Visible = True
        cmdUpdate.Visible = True

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        ' Define the Command.
        Dim strCommand As String = "UPDATE Products SET CategoryID='" & lstCategory.SelectedItem.Value & "' WHERE ProductID=" & lstProduct.SelectedItem.Value
        Dim con As New OleDbConnection(strConnection)
        Dim com As New OleDbCommand(strCommand, con)

        ' Execute the update.
        con.Open()
        com.ExecuteNonQuery()
        con.Close()

    End Sub
End Class
