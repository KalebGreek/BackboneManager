Module db
    'Muestra ultimo comando SQL ejecutado
    Public last_sql As String = ""

    'Conexiones de base de datos
    Public olecon As New OleDb.OleDbConnection

    '###### READ: Rutinas de lectura #####################################################################
    '###### Reads datatable
    Function read(ByVal sql As String,
                  Optional OleDBProcedure As OleDb.OleDbCommand = Nothing)
        Dim dtab As New DataTable

        'Crear adaptador de datos
        Dim dada As New OleDb.OleDbDataAdapter

        If sql = "" Then
            OleDBProcedure.CommandType = CommandType.StoredProcedure
        Else
            OleDBProcedure = New OleDb.OleDbCommand
            OleDBProcedure.CommandType = CommandType.Text
            OleDBProcedure.CommandText = sql
        End If
        dada.SelectCommand = OleDBProcedure

        If dada.SelectCommand Is Nothing = False Then
            'Si la conexión estaba abierta, cerrarla y mostrar mensaje
            If olecon.State = ConnectionState.Open Then
                olecon.Close()
                MsgBox("Se cerrará la conexión actual." & Chr(13) & Chr(13) & "Detalles: " & last_sql)
            End If

            If My.Settings.NetworkName = "TELEFONIA" Then
                olecon.ConnectionString = My.Settings.telcon
            Else
                olecon.ConnectionString = My.Settings.tvcon
            End If

            OleDBProcedure.Connection = olecon
            'Abrir conexion
            Try
                olecon.Open()
            Catch ex As System.Data.OleDb.OleDbException
                MsgBox("La ruta de acceso a la base de datos es incorrecta.", MsgBoxStyle.Critical)

            End Try
            'Comandos
            Try
                dada.Fill(dtab)
            Catch ex As System.Data.OleDb.OleDbException
                MsgBox("No se encuentra la tabla indicada." & Chr(13) & "Detalles:" & ex.Message.ToString, MsgBoxStyle.Exclamation)
                Return Nothing
            End Try
            olecon.Close()
            dada.Dispose()
            last_sql = sql
            Return dtab
        Else
            MsgBox("Datos insuficientes para realizar la consulta.", MsgBoxStyle.Exclamation)
            Return Nothing
        End If

    End Function

    Public Class Fill
        Overloads Shared Sub AutoComplete(table As String, column As String, ByRef target As TextBox)
            Dim dtab As DataTable = db.read("SELECT DISTINCT " & column & " FROM " & table)
            target.AutoCompleteMode = AutoCompleteMode.Suggest
            target.AutoCompleteSource = AutoCompleteSource.CustomSource
            target.AutoCompleteCustomSource.Clear()
            For Each r As DataRow In dtab.Rows
                target.AutoCompleteCustomSource.Add(r(column))
            Next
        End Sub
        Shared Sub Categories()

        End Sub
        Shared Sub Cities(ByRef CitiesList As ComboBox, ByRef bs As BindingSource)
            CitiesList.BeginUpdate()
            bs.DataSource = db.read("SELECT * FROM Localidad")
            CitiesList.DataSource = bs
            CitiesList.DisplayMember = "nombre"
            CitiesList.ValueMember = "id"
            CitiesList.SelectedText = "VILLA DE LAS ROSAS"
            CitiesList.EndUpdate()
        End Sub
    End Class

    '###### Mostrar resultados en distintos formatos

    '###### END READ ############################################################################################
    '###### SAVE: Rutinas para grabar registros #################################################################
    Function edit(ByVal sql As String, Optional OleDBProcedure As OleDb.OleDbCommand = Nothing) As String
        'Para conectarse a la bd en modo de inserción
        'Se necesita convertir el string a un objeto ConnectionString
        'antes de aplicarlo al OleDbCommand "Comm"
        If OleDBProcedure Is Nothing And sql.Contains("INSERT") Or sql.Contains("UPDATE") Or sql.Contains("DELETE") Then
            Dim SQLCommand As New OleDb.OleDbCommand
            SQLCommand.CommandText = sql
            OleDBProcedure = SQLCommand
        End If
        If OleDBProcedure Is Nothing = False Then

            If My.Settings.NetworkName = "TELEFONIA" Then
                olecon.ConnectionString = My.Settings.telcon
            Else
                olecon.ConnectionString = My.Settings.tvcon
            End If

            OleDBProcedure.Connection = olecon
            'Abrir la conexión y ejecutar
            olecon.Open()
            OleDBProcedure.ExecuteNonQuery()
            olecon.Close()
            sql = ""
            Return Nothing
        Else
            Return "Datos insuficientes para realizar la operación."
        End If

    End Function
    '###### END SAVE ############################################################################################   

    Public Class Data
        Shared Function FormatColumns(ByVal visor As DataGridView) As DataGridView
            With visor.Columns
                If .Contains("codigo") Then
                    visor.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
                If .Contains("id") Then
                    visor.Columns("id").Width = 0
                End If

                'OPRIVADAS
                If .Contains("user_id") Then
                    visor.Columns("user_id").Width = 0
                End If
                If .Contains("opr_id") Then
                    visor.Columns("opr_id").Width = 0
                End If
                If .Contains("catastro_id") Then
                    visor.Columns("catastro_id").Width = 0
                End If
                If .Contains("expediente_id") Then
                    visor.Columns("expediente_id").Width = 0
                End If
                If .Contains("responsable") Then
                    visor.Columns("responsable").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If


                'PERSONAS
                If .Contains("per_id") Then
                    visor.Columns("per_id").Width = 0
                End If
                If .Contains("persona_id") Then
                    visor.Columns("persona_id").Width = 0
                End If
                If .Contains("prof_id") Then
                    visor.Columns("prof_id").Width = 0
                End If
                If .Contains("doc_id") Then
                    visor.Columns("doc_id").Width = 0
                End If
                If .Contains("cuil") Then
                    visor.Columns("cuil").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("razon") Then
                    visor.Columns("razon").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("calle") Then
                    visor.Columns("calle").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("altura") Then
                    visor.Columns("altura").Width = 40
                End If
                If .Contains("piso") Then
                    visor.Columns("piso").Width = 30
                End If
                If .Contains("dpto") Then
                    visor.Columns("dpto").Width = 30
                End If
                If .Contains("localidad") Then
                    visor.Columns("localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("localidad_id") Then
                    visor.Columns("localidad_id").Width = 0
                End If
                If .Contains("email") Then
                    visor.Columns("email").Width = 50
                End If
                If .Contains("telefono") Then
                    visor.Columns("telefono").Width = 50
                End If
                If .Contains("difunto") Then
                    visor.Columns("difunto").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
                If .Contains("fisica") Then
                    visor.Columns("fisica").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If

                'DOCS
                If .Contains("descripcion") Then
                    visor.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("fecha") Then
                    visor.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("ruta") Then
                    visor.Columns("ruta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If

                'ACTAS
                If .Contains("acta") Then
                    visor.Columns("acta").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("libro") Then
                    visor.Columns("libro").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("nota") Then
                    visor.Columns("nota").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If

                'INMUEBLES
                If .Contains("titular_id") Then
                    visor.Columns("titular_id").Width = 0
                End If
                If .Contains("zona") Then
                    visor.Columns("zona").Width = 20
                End If
                If .Contains("circ") Then
                    visor.Columns("circ").Width = 20
                End If
                If .Contains("secc") Then
                    visor.Columns("secc").Width = 20
                End If
                If .Contains("manz") Then
                    visor.Columns("manz").Width = 20
                End If
                If .Contains("parc") Then
                    visor.Columns("parc").Width = 20
                End If
                If .Contains("lote") Then
                    visor.Columns("lote").Width = 20
                End If
                If .Contains("archivado") Then
                    visor.Columns("archivado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If

                'FRENTES
                If .Contains("altura") Then
                    visor.Columns("altura").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
                If .Contains("metros") Then
                    visor.Columns("metros").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If

                'ORDENANZAS
                If .Contains("concepto") Then
                    visor.Columns("concepto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                If .Contains("ruta_copia") Then
                    visor.Columns("ruta_copia").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If

                'MOVIMIS
                If .Contains("detalle") Then
                    visor.Columns("detalle").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
            End With
            Return visor
        End Function
        Shared Function ToDataGridView(ByVal visor As DataGridView, ByVal bs As BindingSource, ByVal dtab As DataTable) As DataGridView
            'Esta rutina va después de que la consulta genera la instrucción SQL
            'y lee la datatable; es igual para todos los servicios.
            bs.DataSource = dtab
            visor.DataSource = bs
            visor.Update()
            'Con VB .Net sobre la tabla de consulta
            'Dar formato
            visor = Data.FormatColumns(visor)
            Return visor
        End Function
        'Una funcion para cargarlos a todos, una funcion para bindearlos y atraerlos a Shadows
        Overloads Shared Function ToControls(drow As DataRow, ByVal target As Object) As Object
            'Carga los registros de cada columna en los controles con el nombre de la columna correspondiente
            For Each c As Control In target.Controls
                If TypeOf c Is TextBox Then
                    c.Text = drow(c.Name).ToString
                ElseIf TypeOf c Is ComboBox Then
                    CType(c, ComboBox).DataSource.Position = CType(c, ComboBox).DataSource.Find("id", drow("id" & c.Name))
                ElseIf TypeOf c Is NumericUpDown Then
                    CType(c, NumericUpDown).Value = drow(c.Name)
                ElseIf TypeOf c Is DateTimePicker Then
                    CType(c, DateTimePicker).Value = drow(c.Name)
                ElseIf TypeOf c Is CheckBox Then
                    CType(c, CheckBox).Checked = drow(c.Name)
                End If
            Next
            Return target
        End Function
        Overloads Shared Function ToControls(dtab As DataTable, ByVal target As Object) As Object
            'Carga los registros de cada columna en los controles con el nombre de la columna correspondiente
            For Each c As Control In target.Controls
                If TypeOf c Is TextBox Then
                    c.Text = dtab(0)(c.Name).ToString
                ElseIf TypeOf c Is ComboBox Then
                    CType(c, ComboBox).DataSource.Position = CType(c, ComboBox).DataSource.Find("id", dtab(0)("id" & c.Name))
                ElseIf TypeOf c Is NumericUpDown Then
                    CType(c, NumericUpDown).Value = dtab(0)(c.Name)
                ElseIf TypeOf c Is DateTimePicker Then
                    CType(c, DateTimePicker).Value = dtab(0)(c.Name)
                ElseIf TypeOf c Is CheckBox Then
                    CType(c, CheckBox).Checked = dtab(0)(c.Name)
                End If
            Next
            Return target
        End Function
    End Class
End Module
