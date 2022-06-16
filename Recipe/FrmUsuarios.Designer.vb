<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.ContraseñaLabel = New System.Windows.Forms.Label()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.Crear = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Usuario})
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(12, 29)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(262, 150)
        Me.UsuariosDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione la cuenta que desea cambiar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(13, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Crear una nueva cuenta"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Location = New System.Drawing.Point(77, 10)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(151, 20)
        Me.UsuarioTextBox.TabIndex = 3
        Me.UsuarioTextBox.Visible = False
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(77, 36)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ContraseñaTextBox.TabIndex = 4
        Me.ContraseñaTextBox.Visible = False
        '
        'TipoComboBox
        '
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Items.AddRange(New Object() {"Administrador", "Estandar"})
        Me.TipoComboBox.Location = New System.Drawing.Point(77, 62)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(151, 21)
        Me.TipoComboBox.TabIndex = 5
        Me.TipoComboBox.Visible = False
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(25, 13)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        Me.UsuarioLabel.TabIndex = 6
        Me.UsuarioLabel.Text = "Usuario:"
        Me.UsuarioLabel.Visible = False
        '
        'ContraseñaLabel
        '
        Me.ContraseñaLabel.AutoSize = True
        Me.ContraseñaLabel.Location = New System.Drawing.Point(7, 39)
        Me.ContraseñaLabel.Name = "ContraseñaLabel"
        Me.ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        Me.ContraseñaLabel.TabIndex = 7
        Me.ContraseñaLabel.Text = "Contraseña:"
        Me.ContraseñaLabel.Visible = False
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(37, 65)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(34, 13)
        Me.TipoLabel.TabIndex = 8
        Me.TipoLabel.Text = "Nivel:"
        Me.TipoLabel.Visible = False
        '
        'Crear
        '
        Me.Crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Crear.Location = New System.Drawing.Point(206, 177)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(75, 23)
        Me.Crear.TabIndex = 9
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        Me.Crear.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "IDusuario"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 200
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 206)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.ContraseñaLabel)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents ContraseñaLabel As System.Windows.Forms.Label
    Friend WithEvents TipoLabel As System.Windows.Forms.Label
    Friend WithEvents Crear As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
