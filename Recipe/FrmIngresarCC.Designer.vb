<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresarCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresarCC))
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.LabelEnfermedad = New System.Windows.Forms.Label()
        Me.LabelVideo = New System.Windows.Forms.Label()
        Me.Enfermedad = New System.Windows.Forms.TextBox()
        Me.Video = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.RichTextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BuscarImagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(12, 48)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(78, 13)
        Me.LabelDescripcion.TabIndex = 1
        Me.LabelDescripcion.Text = "Descripción:"
        '
        'LabelEnfermedad
        '
        Me.LabelEnfermedad.AutoSize = True
        Me.LabelEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnfermedad.Location = New System.Drawing.Point(12, 9)
        Me.LabelEnfermedad.Name = "LabelEnfermedad"
        Me.LabelEnfermedad.Size = New System.Drawing.Size(78, 13)
        Me.LabelEnfermedad.TabIndex = 2
        Me.LabelEnfermedad.Text = "Enfermedad:"
        '
        'LabelVideo
        '
        Me.LabelVideo.AutoSize = True
        Me.LabelVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVideo.Location = New System.Drawing.Point(12, 486)
        Me.LabelVideo.Name = "LabelVideo"
        Me.LabelVideo.Size = New System.Drawing.Size(89, 13)
        Me.LabelVideo.TabIndex = 3
        Me.LabelVideo.Text = "Link de Video:"
        '
        'Enfermedad
        '
        Me.Enfermedad.Location = New System.Drawing.Point(15, 25)
        Me.Enfermedad.Name = "Enfermedad"
        Me.Enfermedad.Size = New System.Drawing.Size(669, 20)
        Me.Enfermedad.TabIndex = 1
        '
        'Video
        '
        Me.Video.Location = New System.Drawing.Point(15, 502)
        Me.Video.Name = "Video"
        Me.Video.Size = New System.Drawing.Size(669, 20)
        Me.Video.TabIndex = 3
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(12, 64)
        Me.Descripcion.MaxLength = 65535
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(675, 419)
        Me.Descripcion.TabIndex = 2
        Me.Descripcion.Text = ""
        '
        'Guardar
        '
        Me.Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(549, 533)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(135, 54)
        Me.Guardar.TabIndex = 4
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(408, 533)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(135, 54)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BuscarImagen
        '
        Me.BuscarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarImagen.Location = New System.Drawing.Point(660, 463)
        Me.BuscarImagen.Name = "BuscarImagen"
        Me.BuscarImagen.Size = New System.Drawing.Size(27, 23)
        Me.BuscarImagen.TabIndex = 6
        Me.BuscarImagen.Text = "..."
        Me.BuscarImagen.UseVisualStyleBackColor = True
        Me.BuscarImagen.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(130, 533)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'FrmIngresarCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 599)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BuscarImagen)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Video)
        Me.Controls.Add(Me.Enfermedad)
        Me.Controls.Add(Me.LabelVideo)
        Me.Controls.Add(Me.LabelEnfermedad)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIngresarCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDescripcion As System.Windows.Forms.Label
    Friend WithEvents LabelEnfermedad As System.Windows.Forms.Label
    Friend WithEvents LabelVideo As System.Windows.Forms.Label
    Friend WithEvents Enfermedad As System.Windows.Forms.TextBox
    Friend WithEvents Video As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BuscarImagen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
