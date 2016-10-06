Imports System.Web.Mail
Public Class IssueReporter
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents chkPriority As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSender As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtComment As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdSend As System.Web.UI.WebControls.Button
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

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click

        ' Create the message.
        Dim Msg As New MailMessage()
        Msg.Subject = "Issue Report"
        Msg.Body = "Submitted By: " & txtName.Text & Chr(10)
        Msg.Body &= txtComment.Text
        Msg.From = txtSender.Text

        ' Put your email address here!!
        Msg.To = "m@prosetech.com"

        If chkPriority.Checked Then Msg.Priority = MailPriority.High

        ' Send the message.
        SmtpMail.Send(Msg)

        lblResult.Text = "Message sent to SMTP service."
    End Sub
End Class
