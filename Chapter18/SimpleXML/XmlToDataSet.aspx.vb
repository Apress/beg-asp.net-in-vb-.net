Imports System.Xml


Public Class XmlDataSet
    Inherits System.Web.UI.Page
    Protected WithEvents dgResults As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents cmdDisplay As System.Web.UI.WebControls.Button

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        Dim DataDoc As New XmlDataDocument()
        DataDoc.DataSet.ReadXmlSchema(Request.ApplicationPath & "\SuperProProductList.xsd")
        DataDoc.Load(Request.ApplicationPath & "\SuperProProductList.xml")

        dgResults.DataSource = DataDoc.DataSet
        dgResults.DataBind()
    End Sub
End Class
