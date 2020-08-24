<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_MOZO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_MOZO))
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dg_Proveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txttelefonoNatu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDNI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.ButttonModificar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.RadioButtonInactivo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActivo = New System.Windows.Forms.RadioButton()
        Me.txtdire = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtemail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnomcomp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel2.Controls.Add(Me.Dg_Proveedores)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(6, 177)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(791, 310)
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
        Me.GroupPanel2.Text = "LISTADO DE MOZO"
        '
        'Dg_Proveedores
        '
        Me.Dg_Proveedores.AllowUserToAddRows = False
        Me.Dg_Proveedores.AllowUserToDeleteRows = False
        Me.Dg_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Proveedores.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Dg_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Proveedores.ColumnHeadersHeight = 26
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Proveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_Proveedores.EnableHeadersVisualStyles = False
        Me.Dg_Proveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Dg_Proveedores.Location = New System.Drawing.Point(9, 14)
        Me.Dg_Proveedores.Name = "Dg_Proveedores"
        Me.Dg_Proveedores.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Proveedores.RowHeadersVisible = False
        Me.Dg_Proveedores.RowHeadersWidth = 30
        Me.Dg_Proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Proveedores.Size = New System.Drawing.Size(766, 266)
        Me.Dg_Proveedores.TabIndex = 0
        '
        'groupPanel1
        '
        Me.groupPanel1.AutoScroll = True
        Me.groupPanel1.BackColor = System.Drawing.Color.White
        Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel1.Controls.Add(Me.txttelefonoNatu)
        Me.groupPanel1.Controls.Add(Me.txtDNI)
        Me.groupPanel1.Controls.Add(Me.TextBox1)
        Me.groupPanel1.Controls.Add(Me.ButtonNuevo)
        Me.groupPanel1.Controls.Add(Me.ButttonModificar)
        Me.groupPanel1.Controls.Add(Me.ButtonRegistrar)
        Me.groupPanel1.Controls.Add(Me.RadioButtonInactivo)
        Me.groupPanel1.Controls.Add(Me.RadioButtonActivo)
        Me.groupPanel1.Controls.Add(Me.txtdire)
        Me.groupPanel1.Controls.Add(Me.txtemail)
        Me.groupPanel1.Controls.Add(Me.txtnomcomp)
        Me.groupPanel1.Controls.Add(Me.Label7)
        Me.groupPanel1.Controls.Add(Me.Label6)
        Me.groupPanel1.Controls.Add(Me.Label5)
        Me.groupPanel1.Controls.Add(Me.Label4)
        Me.groupPanel1.Controls.Add(Me.Label3)
        Me.groupPanel1.Controls.Add(Me.Label1)
        Me.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupPanel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Location = New System.Drawing.Point(6, 5)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(791, 166)
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
        Me.groupPanel1.Text = "DATOS DEL MOZO"
        '
        'txttelefonoNatu
        '
        Me.txttelefonoNatu.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txttelefonoNatu.Border.Class = "TextBoxBorder"
        Me.txttelefonoNatu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttelefonoNatu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelefonoNatu.DisabledBackColor = System.Drawing.Color.White
        Me.txttelefonoNatu.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txttelefonoNatu.ForeColor = System.Drawing.Color.Black
        Me.txttelefonoNatu.Location = New System.Drawing.Point(109, 54)
        Me.txttelefonoNatu.MaxLength = 10
        Me.txttelefonoNatu.Name = "txttelefonoNatu"
        Me.txttelefonoNatu.Size = New System.Drawing.Size(118, 23)
        Me.txttelefonoNatu.TabIndex = 44
        Me.txttelefonoNatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttelefonoNatu.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonoNatu.WatermarkText = "10 digistos del 0-9"
        '
        'txtDNI
        '
        Me.txtDNI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDNI.Border.Class = "TextBoxBorder"
        Me.txtDNI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDNI.DisabledBackColor = System.Drawing.Color.White
        Me.txtDNI.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtDNI.ForeColor = System.Drawing.Color.Black
        Me.txtDNI.Location = New System.Drawing.Point(109, 16)
        Me.txtDNI.MaxLength = 9
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(118, 23)
        Me.txtDNI.TabIndex = 43
        Me.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDNI.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.WatermarkText = "9 digistos del 0-9"
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
        Me.ButtonNuevo.Location = New System.Drawing.Point(686, 16)
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
        Me.ButttonModificar.Location = New System.Drawing.Point(686, 97)
        Me.ButttonModificar.Name = "ButttonModificar"
        Me.ButttonModificar.Size = New System.Drawing.Size(92, 28)
        Me.ButttonModificar.TabIndex = 30
        Me.ButttonModificar.Text = "MODIFICAR"
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonRegistrar.FocusCuesEnabled = False
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrar.Location = New System.Drawing.Point(686, 55)
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
        Me.RadioButtonInactivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButtonInactivo.Location = New System.Drawing.Point(584, 116)
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
        Me.RadioButtonActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButtonActivo.Location = New System.Drawing.Point(584, 91)
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
        Me.txtdire.Location = New System.Drawing.Point(330, 54)
        Me.txtdire.MaxLength = 50
        Me.txtdire.Name = "txtdire"
        Me.txtdire.Size = New System.Drawing.Size(338, 23)
        Me.txtdire.TabIndex = 17
        Me.txtdire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdire.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdire.WatermarkText = "Lugar de direecion de vivienda"
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
        Me.txtemail.Location = New System.Drawing.Point(109, 92)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtemail.Size = New System.Drawing.Size(392, 41)
        Me.txtemail.TabIndex = 16
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtemail.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.WatermarkText = "Comentarios alternativos"
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
        Me.txtnomcomp.Location = New System.Drawing.Point(394, 18)
        Me.txtnomcomp.MaxLength = 30
        Me.txtnomcomp.Name = "txtnomcomp"
        Me.txtnomcomp.Size = New System.Drawing.Size(274, 23)
        Me.txtnomcomp.TabIndex = 12
        Me.txtnomcomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnomcomp.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcomp.WatermarkText = "Nombres personales del mozo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(514, 105)
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
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "OBSERVACION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(249, 62)
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
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 62)
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
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = " N° RUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(249, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE - APELLIDOS"
        '
        'WFrm_MOZO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 493)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.groupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WFrm_MOZO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO MOZO"
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPanel1.ResumeLayout(False)
        Me.groupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dg_Proveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButttonModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RadioButtonInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonActivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdire As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtemail As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtnomcomp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttelefonoNatu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDNI As DevComponents.DotNetBar.Controls.TextBoxX
End Class
