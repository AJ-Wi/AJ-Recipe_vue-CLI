<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Dim MedicoLabel As System.Windows.Forms.Label
        Dim ClinicaLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.CHCDataSet = New MultiCHC.CHCDataSet
        Me.ConfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfiguracionTableAdapter = New MultiCHC.CHCDataSetTableAdapters.ConfiguracionTableAdapter
        Me.TableAdapterManager = New MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
        Me.MedicoTextBox = New System.Windows.Forms.TextBox
        Me.ClinicaTextBox = New System.Windows.Forms.TextBox
        Me.DireccionTextBox = New System.Windows.Forms.TextBox
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox
        Me.WebTextBox = New System.Windows.Forms.TextBox
        Me.CorreoTextBox = New System.Windows.Forms.TextBox
        Me.LogoTextBox = New System.Windows.Forms.TextBox
        Me.Cargar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Logo = New System.Windows.Forms.TextBox
        Me.Guardar = New System.Windows.Forms.Button
        MedicoLabel = New System.Windows.Forms.Label
        ClinicaLabel = New System.Windows.Forms.Label
        DireccionLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        WebLabel = New System.Windows.Forms.Label
        CorreoLabel = New System.Windows.Forms.Label
        LogoLabel = New System.Windows.Forms.Label
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicoLabel
        '
        MedicoLabel.AutoSize = True
        MedicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicoLabel.Location = New System.Drawing.Point(12, 19)
        MedicoLabel.Name = "MedicoLabel"
        MedicoLabel.Size = New System.Drawing.Size(52, 13)
        MedicoLabel.TabIndex = 1
        MedicoLabel.Text = "Medico:"
        '
        'ClinicaLabel
        '
        ClinicaLabel.AutoSize = True
        ClinicaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClinicaLabel.Location = New System.Drawing.Point(12, 58)
        ClinicaLabel.Name = "ClinicaLabel"
        ClinicaLabel.Size = New System.Drawing.Size(49, 13)
        ClinicaLabel.TabIndex = 3
        ClinicaLabel.Text = "Clinica:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(12, 97)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(65, 13)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(12, 197)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(61, 13)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "Telefono:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WebLabel.Location = New System.Drawing.Point(12, 236)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(37, 13)
        WebLabel.TabIndex = 9
        WebLabel.Text = "Web:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(12, 275)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(48, 13)
        CorreoLabel.TabIndex = 11
        CorreoLabel.Text = "Correo:"
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LogoLabel.Location = New System.Drawing.Point(404, 255)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(39, 13)
        LogoLabel.TabIndex = 13
        LogoLabel.Text = "Logo:"
        '
        'CHCDataSet
        '
        Me.CHCDataSet.DataSetName = "CHCDataSet"
        Me.CHCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConfiguracionTableAdapter = Me.ConfiguracionTableAdapter
        Me.TableAdapterManager.EnfermedadesTableAdapter = Nothing
        Me.TableAdapterManager.HistoriasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MultiCHC.CHCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MedicoTextBox
        '
        Me.MedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Medico", True))
        Me.MedicoTextBox.Location = New System.Drawing.Point(15, 35)
        Me.MedicoTextBox.Name = "MedicoTextBox"
        Me.MedicoTextBox.Size = New System.Drawing.Size(369, 20)
        Me.MedicoTextBox.TabIndex = 2
        '
        'ClinicaTextBox
        '
        Me.ClinicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Clinica", True))
        Me.ClinicaTextBox.Location = New System.Drawing.Point(15, 74)
        Me.ClinicaTextBox.Name = "ClinicaTextBox"
        Me.ClinicaTextBox.Size = New System.Drawing.Size(369, 20)
        Me.ClinicaTextBox.TabIndex = 4
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(15, 113)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(369, 81)
        Me.DireccionTextBox.TabIndex = 6
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(15, 213)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(369, 20)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(15, 252)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(369, 20)
        Me.WebTextBox.TabIndex = 10
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(15, 291)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(369, 20)
        Me.CorreoTextBox.TabIndex = 12
        '
        'LogoTextBox
        '
        Me.LogoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Logo", True))
        Me.LogoTextBox.Location = New System.Drawing.Point(444, 252)
        Me.LogoTextBox.Name = "LogoTextBox"
        Me.LogoTextBox.Size = New System.Drawing.Size(179, 20)
        Me.LogoTextBox.TabIndex = 14
        '
        'Cargar
        '
        Me.Cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargar.Location = New System.Drawing.Point(629, 252)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(36, 20)
        Me.Cargar.TabIndex = 36
        Me.Cargar.Text = "..."
        Me.Cargar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(407, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(444, 252)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(179, 20)
        Me.Logo.TabIndex = 38
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(463, 282)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(143, 40)
        Me.Guardar.TabIndex = 39
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 330)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cargar)
        Me.Controls.Add(MedicoLabel)
        Me.Controls.Add(Me.MedicoTextBox)
        Me.Controls.Add(ClinicaLabel)
        Me.Controls.Add(Me.ClinicaTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(LogoLabel)
        Me.Controls.Add(Me.LogoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opciones de MultiCHC"
        CType(Me.CHCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHCDataSet As MultiCHC.CHCDataSet
    Friend WithEvents ConfiguracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfiguracionTableAdapter As MultiCHC.CHCDataSetTableAdapters.ConfiguracionTableAdapter
    Friend WithEvents TableAdapterManager As MultiCHC.CHCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClinicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cargar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Logo As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
End Class
