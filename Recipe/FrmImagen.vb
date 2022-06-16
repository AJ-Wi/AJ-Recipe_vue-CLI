

Public Class FrmImagen

    Private Sub FrmImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.PictureBox1.Image = New Bitmap(Imagen)

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub BtnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSi.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNo.Click
        Me.DialogResult = DialogResult.No
    End Sub

End Class