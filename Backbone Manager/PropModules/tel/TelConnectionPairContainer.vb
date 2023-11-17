Public Class TelConnectionPairContainer
    Dim ConnectionListSQL As String =
        "SELECT id, idOrigen, idComponente, idAbonado, idCable, 
        NumeroPar, activo, nota, idAbonado
        FROM Conexion"

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub

    Public Sub Fill(idCable As Integer, capacity As Integer)
        Dim dtab As New DataTable
        Dim row As Integer = 0

        wrapper.SuspendLayout()

        dtab = DbMan.ReadDB(ConnectionListSQL & " WHERE idCable=" & idCable, My.Settings.currentcon)
        Dim bs As New BindingSource
        bs.DataSource = dtab

        For p = 1 To capacity
            Dim TelPairDetail As New TelConnectionPairDetail
            With TelPairDetail
                .Parent = wrapper
                .CableId = -1
                .NumeroPar = p
                .Activo = True
                .Nota = ""

                row = bs.Find("NumeroPar", p)
                If row > -1 Then
                    .CableId = dtab(row)("id")
                    .NumeroPar = dtab(row)("NumeroPar")
                    .Activo = dtab(row)("activo")
                    .Nota = dtab(row)("nota").ToString
                End If
            End With
            wrapper.Controls.Add(TelPairDetail)
            TelPairDetail.PaintPair()
        Next
        wrapper.ResumeLayout()
    End Sub

    Public Sub Save(origen As Integer, componente As Integer, abonado As Integer, cable As Integer)
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Minimum
        ProgressBar1.Maximum = wrapper.Controls.Count
        wrapper.Visible = False
        'Llamar a cada PairDetail
        For Each cpd As TelConnectionPairDetail In wrapper.Controls
            ProgressBar1.Value += 1
            DbMan.EditDB(cpd.EditPairSQL(origen, componente, abonado, cable))
        Next
        ProgressBar1.Visible = False
        wrapper.Visible = True
    End Sub
End Class
