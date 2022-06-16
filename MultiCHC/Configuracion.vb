Public Class Configuracion

    Private Sub Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ConfiguracionTableAdapter.Fill(Me.CHCDataSet.Configuracion)
        If Me.LogoTextBox.Text <> "" Then
            Me.PictureBox1.Image = New Bitmap(Me.LogoTextBox.Text)
            Me.Logo.Text = NombreIMG(Me.LogoTextBox.Text)
        End If
        If Me.MedicoTextBox.Text <> "" Then
            Me.Guardar.Text = "Editar"
        End If

    End Sub

    Private Sub Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cargar.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenFileDialog.Filter = "Archivos de Imagenes (*.jpg, *.bmp, *.gif)|*.jpg; *.bmp; *.gif | Todas las Imagenes (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            Me.PictureBox1.Image = New Bitmap(FileName)
            Me.LogoTextBox.Text = (FileName)
            Me.Logo.Text = NombreIMG(FileName)
        End If

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim CamposConfig As String, ValorConfig As String, Editados As String

        If Me.Guardar.Text = "Guardar" Then
            CamposConfig = "Medico, Clinica, Direccion, Telefono, Web, Correo, Logo"
            ValorConfig = "'" & Me.MedicoTextBox.Text & "','" & Me.ClinicaTextBox.Text & "','" & Me.DireccionTextBox.Text & "','" & _
                    Me.TelefonoTextBox.Text & "','" & Me.WebTextBox.Text & "','" & Me.CorreoTextBox.Text & "','" & LogoTextBox.Text & "'"

            SQLData("Configuracion", CamposConfig, ValorConfig, "Guardar")

            Me.Guardar.Text = "Editar"
            Me.ConfiguracionTableAdapter.Fill(Me.CHCDataSet.Configuracion)
        Else
            Editados = "Configuracion.Medico = '" & Me.MedicoTextBox.Text & "', Configuracion.Clinica = '" & Me.ClinicaTextBox.Text & _
            "', Configuracion.Direccion = '" & Me.DireccionTextBox.Text & "', Configuracion.Telefono = '" & Me.TelefonoTextBox.Text & _
            "', Configuracion.Web = '" & Me.WebTextBox.Text & "', Configuracion.Correo = '" & Me.CorreoTextBox.Text & _
            "', Configuracion.Logo = '" & Me.LogoTextBox.Text & "'"

            SQLData("Configuracion", "Medico", "'" & Me.MedicoTextBox.Text & "'", "Editar", Editados)
        End If

    End Sub
End Class