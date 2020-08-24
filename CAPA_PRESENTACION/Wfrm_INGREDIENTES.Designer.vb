<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wfrm_INGREDIENTES
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wfrm_INGREDIENTES))
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbunidad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.ButttonModificar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.txtStock = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbusqueda = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Dg_Proveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.groupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupPanel1
        '
        Me.groupPanel1.AutoScroll = True
        Me.groupPanel1.BackColor = System.Drawing.Color.White
        Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel1.Controls.Add(Me.TextBox2)
        Me.groupPanel1.Controls.Add(Me.Label8)
        Me.groupPanel1.Controls.Add(Me.cbunidad)
        Me.groupPanel1.Controls.Add(Me.TextBox1)
        Me.groupPanel1.Controls.Add(Me.ButtonNuevo)
        Me.groupPanel1.Controls.Add(Me.ButttonModificar)
        Me.groupPanel1.Controls.Add(Me.ButtonRegistrar)
        Me.groupPanel1.Controls.Add(Me.txtStock)
        Me.groupPanel1.Controls.Add(Me.txtnom)
        Me.groupPanel1.Controls.Add(Me.Label2)
        Me.groupPanel1.Controls.Add(Me.Label1)
        Me.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupPanel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Location = New System.Drawing.Point(7, 13)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(650, 125)
        '
        '
        '
        Me.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.groupPanel1.Style.BackColorGradientAngle = 90
        Me.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderBottomWidth = 1
        Me.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderLeftWidth = 1
        Me.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderRightWidth = 1
        Me.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderTopWidth = 1
        Me.groupPanel1.Style.CornerDiameter = 4
        Me.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.groupPanel1.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.groupPanel1.TabIndex = 28
        Me.groupPanel1.Text = "DATOS DEL INGREDIENTE DEL PLATO"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(506, -8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(11, 23)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(493, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "STOCK"
        '
        'cbunidad
        '
        Me.cbunidad.DisplayMember = "Text"
        Me.cbunidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbunidad.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbunidad.ForeColor = System.Drawing.Color.Black
        Me.cbunidad.FormattingEnabled = True
        Me.cbunidad.ItemHeight = 17
        Me.cbunidad.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cbunidad.Location = New System.Drawing.Point(376, 20)
        Me.cbunidad.Name = "cbunidad"
        Me.cbunidad.Size = New System.Drawing.Size(109, 23)
        Me.cbunidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbunidad.TabIndex = 2
        Me.cbunidad.WatermarkText = "Seleccione"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Gramos"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Kg"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Und"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(8, -2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 23)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Visible = False
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonNuevo.FocusCuesEnabled = False
        Me.ButtonNuevo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevo.Location = New System.Drawing.Point(173, 61)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(92, 28)
        Me.ButtonNuevo.TabIndex = 9
        Me.ButtonNuevo.Text = "NUEVO"
        '
        'ButttonModificar
        '
        Me.ButttonModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButttonModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButttonModificar.Enabled = False
        Me.ButttonModificar.FocusCuesEnabled = False
        Me.ButttonModificar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButttonModificar.Location = New System.Drawing.Point(410, 63)
        Me.ButttonModificar.Name = "ButttonModificar"
        Me.ButttonModificar.Size = New System.Drawing.Size(92, 28)
        Me.ButttonModificar.TabIndex = 11
        Me.ButttonModificar.Text = "ACTUALIZAR"
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonRegistrar.FocusCuesEnabled = False
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrar.Location = New System.Drawing.Point(292, 61)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(92, 30)
        Me.ButtonRegistrar.TabIndex = 10
        Me.ButtonRegistrar.Text = "REGISTRAR"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtStock.Border.Class = "TextBoxBorder"
        Me.txtStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStock.DisabledBackColor = System.Drawing.Color.White
        Me.txtStock.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtStock.ForeColor = System.Drawing.Color.Black
        Me.txtStock.Location = New System.Drawing.Point(545, 20)
        Me.txtStock.MaxLength = 11
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(89, 23)
        Me.txtStock.TabIndex = 3
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStock.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.WatermarkText = "Costo del Plato"
        '
        'txtnom
        '
        Me.txtnom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtnom.Border.Class = "TextBoxBorder"
        Me.txtnom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.DisabledBackColor = System.Drawing.Color.White
        Me.txtnom.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtnom.ForeColor = System.Drawing.Color.Black
        Me.txtnom.Location = New System.Drawing.Point(72, 20)
        Me.txtnom.MaxLength = 30
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(162, 23)
        Me.txtnom.TabIndex = 1
        Me.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnom.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.WatermarkText = "Identificacion del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(242, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "UNIDAD DE MEDIDA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE "
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.txtbusqueda)
        Me.GroupPanel2.Controls.Add(Me.Dg_Proveedores)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(8, 156)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(649, 285)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 29
        Me.GroupPanel2.Text = "LISTADO DE INGREDIENTES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(233, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NOMBRE "
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtbusqueda.Border.Class = "TextBoxBorder"
        Me.txtbusqueda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtbusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbusqueda.DisabledBackColor = System.Drawing.Color.White
        Me.txtbusqueda.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbusqueda.ForeColor = System.Drawing.Color.Black
        Me.txtbusqueda.Location = New System.Drawing.Point(302, 11)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(136, 23)
        Me.txtbusqueda.TabIndex = 12
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbusqueda.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.WatermarkText = "Ingrese el dato a buscar"
        '
        'Dg_Proveedores
        '
        Me.Dg_Proveedores.AllowUserToDeleteRows = False
        Me.Dg_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Proveedores.ColumnHeadersHeight = 26
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Proveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_Proveedores.EnableHeadersVisualStyles = False
        Me.Dg_Proveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Dg_Proveedores.Location = New System.Drawing.Point(11, 45)
        Me.Dg_Proveedores.Name = "Dg_Proveedores"
        Me.Dg_Proveedores.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Proveedores.RowHeadersWidth = 30
        Me.Dg_Proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Proveedores.Size = New System.Drawing.Size(621, 206)
        Me.Dg_Proveedores.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(8, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 211)
        Me.Panel1.TabIndex = 2
        '
        'Wfrm_INGREDIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 443)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.groupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Wfrm_INGREDIENTES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO DE INGREDIENTES"
        Me.groupPanel1.ResumeLayout(False)
        Me.groupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbunidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButttonModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtStock As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtnom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Dg_Proveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
End Class
