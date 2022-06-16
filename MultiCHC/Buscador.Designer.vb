<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscador))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CadenaBuscada = New System.Windows.Forms.TextBox
        Me.CHCDataSet = New MultiCHC.CHCDataSet
        Me.EnfermedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnfermedadesTableAdapter = New MultiCHC.CHCDataSetTableAdapters.EnfermedadesTableAdapter
        Me.TableAdapterManager = New MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
        Me.EnfermedadesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.EnfermedadesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.EnfermedadesDataGridView = New System.Windows.Forms.DataGridView
        Me.IDenfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnfermedadesBindingNavigator.SuspendLayout()
        CType(Me.EnfermedadesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CadenaBuscada
        '
        Me.CadenaBuscada.Location = New System.Drawing.Point(192, 12)
        Me.CadenaBuscada.Name = "CadenaBuscada"
        Me.CadenaBuscada.Size = New System.Drawing.Size(285, 20)
        Me.CadenaBuscada.TabIndex = 0
        '
        'CHCDataSet
        '
        Me.CHCDataSet.DataSetName = "CHCDataSet"
        Me.CHCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnfermedadesBindingSource
        '
        Me.EnfermedadesBindingSource.DataMember = "Enfermedades"
        Me.EnfermedadesBindingSource.DataSource = Me.CHCDataSet
        '
        'EnfermedadesTableAdapter
        '
        Me.EnfermedadesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConfiguracionTableAdapter = Nothing
        Me.TableAdapterManager.EnfermedadesTableAdapter = Me.EnfermedadesTableAdapter
        Me.TableAdapterManager.HistoriasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MultiCHC.CHCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EnfermedadesBindingNavigator
        '
        Me.EnfermedadesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EnfermedadesBindingNavigator.BindingSource = Me.EnfermedadesBindingSource
        Me.EnfermedadesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EnfermedadesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EnfermedadesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.EnfermedadesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EnfermedadesBindingNavigatorSaveItem})
        Me.EnfermedadesBindingNavigator.Location = New System.Drawing.Point(27, 712)
        Me.EnfermedadesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EnfermedadesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EnfermedadesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EnfermedadesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EnfermedadesBindingNavigator.Name = "EnfermedadesBindingNavigator"
        Me.EnfermedadesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EnfermedadesBindingNavigator.Size = New System.Drawing.Size(279, 25)
        Me.EnfermedadesBindingNavigator.TabIndex = 1
        Me.EnfermedadesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EnfermedadesBindingNavigatorSaveItem
        '
        Me.EnfermedadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnfermedadesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EnfermedadesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EnfermedadesBindingNavigatorSaveItem.Name = "EnfermedadesBindingNavigatorSaveItem"
        Me.EnfermedadesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EnfermedadesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EnfermedadesDataGridView
        '
        Me.EnfermedadesDataGridView.AllowUserToAddRows = False
        Me.EnfermedadesDataGridView.AllowUserToDeleteRows = False
        Me.EnfermedadesDataGridView.AutoGenerateColumns = False
        Me.EnfermedadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EnfermedadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDenfermedad, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.EnfermedadesDataGridView.DataSource = Me.EnfermedadesBindingSource
        Me.EnfermedadesDataGridView.Location = New System.Drawing.Point(12, 56)
        Me.EnfermedadesDataGridView.Name = "EnfermedadesDataGridView"
        Me.EnfermedadesDataGridView.ReadOnly = True
        Me.EnfermedadesDataGridView.Size = New System.Drawing.Size(695, 607)
        Me.EnfermedadesDataGridView.TabIndex = 2
        '
        'IDenfermedad
        '
        Me.IDenfermedad.DataPropertyName = "IDenfermedad"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDenfermedad.DefaultCellStyle = DataGridViewCellStyle1
        Me.IDenfermedad.HeaderText = "ID"
        Me.IDenfermedad.Name = "IDenfermedad"
        Me.IDenfermedad.ReadOnly = True
        Me.IDenfermedad.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Enfermedad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Enfermedad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 550
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Medicamentos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Medicamentos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tratamiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tratamiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Video"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Video"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Buscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 675)
        Me.Controls.Add(Me.EnfermedadesDataGridView)
        Me.Controls.Add(Me.EnfermedadesBindingNavigator)
        Me.Controls.Add(Me.CadenaBuscada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Buscador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador"
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnfermedadesBindingNavigator.ResumeLayout(False)
        Me.EnfermedadesBindingNavigator.PerformLayout()
        CType(Me.EnfermedadesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CadenaBuscada As System.Windows.Forms.TextBox
    Friend WithEvents CHCDataSet As MultiCHC.CHCDataSet
    Friend WithEvents EnfermedadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnfermedadesTableAdapter As MultiCHC.CHCDataSetTableAdapters.EnfermedadesTableAdapter
    Friend WithEvents TableAdapterManager As MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EnfermedadesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnfermedadesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EnfermedadesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDenfermedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
