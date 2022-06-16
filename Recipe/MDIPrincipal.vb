Imports Actualizar
Imports System.Net
Imports System.ComponentModel
Imports Recipe.Entities
Imports Recipe.BusinessLayer

Public Class MDIPrincipal
    Private Configuracion As EmpresaEntity
    Dim Archivo As String = "Base de Datos"

#Region "Menu Archivo"

    Private Sub MenuNuevaEnfermedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuevaEnfermedad.Click
        Ventana = "Nueva Enfermedad"
        Nueva()
    End Sub

    Private Sub MenuNuvaTerapia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuvaTerapia.Click
        Ventana = "Nueva Terapia"
        Nueva()
    End Sub

    Private Sub MenuNuevoConsejo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuevoConsejo.Click
        Ventana = "Nuevo Consejo"
        Nueva()
    End Sub

    Private Sub MenuNuevaDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuevaDieta.Click
        Ventana = "Nueva Dieta"
        Nueva()
    End Sub

    Private Sub MenuListarEnfermedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuListarEnfermedades.Click
        Ventana = "Listar Enfermedad"
        Listar()
    End Sub

    Private Sub MenuListarTerapias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuListarTerapias.Click
        Ventana = "Listar Terapia"
        Listar()
    End Sub

    Private Sub MenuListarConsejos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuListarConsejos.Click
        Ventana = "Listar Consejo"
        Listar()
    End Sub

    Private Sub MenuListarDietas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuListarDietas.Click
        Ventana = "Listar Dieta"
        Listar()
    End Sub

    Private Sub MenuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSalir.Click
        Application.Exit()
    End Sub

    Private Sub Nueva()
        Nuevo = True
        FrmIngresarCC.MdiParent = Me
        FrmIngresarCC.Show()
    End Sub

    Private Sub Listar()
        Nuevo = False
        FrmListar.MdiParent = Me
        FrmListar.Show()
    End Sub

#End Region

#Region "Menu Recipe"

    Private Sub MenuNuevoRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuevoRecipe.Click
        RecipeN()
    End Sub

    Private Sub BotonNuevoRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonNuevoRecipe.Click
        RecipeN()
    End Sub

    Private Sub MenuRecipesPrescritos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRecipesPrescritos.Click
        RecipeP()
    End Sub

    Private Sub BotonRecipePrescritos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRecipePrescritos.Click
        RecipeP()
    End Sub

    Private Sub RecipeN()
        MenuRecipesPrescritos.Enabled = False
        BotonRecipePrescritos.Enabled = False
        FrmRecipe.MdiParent = Me
        FrmRecipe.Show()
    End Sub

    Private Sub RecipeP()
        MenuNuevoRecipe.Enabled = False
        MenuRecipesPrescritos.Enabled = False
        BotonNuevoRecipe.Enabled = False
        BotonRecipePrescritos.Enabled = False
        MenuPacientes.Enabled = False
        'Ventana = "Recipes Prescritos"
        'Listar()
        MenuEmergente.Visible = True
        CedulaTextBox.Focus()
    End Sub

#End Region

#Region "Menu Pacientes"

    Private Sub MenuNuevoPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuevoPaciente.Click
        Dim Form As New FrmPacientes(True)
        Form.MdiParent = Me
        Form.Show()
    End Sub

    Private Sub MenuBuscarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBuscarPaciente.Click
        RecipeP()
    End Sub

    Private Sub CedulaTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CedulaTextBox.KeyDown

        If e.KeyData = Keys.Enter And CedulaTextBox.Text <> Nothing Then
            Dim Form As New FrmPacientes(False, CedulaTextBox.Text)
            Form.MdiParent = Me
            Form.Show()
            CedulaTextBox.Text = Nothing
            MenuEmergente.Visible = False
        ElseIf e.KeyData = Keys.Enter And CedulaTextBox.Text = Nothing Then
            Me.CedulaTextBox.Text = Nothing
            Me.MenuEmergente.Visible = False
            Me.MenuNuevoRecipe.Enabled = True
            Me.MenuRecipesPrescritos.Enabled = True
            Me.BotonNuevoRecipe.Enabled = True
            Me.BotonRecipePrescritos.Enabled = True
            Me.MenuPacientes.Enabled = True
        End If

    End Sub

#End Region

