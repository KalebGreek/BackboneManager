Public Class TelCompOriginProp
    Dim idDestino As Integer

    Dim UpdateCompOrigenSQL As String =
        "UPDATE componente SET idOrigen="

    Dim UpdateAbOrigenSQL As String =
        "UPDATE "


    'Rutinas
    Public Sub Fill(idOri As Integer, descOrigen As String, abonado As Boolean, id As Integer, nombre As String)
        'Cargar componente de origen
        origen.Text = descOrigen
        Me.Name = idOri

        destino.Text = nombre
        idDestino = id

        ab.Checked = abonado
    End Sub

    Public Sub Save()
        'Componente
        If Me.Name > 0 Then

        End If
    End Sub

    'Eventos
    Private Sub origen_DoubleClick(sender As Object, e As EventArgs) Handles origen.DoubleClick
        'mostrar lista
    End Sub

End Class
