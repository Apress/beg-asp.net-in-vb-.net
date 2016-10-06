Imports System.ComponentModel

Public MustInherit Class Footer
    Inherits System.Web.UI.UserControl
    Protected WithEvents lblFooter As System.Web.UI.WebControls.Label

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

    Public Enum FooterFormat
        LongDate
        ShortTime
    End Enum

    Private _Format As FooterFormat = FooterFormat.LongDate

    <Browsable(True), Category("Misc")> _
    Public Property Format() As FooterFormat
        Get
            Return _Format
        End Get
        Set(ByVal Value As FooterFormat)
            _Format = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFooter.Text = "This page was served at "

        If _Format = FooterFormat.LongDate Then
            lblFooter.Text &= DateTime.Now.ToLongDateString()
        ElseIf _Format = FooterFormat.ShortTime Then
            lblFooter.Text &= DateTime.Now.ToShortTimeString()
        End If

    End Sub

End Class
