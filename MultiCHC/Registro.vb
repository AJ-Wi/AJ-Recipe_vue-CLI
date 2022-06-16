Imports System.Windows.Forms

Public Class Registro

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Mivalor As String
        Dim Contador As Integer
        On Error GoTo Err_Etiqueta_Error

        If Vensido() = True Then
            Principal.Close()
        End If

        MsgBox("Bienvenido al programa de Registro", vbInformation + vbOKOnly, "Registro")

        'miro si ya hay clave aleatoria en elregistro
        Mivalor = MiraClaveAleatoria()


        Numero.Text = Mivalor
        ControLL.Text = ControLL.Text & " " & ConTrol(Mivalor)
        clave1.Focus()
Exit_Etiqueta_Error:
        Exit Sub

Err_Etiqueta_Error:
        MsgBox("Aviso Nº: " & Err.Number & " " & Err.Description, _
            vbCritical + vbOKOnly, "Información")
        Resume Exit_Etiqueta_Error
    End Sub

    Private Sub Registro_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Cuantasveces = 0
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        On Error GoTo Err_Etiqueta_Error
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim Clave As String


        ' aquí el codigo para avisar al usuario que ya está registrado
        '=============================================================
        If NoEstaRegistrado() = False Then
            MsgBox("Ud. ya está registrado.", _
                vbInformation + vbOKOnly, "Usuario Registrado")
            Me.Close()
            Exit Sub
        End If
        '=============================================================
        If clave1.Text = "" And clave2.Text = "" And clave3.Text = "" _
        And clave4.Text = "" And clave5.Text = "" Then
            MsgBox("Introduzca el Codigo de Activacion " & Chr(13) & " Póngase en contacto con el Administrador" & Chr(13) & " del Programa por el TLF. (0412)5835838", vbCritical, "AVISO")
            clave1.Focus()
            Exit Sub
        End If

        Clave = clave1.Text & clave2.Text & clave3.Text & clave4.Text & clave5.Text

        If FinalX(Clave, Numero.Text) = True Then
            MsgBox("Registro efectuado con éxito. " & Chr(13) _
                & " UD ya no tiene limitaciones en este programa", _
                vbInformation, "Registro OK")
            Me.Close()

        Else

            Cuantasveces = Cuantasveces + 1
            If Cuantasveces = 4 Then
                MsgBox("Demasiados intentos", vbCritical + vbOKOnly, _
                    "Fin de Registro")
                Me.Close()
            End If
            Exit Sub
        End If


Exit_Etiqueta_Error:
        Exit Sub

Err_Etiqueta_Error:
        MsgBox("Aviso Nº: " & Err.Number & " " & Err.Description, _
            vbCritical + vbOKOnly, "Información")
        Resume Exit_Etiqueta_Error
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

        If Principal.Visible = False Then
            Application.Exit()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub OK_Button_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Enter
        Dim Clave As String, Verificar As String, Comparar As String
        Dim Var1, Var2, Var3, Var4

        Clave = clave1.Text & clave2.Text & clave3.Text & clave4.Text & clave5.Text
        Var1 = GetSetting("RegSystemWindows", "Reg3", "5")
        Var2 = GetSetting("RegSystemWindows", "Reg1", "3")
        Var3 = GetSetting("RegSystemWindows", "Reg2", "2")
        Var4 = GetSetting("RegSystemWindows", "Numero_Registro", "2")

        Verificar = Mid(Clave, 3, 1) & Mid(Clave, 7, 1) & Mid(Clave, 13, 1) _
        & Mid(Clave, 16, 1) & Mid(Clave, 25, 1)

        Comparar = Var1 & Var2 & Var3 & Var4

        If Verificar = Comparar Then
            Me.bueno.Visible = True
            Me.malo.Visible = False
        Else
            Me.malo.Visible = True
            Me.bueno.Visible = False
        End If
    End Sub

    Private Sub clave1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clave1.TextChanged
        If Len(Me.clave1.Text) = 5 Then
            Me.clave2.Focus()
        End If
    End Sub

    Private Sub clave2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clave2.TextChanged
        If Len(Me.clave2.Text) = 5 Then
            Me.clave3.Focus()
        End If
    End Sub

    Private Sub clave3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clave3.TextChanged
        If Len(Me.clave3.Text) = 5 Then
            Me.clave4.Focus()
        End If
    End Sub

    Private Sub clave4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clave4.TextChanged
        If Len(Me.clave4.Text) = 5 Then
            Me.clave5.Focus()
        End If
    End Sub

    Private Sub clave5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clave5.TextChanged
        If Len(Me.clave5.Text) = 5 Then
            Me.OK_Button.Focus()
        End If
    End Sub

    Private Sub Registro_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Principal.Visible = False Then
            Application.Exit()
        Else
            Me.Close()
        End If
    End Sub
End Class
