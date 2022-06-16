Imports Actualizar
Imports Recipe.Entities
Imports Recipe.BusinessLayer

Public Class FrmLogin
    Private User As UserEntity

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        Try

            If Me.Usuario.Text = Nothing Or Me.Contraseña.Text = Nothing Then
                mensaje()
            ElseIf UserBU.ExisteUsuario(Me.Usuario.Text) = True Then
                User = UserBU.BuscarPorCadena(Me.Usuario.Text)
                If User.Contraseña = Me.Contraseña.Text Then
                    Tipo = User.Tipo
                    MDIPrincipal.Show()
                    Me.Close()
                Else
                    mensaje()
                End If
            Else
                mensaje()
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Public Sub mensaje()
        MsgBox("Debe ingresar un usuario y contraseña valido.", MsgBoxStyle.Critical, "Acceso")
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Usuarios As List(Of UserEntity)

        Try

            Usuarios = UserBU.CargarTodo

            For i As Integer = 0 To Usuarios.Count - 1
                Me.Usuario.Items.Add(Usuarios(i).Usuario)
            Next

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class