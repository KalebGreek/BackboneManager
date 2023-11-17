<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelConnectionPairDetail
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BinderColor = New System.Windows.Forms.Label()
        Me.Binder2Color = New System.Windows.Forms.Label()
        Me.TipColor = New System.Windows.Forms.Label()
        Me.RingColor = New System.Windows.Forms.Label()
        Me.CableActivo = New System.Windows.Forms.CheckBox()
        Me.CableNumeroPar = New System.Windows.Forms.TextBox()
        Me.CableNota = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BinderColor
        '
        Me.BinderColor.BackColor = System.Drawing.Color.White
        Me.BinderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BinderColor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BinderColor.Location = New System.Drawing.Point(46, 2)
        Me.BinderColor.Margin = New System.Windows.Forms.Padding(10, 2, 0, 0)
        Me.BinderColor.Name = "BinderColor"
        Me.BinderColor.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BinderColor.Size = New System.Drawing.Size(23, 27)
        Me.BinderColor.TabIndex = 21
        Me.BinderColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Binder2Color
        '
        Me.Binder2Color.BackColor = System.Drawing.Color.RoyalBlue
        Me.Binder2Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Binder2Color.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Binder2Color.Location = New System.Drawing.Point(46, 5)
        Me.Binder2Color.Margin = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.Binder2Color.Name = "Binder2Color"
        Me.Binder2Color.Size = New System.Drawing.Size(43, 21)
        Me.Binder2Color.TabIndex = 22
        Me.Binder2Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TipColor
        '
        Me.TipColor.BackColor = System.Drawing.Color.White
        Me.TipColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TipColor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TipColor.Location = New System.Drawing.Point(46, 8)
        Me.TipColor.Margin = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.TipColor.Name = "TipColor"
        Me.TipColor.Size = New System.Drawing.Size(80, 7)
        Me.TipColor.TabIndex = 27
        Me.TipColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RingColor
        '
        Me.RingColor.BackColor = System.Drawing.Color.RoyalBlue
        Me.RingColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RingColor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RingColor.Location = New System.Drawing.Point(46, 15)
        Me.RingColor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.RingColor.Name = "RingColor"
        Me.RingColor.Size = New System.Drawing.Size(80, 8)
        Me.RingColor.TabIndex = 28
        Me.RingColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CableActivo
        '
        Me.CableActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CableActivo.Location = New System.Drawing.Point(136, 3)
        Me.CableActivo.Margin = New System.Windows.Forms.Padding(0)
        Me.CableActivo.Name = "CableActivo"
        Me.CableActivo.Size = New System.Drawing.Size(50, 25)
        Me.CableActivo.TabIndex = 20
        Me.CableActivo.UseVisualStyleBackColor = True
        '
        'CableNumeroPar
        '
        Me.CableNumeroPar.Location = New System.Drawing.Point(2, 4)
        Me.CableNumeroPar.Name = "CableNumeroPar"
        Me.CableNumeroPar.ReadOnly = True
        Me.CableNumeroPar.Size = New System.Drawing.Size(36, 20)
        Me.CableNumeroPar.TabIndex = 29
        Me.CableNumeroPar.Text = "1"
        Me.CableNumeroPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CableNota
        '
        Me.CableNota.Location = New System.Drawing.Point(194, 5)
        Me.CableNota.Name = "CableNota"
        Me.CableNota.Size = New System.Drawing.Size(157, 20)
        Me.CableNota.TabIndex = 30
        '
        'TelConnectionPairDetail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.CableNota)
        Me.Controls.Add(Me.CableNumeroPar)
        Me.Controls.Add(Me.BinderColor)
        Me.Controls.Add(Me.Binder2Color)
        Me.Controls.Add(Me.CableActivo)
        Me.Controls.Add(Me.RingColor)
        Me.Controls.Add(Me.TipColor)
        Me.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TelConnectionPairDetail"
        Me.Size = New System.Drawing.Size(353, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BinderColor As Label
    Friend WithEvents Binder2Color As Label
    Friend WithEvents TipColor As Label
    Friend WithEvents RingColor As Label
    Friend WithEvents CableActivo As CheckBox
    Friend WithEvents CableNumeroPar As TextBox
    Friend WithEvents CableNota As TextBox
End Class
