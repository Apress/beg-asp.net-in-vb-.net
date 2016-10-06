Imports System.Data
Imports System.Data.OleDb
Public Class AuthorManager
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents lstAuthor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents cmdDelete As System.Web.UI.WebControls.Button
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents cmdNew As System.Web.UI.WebControls.Button
    Protected WithEvents cmdInsert As System.Web.UI.WebControls.Button
    Protected WithEvents pnlSelect As System.Web.UI.WebControls.Panel
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtFirstName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtLastName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtPhone As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents txtCity As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents txtState As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents txtZip As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents chkContract As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel

#End Region

    ' Connection string used for all connections.
    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
     "Data Source=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack = False Then
            FillAuthorList()
        End If

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        ' Define ADO.NET objects.
        Dim strUpdate As String
        strUpdate = "UPDATE Authors SET "
        strUpdate &= "au_id='" & txtID.Text & "', "
        strUpdate &= "au_fname='" & txtFirstName.Text & "', "
        strUpdate &= "au_lname='" & txtLastName.Text & "', "
        strUpdate &= "phone='" & txtPhone.Text & "', "
        strUpdate &= "address='" & txtAddress.Text & "', "
        strUpdate &= "city='" & txtCity.Text & "', "
        strUpdate &= "state='" & txtState.Text & "', "
        strUpdate &= "zip='" & txtZip.Text & "', "
        strUpdate &= "contract='" & Int(chkContract.Checked) & "' "
        strUpdate &= "WHERE au_id='" & lstAuthor.SelectedItem.Value & "'"

        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strUpdate, con)

        ' Try to open database and execute the update.
        Try
            con.Open()
            Dim intUpdated As Integer
            intUpdated = cmd.ExecuteNonQuery
            lblStatus.Text = intUpdated.ToString & " records updated."
        Catch err As Exception
            lblStatus.Text = "Error updating author. "
            lblStatus.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

    End Sub

    Private Sub lstAuthor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAuthor.SelectedIndexChanged

        ' Define ADO.NET objects.
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors "
        strSelect &= "WHERE au_id='" & lstAuthor.SelectedItem.Value & "'"

        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim reader As OleDbDataReader

        ' Try to open database and read information.
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            txtID.Text = reader("au_id")
            txtFirstName.Text = reader("au_fname")
            txtLastName.Text = reader("au_lname")
            txtPhone.Text = reader("phone")
            txtAddress.Text = reader("address")
            txtCity.Text = reader("city")
            txtState.Text = reader("state")
            txtZip.Text = reader("zip")
            chkContract.Checked = CType(reader("contract"), Boolean)
            reader.Close()
            lblStatus.Text = ""
        Catch err As Exception
            lblStatus.Text = "Error getting author. "
            lblStatus.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try


    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        ' Define ADO.NET objects.
        Dim strDelete As String
        strDelete = "DELETE FROM Authors "
        strDelete &= "WHERE au_id='" & lstAuthor.SelectedItem.Value & "'"

        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strDelete, con)

        ' Try to open database and delete the record.
        Dim intDeleted As Integer
        Try
            con.Open()
            intDeleted = cmd.ExecuteNonQuery()
        Catch err As Exception
            lblStatus.Text = "Error deleting author. "
            lblStatus.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

        ' If the delete succeeded, refresh the author list.
        If intDeleted > 0 Then
            FillAuthorList()
        End If

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        txtID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        chkContract.Checked = False

        lblStatus.Text = "Click Insert New to add the completed record."

    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click

        ' Perform user-defined checks.
        ' Alternatively, you could use RequiredFieldValidator controls.
        If txtID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            lblStatus.Text = "Records require an ID, first name, and last name."
            Exit Sub
        End If

        ' Define ADO.NET objects.
        Dim strInsert As String
        strInsert = "INSERT INTO Authors ("
        strInsert &= "au_id, au_fname, au_lname, "
        strInsert &= "phone, address, city, state, zip, contract) "
        strInsert &= "VALUES ('"
        strInsert &= txtID.Text & "', '"
        strInsert &= txtFirstName.Text & "', '"
        strInsert &= txtLastName.Text & "', '"
        strInsert &= txtPhone.Text & "', '"
        strInsert &= txtAddress.Text & "', '"
        strInsert &= txtCity.Text & "', '"
        strInsert &= txtState.Text & "', '"
        strInsert &= txtZip.Text & "', '"
        strInsert &= Int(chkContract.Checked) & "')"

        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strInsert, con)

        ' Try to open database and execute the update.
        Dim intAdded As Integer
        Try
            con.Open()
            intAdded = cmd.ExecuteNonQuery
            lblStatus.Text = intAdded.ToString & " records inserted."
        Catch err As Exception
            lblStatus.Text = "Error inserting record. "
            lblStatus.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

        ' If the insert succeeded, refresh the author list.
        If intAdded > 0 Then
            FillAuthorList()
        End If

    End Sub

    Private Sub FillAuthorList()

        lstAuthor.Items.Clear()

        ' Define ADO.NET objects.
        Dim strSelect As String
        strSelect = "SELECT au_lname, au_fname, au_id FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim reader As OleDbDataReader

        ' Try to open database and read information.
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Dim NewItem As New ListItem()
                NewItem.Text = reader("au_lname") & ", " & _
                 reader("au_fname")
                NewItem.Value = reader("au_id")
                lstAuthor.Items.Add(NewItem)
            Loop
            reader.Close()
        Catch err As Exception
            lblStatus.Text = "Error reading list of names. "
            lblStatus.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

        ' Listboxes always require a selected item.
        ' For that reason, me must load the author information
        ' for the currently selected record.
        lstAuthor_SelectedIndexChanged(Nothing, Nothing)

    End Sub

End Class
