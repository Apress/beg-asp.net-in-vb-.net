Imports System.Data.OleDb
Imports System.Xml

Public Class DataSetToXml
    Inherits System.Web.UI.Page
    Protected WithEvents XmlControl As System.Web.UI.WebControls.Xml

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

        Dim ConnectionString As String = "Provider=SQLOLEDB.1;" & _
          "Data Source=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

        Dim SQL As String = "SELECT * FROM authors WHERE city='Oakland'"

        ' Create ADO.NET objects.
        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(SQL, con)
        Dim adapter As New OleDbDataAdapter(cmd)

        Dim ds As New DataSet("AuthorsDataSet")

        ' Execute the command.
        con.Open()
        adapter.Fill(ds, "AuthorsTable")
        con.Close()

        ' Create the XMLDataDocument that wraps this DataSet.
        Dim DataDoc As New XmlDataDocument(ds)

        XmlControl.Document = DataDoc
        XmlControl.TransformSource = "authors.xslt"

    End Sub

End Class
