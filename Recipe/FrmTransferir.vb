
Public Class FrmTransferir

    Private Sub FrmTransferir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Ventana
            Case "Listar Enfermedad"
                Me.EnfermedadesCheckBox.Enabled = False
            Case "Listar Terapia"
                Me.TerapiasCheckBox.Enabled = False
            Case "Listar Dieta"
                Me.DietasCheckBox.Enabled = False
            Case "Listar Consejo"
                Me.DietasCheckBox.Enabled = False
        End Select
    End Sub

    Private Sub ConsejosCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsejosCheckBox.CheckedChanged
        If ConsejosCheckBox.Checked = True Then
            Me.Aceptar.Enabled = True
            Me.DietasCheckBox.Checked = False
            Me.TerapiasCheckBox.Checked = False
            Me.EnfermedadesCheckBox.Checked = False
            Me.NombreLabel.Enabled = False
            Me.NombreTextBox.Enabled = False
            Tabla = "Consejos"
        Else
            Me.Aceptar.Enabled = False
            Tabla = Nothing
        End If
    End Sub

    Private Sub DietasCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DietasCheckBox.CheckedChanged
        If DietasCheckBox.Checked = True Then
            Me.Aceptar.Enabled = True
            Me.ConsejosCheckBox.Checked = False
            Me.TerapiasCheckBox.Checked = False
            Me.EnfermedadesCheckBox.Checked = False
            Me.NombreLabel.Enabled = False
            Me.NombreTextBox.Enabled = False
            Tabla = "Dietas"
        Else
            Me.Aceptar.Enabled = False
            Tabla = Nothing
        End If
    End Sub

    Private Sub TerapiasCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerapiasCheckBox.CheckedChanged
        If TerapiasCheckBox.Checked = True Then
            Me.Aceptar.Enabled = True
            Me.DietasCheckBox.Checked = False
            Me.ConsejosCheckBox.Checked = False
            Me.EnfermedadesCheckBox.Checked = False
            Me.NombreLabel.Enabled = False
            Me.NombreTextBox.Enabled = False
            Tabla = "Terapias"
        Else
            Me.Aceptar.Enabled = False
            Tabla = Nothing
        End If
    End Sub

    Private Sub EnfermedadesCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnfermedadesCheckBox.CheckedChanged
        If EnfermedadesCheckBox.Checked = True Then
            Me.Aceptar.Enabled = True
            Me.DietasCheckBox.Checked = False
            Me.TerapiasCheckBox.Checked = False
            Me.ConsejosCheckBox.Checked = False
            Me.NombreLabel.Enabled = True
            Me.NombreTextBox.Enabled = True
            Tabla = "Enfermedades"
        Else
            Me.NombreLabel.Enabled = False
            Me.NombreTextBox.Enabled = False
            Me.Aceptar.Enabled = False
            Tabla = Nothing
        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If NombreTextBox.Enabled = True Then NombreEnfermedad = Me.NombreTextBox.Text
        If NombreEnfermedad = Nothing Then
            MsgBox("Debe ingresar el nombre de la Enfermedad.", MsgBoxStyle.Critical, "AVISO")
            Me.NombreTextBox.Focus()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FrmTransferir_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If NombreTextBox.Enabled = True Then NombreEnfermedad = Me.NombreTextBox.Text
        If NombreEnfermedad = Nothing Then
            MsgBox("Debe ingresar el nombre de la Enfermedad.", MsgBoxStyle.Critical, "AVISO")
            Me.NombreTextBox.Focus()
            e.Cancel = True
        End If
    End Sub

End Class