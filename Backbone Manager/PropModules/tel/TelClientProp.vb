Public Class TelClientProp
    Inherits System.Windows.Forms.UserControl

    Dim LocalidadBS As New BindingSource

    Dim SelectClientSQL As String =
        "SELECT id, razon, activo, calle, altura, referencia,
        barrio, idLocalidad, linea, alta
        FROM Abonado"

    Public Sub Fill(idAb As Integer)
        Dim dtab As New DataTable
        Dim sql As String = SelectClientSQL
        CtrlMan.Fill.GetCities(localidad, LocalidadBS, 1)

        If idAb > 0 Then
            sql &= " WHERE Abonado.id=" & idAb
        End If

        dtab = DbMan.ReadDB(sql, My.Settings.currentcon)

        If dtab Is Nothing = False Then
            CtrlMan.LoadControls(dtab(0), FlowLayoutPanel4)
        End If

        Me.Name = idAb
    End Sub

    Public Sub Save()
        If Me.Name > 0 Then
            DbMan.EditDB("UPDATE abonado SET razon='" & razon.Text & "', activo=" & activo.Checked & ",
                     calle='" & calle.Text & "', altura=" & altura.Value & ", referencia='" & referencia.Text & "',
                     barrio='" & barrio.Text & "', idLocalidad=" & localidadBS.Current("id") & ", 
                     linea=" & linea.Value & ", alta='" & alta.Value & "'
                     WHERE id=" & Me.Name, My.Settings.currentcon)
        Else
            DbMan.EditDB("INSERT INTO abonado(razon, activo, calle, altura, referencia, barrio, 
                     idLocalidad, linea, alta)
                     VALUES('" & razon.Text & "', " & activo.Checked & ", '" & calle.Text & "', " & altura.Value & ",
                     '" & referencia.Text & "', '" & barrio.Text & "', " & localidadBS.Current("id") & ", " &
                     linea.Value & ", '" & alta.Value & "')", My.Settings.currentcon)

            Dim dtab As DataTable = DbMan.ReadDB(SelectClientSQL & " ORDER BY id DESC", My.Settings.currentcon)
            Me.Name = dtab(0)("id")
        End If
    End Sub
End Class
