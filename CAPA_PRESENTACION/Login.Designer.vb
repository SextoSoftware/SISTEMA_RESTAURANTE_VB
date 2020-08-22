<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(310, 221)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(101, 40)
        Me.ButtonX1.TabIndex = 17
        Me.ButtonX1.Text = "CERRAR"
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonRegistrar.FocusCuesEnabled = False
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrar.Location = New System.Drawing.Point(195, 220)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(101, 40)
        Me.ButtonRegistrar.TabIndex = 16
        Me.ButtonRegistrar.Text = "INGRESAR"
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
        Me.textBoxX2.Location = New System.Drawing.Point(291, 114)
        Me.textBoxX2.Multiline = True
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxX2.Size = New System.Drawing.Size(125, 27)
        Me.textBoxX2.TabIndex = 15
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
        Me.textBoxX1.Location = New System.Drawing.Point(291, 71)
        Me.textBoxX1.Multiline = True
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.Size = New System.Drawing.Size(125, 27)
        Me.textBoxX1.TabIndex = 14
        Me.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(291, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 27)
        Me.Panel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources.logotipo
        Me.PictureBox1.Location = New System.Drawing.Point(19, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CAPA_PRESENTACION.My.Resources.Resources.LOGINX
        Me.ClientSize = New System.Drawing.Size(426, 279)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ButtonRegistrar)
        Me.Controls.Add(Me.textBoxX2)
        Me.Controls.Add(Me.textBoxX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Private WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
