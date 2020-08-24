<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(278, 456)
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
        Me.ButtonRegistrar.Location = New System.Drawing.Point(126, 457)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(101, 40)
        Me.ButtonRegistrar.TabIndex = 16
        Me.ButtonRegistrar.Text = "INGRESAR"
        '
        'textBoxX2
        '
        Me.textBoxX2.BackColor = System.Drawing.Color.DarkRed
        '
        '
        '
        Me.textBoxX2.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.textBoxX2.Border.BorderGradientAngle = 0
        Me.textBoxX2.Border.BorderLightGradientAngle = 0
        Me.textBoxX2.Border.Class = "TextBoxBorder"
        Me.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.textBoxX2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxX2.ForeColor = System.Drawing.Color.White
        Me.textBoxX2.Location = New System.Drawing.Point(226, 171)
        Me.textBoxX2.Multiline = True
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxX2.Size = New System.Drawing.Size(125, 27)
        Me.textBoxX2.TabIndex = 15
        Me.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textBoxX1
        '
        Me.textBoxX1.BackColor = System.Drawing.Color.DarkRed
        '
        '
        '
        Me.textBoxX1.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.textBoxX1.Border.BorderGradientAngle = 0
        Me.textBoxX1.Border.BorderLightGradientAngle = 0
        Me.textBoxX1.Border.Class = "TextBoxBorder"
        Me.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.textBoxX1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxX1.ForeColor = System.Drawing.Color.White
        Me.textBoxX1.Location = New System.Drawing.Point(228, 95)
        Me.textBoxX1.Multiline = True
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.Size = New System.Drawing.Size(125, 27)
        Me.textBoxX1.TabIndex = 14
        Me.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 527)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(417, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(83, 527)
        Me.Panel2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(98, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CONTRASEÑA"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(500, 527)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 97
        Me.LineShape2.X2 = 383
        Me.LineShape2.Y1 = 212
        Me.LineShape2.Y2 = 212
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 103
        Me.LineShape1.X2 = 379
        Me.LineShape1.Y1 = 133
        Me.LineShape1.Y2 = 133
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(181, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "GEOMAFER'S"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 239)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(500, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ButtonRegistrar)
        Me.Controls.Add(Me.textBoxX2)
        Me.Controls.Add(Me.textBoxX1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonRegistrar As DevComponents.DotNetBar.ButtonX
    Private WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
