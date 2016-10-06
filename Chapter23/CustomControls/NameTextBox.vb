Imports System.ComponentModel
Imports System.Web.UI

Namespace AdvancedControls

    Public Class NameTextBox
        Inherits System.Web.UI.WebControls.TextBox

        Private _FirstName As String
        Private _LastName As String

        Public Function GetFirstName() As String
            UpdateNames()
            Return _FirstName
        End Function

        Public Function GetLastName() As String
            UpdateNames()
            Return _LastName
        End Function

        Private Sub UpdateNames()
            Dim CommaPos As Integer = Text.IndexOf(",")
            Dim SpacePos As Integer = Text.IndexOf(" ")

            Dim NameArray() As String

            If CommaPos <> -1 Then
                NameArray = Text.Split(",")
                _FirstName = NameArray(1)
                _LastName = NameArray(0)
            ElseIf SpacePos <> -1 Then
                NameArray = Text.Split(" ")
                _FirstName = NameArray(0)
                _LastName = NameArray(1)
            Else
                ' The text has no comma or space.
                ' It cannot be converted to a name.
                Throw New InvalidOperationException()
            End If
        End Sub

    End Class

End Namespace