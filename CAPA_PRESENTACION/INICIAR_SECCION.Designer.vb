<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIAR_SECCION
    Inherits System.Windows.Forms.Form

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
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxX2
        '
        Me.textBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.textBoxX2.Border.Class = "TextBoxBorder"
        Me.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.textBoxX2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxX2.ForeColor = System.Drawing.Color.Black
        Me.highlighter1.SetHighlightOnFocus(Me.textBoxX2, True)
        Me.textBoxX2.Location = New System.Drawing.Point(286, 114)
        Me.textBoxX2.Multiline = True
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxX2.Size = New System.Drawing.Size(125, 27)
        Me.textBoxX2.TabIndex = 8
        Me.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textBoxX1
        '
        Me.textBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.textBoxX1.Border.Class = "TextBoxBorder"
        Me.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.textBoxX1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxX1.ForeColor = System.Drawing.Color.Black
        Me.highlighter1.SetHighlightOnFocus(Me.textBoxX1, True)
        Me.textBoxX1.Location = New System.Drawing.Point(286, 70)
        Me.textBoxX1.Multiline = True
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.Size = New System.Drawing.Size(125, 27)
        Me.textBoxX1.TabIndex = 7
        Me.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'highlighter1
        '
        Me.highlighter1.ContainerControl = Me
        Me.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonRegistrar.FocusCuesEnabled = False
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highlighter1.SetHighlightOnFocus(Me.ButtonRegistrar, True)
        Me.ButtonRegistrar.Location = New System.Drawing.Point(194, 215)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(101, 40)
        Me.ButtonRegistrar.TabIndex = 11
        Me.ButtonRegistrar.Text = "INGRESAR"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highlighter1.SetHighlightOnFocus(Me.ButtonX1, True)
        Me.ButtonX1.Location = New System.Drawing.Point(309, 216)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(101, 40)
        Me.ButtonX1.TabIndex = 12
        Me.ButtonX1.Text = "CERRAR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(286, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 27)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LA BARRICA CELTA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources.logotipo
        Me.PictureBox1.Location = New System.Drawing.Point(29, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'INICIAR_SECCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CAPA_PRESENTACION.My.Resources.Resources.LOGINX
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(423, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ButtonRegistrar)
        Me.Controls.Add(Me.textBoxX2)
        Me.Controls.Add(Me.textBoxX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "INICIAR_SECCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIAR_SECCION"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
