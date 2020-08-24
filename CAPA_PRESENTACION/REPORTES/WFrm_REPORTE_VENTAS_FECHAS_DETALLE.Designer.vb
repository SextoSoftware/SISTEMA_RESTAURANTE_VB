<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_VENTAS_FECHAS_DETALLE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_VENTAS_FECHAS_DETALLE))
        Me.PA_ReporteVentasFechasDetalladoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_ReporteVentasFechasDetalladoTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteVentasFechasDetalladoTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PA_ReporteVentasFechasDetalladoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteVentasFechasDetalladoBindingSource
        '
        Me.PA_ReporteVentasFechasDetalladoBindingSource.DataMember = "PA_ReporteVentasFechasDetallado"
        Me.PA_ReporteVentasFechasDetalladoBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteVentasFechasDetalladoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Reporte_Ventas_Fechas_Detallado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 34)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(976, 487)
        Me.ReportViewer1.TabIndex = 0
        '
        'PA_ReporteVentasFechasDetalladoTableAdapter
        '
        Me.PA_ReporteVentasFechasDetalladoTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(687, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(397, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "AL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-1, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "SELECCIONE FECHAS"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(425, 4)
        Me.DateTimePicker2.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(253, 22)
        Me.DateTimePicker2.TabIndex = 99
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 4)
        Me.DateTimePicker1.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 22)
        Me.DateTimePicker1.TabIndex = 98
        '
        'WFrm_REPORTE_VENTAS_FECHAS_DETALLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 514)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(994, 553)
        Me.MinimumSize = New System.Drawing.Size(994, 553)
        Me.Name = "WFrm_REPORTE_VENTAS_FECHAS_DETALLE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Ingresos Detallado de Ventas"
        CType(Me.PA_ReporteVentasFechasDetalladoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteVentasFechasDetalladoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents PA_ReporteVentasFechasDetalladoTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteVentasFechasDetalladoTableAdapter
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
