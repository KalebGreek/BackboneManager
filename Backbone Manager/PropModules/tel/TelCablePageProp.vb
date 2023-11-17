Public Class TelCablePageProp
    Inherits System.Windows.Forms.TabPage
    Dim CategoryListBS As New BindingSource

    Dim SelectCableSQL As String =
        "SELECT id, idCategoria, marca, modelo, 
        descripcion, instalacion, longitud, capacidad
        FROM Cable"

    Dim CategoryListSQL As String =
        "SELECT * FROM CatCable"

    'Rutinas
    Public Sub Fill(drow As DataRow, Optional nuevo As Boolean = False)
        FillCategories()
        Me.Dock = DockStyle.Fill
        Me.Margin = New System.Windows.Forms.Padding(0)

        If nuevo Then
            Me.Name = -1
            Me.Text = "[" & Me.Name & "] <NUEVO>"
        Else
            Me.Name = drow("idCable")
            CtrlMan.LoadControls(drow, FlowLayoutPanel1)
            Me.Text = "[" & Me.Name & "] " & categoria.DataSource.Current("nombre") & " " & descripcion.Text
        End If
    End Sub
    Private Sub FillCategories()
        categoria.BeginUpdate()
        CategoryListBS.DataSource = DbMan.ReadDB(CategoryListSQL, My.Settings.currentcon)
        categoria.DataSource = CategoryListBS
        categoria.DisplayMember = "nombre"
        categoria.ValueMember = "id"
        categoria.EndUpdate()
    End Sub

    Public Sub ManagePairList(reload As Boolean)
        Me.SuspendLayout()
        For Each c As Control In Me.Controls
            If TypeOf c Is TelConnectionPairContainer Then
                c.Dispose()
            End If
        Next
        If reload Then
            Dim TcPc As New TelConnectionPairContainer
            TcPc.Dock = DockStyle.Fill
            TcPc.Fill(Me.Name, capacidad.Value)
            Me.Controls.Add(TcPc)
            For Each c As Control In Me.Controls
                If TypeOf c Is TelConnectionPairContainer Then
                    c.BringToFront()
                End If
            Next
            capacidad.BackColor = Color.White
        End If
        Me.ResumeLayout()
    End Sub

    Public Sub Save(origen As Integer, componente As Integer, abonado As Integer)
        'Limpiar registro de cable y conexiones anteriores
        If Me.Name > 0 Then
            DbMan.EditDB("UPDATE cable SET idCategoria=" & categoria.SelectedValue & ", marca='" & marca.Text & "',
                     modelo='" & modelo.Text & "', descripcion='" & descripcion.Text & "',
                     instalacion='" & instalacion.Value & "', longitud=" & longitud.Value & ",
                     capacidad=" & capacidad.Value & "
                     WHERE id=" & Me.Name, My.Settings.currentcon)
        Else
            'El cable se borra y se agrega de nuevo
            DbMan.EditDB("INSERT INTO cable(idCategoria, marca, modelo, descripcion, instalacion, longitud, capacidad)
                    VALUES(" & CategoryListBS.Current("id") & ", '" & marca.Text & "', '" & modelo.Text & "', 
                    '" & descripcion.Text & "', '" & instalacion.Value & "', " & longitud.Value & ",
                    " & capacidad.Value & ")", My.Settings.currentcon)
        End If

        Dim dtab As DataTable = DbMan.ReadDB(SelectCableSQL & " ORDER BY id DESC", My.Settings.currentcon)
        Me.Name = dtab(0)("id")
        For Each c As Control In Me.Controls
            If TypeOf c Is TelConnectionPairContainer Then
                CType(c, TelConnectionPairContainer).Save(origen, componente, abonado, Me.Name)
            End If
        Next
    End Sub

    'Eventos
    Private Sub DeleteMe_Click(sender As Object, e As EventArgs) Handles DelCable.Click
        If Me.Name > 0 Then
            DbMan.EditDB("DELETE * FROM conexion WHERE idCable=" & Me.Name, My.Settings.currentcon)
            DbMan.EditDB("DELETE * FROM cable WHERE id=" & Me.Name, My.Settings.currentcon)
        End If
        Me.Dispose()
    End Sub
    Private Sub Capacidad_ValueChanged(sender As Object, e As EventArgs) Handles capacidad.ValueChanged
        capacidad.BackColor = Color.FromArgb(255, 255, 128)
    End Sub
    Private Sub Capacidad_KeyUp(sender As Object, e As KeyEventArgs) Handles capacidad.KeyUp
        If e.KeyValue = Keys.Enter Then
            ManagePairList(True)
        End If
    End Sub
    Private Sub ChangeCap_Click(sender As Object, e As EventArgs) Handles ChangeCap.Click
        ManagePairList(True)
    End Sub
End Class
