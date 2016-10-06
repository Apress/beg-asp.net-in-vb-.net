Imports System.IO
Imports System.Xml

Public Class XmlDocuments
    Inherits System.Web.UI.Page
    Protected WithEvents cmdDisplay As System.Web.UI.WebControls.Button
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents dgResults As System.Web.UI.WebControls.DataGrid
    Protected WithEvents cmdSearch As System.Web.UI.WebControls.Button
    Protected WithEvents cmdCreate As System.Web.UI.WebControls.Button

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


    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        lblStatus.Text = ""

        ' Start with a blank in memory document.
        Dim doc As New XmlDocument()

        ' Create some variables that will be useful for manipulating XML data.
        Dim RootElement, ProductElement, PriceElement As XmlElement
        Dim ProductAttribute As XmlAttribute
        Dim Comment As XmlComment

        ' Create the declaration.
        Dim Declaration As XmlDeclaration
        Declaration = doc.CreateXmlDeclaration("1.0", Nothing, "yes")

        ' Insert the declaration as the first node.
        doc.InsertBefore(Declaration, doc.DocumentElement)

        ' Add a comment.
        Comment = doc.CreateComment("Created with the XmlDocument class.")
        doc.InsertAfter(Comment, Declaration)

        ' Add the root node.
        RootElement = doc.CreateElement("SuperProProductList")
        doc.InsertAfter(RootElement, Comment)

        ' Add the first product.
        ProductElement = doc.CreateElement("Product")
        RootElement.AppendChild(ProductElement)

        ' Set and add the product attributes.
        ProductAttribute = doc.CreateAttribute("ID")
        ProductAttribute.Value = "1"
        ProductElement.SetAttributeNode(ProductAttribute)
        ProductAttribute = doc.CreateAttribute("Name")
        ProductAttribute.Value = "Chair"
        ProductElement.SetAttributeNode(ProductAttribute)

        ' Add the price node.
        PriceElement = doc.CreateElement("Price")
        PriceElement.InnerText = "49.33"
        ProductElement.AppendChild(PriceElement)


        ' Add the second product.
        ProductElement = doc.CreateElement("Product")
        RootElement.AppendChild(ProductElement)

        ' Set and add the product attributes.
        ProductAttribute = doc.CreateAttribute("ID")
        ProductAttribute.Value = "2"
        ProductElement.SetAttributeNode(ProductAttribute)
        ProductAttribute = doc.CreateAttribute("Name")
        ProductAttribute.Value = "Car"
        ProductElement.SetAttributeNode(ProductAttribute)

        ' Add the price node.
        PriceElement = doc.CreateElement("Price")
        PriceElement.InnerText = "43399.55"
        ProductElement.AppendChild(PriceElement)


        ' Add the third product.
        ProductElement = doc.CreateElement("Product")
        RootElement.AppendChild(ProductElement)

        ' Set and add the product attributes.
        ProductAttribute = doc.CreateAttribute("ID")
        ProductAttribute.Value = "3"
        ProductElement.SetAttributeNode(ProductAttribute)
        ProductAttribute = doc.CreateAttribute("Name")
        ProductAttribute.Value = "Fresh Fruit Basket"
        ProductElement.SetAttributeNode(ProductAttribute)

        ' Add the price node.
        PriceElement = doc.CreateElement("Price")
        PriceElement.InnerText = "49.99"
        ProductElement.AppendChild(PriceElement)

        ' Save the document.
        doc.Save("c:\SuperProProductList.xml")

        lblStatus.Text = "File c:\SuperProProductList.xml written successfully."
    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click

        ' Create the document.
        Dim doc As New XmlDataDocument()
        doc.Load("c:\SuperProProductList.xml")

        ' Loop through all the nodes, and create the ArrayList..
        Dim Element As XmlElement
        Dim Products As New ArrayList()
        For Each Element In doc.DocumentElement.ChildNodes
            Dim NewProduct As New Product()
            NewProduct.ID = Element.GetAttribute("ID")
            NewProduct.Name = Element.GetAttribute("Name")
            NewProduct.Price() = Element.ChildNodes(0).InnerText()
            Products.Add(NewProduct)
        Next

        ' Display the results.
        dgResults.DataSource = Products
        dgResults.DataBind()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

        Dim doc As New XmlDataDocument()
        doc.Load("c:\SuperProProductList.xml")
        Dim Results As XmlNodeList
        Dim Result As XmlNode

        ' Perform the search.
        Results = doc.GetElementsByTagName("Price")

        ' Display the results.
        lblStatus.Text = "<b>Found " & Results.Count.ToString() & " Matches "
        lblStatus.Text &= " for the Price tag: </b><br><br>"
        For Each Result In Results
            lblStatus.Text &= Result.FirstChild.Value & "<br>"
        Next
    End Sub


End Class
