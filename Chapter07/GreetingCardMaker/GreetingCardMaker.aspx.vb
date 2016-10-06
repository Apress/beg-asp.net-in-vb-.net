Public Class GreetingCardMaker
    Inherits System.Web.UI.Page
    Protected WithEvents lstBackColor As System.Web.UI.WebControls.DropDownList
        Protected WithEvents lstFontName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtFontSize As System.Web.UI.WebControls.TextBox
        Protected WithEvents chkPicture As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtGreeting As System.Web.UI.WebControls.TextBox
    Protected WithEvents pnlCard As System.Web.UI.WebControls.Panel
    Protected WithEvents lblGreeting As System.Web.UI.WebControls.Label
    Protected WithEvents lstBorder As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents imgDefault As System.Web.UI.WebControls.Image
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button

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
        If Me.IsPostBack = False Then

            ' Set color options.
            lstBackColor.Items.Add("White")
            lstBackColor.Items.Add("Red")
            lstBackColor.Items.Add("Green")
            lstBackColor.Items.Add("Blue")
            lstBackColor.Items.Add("Yellow")

            ' Set font options.
            lstFontName.Items.Add("Times New Roman")
            lstFontName.Items.Add("Arial")
            lstFontName.Items.Add("Verdana")
            lstFontName.Items.Add("Tahoma")

            ' Set border style options.
            lstBorder.Items.Add(New ListItem(BorderStyle.None.ToString, BorderStyle.None))
            lstBorder.Items.Add(New ListItem(BorderStyle.Double.ToString, BorderStyle.Double))
            lstBorder.Items.Add(New ListItem(BorderStyle.Solid.ToString, BorderStyle.Solid))

            ' Select the first border option.
            lstBorder.SelectedIndex = 0

            ' Set the picture.
            imgDefault.ImageUrl = "defaultpic.png"
        End If
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        ' Update the color.
        pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text)

        ' Update the font.
        lblGreeting.Font.Name = lstFontName.SelectedItem.Text
        If Val(txtFontSize.Text) > 0 Then
            lblGreeting.Font.Size = FontUnit.Point(Val(txtFontSize.Text))
        End If

        ' Update the border style.
        pnlCard.BorderStyle = Val(lstBorder.SelectedItem.Value)

        ' Update the picture.
        If chkPicture.Checked = True Then
            imgDefault.Visible = True
        Else
            imgDefault.Visible = False
        End If

        ' Set the text.
        lblGreeting.Text = txtGreeting.Text

    End Sub
End Class
