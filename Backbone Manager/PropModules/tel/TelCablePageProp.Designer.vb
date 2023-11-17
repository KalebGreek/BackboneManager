<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelCablePageProp


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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.categoria = New System.Windows.Forms.ComboBox()
        Me.ChangeCat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.modelo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.longitud = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.capacidad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChangeCap = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.instalacion = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DelCable = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.longitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.capacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(0, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(4, 61)
        Me.Label4.TabIndex = 7
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.categoria)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChangeCat)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.marca)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.modelo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.descripcion)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.longitud)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.capacidad)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChangeCap)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel1.Controls.Add(Me.instalacion)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel1.Controls.Add(Me.DelCable)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(380, 148)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Categoria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'categoria
        '
        Me.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoria.FormattingEnabled = True
        Me.categoria.Location = New System.Drawing.Point(74, 3)
        Me.categoria.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(267, 21)
        Me.categoria.TabIndex = 20
        '
        'ChangeCat
        '
        Me.ChangeCat.Location = New System.Drawing.Point(343, 2)
        Me.ChangeCat.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeCat.Name = "ChangeCat"
        Me.ChangeCat.Size = New System.Drawing.Size(30, 23)
        Me.ChangeCat.TabIndex = 22
        Me.ChangeCat.Text = "+"
        Me.ChangeCat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Marca"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'marca
        '
        Me.marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.marca.Location = New System.Drawing.Point(74, 29)
        Me.marca.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(125, 20)
        Me.marca.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(199, 30)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 18)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Modelo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'modelo
        '
        Me.modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.modelo.Location = New System.Drawing.Point(249, 29)
        Me.modelo.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.modelo.Name = "modelo"
        Me.modelo.Size = New System.Drawing.Size(125, 20)
        Me.modelo.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(0, 53)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 18)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Descripcion"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'descripcion
        '
        Me.descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.descripcion.Location = New System.Drawing.Point(74, 53)
        Me.descripcion.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(300, 20)
        Me.descripcion.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Longitud (mts.)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'longitud
        '
        Me.longitud.Location = New System.Drawing.Point(110, 77)
        Me.longitud.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.longitud.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.longitud.Name = "longitud"
        Me.longitud.Size = New System.Drawing.Size(89, 20)
        Me.longitud.TabIndex = 30
        Me.longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.longitud.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(199, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(0, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Capacidad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'capacidad
        '
        Me.capacidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.capacidad.Location = New System.Drawing.Point(109, 101)
        Me.capacidad.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.capacidad.Maximum = New Decimal(New Integer() {625, 0, 0, 0})
        Me.capacidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.capacidad.Name = "capacidad"
        Me.capacidad.Size = New System.Drawing.Size(90, 20)
        Me.capacidad.TabIndex = 32
        Me.capacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.capacidad.ThousandsSeparator = True
        Me.capacidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(199, 99)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChangeCap
        '
        Me.ChangeCap.Location = New System.Drawing.Point(235, 100)
        Me.ChangeCap.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.ChangeCap.Name = "ChangeCap"
        Me.ChangeCap.Size = New System.Drawing.Size(139, 21)
        Me.ChangeCap.TabIndex = 34
        Me.ChangeCap.Text = "Cambiar Capacidad"
        Me.ChangeCap.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(0, 125)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 18)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Fecha Instalacion"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'instalacion
        '
        Me.instalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.instalacion.Location = New System.Drawing.Point(110, 125)
        Me.instalacion.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.instalacion.Name = "instalacion"
        Me.instalacion.Size = New System.Drawing.Size(89, 20)
        Me.instalacion.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(199, 123)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 18)
        Me.Label16.TabIndex = 45
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DelCable
        '
        Me.DelCable.Location = New System.Drawing.Point(235, 124)
        Me.DelCable.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.DelCable.Name = "DelCable"
        Me.DelCable.Size = New System.Drawing.Size(139, 21)
        Me.DelCable.TabIndex = 38
        Me.DelCable.Text = "Eliminar Conexion"
        Me.DelCable.UseVisualStyleBackColor = True
        '
        'TelCablePageProp
        '
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TelCablePageProp"
        Me.Size = New System.Drawing.Size(380, 209)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.longitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.capacidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents longitud As NumericUpDown
    Friend WithEvents DelCable As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents categoria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents marca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents modelo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents descripcion As TextBox
    Friend WithEvents capacidad As NumericUpDown
    Friend WithEvents ChangeCap As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents instalacion As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents ChangeCat As Button
    Friend WithEvents Label5 As Label
End Class
