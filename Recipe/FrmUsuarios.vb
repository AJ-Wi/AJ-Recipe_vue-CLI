Imports Recipe.Entities
Imports Recipe.BusinessLayer

Public Class FrmUsuarios
    Private User As UserEntity

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            UsuariosDataGridView.AutoGenerateColumns = False
            UsuariosDataGridView.DataSource = UserBU.CargarTodo

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        CambiarForm()
    End Sub

    Private Sub UsuariosDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellContentDoubleClick

        Try

            If CStr(UsuariosDataGridView.CurrentRow.Cells(1).Value) <> "Sistema" Then
                CambiarForm()
                Me.Crear.Text = "Actualizar"

                If e.RowIndex <> -1 Then
                    User = UserBU.BuscarPorID(CInt(UsuariosDataGridView.CurrentRow.Cells(0).Value))
                    Me.UsuarioTextBox.Text = User.Usuario
                    Me.ContraseñaTextBox.Text = User.Contraseña
                    Me.TipoComboBox.Text = User.Tipo
                End If
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub CambiarForm()

        Try

            Me.Label1.Visible = False
            Me.Label2.Visible = False
            Me.UsuariosDataGridView.Visible = False
            Me.Crear.Visible = True
            Me.UsuarioLabel.Visible = True
            Me.UsuarioTextBox.Visible = True
            Me.ContraseñaLabel.Visible = True
            Me.ContraseñaTextBox.Visible = True
            Me.TipoLabel.Visible = True
            Me.TipoComboBox.Visible = True
            Me.Size = New Size(244, 148) '295, 234

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crear.Click

        Try

            If User Is Nothing Then
                User = New UserEntity
            End If
            User.Usuario = Me.UsuarioTextBox.Text
            User.Contraseña = Me.ContraseñaTextBox.Text
            User.Tipo = Me.TipoComboBox.Text
            UserBU.Guardar(User)
            Me.Close()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class