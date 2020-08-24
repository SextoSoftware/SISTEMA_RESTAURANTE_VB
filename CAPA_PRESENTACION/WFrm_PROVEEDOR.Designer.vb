<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_PROVEEDOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_PROVEEDOR))
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.ButttonModificar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.RadioButtonInactivo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActivo = New System.Windows.Forms.RadioButton()
        Me.txtdire = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtemail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttelefono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtruc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnomcontac = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnomcomp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbusqueda = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RadioButtonRuc = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNomComp = New System.Windows.Forms.RadioButton()
        Me.Dg_Proveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RequiredFieldValidator1 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator()
        Me.RegularExpressionValidator1 = New DevComponents.DotNetBar.Validator.RegularExpressionValidator()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.RequiredFieldValidator3 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator()
        Me.RequiredFieldValidator2 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator()
        Me.groupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupPanel1
        '
        Me.groupPanel1.AutoScroll = True
        Me.groupPanel1.BackColor = System.Drawing.Color.White
        Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel1.Controls.Add(Me.TextBox1)
        Me.groupPanel1.Controls.Add(Me.ButtonNuevo)
        Me.groupPanel1.Controls.Add(Me.ButttonModificar)
        Me.groupPanel1.Controls.Add(Me.ButtonRegistrar)
        Me.groupPanel1.Controls.Add(Me.RadioButtonInactivo)
        Me.groupPanel1.Controls.Add(Me.RadioButtonActivo)
        Me.groupPanel1.Controls.Add(Me.txtdire)
        Me.groupPanel1.Controls.Add(Me.txtemail)
        Me.groupPanel1.Controls.Add(Me.txttelefono)
        Me.groupPanel1.Controls.Add(Me.txtruc)
        Me.groupPanel1.Controls.Add(Me.txtnomcontac)
        Me.groupPanel1.Controls.Add(Me.txtnomcomp)
        Me.groupPanel1.Controls.Add(Me.Label7)
        Me.groupPanel1.Controls.Add(Me.Label6)
        Me.groupPanel1.Controls.Add(Me.Label5)
        Me.groupPanel1.Controls.Add(Me.Label4)
        Me.groupPanel1.Controls.Add(Me.Label3)
        Me.groupPanel1.Controls.Add(Me.Label2)
        Me.groupPanel1.Controls.Add(Me.Label1)
        Me.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupPanel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Location = New System.Drawing.Point(10, 10)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(800, 158)
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
        Me.groupPanel1.TabIndex = 23
        Me.groupPanel1.Text = "DATOS DEL PROVEEDOR"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(14, -1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(23, 23)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Visible = False
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonNuevo.FocusCuesEnabled = False
        Me.ButtonNuevo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.ButtonNuevo, True)
        Me.ButtonNuevo.Location = New System.Drawing.Point(689, 11)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(92, 28)
        Me.ButtonNuevo.TabIndex = 31
        Me.ButtonNuevo.Text = "NUEVO"
        '
        'ButttonModificar
        '
        Me.ButttonModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButttonModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButttonModificar.Enabled = False
        Me.ButttonModificar.FocusCuesEnabled = False
        Me.ButttonModificar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.ButttonModificar, True)
        Me.ButttonModificar.Location = New System.Drawing.Point(689, 92)
        Me.ButttonModificar.Name = "ButttonModificar"
        Me.ButttonModificar.Size = New System.Drawing.Size(92, 28)
        Me.ButttonModificar.TabIndex = 30
        Me.ButttonModificar.Text = "ACTUALIZAR"
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonRegistrar.FocusCuesEnabled = False
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.ButtonRegistrar, True)
        Me.ButtonRegistrar.Location = New System.Drawing.Point(689, 49)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(92, 30)
        Me.ButtonRegistrar.TabIndex = 29
        Me.ButtonRegistrar.Text = "REGISTRAR"
        '
        'RadioButtonInactivo
        '
        Me.RadioButtonInactivo.AutoSize = True
        Me.RadioButtonInactivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonInactivo.Enabled = False
        Me.RadioButtonInactivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonInactivo.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonInactivo.Location = New System.Drawing.Point(577, 98)
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
        Me.RadioButtonActivo.Location = New System.Drawing.Point(486, 99)
        Me.RadioButtonActivo.Name = "RadioButtonActivo"
        Me.RadioButtonActivo.Size = New System.Drawing.Size(70, 19)
        Me.RadioButtonActivo.TabIndex = 18
        Me.RadioButtonActivo.TabStop = True
        Me.RadioButtonActivo.Text = "ACTIVO"
        Me.RadioButtonActivo.UseVisualStyleBackColor = False
        '
        'txtdire
        '
        Me.txtdire.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtdire.Border.Class = "TextBoxBorder"
        Me.txtdire.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdire.DisabledBackColor = System.Drawing.Color.White
        Me.txtdire.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtdire.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdire, True)
        Me.txtdire.Location = New System.Drawing.Point(94, 97)
        Me.txtdire.MaxLength = 50
        Me.txtdire.Name = "txtdire"
        Me.txtdire.Size = New System.Drawing.Size(283, 23)
        Me.txtdire.TabIndex = 17
        Me.txtdire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdire.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdire.WatermarkText = "Lugar donde se encuentra ubicada la empresa"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtemail.Border.Class = "TextBoxBorder"
        Me.txtemail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemail.DisabledBackColor = System.Drawing.Color.White
        Me.txtemail.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtemail, True)
        Me.txtemail.Location = New System.Drawing.Point(447, 59)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(219, 23)
        Me.txtemail.TabIndex = 16
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtemail.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.WatermarkText = "Correo electronico para comuniarse"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txttelefono.Border.Class = "TextBoxBorder"
        Me.txttelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelefono.DisabledBackColor = System.Drawing.Color.White
        Me.txttelefono.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txttelefono.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txttelefono, True)
        Me.txttelefono.Location = New System.Drawing.Point(279, 59)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(98, 23)
        Me.txttelefono.TabIndex = 15
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttelefono.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.WatermarkText = "8 digistos del 0-9"
        '
        'txtruc
        '
        Me.txtruc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtruc.Border.Class = "TextBoxBorder"
        Me.txtruc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.DisabledBackColor = System.Drawing.Color.White
        Me.txtruc.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtruc.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtruc, True)
        Me.txtruc.Location = New System.Drawing.Point(72, 58)
        Me.txtruc.MaxLength = 10
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(111, 23)
        Me.txtruc.TabIndex = 14
        Me.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtruc.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.WatermarkText = "10 digistos del 0-9"
        '
        'txtnomcontac
        '
        Me.txtnomcontac.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtnomcontac.Border.Class = "TextBoxBorder"
        Me.txtnomcontac.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnomcontac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomcontac.DisabledBackColor = System.Drawing.Color.White
        Me.txtnomcontac.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtnomcontac.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtnomcontac, True)
        Me.txtnomcontac.Location = New System.Drawing.Point(504, 21)
        Me.txtnomcontac.MaxLength = 30
        Me.txtnomcontac.Name = "txtnomcontac"
        Me.txtnomcontac.Size = New System.Drawing.Size(162, 23)
        Me.txtnomcontac.TabIndex = 13
        Me.txtnomcontac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnomcontac.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcontac.WatermarkText = "Nombre y apellidos"
        '
        'txtnomcomp
        '
        Me.txtnomcomp.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtnomcomp.Border.Class = "TextBoxBorder"
        Me.txtnomcomp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnomcomp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomcomp.DisabledBackColor = System.Drawing.Color.White
        Me.txtnomcomp.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtnomcomp.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtnomcomp, True)
        Me.txtnomcomp.Location = New System.Drawing.Point(167, 21)
        Me.txtnomcomp.MaxLength = 30
        Me.txtnomcomp.Name = "txtnomcomp"
        Me.txtnomcomp.Size = New System.Drawing.Size(162, 23)
        Me.txtnomcomp.TabIndex = 12
        Me.txtnomcomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnomcomp.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcomp.WatermarkText = "Identificacion de la empresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(396, 100)
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
        Me.Label6.Location = New System.Drawing.Point(395, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "EMAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(199, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TELEFONO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "C.I"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(349, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE DE CONTACTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE DE COMPAÑIA"
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
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 179)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(798, 313)
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
        Me.GroupPanel2.TabIndex = 24
        Me.GroupPanel2.Text = "LISTADO DE PROVEEDORES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.txtbusqueda)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRuc)
        Me.GroupBox1.Controls.Add(Me.RadioButtonNomComp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(118, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 59)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Busqueda"
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
        Me.txtbusqueda.Location = New System.Drawing.Point(346, 27)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(136, 23)
        Me.txtbusqueda.TabIndex = 22
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
        Me.RadioButtonRuc.Location = New System.Drawing.Point(210, 29)
        Me.RadioButtonRuc.Name = "RadioButtonRuc"
        Me.RadioButtonRuc.Size = New System.Drawing.Size(110, 19)
        Me.RadioButtonRuc.TabIndex = 21
        Me.RadioButtonRuc.Text = "Numero de C.I"
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
        Me.RadioButtonNomComp.Location = New System.Drawing.Point(51, 29)
        Me.RadioButtonNomComp.Name = "RadioButtonNomComp"
        Me.RadioButtonNomComp.Size = New System.Drawing.Size(137, 19)
        Me.RadioButtonNomComp.TabIndex = 20
        Me.RadioButtonNomComp.TabStop = True
        Me.RadioButtonNomComp.Text = "Nombre Compañia"
        Me.RadioButtonNomComp.UseVisualStyleBackColor = False
        '
        'Dg_Proveedores
        '
        Me.Dg_Proveedores.AllowUserToDeleteRows = False
        Me.Dg_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Proveedores.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Proveedores.ColumnHeadersHeight = 26
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Proveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_Proveedores.EnableHeadersVisualStyles = False
        Me.Dg_Proveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Dg_Proveedores.Location = New System.Drawing.Point(12, 66)
        Me.Dg_Proveedores.Name = "Dg_Proveedores"
        Me.Dg_Proveedores.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Proveedores.RowHeadersWidth = 30
        Me.Dg_Proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Proveedores.Size = New System.Drawing.Size(766, 214)
        Me.Dg_Proveedores.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(10, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 219)
        Me.Panel1.TabIndex = 2
        '
        'RequiredFieldValidator1
        '
        Me.RequiredFieldValidator1.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RegularExpressionValidator1
        '
        Me.RegularExpressionValidator1.ValidationExpression = "\S{5,5}"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator3
        '
        Me.RequiredFieldValidator3.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator2
        '
        Me.RequiredFieldValidator2.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'WFrm_PROVEEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 492)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.groupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(838, 531)
        Me.MinimumSize = New System.Drawing.Size(838, 531)
        Me.Name = "WFrm_PROVEEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO PROVEEDOR"
        Me.groupPanel1.ResumeLayout(False)
        Me.groupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents RequiredFieldValidator1 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Private WithEvents RegularExpressionValidator1 As DevComponents.DotNetBar.Validator.RegularExpressionValidator
    Friend WithEvents txtruc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RadioButtonInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonActivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdire As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtemail As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents RequiredFieldValidator2 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Private WithEvents txtnomcomp As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents RequiredFieldValidator3 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Private WithEvents txtnomcontac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButttonModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dg_Proveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RadioButtonRuc As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNomComp As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txttelefono As DevComponents.DotNetBar.Controls.TextBoxX
End Class
