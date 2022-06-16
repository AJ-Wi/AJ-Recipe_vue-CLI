<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCamara
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
        Me.CamaraWeb = New WebCAM.WebCam()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CamaraWeb
        '
        Me.CamaraWeb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CamaraWeb.Imagen = Nothing
        Me.CamaraWeb.Location = New System.Drawing.Point(12, 12)
        Me.CamaraWeb.MilisegundosCaptura = 100
        Me.CamaraWeb.Name = "CamaraWeb"
        Me.CamaraWeb.Size = New System.Drawing.Size(166, 158)
        Me.CamaraWeb.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Capturar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCamara
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CamaraWeb)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCamara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camara"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CamaraWeb As WebCAM.WebCam
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
