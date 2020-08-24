<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_BuscarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_BuscarProducto))
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Dg_Producto = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dg_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.PictureBox1)
        Me.GroupPanel2.Controls.Add(Me.TextBoxX7)
        Me.GroupPanel2.Controls.Add(Me.RadioButton3)
        Me.GroupPanel2.Controls.Add(Me.Dg_Producto)
        Me.GroupPanel2.Controls.Add(Me.RadioButton4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(8, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(553, 247)
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
        Me.GroupPanel2.Text = "BUSQUEDA DE PRODUCTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._8
        Me.PictureBox1.Location = New System.Drawing.Point(490, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'TextBoxX7
        '
        Me.TextBoxX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxX7.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxX7.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX7.Location = New System.Drawing.Point(314, 15)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.Size = New System.Drawing.Size(136, 23)
        Me.TextBoxX7.TabIndex = 22
        Me.TextBoxX7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxX7.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX7.WatermarkText = "Ingrese el dato a buscar"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(172, 17)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(123, 19)
        Me.RadioButton3.TabIndex = 21
        Me.RadioButton3.Text = "Codigo Producto"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Dg_Producto
        '
        Me.Dg_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Producto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Producto.ColumnHeadersHeight = 26
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Producto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Producto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_Producto.EnableHeadersVisualStyles = False
        Me.Dg_Producto.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Dg_Producto.Location = New System.Drawing.Point(12, 55)
        Me.Dg_Producto.Name = "Dg_Producto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Producto.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Producto.RowHeadersWidth = 30
        Me.Dg_Producto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Producto.Size = New System.Drawing.Size(518, 156)
        Me.Dg_Producto.TabIndex = 0
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton4.Location = New System.Drawing.Point(26, 17)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(132, 19)
        Me.RadioButton4.TabIndex = 20
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Nombre Producto"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'WFrm_BuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WFrm_BuscarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WFrm_BuscarProducto"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dg_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Dg_Producto As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
End Class
