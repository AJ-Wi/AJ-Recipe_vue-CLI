<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.clave1 = New System.Windows.Forms.TextBox
        Me.clave2 = New System.Windows.Forms.TextBox
        Me.clave3 = New System.Windows.Forms.TextBox
        Me.clave4 = New System.Windows.Forms.TextBox
        Me.clave5 = New System.Windows.Forms.TextBox
        Me.malo = New System.Windows.Forms.PictureBox
        Me.bueno = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ControLL = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.malo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bueno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(239, 209)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 5
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Cancelar"
        '
        'clave1
        '
        Me.clave1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.clave1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave1.Location = New System.Drawing.Point(44, 149)
        Me.clave1.MaxLength = 5
        Me.clave1.Name = "clave1"
        Me.clave1.Size = New System.Drawing.Size(48, 21)
        Me.clave1.TabIndex = 0
        Me.clave1.WordWrap = False
        '
        'clave2
        '
        Me.clave2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.clave2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave2.Location = New System.Drawing.Point(96, 149)
        Me.clave2.MaxLength = 5
        Me.clave2.Name = "clave2"
        Me.clave2.Size = New System.Drawing.Size(48, 21)
        Me.clave2.TabIndex = 1
        '
        'clave3
        '
        Me.clave3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.clave3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave3.Location = New System.Drawing.Point(148, 149)
        Me.clave3.MaxLength = 5
        Me.clave3.Name = "clave3"
        Me.clave3.Size = New System.Drawing.Size(48, 21)
        Me.clave3.TabIndex = 2
        '
        'clave4
        '
        Me.clave4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.clave4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave4.Location = New System.Drawing.Point(200, 149)
        Me.clave4.MaxLength = 5
        Me.clave4.Name = "clave4"
        Me.clave4.Size = New System.Drawing.Size(48, 21)
        Me.clave4.TabIndex = 3
        '
        'clave5
        '
        Me.clave5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.clave5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave5.Location = New System.Drawing.Point(252, 149)
        Me.clave5.MaxLength = 5
        Me.clave5.Name = "clave5"
        Me.clave5.Size = New System.Drawing.Size(48, 21)
        Me.clave5.TabIndex = 4
        '
        'malo
        '
        Me.malo.Image = Global.MultiCHC.My.Resources.Resources.Malo
        Me.malo.Location = New System.Drawing.Point(306, 125)
        Me.malo.Name = "malo"
        Me.malo.Size = New System.Drawing.Size(72, 71)
        Me.malo.TabIndex = 7
        Me.malo.TabStop = False
        Me.malo.Visible = False
        '
        'bueno
        '
        Me.bueno.Image = Global.MultiCHC.My.Resources.Resources.Fino
        Me.bueno.Location = New System.Drawing.Point(306, 136)
        Me.bueno.Name = "bueno"
        Me.bueno.Size = New System.Drawing.Size(77, 50)
        Me.bueno.TabIndex = 6
        Me.bueno.TabStop = False
        Me.bueno.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Introduzca el código de activación del producto suministrado por "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "El Administrador del Programa, Si no lo tiene o lo extravió, favor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ponerse en contacto por el TLF. (0412)5835838"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Código de Activación"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(148, 89)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(152, 20)
        Me.Numero.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Número de Producto"
        '
        'ControLL
        '
        Me.ControLL.AutoSize = True
        Me.ControLL.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControLL.Location = New System.Drawing.Point(7, 207)
        Me.ControLL.Name = "ControLL"
        Me.ControLL.Size = New System.Drawing.Size(52, 25)
        Me.ControLL.TabIndex = 14
        Me.ControLL.Text = "PID"
        '
        'Registro
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(398, 247)
        Me.Controls.Add(Me.ControLL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.malo)
        Me.Controls.Add(Me.bueno)
        Me.Controls.Add(Me.clave5)
        Me.Controls.Add(Me.clave4)
        Me.Controls.Add(Me.clave3)
        Me.Controls.Add(Me.clave2)
        Me.Controls.Add(Me.clave1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activación de Producto"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.malo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bueno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents clave1 As System.Windows.Forms.TextBox
    Friend WithEvents clave2 As System.Windows.Forms.TextBox
    Friend WithEvents clave3 As System.Windows.Forms.TextBox
    Friend WithEvents clave4 As System.Windows.Forms.TextBox
    Friend WithEvents clave5 As System.Windows.Forms.TextBox
    Friend WithEvents bueno As System.Windows.Forms.PictureBox
    Friend WithEvents malo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ControLL As System.Windows.Forms.Label

End Class
