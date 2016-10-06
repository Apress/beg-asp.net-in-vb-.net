Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents txtShowAll As System.Web.UI.WebControls.Button
    Protected WithEvents cmdShow As System.Web.UI.WebControls.Button
    Protected WithEvents cmdShowPic As System.Web.UI.WebControls.Button
        Protected WithEvents lblResult As System.Web.UI.WebControls.Label

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

    Private ts As New net.terraservice.TerraService()

    Private Sub txtShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShowAll.Click

        ' Create the TerraService objects.
        Dim FactsArray() As net.terraservice.PlaceFacts
        Dim Facts As net.terraservice.PlaceFacts

        ' Retrieve the matching list.
        FactsArray = ts.GetPlaceList("Kingston", 100, False)

        ' Loop through all the results, and display them.
        For Each Facts In FactsArray
            ShowPlaceFacts(Facts)
        Next

    End Sub


    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click

        ' Create the Place object for Seattle.
        Dim SearchPlace As New net.terraservice.Place()
        SearchPlace.City = "Seattle"

        ' Create the PlaceFacts objects to retrieve our information.
        Dim Facts As New net.terraservice.PlaceFacts()

        ' Call the Web Service method.
        Facts = ts.GetPlaceFacts(SearchPlace)

        ' Display the results with the help of a subroutine.
        ShowPlaceFacts(Facts)

    End Sub


    Private Sub ShowPlaceFacts(ByVal Facts As net.terraservice.PlaceFacts)

        lblResult.Text &= "<b>Place: " & Facts.Place.City & "</b><br>"
        lblResult.Text &= Facts.Place.State & ", " & Facts.Place.Country
        lblResult.Text &= "<br> Lat: " & Facts.Center.Lat
        lblResult.Text &= "<br> Long: " & Facts.Center.Lon
        lblResult.Text &= "<br><br>"

    End Sub

    Private Sub cmdShowPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowPic.Click

        ' Define the search.
        Dim SearchPlace As New net.terraservice.Place()
        SearchPlace.City = "Seattle"

        ' Get the PlaceFacts for Seattle.
        Dim Facts As New net.terraservice.PlaceFacts()
        Facts = ts.GetPlaceFacts(SearchPlace)

        ' Retrieve information about the tile at the centre of Seattle.
        ' Two enumerations are used from the terraservice namespace (Scale and Theme).
        Dim TileData As net.terraservice.TileMeta
        TileData = ts.GetTileMetaFromLonLatPt(Facts.Center, net.terraservice.Theme.Photo, net.terraservice.Scale.Scale16m)

        ' Retrieve the image.
        Dim Image() As Byte
        Image = ts.GetTile(TileData.Id)

        ' Display the image.
        Response.BinaryWrite(Image)

    End Sub

End Class
