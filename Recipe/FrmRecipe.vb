Imports Recipe.BusinessLayer
Imports Recipe.Entities

Public Class FrmRecipe
    Private Historias As HistoriasEntity
    Private Enfermedades As EnfermedadesEntity
    Private Terapias As TerapiasEntity
    Private Dietas As DietasEntity
    Private Consejos As ConsejosEntity
    Private IDrecipe As Integer

    Private Sub FrmRecipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If ID <> 0 Then
                IDrecipe = ID
                Historias = HistoriasBU.BuscarPorId(ID)
                Formato.SelectedItem = Historias.Tipo
                Cedula.Text = Historias.Cedula
                Nombre.Text = Historias.Nombre
                Enfermedad.Text = Historias.Enfermedad
                Medicamentos.Text = Historias.Medicamentos
                Video.Text = Historias.URLVideo
                Terapia.Text = Historias.Terapia
                Dieta.Text = Historias.Dietas
                FechaEmision.Text = Historias.Fecha
                FechaNacimiento.Text = Historias.FechaNacimiento
                FechaExpiracion.Text = Historias.FechaExpiracion
                Lugar.Text = Historias.Lugar
                Me.Guardar.Text = "Editar"
            Else
                IDrecipe = 0
                Formato.SelectedItem = "Formato Normal"
                FechaEmision.Text = DateTime.Now.ToString()
                FechaExpiracion.Text = DateTime.Now.ToString()
                FechaNacimiento.Text = DateTime.Now.ToString()
                Me.ImprimirRecipe.Enabled = False
                Me.ImprimirDieta.Enabled = False
                Me.Guardar.Enabled = False
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub BtnEnfermedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnfermedad.Click
        Ventana = "Listar Enfermedad"
        Listar()
    End Sub

    Private Sub BtnTerapia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTerapia.Click
        Ventana = "Listar Terapia"
        Listar()
    End Sub

    Private Sub BtnTips_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTips.Click
        Ventana = "Listar Consejo"
        Listar()
    End Sub

    Private Sub BtnDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDieta.Click
        Ventana = "Listar Dieta"
        Listar()
    End Sub

    Private Sub Listar()

        Try

            Nuevo = True
            If FrmListar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Select Case Ventana
                    Case "Listar Enfermedad"
                        Enfermedades = EnfermedadesBU.BuscarPorId(ID)
                        Enfermedad.Text = Enfermedades.Enfermedad
                        Medicamentos.Text = Enfermedades.Medicamentos
                        Video.Text = Enfermedades.URLVideo
                    Case "Listar Terapia"
                        Terapias = TerapiasBU.BuscarPorId(ID)
                        If Terapia.Text = Nothing Then
                            Terapia.Text = "Terapia" & vbCrLf & Terapias.Terapia
                        Else
                            Terapia.Text = Terapia.Text & vbCrLf & vbCrLf & "Terapia" & vbCrLf & Terapias.Terapia
                        End If
                    Case "Listar Consejo"
                        Consejos = ConsejosBU.BuscarPorId(ID)
                        RutaImagenTextBox.Text = Consejos.RutaImagen
                        If Terapia.Text = Nothing Then
                            Terapia.Text = "Tips" & vbCrLf & Consejos.Consejo
                        Else
                            Terapia.Text = Terapia.Text & vbCrLf & vbCrLf & "Tips" & vbCrLf & Consejos.Consejo
                        End If
                    Case "Listar Dieta"
                        Dietas = DietasBU.BuscarPorId(ID)
                        Dieta.Text = Dietas.Dieta
                End Select
                ID = 0
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Formato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Formato.SelectedIndexChanged
        Try

            If Formato.SelectedIndex = 1 Then
                Label2.Enabled = True
                Lugar.Enabled = True
                Label3.Enabled = True
                FechaExpiracion.Enabled = True
                Label7.Enabled = True
                FechaNacimiento.Enabled = True
                Label10.Enabled = False
                Video.Enabled = False
                Label12.Enabled = False
                Dieta.Enabled = False
                BtnTerapia.Enabled = False
                BtnTips.Enabled = False
                BtnDieta.Enabled = False
                ImprimirRecipe.Visible = False
                Label9.Text = "Recipe:"
                Label11.Text = "Indicaciones:"
                ImprimirDieta.Text = "Imprimir Recipe"
            Else
                Label2.Enabled = False
                Lugar.Enabled = False
                Label3.Enabled = False
                FechaExpiracion.Enabled = False
                Label7.Enabled = False
                FechaNacimiento.Enabled = False
                Label10.Enabled = True
                Video.Enabled = True
                Label12.Enabled = True
                Dieta.Enabled = True
                BtnTerapia.Enabled = True
                BtnTips.Enabled = True
                BtnDieta.Enabled = True
                ImprimirRecipe.Visible = True
                Label9.Text = "Medicamentos e Indicaciones:"
                Label11.Text = "Terapias y Tips:"
                ImprimirDieta.Text = "Imprimir Dieta"
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        Try

            If Guardar.Text = "Nuevo" Then
                Dim x As Control
                For Each x In Me.Controls
                    If TypeOf x Is System.Windows.Forms.TextBox Then x.Text = ""
                    If TypeOf x Is System.Windows.Forms.RichTextBox Then x.Text = ""
                Next
                Formato.SelectedItem = "Formato Normal"
                FechaEmision.Text = DateTime.Now.ToString()
                FechaExpiracion.Text = DateTime.Now.ToString()
                FechaNacimiento.Text = DateTime.Now.ToString()
                Nombre.Focus()
                Guardar.Text = "Guardar"
            Else
                MDIPrincipal.ProgresoGuardar()
                Historias = New HistoriasEntity()
                If IDrecipe <> 0 Then
                    Historias.IDpaciente = IDrecipe
                End If
                Historias.Cedula = Cedula.Text
                Historias.Nombre = Nombre.Text
                Historias.Enfermedad = Enfermedad.Text
                Historias.Medicamentos = Medicamentos.Text
                Historias.URLVideo = Video.Text
                Historias.Terapia = Terapia.Text
                Historias.Dietas = Dieta.Text
                Historias.Fecha = FechaEmision.Text
                Historias.Tipo = Formato.Text
                Historias.Lugar = Lugar.Text
                Historias.FechaNacimiento = FechaNacimiento.Text
                Historias.FechaExpiracion = FechaExpiracion.Text
                Historias.RutaImagen = RutaImagenTextBox.Text
                Historias = HistoriasBU.Guardar(Historias)
                Me.Guardar.Text = "Nuevo"
                Me.ImprimirDieta.Enabled = True
                Me.ImprimirRecipe.Enabled = True
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub ImprimirRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirRecipe.Click

        Try

            Imagen = Historias.RutaImagen

            If Historias.RutaImagen = "" Then
                Inf = "RecipeSinImagen"
            Else
                If FrmImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Inf = "RecipeConImagen"
                Else
                    Inf = "RecipeSinImagen"
                End If
            End If
            Recipe = Historias
            FrmImprimir.ShowDialog()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub ImprimirDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirDieta.Click

        Try

            Recipe = Historias
            If ImprimirDieta.Text = "Imprimir Dieta" Then
                Inf = "Dietas"
            ElseIf ImprimirDieta.Text = "Imprimir Recipe" Then
                Inf = "Legal"
            End If
            FrmImprimir.ShowDialog()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub FrmRecipe_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.MenuRecipesPrescritos.Enabled = True
        MDIPrincipal.BotonRecipePrescritos.Enabled = True
        ID = 0
    End Sub

    Private Sub Nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombre.TextChanged
        If Me.Nombre.Text = Nothing Then
            Me.Guardar.Enabled = False
        Else
            Me.Guardar.Enabled = True
        End If
    End Sub

End Class