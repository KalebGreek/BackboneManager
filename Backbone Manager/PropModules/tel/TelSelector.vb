Public Class TelSelector

    Dim FullComponentListSQL As String =
        "SELECT Red.Id, Red.idOrigen, Red.idComponente,
        CatComponente.nombre + ' ' + Componente.descripcion as Componente
        FROM CatComponente INNER JOIN ((Componente INNER JOIN Red ON Componente.Id = Red.idComponente)
        LEFT JOIN Componente AS CompOrigen ON Red.idOrigen = CompOrigen.Id) ON CatComponente.Id = Componente.idCategoria"

    Dim CompListBS, CategorySelectorBS As New BindingSource
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CategorySelectorBS.DataSource = DbMan.ReadDB("SELECT * FROM CatComponente", My.Settings.currentcon)
        CompCatSelect.DataSource = CategorySelectorBS
        CompCatSelect.ValueMember = "id"
        CompCatSelect.DisplayMember = "nombre"

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompCatSelect.SelectedIndexChanged
        CompList.DataSource = Nothing

        If CompCatSelect.SelectedIndex > -1 Then
            CompListBS.DataSource = DbMan.ReadDB(FullComponentListSQL & " WHERE CatComponente.id=" & CompCatSelect.ValueMember, My.Settings.currentcon)
            CompList.DataSource = CompListBS
            CompList.DisplayMember = "Componente"
            CompList.ValueMember = "idComponente"
        End If
    End Sub
End Class
