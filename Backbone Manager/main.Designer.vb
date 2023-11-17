<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ValorRuta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deshacer = New System.Windows.Forms.ToolStripButton()
        Me.guardar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PropPage = New System.Windows.Forms.TabPage()
        Me.ConnectPage = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DelCable = New System.Windows.Forms.Button()
        Me.SelectCable = New System.Windows.Forms.Button()
        Me.NewCable = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TelCompOriginProp1 = New Backbone_Manager.TelCompOriginProp()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.nuevo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoComp = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoAbonado = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminar = New System.Windows.Forms.ToolStripButton()
        Me.buscar = New System.Windows.Forms.ToolStripButton()
        Me.keyword = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ConnectPage.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ValorRuta})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(924, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel1.Text = "Ruta:"
        '
        'ValorRuta
        '
        Me.ValorRuta.Name = "ValorRuta"
        Me.ValorRuta.Size = New System.Drawing.Size(65, 17)
        Me.ValorRuta.Text = "[ValorRuta]"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.deshacer, Me.guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(924, 31)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(72, 28)
        Me.ToolStripDropDownButton1.Text = "≡ Menu"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.RestaurarToolStripMenuItem})
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo.."
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar.."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'deshacer
        '
        Me.deshacer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.deshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.deshacer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deshacer.ForeColor = System.Drawing.Color.White
        Me.deshacer.Image = CType(resources.GetObject("deshacer.Image"), System.Drawing.Image)
        Me.deshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.deshacer.Name = "deshacer"
        Me.deshacer.Size = New System.Drawing.Size(76, 28)
        Me.deshacer.Text = "Cancelar"
        '
        'guardar
        '
        Me.guardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.guardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.ForeColor = System.Drawing.Color.White
        Me.guardar.Image = CType(resources.GetObject("guardar.Image"), System.Drawing.Image)
        Me.guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(137, 28)
        Me.guardar.Text = "Guardar Cambios"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(524, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 508)
        Me.Panel1.TabIndex = 13
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PropPage)
        Me.TabControl1.Controls.Add(Me.ConnectPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(396, 504)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 14
        '
        'PropPage
        '
        Me.PropPage.Location = New System.Drawing.Point(4, 23)
        Me.PropPage.Margin = New System.Windows.Forms.Padding(0)
        Me.PropPage.Name = "PropPage"
        Me.PropPage.Size = New System.Drawing.Size(388, 477)
        Me.PropPage.TabIndex = 0
        Me.PropPage.Text = "Propiedades"
        '
        'ConnectPage
        '
        Me.ConnectPage.Controls.Add(Me.TabControl2)
        Me.ConnectPage.Controls.Add(Me.FlowLayoutPanel2)
        Me.ConnectPage.Controls.Add(Me.TelCompOriginProp1)
        Me.ConnectPage.Location = New System.Drawing.Point(4, 23)
        Me.ConnectPage.Margin = New System.Windows.Forms.Padding(0)
        Me.ConnectPage.Name = "ConnectPage"
        Me.ConnectPage.Size = New System.Drawing.Size(388, 477)
        Me.ConnectPage.TabIndex = 1
        Me.ConnectPage.Text = "Conectividad"
        '
        'TabControl2
        '
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 86)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(388, 391)
        Me.TabControl2.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl2.TabIndex = 122
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.DelCable)
        Me.FlowLayoutPanel2.Controls.Add(Me.SelectCable)
        Me.FlowLayoutPanel2.Controls.Add(Me.NewCable)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 58)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(388, 28)
        Me.FlowLayoutPanel2.TabIndex = 123
        '
        'DelCable
        '
        Me.DelCable.Location = New System.Drawing.Point(308, 3)
        Me.DelCable.Margin = New System.Windows.Forms.Padding(0, 3, 5, 3)
        Me.DelCable.Name = "DelCable"
        Me.DelCable.Size = New System.Drawing.Size(75, 22)
        Me.DelCable.TabIndex = 116
        Me.DelCable.Text = "Eliminar"
        Me.DelCable.UseVisualStyleBackColor = True
        '
        'SelectCable
        '
        Me.SelectCable.Location = New System.Drawing.Point(228, 3)
        Me.SelectCable.Margin = New System.Windows.Forms.Padding(0, 3, 5, 3)
        Me.SelectCable.Name = "SelectCable"
        Me.SelectCable.Size = New System.Drawing.Size(75, 22)
        Me.SelectCable.TabIndex = 117
        Me.SelectCable.Text = "Cargar"
        Me.SelectCable.UseVisualStyleBackColor = True
        '
        'NewCable
        '
        Me.NewCable.Location = New System.Drawing.Point(148, 3)
        Me.NewCable.Margin = New System.Windows.Forms.Padding(0, 3, 5, 3)
        Me.NewCable.Name = "NewCable"
        Me.NewCable.Size = New System.Drawing.Size(75, 22)
        Me.NewCable.TabIndex = 115
        Me.NewCable.Text = "Nueva"
        Me.NewCable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 28)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Conexiones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelCompOriginProp1
        '
        Me.TelCompOriginProp1.BackColor = System.Drawing.Color.Gainsboro
        Me.TelCompOriginProp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TelCompOriginProp1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelCompOriginProp1.Location = New System.Drawing.Point(0, 0)
        Me.TelCompOriginProp1.Margin = New System.Windows.Forms.Padding(0)
        Me.TelCompOriginProp1.Name = "TelCompOriginProp1"
        Me.TelCompOriginProp1.Size = New System.Drawing.Size(388, 58)
        Me.TelCompOriginProp1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 508)
        Me.Panel2.TabIndex = 14
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 23)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.PathSeparator = " > "
        Me.TreeView1.Size = New System.Drawing.Size(520, 481)
        Me.TreeView1.TabIndex = 6
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.ToolStrip3.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevo, Me.eliminar, Me.buscar, Me.keyword})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(520, 23)
        Me.ToolStrip3.TabIndex = 8
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'nuevo
        '
        Me.nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nuevo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoComp, Me.NuevoAbonado})
        Me.nuevo.Image = CType(resources.GetObject("nuevo.Image"), System.Drawing.Image)
        Me.nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nuevo.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(60, 23)
        Me.nuevo.Text = "Nuevo"
        '
        'NuevoComp
        '
        Me.NuevoComp.Name = "NuevoComp"
        Me.NuevoComp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.NuevoComp.Size = New System.Drawing.Size(177, 22)
        Me.NuevoComp.Text = "Componente"
        '
        'NuevoAbonado
        '
        Me.NuevoAbonado.Name = "NuevoAbonado"
        Me.NuevoAbonado.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NuevoAbonado.Size = New System.Drawing.Size(177, 22)
        Me.NuevoAbonado.Text = "Abonado"
        '
        'eliminar
        '
        Me.eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.eliminar.ForeColor = System.Drawing.Color.Black
        Me.eliminar.Image = CType(resources.GetObject("eliminar.Image"), System.Drawing.Image)
        Me.eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.eliminar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(93, 23)
        Me.eliminar.Text = "Eliminar Item"
        '
        'buscar
        '
        Me.buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.buscar.Image = CType(resources.GetObject("buscar.Image"), System.Drawing.Image)
        Me.buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buscar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(82, 23)
        Me.buscar.Text = "Buscar [F3]"
        '
        'keyword
        '
        Me.keyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.keyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keyword.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.keyword.MaxLength = 32
        Me.keyword.Name = "keyword"
        Me.keyword.Size = New System.Drawing.Size(200, 23)
        '
        'main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(924, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "main"
        Me.Text = "BackManager | Telefonia"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ConnectPage.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ValorRuta As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PropPage As TabPage
    Friend WithEvents ConnectPage As TabPage
    Friend WithEvents TelCompOriginProp1 As TelCompOriginProp
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents nuevo As ToolStripDropDownButton
    Friend WithEvents NuevoComp As ToolStripMenuItem
    Friend WithEvents NuevoAbonado As ToolStripMenuItem
    Friend WithEvents buscar As ToolStripButton
    Friend WithEvents keyword As ToolStripTextBox
    Friend WithEvents eliminar As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents NewCable As Button
    Friend WithEvents DelCable As Button
    Friend WithEvents SelectCable As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents deshacer As ToolStripButton
    Friend WithEvents guardar As ToolStripButton
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaurarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
