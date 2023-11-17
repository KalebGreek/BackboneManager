Public Class TelComponentProp
    Inherits System.Windows.Forms.UserControl

    Dim CompCategoryListBS As New BindingSource
    Dim localidadBS As New BindingSource

    Dim SelectComponentSQL As String =
        "SELECT id, activo, marca, modelo, descripcion, idCategoria, 
        instalacion, calle, altura, barrio, referencia, idLocalidad
        FROM Componente"

    Public Sub Fill(idComponente As Integer)
        Me.Name = idComponente
        'Rellenar Categorias
        CompCategoryListBS.DataSource = DbMan.ReadDB("SELECT * FROM catComponente", My.Settings.currentcon)
        categoria.DataSource = CompCategoryListBS
        categoria.DisplayMember = "nombre"
        categoria.ValueMember = "id"
        'Rellenar Localidades
        CtrlMan.Fill.GetCities(localidad, localidadBS, 1)
        'Cargar Componente
        If Me.Name > 0 Then
            Dim dtab As DataTable = DbMan.ReadDB(SelectComponentSQL & " WHERE Componente.id=" & Me.Name, My.Settings.currentcon)
            CtrlMan.LoadControls(dtab(0), FlowLayoutPanel2)
        End If
    End Sub
    Public Sub Save()
        'Guardar datos usando idComp cargado
        If Me.Name > 0 Then
            Dim UpdateComponentSQL As String =
                "UPDATE componente SET activo=" & activo.Checked & ",
                marca='" & marca.Text & "', modelo='" & modelo.Text & "', descripcion='" & descripcion.Text & "',
                idCategoria=" & categoria.SelectedValue & ", instalacion='" & instalacion.Value & "',
                calle='" & calle.Text & "', altura=" & altura.Value & ", barrio='" & barrio.Text & "',
                referencia='" & referencia.Text & "', idLocalidad=" & localidad.SelectedValue & "
                WHERE Componente.id=" & Me.Name


            DbMan.EditDB(UpdateComponentSQL, My.Settings.currentcon)
        Else
            Dim InsertComponentSQL As String =
                "INSERT INTO componente(activo, marca, modelo, descripcion, idCategoria, instalacion, 
                calle, altura, barrio, referencia, idLocalidad)
                VALUES(" & activo.Checked & ", 
                '" & marca.Text & "', '" & modelo.Text & "', '" & descripcion.Text & "',    
                " & CompCategoryListBS.Current("id") & ", '" & instalacion.Value & "',
                '" & calle.Text & "', " & altura.Value & ", '" & barrio.Text & "',
                '" & referencia.Text & "', " & localidadBS.Current("id") & ")"

            DbMan.EditDB(InsertComponentSQL, My.Settings.currentcon)
            'Cargar nuevo id
            Dim dtab As DataTable = DbMan.ReadDB(SelectComponentSQL & " ORDER BY id DESC", My.Settings.currentcon)
            Me.Name = dtab(0)("id")
        End If
    End Sub
    Public Sub Delete()

    End Sub
End Class
