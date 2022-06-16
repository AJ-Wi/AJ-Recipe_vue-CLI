Imports Actualizar
Imports Recipe.BusinessLayer
Imports Recipe.Entities

Public Class FrmEmpresa
    Private Empresa As EmpresaEntity

    Private Function Validaciones() As Boolean
        Dim result As Boolean = True

        Try

            Me.ErrorProvider.Clear()

            If Me.MedicoTextBox.Text = Nothing Then
                Me.ErrorProvider.SetError(Me.MedicoTextBox, "El nombre del Medico es obligatorio")
                result = False
            End If

            If Me.ClinicaTextBox.Text = Nothing Then
                Me.ErrorProvider.SetError(Me.ClinicaTextBox, "El Nombre de la Clinica 1 es obligatorio")
                result = False
            End If

            If Me.EnunciadoTextBox.Text = Nothing Then
                Me.ErrorProvider.SetError(Me.EnunciadoTextBox, "El Enunciado es obligatorio")
                result = False
            End If

            If Me.CedulaTextBox.Text = Nothing Then
                Me.ErrorProvider.SetError(Me.CedulaTextBox, "La Cedula es obligatorio")
                result = False
            End If

            If Me.RegistroTextBox.Text = Nothing Then
                Me.ErrorProvider.SetError(Me.RegistroTextBox, "El Numero de Registro es obligatorio")
                result = False
            End If

        Catch x As Exception
            Errores(x)
        End Try

        Return result
    End Function

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Try
            If Validaciones() = True Then
                MDIPrincipal.ProgresoGuardar()
                Empresa = New EmpresaEntity()
                Empresa.IDempresa = 1
                Empresa.Clinica = Me.ClinicaTextBox.Text
                Empresa.Medico = Me.MedicoTextBox.Text
                Empresa.Cedula = CInt(Me.CedulaTextBox.Text)
                Empresa.NRegistro = CInt(Me.RegistroTextBox.Text)
                Empresa.Clinica2 = Me.Clinica2TextBox.Text
                Empresa.Direccion = Me.DireccionTextBox.Text
                Empresa.Direccion2 = Me.Direccion2TextBox.Text
                Empresa.Telefono = Me.TelefonoTextBox.Text
                Empresa.Telefono2 = Me.Telefono2TextBox.Text
                Empresa.Web = Me.WebTextBox.Text
                Empresa.Web2 = Me.Web2TextBox.Text
                Empresa.Correo = Me.CorreoTextBox.Text
                Empresa.Correo2 = Me.Correo2TextBox.Text
                Empresa.Enunciado = Me.EnunciadoTextBox.Text
                Empresa.Horario = Me.HorarioTextBox.Text
                Empresa.Horario2 = Me.Horario2TextBox.Text
                Empresa.Logo = Me.LogoTextBox.Text
                Empresa.SubirBD = Me.SubirBdCheckBox.Checked
                Empresa = EmpresaBU.Guardar(Empresa)
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cargar.Click
        Try
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            openFileDialog.Filter = "Archivos de Imagenes (*.jpg, *.bmp, *.gif, *png)|*.jpg; *.bmp; *.gif; *png | Todas las Imagenes (*.*)|*.*"

            If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
                Dim fileName As String = openFileDialog.FileName
                Me.IMGno.Visible = False
                Me.PictureBox1.Image = New Bitmap(fileName)
                Me.LogoTextBox.Text = fileName
                Me.Logo.Text = My.Computer.FileSystem.GetName(fileName)
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub FrmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If EmpresaBU.Existe(1) = True Then
                Empresa = EmpresaBU.BuscarPorId(1)
                Me.ClinicaTextBox.Text = Empresa.Clinica
                Me.MedicoTextBox.Text = Empresa.Medico
                Me.CedulaTextBox.Text = CStr(Empresa.Cedula)
                Me.RegistroTextBox.Text = CStr(Empresa.NRegistro)
                Me.Clinica2TextBox.Text = Empresa.Clinica2
                Me.DireccionTextBox.Text = Empresa.Direccion
                Me.Direccion2TextBox.Text = Empresa.Direccion2
                Me.TelefonoTextBox.Text = Empresa.Telefono
                Me.Telefono2TextBox.Text = Empresa.Telefono2
                Me.WebTextBox.Text = Empresa.Web
                Me.Web2TextBox.Text = Empresa.Web2
                Me.CorreoTextBox.Text = Empresa.Correo
                Me.Correo2TextBox.Text = Empresa.Correo2
                Me.EnunciadoTextBox.Text = Empresa.Enunciado
                Me.HorarioTextBox.Text = Empresa.Horario
                Me.Horario2TextBox.Text = Empresa.Horario2
                Me.LogoTextBox.Text = Empresa.Logo
                Me.SubirBdCheckBox.Checked = Empresa.SubirBD

                If Me.LogoTextBox.Text <> Nothing Then
                    Me.Logo.Text = My.Computer.FileSystem.GetName(Me.LogoTextBox.Text)
                    Dim pepe As Boolean = My.Computer.FileSystem.FileExists(Me.LogoTextBox.Text)
                    If My.Computer.FileSystem.FileExists(Me.LogoTextBox.Text) = True Then
                        Me.PictureBox1.Image = New Bitmap(Me.LogoTextBox.Text)
                        Me.IMGno.Visible = False
                    Else
                        Me.PictureBox1.Image = My.Resources.Medicina
                        Me.IMGno.Visible = True
                    End If
                Else
                    Me.PictureBox1.Image = My.Resources.Medicina
                    Me.IMGno.Visible = False
                End If

                If Me.MedicoTextBox.Text <> Nothing Then
                    Me.Guardar.Text = "Editar"
                End If
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub
End Class