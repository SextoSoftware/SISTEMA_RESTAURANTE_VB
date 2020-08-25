<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_PRODUCTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_PRODUCTO))
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtbusqueda = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RadioButtonRuc = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNomComp = New System.Windows.Forms.RadioButton()
        Me.Dg_Proveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ComboBoxEx3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtstock = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.ButttonModificar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.RadioButtonInactivo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActivo = New System.Windows.Forms.RadioButton()
        Me.txtdes = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcanmedi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtprecio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.Dg_Proveedores)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(3, 177)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(830, 381)
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
        Me.GroupPanel2.TabIndex = 26
        Me.GroupPanel2.Text = "LISTADO DE PRODUCTO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.ComboBoxEx2)
        Me.GroupBox1.Controls.Add(Me.txtbusqueda)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRuc)
        Me.GroupBox1.Controls.Add(Me.RadioButtonNomComp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(118, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 59)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Busqueda"
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx2.Enabled = False
        Me.ComboBoxEx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxEx2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx2.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.Highlighter1.SetHighlightOnFocus(Me.ComboBoxEx2, True)
        Me.ComboBoxEx2.ItemHeight = 17
        Me.ComboBoxEx2.Location = New System.Drawing.Point(361, 26)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(119, 23)
        Me.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx2.TabIndex = 14
        Me.ComboBoxEx2.WatermarkText = "Seleccione"
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
        Me.Highlighter1.SetHighlightOnFocus(Me.txtbusqueda, True)
        Me.txtbusqueda.Location = New System.Drawing.Point(138, 25)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(136, 23)
        Me.txtbusqueda.TabIndex = 12
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbusqueda.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.WatermarkText = "Ingrese el dato a buscar"
        '
        'RadioButtonRuc
        '
        Me.RadioButtonRuc.AutoSize = True
        Me.RadioButtonRuc.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonRuc.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonRuc.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.RadioButtonRuc, True)
        Me.RadioButtonRuc.Location = New System.Drawing.Point(303, 27)
        Me.RadioButtonRuc.Name = "RadioButtonRuc"
        Me.RadioButtonRuc.Size = New System.Drawing.Size(55, 19)
        Me.RadioButtonRuc.TabIndex = 13
        Me.RadioButtonRuc.Text = "TIPO"
        Me.RadioButtonRuc.UseVisualStyleBackColor = False
        '
        'RadioButtonNomComp
        '
        Me.RadioButtonNomComp.AutoSize = True
        Me.RadioButtonNomComp.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonNomComp.Checked = True
        Me.RadioButtonNomComp.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonNomComp.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.RadioButtonNomComp, True)
        Me.RadioButtonNomComp.Location = New System.Drawing.Point(56, 27)
        Me.RadioButtonNomComp.Name = "RadioButtonNomComp"
        Me.RadioButtonNomComp.Size = New System.Drawing.Size(79, 19)
        Me.RadioButtonNomComp.TabIndex = 20
        Me.RadioButtonNomComp.TabStop = True
        Me.RadioButtonNomComp.Text = "NOMBRE"
        Me.RadioButtonNomComp.UseVisualStyleBackColor = False
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
        Me.Dg_Proveedores.Location = New System.Drawing.Point(9, 66)
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
        Me.Dg_Proveedores.Size = New System.Drawing.Size(803, 285)
        Me.Dg_Proveedores.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(6, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 290)
        Me.Panel1.TabIndex = 2
        '
        'groupPanel1
        '
        Me.groupPanel1.AutoScroll = True
        Me.groupPanel1.BackColor = System.Drawing.Color.White
        Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel1.Controls.Add(Me.ComboBoxEx3)
        Me.groupPanel1.Controls.Add(Me.TextBox2)
        Me.groupPanel1.Controls.Add(Me.txtstock)
        Me.groupPanel1.Controls.Add(Me.Label3)
        Me.groupPanel1.Controls.Add(Me.Label8)
        Me.groupPanel1.Controls.Add(Me.ComboBoxEx1)
        Me.groupPanel1.Controls.Add(Me.TextBox1)
        Me.groupPanel1.Controls.Add(Me.ButtonNuevo)
        Me.groupPanel1.Controls.Add(Me.ButttonModificar)
        Me.groupPanel1.Controls.Add(Me.ButtonRegistrar)
        Me.groupPanel1.Controls.Add(Me.RadioButtonInactivo)
        Me.groupPanel1.Controls.Add(Me.RadioButtonActivo)
        Me.groupPanel1.Controls.Add(Me.txtdes)
        Me.groupPanel1.Controls.Add(Me.txtcanmedi)
        Me.groupPanel1.Controls.Add(Me.txtprecio)
        Me.groupPanel1.Controls.Add(Me.txtnom)
        Me.groupPanel1.Controls.Add(Me.Label7)
        Me.groupPanel1.Controls.Add(Me.Label6)
        Me.groupPanel1.Controls.Add(Me.Label5)
        Me.groupPanel1.Controls.Add(Me.Label4)
        Me.groupPanel1.Controls.Add(Me.Label2)
        Me.groupPanel1.Controls.Add(Me.Label1)
        Me.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupPanel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Location = New System.Drawing.Point(1, 9)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(832, 158)
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
        Me.groupPanel1.TabIndex = 25
        Me.groupPanel1.Text = "DATOS DEL PRODUCTO"
        '
        'ComboBoxEx3
        '
        Me.ComboBoxEx3.DisplayMember = "Text"
        Me.ComboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxEx3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx3.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx3.FormattingEnabled = True
        Me.Highlighter1.SetHighlightOnFocus(Me.ComboBoxEx3, True)
        Me.ComboBoxEx3.ItemHeight = 17
        Me.ComboBoxEx3.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.ComboBoxEx3.Location = New System.Drawing.Point(594, 56)
        Me.ComboBoxEx3.Name = "ComboBoxEx3"
        Me.ComboBoxEx3.Size = New System.Drawing.Size(101, 23)
        Me.ComboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx3.TabIndex = 38
        Me.ComboBoxEx3.WatermarkText = "Seleccione"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Litros"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Gramos"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Kilo"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "CC"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(506, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(11, 23)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.Visible = False
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtstock.Border.Class = "TextBoxBorder"
        Me.txtstock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtstock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstock.DisabledBackColor = System.Drawing.Color.White
        Me.txtstock.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtstock.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtstock, True)
        Me.txtstock.Location = New System.Drawing.Point(383, 100)
        Me.txtstock.MaxLength = 6
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(54, 23)
        Me.txtstock.TabIndex = 7
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtstock.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.WatermarkText = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(319, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "STOCK"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(529, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "PRECIO"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.Highlighter1.SetHighlightOnFocus(Me.ComboBoxEx1, True)
        Me.ComboBoxEx1.ItemHeight = 17
        Me.ComboBoxEx1.Location = New System.Drawing.Point(386, 20)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(119, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 2
        Me.ComboBoxEx1.WatermarkText = "Seleccione"
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
        Me.ButtonNuevo.Location = New System.Drawing.Point(715, 11)
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
        Me.ButttonModificar.Location = New System.Drawing.Point(715, 92)
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
        Me.ButtonRegistrar.Location = New System.Drawing.Point(715, 49)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(92, 30)
        Me.ButtonRegistrar.TabIndex = 10
        Me.ButtonRegistrar.Text = "REGISTRAR"
        '
        'RadioButtonInactivo
        '
        Me.RadioButtonInactivo.AutoSize = True
        Me.RadioButtonInactivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonInactivo.Enabled = False
        Me.RadioButtonInactivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonInactivo.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.RadioButtonInactivo, True)
        Me.RadioButtonInactivo.Location = New System.Drawing.Point(611, 101)
        Me.RadioButtonInactivo.Name = "RadioButtonInactivo"
        Me.RadioButtonInactivo.Size = New System.Drawing.Size(84, 19)
        Me.RadioButtonInactivo.TabIndex = 19
        Me.RadioButtonInactivo.Text = "INACTIVO"
        Me.RadioButtonInactivo.UseVisualStyleBackColor = False
        '
        'RadioButtonActivo
        '
        Me.RadioButtonActivo.AutoSize = True
        Me.RadioButtonActivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonActivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonActivo.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.RadioButtonActivo, True)
        Me.RadioButtonActivo.Location = New System.Drawing.Point(532, 101)
        Me.RadioButtonActivo.Name = "RadioButtonActivo"
        Me.RadioButtonActivo.Size = New System.Drawing.Size(70, 19)
        Me.RadioButtonActivo.TabIndex = 8
        Me.RadioButtonActivo.TabStop = True
        Me.RadioButtonActivo.Text = "ACTIVO"
        Me.RadioButtonActivo.UseVisualStyleBackColor = False
        '
        'txtdes
        '
        Me.txtdes.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtdes.Border.Class = "TextBoxBorder"
        Me.txtdes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdes.DisabledBackColor = System.Drawing.Color.White
        Me.txtdes.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtdes.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdes, True)
        Me.txtdes.Location = New System.Drawing.Point(112, 60)
        Me.txtdes.MaxLength = 50
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(378, 23)
        Me.txtdes.TabIndex = 4
        Me.txtdes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdes.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdes.WatermarkText = "Descripción alternativa o comentarios del producto "
        '
        'txtcanmedi
        '
        Me.txtcanmedi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcanmedi.Border.Class = "TextBoxBorder"
        Me.txtcanmedi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcanmedi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcanmedi.DisabledBackColor = System.Drawing.Color.White
        Me.txtcanmedi.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtcanmedi.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtcanmedi, True)
        Me.txtcanmedi.Location = New System.Drawing.Point(229, 100)
        Me.txtcanmedi.MaxLength = 5
        Me.txtcanmedi.Name = "txtcanmedi"
        Me.txtcanmedi.Size = New System.Drawing.Size(59, 23)
        Me.txtcanmedi.TabIndex = 6
        Me.txtcanmedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcanmedi.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcanmedi.WatermarkText = "Cantidad"
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtprecio.Border.Class = "TextBoxBorder"
        Me.txtprecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtprecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprecio.DisabledBackColor = System.Drawing.Color.White
        Me.txtprecio.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtprecio.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtprecio, True)
        Me.txtprecio.Location = New System.Drawing.Point(594, 20)
        Me.txtprecio.MaxLength = 11
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(101, 23)
        Me.txtprecio.TabIndex = 3
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtprecio.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.WatermarkText = "Costo del producto"
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
        Me.Highlighter1.SetHighlightOnFocus(Me.txtnom, True)
        Me.txtnom.Location = New System.Drawing.Point(93, 20)
        Me.txtnom.MaxLength = 30
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(152, 23)
        Me.txtnom.TabIndex = 1
        Me.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnom.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.WatermarkText = "Identificación del producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(462, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ESTADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CANTIDAD DE UNIDADES MEDIDA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DESCRIPCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(518, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MEDIDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(262, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TIPO PRODUCTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE "
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'WFrm_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 561)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.groupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(853, 600)
        Me.MinimumSize = New System.Drawing.Size(853, 600)
        Me.Name = "WFrm_PRODUCTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " FORMULARIO PRODUCTO "
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPanel1.ResumeLayout(False)
        Me.groupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RadioButtonRuc As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNomComp As System.Windows.Forms.RadioButton
    Friend WithEvents Dg_Proveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtstock As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButttonModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RadioButtonInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonActivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcanmedi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtprecio As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtnom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBoxEx3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
End Class
