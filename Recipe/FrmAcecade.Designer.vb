<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcecade
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

    Friend WithEvents LogoAplicacion As System.Windows.Forms.PictureBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcecade))
        Me.LogoAplicacion = New System.Windows.Forms.PictureBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.NombreAplicacion = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.NombreCompañia = New System.Windows.Forms.Label()
        Me.AutorizadoLabel = New System.Windows.Forms.Label()
        CType(Me.LogoAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoAplicacion
        '
        Me.LogoAplicacion.Image = Global.Recipe.My.Resources.Resources.RP
        Me.LogoAplicacion.Location = New System.Drawing.Point(15, 11)
        Me.LogoAplicacion.Name = "LogoAplicacion"
        Me.LogoAplicacion.Size = New System.Drawing.Size(168, 113)
        Me.LogoAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoAplicacion.TabIndex = 0
        Me.LogoAplicacion.TabStop = False
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(15, 143)
        Me.Descripcion.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Descripcion.Size = New System.Drawing.Size(389, 86)
        Me.Descripcion.TabIndex = 5
        Me.Descripcion.TabStop = False
        Me.Descripcion.Text = resources.GetString("Descripcion.Text")
        '
        'Aceptar
        '
        Me.Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Aceptar.Location = New System.Drawing.Point(328, 237)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 6
        Me.Aceptar.Text = "&Aceptar"
        '
        'NombreAplicacion
        '
        Me.NombreAplicacion.AutoSize = True
        Me.NombreAplicacion.Location = New System.Drawing.Point(189, 23)
        Me.NombreAplicacion.Name = "NombreAplicacion"
        Me.NombreAplicacion.Size = New System.Drawing.Size(39, 13)
        Me.NombreAplicacion.TabIndex = 7
        Me.NombreAplicacion.Text = "Label1"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Location = New System.Drawing.Point(189, 45)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(39, 13)
        Me.Version.TabIndex = 8
        Me.Version.Text = "Label1"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Location = New System.Drawing.Point(189, 68)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(39, 13)
        Me.Copyright.TabIndex = 9
        Me.Copyright.Text = "Label1"
        '
        'NombreCompañia
        '
        Me.NombreCompañia.AutoSize = True
        Me.NombreCompañia.Location = New System.Drawing.Point(189, 91)
        Me.NombreCompañia.Name = "NombreCompañia"
        Me.NombreCompañia.Size = New System.Drawing.Size(39, 13)
        Me.NombreCompañia.TabIndex = 10
        Me.NombreCompañia.Text = "Label1"
        '
        'AutorizadoLabel
        '
        Me.AutorizadoLabel.AutoSize = True
        Me.AutorizadoLabel.Location = New System.Drawing.Point(12, 127)
        Me.AutorizadoLabel.Name = "AutorizadoLabel"
        Me.AutorizadoLabel.Size = New System.Drawing.Size(109, 13)
        Me.AutorizadoLabel.TabIndex = 11
        Me.AutorizadoLabel.Text = "Se Autoriza el Uso a: "
        '
        'FrmAcecade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 272)
        Me.Controls.Add(Me.AutorizadoLabel)
        Me.Controls.Add(Me.NombreCompañia)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.NombreAplicacion)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.LogoAplicacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcecade"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aceca de"
        CType(Me.LogoAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents NombreAplicacion As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents NombreCompañia As System.Windows.Forms.Label
    Friend WithEvents AutorizadoLabel As System.Windows.Forms.Label

End Class
