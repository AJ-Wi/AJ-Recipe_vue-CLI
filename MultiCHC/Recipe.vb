Imports Microsoft.Reporting.WinForms

Public Class Recipe

    Private Sub Recipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filtro As String
        Dim parametros As New List(Of ReportParameter)

        Me.ConfiguracionTableAdapter.Fill(Me.CHCDataSet.Configuracion)
        Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)
        filtro = "SELECT * FROM Historias WHERE IDpaciente like '" & Imp & "'"
        HistoriasTableAdapter.Adapter.SelectCommand.CommandText = filtro
        Me.HistoriasTableAdapter.Fill(Me.CHCDataSet.Historias)

        parametros.Add(New ReportParameter("ID", Imp, False))
        Me.ReportViewer1.LocalReport.SetParameters(parametros)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class