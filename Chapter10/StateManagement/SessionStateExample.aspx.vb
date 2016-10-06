Public Class SessionStateExample
    Inherits System.Web.UI.Page
    Protected WithEvents cmdMoreInfo As System.Web.UI.WebControls.Button
    Protected WithEvents lblRecord As System.Web.UI.WebControls.Label
    Protected WithEvents lblSession As System.Web.UI.WebControls.Label
    Protected WithEvents lstItems As System.Web.UI.WebControls.ListBox

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

    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If Me.IsPostBack = False Then
            ' Create Furniture objects.
            Dim Piece1 As New Furniture("Econo Sofa", "Acme Inc.", 74.99)
            Dim Piece2 As New Furniture("Pioneer Table", "Heritage Unit", 866.75)
            Dim Piece3 As New Furniture("Retro Cabinet", "Sixties Ltd.", 300.11)

            ' Add objects to session state.
            Session("Furniture1") = Piece1
            Session("Furniture2") = Piece2
            Session("Furniture3") = Piece3

            ' Add rows to list control.
            lstItems.Items.Clear()
            lstItems.Items.Add(Piece1.Name)
            lstItems.Items.Add(Piece2.Name)
            lstItems.Items.Add(Piece3.Name)
        End If

        ' Display some basic information about the session.
        ' This is useful for testing configuration settings.
        lblSession.Text = "Session ID: " & Session.SessionID
        lblSession.Text &= "<br>Number of Objects: " & Session.Count.ToString()
        lblSession.Text &= "<br>Mode: " & Session.Mode.ToString()
        lblSession.Text &= "<br>Is Cookieless: "
        lblSession.Text &= Session.IsCookieless.ToString()
        lblSession.Text &= "<br>Is New: " & Session.IsNewSession.ToString()
        lblSession.Text &= "<br>Timeout (minutes): " & Session.Timeout.ToString()

    End Sub

    Private Sub cmdMoreInfo_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdMoreInfo.Click

        If lstItems.SelectedIndex = -1 Then
            lblRecord.Text = "No item selected."
        Else
            ' Construct the right key name based on the index.
            Dim Key As String
            Key = "Furniture" & (lstItems.SelectedIndex + 1).ToString()

            ' Retrieve the object and display its information.
            Dim Piece As Furniture = CType(Session(Key), Furniture)
            lblRecord.Text = "Name: " & Piece.Name & "<br>"
            lblRecord.Text &= "Manufacturer: " & Piece.Description & "<br>"
            lblRecord.Text &= "Cost: $" & Piece.Cost.ToString()
        End If

    End Sub

End Class

Public Class Furniture

    Public Name As String
    Public Description As String
    Public Cost As Decimal

    Public Sub New(ByVal Name As String, ByVal Description As String, ByVal Cost As Decimal)
        Me.Name = Name
        Me.Description = Description
        Me.Cost = Cost
    End Sub

End Class
