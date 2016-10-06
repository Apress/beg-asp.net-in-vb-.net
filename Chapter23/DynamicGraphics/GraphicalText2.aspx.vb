Public Class GraphicalText2
    Inherits System.Web.UI.Page

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

        ' Get the user name.
        Dim Name As String = Request.QueryString("Name")

        If Name = "" Then
            ' No name was supplied.
            ' Don't display anything.

        Else
            ' Create an in-memory bitmap where you will draw the image. 
            ' The Bitmap is 300 pixels wide and 50 pixels high.
            Dim Image As New Bitmap(300, 50)

            ' Get the graphics context for the bitmap.
            Dim g As Graphics = Graphics.FromImage(Image)

            ' Draw a solid yellow rectangle with a red border.
            g.FillRectangle(Brushes.LightYellow, 0, 0, 300, 50)
            g.DrawRectangle(Pens.Red, 0, 0, 299, 49)

            ' Draw some text based on the query string.
            Dim Font As New Font("Alba Super", 20, FontStyle.Regular)
            g.DrawString(Name, Font, Brushes.Blue, 10, 0)

            ' Render the entire bitmap to the HTML output stream.
            Image.Save(Response.OutputStream, _
              System.Drawing.Imaging.ImageFormat.Gif)

            ' Clean up.
            g.Dispose()
            Image.Dispose()
        End If
    End Sub

End Class
