<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevaEnfermedad = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuvaTerapia = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevoConsejo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevaDieta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuListarEnfermedades = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuListarTerapias = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuListarConsejos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuListarDietas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRecipe = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevoRecipe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuRecipesPrescritos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevoPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBuscarPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHerramientas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSubirBD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVerAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSitioWeb = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuRegistrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuActualizaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuAcercade = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNivelUsuario = New System.Windows.Forms.ToolStripTextBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.BotonNuevoRecipe = New System.Windows.Forms.ToolStripButton()
        Me.BotonRecipePrescritos = New System.Windows.Forms.ToolStripButton()
        Me.BotonSubirBD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.EstadoMensajes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EstadoProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CronometroGlobal = New System.Windows.Forms.Timer(Me.components)
        Me.MenuEmergente = New System.Windows.Forms.MenuStrip()
        Me.CedulaTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BarraMenu.SuspendLayout()
        Me.BarraHerramientas.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.MenuEmergente.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraMenu.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuArchivo, Me.MenuRecipe, Me.MenuPacientes, Me.MenuHerramientas, Me.MenuAyuda, Me.MenuNivelUsuario})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(775, 25)
        Me.BarraMenu.TabIndex = 5
        Me.BarraMenu.Text = "MenuStrip"
        '
        'MenuArchivo
        '
        Me.MenuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevaEnfermedad, Me.MenuNuvaTerapia, Me.MenuNuevoConsejo, Me.MenuNuevaDieta, Me.ToolStripSeparator3, Me.MenuListarEnfermedades, Me.MenuListarTerapias, Me.MenuListarConsejos, Me.MenuListarDietas, Me.ToolStripSeparator4, Me.MenuSalir})
        Me.MenuArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuArchivo.Name = "MenuArchivo"
        Me.MenuArchivo.Size = New System.Drawing.Size(63, 21)
        Me.MenuArchivo.Text = "&Archivo"
        '
        'MenuNuevaEnfermedad
        '
        Me.MenuNuevaEnfermedad.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuNuevaEnfermedad.Name = "MenuNuevaEnfermedad"
        Me.MenuNuevaEnfermedad.Size = New System.Drawing.Size(195, 22)
        Me.MenuNuevaEnfermedad.Text = "Nueva Enfermedad"
        '
        'MenuNuvaTerapia
        '
        Me.MenuNuvaTerapia.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuNuvaTerapia.Name = "MenuNuvaTerapia"
        Me.MenuNuvaTerapia.Size = New System.Drawing.Size(195, 22)
        Me.MenuNuvaTerapia.Text = "Nueva Terapia"
        '
        'MenuNuevoConsejo
        '
        Me.MenuNuevoConsejo.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuNuevoConsejo.Name = "MenuNuevoConsejo"
        Me.MenuNuevoConsejo.Size = New System.Drawing.Size(195, 22)
        Me.MenuNuevoConsejo.Text = "Nuevo Consejo"
        '
        'MenuNuevaDieta
        '
        Me.MenuNuevaDieta.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuNuevaDieta.Name = "MenuNuevaDieta"
        Me.MenuNuevaDieta.Size = New System.Drawing.Size(195, 22)
        Me.MenuNuevaDieta.Text = "Nueva Dieta"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'MenuListarEnfermedades
        '
        Me.MenuListarEnfermedades.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuListarEnfermedades.Name = "MenuListarEnfermedades"
        Me.MenuListarEnfermedades.Size = New System.Drawing.Size(195, 22)
        Me.MenuListarEnfermedades.Text = "Listar Enfermedades"
        '
        'MenuListarTerapias
        '
        Me.MenuListarTerapias.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuListarTerapias.Name = "MenuListarTerapias"
        Me.MenuListarTerapias.Size = New System.Drawing.Size(195, 22)
        Me.MenuListarTerapias.Text = "Listar Terapias"
        '
        'MenuListarConsejos
        '
        Me.MenuListarConsejos.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuListarConsejos.Name = "MenuListarConsejos"
        Me.MenuListarConsejos.Size = New System.Drawing.Size(195, 22)
        Me.MenuListarConsejos.Text = "Listar Consejos"
        '
        'MenuListarDietas
        '
        Me.MenuListarDietas.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuListarDietas.Name = "MenuListarDietas"
        Me.MenuListarDietas.Size = New System.Drawing.Size(195, 22)
        Me.MenuListarDietas.Text = "Listar Dietas"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(195, 22)
        Me.MenuSalir.Text = "&Salir"
        '
        'MenuRecipe
        '
        Me.MenuRecipe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevoRecipe, Me.ToolStripSeparator6, Me.MenuRecipesPrescritos})
        Me.MenuRecipe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuRecipe.Name = "MenuRecipe"
        Me.MenuRecipe.Size = New System.Drawing.Size(59, 21)
        Me.MenuRecipe.Text = "&Recipe"
        '
        'MenuNuevoRecipe
        '
        Me.MenuNuevoRecipe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuNuevoRecipe.Image = Global.Recipe.My.Resources.Resources.Recipe
        Me.MenuNuevoRecipe.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuNuevoRecipe.Name = "MenuNuevoRecipe"
        Me.MenuNuevoRecipe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuNuevoRecipe.Size = New System.Drawing.Size(204, 22)
        Me.MenuNuevoRecipe.Text = "Nuevo Recipe"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(201, 6)
        '
        'MenuRecipesPrescritos
        '
        Me.MenuRecipesPrescritos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuRecipesPrescritos.Image = Global.Recipe.My.Resources.Resources.RecipePrescritos
        Me.MenuRecipesPrescritos.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuRecipesPrescritos.Name = "MenuRecipesPrescritos"
        Me.MenuRecipesPrescritos.Size = New System.Drawing.Size(204, 22)
        Me.MenuRecipesPrescritos.Text = "Recipes Prescritos"
        '
        'MenuPacientes
        '
        Me.MenuPacientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevoPaciente, Me.MenuBuscarPaciente})
        Me.MenuPacientes.Name = "MenuPacientes"
        Me.MenuPacientes.Size = New System.Drawing.Size(74, 21)
        Me.MenuPacientes.Text = "Pacientes"
        '
        'MenuNuevoPaciente
        '
        Me.MenuNuevoPaciente.Name = "MenuNuevoPaciente"
        Me.MenuNuevoPaciente.Size = New System.Drawing.Size(166, 22)
        Me.MenuNuevoPaciente.Text = "Nuevo Paciente"
        '
        'MenuBuscarPaciente
        '
        Me.MenuBuscarPaciente.Name = "MenuBuscarPaciente"
        Me.MenuBuscarPaciente.Size = New System.Drawing.Size(166, 22)
        Me.MenuBuscarPaciente.Text = "Buscar Paciente"
        '
        'MenuHerramientas
        '
        Me.MenuHerramientas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOpciones, Me.UsuariosToolStripMenuItem, Me.ToolStripSeparator1, Me.MenuSubirBD})
        Me.MenuHerramientas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuHerramientas.Name = "MenuHerramientas"
        Me.MenuHerramientas.Size = New System.Drawing.Size(98, 21)
        Me.MenuHerramientas.Text = "&Herramientas"
        '
        'MenuOpciones
        '
        Me.MenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Size = New System.Drawing.Size(131, 22)
        Me.MenuOpciones.Text = "Opciones"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'MenuSubirBD
        '
        Me.MenuSubirBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuSubirBD.Image = Global.Recipe.My.Resources.Resources.SubirNube
        Me.MenuSubirBD.Name = "MenuSubirBD"
        Me.MenuSubirBD.Size = New System.Drawing.Size(131, 22)
        Me.MenuSubirBD.Text = "Subir BD"
        '
        'MenuAyuda
        '
        Me.MenuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuVerAyuda, Me.ToolStripSeparator7, Me.MenuSitioWeb, Me.ToolStripSeparator5, Me.MenuRegistrar, Me.MenuActualizaciones, Me.ToolStripSeparator8, Me.MenuAcercade})
        Me.MenuAyuda.Name = "MenuAyuda"
        Me.MenuAyuda.Size = New System.Drawing.Size(56, 21)
        Me.MenuAyuda.Text = "Ay&uda"
        '
        'MenuVerAyuda
        '
        Me.MenuVerAyuda.Name = "MenuVerAyuda"
        Me.MenuVerAyuda.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.MenuVerAyuda.Size = New System.Drawing.Size(225, 22)
        Me.MenuVerAyuda.Text = "Ver la Ayuda"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(222, 6)
        '
        'MenuSitioWeb
        '
        Me.MenuSitioWeb.Name = "MenuSitioWeb"
        Me.MenuSitioWeb.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.MenuSitioWeb.Size = New System.Drawing.Size(225, 22)
        Me.MenuSitioWeb.Text = "Sitio Web"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(222, 6)
        '
        'MenuRegistrar
        '
        Me.MenuRegistrar.Name = "MenuRegistrar"
        Me.MenuRegistrar.Size = New System.Drawing.Size(225, 22)
        Me.MenuRegistrar.Text = "Registrar Producto"
        '
        'MenuActualizaciones
        '
        Me.MenuActualizaciones.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuActualizaciones.Name = "MenuActualizaciones"
        Me.MenuActualizaciones.Size = New System.Drawing.Size(225, 22)
        Me.MenuActualizaciones.Text = "Buscar Actualizaciones"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(222, 6)
        '
        'MenuAcercade
        '
        Me.MenuAcercade.Name = "MenuAcercade"
        Me.MenuAcercade.Size = New System.Drawing.Size(225, 22)
        Me.MenuAcercade.Text = "Acerca de Recipe Medico"
        '
        'MenuNivelUsuario
        '
        Me.MenuNivelUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MenuNivelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MenuNivelUsuario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuNivelUsuario.Name = "MenuNivelUsuario"
        Me.MenuNivelUsuario.Size = New System.Drawing.Size(120, 21)
        Me.MenuNivelUsuario.Text = "Usuario "
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(60, 60)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonNuevoRecipe, Me.BotonRecipePrescritos, Me.BotonSubirBD})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 25)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(775, 82)
        Me.BarraHerramientas.TabIndex = 6
        Me.BarraHerramientas.Text = "ToolStrip"
        '
        'BotonNuevoRecipe
        '
        Me.BotonNuevoRecipe.Image = Global.Recipe.My.Resources.Resources.Recipe
        Me.BotonNuevoRecipe.ImageTransparentColor = System.Drawing.Color.Black
        Me.BotonNuevoRecipe.Name = "BotonNuevoRecipe"
        Me.BotonNuevoRecipe.Size = New System.Drawing.Size(84, 79)
        Me.BotonNuevoRecipe.Text = "Nuevo Recipe"
        Me.BotonNuevoRecipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BotonNuevoRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BotonRecipePrescritos
        '
        Me.BotonRecipePrescritos.Image = Global.Recipe.My.Resources.Resources.RecipePrescritos
        Me.BotonRecipePrescritos.ImageTransparentColor = System.Drawing.Color.Black
        Me.BotonRecipePrescritos.Name = "BotonRecipePrescritos"
        Me.BotonRecipePrescritos.Size = New System.Drawing.Size(105, 79)
        Me.BotonRecipePrescritos.Text = "Recipes Prescritos"
        Me.BotonRecipePrescritos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BotonRecipePrescritos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BotonSubirBD
        '
        Me.BotonSubirBD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BotonSubirBD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BotonSubirBD.Image = Global.Recipe.My.Resources.Resources.SubirBD
        Me.BotonSubirBD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonSubirBD.Name = "BotonSubirBD"
        Me.BotonSubirBD.Size = New System.Drawing.Size(64, 79)
        Me.BotonSubirBD.Text = "Subir BD"
        Me.BotonSubirBD.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 82)
        '
        'BarraEstado
        '
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoMensajes, Me.EstadoProgressBar})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 752)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(775, 22)
        Me.BarraEstado.TabIndex = 7
        Me.BarraEstado.Text = "StatusStrip"
        '
        'EstadoMensajes
        '
        Me.EstadoMensajes.Name = "EstadoMensajes"
        Me.EstadoMensajes.Size = New System.Drawing.Size(42, 17)
        Me.EstadoMensajes.Text = "Estado"
        '
        'EstadoProgressBar
        '
        Me.EstadoProgressBar.Name = "EstadoProgressBar"
        Me.EstadoProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.EstadoProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.EstadoProgressBar.Visible = False
        '
        'CronometroGlobal
        '
        Me.CronometroGlobal.Interval = 1
        '
        'MenuEmergente
        '
        Me.MenuEmergente.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuEmergente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CedulaTextBox})
        Me.MenuEmergente.Location = New System.Drawing.Point(0, 108)
        Me.MenuEmergente.Name = "MenuEmergente"
        Me.MenuEmergente.Size = New System.Drawing.Size(302, 27)
        Me.MenuEmergente.TabIndex = 9
        Me.MenuEmergente.Text = "MenuStrip1"
        Me.MenuEmergente.Visible = False
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(200, 23)
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 774)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.BarraMenu)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.MenuEmergente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.BarraMenu
        Me.Name = "MDIPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipe Médico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.MenuEmergente.ResumeLayout(False)
        Me.MenuEmergente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuVerAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActualizaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuAcercade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuOpciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents EstadoMensajes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents BotonNuevoRecipe As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents BotonRecipePrescritos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevaEnfermedad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuListarEnfermedades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuRecipe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevoRecipe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuRecipesPrescritos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHerramientas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuNuvaTerapia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevaDieta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevoConsejo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuListarTerapias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuListarConsejos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuListarDietas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuSubirBD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuSitioWeb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents CronometroGlobal As System.Windows.Forms.Timer
    Friend WithEvents BotonSubirBD As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuNivelUsuario As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuRegistrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPacientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevoPaciente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBuscarPaciente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmergente As System.Windows.Forms.MenuStrip
    Friend WithEvents CedulaTextBox As System.Windows.Forms.ToolStripTextBox

End Class
