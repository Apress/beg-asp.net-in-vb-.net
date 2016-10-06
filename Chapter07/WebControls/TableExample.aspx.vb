Public Class TableExample
    Inherits System.Web.UI.Page
    Protected WithEvents txtRows As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCols As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbl As System.Web.UI.WebControls.Table
    Protected WithEvents chkBorder As System.Web.UI.WebControls.CheckBox
    Protected WithEvents cmdCreate As System.Web.UI.WebControls.Button

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

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click

        ' Remove all the current rows and cells.
        ' This would not be necessary if you set EnableViewState = False.
        tbl.Controls.Clear()

        Dim i, j As Integer
        For i = 0 To Val(txtRows.Text)

            ' Create a new TableRow object.
            Dim rowNew As New TableRow()

            ' Put the TableRow in the Table.
            tbl.Controls.Add(rowNew)

            For j = 0 To Val(txtCols.Text)

                ' Create a new TableCell object.
                Dim cellNew As New TableCell()
                If chkBorder.Checked = True Then
                    cellNew.BorderStyle = BorderStyle.Inset
                    cellNew.BorderWidth = Unit.Pixel(1)
                End If


                cellNew.Text = "Example Cell (" & i & "," & j & ")"
                ' Put the TableCell in the TableRow.
                rowNew.Controls.Add(cellNew)

            Next

        Next
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Configure the table's appearance.
        ' This could also be performed in the .aspx file,
        ' or in the cmdCreate_Click event handler.
        tbl.BorderStyle = BorderStyle.Inset
        tbl.BorderWidth = Unit.Pixel(1)
    End Sub
End Class
