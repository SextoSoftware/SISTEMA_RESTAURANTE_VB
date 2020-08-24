<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_Mesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_Mesa))
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dg_Proveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.ButttonModificar = New DevComponents.DotNetBar.ButtonX()
        Me.RadioButtonInactivo = New System.Windows.Forms.RadioButton()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.RadioButtonActivo = New System.Windows.Forms.RadioButton()
        Me.txtnom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
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
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Dg_Proveedores)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(2, 139)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(358, 337)
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
        Me.GroupPanel2.TabIndex = 28
        Me.GroupPanel2.Text = "LISTADO DE MESAS"
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
        Me.Dg_Proveedores.Location = New System.Drawing.Point(14, 12)
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
        Me.Dg_Proveedores.Size = New System.Drawing.Size(322, 294)
        Me.Dg_Proveedores.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 299)
        Me.Panel1.TabIndex = 2
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
        Me.groupPanel1.Controls.Add(Me.RadioButtonInactivo)
        Me.groupPanel1.Controls.Add(Me.ButtonRegistrar)
        Me.groupPanel1.Controls.Add(Me.RadioButtonActivo)
        Me.groupPanel1.Controls.Add(Me.txtnom)
        Me.groupPanel1.Controls.Add(Me.Label7)
        Me.groupPanel1.Controls.Add(Me.Label1)
        Me.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupPanel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Location = New System.Drawing.Point(2, 9)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(358, 122)
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
        Me.groupPanel1.TabIndex = 27
        Me.groupPanel1.Text = "DATOS DE LA MESA"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, -9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 23)
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
        Me.ButtonNuevo.Location = New System.Drawing.Point(245, 6)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(92, 25)
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
        Me.ButttonModificar.Location = New System.Drawing.Point(245, 68)
        Me.ButttonModificar.Name = "ButttonModificar"
        Me.ButttonModificar.Size = New System.Drawing.Size(92, 25)
        Me.ButttonModificar.TabIndex = 30
        Me.ButttonModificar.Text = "MODIFICAR"
        '
        'RadioButtonInactivo
        '
        Me.RadioButtonInactivo.AutoSize = True
        Me.RadioButtonInactivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonInactivo.Enabled = False
        Me.RadioButtonInactivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonInactivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Highlighter1.SetHighlightOnFocus(Me.RadioButtonInactivo, True)
        Me.RadioButtonInactivo.Location = New System.Drawing.Point(154, 63)
        Me.RadioButtonInactivo.Name = "RadioButtonInactivo"
        Me.RadioButtonInactivo.Size = New System.Drawing.Size(84, 19)
        Me.RadioButtonInactivo.TabIndex = 19
        Me.RadioButtonInactivo.Text = "INACTIVO"
        Me.RadioButtonInactivo.UseVisualStyleBackColor = False
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonRegistrar.FocusCuesEnabled = False
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.ButtonRegistrar, True)
        Me.ButtonRegistrar.Location = New System.Drawing.Point(245, 37)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(92, 25)
        Me.ButtonRegistrar.TabIndex = 29
        Me.ButtonRegistrar.Text = "REGISTRAR"
        '
        'RadioButtonActivo
        '
        Me.RadioButtonActivo.AutoSize = True
        Me.RadioButtonActivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonActivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Highlighter1.SetHighlightOnFocus(Me.RadioButtonActivo, True)
        Me.RadioButtonActivo.Location = New System.Drawing.Point(84, 64)
        Me.RadioButtonActivo.Name = "RadioButtonActivo"
        Me.RadioButtonActivo.Size = New System.Drawing.Size(70, 19)
        Me.RadioButtonActivo.TabIndex = 18
        Me.RadioButtonActivo.TabStop = True
        Me.RadioButtonActivo.Text = "ACTIVO"
        Me.RadioButtonActivo.UseVisualStyleBackColor = False
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
        Me.txtnom.Location = New System.Drawing.Point(92, 20)
        Me.txtnom.MaxLength = 30
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(129, 23)
        Me.txtnom.TabIndex = 12
        Me.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnom.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.WatermarkText = "Identificacion de la mesa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ESTADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'WFrm_Mesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 478)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.groupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(379, 517)
        Me.MinimumSize = New System.Drawing.Size(379, 517)
        Me.Name = "WFrm_Mesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO MESA"
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPanel1.ResumeLayout(False)
        Me.groupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dg_Proveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButttonModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RadioButtonInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RadioButtonActivo As System.Windows.Forms.RadioButton
    Private WithEvents txtnom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
End Class
