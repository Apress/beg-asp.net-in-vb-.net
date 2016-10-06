Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls

Public Class HtmlEncodeTest
    Inherits Page
    Protected ctrl1 as HtmlGenericControl
    Protected ctrl2 as HtmlGenericControl

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ctrl1.InnerHtml = "To <b>bold</b> text use the <b> tag."
        ctrl2.InnerHtml = "To <b>bold</b> text use the " & Server.HtmlEncode("<b>") & " tag."
    End Sub

End Class