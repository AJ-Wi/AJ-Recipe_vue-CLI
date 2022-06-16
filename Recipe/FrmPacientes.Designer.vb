<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPacientes))
        Me.FichaClinica = New System.Windows.Forms.TabControl()
        Me.Identificacion = New System.Windows.Forms.TabPage()
        Me.TipoSangre = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Parentesco = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TelefonoContacto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PersonaContacto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Escolaridad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Religion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Domicilio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Residencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Origen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ocupacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EstadoCivilV = New System.Windows.Forms.CheckBox()
        Me.EstadoCivilD = New System.Windows.Forms.CheckBox()
        Me.EstadoCivilS = New System.Windows.Forms.CheckBox()
        Me.EstadoCivilC = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SexoF = New System.Windows.Forms.CheckBox()
        Me.SexoM = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Edad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        'Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        'Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Antecedentes = New System.Windows.Forms.TabPage()
        Me.PersonalesNOPatologicos = New System.Windows.Forms.GroupBox()
        Me.PersonalesDesparacitacion = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PersonalesPendientes = New System.Windows.Forms.TextBox()
        Me.PersonalesInmunizaciones = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PersonalesDeporte = New System.Windows.Forms.TextBox()
        Me.Deporte = New System.Windows.Forms.CheckBox()
        Me.PersonalesAlimentacion = New System.Windows.Forms.TextBox()
        Me.PersonalesAlcoholismo = New System.Windows.Forms.TextBox()
        Me.Alcoholismo = New System.Windows.Forms.CheckBox()
        Me.PersonalesTabaquismo = New System.Windows.Forms.TextBox()
        Me.Tabaquismo = New System.Windows.Forms.CheckBox()
        Me.PersonalesHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PersonalesDientes = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PersonalesDuchas = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PersonalesPatologicos = New System.Windows.Forms.GroupBox()
        Me.PersonalesHospitalizaciones = New System.Windows.Forms.TextBox()
        Me.Hospitalizaciones = New System.Windows.Forms.CheckBox()
        Me.PersonalesAdicciones = New System.Windows.Forms.TextBox()
        Me.Adicciones = New System.Windows.Forms.CheckBox()
        Me.PersonalesOtros = New System.Windows.Forms.TextBox()
        Me.PerOtros = New System.Windows.Forms.CheckBox()
        Me.PersonalTraumaticos = New System.Windows.Forms.TextBox()
        Me.Traumaticos = New System.Windows.Forms.CheckBox()
        Me.PersonalQuirurgico = New System.Windows.Forms.TextBox()
        Me.quirurgicos = New System.Windows.Forms.CheckBox()
        Me.PersonalTransfuncionales = New System.Windows.Forms.TextBox()
        Me.Transfuncionales = New System.Windows.Forms.CheckBox()
        Me.PersonalAlergias = New System.Windows.Forms.TextBox()
        Me.Alergias = New System.Windows.Forms.CheckBox()
        Me.PersonalActual = New System.Windows.Forms.TextBox()
        Me.Actuales = New System.Windows.Forms.CheckBox()
        Me.Familiares = New System.Windows.Forms.GroupBox()
        Me.FamiliarOtros = New System.Windows.Forms.TextBox()
        Me.FamOtros = New System.Windows.Forms.CheckBox()
        Me.FamiliarAlergicas = New System.Windows.Forms.TextBox()
        Me.Alergicas = New System.Windows.Forms.CheckBox()
        Me.FamiliarMentales = New System.Windows.Forms.TextBox()
        Me.Mentales = New System.Windows.Forms.CheckBox()
        Me.FamiliarCardiopatia = New System.Windows.Forms.TextBox()
        Me.Cardiopatia = New System.Windows.Forms.CheckBox()
        Me.FamiliarCancer = New System.Windows.Forms.TextBox()
        Me.Cancer = New System.Windows.Forms.CheckBox()
        Me.FamiliarNefropatia = New System.Windows.Forms.TextBox()
        Me.Nefropatia = New System.Windows.Forms.CheckBox()
        Me.FamiliarHipertension = New System.Windows.Forms.TextBox()
        Me.Hipertension = New System.Windows.Forms.CheckBox()
        Me.FamiliarEndocrina = New System.Windows.Forms.TextBox()
        Me.Endocrina = New System.Windows.Forms.CheckBox()
        Me.FamiliarAsma = New System.Windows.Forms.TextBox()
        Me.asma = New System.Windows.Forms.CheckBox()
        Me.FamiliarHepatopatia = New System.Windows.Forms.TextBox()
        Me.hepatopatia = New System.Windows.Forms.CheckBox()
        Me.FamiliarDiabetes = New System.Windows.Forms.TextBox()
        Me.Diabetes = New System.Windows.Forms.CheckBox()
        Me.Consultas = New System.Windows.Forms.TabPage()
        Me.ConsultasGridView = New System.Windows.Forms.DataGridView()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDRecipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FichaClinica.SuspendLayout()
        Me.Identificacion.SuspendLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Antecedentes.SuspendLayout()
        Me.PersonalesNOPatologicos.SuspendLayout()
        Me.PersonalesPatologicos.SuspendLayout()
        Me.Familiares.SuspendLayout()
        Me.Consultas.SuspendLayout()
        CType(Me.ConsultasGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FichaClinica
        '
        Me.FichaClinica.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.FichaClinica.Controls.Add(Me.Identificacion)
        Me.FichaClinica.Controls.Add(Me.Antecedentes)
        Me.FichaClinica.Controls.Add(Me.Consultas)
        Me.FichaClinica.HotTrack = True
        Me.FichaClinica.Location = New System.Drawing.Point(-2, -1)
        Me.FichaClinica.Multiline = True
        Me.FichaClinica.Name = "FichaClinica"
        Me.FichaClinica.SelectedIndex = 0
        Me.FichaClinica.Size = New System.Drawing.Size(644, 536)
        Me.FichaClinica.TabIndex = 0
        '
        'Identificacion
        '
        Me.Identificacion.Controls.Add(Me.TipoSangre)
        Me.Identificacion.Controls.Add(Me.Label24)
        Me.Identificacion.Controls.Add(Me.Cedula)
        Me.Identificacion.Controls.Add(Me.Label17)
        Me.Identificacion.Controls.Add(Me.Parentesco)
        Me.Identificacion.Controls.Add(Me.Label16)
        Me.Identificacion.Controls.Add(Me.TelefonoContacto)
        Me.Identificacion.Controls.Add(Me.Label15)
        Me.Identificacion.Controls.Add(Me.PersonaContacto)
        Me.Identificacion.Controls.Add(Me.Label14)
        Me.Identificacion.Controls.Add(Me.BtnFoto)
        Me.Identificacion.Controls.Add(Me.FechaNacimiento)
        Me.Identificacion.Controls.Add(Me.Label13)
        Me.Identificacion.Controls.Add(Me.Foto)
        Me.Identificacion.Controls.Add(Me.Email)
        Me.Identificacion.Controls.Add(Me.Label11)
        Me.Identificacion.Controls.Add(Me.Escolaridad)
        Me.Identificacion.Controls.Add(Me.Label12)
        Me.Identificacion.Controls.Add(Me.Religion)
        Me.Identificacion.Controls.Add(Me.Label10)
        Me.Identificacion.Controls.Add(Me.Telefono)
        Me.Identificacion.Controls.Add(Me.Label9)
        Me.Identificacion.Controls.Add(Me.Domicilio)
        Me.Identificacion.Controls.Add(Me.Label8)
        Me.Identificacion.Controls.Add(Me.Residencia)
        Me.Identificacion.Controls.Add(Me.Label7)
        Me.Identificacion.Controls.Add(Me.Origen)
        Me.Identificacion.Controls.Add(Me.Label6)
        Me.Identificacion.Controls.Add(Me.Ocupacion)
        Me.Identificacion.Controls.Add(Me.Label5)
        Me.Identificacion.Controls.Add(Me.EstadoCivilV)
        Me.Identificacion.Controls.Add(Me.EstadoCivilD)
        Me.Identificacion.Controls.Add(Me.EstadoCivilS)
        Me.Identificacion.Controls.Add(Me.EstadoCivilC)
        Me.Identificacion.Controls.Add(Me.Label4)
        Me.Identificacion.Controls.Add(Me.SexoF)
        Me.Identificacion.Controls.Add(Me.SexoM)
        Me.Identificacion.Controls.Add(Me.Label3)
        Me.Identificacion.Controls.Add(Me.Edad)
        Me.Identificacion.Controls.Add(Me.Label2)
        Me.Identificacion.Controls.Add(Me.Nombre)
        Me.Identificacion.Controls.Add(Me.Label1)
        ' Me.Identificacion.Controls.Add(Me.ShapeContainer1)
        Me.Identificacion.Location = New System.Drawing.Point(4, 4)
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.Padding = New System.Windows.Forms.Padding(3)
        Me.Identificacion.Size = New System.Drawing.Size(617, 528)
        Me.Identificacion.TabIndex = 0
        Me.Identificacion.Text = "Identificación"
        Me.Identificacion.UseVisualStyleBackColor = True
        '
        'TipoSangre
        '
        Me.TipoSangre.FormattingEnabled = True
        Me.TipoSangre.Items.AddRange(New Object() {"O", "O-", "A", "A-", "B", "B-", "AB", "AB-"})
        Me.TipoSangre.Location = New System.Drawing.Point(302, 151)
        Me.TipoSangre.Name = "TipoSangre"
        Me.TipoSangre.Size = New System.Drawing.Size(114, 21)
        Me.TipoSangre.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(216, 154)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Tipo de Sangre"
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(426, 28)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(166, 20)
        Me.Cedula.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(380, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Cedula"
        '
        'Parentesco
        '
        Me.Parentesco.Location = New System.Drawing.Point(400, 485)
        Me.Parentesco.Name = "Parentesco"
        Me.Parentesco.Size = New System.Drawing.Size(192, 20)
        Me.Parentesco.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(333, 488)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Parentesco"
        '
        'TelefonoContacto
        '
        Me.TelefonoContacto.Location = New System.Drawing.Point(112, 485)
        Me.TelefonoContacto.Name = "TelefonoContacto"
        Me.TelefonoContacto.Size = New System.Drawing.Size(217, 20)
        Me.TelefonoContacto.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 488)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Teléfono Contacto"
        '
        'PersonaContacto
        '
        Me.PersonaContacto.Location = New System.Drawing.Point(109, 439)
        Me.PersonaContacto.Name = "PersonaContacto"
        Me.PersonaContacto.Size = New System.Drawing.Size(483, 20)
        Me.PersonaContacto.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 442)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Persona Contacto"
        '
        'BtnFoto
        '
        Me.BtnFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFoto.Location = New System.Drawing.Point(426, 229)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(166, 39)
        Me.BtnFoto.TabIndex = 31
        Me.BtnFoto.Text = "Foto"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimiento.Location = New System.Drawing.Point(110, 73)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.FechaNacimiento.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Fecha Nacimiento"
        '
        'Foto
        '
        Me.Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Foto.Image = Global.Recipe.My.Resources.Resources.Paciente
        Me.Foto.Location = New System.Drawing.Point(426, 57)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(166, 158)
        Me.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto.TabIndex = 28
        Me.Foto.TabStop = False
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(336, 366)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(257, 20)
        Me.Email.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "E-mail"
        '
        'Escolaridad
        '
        Me.Escolaridad.Location = New System.Drawing.Point(79, 366)
        Me.Escolaridad.Name = "Escolaridad"
        Me.Escolaridad.Size = New System.Drawing.Size(204, 20)
        Me.Escolaridad.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 369)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Escolaridad"
        '
        'Religion
        '
        Me.Religion.Location = New System.Drawing.Point(346, 324)
        Me.Religion.Name = "Religion"
        Me.Religion.Size = New System.Drawing.Size(247, 20)
        Me.Religion.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Religión"
        '
        'Telefono
        '
        Me.Telefono.Location = New System.Drawing.Point(66, 324)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(217, 20)
        Me.Telefono.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Teléfono"
        '
        'Domicilio
        '
        Me.Domicilio.Location = New System.Drawing.Point(66, 283)
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Size = New System.Drawing.Size(527, 20)
        Me.Domicilio.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Domicilio"
        '
        'Residencia
        '
        Me.Residencia.Location = New System.Drawing.Point(122, 239)
        Me.Residencia.Name = "Residencia"
        Me.Residencia.Size = New System.Drawing.Size(294, 20)
        Me.Residencia.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Lugar de Residencia"
        '
        'Origen
        '
        Me.Origen.Location = New System.Drawing.Point(100, 195)
        Me.Origen.Name = "Origen"
        Me.Origen.Size = New System.Drawing.Size(316, 20)
        Me.Origen.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Lugar de Origen"
        '
        'Ocupacion
        '
        Me.Ocupacion.Location = New System.Drawing.Point(76, 151)
        Me.Ocupacion.Name = "Ocupacion"
        Me.Ocupacion.Size = New System.Drawing.Size(134, 20)
        Me.Ocupacion.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ocupación"
        '
        'EstadoCivilV
        '
        Me.EstadoCivilV.AutoSize = True
        Me.EstadoCivilV.Location = New System.Drawing.Point(331, 112)
        Me.EstadoCivilV.Name = "EstadoCivilV"
        Me.EstadoCivilV.Size = New System.Drawing.Size(65, 17)
        Me.EstadoCivilV.TabIndex = 11
        Me.EstadoCivilV.Text = "Viudo(a)"
        Me.EstadoCivilV.UseVisualStyleBackColor = True
        '
        'EstadoCivilD
        '
        Me.EstadoCivilD.AutoSize = True
        Me.EstadoCivilD.Location = New System.Drawing.Point(236, 112)
        Me.EstadoCivilD.Name = "EstadoCivilD"
        Me.EstadoCivilD.Size = New System.Drawing.Size(89, 17)
        Me.EstadoCivilD.TabIndex = 10
        Me.EstadoCivilD.Text = "Divorciado(a)"
        Me.EstadoCivilD.UseVisualStyleBackColor = True
        '
        'EstadoCivilS
        '
        Me.EstadoCivilS.AutoSize = True
        Me.EstadoCivilS.Location = New System.Drawing.Point(159, 112)
        Me.EstadoCivilS.Name = "EstadoCivilS"
        Me.EstadoCivilS.Size = New System.Drawing.Size(71, 17)
        Me.EstadoCivilS.TabIndex = 9
        Me.EstadoCivilS.Text = "Soltero(a)"
        Me.EstadoCivilS.UseVisualStyleBackColor = True
        '
        'EstadoCivilC
        '
        Me.EstadoCivilC.AutoSize = True
        Me.EstadoCivilC.Location = New System.Drawing.Point(79, 112)
        Me.EstadoCivilC.Name = "EstadoCivilC"
        Me.EstadoCivilC.Size = New System.Drawing.Size(74, 17)
        Me.EstadoCivilC.TabIndex = 8
        Me.EstadoCivilC.Text = "Casado(a)"
        Me.EstadoCivilC.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estado Civil"
        '
        'SexoF
        '
        Me.SexoF.AutoSize = True
        Me.SexoF.Location = New System.Drawing.Point(386, 75)
        Me.SexoF.Name = "SexoF"
        Me.SexoF.Size = New System.Drawing.Size(32, 17)
        Me.SexoF.TabIndex = 6
        Me.SexoF.Text = "F"
        Me.SexoF.UseVisualStyleBackColor = True
        '
        'SexoM
        '
        Me.SexoM.AutoSize = True
        Me.SexoM.Location = New System.Drawing.Point(345, 75)
        Me.SexoM.Name = "SexoM"
        Me.SexoM.Size = New System.Drawing.Size(35, 17)
        Me.SexoM.TabIndex = 5
        Me.SexoM.Text = "M"
        Me.SexoM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo"
        '
        'Edad
        '
        Me.Edad.Location = New System.Drawing.Point(254, 73)
        Me.Edad.Name = "Edad"
        Me.Edad.Size = New System.Drawing.Size(47, 20)
        Me.Edad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(61, 28)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(313, 20)
        Me.Nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'ShapeContainer1
        '

        '
        'Antecedentes
        '
        Me.Antecedentes.Controls.Add(Me.PersonalesNOPatologicos)
        Me.Antecedentes.Controls.Add(Me.PersonalesPatologicos)
        Me.Antecedentes.Controls.Add(Me.Familiares)
        Me.Antecedentes.Location = New System.Drawing.Point(4, 4)
        Me.Antecedentes.Name = "Antecedentes"
        Me.Antecedentes.Padding = New System.Windows.Forms.Padding(3)
        Me.Antecedentes.Size = New System.Drawing.Size(617, 528)
        Me.Antecedentes.TabIndex = 1
        Me.Antecedentes.Text = "Antecedentes"
        Me.Antecedentes.UseVisualStyleBackColor = True
        '
        'PersonalesNOPatologicos
        '
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesDesparacitacion)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Label23)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesPendientes)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesInmunizaciones)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Label22)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Label21)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesDeporte)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Deporte)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesAlimentacion)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesAlcoholismo)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Alcoholismo)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesTabaquismo)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Tabaquismo)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesHabitacion)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Label20)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesDientes)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Label19)
        Me.PersonalesNOPatologicos.Controls.Add(Me.PersonalesDuchas)
        Me.PersonalesNOPatologicos.Controls.Add(Me.Label18)
        Me.PersonalesNOPatologicos.Location = New System.Drawing.Point(6, 384)
        Me.PersonalesNOPatologicos.Name = "PersonalesNOPatologicos"
        Me.PersonalesNOPatologicos.Size = New System.Drawing.Size(597, 132)
        Me.PersonalesNOPatologicos.TabIndex = 44
        Me.PersonalesNOPatologicos.TabStop = False
        Me.PersonalesNOPatologicos.Text = "Personales No Patológicos"
        '
        'PersonalesDesparacitacion
        '
        Me.PersonalesDesparacitacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PersonalesDesparacitacion.Location = New System.Drawing.Point(424, 98)
        Me.PersonalesDesparacitacion.Name = "PersonalesDesparacitacion"
        Me.PersonalesDesparacitacion.Size = New System.Drawing.Size(165, 20)
        Me.PersonalesDesparacitacion.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(303, 101)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Última Desparasitación"
        '
        'PersonalesPendientes
        '
        Me.PersonalesPendientes.Location = New System.Drawing.Point(193, 98)
        Me.PersonalesPendientes.Name = "PersonalesPendientes"
        Me.PersonalesPendientes.Size = New System.Drawing.Size(104, 20)
        Me.PersonalesPendientes.TabIndex = 17
        '
        'PersonalesInmunizaciones
        '
        Me.PersonalesInmunizaciones.FormattingEnabled = True
        Me.PersonalesInmunizaciones.Items.AddRange(New Object() {"Completas", "Pendientes"})
        Me.PersonalesInmunizaciones.Location = New System.Drawing.Point(94, 98)
        Me.PersonalesInmunizaciones.Name = "PersonalesInmunizaciones"
        Me.PersonalesInmunizaciones.Size = New System.Drawing.Size(93, 21)
        Me.PersonalesInmunizaciones.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Inmunizaciones"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Alimentación"
        '
        'PersonalesDeporte
        '
        Me.PersonalesDeporte.Location = New System.Drawing.Point(382, 70)
        Me.PersonalesDeporte.Name = "PersonalesDeporte"
        Me.PersonalesDeporte.Size = New System.Drawing.Size(207, 20)
        Me.PersonalesDeporte.TabIndex = 13
        '
        'Deporte
        '
        Me.Deporte.AutoSize = True
        Me.Deporte.Location = New System.Drawing.Point(292, 72)
        Me.Deporte.Name = "Deporte"
        Me.Deporte.Size = New System.Drawing.Size(64, 17)
        Me.Deporte.TabIndex = 12
        Me.Deporte.Text = "Deporte"
        Me.Deporte.UseVisualStyleBackColor = True
        '
        'PersonalesAlimentacion
        '
        Me.PersonalesAlimentacion.Location = New System.Drawing.Point(81, 70)
        Me.PersonalesAlimentacion.Name = "PersonalesAlimentacion"
        Me.PersonalesAlimentacion.Size = New System.Drawing.Size(205, 20)
        Me.PersonalesAlimentacion.TabIndex = 11
        '
        'PersonalesAlcoholismo
        '
        Me.PersonalesAlcoholismo.Location = New System.Drawing.Point(382, 45)
        Me.PersonalesAlcoholismo.Name = "PersonalesAlcoholismo"
        Me.PersonalesAlcoholismo.Size = New System.Drawing.Size(207, 20)
        Me.PersonalesAlcoholismo.TabIndex = 9
        '
        'Alcoholismo
        '
        Me.Alcoholismo.AutoSize = True
        Me.Alcoholismo.Location = New System.Drawing.Point(292, 47)
        Me.Alcoholismo.Name = "Alcoholismo"
        Me.Alcoholismo.Size = New System.Drawing.Size(82, 17)
        Me.Alcoholismo.TabIndex = 8
        Me.Alcoholismo.Text = "Alcoholismo"
        Me.Alcoholismo.UseVisualStyleBackColor = True
        '
        'PersonalesTabaquismo
        '
        Me.PersonalesTabaquismo.Location = New System.Drawing.Point(101, 45)
        Me.PersonalesTabaquismo.Name = "PersonalesTabaquismo"
        Me.PersonalesTabaquismo.Size = New System.Drawing.Size(185, 20)
        Me.PersonalesTabaquismo.TabIndex = 7
        '
        'Tabaquismo
        '
        Me.Tabaquismo.AutoSize = True
        Me.Tabaquismo.Location = New System.Drawing.Point(11, 47)
        Me.Tabaquismo.Name = "Tabaquismo"
        Me.Tabaquismo.Size = New System.Drawing.Size(84, 17)
        Me.Tabaquismo.TabIndex = 6
        Me.Tabaquismo.Text = "Tabaquismo"
        Me.Tabaquismo.UseVisualStyleBackColor = True
        '
        'PersonalesHabitacion
        '
        Me.PersonalesHabitacion.FormattingEnabled = True
        Me.PersonalesHabitacion.Items.AddRange(New Object() {"Urbana", "Rural", "Todos los servicios", "Letrina"})
        Me.PersonalesHabitacion.Location = New System.Drawing.Point(429, 19)
        Me.PersonalesHabitacion.Name = "PersonalesHabitacion"
        Me.PersonalesHabitacion.Size = New System.Drawing.Size(160, 21)
        Me.PersonalesHabitacion.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(365, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Habitación"
        '
        'PersonalesDientes
        '
        Me.PersonalesDientes.FormattingEnabled = True
        Me.PersonalesDientes.Items.AddRange(New Object() {"1 vez al día", "2 veces al día", "3 veces al día"})
        Me.PersonalesDientes.Location = New System.Drawing.Point(238, 19)
        Me.PersonalesDientes.Name = "PersonalesDientes"
        Me.PersonalesDientes.Size = New System.Drawing.Size(121, 21)
        Me.PersonalesDientes.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(165, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Lav. Dientes"
        '
        'PersonalesDuchas
        '
        Me.PersonalesDuchas.FormattingEnabled = True
        Me.PersonalesDuchas.Items.AddRange(New Object() {"Diarias", "Cada 3 dias", "Irregular"})
        Me.PersonalesDuchas.Location = New System.Drawing.Point(56, 19)
        Me.PersonalesDuchas.Name = "PersonalesDuchas"
        Me.PersonalesDuchas.Size = New System.Drawing.Size(103, 21)
        Me.PersonalesDuchas.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Duchas"
        '
        'PersonalesPatologicos
        '
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalesHospitalizaciones)
        Me.PersonalesPatologicos.Controls.Add(Me.Hospitalizaciones)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalesAdicciones)
        Me.PersonalesPatologicos.Controls.Add(Me.Adicciones)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalesOtros)
        Me.PersonalesPatologicos.Controls.Add(Me.PerOtros)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalTraumaticos)
        Me.PersonalesPatologicos.Controls.Add(Me.Traumaticos)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalQuirurgico)
        Me.PersonalesPatologicos.Controls.Add(Me.quirurgicos)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalTransfuncionales)
        Me.PersonalesPatologicos.Controls.Add(Me.Transfuncionales)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalAlergias)
        Me.PersonalesPatologicos.Controls.Add(Me.Alergias)
        Me.PersonalesPatologicos.Controls.Add(Me.PersonalActual)
        Me.PersonalesPatologicos.Controls.Add(Me.Actuales)
        Me.PersonalesPatologicos.Location = New System.Drawing.Point(6, 167)
        Me.PersonalesPatologicos.Name = "PersonalesPatologicos"
        Me.PersonalesPatologicos.Size = New System.Drawing.Size(597, 214)
        Me.PersonalesPatologicos.TabIndex = 43
        Me.PersonalesPatologicos.TabStop = False
        Me.PersonalesPatologicos.Text = "Personales Patológicos"
        '
        'PersonalesHospitalizaciones
        '
        Me.PersonalesHospitalizaciones.Location = New System.Drawing.Point(119, 138)
        Me.PersonalesHospitalizaciones.Name = "PersonalesHospitalizaciones"
        Me.PersonalesHospitalizaciones.Size = New System.Drawing.Size(471, 20)
        Me.PersonalesHospitalizaciones.TabIndex = 37
        '
        'Hospitalizaciones
        '
        Me.Hospitalizaciones.AutoSize = True
        Me.Hospitalizaciones.Location = New System.Drawing.Point(6, 140)
        Me.Hospitalizaciones.Name = "Hospitalizaciones"
        Me.Hospitalizaciones.Size = New System.Drawing.Size(108, 17)
        Me.Hospitalizaciones.TabIndex = 36
        Me.Hospitalizaciones.Text = "Hospitalizaciones"
        Me.Hospitalizaciones.UseVisualStyleBackColor = True
        '
        'PersonalesAdicciones
        '
        Me.PersonalesAdicciones.Location = New System.Drawing.Point(119, 161)
        Me.PersonalesAdicciones.Name = "PersonalesAdicciones"
        Me.PersonalesAdicciones.Size = New System.Drawing.Size(470, 20)
        Me.PersonalesAdicciones.TabIndex = 35
        '
        'Adicciones
        '
        Me.Adicciones.AutoSize = True
        Me.Adicciones.Location = New System.Drawing.Point(6, 163)
        Me.Adicciones.Name = "Adicciones"
        Me.Adicciones.Size = New System.Drawing.Size(78, 17)
        Me.Adicciones.TabIndex = 34
        Me.Adicciones.Text = "Adicciones"
        Me.Adicciones.UseVisualStyleBackColor = True
        '
        'PersonalesOtros
        '
        Me.PersonalesOtros.Location = New System.Drawing.Point(63, 184)
        Me.PersonalesOtros.Name = "PersonalesOtros"
        Me.PersonalesOtros.Size = New System.Drawing.Size(527, 20)
        Me.PersonalesOtros.TabIndex = 33
        '
        'PerOtros
        '
        Me.PerOtros.AutoSize = True
        Me.PerOtros.Location = New System.Drawing.Point(6, 186)
        Me.PerOtros.Name = "PerOtros"
        Me.PerOtros.Size = New System.Drawing.Size(51, 17)
        Me.PerOtros.TabIndex = 32
        Me.PerOtros.Text = "Otros"
        Me.PerOtros.UseVisualStyleBackColor = True
        '
        'PersonalTraumaticos
        '
        Me.PersonalTraumaticos.Location = New System.Drawing.Point(119, 115)
        Me.PersonalTraumaticos.Name = "PersonalTraumaticos"
        Me.PersonalTraumaticos.Size = New System.Drawing.Size(471, 20)
        Me.PersonalTraumaticos.TabIndex = 31
        '
        'Traumaticos
        '
        Me.Traumaticos.AutoSize = True
        Me.Traumaticos.Location = New System.Drawing.Point(6, 117)
        Me.Traumaticos.Name = "Traumaticos"
        Me.Traumaticos.Size = New System.Drawing.Size(84, 17)
        Me.Traumaticos.TabIndex = 30
        Me.Traumaticos.Text = "Traumáticos"
        Me.Traumaticos.UseVisualStyleBackColor = True
        '
        'PersonalQuirurgico
        '
        Me.PersonalQuirurgico.Location = New System.Drawing.Point(119, 46)
        Me.PersonalQuirurgico.Name = "PersonalQuirurgico"
        Me.PersonalQuirurgico.Size = New System.Drawing.Size(471, 20)
        Me.PersonalQuirurgico.TabIndex = 29
        '
        'quirurgicos
        '
        Me.quirurgicos.AutoSize = True
        Me.quirurgicos.Location = New System.Drawing.Point(6, 48)
        Me.quirurgicos.Name = "quirurgicos"
        Me.quirurgicos.Size = New System.Drawing.Size(79, 17)
        Me.quirurgicos.TabIndex = 28
        Me.quirurgicos.Text = "Quirúrgicos"
        Me.quirurgicos.UseVisualStyleBackColor = True
        '
        'PersonalTransfuncionales
        '
        Me.PersonalTransfuncionales.Location = New System.Drawing.Point(119, 69)
        Me.PersonalTransfuncionales.Name = "PersonalTransfuncionales"
        Me.PersonalTransfuncionales.Size = New System.Drawing.Size(471, 20)
        Me.PersonalTransfuncionales.TabIndex = 27
        '
        'Transfuncionales
        '
        Me.Transfuncionales.AutoSize = True
        Me.Transfuncionales.Location = New System.Drawing.Point(6, 71)
        Me.Transfuncionales.Name = "Transfuncionales"
        Me.Transfuncionales.Size = New System.Drawing.Size(107, 17)
        Me.Transfuncionales.TabIndex = 26
        Me.Transfuncionales.Text = "Transfuncionales"
        Me.Transfuncionales.UseVisualStyleBackColor = True
        '
        'PersonalAlergias
        '
        Me.PersonalAlergias.Location = New System.Drawing.Point(120, 92)
        Me.PersonalAlergias.Name = "PersonalAlergias"
        Me.PersonalAlergias.Size = New System.Drawing.Size(470, 20)
        Me.PersonalAlergias.TabIndex = 25
        '
        'Alergias
        '
        Me.Alergias.AutoSize = True
        Me.Alergias.Location = New System.Drawing.Point(6, 94)
        Me.Alergias.Name = "Alergias"
        Me.Alergias.Size = New System.Drawing.Size(63, 17)
        Me.Alergias.TabIndex = 24
        Me.Alergias.Text = "Alergias"
        Me.Alergias.UseVisualStyleBackColor = True
        '
        'PersonalActual
        '
        Me.PersonalActual.Location = New System.Drawing.Point(119, 23)
        Me.PersonalActual.Name = "PersonalActual"
        Me.PersonalActual.Size = New System.Drawing.Size(471, 20)
        Me.PersonalActual.TabIndex = 23
        '
        'Actuales
        '
        Me.Actuales.AutoSize = True
        Me.Actuales.Location = New System.Drawing.Point(6, 25)
        Me.Actuales.Name = "Actuales"
        Me.Actuales.Size = New System.Drawing.Size(89, 17)
        Me.Actuales.TabIndex = 22
        Me.Actuales.Text = "Enf. Actuales"
        Me.Actuales.UseVisualStyleBackColor = True
        '
        'Familiares
        '
        Me.Familiares.Controls.Add(Me.FamiliarOtros)
        Me.Familiares.Controls.Add(Me.FamOtros)
        Me.Familiares.Controls.Add(Me.FamiliarAlergicas)
        Me.Familiares.Controls.Add(Me.Alergicas)
        Me.Familiares.Controls.Add(Me.FamiliarMentales)
        Me.Familiares.Controls.Add(Me.Mentales)
        Me.Familiares.Controls.Add(Me.FamiliarCardiopatia)
        Me.Familiares.Controls.Add(Me.Cardiopatia)
        Me.Familiares.Controls.Add(Me.FamiliarCancer)
        Me.Familiares.Controls.Add(Me.Cancer)
        Me.Familiares.Controls.Add(Me.FamiliarNefropatia)
        Me.Familiares.Controls.Add(Me.Nefropatia)
        Me.Familiares.Controls.Add(Me.FamiliarHipertension)
        Me.Familiares.Controls.Add(Me.Hipertension)
        Me.Familiares.Controls.Add(Me.FamiliarEndocrina)
        Me.Familiares.Controls.Add(Me.Endocrina)
        Me.Familiares.Controls.Add(Me.FamiliarAsma)
        Me.Familiares.Controls.Add(Me.asma)
        Me.Familiares.Controls.Add(Me.FamiliarHepatopatia)
        Me.Familiares.Controls.Add(Me.hepatopatia)
        Me.Familiares.Controls.Add(Me.FamiliarDiabetes)
        Me.Familiares.Controls.Add(Me.Diabetes)
        Me.Familiares.Location = New System.Drawing.Point(6, 4)
        Me.Familiares.Name = "Familiares"
        Me.Familiares.Size = New System.Drawing.Size(597, 160)
        Me.Familiares.TabIndex = 42
        Me.Familiares.TabStop = False
        Me.Familiares.Text = "Antecedentes Familiares"
        '
        'FamiliarOtros
        '
        Me.FamiliarOtros.Location = New System.Drawing.Point(63, 132)
        Me.FamiliarOtros.Name = "FamiliarOtros"
        Me.FamiliarOtros.Size = New System.Drawing.Size(527, 20)
        Me.FamiliarOtros.TabIndex = 21
        '
        'FamOtros
        '
        Me.FamOtros.AutoSize = True
        Me.FamOtros.Location = New System.Drawing.Point(6, 134)
        Me.FamOtros.Name = "FamOtros"
        Me.FamOtros.Size = New System.Drawing.Size(51, 17)
        Me.FamOtros.TabIndex = 20
        Me.FamOtros.Text = "Otros"
        Me.FamOtros.UseVisualStyleBackColor = True
        '
        'FamiliarAlergicas
        '
        Me.FamiliarAlergicas.Location = New System.Drawing.Point(103, 109)
        Me.FamiliarAlergicas.Name = "FamiliarAlergicas"
        Me.FamiliarAlergicas.Size = New System.Drawing.Size(183, 20)
        Me.FamiliarAlergicas.TabIndex = 19
        '
        'Alergicas
        '
        Me.Alergicas.AutoSize = True
        Me.Alergicas.Location = New System.Drawing.Point(6, 111)
        Me.Alergicas.Name = "Alergicas"
        Me.Alergicas.Size = New System.Drawing.Size(91, 17)
        Me.Alergicas.TabIndex = 18
        Me.Alergicas.Text = "Enf. Alérgicas"
        Me.Alergicas.UseVisualStyleBackColor = True
        '
        'FamiliarMentales
        '
        Me.FamiliarMentales.Location = New System.Drawing.Point(399, 63)
        Me.FamiliarMentales.Name = "FamiliarMentales"
        Me.FamiliarMentales.Size = New System.Drawing.Size(192, 20)
        Me.FamiliarMentales.TabIndex = 17
        '
        'Mentales
        '
        Me.Mentales.AutoSize = True
        Me.Mentales.Location = New System.Drawing.Point(292, 65)
        Me.Mentales.Name = "Mentales"
        Me.Mentales.Size = New System.Drawing.Size(91, 17)
        Me.Mentales.TabIndex = 16
        Me.Mentales.Text = "Enf. Mentales"
        Me.Mentales.UseVisualStyleBackColor = True
        '
        'FamiliarCardiopatia
        '
        Me.FamiliarCardiopatia.Location = New System.Drawing.Point(104, 40)
        Me.FamiliarCardiopatia.Name = "FamiliarCardiopatia"
        Me.FamiliarCardiopatia.Size = New System.Drawing.Size(183, 20)
        Me.FamiliarCardiopatia.TabIndex = 15
        '
        'Cardiopatia
        '
        Me.Cardiopatia.AutoSize = True
        Me.Cardiopatia.Location = New System.Drawing.Point(6, 42)
        Me.Cardiopatia.Name = "Cardiopatia"
        Me.Cardiopatia.Size = New System.Drawing.Size(81, 17)
        Me.Cardiopatia.TabIndex = 14
        Me.Cardiopatia.Text = "Cardiopatía"
        Me.Cardiopatia.UseVisualStyleBackColor = True
        '
        'FamiliarCancer
        '
        Me.FamiliarCancer.Location = New System.Drawing.Point(399, 86)
        Me.FamiliarCancer.Name = "FamiliarCancer"
        Me.FamiliarCancer.Size = New System.Drawing.Size(192, 20)
        Me.FamiliarCancer.TabIndex = 13
        '
        'Cancer
        '
        Me.Cancer.AutoSize = True
        Me.Cancer.Location = New System.Drawing.Point(292, 88)
        Me.Cancer.Name = "Cancer"
        Me.Cancer.Size = New System.Drawing.Size(60, 17)
        Me.Cancer.TabIndex = 12
        Me.Cancer.Text = "Cancer"
        Me.Cancer.UseVisualStyleBackColor = True
        '
        'FamiliarNefropatia
        '
        Me.FamiliarNefropatia.Location = New System.Drawing.Point(104, 63)
        Me.FamiliarNefropatia.Name = "FamiliarNefropatia"
        Me.FamiliarNefropatia.Size = New System.Drawing.Size(183, 20)
        Me.FamiliarNefropatia.TabIndex = 11
        '
        'Nefropatia
        '
        Me.Nefropatia.AutoSize = True
        Me.Nefropatia.Location = New System.Drawing.Point(6, 65)
        Me.Nefropatia.Name = "Nefropatia"
        Me.Nefropatia.Size = New System.Drawing.Size(77, 17)
        Me.Nefropatia.TabIndex = 10
        Me.Nefropatia.Text = "Nefropatía"
        Me.Nefropatia.UseVisualStyleBackColor = True
        '
        'FamiliarHipertension
        '
        Me.FamiliarHipertension.Location = New System.Drawing.Point(399, 17)
        Me.FamiliarHipertension.Name = "FamiliarHipertension"
        Me.FamiliarHipertension.Size = New System.Drawing.Size(192, 20)
        Me.FamiliarHipertension.TabIndex = 9
        '
        'Hipertension
        '
        Me.Hipertension.AutoSize = True
        Me.Hipertension.Location = New System.Drawing.Point(292, 19)
        Me.Hipertension.Name = "Hipertension"
        Me.Hipertension.Size = New System.Drawing.Size(85, 17)
        Me.Hipertension.TabIndex = 8
        Me.Hipertension.Text = "Hipertensión"
        Me.Hipertension.UseVisualStyleBackColor = True
        '
        'FamiliarEndocrina
        '
        Me.FamiliarEndocrina.Location = New System.Drawing.Point(399, 109)
        Me.FamiliarEndocrina.Name = "FamiliarEndocrina"
        Me.FamiliarEndocrina.Size = New System.Drawing.Size(192, 20)
        Me.FamiliarEndocrina.TabIndex = 7
        '
        'Endocrina
        '
        Me.Endocrina.AutoSize = True
        Me.Endocrina.Location = New System.Drawing.Point(292, 111)
        Me.Endocrina.Name = "Endocrina"
        Me.Endocrina.Size = New System.Drawing.Size(101, 17)
        Me.Endocrina.TabIndex = 6
        Me.Endocrina.Text = "Enf. Endócrinas"
        Me.Endocrina.UseVisualStyleBackColor = True
        '
        'FamiliarAsma
        '
        Me.FamiliarAsma.Location = New System.Drawing.Point(104, 86)
        Me.FamiliarAsma.Name = "FamiliarAsma"
        Me.FamiliarAsma.Size = New System.Drawing.Size(183, 20)
        Me.FamiliarAsma.TabIndex = 5
        '
        'asma
        '
        Me.asma.AutoSize = True
        Me.asma.Location = New System.Drawing.Point(6, 88)
        Me.asma.Name = "asma"
        Me.asma.Size = New System.Drawing.Size(52, 17)
        Me.asma.TabIndex = 4
        Me.asma.Text = "Asma"
        Me.asma.UseVisualStyleBackColor = True
        '
        'FamiliarHepatopatia
        '
        Me.FamiliarHepatopatia.Location = New System.Drawing.Point(398, 40)
        Me.FamiliarHepatopatia.Name = "FamiliarHepatopatia"
        Me.FamiliarHepatopatia.Size = New System.Drawing.Size(192, 20)
        Me.FamiliarHepatopatia.TabIndex = 3
        '
        'hepatopatia
        '
        Me.hepatopatia.AutoSize = True
        Me.hepatopatia.Location = New System.Drawing.Point(292, 42)
        Me.hepatopatia.Name = "hepatopatia"
        Me.hepatopatia.Size = New System.Drawing.Size(86, 17)
        Me.hepatopatia.TabIndex = 2
        Me.hepatopatia.Text = "Hepatopatía"
        Me.hepatopatia.UseVisualStyleBackColor = True
        '
        'FamiliarDiabetes
        '
        Me.FamiliarDiabetes.Location = New System.Drawing.Point(104, 17)
        Me.FamiliarDiabetes.Name = "FamiliarDiabetes"
        Me.FamiliarDiabetes.Size = New System.Drawing.Size(183, 20)
        Me.FamiliarDiabetes.TabIndex = 1
        '
        'Diabetes
        '
        Me.Diabetes.AutoSize = True
        Me.Diabetes.Location = New System.Drawing.Point(6, 19)
        Me.Diabetes.Name = "Diabetes"
        Me.Diabetes.Size = New System.Drawing.Size(68, 17)
        Me.Diabetes.TabIndex = 0
        Me.Diabetes.Text = "Diabetes"
        Me.Diabetes.UseVisualStyleBackColor = True
        '
        'Consultas
        '
        Me.Consultas.Controls.Add(Me.ConsultasGridView)
        Me.Consultas.Location = New System.Drawing.Point(4, 4)
        Me.Consultas.Name = "Consultas"
        Me.Consultas.Padding = New System.Windows.Forms.Padding(3)
        Me.Consultas.Size = New System.Drawing.Size(617, 528)
        Me.Consultas.TabIndex = 2
        Me.Consultas.Text = "Consultas"
        Me.Consultas.UseVisualStyleBackColor = True
        '
        'ConsultasGridView
        '
        Me.ConsultasGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ConsultasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultasGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.IDRecipe, Me.NombrePaciente, Me.Fecha, Me.Enfermedad})
        Me.ConsultasGridView.Location = New System.Drawing.Point(10, 9)
        Me.ConsultasGridView.Name = "ConsultasGridView"
        Me.ConsultasGridView.Size = New System.Drawing.Size(601, 504)
        Me.ConsultasGridView.TabIndex = 0
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(625, 445)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(61, 26)
        Me.Guardar.TabIndex = 43
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(625, 490)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(61, 26)
        Me.BtnEliminar.TabIndex = 44
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.DataPropertyName = "Eliminar"
        Me.Eliminar.HeaderText = " X"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 30
        '
        'IDRecipe
        '
        Me.IDRecipe.DataPropertyName = "IDpaciente"
        Me.IDRecipe.HeaderText = "ID"
        Me.IDRecipe.Name = "IDRecipe"
        Me.IDRecipe.ReadOnly = True
        Me.IDRecipe.Visible = False
        Me.IDRecipe.Width = 30
        '
        'NombrePaciente
        '
        Me.NombrePaciente.DataPropertyName = "Nombre"
        Me.NombrePaciente.HeaderText = "Nombre"
        Me.NombrePaciente.Name = "NombrePaciente"
        Me.NombrePaciente.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 110
        '
        'Enfermedad
        '
        Me.Enfermedad.DataPropertyName = "Enfermedad"
        Me.Enfermedad.HeaderText = "Enfermedad"
        Me.Enfermedad.Name = "Enfermedad"
        Me.Enfermedad.Width = 400
        '
        'FrmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 535)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.FichaClinica)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historia Clínica"
        Me.FichaClinica.ResumeLayout(False)
        Me.Identificacion.ResumeLayout(False)
        Me.Identificacion.PerformLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Antecedentes.ResumeLayout(False)
        Me.PersonalesNOPatologicos.ResumeLayout(False)
        Me.PersonalesNOPatologicos.PerformLayout()
        Me.PersonalesPatologicos.ResumeLayout(False)
        Me.PersonalesPatologicos.PerformLayout()
        Me.Familiares.ResumeLayout(False)
        Me.Familiares.PerformLayout()
        Me.Consultas.ResumeLayout(False)
        CType(Me.ConsultasGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FichaClinica As System.Windows.Forms.TabControl
    Friend WithEvents Identificacion As System.Windows.Forms.TabPage
    Friend WithEvents Antecedentes As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Edad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SexoF As System.Windows.Forms.CheckBox
    Friend WithEvents SexoM As System.Windows.Forms.CheckBox
    Friend WithEvents EstadoCivilC As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EstadoCivilD As System.Windows.Forms.CheckBox
    Friend WithEvents EstadoCivilS As System.Windows.Forms.CheckBox
    Friend WithEvents EstadoCivilV As System.Windows.Forms.CheckBox
    Friend WithEvents Ocupacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Residencia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Origen As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Religion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Domicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Escolaridad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Foto As System.Windows.Forms.PictureBox
    Friend WithEvents FechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnFoto As System.Windows.Forms.Button
    Friend WithEvents PersonaContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TelefonoContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Parentesco As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Familiares As System.Windows.Forms.GroupBox
    Friend WithEvents FamiliarDiabetes As System.Windows.Forms.TextBox
    Friend WithEvents Diabetes As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarHepatopatia As System.Windows.Forms.TextBox
    Friend WithEvents hepatopatia As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarAsma As System.Windows.Forms.TextBox
    Friend WithEvents asma As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarEndocrina As System.Windows.Forms.TextBox
    Friend WithEvents Endocrina As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarHipertension As System.Windows.Forms.TextBox
    Friend WithEvents Hipertension As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarNefropatia As System.Windows.Forms.TextBox
    Friend WithEvents Nefropatia As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarOtros As System.Windows.Forms.TextBox
    Friend WithEvents FamOtros As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarAlergicas As System.Windows.Forms.TextBox
    Friend WithEvents Alergicas As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarMentales As System.Windows.Forms.TextBox
    Friend WithEvents Mentales As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarCardiopatia As System.Windows.Forms.TextBox
    Friend WithEvents Cardiopatia As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliarCancer As System.Windows.Forms.TextBox
    Friend WithEvents Cancer As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalesPatologicos As System.Windows.Forms.GroupBox
    Friend WithEvents PersonalesOtros As System.Windows.Forms.TextBox
    Friend WithEvents PerOtros As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalTraumaticos As System.Windows.Forms.TextBox
    Friend WithEvents Traumaticos As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalQuirurgico As System.Windows.Forms.TextBox
    Friend WithEvents quirurgicos As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalTransfuncionales As System.Windows.Forms.TextBox
    Friend WithEvents Transfuncionales As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalAlergias As System.Windows.Forms.TextBox
    Friend WithEvents Alergias As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalActual As System.Windows.Forms.TextBox
    Friend WithEvents Actuales As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalesHospitalizaciones As System.Windows.Forms.TextBox
    Friend WithEvents Hospitalizaciones As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalesAdicciones As System.Windows.Forms.TextBox
    Friend WithEvents Adicciones As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalesNOPatologicos As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PersonalesDuchas As System.Windows.Forms.ComboBox
    Friend WithEvents PersonalesDientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PersonalesHabitacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Tabaquismo As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalesTabaquismo As System.Windows.Forms.TextBox
    Friend WithEvents PersonalesAlcoholismo As System.Windows.Forms.TextBox
    Friend WithEvents Alcoholismo As System.Windows.Forms.CheckBox
    Friend WithEvents PersonalesAlimentacion As System.Windows.Forms.TextBox
    Friend WithEvents PersonalesDeporte As System.Windows.Forms.TextBox
    Friend WithEvents Deporte As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PersonalesInmunizaciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PersonalesPendientes As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PersonalesDesparacitacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents TipoSangre As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Consultas As System.Windows.Forms.TabPage
    Friend WithEvents ConsultasGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDRecipe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrePaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Enfermedad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
