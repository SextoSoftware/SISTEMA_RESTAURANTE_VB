<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_MENU_DIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_MENU_DIA))
        Me.PA_Reporte_MenuDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Restaurante = New CAPA_PRESENTACION.DataSet_Restaurante()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_Reporte_MenuDiaTableAdapter = New CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_Reporte_MenuDiaTableAdapter()
        Me.RadioButtonInactivo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActivo = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.PA_Reporte_MenuDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_Reporte_MenuDiaBindingSource
        '
        Me.PA_Reporte_MenuDiaBindingSource.DataMember = "PA_Reporte_MenuDia"
        Me.PA_Reporte_MenuDiaBindingSource.DataSource = Me.DataSet_Restaurante
        '
        'DataSet_Restaurante
        '
        Me.DataSet_Restaurante.DataSetName = "DataSet_Restaurante"
        Me.DataSet_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.LightSteelBlue
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_Reporte_MenuDiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report_MenuDiaInterno.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 30)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(519, 537)
        Me.ReportViewer1.TabIndex = 0
        '
        'PA_Reporte_MenuDiaTableAdapter
        '
        Me.PA_Reporte_MenuDiaTableAdapter.ClearBeforeFill = True
        '
        'RadioButtonInactivo
        '
        Me.RadioButtonInactivo.AutoSize = True
        Me.RadioButtonInactivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonInactivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonInactivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButtonInactivo.Location = New System.Drawing.Point(300, 6)
        Me.RadioButtonInactivo.Name = "RadioButtonInactivo"
        Me.RadioButtonInactivo.Size = New System.Drawing.Size(84, 19)
        Me.RadioButtonInactivo.TabIndex = 22
        Me.RadioButtonInactivo.Text = "EXTERNO"
        Me.RadioButtonInactivo.UseVisualStyleBackColor = False
        '
        'RadioButtonActivo
        '
        Me.RadioButtonActivo.AutoSize = True
        Me.RadioButtonActivo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonActivo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButtonActivo.Location = New System.Drawing.Point(204, 6)
        Me.RadioButtonActivo.Name = "RadioButtonActivo"
        Me.RadioButtonActivo.Size = New System.Drawing.Size(82, 19)
        Me.RadioButtonActivo.TabIndex = 21
        Me.RadioButtonActivo.TabStop = True
        Me.RadioButtonActivo.Text = "INTERNO"
        Me.RadioButtonActivo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "TIPO DE REPORTE DEL MENU"
        '
        'ReportViewer2
        '
        Me.ReportViewer2.BackColor = System.Drawing.Color.LightSteelBlue
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.PA_Reporte_MenuDiaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report_MenDia.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 30)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(519, 537)
        Me.ReportViewer2.TabIndex = 23
        '
        'WFrm_REPORTE_MENU_DIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 566)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.RadioButtonInactivo)
        Me.Controls.Add(Me.RadioButtonActivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(535, 605)
        Me.MinimumSize = New System.Drawing.Size(535, 605)
        Me.Name = "WFrm_REPORTE_MENU_DIA"
        Me.Text = "FORMULARIO REPORTE DEL MENU DEL DIA"
        CType(Me.PA_Reporte_MenuDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_Reporte_MenuDiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Restaurante As CAPA_PRESENTACION.DataSet_Restaurante
    Friend WithEvents PA_Reporte_MenuDiaTableAdapter As CAPA_PRESENTACION.DataSet_RestauranteTableAdapters.PA_Reporte_MenuDiaTableAdapter
    Friend WithEvents RadioButtonInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonActivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
