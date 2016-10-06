Imports System.Xml
Imports System.IO
Imports System.Xml.Schema

Public Class XmlValidation
    Inherits System.Web.UI.Page
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents cmdValidate As System.Web.UI.WebControls.Button
    Protected WithEvents optValid As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optInvalidData As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optInvalidTag As System.Web.UI.WebControls.RadioButton

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

    Private Sub cmdValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValidate.Click

        Dim FilePath As String = Request.ApplicationPath
        If optValid.Checked = True Then
            FilePath &= "\SuperProProductList.xml"
        ElseIf optInvalidData.Checked = True Then
            FilePath &= "\InvalidData.xml"
        ElseIf optInvalidTag.Checked = True Then
            FilePath &= "\InvalidTag.xml"
        End If

        Dim fs As FileStream
        Dim r As XmlTextReader
        Dim vr As XmlValidatingReader

        Try
            ' Open the XML file.
            fs = New FileStream(FilePath, FileMode.Open)
            r = New XmlTextReader(fs)

            ' Create the validating reader.
            vr = New XmlValidatingReader(r)
            vr.ValidationType = ValidationType.Schema

            ' Add the XSD file to the validator.
            Dim Schemas As New XmlSchemaCollection()
            Schemas.Add("SuperProProductList", _
              Request.ApplicationPath & "\SuperProProductList.xsd")
            vr.Schemas.Add(Schemas)

            ' Read through the document.
            Do While vr.Read()
                ' Process document here.
                ' If an error is found, an exception will be thrown.
            Loop

            lblStatus.Text = "Validation succeeded."
        Catch err As Exception
            lblStatus.Text = err.Message
        Finally
            If Not vr Is Nothing Then
                vr.Close()
            End If
        End Try

    End Sub
End Class
