<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListar))
        Me.Filtro = New System.Windows.Forms.TextBox()
        Me.ListarDataGridView = New System.Windows.Forms.DataGridView()
        Me.Cuenta = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombregridview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDenfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDrecipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDconsejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDdieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDterapia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Terapia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnTransferir = New System.Windows.Forms.Button()
        CType(Me.ListarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Filtro
        '
        Me.Filtro.Location = New System.Drawing.Point(135, 12)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(285, 20)
        Me.Filtro.TabIndex = 0
        '
        'ListarDataGridView
        '
        Me.ListarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListarDataGridView.Location = New System.Drawing.Point(16, 38)
        Me.ListarDataGridView.Name = "ListarDataGridView"
        Me.ListarDataGridView.Size = New System.Drawing.Size(572, 486)
        Me.ListarDataGridView.TabIndex = 1
        '
        'Cuenta
        '
        Me.Cuenta.AutoSize = True
        Me.Cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.Location = New System.Drawing.Point(61, 532)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Size = New System.Drawing.Size(180, 15)
        Me.Cuenta.TabIndex = 2
        Me.Cuenta.Text = "100 Registros Encontrados"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 70
        '
        'Nombregridview
        '
        Me.Nombregridview.DataPropertyName = "Nombre"
        Me.Nombregridview.HeaderText = "Nombre"
        Me.Nombregridview.Name = "Nombregridview"
        Me.Nombregridview.ReadOnly = True
        Me.Nombregridview.Visible = False
        Me.Nombregridview.Width = 440
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "X"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 20
        '
        'IDenfermedad
        '
        Me.IDenfermedad.DataPropertyName = "IDenfermedad"
        Me.IDenfermedad.HeaderText = "ID"
        Me.IDenfermedad.Name = "IDenfermedad"
        Me.IDenfermedad.ReadOnly = True
        Me.IDenfermedad.Width = 50
        '
        'IDrecipe
        '
        Me.IDrecipe.DataPropertyName = "IDpaciente"
        Me.IDrecipe.HeaderText = "ID"
        Me.IDrecipe.Name = "IDrecipe"
        Me.IDrecipe.ReadOnly = True
        Me.IDrecipe.Visible = False
        Me.IDrecipe.Width = 50
        '
        'Enfermedad
        '
        Me.Enfermedad.DataPropertyName = "Enfermedad"
        Me.Enfermedad.HeaderText = "Enfermedad"
        Me.Enfermedad.Name = "Enfermedad"
        Me.Enfermedad.ReadOnly = True
        Me.Enfermedad.Width = 440
        '
        'IDconsejo
        '
        Me.IDconsejo.DataPropertyName = "IDconsejo"
        Me.IDconsejo.HeaderText = "ID"
        Me.IDconsejo.Name = "IDconsejo"
        Me.IDconsejo.ReadOnly = True
        Me.IDconsejo.Width = 50
        '
        'Consejo
        '
        Me.Consejo.DataPropertyName = "Consejo"
        Me.Consejo.HeaderText = "Consejo"
        Me.Consejo.Name = "Consejo"
        Me.Consejo.ReadOnly = True
        Me.Consejo.Width = 440
        '
        'IDdieta
        '
        Me.IDdieta.DataPropertyName = "IDdieta"
        Me.IDdieta.HeaderText = "ID"
        Me.IDdieta.Name = "IDdieta"
        Me.IDdieta.ReadOnly = True
        Me.IDdieta.Width = 50
        '
        'Dieta
        '
        Me.Dieta.DataPropertyName = "Dieta"
        Me.Dieta.HeaderText = "Dieta"
        Me.Dieta.Name = "Dieta"
        Me.Dieta.ReadOnly = True
        Me.Dieta.Width = 440
        '
        'IDterapia
        '
        Me.IDterapia.DataPropertyName = "IDterapia"
        Me.IDterapia.HeaderText = "ID"
        Me.IDterapia.Name = "IDterapia"
        Me.IDterapia.ReadOnly = True
        Me.IDterapia.Width = 50
        '
        'Terapia
        '
        Me.Terapia.DataPropertyName = "Terapia"
        Me.Terapia.HeaderText = "Terapia"
        Me.Terapia.Name = "Terapia"
        Me.Terapia.ReadOnly = True
        Me.Terapia.Width = 440
        '
        'Salir
        '
        Me.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Salir.Location = New System.Drawing.Point(513, 543)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese la Cedula:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(463, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cedula:"
        Me.Label3.Visible = False
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(16, 54)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(444, 20)
        Me.Nombre.TabIndex = 7
        Me.Nombre.Visible = False
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(466, 54)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(122, 20)
        Me.Cedula.TabIndex = 8
        Me.Cedula.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(351, 543)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnTransferir
        '
        Me.BtnTransferir.Location = New System.Drawing.Point(432, 543)
        Me.BtnTransferir.Name = "BtnTransferir"
        Me.BtnTransferir.Size = New System.Drawing.Size(75, 23)
        Me.BtnTransferir.TabIndex = 10
        Me.BtnTransferir.Text = "Transferir"
        Me.BtnTransferir.UseVisualStyleBackColor = True
        '
        'FrmListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Salir
        Me.ClientSize = New System.Drawing.Size(605, 578)
        Me.Controls.Add(Me.BtnTransferir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Cuenta)
        Me.Controls.Add(Me.ListarDataGridView)
        Me.Controls.Add(Me.Filtro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListar"
        Me.Text = "FrmListar"
        CType(Me.ListarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Filtro As System.Windows.Forms.TextBox
    Friend WithEvents ListarDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Cuenta As System.Windows.Forms.Label
    Friend WithEvents IDconsejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDdieta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dieta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDrecipe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDenfermedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Enfermedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDterapia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Terapia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Nombregridview As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnTransferir As System.Windows.Forms.Button
End Class
