<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransferir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransferir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnfermedadesCheckBox = New System.Windows.Forms.CheckBox()
        Me.DietasCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConsejosCheckBox = New System.Windows.Forms.CheckBox()
        Me.TerapiasCheckBox = New System.Windows.Forms.CheckBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marque la tabla a la que quiere transferir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los datos seleccionados."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnfermedadesCheckBox
        '
        Me.EnfermedadesCheckBox.AutoSize = True
        Me.EnfermedadesCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnfermedadesCheckBox.Location = New System.Drawing.Point(168, 77)
        Me.EnfermedadesCheckBox.Name = "EnfermedadesCheckBox"
        Me.EnfermedadesCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.EnfermedadesCheckBox.TabIndex = 1
        Me.EnfermedadesCheckBox.Text = "Enfermedades"
        Me.EnfermedadesCheckBox.UseVisualStyleBackColor = True
        '
        'DietasCheckBox
        '
        Me.DietasCheckBox.AutoSize = True
        Me.DietasCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DietasCheckBox.Location = New System.Drawing.Point(168, 54)
        Me.DietasCheckBox.Name = "DietasCheckBox"
        Me.DietasCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.DietasCheckBox.TabIndex = 2
        Me.DietasCheckBox.Text = "Dietas"
        Me.DietasCheckBox.UseVisualStyleBackColor = True
        '
        'ConsejosCheckBox
        '
        Me.ConsejosCheckBox.AutoSize = True
        Me.ConsejosCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsejosCheckBox.Location = New System.Drawing.Point(15, 54)
        Me.ConsejosCheckBox.Name = "ConsejosCheckBox"
        Me.ConsejosCheckBox.Size = New System.Drawing.Size(77, 17)
        Me.ConsejosCheckBox.TabIndex = 3
        Me.ConsejosCheckBox.Text = "Consejos"
        Me.ConsejosCheckBox.UseVisualStyleBackColor = True
        '
        'TerapiasCheckBox
        '
        Me.TerapiasCheckBox.AutoSize = True
        Me.TerapiasCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerapiasCheckBox.Location = New System.Drawing.Point(15, 77)
        Me.TerapiasCheckBox.Name = "TerapiasCheckBox"
        Me.TerapiasCheckBox.Size = New System.Drawing.Size(75, 17)
        Me.TerapiasCheckBox.TabIndex = 4
        Me.TerapiasCheckBox.Text = "Terapias"
        Me.TerapiasCheckBox.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aceptar.Enabled = False
        Me.Aceptar.Location = New System.Drawing.Point(228, 146)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 5
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(9, 120)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(287, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Enabled = False
        Me.NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLabel.Location = New System.Drawing.Point(12, 101)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(74, 13)
        Me.NombreLabel.TabIndex = 7
        Me.NombreLabel.Text = "Enfermedad"
        '
        'FrmTransferir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 176)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.TerapiasCheckBox)
        Me.Controls.Add(Me.ConsejosCheckBox)
        Me.Controls.Add(Me.DietasCheckBox)
        Me.Controls.Add(Me.EnfermedadesCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransferir"
        Me.Text = "Transferir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnfermedadesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DietasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ConsejosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TerapiasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
End Class
