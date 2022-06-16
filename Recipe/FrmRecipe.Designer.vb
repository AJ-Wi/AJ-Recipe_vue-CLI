<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecipe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.FechaExpiracion = New System.Windows.Forms.DateTimePicker()
        Me.FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Lugar = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.Enfermedad = New System.Windows.Forms.TextBox()
        Me.Video = New System.Windows.Forms.TextBox()
        Me.Formato = New System.Windows.Forms.ComboBox()
        Me.Medicamentos = New System.Windows.Forms.RichTextBox()
        Me.Terapia = New System.Windows.Forms.RichTextBox()
        Me.Dieta = New System.Windows.Forms.RichTextBox()
        Me.BtnEnfermedad = New System.Windows.Forms.Button()
        Me.BtnTerapia = New System.Windows.Forms.Button()
        Me.BtnTips = New System.Windows.Forms.Button()
        Me.BtnDieta = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.ImprimirRecipe = New System.Windows.Forms.Button()
        Me.ImprimirDieta = New System.Windows.Forms.Button()
        Me.RutaImagenTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de Emisión:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lugar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Expiración:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(599, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cedula:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(592, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha de Nacimiento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Enfermedad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Medicamentos e Indicaciones:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Video:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Terapias y Tips:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 479)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Dieta:"
        '
        'FechaEmision
        '
        Me.FechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaEmision.Location = New System.Drawing.Point(15, 25)
        Me.FechaEmision.Name = "FechaEmision"
        Me.FechaEmision.Size = New System.Drawing.Size(116, 20)
        Me.FechaEmision.TabIndex = 12
        '
        'FechaExpiracion
        '
        Me.FechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaExpiracion.Location = New System.Drawing.Point(453, 25)
        Me.FechaExpiracion.Name = "FechaExpiracion"
        Me.FechaExpiracion.Size = New System.Drawing.Size(136, 20)
        Me.FechaExpiracion.TabIndex = 13
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimiento.Location = New System.Drawing.Point(595, 64)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(128, 20)
        Me.FechaNacimiento.TabIndex = 14
        '
        'Lugar
        '
        Me.Lugar.Location = New System.Drawing.Point(137, 25)
        Me.Lugar.Name = "Lugar"
        Me.Lugar.Size = New System.Drawing.Size(310, 20)
        Me.Lugar.TabIndex = 15
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(15, 64)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(432, 20)
        Me.Nombre.TabIndex = 16
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(453, 64)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(136, 20)
        Me.Cedula.TabIndex = 17
        '
        'Enfermedad
        '
        Me.Enfermedad.Location = New System.Drawing.Point(15, 103)
        Me.Enfermedad.Name = "Enfermedad"
        Me.Enfermedad.Size = New System.Drawing.Size(574, 20)
        Me.Enfermedad.TabIndex = 18
        '
        'Video
        '
        Me.Video.Location = New System.Drawing.Point(15, 299)
        Me.Video.Name = "Video"
        Me.Video.Size = New System.Drawing.Size(574, 20)
        Me.Video.TabIndex = 19
        '
        'Formato
        '
        Me.Formato.FormattingEnabled = True
        Me.Formato.Items.AddRange(New Object() {"Formato Normal", "Formato Legal"})
        Me.Formato.Location = New System.Drawing.Point(602, 25)
        Me.Formato.Name = "Formato"
        Me.Formato.Size = New System.Drawing.Size(121, 21)
        Me.Formato.TabIndex = 20
        '
        'Medicamentos
        '
        Me.Medicamentos.Location = New System.Drawing.Point(15, 142)
        Me.Medicamentos.Name = "Medicamentos"
        Me.Medicamentos.Size = New System.Drawing.Size(574, 138)
        Me.Medicamentos.TabIndex = 21
        Me.Medicamentos.Text = ""
        '
        'Terapia
        '
        Me.Terapia.Location = New System.Drawing.Point(15, 338)
        Me.Terapia.Name = "Terapia"
        Me.Terapia.Size = New System.Drawing.Size(574, 138)
        Me.Terapia.TabIndex = 22
        Me.Terapia.Text = ""
        '
        'Dieta
        '
        Me.Dieta.Location = New System.Drawing.Point(15, 495)
        Me.Dieta.Name = "Dieta"
        Me.Dieta.Size = New System.Drawing.Size(574, 138)
        Me.Dieta.TabIndex = 23
        Me.Dieta.Text = ""
        '
        'BtnEnfermedad
        '
        Me.BtnEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnfermedad.Location = New System.Drawing.Point(611, 103)
        Me.BtnEnfermedad.Name = "BtnEnfermedad"
        Me.BtnEnfermedad.Size = New System.Drawing.Size(92, 36)
        Me.BtnEnfermedad.TabIndex = 24
        Me.BtnEnfermedad.Text = "Enfermedad"
        Me.BtnEnfermedad.UseVisualStyleBackColor = True
        '
        'BtnTerapia
        '
        Me.BtnTerapia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTerapia.Location = New System.Drawing.Point(611, 357)
        Me.BtnTerapia.Name = "BtnTerapia"
        Me.BtnTerapia.Size = New System.Drawing.Size(92, 36)
        Me.BtnTerapia.TabIndex = 25
        Me.BtnTerapia.Text = "Terapia"
        Me.BtnTerapia.UseVisualStyleBackColor = True
        '
        'BtnTips
        '
        Me.BtnTips.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTips.Location = New System.Drawing.Point(611, 408)
        Me.BtnTips.Name = "BtnTips"
        Me.BtnTips.Size = New System.Drawing.Size(92, 36)
        Me.BtnTips.TabIndex = 26
        Me.BtnTips.Text = "Tips"
        Me.BtnTips.UseVisualStyleBackColor = True
        '
        'BtnDieta
        '
        Me.BtnDieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDieta.Location = New System.Drawing.Point(611, 495)
        Me.BtnDieta.Name = "BtnDieta"
        Me.BtnDieta.Size = New System.Drawing.Size(92, 36)
        Me.BtnDieta.TabIndex = 27
        Me.BtnDieta.Text = "Dieta"
        Me.BtnDieta.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(577, 656)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(126, 49)
        Me.Guardar.TabIndex = 28
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'ImprimirRecipe
        '
        Me.ImprimirRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirRecipe.Location = New System.Drawing.Point(313, 656)
        Me.ImprimirRecipe.Name = "ImprimirRecipe"
        Me.ImprimirRecipe.Size = New System.Drawing.Size(126, 49)
        Me.ImprimirRecipe.TabIndex = 30
        Me.ImprimirRecipe.Text = "Imprimir Recipe"
        Me.ImprimirRecipe.UseVisualStyleBackColor = True
        '
        'ImprimirDieta
        '
        Me.ImprimirDieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirDieta.Location = New System.Drawing.Point(445, 656)
        Me.ImprimirDieta.Name = "ImprimirDieta"
        Me.ImprimirDieta.Size = New System.Drawing.Size(126, 49)
        Me.ImprimirDieta.TabIndex = 31
        Me.ImprimirDieta.Text = "Imprimir Dieta"
        Me.ImprimirDieta.UseVisualStyleBackColor = True
        '
        'RutaImagenTextBox
        '
        Me.RutaImagenTextBox.Location = New System.Drawing.Point(15, 639)
        Me.RutaImagenTextBox.Name = "RutaImagenTextBox"
        Me.RutaImagenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RutaImagenTextBox.TabIndex = 32
        Me.RutaImagenTextBox.Visible = False
        '
        'FrmRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(735, 717)
        Me.Controls.Add(Me.RutaImagenTextBox)
        Me.Controls.Add(Me.ImprimirDieta)
        Me.Controls.Add(Me.ImprimirRecipe)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.BtnDieta)
        Me.Controls.Add(Me.BtnTips)
        Me.Controls.Add(Me.BtnTerapia)
        Me.Controls.Add(Me.BtnEnfermedad)
        Me.Controls.Add(Me.Dieta)
        Me.Controls.Add(Me.Terapia)
        Me.Controls.Add(Me.Medicamentos)
        Me.Controls.Add(Me.Formato)
        Me.Controls.Add(Me.Video)
        Me.Controls.Add(Me.Enfermedad)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Lugar)
        Me.Controls.Add(Me.FechaNacimiento)
        Me.Controls.Add(Me.FechaExpiracion)
        Me.Controls.Add(Me.FechaEmision)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRecipe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recipe Médico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaExpiracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lugar As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Enfermedad As System.Windows.Forms.TextBox
    Friend WithEvents Video As System.Windows.Forms.TextBox
    Friend WithEvents Formato As System.Windows.Forms.ComboBox
    Friend WithEvents Medicamentos As System.Windows.Forms.RichTextBox
    Friend WithEvents Terapia As System.Windows.Forms.RichTextBox
    Friend WithEvents Dieta As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnEnfermedad As System.Windows.Forms.Button
    Friend WithEvents BtnTerapia As System.Windows.Forms.Button
    Friend WithEvents BtnTips As System.Windows.Forms.Button
    Friend WithEvents BtnDieta As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents ImprimirRecipe As System.Windows.Forms.Button
    Friend WithEvents ImprimirDieta As System.Windows.Forms.Button
    Friend WithEvents RutaImagenTextBox As System.Windows.Forms.TextBox
End Class
