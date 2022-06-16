

Public Class FrmAcecade

    Private Sub FrmAcecade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim ApplicationTitle As String
            If My.Application.Info.Title <> "" Then
                ApplicationTitle = My.Application.Info.Title
            Else
                ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If
            Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
            Me.NombreAplicacion.Text = ApplicationTitle
            Me.Version.Text = String.Format("Versión {0}", My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision)
            Me.Copyright.Text = My.Application.Info.Copyright
            Me.NombreCompañia.Text = My.Application.Info.Trademark
            Me.Descripcion.Text = My.Application.Info.Description
            Me.AutorizadoLabel.Text += My.Settings.NombreLicenciatario

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Me.Close()
    End Sub

End Class
