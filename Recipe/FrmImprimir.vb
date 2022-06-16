Imports Recipe.BusinessLayer

Public Class FrmImprimir

    Private Sub FrmImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case Inf
                Case "RecipeConImagen"
                    Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\RptRecipeImagen.rdlc"
                Case "RecipeSinImagen"
                    Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\RptRecipe.rdlc"
                Case "Dietas"
                    Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\RptRecipeDietas.rdlc"
                Case "Legal"
                    Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\RptRecipeLegal.rdlc"
            End Select

            Inf = Nothing

            Me.ReportViewer1.LocalReport.EnableExternalImages = True
            If Me.ReportViewer1.PrinterSettings.CanDuplex = True Then
                Me.ReportViewer1.PrinterSettings.Duplex = Printing.Duplex.Vertical
            End If
            Me.EmpresaEntityBindingSource.DataSource = EmpresaBU.BuscarPorId(1)
            Me.HistoriasEntityBindingSource.DataSource = Recipe
            Me.ReportViewer1.RefreshReport()

        Catch x As Exception
            Errores(x)
        End Try

    End Sub
End Class