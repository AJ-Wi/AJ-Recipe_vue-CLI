<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresa))
        Me.MedicoTextBox = New System.Windows.Forms.TextBox()
        Me.ClinicaTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.WebTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.LogoTextBox = New System.Windows.Forms.TextBox()
        Me.Cargar = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IMGno = New System.Windows.Forms.Label()
        Me.Clinica2TextBox = New System.Windows.Forms.TextBox()
        Me.Direccion2TextBox = New System.Windows.Forms.TextBox()
        Me.Telefono2TextBox = New System.Windows.Forms.TextBox()
        Me.Web2TextBox = New System.Windows.Forms.TextBox()
        Me.Correo2TextBox = New System.Windows.Forms.TextBox()
        Me.EnunciadoTextBox = New System.Windows.Forms.TextBox()
        Me.HorarioTextBox = New System.Windows.Forms.TextBox()
        Me.Horario2TextBox = New System.Windows.Forms.TextBox()
        Me.IDconfiguracionTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RegistroTextBox = New System.Windows.Forms.TextBox()
        Me.LblRegistro = New System.Windows.Forms.Label()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.SubirBdCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicoTextBox
        '
        Me.MedicoTextBox.Location = New System.Drawing.Point(10, 263)
        Me.MedicoTextBox.Name = "MedicoTextBox"
        Me.MedicoTextBox.Size = New System.Drawing.Size(491, 20)
        Me.MedicoTextBox.TabIndex = 11
        '
        'ClinicaTextBox
        '
        Me.ClinicaTextBox.Location = New System.Drawing.Point(13, 23)
        Me.ClinicaTextBox.Name = "ClinicaTextBox"
        Me.ClinicaTextBox.Size = New System.Drawing.Size(305, 20)
        Me.ClinicaTextBox.TabIndex = 1
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(13, 62)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DireccionTextBox.Size = New System.Drawing.Size(305, 65)
        Me.DireccionTextBox.TabIndex = 3
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(10, 146)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(305, 20)
        Me.TelefonoTextBox.TabIndex = 5
        '
        'WebTextBox
        '
        Me.WebTextBox.Location = New System.Drawing.Point(10, 185)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(305, 20)
        Me.WebTextBox.TabIndex = 8
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.Location = New System.Drawing.Point(10, 224)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(305, 20)
        Me.CorreoTextBox.TabIndex = 10
        '
        'LogoTextBox
        '
        Me.LogoTextBox.Location = New System.Drawing.Point(556, 457)
        Me.LogoTextBox.Name = "LogoTextBox"
        Me.LogoTextBox.Size = New System.Drawing.Size(111, 20)
        Me.LogoTextBox.TabIndex = 14
        '
        'Cargar
        '
        Me.Cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargar.Location = New System.Drawing.Point(673, 457)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(36, 20)
        Me.Cargar.TabIndex = 14
        Me.Cargar.Text = "..."
        Me.Cargar.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(556, 457)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(111, 20)
        Me.Logo.TabIndex = 38
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(566, 490)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(143, 40)
        Me.Guardar.TabIndex = 16
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Recipe.My.Resources.Resources.Medicina
        Me.PictureBox1.Location = New System.Drawing.Point(521, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'IMGno
        '
        Me.IMGno.AutoSize = True
        Me.IMGno.BackColor = System.Drawing.SystemColors.Control
        Me.IMGno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMGno.ForeColor = System.Drawing.Color.Red
        Me.IMGno.Location = New System.Drawing.Point(528, 346)
        Me.IMGno.Name = "IMGno"
        Me.IMGno.Size = New System.Drawing.Size(175, 18)
        Me.IMGno.TabIndex = 40
        Me.IMGno.Text = "Imagen no encontrada"
        Me.IMGno.Visible = False
        '
        'Clinica2TextBox
        '
        Me.Clinica2TextBox.Location = New System.Drawing.Point(340, 23)
        Me.Clinica2TextBox.Name = "Clinica2TextBox"
        Me.Clinica2TextBox.Size = New System.Drawing.Size(369, 20)
        Me.Clinica2TextBox.TabIndex = 2
        '
        'Direccion2TextBox
        '
        Me.Direccion2TextBox.Location = New System.Drawing.Point(340, 62)
        Me.Direccion2TextBox.Multiline = True
        Me.Direccion2TextBox.Name = "Direccion2TextBox"
        Me.Direccion2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Direccion2TextBox.Size = New System.Drawing.Size(369, 65)
        Me.Direccion2TextBox.TabIndex = 4
        '
        'Telefono2TextBox
        '
        Me.Telefono2TextBox.Location = New System.Drawing.Point(337, 146)
        Me.Telefono2TextBox.Name = "Telefono2TextBox"
        Me.Telefono2TextBox.Size = New System.Drawing.Size(372, 20)
        Me.Telefono2TextBox.TabIndex = 6
        '
        'Web2TextBox
        '
        Me.Web2TextBox.Location = New System.Drawing.Point(337, 185)
        Me.Web2TextBox.Name = "Web2TextBox"
        Me.Web2TextBox.Size = New System.Drawing.Size(372, 20)
        Me.Web2TextBox.TabIndex = 9
        '
        'Correo2TextBox
        '
        Me.Correo2TextBox.Location = New System.Drawing.Point(337, 224)
        Me.Correo2TextBox.Name = "Correo2TextBox"
        Me.Correo2TextBox.Size = New System.Drawing.Size(372, 20)
        Me.Correo2TextBox.TabIndex = 7
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(7, 341)
        Me.EnunciadoTextBox.Multiline = True
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(491, 80)
        Me.EnunciadoTextBox.TabIndex = 12
        '
        'HorarioTextBox
        '
        Me.HorarioTextBox.Location = New System.Drawing.Point(7, 440)
        Me.HorarioTextBox.Multiline = True
        Me.HorarioTextBox.Name = "HorarioTextBox"
        Me.HorarioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HorarioTextBox.Size = New System.Drawing.Size(235, 72)
        Me.HorarioTextBox.TabIndex = 13
        '
        'Horario2TextBox
        '
        Me.Horario2TextBox.Location = New System.Drawing.Point(263, 440)
        Me.Horario2TextBox.Multiline = True
        Me.Horario2TextBox.Name = "Horario2TextBox"
        Me.Horario2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Horario2TextBox.Size = New System.Drawing.Size(235, 72)
        Me.Horario2TextBox.TabIndex = 14
        '
        'IDconfiguracionTextBox
        '
        Me.IDconfiguracionTextBox.Location = New System.Drawing.Point(309, 468)
        Me.IDconfiguracionTextBox.Name = "IDconfiguracionTextBox"
        Me.IDconfiguracionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDconfiguracionTextBox.TabIndex = 49
        Me.IDconfiguracionTextBox.Visible = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'RegistroTextBox
        '
        Me.RegistroTextBox.Location = New System.Drawing.Point(266, 302)
        Me.RegistroTextBox.Name = "RegistroTextBox"
        Me.RegistroTextBox.Size = New System.Drawing.Size(235, 20)
        Me.RegistroTextBox.TabIndex = 54
        '
        'LblRegistro
        '
        Me.LblRegistro.AutoSize = True
        Me.LblRegistro.BackColor = System.Drawing.Color.Transparent
        Me.LblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistro.Location = New System.Drawing.Point(266, 286)
        Me.LblRegistro.Name = "LblRegistro"
        Me.LblRegistro.Size = New System.Drawing.Size(126, 13)
        Me.LblRegistro.TabIndex = 53
        Me.LblRegistro.Text = "Nº Registro M.P.P.S."
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.Location = New System.Drawing.Point(10, 302)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(235, 20)
        Me.CedulaTextBox.TabIndex = 52
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Transparent
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.Location = New System.Drawing.Point(7, 286)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(46, 13)
        Me.LblCedula.TabIndex = 51
        Me.LblCedula.Text = "Cedula"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(10, 247)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(52, 13)
        Me.label.TabIndex = 1
        Me.label.Text = "Medico:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(13, 7)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Clinica 1:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(13, 46)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Direccion 1:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(10, 130)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Telefono 1:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(10, 169)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 13)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Web 1:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(10, 208)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(59, 13)
        Me.label6.TabIndex = 11
        Me.label6.Text = "Correo 1:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(511, 461)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(39, 13)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Logo:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(340, 7)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(60, 13)
        Me.label8.TabIndex = 40
        Me.label8.Text = "Clinica 2:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(340, 46)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(76, 13)
        Me.label9.TabIndex = 41
        Me.label9.Text = "Direccion 2:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(337, 130)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(72, 13)
        Me.label10.TabIndex = 42
        Me.label10.Text = "Telefono 2:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.Transparent
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(337, 169)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(48, 13)
        Me.label11.TabIndex = 43
        Me.label11.Text = "Web 2:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.BackColor = System.Drawing.Color.Transparent
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(337, 208)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(59, 13)
        Me.label12.TabIndex = 44
        Me.label12.Text = "Correo 2:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.BackColor = System.Drawing.Color.Transparent
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(7, 325)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(71, 13)
        Me.label13.TabIndex = 45
        Me.label13.Text = "Enunciado:"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.Transparent
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(7, 424)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(63, 13)
        Me.label14.TabIndex = 46
        Me.label14.Text = "Horario 1:"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.Transparent
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(263, 424)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(59, 13)
        Me.label15.TabIndex = 47
        Me.label15.Text = "Horario2:"
        '
        'SubirBdCheckBox
        '
        Me.SubirBdCheckBox.AutoSize = True
        Me.SubirBdCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubirBdCheckBox.Location = New System.Drawing.Point(7, 522)
        Me.SubirBdCheckBox.Name = "SubirBdCheckBox"
        Me.SubirBdCheckBox.Size = New System.Drawing.Size(362, 17)
        Me.SubirBdCheckBox.TabIndex = 55
        Me.SubirBdCheckBox.Text = "Subir Base de Datos al Servidor automaticamente al cerrar."
        Me.SubirBdCheckBox.UseVisualStyleBackColor = True
        '
        'FrmEmpresa
        '
        Me.ClientSize = New System.Drawing.Size(729, 551)
        Me.Controls.Add(Me.SubirBdCheckBox)
        Me.Controls.Add(Me.RegistroTextBox)
        Me.Controls.Add(Me.LblRegistro)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.Horario2TextBox)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.HorarioTextBox)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.EnunciadoTextBox)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.Correo2TextBox)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.Web2TextBox)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Telefono2TextBox)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.Direccion2TextBox)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.Clinica2TextBox)
        Me.Controls.Add(Me.IMGno)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cargar)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.MedicoTextBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ClinicaTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.LogoTextBox)
        Me.Controls.Add(Me.IDconfiguracionTextBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Opciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cargar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clinica2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClinicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Direccion2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnunciadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Horario2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents HorarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDconfiguracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Logo As System.Windows.Forms.TextBox
    Friend WithEvents LogoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefono2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Web2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblRegistro As System.Windows.Forms.Label
    Friend WithEvents LblCedula As System.Windows.Forms.Label
    Friend WithEvents IMGno As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents label15 As System.Windows.Forms.Label
    Friend WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents label13 As System.Windows.Forms.Label
    Friend WithEvents label12 As System.Windows.Forms.Label
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents SubirBdCheckBox As System.Windows.Forms.CheckBox
End Class
