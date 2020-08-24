<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_VENTAS_FECHAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_VENTAS_FECHAS))
        Me.PA_ReporteVentasFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PA_ReporteVentasFechasTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteVentasFechasTableAdapter()
        CType(Me.PA_ReporteVentasFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteVentasFechasBindingSource
        '
        Me.PA_ReporteVentasFechasBindingSource.DataMember = "PA_ReporteVentasFechas"
        Me.PA_ReporteVentasFechasBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(410, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "AL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "SELECCIONE FECHAS"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(438, 16)
        Me.DateTimePicker2.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(253, 23)
        Me.DateTimePicker2.TabIndex = 94
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 15)
        Me.DateTimePicker1.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 23)
        Me.DateTimePicker1.TabIndex = 93
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteVentasFechasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report_Ventas_Fechas.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(-7, 51)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(896, 479)
        Me.ReportViewer2.TabIndex = 92
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(711, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox2.TabIndex = 97
        Me.PictureBox2.TabStop = False
        '
        'PA_ReporteVentasFechasTableAdapter
        '
        Me.PA_ReporteVentasFechasTableAdapter.ClearBeforeFill = True
        '
        'WFrm_REPORTE_VENTAS_FECHAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 528)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WFrm_REPORTE_VENTAS_FECHAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO DE VENTAS POR FECHAS"
        CType(Me.PA_ReporteVentasFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteVentasFechasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents PA_ReporteVentasFechasTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteVentasFechasTableAdapter
End Class
