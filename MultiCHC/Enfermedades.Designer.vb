<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enfermedades
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
        Me.components = New System.ComponentModel.Container()
        Dim EnfermedadLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MedicamentosLabel As System.Windows.Forms.Label
        Dim TratamientoLabel As System.Windows.Forms.Label
        Dim VideoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enfermedades))
        Me.CHCDataSet = New MultiCHC.CHCDataSet()
        Me.EnfermedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnfermedadesTableAdapter = New MultiCHC.CHCDataSetTableAdapters.EnfermedadesTableAdapter()
        Me.TableAdapterManager = New MultiCHC.CHCDataSetTableAdapters.TableAdapterManager()
        Me.EnfermedadesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NombreEnfermedad = New System.Windows.Forms.ToolStripTextBox()
        Me.Buscar = New System.Windows.Forms.ToolStripButton()
        Me.EnfermedadTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MedicamentosTextBox = New System.Windows.Forms.TextBox()
        Me.TratamientoTextBox = New System.Windows.Forms.TextBox()
        Me.VideoTextBox = New System.Windows.Forms.TextBox()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.IDenfermedadTextBox = New System.Windows.Forms.TextBox()
        EnfermedadLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MedicamentosLabel = New System.Windows.Forms.Label()
        TratamientoLabel = New System.Windows.Forms.Label()
        VideoLabel = New System.Windows.Forms.Label()
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnfermedadesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnfermedadLabel
        '
        EnfermedadLabel.AutoSize = True
        EnfermedadLabel.Location = New System.Drawing.Point(14, 69)
        EnfermedadLabel.Name = "EnfermedadLabel"
        EnfermedadLabel.Size = New System.Drawing.Size(78, 13)
        EnfermedadLabel.TabIndex = 1
        EnfermedadLabel.Text = "Enfermedad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(14, 108)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(78, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'MedicamentosLabel
        '
        MedicamentosLabel.AutoSize = True
        MedicamentosLabel.Location = New System.Drawing.Point(14, 252)
        MedicamentosLabel.Name = "MedicamentosLabel"
        MedicamentosLabel.Size = New System.Drawing.Size(92, 13)
        MedicamentosLabel.TabIndex = 5
        MedicamentosLabel.Text = "Medicamentos:"
        '
        'TratamientoLabel
        '
        TratamientoLabel.AutoSize = True
        TratamientoLabel.Location = New System.Drawing.Point(14, 373)
        TratamientoLabel.Name = "TratamientoLabel"
        TratamientoLabel.Size = New System.Drawing.Size(78, 13)
        TratamientoLabel.TabIndex = 7
        TratamientoLabel.Text = "Tratamiento:"
        '
        'VideoLabel
        '
        VideoLabel.AutoSize = True
        VideoLabel.Location = New System.Drawing.Point(14, 545)
        VideoLabel.Name = "VideoLabel"
        VideoLabel.Size = New System.Drawing.Size(43, 13)
        VideoLabel.TabIndex = 9
        VideoLabel.Text = "Video:"
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
        Me.EnfermedadesBindingNavigator.AddNewItem = Nothing
        Me.EnfermedadesBindingNavigator.BindingSource = Me.EnfermedadesBindingSource
        Me.EnfermedadesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EnfermedadesBindingNavigator.DeleteItem = Nothing
        Me.EnfermedadesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.NombreEnfermedad, Me.Buscar})
        Me.EnfermedadesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EnfermedadesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EnfermedadesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EnfermedadesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EnfermedadesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EnfermedadesBindingNavigator.Name = "EnfermedadesBindingNavigator"
        Me.EnfermedadesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EnfermedadesBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.EnfermedadesBindingNavigator.TabIndex = 0
        Me.EnfermedadesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel1.Text = "Buscar"
        '
        'NombreEnfermedad
        '
        Me.NombreEnfermedad.BackColor = System.Drawing.SystemColors.Window
        Me.NombreEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreEnfermedad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreEnfermedad.Name = "NombreEnfermedad"
        Me.NombreEnfermedad.Size = New System.Drawing.Size(320, 25)
        Me.NombreEnfermedad.ToolTipText = "Escriba el nombre de la enfermedad a buscar"
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Buscar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Image = Global.MultiCHC.My.Resources.Resources.lupa
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Padding = New System.Windows.Forms.Padding(40, 0, 0, 2)
        Me.Buscar.Size = New System.Drawing.Size(60, 22)
        Me.Buscar.Text = "Buscar"
        '
        'EnfermedadTextBox
        '
        Me.EnfermedadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Enfermedad", True))
        Me.EnfermedadTextBox.Location = New System.Drawing.Point(17, 85)
        Me.EnfermedadTextBox.Name = "EnfermedadTextBox"
        Me.EnfermedadTextBox.Size = New System.Drawing.Size(668, 20)
        Me.EnfermedadTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(17, 124)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(668, 125)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'MedicamentosTextBox
        '
        Me.MedicamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Medicamentos", True))
        Me.MedicamentosTextBox.Location = New System.Drawing.Point(17, 268)
        Me.MedicamentosTextBox.Multiline = True
        Me.MedicamentosTextBox.Name = "MedicamentosTextBox"
        Me.MedicamentosTextBox.Size = New System.Drawing.Size(668, 102)
        Me.MedicamentosTextBox.TabIndex = 6
        '
        'TratamientoTextBox
        '
        Me.TratamientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Tratamiento", True))
        Me.TratamientoTextBox.Location = New System.Drawing.Point(17, 389)
        Me.TratamientoTextBox.Multiline = True
        Me.TratamientoTextBox.Name = "TratamientoTextBox"
        Me.TratamientoTextBox.Size = New System.Drawing.Size(668, 153)
        Me.TratamientoTextBox.TabIndex = 8
        '
        'VideoTextBox
        '
        Me.VideoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Video", True))
        Me.VideoTextBox.Location = New System.Drawing.Point(17, 561)
        Me.VideoTextBox.Name = "VideoTextBox"
        Me.VideoTextBox.Size = New System.Drawing.Size(668, 20)
        Me.VideoTextBox.TabIndex = 10
        '
        'Nuevo
        '
        Me.Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo.Location = New System.Drawing.Point(17, 605)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(135, 54)
        Me.Nuevo.TabIndex = 11
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(282, 605)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(135, 54)
        Me.Guardar.TabIndex = 12
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(547, 605)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(135, 54)
        Me.Borrar.TabIndex = 14
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'IDenfermedadTextBox
        '
        Me.IDenfermedadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "IDenfermedad", True))
        Me.IDenfermedadTextBox.Enabled = False
        Me.IDenfermedadTextBox.Location = New System.Drawing.Point(651, 1)
        Me.IDenfermedadTextBox.Name = "IDenfermedadTextBox"
        Me.IDenfermedadTextBox.Size = New System.Drawing.Size(56, 20)
        Me.IDenfermedadTextBox.TabIndex = 16
        '
        'Enfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(719, 702)
        Me.Controls.Add(Me.IDenfermedadTextBox)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(EnfermedadLabel)
        Me.Controls.Add(Me.EnfermedadTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(MedicamentosLabel)
        Me.Controls.Add(Me.MedicamentosTextBox)
        Me.Controls.Add(TratamientoLabel)
        Me.Controls.Add(Me.TratamientoTextBox)
        Me.Controls.Add(VideoLabel)
        Me.Controls.Add(Me.VideoTextBox)
        Me.Controls.Add(Me.EnfermedadesBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "Enfermedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermedades"
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnfermedadesBindingNavigator.ResumeLayout(False)
        Me.EnfermedadesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHCDataSet As MultiCHC.CHCDataSet
    Friend WithEvents EnfermedadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnfermedadesTableAdapter As MultiCHC.CHCDataSetTableAdapters.EnfermedadesTableAdapter
    Friend WithEvents TableAdapterManager As MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EnfermedadesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnfermedadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicamentosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TratamientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VideoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NombreEnfermedad As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDenfermedadTextBox As System.Windows.Forms.TextBox
End Class
