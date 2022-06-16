Public Class HistorialClinico

    Private Sub HistorialClinico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)
        Me.BuscarCedula.Focus()

    End Sub

    Private Sub BuscarCedula_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BuscarCedula.KeyDown
        If e.KeyData = Keys.Enter Then
            Call Busqueda(Me.BuscarCedula.Text)
        End If
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Call Busqueda(Me.BuscarCedula.Text)
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        mensaje = "Nuevo"
        Pacientes.MdiParent = Principal
        Pacientes.Show()
        Me.Close()
    End Sub

    Private Sub Busqueda(ByVal Cedula As String)
        Me.HistoriasBindingSource.Filter = "Cedula = " & Cedula
        If Me.HistoriasBindingSource.Count = 0 Then
            If MsgBox("El Paciente que intenta buscar no se encuentra, decea ingresarlo como uno nuevo?", MsgBoxStyle.YesNo, "A V I S O") = MsgBoxResult.Yes Then
                Pacientes.MdiParent = Principal
                Pacientes.Show()
                Me.Close()
            Else
                Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)
            End If
        Else
            Me.BuscarCedula.Text = ""
            Me.CedulaTextBox.Text = Cedula
            Me.NombreTextBox1.Visible = True
            Me.NombreTextBox.Text = Me.NombreTextBox1.Text
            Me.NombreTextBox1.Visible = False
        End If
    End Sub

    Private Sub HistoriasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HistoriasDataGridView.CellDoubleClick
        Dim cell As DataGridViewCell = HistoriasDataGridView.CurrentCell

        Pace = cell.FormattedValue.ToString
        CI = Me.CedulaTextBox.Text
        mensaje = "Pacientes"
        Pacientes.MdiParent = Principal
        Pacientes.Show()
        Me.Close()
    End Sub

    Private Sub HistorialClinico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Paciente.Enabled = True
    End Sub
End Class