Public Class GreetingCardMaker2
    Inherits System.Web.UI.Page
    Protected WithEvents lstBackColor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lstForeColor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lstFontName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtFontSize As System.Web.UI.WebControls.TextBox
    Protected WithEvents chkPicture As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtGreeting As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents lblGreeting As System.Web.UI.WebControls.Label
    Protected WithEvents lstBorder As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents imgDefault As System.Web.UI.WebControls.Image
    Protected WithEvents pnlCard As System.Web.UI.WebControls.Panel

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

            ' Get the list of colors
            Dim ColorArray As String() = System.Enum.GetNames(GetType(System.Drawing.KnownColor))
            lstBackColor.DataSource = ColorArray
            lstBackColor.DataBind()

            lstForeColor.DataSource = ColorArray
            lstForeColor.DataBind()
            lstForeColor.SelectedIndex = 34
            lstBackColor.SelectedIndex = 163

            ' Get the list of available fonts, and add them to the font list.
            Dim Family As FontFamily
            Dim Fonts As New System.Drawing.Text.InstalledFontCollection()
            For Each Family In Fonts.Families
                lstFontName.Items.Add(Family.Name)
            Next

            ' Set border style options.
            Dim BorderStyleArray As String() = System.Enum.GetNames(GetType(BorderStyle))
            lstBorder.DataSource = BorderStyleArray
            lstBorder.DataBind()

            ' Select the first border option.
            lstBorder.SelectedIndex = 0

            ' Set the picture.
            imgDefault.ImageUrl = "defaultpic.png"

        End If

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        ' Update the color.
        pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text)
        lblGreeting.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text)

        ' Update the font.
        lblGreeting.Font.Name = lstFontName.SelectedItem.Text
        If Val(txtFontSize.Text) > 0 Then
            lblGreeting.Font.Size = FontUnit.Point(Val(txtFontSize.Text))
        End If

        ' Update the border style.
        pnlCard.BorderStyle = System.ComponentModel.TypeDescriptor.GetConverter(GetType(BorderStyle)).ConvertFromString(lstBorder.SelectedItem.Text)

        ' Update the picture.
        If chkPicture.Checked = True Then
            imgDefault.Visible = True
        Else
            imgDefault.Visible = False
        End If

        ' Set the text.
        lblGreeting.Text = txtGreeting.Text
    End Sub

    Private Sub ControlChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles lstBackColor.SelectedIndexChanged, chkPicture.CheckedChanged, _
             lstBackColor.SelectedIndexChanged, lstBorder.SelectedIndexChanged, _
             lstFontName.SelectedIndexChanged, lstForeColor.SelectedIndexChanged, _
             txtFontSize.TextChanged

        ' Call the button event handler to refresh the window.
        cmdUpdate_Click(Nothing, Nothing)

    End Sub
End Class


