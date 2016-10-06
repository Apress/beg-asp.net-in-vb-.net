Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI
Imports system.Web.UI.WebControls
Imports System.Web.UI.HtmlControls


Public Class CurrencyConverter
  Inherits Page
    Protected Result As HtmlGenericControl
    Protected WithEvents Convert As HtmlInputButton
    Protected US As HtmlInputText
    Protected Currency As HtmlSelect
    Protected Graph As HtmlImage
    Protected WithEvents ShowGraph As HtmlInputButton

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack = False
            Currency.Items.Add(New ListItem("Euro", "1.12"))
            Currency.Items.Add(New ListItem("Japanese Yen", "122.33"))
            Currency.Items.Add(New ListItem("Canadian Dollar", "1.58"))
        End If
        Graph.Visible = False


    End Sub

    Private Sub Convert_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles convert.ServerClick


        Dim Amount As Decimal = Val(US.Value)

        If Amount <= 0 Then
            Result.Style("color")="Red"
            Result.InnerText = "Specify a positive number"        
        Else
            Result.Style("color")="Black"

            ' Retrieve the select ListItem object by its index number.
            ' Each ListItem object provides a Text and Value property.
            Dim Item As ListItem
            Item = Currency.Items(Currency.SelectedIndex)

            Dim ConvertedAmount As Decimal = Amount * Val(Item.Value)

            Result.InnerText = Amount & " US dollars = " & ConvertedAmount & " " & Item.Text
        End If

    End Sub


    Private Sub ShowGraph_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowGraph.ServerClick

        Graph.Src = "Pic" & Currency.SelectedIndex & ".png"
        Graph.Alt = "Currency Graph"
        Graph.Visible = True

    End Sub


End Class