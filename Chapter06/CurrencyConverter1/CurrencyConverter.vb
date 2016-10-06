Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls


Public Class CurrencyConverter
    Inherits Page
    Protected WithEvents Result As HtmlGenericControl
    Protected WithEvents Convert As HtmlInputButton
    Protected WithEvents US As HtmlInputText

    Private Sub Convert_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles convert.ServerClick
        Dim Amount As Decimal = Val(US.Value)
        Result.InnerText = Amount & " US dollars = " & Amount * 1.12 & " Euros."
    End Sub

End Class