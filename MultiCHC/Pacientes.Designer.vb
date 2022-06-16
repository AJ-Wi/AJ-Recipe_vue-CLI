<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes
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
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EnfermedadLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MedicamentosLabel As System.Windows.Forms.Label
        Dim TratamientoLabel As System.Windows.Forms.Label
        Dim VideoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacientes))
        Me.Borrar = New System.Windows.Forms.Button
        Me.Imprimir = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.CedulaTextBox = New System.Windows.Forms.TextBox
        Me.HistoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHCDataSet = New MultiCHC.CHCDataSet
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.EnfermedadTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.MedicamentosTextBox = New System.Windows.Forms.TextBox
        Me.TratamientoTextBox = New System.Windows.Forms.TextBox
        Me.VideoTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Buscar = New System.Windows.Forms.Button
        Me.Nuevo = New System.Windows.Forms.Button
        Me.HistoriasTableAdapter = New MultiCHC.CHCDataSetTableAdapters.HistoriasTableAdapter
        Me.TableAdapterManager = New MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
        Me.EnfermedadesTableAdapter = New MultiCHC.CHCDataSetTableAdapters.EnfermedadesTableAdapter
        Me.IDpacienteTextBox = New System.Windows.Forms.TextBox
        Me.PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.HistoriasClinicas = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.EnfermedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnfermedadTextBox1 = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox1 = New System.Windows.Forms.TextBox
        Me.MedicamentosTextBox1 = New System.Windows.Forms.TextBox
        Me.TratamientoTextBox1 = New System.Windows.Forms.TextBox
        Me.VideoTextBox1 = New System.Windows.Forms.TextBox
        Me.IDenfermedadTextBox = New System.Windows.Forms.TextBox
        CedulaLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        EnfermedadLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        MedicamentosLabel = New System.Windows.Forms.Label
        TratamientoLabel = New System.Windows.Forms.Label
        VideoLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        CType(Me.HistoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacientesBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel.Location = New System.Drawing.Point(585, 70)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(50, 13)
        CedulaLabel.TabIndex = 19
        CedulaLabel.Text = "Cedula:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(12, 70)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(54, 13)
        NombreLabel.TabIndex = 21
        NombreLabel.Text = "Nombre:"
        '
        'EnfermedadLabel
        '
        EnfermedadLabel.AutoSize = True
        EnfermedadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnfermedadLabel.Location = New System.Drawing.Point(12, 109)
        EnfermedadLabel.Name = "EnfermedadLabel"
        EnfermedadLabel.Size = New System.Drawing.Size(78, 13)
        EnfermedadLabel.TabIndex = 23
        EnfermedadLabel.Text = "Enfermedad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(12, 148)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(78, 13)
        DescripcionLabel.TabIndex = 25
        DescripcionLabel.Text = "Descripcion:"
        '
        'MedicamentosLabel
        '
        MedicamentosLabel.AutoSize = True
        MedicamentosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicamentosLabel.Location = New System.Drawing.Point(12, 292)
        MedicamentosLabel.Name = "MedicamentosLabel"
        MedicamentosLabel.Size = New System.Drawing.Size(92, 13)
        MedicamentosLabel.TabIndex = 27
        MedicamentosLabel.Text = "Medicamentos:"
        '
        'TratamientoLabel
        '
        TratamientoLabel.AutoSize = True
        TratamientoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TratamientoLabel.Location = New System.Drawing.Point(12, 413)
        TratamientoLabel.Name = "TratamientoLabel"
        TratamientoLabel.Size = New System.Drawing.Size(78, 13)
        TratamientoLabel.TabIndex = 29
        TratamientoLabel.Text = "Tratamiento:"
        '
        'VideoLabel
        '
        VideoLabel.AutoSize = True
        VideoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VideoLabel.Location = New System.Drawing.Point(12, 585)
        VideoLabel.Name = "VideoLabel"
        VideoLabel.Size = New System.Drawing.Size(43, 13)
        VideoLabel.TabIndex = 31
        VideoLabel.Text = "Video:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(12, 51)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(46, 13)
        FechaLabel.TabIndex = 33
        FechaLabel.Text = "Fecha:"
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(543, 638)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(135, 54)
        Me.Borrar.TabIndex = 18
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Imprimir
        '
        Me.Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.Location = New System.Drawing.Point(367, 638)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(135, 54)
        Me.Imprimir.TabIndex = 17
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(191, 638)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(135, 54)
        Me.Guardar.TabIndex = 16
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(588, 86)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(95, 20)
        Me.CedulaTextBox.TabIndex = 20
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
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(15, 86)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(567, 20)
        Me.NombreTextBox.TabIndex = 22
        '
        'EnfermedadTextBox
        '
        Me.EnfermedadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Enfermedad", True))
        Me.EnfermedadTextBox.Location = New System.Drawing.Point(15, 125)
        Me.EnfermedadTextBox.Name = "EnfermedadTextBox"
        Me.EnfermedadTextBox.Size = New System.Drawing.Size(628, 20)
        Me.EnfermedadTextBox.TabIndex = 24
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(15, 164)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(668, 125)
        Me.DescripcionTextBox.TabIndex = 26
        '
        'MedicamentosTextBox
        '
        Me.MedicamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Medicamentos", True))
        Me.MedicamentosTextBox.Location = New System.Drawing.Point(15, 308)
        Me.MedicamentosTextBox.Multiline = True
        Me.MedicamentosTextBox.Name = "MedicamentosTextBox"
        Me.MedicamentosTextBox.Size = New System.Drawing.Size(668, 102)
        Me.MedicamentosTextBox.TabIndex = 28
        '
        'TratamientoTextBox
        '
        Me.TratamientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Tratamiento", True))
        Me.TratamientoTextBox.Location = New System.Drawing.Point(15, 429)
        Me.TratamientoTextBox.Multiline = True
        Me.TratamientoTextBox.Name = "TratamientoTextBox"
        Me.TratamientoTextBox.Size = New System.Drawing.Size(668, 153)
        Me.TratamientoTextBox.TabIndex = 30
        '
        'VideoTextBox
        '
        Me.VideoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "Video", True))
        Me.VideoTextBox.Location = New System.Drawing.Point(15, 601)
        Me.VideoTextBox.Name = "VideoTextBox"
        Me.VideoTextBox.Size = New System.Drawing.Size(628, 20)
        Me.VideoTextBox.TabIndex = 32
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HistoriasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(64, 47)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.FechaDateTimePicker.TabIndex = 34
        Me.FechaDateTimePicker.Value = New Date(2013, 3, 16, 0, 0, 0, 0)
        '
        'Buscar
        '
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Location = New System.Drawing.Point(647, 125)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(36, 20)
        Me.Buscar.TabIndex = 35
        Me.Buscar.Text = "..."
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo.Location = New System.Drawing.Point(15, 638)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(135, 54)
        Me.Nuevo.TabIndex = 37
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'HistoriasTableAdapter
        '
        Me.HistoriasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConfiguracionTableAdapter = Nothing
        Me.TableAdapterManager.EnfermedadesTableAdapter = Me.EnfermedadesTableAdapter
        Me.TableAdapterManager.HistoriasTableAdapter = Me.HistoriasTableAdapter
        Me.TableAdapterManager.UpdateOrder = MultiCHC.CHCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EnfermedadesTableAdapter
        '
        Me.EnfermedadesTableAdapter.ClearBeforeFill = True
        '
        'IDpacienteTextBox
        '
        Me.IDpacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistoriasBindingSource, "IDpaciente", True))
        Me.IDpacienteTextBox.Enabled = False
        Me.IDpacienteTextBox.Location = New System.Drawing.Point(153, 48)
        Me.IDpacienteTextBox.Name = "IDpacienteTextBox"
        Me.IDpacienteTextBox.Size = New System.Drawing.Size(50, 20)
        Me.IDpacienteTextBox.TabIndex = 38
        '
        'PacientesBindingNavigator
        '
        Me.PacientesBindingNavigator.AddNewItem = Nothing
        Me.PacientesBindingNavigator.BindingSource = Me.HistoriasBindingSource
        Me.PacientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PacientesBindingNavigator.DeleteItem = Nothing
        Me.PacientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.HistoriasClinicas})
        Me.PacientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PacientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PacientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PacientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PacientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PacientesBindingNavigator.Name = "PacientesBindingNavigator"
        Me.PacientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PacientesBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.PacientesBindingNavigator.TabIndex = 39
        Me.PacientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        'HistoriasClinicas
        '
        Me.HistoriasClinicas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HistoriasClinicas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HistoriasClinicas.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.HistoriasClinicas.Name = "HistoriasClinicas"
        Me.HistoriasClinicas.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.HistoriasClinicas.Size = New System.Drawing.Size(23, 22)
        Me.HistoriasClinicas.Text = "ToolStripButton1"
        Me.HistoriasClinicas.ToolTipText = "Historias Clinicas"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.MultiCHC.My.Resources.Resources.Reproducir
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(655, 601)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'EnfermedadesBindingSource
        '
        Me.EnfermedadesBindingSource.DataMember = "Enfermedades"
        Me.EnfermedadesBindingSource.DataSource = Me.CHCDataSet
        '
        'EnfermedadTextBox1
        '
        Me.EnfermedadTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Enfermedad", True))
        Me.EnfermedadTextBox1.Location = New System.Drawing.Point(915, 251)
        Me.EnfermedadTextBox1.Name = "EnfermedadTextBox1"
        Me.EnfermedadTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EnfermedadTextBox1.TabIndex = 40
        Me.EnfermedadTextBox1.Visible = False
        '
        'DescripcionTextBox1
        '
        Me.DescripcionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Descripcion", True))
        Me.DescripcionTextBox1.Location = New System.Drawing.Point(915, 277)
        Me.DescripcionTextBox1.Name = "DescripcionTextBox1"
        Me.DescripcionTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox1.TabIndex = 42
        Me.DescripcionTextBox1.Visible = False
        '
        'MedicamentosTextBox1
        '
        Me.MedicamentosTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Medicamentos", True))
        Me.MedicamentosTextBox1.Location = New System.Drawing.Point(915, 303)
        Me.MedicamentosTextBox1.Name = "MedicamentosTextBox1"
        Me.MedicamentosTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MedicamentosTextBox1.TabIndex = 44
        Me.MedicamentosTextBox1.Visible = False
        '
        'TratamientoTextBox1
        '
        Me.TratamientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Tratamiento", True))
        Me.TratamientoTextBox1.Location = New System.Drawing.Point(915, 329)
        Me.TratamientoTextBox1.Name = "TratamientoTextBox1"
        Me.TratamientoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TratamientoTextBox1.TabIndex = 46
        Me.TratamientoTextBox1.Visible = False
        '
        'VideoTextBox1
        '
        Me.VideoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "Video", True))
        Me.VideoTextBox1.Location = New System.Drawing.Point(915, 355)
        Me.VideoTextBox1.Name = "VideoTextBox1"
        Me.VideoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.VideoTextBox1.TabIndex = 48
        Me.VideoTextBox1.Visible = False
        '
        'IDenfermedadTextBox
        '
        Me.IDenfermedadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnfermedadesBindingSource, "IDenfermedad", True))
        Me.IDenfermedadTextBox.Location = New System.Drawing.Point(915, 225)
        Me.IDenfermedadTextBox.Name = "IDenfermedadTextBox"
        Me.IDenfermedadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDenfermedadTextBox.TabIndex = 50
        Me.IDenfermedadTextBox.Visible = False
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 702)
        Me.Controls.Add(Me.EnfermedadTextBox1)
        Me.Controls.Add(Me.DescripcionTextBox1)
        Me.Controls.Add(Me.MedicamentosTextBox1)
        Me.Controls.Add(Me.TratamientoTextBox1)
        Me.Controls.Add(Me.VideoTextBox1)
        Me.Controls.Add(Me.IDenfermedadTextBox)
        Me.Controls.Add(Me.PacientesBindingNavigator)
        Me.Controls.Add(Me.IDpacienteTextBox)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
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
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.Guardar)
        Me.MinimizeBox = False
        Me.Name = "Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.HistoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacientesBindingNavigator.ResumeLayout(False)
        Me.PacientesBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnfermedadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicamentosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TratamientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VideoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents CHCDataSet As MultiCHC.CHCDataSet
    Friend WithEvents HistoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HistoriasTableAdapter As MultiCHC.CHCDataSetTableAdapters.HistoriasTableAdapter
    Friend WithEvents TableAdapterManager As MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDpacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PacientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HistoriasClinicas As System.Windows.Forms.ToolStripButton
    Friend WithEvents EnfermedadesTableAdapter As MultiCHC.CHCDataSetTableAdapters.EnfermedadesTableAdapter
    Friend WithEvents EnfermedadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnfermedadTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MedicamentosTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TratamientoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VideoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IDenfermedadTextBox As System.Windows.Forms.TextBox
End Class
