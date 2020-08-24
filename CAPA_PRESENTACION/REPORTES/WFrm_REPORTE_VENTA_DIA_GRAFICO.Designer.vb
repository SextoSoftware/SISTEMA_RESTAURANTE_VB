<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_VENTA_DIA_GRAFICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_VENTA_DIA_GRAFICO))
        Me.PA_ReporteVentasDiasGraficoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_ReporteVentasDiasGraficoTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteVentasDiasGraficoTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PA_ReporteVentasDiasGraficoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteVentasDiasGraficoBindingSource
        '
        Me.PA_ReporteVentasDiasGraficoBindingSource.DataMember = "PA_ReporteVentasDiasGrafico"
        Me.PA_ReporteVentasDiasGraficoBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteVentasDiasGraficoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Reporte_Ventas_Dias_Grafico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 32)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1129, 453)
        Me.ReportViewer1.TabIndex = 0
        '
        'PA_ReporteVentasDiasGraficoTableAdapter
        '
        Me.PA_ReporteVentasDiasGraficoTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = """MMMM yyyy"""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(147, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "SELECCIONE FECHAS"
        '
        'WFrm_REPORTE_VENTA_DIA_GRAFICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 485)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1141, 524)
        Me.MinimumSize = New System.Drawing.Size(1141, 524)
        Me.Name = "WFrm_REPORTE_VENTA_DIA_GRAFICO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte : Ingreo de Ventas Diarias / Grafico"
        CType(Me.PA_ReporteVentasDiasGraficoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteVentasDiasGraficoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents PA_ReporteVentasDiasGraficoTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteVentasDiasGraficoTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
