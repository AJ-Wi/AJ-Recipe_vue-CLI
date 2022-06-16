Imports System.Net
Imports System.ComponentModel
Imports Actualizar

Public Class FrmInicio

    Private Sub FrmInicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Version.Text = Version.Text & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
            Copyright.Text = My.Application.Info.Copyright

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class
