
Public Class FrmCamara

    Private Sub FrmCamara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            CamaraWeb.Start()
            CamaraWeb.Start()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            'FrmPacientes.Foto.Image = CamaraWeb.Imagen
            Me.Close()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub FrmCamara_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            CamaraWeb.Stop()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class