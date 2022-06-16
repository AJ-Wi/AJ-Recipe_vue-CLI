Public Class Enfermedades

    Private Sub Enfermedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.EnfermedadesTableAdapter.Fill(Me.CHCDataSet.Enfermedades)
        Me.NombreEnfermedad.Focus()

        If Me.EnfermedadTextBox.Text = "" Then
            Me.Nuevo.Enabled = False
            Me.Guardar.Text = "Guardar"
        Else
            Me.Guardar.Text = "Editar"
        End If

    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click

        Me.EnfermedadesBindingSource.AddNew()
        Me.Nuevo.Enabled = False
        Me.Guardar.Text = "Guardar"
        Me.EnfermedadTextBox.Focus()
        Me.Buscar.Enabled = False

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim CamposEfermedades As String, ValorEfermedades As String, Editados As String

        If Me.Guardar.Text = "Guardar" Then
            CamposEfermedades = "Enfermedad, Descripcion, Medicamentos, Tratamiento, Video"
            ValorEfermedades = "'" & Me.EnfermedadTextBox.Text & "','" & Me.DescripcionTextBox.Text & "','" & Me.MedicamentosTextBox.Text & "','" & _
                    Me.TratamientoTextBox.Text & "','" & Me.VideoTextBox.Text & "'"

            SQLData("Enfermedades", CamposEfermedades, ValorEfermedades, "Guardar")

            Me.Nuevo.Enabled = True
            Me.Guardar.Text = "Editar"
            Me.EnfermedadesTableAdapter.Fill(Me.CHCDataSet.Enfermedades)
            Me.EnfermedadesBindingSource.MoveLast()
        Else
            Editados = "Enfermedades.Enfermedad = '" & Me.EnfermedadTextBox.Text & "', Enfermedades.Descripcion = '" & Me.DescripcionTextBox.Text & _
              "', Enfermedades.Medicamentos = '" & Me.MedicamentosTextBox.Text & "', Enfermedades.Tratamiento = '" & Me.TratamientoTextBox.Text & _
              "', Enfermedades.Video = '" & Me.VideoTextBox.Text & "'"

            SQLData("Enfermedades", "IDenfermedad", Me.IDenfermedadTextBox.Text, "Editar", Editados)
        End If

    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click

        SQLData("Enfermedades", "IDenfermedad", Me.IDenfermedadTextBox.Text, "Eliminar")
        Me.EnfermedadesTableAdapter.Fill(Me.CHCDataSet.Enfermedades)

        If Me.EnfermedadTextBox.Text = "" Then
            Me.Nuevo.Enabled = False
            Me.Guardar.Text = "Guardar"
        Else
            Me.Guardar.Text = "Editar"
        End If

    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click

        Me.EnfermedadesBindingSource.Filter = "Enfermedad like '*" & Me.NombreEnfermedad.Text & "*'"
        If Me.EnfermedadesBindingSource.Count = 0 Then
            If MsgBox("La Enfermedad que intenta buscar no se encuentra, decea ingresarla como una nueva?", MsgBoxStyle.YesNo, "A V I S O") = MsgBoxResult.Yes Then
                Me.EnfermedadesBindingSource.AddNew()
                Me.Nuevo.Enabled = False
                Me.Guardar.Text = "Guardar"
                Me.EnfermedadTextBox.Text = Me.NombreEnfermedad.Text
                Me.NombreEnfermedad.Text = ""
                Me.EnfermedadTextBox.Focus()
                Me.Buscar.Enabled = False
            Else
                Me.NombreEnfermedad.Text = ""
                Me.EnfermedadesBindingSource.Filter = "Enfermedad like '*" & Me.NombreEnfermedad.Text & "*'"
                Me.NombreEnfermedad.Focus()

                If Me.EnfermedadTextBox.Text = "" Then
                    Me.Nuevo.Enabled = False
                    Me.Guardar.Text = "Guardar"
                Else
                    Me.Guardar.Text = "Editar"
                End If
            End If
        End If
    End Sub

End Class