<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_BuscarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_BuscarProveedor))
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbusqueda = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Dg_Proveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.PictureBox1)
        Me.GroupPanel2.Controls.Add(Me.txtbusqueda)
        Me.GroupPanel2.Controls.Add(Me.RadioButton3)
        Me.GroupPanel2.Controls.Add(Me.Dg_Proveedores)
        Me.GroupPanel2.Controls.Add(Me.RadioButton4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(6, 6)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(543, 239)
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
        Me.GroupPanel2.TabIndex = 25
        Me.GroupPanel2.Text = "BUSQUEDA DE PROVEEDORES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._8
        Me.PictureBox1.Location = New System.Drawing.Point(492, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
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
        Me.txtbusqueda.Location = New System.Drawing.Point(311, 15)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(136, 23)
        Me.txtbusqueda.TabIndex = 22
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbusqueda.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.WatermarkText = "Ingrese el dato a buscar"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(177, 17)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(118, 19)
        Me.RadioButton3.TabIndex = 21
        Me.RadioButton3.Text = "Numero de Ruc"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Dg_Proveedores
        '
        Me.Dg_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Proveedores.ColumnHeadersHeight = 26
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Proveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_Proveedores.EnableHeadersVisualStyles = False
        Me.Dg_Proveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Dg_Proveedores.Location = New System.Drawing.Point(9, 50)
        Me.Dg_Proveedores.Name = "Dg_Proveedores"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Proveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Proveedores.RowHeadersWidth = 30
        Me.Dg_Proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Proveedores.Size = New System.Drawing.Size(518, 156)
        Me.Dg_Proveedores.TabIndex = 0
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton4.Location = New System.Drawing.Point(23, 17)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(137, 19)
        Me.RadioButton4.TabIndex = 20
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Nombre Compañia"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'WFrm_BuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 254)
        Me.Controls.Add(Me.GroupPanel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WFrm_BuscarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO BUSCAR PROVEDORES"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dg_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtbusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Dg_Proveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
