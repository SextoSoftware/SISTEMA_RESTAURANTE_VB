<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_COMANDA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_COMANDA))
        Me.PA_ReporteComandaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_ReporteComandaTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteComandaTableAdapter()
        CType(Me.PA_ReporteComandaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteComandaBindingSource
        '
        Me.PA_ReporteComandaBindingSource.DataMember = "PA_ReporteComanda"
        Me.PA_ReporteComandaBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteComandaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report_Comanda.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(679, 572)
        Me.ReportViewer2.TabIndex = 24
        '
        'PA_ReporteComandaTableAdapter
        '
        Me.PA_ReporteComandaTableAdapter.ClearBeforeFill = True
        '
        'WFrm_REPORTE_COMANDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 572)
        Me.Controls.Add(Me.ReportViewer2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WFrm_REPORTE_COMANDA"
        Me.Text = "WFrm_REPORTE_COMANDA"
        CType(Me.PA_ReporteComandaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteComandaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents PA_ReporteComandaTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteComandaTableAdapter
End Class
