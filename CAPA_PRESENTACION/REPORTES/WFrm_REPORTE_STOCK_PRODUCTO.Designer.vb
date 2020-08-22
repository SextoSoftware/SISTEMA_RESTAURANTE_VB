<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_STOCK_PRODUCTO
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_STOCK_PRODUCTO))
        Me.PA_ReporteXstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtNomNatu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PA_ReporteXstockTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteXstockTableAdapter()
        CType(Me.PA_ReporteXstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteXstockBindingSource
        '
        Me.PA_ReporteXstockBindingSource.DataMember = "PA_ReporteXstock"
        Me.PA_ReporteXstockBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteXstockBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report_ProductoStock.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(-9, 43)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(965, 500)
        Me.ReportViewer2.TabIndex = 26
        '
        'txtNomNatu
        '
        '
        '
        '
        Me.txtNomNatu.Border.Class = "TextBoxBorder"
        Me.txtNomNatu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNomNatu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomNatu.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Highlighter1.SetHighlightOnFocus(Me.txtNomNatu, True)
        Me.txtNomNatu.Location = New System.Drawing.Point(216, 10)
        Me.txtNomNatu.Name = "txtNomNatu"
        Me.txtNomNatu.Size = New System.Drawing.Size(75, 23)
        Me.txtNomNatu.TabIndex = 42
        Me.txtNomNatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNomNatu.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomNatu.WatermarkText = "Ingrese dato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 15)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "INGRESE CANTIDAD DE STOCK"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(311, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'PA_ReporteXstockTableAdapter
        '
        Me.PA_ReporteXstockTableAdapter.ClearBeforeFill = True
        '
        'WFrm_REPORTE_STOCK_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 533)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNomNatu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.DoubleBuffered = True
        Me.Name = "WFrm_REPORTE_STOCK_PRODUCTO"
        Me.Text = "FORMULARIO REPORTE DE STOCK PRODUCTO"
        CType(Me.PA_ReporteXstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents txtNomNatu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PA_ReporteXstockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents PA_ReporteXstockTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteXstockTableAdapter
End Class
