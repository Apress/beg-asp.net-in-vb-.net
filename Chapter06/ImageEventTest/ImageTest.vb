Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls


Public Class ImageTest
    Inherits Page
    Protected Result As HtmlGenericControl
    Protected WithEvents ImgButton As HtmlInputImage


    Private Sub ImgButton_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles ImgButton.ServerClick

         Result.InnerText = "You clicked at (" & e.X.ToString() & _
                           ", " & e.Y.ToString() & "). "
         If e.Y < 100 And e.Y > 20 And e.X > 20 and e.X < 275 Then
             Result.InnerText &= "You clicked on the button surface."
         Else
             Result.InnerText &= "You clicked the button border."
         End If
    End Sub

End Class