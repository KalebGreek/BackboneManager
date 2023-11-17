Public Class TelConnectionPairDetail
    Property CableId As Double
    Property NumeroPar As Double
    Property Activo As Boolean
    Property Nota As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Function ColorFromPair(NPar As Integer) As List(Of Color)
        Dim BackColorPalette1 As New List(Of Color) From {Color.White, Color.Tomato, Color.Black, Color.Yellow, Color.Violet}
        Dim BackColorPalette2 As New List(Of Color) From {Color.RoyalBlue, Color.Orange, Color.Green, Color.Sienna, Color.SlateGray}
        Dim ColorResult As New List(Of Color)

        Dim PairValues(3) As Integer 'Bind, bind2, tip, ring
        If NPar > 0 Then
            Do While NPar > PairValues(3)
                If NPar > 125 Then
                    PairValues(0) += 1
                    NPar -= 125
                ElseIf NPar > 25 Then
                    PairValues(1) += 1
                    NPar -= 25
                ElseIf NPar > 5 Then
                    PairValues(2) += 1
                    NPar -= 5
                Else
                    PairValues(3) = NPar
                End If
            Loop
        End If

        If PairValues(0) = 0 Then
            ColorResult.Add(Color.Transparent)
        Else
            ColorResult.Add(BackColorPalette1(PairValues(0) - 1))
        End If

        If PairValues(1) = 0 Then
            ColorResult.Add(Color.Transparent)
        Else
            ColorResult.Add(BackColorPalette2(PairValues(1) - 1))
        End If

        If PairValues(2) = 0 Then
            ColorResult.Add(Color.Transparent)
        Else
            ColorResult.Add(BackColorPalette1(PairValues(2) - 1))
        End If

        If PairValues(3) = 0 Then
            ColorResult.Add(Color.Transparent)
        Else
            ColorResult.Add(BackColorPalette2(PairValues(3) - 1))
        End If

        Return ColorResult
    End Function

    Public Function EditPairSQL(origen As Integer, componente As Integer, abonado As Integer, cable As Integer) As String
        If Me.Name > 0 Then
            Return "UPDATE conexion SET idOrigen=" & origen & ", idComponente=" & componente & ", 
                   idAbonado=" & abonado & ", idCable=" & cable & ", NumeroPar=" & CableNumeroPar.Text & ",
                   activo=" & CableActivo.Checked & ", nota='" & CableNota.Text & "'
                   WHERE id=" & Me.Name & ";"
        Else
            Return "INSERT INTO conexion(idOrigen, idComponente, idAbonado, idCable, NumeroPar, activo, nota)
                   VALUES(" & origen & ", " & componente & ", " & abonado & ", " & cable & ", " &
                   CableNumeroPar.Text & ", " & CableActivo.Checked & ", '" & CableNota.Text & "');"
        End If
    End Function

    Sub PaintPair()
        If Me.NumeroPar > 0 Then
            Dim ColorResult As List(Of Color) = ColorFromPair(NumeroPar)
            BinderColor.BackColor = ColorResult(0)
            Binder2Color.BackColor = ColorResult(1)
            TipColor.BackColor = ColorResult(2)
            RingColor.BackColor = ColorResult(3)
            CableNumeroPar.Text = NumeroPar
            CableActivo.Checked = Activo
            CableNota.Text = Nota
            ToolTip1.SetToolTip(Me.CableNota, Nota)
        End If
    End Sub
End Class
