Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Configuration

 Public Class ShowSettings
  Inherits Page
    Protected lblTest As Label

    Private Sub Page_Load()
	lblTest.Text &= "This app will connect with the connection string:<br>"
	lblTest.Text &= "<b>" & ConfigurationSettings.AppSettings("ConnectionString") & "</b><br><br>"
	lblTest.Text &= "And will execute the SQL Statement:<br>"
	lblTest.Text &= "<b>" & ConfigurationSettings.AppSettings("SelectSales") & "</b>"
    End Sub

End Class
