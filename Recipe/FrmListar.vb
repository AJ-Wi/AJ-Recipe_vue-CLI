Imports Recipe.BusinessLayer

Public Class FrmListar

    Private Sub FrmListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Ventana & " - " & My.Application.Info.Title
        CargarTodo(True)
    End Sub

    Private Sub CargarTodo(ByVal Nuevo As Boolean)

        Try

            ListarDataGridView.AutoGenerateColumns = False
            ListarDataGridView.Columns.Clear()

            Select Case Ventana
                Case "Listar Enfermedad"
                    ListarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.IDenfermedad, Me.Enfermedad})
                    ListarDataGridView.DataSource = EnfermedadesBU.CargarTodo()
                Case "Listar Terapia"
                    ListarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.IDterapia, Me.Terapia})
                    ListarDataGridView.DataSource = TerapiasBU.CargarTodo()
                Case "Listar Dieta"
                    ListarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.IDdieta, Me.Dieta})
                    ListarDataGridView.DataSource = DietasBU.CargarTodo()
                Case "Listar Consejo"
                    ListarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.IDconsejo, Me.Consejo})
                    ListarDataGridView.DataSource = ConsejosBU.CargarTodo()
            End Select

            Cuenta.Text = CStr(ListarDataGridView.RowCount) & " Registros Encontrados."

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub ListarDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListarDataGridView.CellDoubleClick

        Try

            If e.RowIndex <> -1 Then
                ID = CInt(ListarDataGridView.CurrentRow.Cells(1).Value)
                If Nuevo = True Then
                    Me.DialogResult = DialogResult.OK
                Else
                    If Ventana = "Listar Consejo" Then
                        Ventana = "Nuevo" & Mid(Ventana, 7)
                    Else
                        Ventana = "Nueva" & Mid(Ventana, 7)
                    End If
                        FrmIngresarCC.MdiParent = MDIPrincipal
                        FrmIngresarCC.Show()
                    End If
                Me.Close()
            End If

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged

        Try

            Select Case Ventana
                Case "Listar Enfermedad"
                    ListarDataGridView.DataSource = EnfermedadesBU.BuscarPorCadena(Filtro.Text)
                Case "Listar Terapia"
                    ListarDataGridView.DataSource = TerapiasBU.BuscarPorCadena(Filtro.Text)
                Case "Listar Dieta"
                    ListarDataGridView.DataSource = DietasBU.BuscarPorCadena(Filtro.Text)
                Case "Listar Consejo"
                    ListarDataGridView.DataSource = ConsejosBU.BuscarPorCadena(Filtro.Text)
            End Select

            Cuenta.Text = CStr(ListarDataGridView.RowCount) & " Registros Encontrados."

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        Try

            If Salir.Text = "Nuevo" Then
                FrmRecipe.MdiParent = MDIPrincipal
                FrmRecipe.Show()
            Else
                Me.DialogResult = DialogResult.Cancel
            End If
            Me.Close()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub Expandir()

        Try

            Dim W As Integer = Me.Width + 1  '621 - 460 = 161
            Dim H As Integer = Me.Height + 24 '616 - 80 = 536

            For i As Integer = 0 To 32
                Me.Size = New Size(W, H)
                W += 5
                H += 16
                Me.Refresh()
            Next

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub FrmListar_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.MenuNuevoRecipe.Enabled = True
        MDIPrincipal.BotonNuevoRecipe.Enabled = True
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Try

            For row As Integer = 0 To ListarDataGridView.RowCount - 1
                If CBool(ListarDataGridView.Rows(row).Cells(0).Value) = True Then
                    Select Case Ventana
                        Case "Listar Enfermedad"
                            EnfermedadesBU.EliminarPorID(CInt(ListarDataGridView.Rows(row).Cells(1).Value))
                        Case "Listar Terapia"
                            TerapiasBU.EliminarPorID(CInt(ListarDataGridView.Rows(row).Cells(1).Value))
                        Case "Listar Dieta"
                            DietasBU.EliminarPorID(CInt(ListarDataGridView.Rows(row).Cells(1).Value))
                        Case "Listar Consejo"
                            ConsejosBU.EliminarPorID(CInt(ListarDataGridView.Rows(row).Cells(1).Value))
                    End Select
                End If
            Next
            CargarTodo(False)

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

    Private Sub BtnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransferir.Click
        FrmTransferir.Show()

        Try

            For row As Integer = 0 To ListarDataGridView.RowCount - 1
                If CBool(ListarDataGridView.Rows(row).Cells(0).Value) = True Then
                    Select Case Ventana
                        Case "Listar Enfermedad"
                            EnfermedadesBU.Transferir(CInt(ListarDataGridView.Rows(row).Cells(1).Value), Tabla)
                        Case "Listar Consejo"
                            ConsejosBU.Transferir(CInt(ListarDataGridView.Rows(row).Cells(1).Value), Tabla, NombreEnfermedad)
                        Case "Listar Terapia"
                            TerapiasBU.Transferir(CInt(ListarDataGridView.Rows(row).Cells(1).Value), Tabla, NombreEnfermedad)
                        Case "Listar Dieta"
                            DietasBU.Transferir(CInt(ListarDataGridView.Rows(row).Cells(1).Value), Tabla, NombreEnfermedad)
                    End Select
                End If
            Next
            CargarTodo(False)

        Catch x As Exception
            Errores(x)
        End Try

    End Sub

End Class