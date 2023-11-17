<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelSelector
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
        Me.CompList = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SelectComp = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.CompCatSelect = New System.Windows.Forms.ComboBox()
        Me.ModCat = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompList
        '
        Me.CompList.FormattingEnabled = True
        Me.CompList.ItemHeight = 16
        Me.CompList.Location = New System.Drawing.Point(5, 37)
        Me.CompList.Margin = New System.Windows.Forms.Padding(5, 3, 5, 5)
        Me.CompList.Name = "CompList"
        Me.CompList.Size = New System.Drawing.Size(370, 164)
        Me.CompList.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.CompCatSelect)
        Me.FlowLayoutPanel1.Controls.Add(Me.ModCat)
        Me.FlowLayoutPanel1.Controls.Add(Me.CompList)
        Me.FlowLayoutPanel1.Controls.Add(Me.SelectComp)
        Me.FlowLayoutPanel1.Controls.Add(Me.cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(380, 244)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'SelectComp
        '
        Me.SelectComp.Location = New System.Drawing.Point(3, 209)
        Me.SelectComp.Name = "SelectComp"
        Me.SelectComp.Size = New System.Drawing.Size(202, 27)
        Me.SelectComp.TabIndex = 0
        Me.SelectComp.Text = "Seleccionar Componente"
        Me.SelectComp.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(211, 209)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(164, 27)
        Me.cancel.TabIndex = 1
        Me.cancel.Text = "Cancelar"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'CompCatSelect
        '
        Me.CompCatSelect.FormattingEnabled = True
        Me.CompCatSelect.Location = New System.Drawing.Point(5, 5)
        Me.CompCatSelect.Margin = New System.Windows.Forms.Padding(5)
        Me.CompCatSelect.Name = "CompCatSelect"
        Me.CompCatSelect.Size = New System.Drawing.Size(335, 24)
        Me.CompCatSelect.TabIndex = 2
        '
        'ModCat
        '
        Me.ModCat.Location = New System.Drawing.Point(348, 3)
        Me.ModCat.Name = "ModCat"
        Me.ModCat.Size = New System.Drawing.Size(27, 27)
        Me.ModCat.TabIndex = 3
        Me.ModCat.Text = "+"
        Me.ModCat.UseVisualStyleBackColor = True
        '
        'TelCompOriginSelector
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TelCompOriginSelector"
        Me.Size = New System.Drawing.Size(380, 244)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CompList As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SelectComp As Button
    Friend WithEvents cancel As Button
    Friend WithEvents CompCatSelect As ComboBox
    Friend WithEvents ModCat As Button
End Class
