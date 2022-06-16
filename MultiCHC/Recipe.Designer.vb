<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recipe))
        Me.HistoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHCDataSet = New MultiCHC.CHCDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.HistoriasTableAdapter = New MultiCHC.CHCDataSetTableAdapters.HistoriasTableAdapter
        Me.ConfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfiguracionTableAdapter = New MultiCHC.CHCDataSetTableAdapters.ConfiguracionTableAdapter
        CType(Me.HistoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HistoriasBindingSource
        '
        Me.HistoriasBindingSource.DataMember = "Historias"
        Me.HistoriasBindingSource.DataSource = Me.CHCDataSet
        '
        'CHCDataSet
        '
        Me.CHCDataSet.DataSetName = "CHCDataSet"
        Me.CHCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CHCDataSet_Historias"
        ReportDataSource1.Value = Me.HistoriasBindingSource
        ReportDataSource2.Name = "CHCDataSet_Configuracion"
        ReportDataSource2.Value = Me.ConfiguracionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MultiCHC.Recipe.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1165, 851)
        Me.ReportViewer1.TabIndex = 0
        '
        'HistoriasTableAdapter
        '
        Me.HistoriasTableAdapter.ClearBeforeFill = True
        '
        'ConfiguracionBindingSource
        '
        Me.ConfiguracionBindingSource.DataMember = "Configuracion"
        Me.ConfiguracionBindingSource.DataSource = Me.CHCDataSet
        '
        'ConfiguracionTableAdapter
        '
        Me.ConfiguracionTableAdapter.ClearBeforeFill = True
        '
        'Recipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 851)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recipe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipe"
        CType(Me.HistoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HistoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHCDataSet As MultiCHC.CHCDataSet
    Friend WithEvents HistoriasTableAdapter As MultiCHC.CHCDataSetTableAdapters.HistoriasTableAdapter
    Friend WithEvents ConfiguracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfiguracionTableAdapter As MultiCHC.CHCDataSetTableAdapters.ConfiguracionTableAdapter
End Class
