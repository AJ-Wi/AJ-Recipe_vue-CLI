Public Class Buscador

    Private Sub Buscador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.EnfermedadesTableAdapter.Fill(Me.CHCDataSet.Enfermedades)

    End Sub

    Private Sub CadenaBuscada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadenaBuscada.TextChanged
        Dim Letra As String

        Letra = CadenaBuscada.Text

        Me.EnfermedadesBindingSource.Filter = "Enfermedad like '*" & Letra & "*'"

    End Sub

    Private Sub EnfermedadesDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EnfermedadesDataGridView.CellDoubleClick
        Dim cell As DataGridViewCell = EnfermedadesDataGridView.CurrentCell

        Dato = cell.FormattedValue.ToString
        mensaje = "DobleClick"
        Me.Close()


    End Sub
End Class