<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_TOP_PRODUCTOS_VEN
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_TOP_PRODUCTOS_VEN))
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PA_ReporteTopProductosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.PA_ReporteTopPlatosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PA_ReporteTopProductosVendidosFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PA_ReporteTopPlatosVendidosFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtNomNatu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PA_ReporteTopProductosVendidosTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopProductosVendidosTableAdapter()
        Me.PA_ReporteXstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PA_ReporteXstockTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteXstockTableAdapter()
        Me.PA_ReporteTopPlatosVendidosTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopPlatosVendidosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_ReporteTopProductosVendidosFechasTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopProductosVendidosFechasTableAdapter()
        Me.PA_ReporteTopPlatosVendidosFechasTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopPlatosVendidosFechasTableAdapter()
        CType(Me.PA_ReporteTopProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PA_ReporteTopPlatosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PA_ReporteTopProductosVendidosFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PA_ReporteTopPlatosVendidosFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PA_ReporteXstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteTopProductosVendidosBindingSource
        '
        Me.PA_ReporteTopProductosVendidosBindingSource.DataMember = "PA_ReporteTopProductosVendidos"
        Me.PA_ReporteTopProductosVendidosBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PA_ReporteTopPlatosVendidosBindingSource
        '
        Me.PA_ReporteTopPlatosVendidosBindingSource.DataMember = "PA_ReporteTopPlatosVendidos"
        Me.PA_ReporteTopPlatosVendidosBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'PA_ReporteTopProductosVendidosFechasBindingSource
        '
        Me.PA_ReporteTopProductosVendidosFechasBindingSource.DataMember = "PA_ReporteTopProductosVendidosFechas"
        Me.PA_ReporteTopProductosVendidosFechasBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'PA_ReporteTopPlatosVendidosFechasBindingSource
        '
        Me.PA_ReporteTopPlatosVendidosFechasBindingSource.DataMember = "PA_ReporteTopPlatosVendidosFechas"
        Me.PA_ReporteTopPlatosVendidosFechasBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteTopProductosVendidosBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.PA_ReporteTopPlatosVendidosBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Reporte_TopProductosVendidos.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(-1, 45)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1253, 423)
        Me.ReportViewer2.TabIndex = 27
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
        Me.txtNomNatu.Location = New System.Drawing.Point(198, 11)
        Me.txtNomNatu.Name = "txtNomNatu"
        Me.txtNomNatu.Size = New System.Drawing.Size(75, 23)
        Me.txtNomNatu.TabIndex = 45
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
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "INGRESE CANTIDAD DEL TOP"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(285, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'PA_ReporteTopProductosVendidosTableAdapter
        '
        Me.PA_ReporteTopProductosVendidosTableAdapter.ClearBeforeFill = True
        '
        'PA_ReporteXstockBindingSource
        '
        Me.PA_ReporteXstockBindingSource.DataMember = "PA_ReporteXstock"
        Me.PA_ReporteXstockBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'PA_ReporteXstockTableAdapter
        '
        Me.PA_ReporteXstockTableAdapter.ClearBeforeFill = True
        '
        'PA_ReporteTopPlatosVendidosTableAdapter
        '
        Me.PA_ReporteTopPlatosVendidosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(776, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "AL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(378, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "SELECCIONE FECHAS"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(804, 11)
        Me.DateTimePicker2.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(253, 23)
        Me.DateTimePicker2.TabIndex = 87
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(515, 10)
        Me.DateTimePicker1.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 23)
        Me.DateTimePicker1.TabIndex = 86
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(1077, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.PA_ReporteTopProductosVendidosFechasBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.PA_ReporteTopPlatosVendidosFechasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Reporte_TopProductosVendidosFechas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-4, 44)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1253, 423)
        Me.ReportViewer1.TabIndex = 91
        '
        'PA_ReporteTopProductosVendidosFechasTableAdapter
        '
        Me.PA_ReporteTopProductosVendidosFechasTableAdapter.ClearBeforeFill = True
        '
        'PA_ReporteTopPlatosVendidosFechasTableAdapter
        '
        Me.PA_ReporteTopPlatosVendidosFechasTableAdapter.ClearBeforeFill = True
        '
        'WFrm_REPORTE_TOP_PRODUCTOS_VEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 472)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNomNatu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.DoubleBuffered = True
        Me.Name = "WFrm_REPORTE_TOP_PRODUCTOS_VEN"
        Me.Text = "FORMULARIO REPORTE DE  TOP DE PRODUCTOS - PLATOS MAS VENDIDOS"
        CType(Me.PA_ReporteTopProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PA_ReporteTopPlatosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PA_ReporteTopProductosVendidosFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PA_ReporteTopPlatosVendidosFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PA_ReporteXstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents txtNomNatu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PA_ReporteTopProductosVendidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents PA_ReporteTopProductosVendidosTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopProductosVendidosTableAdapter
    Friend WithEvents PA_ReporteXstockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PA_ReporteXstockTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteXstockTableAdapter
    Friend WithEvents PA_ReporteTopPlatosVendidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PA_ReporteTopPlatosVendidosTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopPlatosVendidosTableAdapter
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteTopProductosVendidosFechasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PA_ReporteTopProductosVendidosFechasTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopProductosVendidosFechasTableAdapter
    Friend WithEvents PA_ReporteTopPlatosVendidosFechasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PA_ReporteTopPlatosVendidosFechasTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteTopPlatosVendidosFechasTableAdapter
End Class
