<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelCompOriginProp
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.origen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.destino = New System.Windows.Forms.TextBox()
        Me.ab = New System.Windows.Forms.CheckBox()
        Me.help1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.origen)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.destino)
        Me.FlowLayoutPanel1.Controls.Add(Me.ab)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(380, 60)
        Me.FlowLayoutPanel1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'origen
        '
        Me.origen.Location = New System.Drawing.Point(44, 5)
        Me.origen.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.origen.Name = "origen"
        Me.origen.ReadOnly = True
        Me.origen.Size = New System.Drawing.Size(331, 21)
        Me.origen.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'destino
        '
        Me.destino.Location = New System.Drawing.Point(44, 31)
        Me.destino.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.destino.Name = "destino"
        Me.destino.ReadOnly = True
        Me.destino.Size = New System.Drawing.Size(252, 21)
        Me.destino.TabIndex = 122
        '
        'ab
        '
        Me.ab.AutoSize = True
        Me.ab.Enabled = False
        Me.ab.Location = New System.Drawing.Point(298, 34)
        Me.ab.Margin = New System.Windows.Forms.Padding(2, 8, 0, 0)
        Me.ab.Name = "ab"
        Me.ab.Size = New System.Drawing.Size(76, 17)
        Me.ab.TabIndex = 120
        Me.ab.Text = "Abonado"
        Me.ab.UseVisualStyleBackColor = True
        '
        'TelCompOriginProp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TelCompOriginProp"
        Me.Size = New System.Drawing.Size(380, 60)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ab As CheckBox
    Friend WithEvents help1 As ToolTip
    Friend WithEvents origen As TextBox
    Friend WithEvents destino As TextBox
End Class
