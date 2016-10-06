Imports System.Data.OleDb
Imports System.Data

Public Class ConcurrencyHandler
    Inherits System.Web.UI.Page
    Protected WithEvents cmdTest As System.Web.UI.WebControls.Button
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

    ' Connection string used for all connections.
    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
     "Data Source=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

    Public Sub OnRowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        ' Check if any records were affected.
        ' If no records were affected, the statement did not execute as expected.
        If e.RecordsAffected() < 1 Then
            ' Find out the type of failed error.
            Select Case e.StatementType
                Case StatementType.Delete
                    lblResult.Text &= "<br>Not deleted: "
                Case StatementType.Insert
                    lblResult.Text &= "<br>Not inserted: "
                Case StatementType.Update
                    lblResult.Text &= "<br>Not updated: "
            End Select

            lblResult.Text &= "(" & e.Row("au_id") & " " & e.Row("au_lname")
            lblResult.Text &= ", " & e.Row("au_fname") & ")"

            ' Using the OledDbRowUpdatedEventArgs class, you can tell ADO.NET
            ' to ignore the problem and keep updating the other rows. 
            e.Status = UpdateStatus.SkipCurrentRow
        End If

    End Sub


    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click

        lblResult.Text = ""

        ' Define ADO.NET objects.
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)

        ' Create the CommandBuilder.
        Dim cb As New OleDbCommandBuilder(adapter)
        ' Retrieve an updated DataAdapter.
        adapter = cb.DataAdapter

        ' Connect the event handler.
        AddHandler adapter.RowUpdated, AddressOf OnRowUpdated

        ' Create two DataSets... perfect for conflicting data.
        Dim dsPubs1 As New DataSet(), dsPubs2 As New DataSet()

        Try
            con.Open()

            ' Fill both DataSets.
            adapter.Fill(dsPubs1, "Authors")
            adapter.Fill(dsPubs2, "Authors")

            ' "Flip" the contract field in the first row of dsPubs1.
            If dsPubs1.Tables(0).Rows(0).Item("contract") = True Then
                dsPubs1.Tables(0).Rows(0).Item("contract") = False
            Else
                dsPubs1.Tables(0).Rows(0).Item("contract") = True
            End If

            ' Update the database
            adapter.Update(dsPubs1, "Authors")

            ' Make a change in the second DataSet.
            dsPubs2.Tables(0).Rows(0).Item("au_fname") = "Bill"
            dsPubs2.Tables(0).Rows(0).Item("au_lname") = "Gates"

            ' Try to update this row. Even though these changes don't conflict,
            ' the update will fail because the row has been changed.
            adapter.Update(dsPubs2, "Authors")

        Catch err As Exception
            lblResult.Text &= "Error reading schema. "
            lblResult.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try



    End Sub


End Class
