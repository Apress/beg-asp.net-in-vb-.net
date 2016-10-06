Public Class FooterHost
    Inherits System.Web.UI.Page
    Protected WithEvents optShort As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optLong As System.Web.UI.WebControls.RadioButton
    Protected WithEvents cmdRefresh As System.Web.UI.WebControls.Button

    Protected WithEvents Footer1 As Footer

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

        If optLong.Checked = True Then
            Footer1.Format = Footer.FooterFormat.LongDate
        ElseIf optShort.Checked = True Then
            Footer1.Format = Footer.FooterFormat.ShortTime
        Else
            ' The default value in the Footer class will apply.
        End If

    End Sub

End Class