#Region "Menu Herramientas"

    Private Sub MenuOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOpciones.Click
        FrmEmpresa.MdiParent = Me
        FrmEmpresa.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        If Tipo = "Estandar" Then
            MsgBox("Usted no tiene permisos para realizar esta operación." & vbCrLf & _
                    "Pongace en contacto co un Administrador.", MsgBoxStyle.Critical, "AVISO")
        Else
            FrmUsuarios.MdiParent = Me
            FrmUsuarios.Show()
        End If
    End Sub

    Private Sub MenuSubirBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSubirBD.Click
        Subir("Tratamientos.rsp", BdLocal)
        Me.BotonSubirBD.Visible = False
    End Sub

    Private Sub BotonSubirBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSubirBD.Click
        Subir("Tratamientos.rsp", BdLocal)
        Me.BotonSubirBD.Visible = False
    End Sub

    Private Sub MDIPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            If e.CloseReason = CloseReason.UserClosing Then
                If Me.BotonSubirBD.Visible = True Then
                    If MsgBox("La Base de Datos a sido Modificada, Desea Subirla al servidor de Actualizaciones?", MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
                        e.Cancel = True
                        Subir("Tratamientos.rsp", BdLocal)
                        Me.BotonSubirBD.Visible = False
                        Application.Exit()
                    Else
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\SubirBD", "Hay modificaciones en la base de datos", False)
                        Application.Exit()
                    End If
                End If
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Subir(ByVal ArchivoWeb As String, ByVal ArchivoLocal As String)

        Try

            My.Computer.FileSystem.WriteAllText(ActualBD, DateTime.Now.ToString, False)
            EstadoProgressBar.Visible = True
            EstadoMensajes.Text = "Subiendo " & Archivo & ", por favor espere..."
            Dim FTP As String = "ftp://a7059498@cvcell.comoj.com/public_html/Actualizaciones/Augusto/"

            Dim Client As WebClient = New WebClient()
            AddHandler Client.UploadProgressChanged, AddressOf client_ProgressChanged
            AddHandler Client.UploadFileCompleted, AddressOf client_UploadCompleted
            Client.Proxy = Nothing
            Client.Credentials = New NetworkCredential("a7059498", Cifrado.Cifrar("	9!v}xq`rry}u"))
            Client.UploadFileAsync(New Uri(FTP & ArchivoWeb), ArchivoLocal)

        Catch x As Exception
            EstadoMensajes.Text = x.Message & ". El Archivo no pudo ser enviado, intente en otro momento"
            EstadoProgressBar.Value = 0
            EstadoProgressBar.Visible = False
            MsgBox(x.Message & ". El Archivo no pudo ser enviado, intente en otro momento")
            Errores(x)
        End Try
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As UploadProgressChangedEventArgs)

        Try

            EstadoMensajes.Text = "Subiendo " & Archivo & ", por favor espere... " & e.ProgressPercentage & " % "
            EstadoProgressBar.Value = e.ProgressPercentage

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub client_UploadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)

        Try

            If Archivo = "Base de Datos" Then
                Archivo = "Identificadores"
                EstadoMensajes.Text = "Subiendo " & Archivo & ", por favor espere... "
                EstadoProgressBar.Value = 0
                Subir("ActualizacionBD.cif", ActualBD)
            Else
                EstadoProgressBar.Value = 0
                EstadoProgressBar.Visible = False
                EstadoMensajes.Text = "Base de datos subida Corectamente."
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

#End Region

#Region "Menu Ayuda"

    Private Sub MenuVerAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVerAyuda.Click

    End Sub

    Private Sub MenuSitioWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSitioWeb.Click

        Try

            Process.Start("http://cvcell.wix.com/cvcell")

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub MenuRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRegistrar.Click
        FrmRegistrar.ShowDialog()
    End Sub

    Private Sub MenuActualizaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActualizaciones.Click

        Try

            If Actualizaciones.BuscaActualizacion = True Then
                Process.Start(Application.StartupPath & "\Actualizar.exe")
            Else
                MsgBox("Usted tiene la ultima versión de Recipe Médico disponible.", MsgBoxStyle.Information, "Actualizaciones.")
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub MenuAcercade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAcercade.Click
        FrmAcecade.ShowDialog()
    End Sub

#End Region

    Public Sub ProgresoGuardar()

        Try

            EstadoProgressBar.Maximum = 102
            EstadoProgressBar.Visible = True
            EstadoMensajes.Text = "Guardando..."
            CronometroGlobal.Enabled = True

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub CronometroGlobal_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CronometroGlobal.Tick

        Try

            If EstadoProgressBar.Value >= 100 Then
                EstadoProgressBar.Value = 0
                EstadoProgressBar.Visible = False
                EstadoMensajes.Text = "Datos Guardados"
                CronometroGlobal.Enabled = False
            Else
                EstadoProgressBar.Value = EstadoProgressBar.Value + 3
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub MDIPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim detallelicencia As DetalleArchivoLicencia = ExaminarLicencia()

            Select Case detallelicencia.Estatus
                Case EstatusLicencia.LicenciaValida
                    NivelUsuario(Tipo)
                    If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\SubirBD") Then
                        Me.BotonSubirBD.Visible = True
                        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CurrentDirectory & "\SubirBD")
                    End If
                Case EstatusLicencia.LicenciaEvaluacion
                    Text = Text & " (Version de Evaluacion le quedan " & detallelicencia.DiasExpiracion & " dias de uso.)"
                    NivelUsuario(Tipo)
                Case Else
                    Text = Text & " (Compre una Nueva Licencia.)"
                    Me.MenuArchivo.Enabled = False
                    Me.MenuHerramientas.Enabled = False
                    Me.MenuRecipesPrescritos.Enabled = False
                    Me.MenuActualizaciones.Enabled = False
                    Me.BotonRecipePrescritos.Enabled = False
            End Select

            Me.MenuNivelUsuario.Text += Tipo

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub NivelUsuario(ByVal Nivel As String)

        Try

            Select Case Nivel
                Case "Estandar"
                    Me.MenuActualizaciones.Enabled = False
                    Me.MenuHerramientas.Enabled = False
                    Me.MenuNuevaDieta.Enabled = False
                    Me.MenuNuevaEnfermedad.Enabled = False
                    Me.MenuNuevoConsejo.Enabled = False
                    Me.MenuNuvaTerapia.Enabled = False
                Case "Administrador"
                    If Actualizaciones.BuscaActualizacion = True Then
                        If MsgBox("Se ha encontrado una nueva actualización de Recipe Médico," & vbCrLf & _
                                  "decea instalarla en este momento?", CType(68, MsgBoxStyle), "Actualización disponible.") = MsgBoxResult.Yes Then
                            Process.Start(Application.StartupPath & "\Actualizar.exe")
                        Else
                            EstadoMensajes.Text = "Actualización disponible."
                            Text = Text & " (Actualización disponible.)"
                        End If
                    End If
                Case "Sistema"
                    Me.MenuNivelUsuario.Text += "de "
            End Select

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class
