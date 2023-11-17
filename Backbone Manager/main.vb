Public Class main
    Dim bs_search As New BindingSource
    Dim LastSelectedNode As New TreeNode
    Dim TreeviewIndex As New Integer

    Dim TreeViewSQL As String =
        "SELECT DISTINCT Conexion.idOrigen, 
            (SELECT CatComponente.nombre &' '& Componente.descripcion 
            FROM Componente INNER JOIN CatComponente ON Componente.idCategoria= CatComponente.Id
            WHERE Componente.id=Conexion.idOrigen) AS Origen,
        Conexion.idComponente, 
            (SELECT CatComponente.nombre &' '& Componente.descripcion 
            FROM Componente INNER JOIN CatComponente ON Componente.idCategoria= CatComponente.Id
            WHERE Componente.id=Conexion.idComponente) AS Componente, 
        Conexion.idAbonado,
            (SELECT &'['& Abonado.linea &'] '&  Abonado.razon AS Abonado
            FROM Abonado WHERE id=Conexion.idAbonado) AS Abonado
        FROM Conexion"

    Dim CableListSQL As String =
        "SELECT Conexion.id as idConexion, Conexion.IdOrigen, Conexion.IdCable, 
        Cable.marca, Cable.modelo, Cable.descripcion, Cable.idCategoria,
        Cable.longitud, Cable.capacidad, Cable.instalacion, 
        Conexion.NumeroPar, Conexion.activo, Conexion.nota, Conexion.idAbonado
        FROM Cable INNER JOIN Conexion ON Cable.Id = Conexion.IdCable"

    Private Sub Main_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        BuildTree()
    End Sub

    'Treeview Section
    Private Sub BuildTree(Optional ForceUpdate As Boolean = False)
        If TreeView1.Enabled Then
            'Filtro
            If TreeView1.Nodes.Count > 0 Then 'Red cargada
                If ForceUpdate Then 'Red distinta a la actual o forzar actualizacion
                    keyword.AutoCompleteCustomSource = Nothing
                    bs_search.DataSource = Nothing
                    TreeView1.Nodes.Clear()
                Else 'Red identica
                    Return
                End If
            End If

            'Raiz no tiene cableado ni origen
            Dim dtab As DataTable = DbMan.ReadDB(TreeViewSQL & " WHERE Conexion.idOrigen=0 AND Conexion.idCable=0", My.Settings.currentcon)

            Dim root As New TreeNode
            TreeviewIndex = 0
            root.Name = dtab(0)("IdComponente")
            root.Text = dtab(0)("Componente")
            root.Tag = TreeviewIndex

            TreeView1.BeginUpdate()
            TreeView1.Nodes.Add(root)
            TreeView1.EndUpdate()

            TreeView1.SelectedNode = TreeView1.Nodes(0)
            TreeView1.Focus()

            PopulateNodes(TreeView1.Nodes)
            TreeView1.SelectedNode.Expand()
        End If
    End Sub
    Private Sub PopulateNodes(ParentNodeCollection As TreeNodeCollection)
        For Each tn As TreeNode In ParentNodeCollection

            'Tabla de componentes
            Dim dtab As DataTable = DbMan.ReadDB(TreeViewSQL & "
                                            WHERE Conexion.IdOrigen=" & tn.Name & "
                                            AND Conexion.idAbonado=0", My.Settings.currentcon)
            'Tabla de abonados 
            Dim dtabClient As DataTable = DbMan.ReadDB(TreeViewSQL & " 
                                                  WHERE Conexion.idOrigen=" & tn.Name & "
                                                  AND Conexion.idComponente=0", My.Settings.currentcon)

            'Los abonados no pueden contener nodos
            If tn.ForeColor <> Color.SlateGray Then
                'Agrega abonados 
                For Each row As DataRow In dtabClient.Rows
                    TreeviewIndex += 1
                    Dim abTN As New TreeNode
                    abTN.ForeColor = Color.SlateGray
                    abTN.Name = row("idAbonado")
                    abTN.Text = row("Abonado").ToString
                    abTN.Tag = TreeviewIndex
                    tn.Nodes.Add(abTN)
                Next
                For Each row As DataRow In dtab.Rows
                    TreeviewIndex += 1
                    'Agrega componentes correspondientes al nodo
                    Dim cmpTN As New TreeNode
                    cmpTN.Name = row("idComponente")
                    cmpTN.Text = row("Componente").ToString
                    cmpTN.Tag = TreeviewIndex
                    tn.Nodes.Add(cmpTN)
                Next
            End If
            'Cargar subnodos antes de continuar
            PopulateNodes(tn.Nodes)
        Next
    End Sub
    Private Function SearchNode(ParentNodeCollection As TreeNodeCollection, key As String, LastResult As TreeNode) As TreeNode
        For Each tn As TreeNode In ParentNodeCollection
            If ((tn.Name Like "*" & keyword.Text & "*") Or (tn.Text Like "*" & keyword.Text & "*")) _
                And tn.Tag > LastResult.Tag Then
                Return tn
            ElseIf tn.Nodes.Count > 0 Then
                Return SearchNode(tn.Nodes, key, LastResult)
            End If
        Next
        Return LastResult
    End Function
    Private Function NewNode(ByRef origen As TreeNode, componente As Boolean) As TreeNode
        Dim newN As New TreeNode
        newN.Name = -1

        If componente Then
            newN.Text = "<Nuevo Componente>"
        Else
            newN.ForeColor = Color.SlateGray
            newN.Text = "[0] <Nuevo Abonado>"
        End If

        If origen Is Nothing Then
            origen = TreeView1.TopNode
        End If
        origen.Nodes.Add(newN)
        origen.Expand()

        Return newN
    End Function

    Private Sub NuevoComp_Click(sender As Object, e As EventArgs) Handles NuevoComp.Click
        If TreeView1.SelectedNode.ForeColor <> Color.SlateGray Then
            TreeView1.SelectedNode = NewNode(TreeView1.SelectedNode, True)
            LastSelectedNode = TreeView1.SelectedNode.Parent
            TreeView1.Enabled = False
        End If
    End Sub
    Private Sub NuevoAbonado_Click(sender As Object, e As EventArgs) Handles NuevoAbonado.Click
        If TreeView1.SelectedNode.ForeColor <> Color.SlateGray Then
            TreeView1.SelectedNode = NewNode(TreeView1.SelectedNode, False)
            LastSelectedNode = TreeView1.SelectedNode.Parent
            TreeView1.Enabled = False
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim target As TreeNode = TreeView1.SelectedNode
        If target Is Nothing = False And target Is TreeView1.TopNode = False Then
            If MsgBoxResult.Yes = MsgBox(
                "Se eliminaran todos los elementos que dependan del item seleccionado, asi como sus conexiones. Esta accion no se puede deshacer. Desea eliminar este item?",
                MsgBoxStyle.YesNo, "Eliminar Item") Then
                If target.ForeColor = Color.SlateGray Then
                    'db.edit(DeleteClientSQL & " WHERE Abonado.id=" & target.name
                Else
                    'db.edit(DeleteCompSQL & " WHERE Componente.id=" & target.Name) 
                End If
                TreeView1.Nodes.Remove(target)
            End If
        End If
    End Sub

    Private Sub SearchBox_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp
        If e.KeyCode = Keys.Enter Then
            buscar.PerformClick()
        End If
    End Sub
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles buscar.Click
        With TreeView1
            keyword.Text = Trim(keyword.Text) ' Formatear keyword
            If Len(keyword.Text) > 2 Then
                If .SelectedNode Is Nothing Then 'No hay nodo seleccionado
                    .SelectedNode = .TopNode
                End If

                Dim tn As TreeNode = SearchNode(.TopNode.Nodes, keyword.Text, LastSelectedNode)
                .SelectedNode = tn
                .SelectedNode.Expand()
            End If

            If .SelectedNode Is LastSelectedNode Then
                .SelectedNode = .TopNode
            End If

            LastSelectedNode = .SelectedNode
            .Focus()
        End With
    End Sub

    'Seccion conexiones
    'Rutinas
    Private Sub LoadCable(id As Integer, abonado As Boolean)
        TabControl2.TabPages.Clear()
        Dim LastCableGroup As Integer = 0

        Dim dtab As New DataTable
        If abonado Then
            dtab = DbMan.ReadDB(CableListSQL & " WHERE Conexion.idAbonado=" & id &
                           " ORDER BY idCable", My.Settings.currentcon)
        Else
            dtab = DbMan.ReadDB(CableListSQL & " WHERE Conexion.idComponente=" & id &
                           " ORDER BY idCable", My.Settings.currentcon)
        End If

        For Each r As DataRow In dtab.Rows
            If r("idCable") <> LastCableGroup Then

                Dim tcpp1 As New TelCablePageProp
                tcpp1.Fill(r)

                TabControl2.TabPages.Add(tcpp1)

                LastCableGroup = r("idCable")
            End If
        Next
        'Cargar lista de pares solo cuando TabPage este seleccionada (esto evita error de desbordamiento)
        If TabControl2.SelectedTab Is Nothing = False Then
            CType(TabControl2.SelectedTab, TelCablePageProp).ManagePairList(True)
        End If
    End Sub
    'Eventos
    Private Sub NewCable_Click(sender As Object, e As EventArgs) Handles NewCable.Click
        If TelCompOriginProp1.Name > 0 Then
            Dim tp1 As New TelCablePageProp
            tp1.Fill(Nothing, True)
            TabControl2.TabPages.Add(tp1)
            TabControl2.SelectTab(tp1)
        End If
    End Sub
    Private Sub SelectCable_Click(sender As Object, e As EventArgs) Handles SelectCable.Click
        'Usar selector para traer cable
    End Sub
    Private Sub DelCable_Click(sender As Object, e As EventArgs) Handles DelCable.Click
        If TabControl2.SelectedTab Is Nothing = False Then
            TabControl2.SelectedTab.Dispose()
        End If
    End Sub
    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        For Each t As TelCablePageProp In TabControl2.TabPages
            t.ManagePairList(False)
        Next
        If TabControl2.SelectedTab Is Nothing = False Then
            CType(TabControl2.SelectedTab, TelCablePageProp).ManagePairList(True)
        End If
    End Sub

    'Cargar propiedades de forma selectiva
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode Is Nothing Then
            TreeView1.SelectedNode = TreeView1.TopNode
        End If

        LoadProperties(TreeView1.SelectedNode)
        ValorRuta.Text = "[" & TreeView1.SelectedNode.Tag & "] " & TreeView1.SelectedNode.FullPath
    End Sub
    Private Sub LoadProperties(node As TreeNode)
        'Conectividad
        For Each tp As TabPage In TabControl1.TabPages
            If tp.Name = "PropPage" Then
                tp.SuspendLayout()
                tp.Controls.Clear()

                Dim telprop1 As Object
                If node.ForeColor <> Color.SlateGray Then
                    'Prop Componente
                    telprop1 = New TelComponentProp
                Else
                    'Prop Abonado
                    telprop1 = New TelClientProp
                End If
                telprop1.Fill(node.Name)
                telprop1.Dock = DockStyle.Fill

                tp.Controls.Add(telprop1)
                tp.ResumeLayout()

            ElseIf tp.Name = "ConnectPage" Then
                If node.Parent Is Nothing Then
                    TelCompOriginProp1.Fill(0, "<NINGUNO>", node.ForeColor = Color.SlateGray,
                                            node.Name, node.Text)
                Else
                    TelCompOriginProp1.Fill(node.Parent.Name, node.Parent.Text, node.ForeColor = Color.SlateGray,
                                            node.Name, node.Text)
                End If
                LoadCable(node.Name, node.ForeColor = Color.SlateGray)
            End If
        Next

        Panel1.Visible = True
    End Sub

    Private Sub deshacer_Click(sender As Object, e As EventArgs) Handles deshacer.Click
        TreeView1.Enabled = True
        BuildTree(True)
        TreeView1.SelectedNode = LastSelectedNode
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim idOrigen, idComponente, idAbonado As Integer

        For Each tp As TabPage In TabControl1.TabPages
            For Each c As Control In tp.Controls
                If tp.Name = "PropPage" Then
                    If TypeOf c Is TelComponentProp Then
                        CType(c, TelComponentProp).Save()
                        idComponente = CType(c, TelComponentProp).Name
                    ElseIf TypeOf c Is TelClientProp Then
                        CType(c, TelClientProp).Save()
                        idAbonado = CType(c, TelClientProp).Name
                    End If
                Else
                    TabControl1.SelectTab(tp)
                End If
            Next
        Next

        idOrigen = TelCompOriginProp1.Name

        'Conexiones
        For Each tcPage As TelCablePageProp In TabControl2.TabPages
            'Guardar cable y conexiones
            tcPage.Save(idOrigen, idComponente, idAbonado)
        Next

        TreeView1.Enabled = True
        BuildTree(True)
        TreeView1.SelectedNode = SearchNode(TreeView1.TopNode.Nodes, idComponente, LastSelectedNode)
    End Sub

    'Menu
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        'Directory
        Dim root As String = Environment.CurrentDirectory
        If FileIO.FileSystem.DirectoryExists(root & "\BACKUP") = False Then
            FileIO.FileSystem.CreateDirectory("BACKUP")
        End If
        'Backup Date
        Dim DateString As String = "" & Today.Year & Today.Month & Today.Day & "_" & Now.Hour & Now.Minute & Now.Second
        'Dialog config
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Backup File | *.backup"
        sfd.DefaultExt = "backup"
        sfd.InitialDirectory = root & "\BACKUP"
        sfd.FileName = DateString & "_telefoniadb.backup"

        sfd.ShowDialog()

        sfd.FileName = Trim(sfd.FileName)
        If sfd.FileName <> "" And sfd.FileName.Contains(".backup") Then
            System.IO.File.Copy(root & "\telefoniadb.accdb", sfd.FileName, True)
        End If
    End Sub
    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        'Directory
        Dim root As String = Environment.CurrentDirectory
        'Dialog Config
        Dim lfd As New OpenFileDialog
        lfd.Filter = "Backup File | *.backup"
        lfd.DefaultExt = "backup"
        lfd.InitialDirectory = root & "\BACKUP"

        lfd.ShowDialog()

        lfd.FileName = Trim(lfd.FileName)
        If lfd.FileName <> "" And lfd.FileName.Contains(".backup") Then
            System.IO.File.Copy(lfd.FileName, root & "\telefoniadb.accdb", True)
        End If
        BuildTree(True)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
