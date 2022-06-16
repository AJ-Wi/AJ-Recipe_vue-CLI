Public Class Pacientes

    Private Sub Pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)

        If mensaje = "Nuevo" Then
            Me.HistoriasBindingSource.AddNew()
            Me.Nuevo.Enabled = False
            Me.Guardar.Text = "Guardar"
            Me.NombreTextBox.Focus()
            Me.FechaDateTimePicker.Text = Now
            mensaje = ""
            Exit Sub
        End If

        If mensaje <> "Pacientes" Then
            If Me.NombreTextBox.Text = "" Then
                Me.Nuevo.Enabled = False
                Me.Guardar.Text = "Guardar"
            Else
                Me.Guardar.Text = "Editar"
            End If
            mensaje = ""
        Else
            Me.HistoriasBindingSource.Filter = "Cedula = '" & CI & "' And Fecha = '" & Pace.ToString("dd/MM/yyyy") & "'"
            mensaje = ""
        End If

    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click

        Me.HistoriasBindingSource.AddNew()
        Me.Nuevo.Enabled = False
        Me.Guardar.Text = "Guardar"
        Me.NombreTextBox.Focus()
        Me.FechaDateTimePicker.Text = Now

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim CamposHistorial As String, ValorHistorial As String, Editados As String

        If Me.NombreTextBox.Text <> "" And Me.CedulaTextBox.Text <> "" Then
            If Me.Guardar.Text = "Guardar" Then
                CamposHistorial = "Cedula, Nombre, Enfermedad, Descripcion, Medicamentos, Tratamiento, Video, Fecha"
                ValorHistorial = "" & Me.CedulaTextBox.Text & ",'" & Me.NombreTextBox.Text & "','" & Me.EnfermedadTextBox.Text & "','" & _
                Me.DescripcionTextBox.Text & "','" & Me.MedicamentosTextBox.Text & "','" & Me.TratamientoTextBox.Text & "','" & Me.VideoTextBox.Text & "','" & _
                Me.FechaDateTimePicker.Text & "'"

                SQLData("Historias", CamposHistorial, ValorHistorial, "Guardar")

                Me.Nuevo.Enabled = True
                Me.Guardar.Text = "Editar"
                Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)
                Me.HistoriasBindingSource.MoveLast()
            Else
                Editados = "Historias.Cedula = '" & Me.CedulaTextBox.Text & "', Historias.Nombre = '" & Me.NombreTextBox.Text & "', Historias.Enfermedad = '" & _
                Me.EnfermedadTextBox.Text & "', Historias.Descripcion = '" & Me.DescripcionTextBox.Text & "', Historias.Medicamentos = '" & _
                Me.MedicamentosTextBox.Text & "', Historias.Tratamiento = '" & Me.TratamientoTextBox.Text & "', Historias.Video = '" & Me.VideoTextBox.Text & _
                "', Historias.Fecha = '" & Me.FechaDateTimePicker.Text & "'"

                SQLData("Historias", "IDpaciente", Me.IDpacienteTextBox.Text, "Editar", Editados)
            End If
        Else
            MsgBox("Debe indicar Nombre y Cedula del paciente para poder guardar el registro", MsgBoxStyle.Critical, "A V I S O")
        End If

    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click

        SQLData("Historias", "IDpaciente", Me.IDpacienteTextBox.Text, "Eliminar")
        Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)

        If Me.NombreTextBox.Text = "" Then
            Me.Nuevo.Enabled = False
            Me.Guardar.Text = "Guardar"
        Else
            Me.Guardar.Text = "Editar"
        End If

    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Buscador.MdiParent = Principal
        Buscador.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start(VideoTextBox.Text)
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Imp = Me.IDpacienteTextBox.Text
        Recipe.ShowDialog()
    End Sub

    Private Sub HistoriasClinicas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoriasClinicas.Click
        HistorialClinico.MdiParent = Principal
        HistorialClinico.Show()
    End Sub

    Private Sub Pacientes_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        If mensaje = "DobleClick" Then
            Me.EnfermedadesTableAdapter.Fill(Me.CHCDataSet.Enfermedades)
            Me.EnfermedadesBindingSource.Filter = "IDenfermedad = " & Dato & ""
            Me.EnfermedadTextBox1.Visible = True
            Me.DescripcionTextBox1.Visible = True
            Me.MedicamentosTextBox1.Visible = True
            Me.TratamientoTextBox1.Visible = True
            Me.VideoTextBox1.Visible = True
            Me.EnfermedadTextBox.Text = EnfermedadTextBox1.Text
            Me.DescripcionTextBox.Text = Me.DescripcionTextBox1.Text
            Me.MedicamentosTextBox.Text = Me.MedicamentosTextBox1.Text
            Me.TratamientoTextBox.Text = Me.TratamientoTextBox1.Text
            Me.VideoTextBox.Text = Me.VideoTextBox1.Text
            Me.EnfermedadTextBox1.Visible = False
            Me.DescripcionTextBox1.Visible = False
            Me.MedicamentosTextBox1.Visible = False
            Me.TratamientoTextBox1.Visible = False
            Me.VideoTextBox1.Visible = False
            mensaje = ""
        End If
    End Sub

    Private Sub Pacientes_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Historias.Enabled = True
    End Sub
End Class