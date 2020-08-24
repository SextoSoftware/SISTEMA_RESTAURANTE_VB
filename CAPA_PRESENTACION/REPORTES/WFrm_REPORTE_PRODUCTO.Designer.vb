<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_PRODUCTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_PRODUCTO))
        Me.PA_ReporteProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_ReporteProductosTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteProductosTableAdapter()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PA_ReporteProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteProductosBindingSource
        '
        Me.PA_ReporteProductosBindingSource.DataMember = "PA_ReporteProductos"
        Me.PA_ReporteProductosBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteProductosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Reporte_Productos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(728, 402)
        Me.ReportViewer1.TabIndex = 0
        '
        'PA_ReporteProductosTableAdapter
        '
        Me.PA_ReporteProductosTableAdapter.ClearBeforeFill = True
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 17
        Me.ComboBoxEx1.Location = New System.Drawing.Point(189, 3)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(119, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 3
        Me.ComboBoxEx1.WatermarkText = "Seleccione"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(314, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "O"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "SELECIONE TIPO PRODUCTO"
        '
        'WFrm_REPORTE_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 433)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxEx1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(740, 472)
        Me.MinimumSize = New System.Drawing.Size(740, 472)
        Me.Name = "WFrm_REPORTE_PRODUCTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte : Productos"
        CType(Me.PA_ReporteProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents PA_ReporteProductosTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_ReporteProductosTableAdapter
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
