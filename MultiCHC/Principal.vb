Imports System.Windows.Forms

Public Class Principal

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel.Text = "Software elaborado y distribuido por: Grupo CVCELL 2010, C.A."
        If NoEstaRegistrado() = False Then
            Me.Text = "Multi CHC"
        Else
            If Vensido() = False Then
                Me.Text = "Multi Control de Historial Clinico. (DEMO)  Le quedan " & Queda & " días de Uso."
            Else
                Registro.Show()
            End If
        End If
    End Sub

    Private Sub Enfermedad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Enfermedad.Click

        Enfermedades.MdiParent = Me
        Enfermedades.Show()

    End Sub

    Private Sub Paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paciente.Click
        Me.Historias.Enabled = False
        Pacientes.MdiParent = Me
        Pacientes.Show()

    End Sub

    Private Sub Historias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Historias.Click
        Me.Paciente.Enabled = False
        HistorialClinico.MdiParent = Me
        HistorialClinico.Show()

    End Sub

    Private Sub Configurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configurar.Click

        Configuracion.ShowDialog()

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

        Configuracion.ShowDialog()

    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        If NoEstaRegistrado() = False Then
            MsgBox("Este producto ya esta registrado.", MsgBoxStyle.Information, "Registro")
            Exit Sub
        Else
            Registro.ShowDialog()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Acercade.ShowDialog()
    End Sub
End Class
