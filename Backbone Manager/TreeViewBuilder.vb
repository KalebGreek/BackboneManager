Public Class TreeViewBuilder
    ' Alternate way of maintaining a list of nodes that have already been added.
    'private List<int> doneNotes;
    Private Shared RedID As Integer

    Shared Sub CreateNodes(ByRef target As TreeView, dtab As DataTable,
                           DefaultParentIdColumn As String, DefaultIdColumn As String, DefaultNameColumn As String)
        Dim rows As DataRow() = New DataRow(dtab.Rows.Count - 1) {}
        dtab.Rows.CopyTo(rows, 0)
        'doneNotes = new List<int>(9);

        ' Get the TreeView ready for node creation.
        ' This isn't really needed since we're using AddRange (but it's good practice).
        target.BeginUpdate()
        target.Nodes.Clear()

        Dim nodes As TreeNode() = RecurseRows(dtab, DefaultParentIdColumn, DefaultIdColumn, DefaultNameColumn)
        target.Nodes.AddRange(nodes)

        ' Notify the TreeView to resume painting.
        target.EndUpdate()
    End Sub

    Shared Function RecurseRows(dtab As DataTable,
                                DefaultParentIdCol As String, DefaultIdCol As String, DefaultNameCol As String) As TreeNode()
        Dim nodeList As New List(Of TreeNode)()
        Dim node As TreeNode = Nothing

        For Each dr As DataRow In dtab.Rows
            node = New TreeNode(dr(DefaultNameCol).ToString())
            RedID = Convert.ToInt32(dr(DefaultIdCol))

            node.Name = RedID.ToString()
            node.ToolTipText = RedID.ToString()

            ' This alternate method using the Find method uses a Predicate generic delegate.
            If nodeList.Find(AddressOf FindNode) Is Nothing And dtab.Rows.Count > 0 Then
                'dtab = db.read(main.NetworkName,
                'main.TreeviewTableSQL & " WHERE " & DefaultParentIdCol & " = " & dr(DefaultIdCol))

                If dtab.Rows.Count > 0 Then
                    ' Recursively call this function for all childRowsl
                    Dim childNodes As TreeNode() = RecurseRows(dtab, DefaultParentIdCol, DefaultIdCol, DefaultNameCol)

                    ' Add all childnodes to this node.
                    node.Nodes.AddRange(childNodes)
                End If

                nodeList.Add(node)
            End If
        Next

        ' Convert this List<TreeNode> to an array so it can be added to the parent node/TreeView.
        Dim nodeArr As TreeNode() = nodeList.ToArray()
        Return nodeArr
    End Function

    Private Shared Function FindNode(n As TreeNode) As Boolean
        If n.Nodes.Count = 0 Then
            Return n.Name = RedID.ToString()
        Else
            While n.Nodes.Count > 0
                For Each tn As TreeNode In n.Nodes
                    If tn.Name = RedID.ToString() Then
                        Return True
                    Else
                        n = tn
                    End If
                Next
            End While
            Return False
        End If
    End Function
End Class
