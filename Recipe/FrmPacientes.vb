Imports Recipe.BusinessLayer
Imports Recipe.Entities

Public Class FrmPacientes
    Dim PacienteNuevo As Boolean
    Dim CedulaPaciente As String

    Sub New(ByVal Parametro1 As Boolean, Optional ByVal Parametro2 As String = Nothing)
        InitializeComponent()
        PacienteNuevo = Parametro1
        CedulaPaciente = Parametro2
    End Sub

    Private Sub FrmPacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarTodo()
    End Sub

    Private Sub CargarTodo()
        Dim Paciente As PacientesEntity

        Try

            If PacienteNuevo = False Then
                ConsultasGridView.AutoGenerateColumns = False
                ConsultasGridView.DataSource = HistoriasBU.BuscarPorCedula(CedulaPaciente)
                If ConsultasGridView.RowCount = 0 Then
                    If MsgBox("El Paciente que intenta buscar no se encuentra, desea ingresarlo como uno nuevo?", MsgBoxStyle.YesNo, "A V I S O") = MsgBoxResult.Yes Then
                        FichaClinica.SelectedTab = Identificacion
                    Else
                        Me.Close()
                    End If
                Else
                    FichaClinica.SelectedTab = Consultas
                    If PacientesBU.ExisteCedula(CedulaPaciente) = True Then
                        Paciente = PacientesBU.BuscarPorCedula(CedulaPaciente)
                        Me.Cedula.Text = Paciente.Cedula
                        Me.Nombre.Text = Paciente.Nombre
                        Me.FechaNacimiento.Text = Paciente.FechaNacimiento
                        Me.Edad.Text = CStr(DateDiff(DateInterval.Year, DateTime.Now, CDate(Me.FechaNacimiento.Text)))
                        If Paciente.Sexo = "Masculino" Then Me.SexoM.Checked = True
                        If Paciente.Sexo = "Femenino" Then Me.SexoF.Checked = True
                        If Paciente.EstadoCivil = "Casado" Then Me.EstadoCivilC.Checked = True
                        If Paciente.EstadoCivil = "Divorciado" Then Me.EstadoCivilD.Checked = True
                        If Paciente.EstadoCivil = "Soltero" Then Me.EstadoCivilS.Checked = True
                        If Paciente.EstadoCivil = "Viudo" Then Me.EstadoCivilV.Checked = True
                        Me.Ocupacion.Text = Paciente.Ocupacion
                        Me.TipoSangre.Text = Paciente.TipoSangre
                        Me.Origen.Text = Paciente.LugarOrigen
                        Me.Residencia.Text = Paciente.LugarResidencia
                        Me.Domicilio.Text = Paciente.Domicilio
                        Me.Telefono.Text = Paciente.Telefono
                        Me.Religion.Text = Paciente.Religion
                        Me.Escolaridad.Text = Paciente.Escolaridad
                        Me.Email.Text = Paciente.Email
                        Me.PersonaContacto.Text = Paciente.PersonaContacto
                        Me.TelefonoContacto.Text = Paciente.TelefonoContacto
                        Me.Parentesco.Text = Paciente.ParentescoContacto

                        Me.FamiliarDiabetes.Text = Paciente.Diabetes
                        If Me.FamiliarDiabetes.Text <> Nothing Then Me.Diabetes.Checked = True

                        Me.FamiliarHipertension.Text = Paciente.Hipertension
                        If Me.FamiliarHipertension.Text <> Nothing Then Me.Hipertension.Checked = True

                        Me.FamiliarCardiopatia.Text = Paciente.Cardiopatia
                        If Me.FamiliarCardiopatia.Text <> Nothing Then Me.Cardiopatia.Checked = True

                        Me.FamiliarHepatopatia.Text = Paciente.Hepatopatia
                        If Me.FamiliarHepatopatia.Text <> Nothing Then Me.hepatopatia.Checked = True

                        Me.FamiliarNefropatia.Text = Paciente.Nefropatia
                        If Me.FamiliarNefropatia.Text <> Nothing Then Me.Nefropatia.Checked = True

                        Me.FamiliarMentales.Text = Paciente.Mentales
                        If Me.FamiliarMentales.Text <> Nothing Then Me.Mentales.Checked = True

                        Me.FamiliarAsma.Text = Paciente.Asma
                        If Me.FamiliarAsma.Text <> Nothing Then Me.asma.Checked = True

                        Me.FamiliarCancer.Text = Paciente.Cancer
                        If Me.FamiliarCancer.Text <> Nothing Then Me.Cancer.Checked = True

                        Me.FamiliarAlergicas.Text = Paciente.Alergicas
                        If Me.FamiliarAlergicas.Text <> Nothing Then Me.Alergicas.Checked = True

                        Me.FamiliarEndocrina.Text = Paciente.Endocrinas
                        If Me.FamiliarEndocrina.Text <> Nothing Then Me.Endocrina.Checked = True

                        Me.FamiliarOtros.Text = Paciente.FamiliaresOtros
                        If Me.FamiliarOtros.Text <> Nothing Then Me.FamOtros.Checked = True

                        Me.PersonalActual.Text = Paciente.Actuales
                        If Me.PersonalActual.Text <> Nothing Then Me.Actuales.Checked = True

                        Me.PersonalQuirurgico.Text = Paciente.Quirurgicos
                        If Me.PersonalQuirurgico.Text <> Nothing Then Me.quirurgicos.Checked = True

                        Me.PersonalTransfuncionales.Text = Paciente.Transfuciones
                        If Me.PersonalTransfuncionales.Text <> Nothing Then Me.Transfuncionales.Checked = True

                        Me.PersonalAlergias.Text = Paciente.Alergias
                        If Me.PersonalAlergias.Text <> Nothing Then Me.Alergias.Checked = True

                        Me.PersonalTraumaticos.Text = Paciente.Traumaticos
                        If Me.PersonalTraumaticos.Text <> Nothing Then Me.Traumaticos.Checked = True

                        Me.PersonalesHospitalizaciones.Text = Paciente.Hospitalizaciones
                        If Me.PersonalesHospitalizaciones.Text <> Nothing Then Me.Hospitalizaciones.Checked = True

                        Me.PersonalesAdicciones.Text = Paciente.Adicciones
                        If Me.PersonalesAdicciones.Text <> Nothing Then Me.Adicciones.Checked = True

                        Me.PersonalesOtros.Text = Paciente.PersonalOtros
                        If Me.PersonalesOtros.Text <> Nothing Then Me.PerOtros.Checked = True

                        Me.PersonalesDuchas.Text = Paciente.Duchas
                        Me.PersonalesDientes.Text = Paciente.Dientes
                        Me.PersonalesHabitacion.Text = Paciente.Habitacion

                        Me.PersonalesTabaquismo.Text = Paciente.Tabaquismo
                        If Me.PersonalesTabaquismo.Text <> Nothing Then Me.Tabaquismo.Checked = True

                        Me.PersonalesAlcoholismo.Text = Paciente.Alcoholismo
                        If Me.PersonalesAlcoholismo.Text <> Nothing Then Me.Alcoholismo.Checked = True

                        Me.PersonalesAlimentacion.Text = Paciente.Alimentacion

                        Me.PersonalesDeporte.Text = Paciente.Deportes
                        If Me.PersonalesDeporte.Text <> Nothing Then Me.Deporte.Checked = True

                        Me.PersonalesInmunizaciones.Text = Paciente.Inmunizaciones
                        Me.PersonalesPendientes.Text = Paciente.Pendientes
                        Me.PersonalesDesparacitacion.Text = Paciente.Desparacitacion

                    Else
                        Me.Cedula.Text = CedulaPaciente
                        Me.Nombre.Text = ConsultasGridView.CurrentRow.Cells(2).Value.ToString()
                        Paciente = New PacientesEntity
                        Paciente.Cedula = Me.Cedula.Text
                        Paciente.Nombre = Me.Nombre.Text
                        Paciente = PacientesBU.GuardarViejos(Paciente)
                    End If
                End If
            Else
                FichaClinica.SelectedTab = Identificacion
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim Paciente As New PacientesEntity
        Paciente.Cedula = Me.Cedula.Text
        Paciente.Nombre = Me.Nombre.Text
        Paciente.FechaNacimiento = Me.FechaNacimiento.Text
        If Me.SexoM.Checked = True Then Paciente.Sexo = "Masculino"
        If Me.SexoF.Checked = True Then Paciente.Sexo = "Femenino"
        If Me.EstadoCivilC.Checked = True Then Paciente.EstadoCivil = "Casado"
        If Me.EstadoCivilD.Checked = True Then Paciente.EstadoCivil = "Divorciado"
        If Me.EstadoCivilS.Checked = True Then Paciente.EstadoCivil = "Soltero"
        If Me.EstadoCivilV.Checked = True Then Paciente.EstadoCivil = "Viudo"
        Paciente.Ocupacion = Me.Ocupacion.Text
        Paciente.TipoSangre = Me.TipoSangre.Text
        Paciente.LugarOrigen = Me.Origen.Text
        Paciente.LugarResidencia = Me.Residencia.Text
        Paciente.Domicilio = Me.Domicilio.Text
        Paciente.Telefono = Me.Telefono.Text
        Paciente.Religion = Me.Religion.Text
        Paciente.Escolaridad = Me.Escolaridad.Text
        Paciente.Email = Me.Email.Text
        Paciente.PersonaContacto = Me.PersonaContacto.Text
        Paciente.TelefonoContacto = Me.TelefonoContacto.Text
        Paciente.ParentescoContacto = Me.Parentesco.Text
        Paciente.Diabetes = Me.FamiliarDiabetes.Text
        Paciente.Hipertension = Me.FamiliarHipertension.Text
        Paciente.Cardiopatia = Me.FamiliarCardiopatia.Text
        Paciente.Hepatopatia = Me.FamiliarHepatopatia.Text
        Paciente.Nefropatia = Me.FamiliarNefropatia.Text
        Paciente.Mentales = Me.FamiliarMentales.Text
        Paciente.Asma = Me.FamiliarAsma.Text
        Paciente.Cancer = Me.FamiliarCancer.Text
        Paciente.Alergicas = Me.FamiliarAlergicas.Text
        Paciente.Endocrinas = Me.FamiliarEndocrina.Text
        Paciente.FamiliaresOtros = Me.FamiliarOtros.Text
        Paciente.Actuales = Me.PersonalActual.Text
        Paciente.Quirurgicos = Me.PersonalQuirurgico.Text
        Paciente.Transfuciones = Me.PersonalTransfuncionales.Text
        Paciente.Alergias = Me.PersonalAlergias.Text
        Paciente.Traumaticos = Me.PersonalTraumaticos.Text
        Paciente.Hospitalizaciones = Me.PersonalesHospitalizaciones.Text
        Paciente.Adicciones = Me.PersonalesAdicciones.Text
        Paciente.PersonalOtros = Me.PersonalesOtros.Text
        Paciente.Duchas = Me.PersonalesDuchas.Text
        Paciente.Dientes = Me.PersonalesDientes.Text
        Paciente.Habitacion = Me.PersonalesHabitacion.Text
        Paciente.Tabaquismo = Me.PersonalesTabaquismo.Text
        Paciente.Alcoholismo = Me.PersonalesAlcoholismo.Text
        Paciente.Alimentacion = Me.PersonalesAlimentacion.Text
        Paciente.Deportes = Me.PersonalesDeporte.Text
        Paciente.Inmunizaciones = Me.PersonalesInmunizaciones.Text
        Paciente.Pendientes = Me.PersonalesPendientes.Text
        Paciente.Desparacitacion = Me.PersonalesDesparacitacion.Text

        Paciente = PacientesBU.Guardar(Paciente)
    End Sub

    Private Sub BtnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFoto.Click
        FrmCamara.ShowDialog()
        'Foto.Image.Save(My.Computer .FileSystem .CurrentDirectory & "\Imagenes\" & me.cedula.text & ".jpg")
    End Sub

    Private Sub FrmPacientes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.MenuNuevoRecipe.Enabled = True
        MDIPrincipal.MenuRecipesPrescritos.Enabled = True
        MDIPrincipal.BotonNuevoRecipe.Enabled = True
        MDIPrincipal.BotonRecipePrescritos.Enabled = True
        MDIPrincipal.MenuPacientes.Enabled = True
    End Sub

    Private Sub ConsultasGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ConsultasGridView.CellContentDoubleClick

        Try

            If e.RowIndex <> -1 Then
                ID = CInt(ConsultasGridView.CurrentRow.Cells(1).Value)
                If Nuevo = True Then
                    Me.DialogResult = DialogResult.OK
                Else
                    FrmRecipe.MdiParent = MDIPrincipal
                    FrmRecipe.Show()
                End If
                Me.Close()
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Try

            For row As Integer = 0 To ConsultasGridView.RowCount - 1
                If CBool(ConsultasGridView.Rows(row).Cells(0).Value) = True Then
                    PacientesBU.EliminarPorCedula(CStr(ConsultasGridView.Rows(row).Cells(1).Value))
                End If
            Next

            CargarTodo()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class