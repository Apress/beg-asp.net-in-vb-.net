Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents cmdShow As System.Windows.Forms.Button
    Friend WithEvents lstPlaces As System.Windows.Forms.ListBox
        Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstPlaces = New System.Windows.Forms.ListBox()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstPlaces
        '
        Me.lstPlaces.Location = New System.Drawing.Point(24, 96)
        Me.lstPlaces.Name = "lstPlaces"
        Me.lstPlaces.Size = New System.Drawing.Size(316, 160)
        Me.lstPlaces.TabIndex = 1
        '
        'lblChoose
        '
        Me.lblChoose.Location = New System.Drawing.Point(24, 28)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(108, 12)
        Me.lblChoose.TabIndex = 3
        Me.lblChoose.Text = "Choose a location:"
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(148, 48)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(120, 28)
        Me.cmdShow.TabIndex = 0
        Me.cmdShow.Text = "Show All Matches"
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(148, 24)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(120, 20)
        Me.txtPlace.TabIndex = 2
        Me.txtPlace.Text = "Kingston"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(372, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblChoose, Me.txtPlace, Me.lstPlaces, Me.cmdShow})
        Me.Name = "Form1"
        Me.Text = "Terra Client (for Windows)"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ts As New net.terraservice.TerraService()

    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click

        ' Create the TerraService objects.
        Dim FactsArray() As Net.terraservice.PlaceFacts
        Dim Facts As Net.terraservice.PlaceFacts

        ' Retrieve the matching list.
        FactsArray = ts.GetPlaceList(txtPlace.Text, 100, False)

        ' Loop through all the results, and display them.
        For Each Facts In FactsArray
            ShowPlaceFacts(Facts)
        Next

    End Sub


    Private Sub ShowPlaceFacts(ByVal Facts As Net.terraservice.PlaceFacts)

        Dim NewItem As String
        NewItem = "Place: " & Facts.Place.City & ", "
        NewItem &= Facts.Place.State & ", " & Facts.Place.Country

        lstPlaces.Items.Add(NewItem)

    End Sub

End Class
