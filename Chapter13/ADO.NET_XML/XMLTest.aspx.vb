Imports System.Data.OleDb
Public Class XMLTest
    Inherits System.Web.UI.Page
    Protected WithEvents cmdShowXML As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtDatabase As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTable As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents optSQL As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optWindows As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Results As System.Web.UI.HtmlControls.HtmlGenericControl

#End Region

    

    Private Sub cmdShowXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowXML.Click

        ' Define the connection string.
        Dim strConnection As String = "Provider=SQLOLEDB.1;" & _
         "DataSource=localhost;Initial Catalog=" & txtDatabase.Text & ";"
        If optWindows.Checked = True Then
            strConnection &= "Integrated Security=SSPI;"
        Else
            strConnection &= "User ID=sa"
        End If

        ' Define the selection string.
        Dim strCommand As String = "SELECT * FROM " & txtTable.Text

        ' Define the ADO.NET objects.
        Dim con As New OleDbConnection(strConnection)
        Dim adapter As New OleDbDataAdapter(strCommand, con)
        Dim ds As New DataSet()

        ' Try to open database and read the information into the DataSet.
        Try
            con.Open()
            adapter.Fill(ds)
            ' Display the information in the DataSet as XML.
            Results.InnerHtml = ds.GetXml()
        Catch err As Exception
            Results.InnerHtml = "Error reading the database. "
            Results.InnerHtml &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
