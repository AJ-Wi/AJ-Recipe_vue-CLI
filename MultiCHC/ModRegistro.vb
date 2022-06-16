Option Explicit On

Module ModRegistro
    Public Cuantasveces As Integer


    Function FinalX(ByVal ClavEX As String, ByVal NumeroX As String) As Boolean
        On Error GoTo Err_Etiqueta_Error
        Dim Var1, Var2, Var3, Var4, Var5, Var6, Var7, Var8, Var9
        If Len(ClavEX) = 0 Then
            MsgBox("La clave de instalación está vacía.", vbCritical + vbOKOnly, _
                "Clave de Instalación nula")
            FinalX = False
            Exit Function
        End If
        
        Var1 = Val(Mid(NumeroX, 1, 1))
        Var2 = Val(Mid(NumeroX, 2, 1))
        Var3 = Val(Mid(NumeroX, 3, 1))
        Var4 = Val(Mid(NumeroX, 4, 1))
        Var5 = Chr(64 + Var1 + Var2)
        Var6 = Chr(91 - Var3 - Var4)
        Var7 = Chr(70 + Var1 - Var4)
        Var8 = Chr(75 - Var3 + Var2)
        var9 = Chr(80 + Var4 + Var2)

        If Var5 = UCase(Mid(ClavEX, 3, 1)) And Var6 = UCase(Mid(ClavEX, 7, _
            1)) And Var7 = UCase(Mid(ClavEX, 13, 1)) And Var8 = UCase(Mid(ClavEX, 16, 1)) And Var9 = UCase(Mid(ClavEX, 25, 1)) Then
            SaveAsText(NumeroX, UCase(Mid(ClavEX, 3, 1)), UCase(Mid(ClavEX, 7, _
                1)), UCase(Mid(ClavEX, 13, 1)), UCase(Mid(ClavEX, 16, 1)), UCase(Mid(ClavEX, 25, 1)))
            FinalX = True

        Else

            Beep()
            MsgBox( _
                "La Clave no es correcta: Consulte con el Autor del programa: (0412)-5835838", vbCritical + vbOKOnly, "ERROR EN LA CLAVE")
            FinalX = False
        End If

Exit_Etiqueta_Error:
        Exit Function

Err_Etiqueta_Error:
        MsgBox("Aviso Nº: " & Err.Number & " " & Err.Description, vbCritical + vbOKOnly, "Información")
        Resume Exit_Etiqueta_Error
    End Function

    Function SaveAsText(ByVal One1 As String, ByVal One2 As String, ByVal One3 As String, ByVal One4 As String, ByVal One5 As String, ByVal One6 As String)
        On Error GoTo Err_Etiqueta_Error
        Dim RutaFicheroWindows As String
        Dim RutaFicheroLocal As String
        Dim MiHdEncriptado As String
        Dim disco As String

        disco = Left(CurDir, 3)
        MiHdEncriptado = VolumeSerialNumber(disco)
        SaveSetting("RegSystemWindows", "Reg1", "Code", "False")
        SaveSetting("RegSystemWindows", "Reg1", 1, "17654897")
        SaveSetting("RegSystemWindows", "Reg1", 2, "7566554371")
        SaveSetting("RegSystemWindows", "Reg1", 3, One4)
        SaveSetting("RegSystemWindows", "Reg1", 4, "087653421")
        SaveSetting("RegSystemWindows", "Reg2", 1, "False")
        SaveSetting("RegSystemWindows", "Reg2", 9, "False")
        SaveSetting("RegSystemWindows", "Reg2", 3, "HHFF&")
        SaveSetting("RegSystemWindows", "Reg2", 4, "-1")
        SaveSetting("RegSystemWindows", "Reg2", 5, One1)
        SaveSetting("RegSystemWindows", "Reg2", 2, One5)
        SaveSetting("RegSystemWindows", "Reg2", 6, "17639007")
        SaveSetting("RegSystemWindows", "Reg2", 7, "756645371")
        SaveSetting("RegSystemWindows", "Reg2", 8, "087653421")
        SaveSetting("RegSystemWindows", "Reg3", 1, "True")
        SaveSetting("RegSystemWindows", "Reg3", 2, "False")
        SaveSetting("RegSystemWindows", "Reg3", 3, "FFHHFF&")
        SaveSetting("RegSystemWindows", "Reg3", 4, "+1")
        SaveSetting("RegSystemWindows", "Reg3", 5, One2 & One3)
        SaveSetting("RegSystemWindows", "Reg3", 6, "S")
        SaveSetting("RegSystemWindows", "Reg3", 7, "W")
        SaveSetting("RegSystemWindows", "Reg3", 8, "CMOS.OCX")
        SaveSetting("RegSystemWindows", "Reg3", 9, "Win.drv")
        SaveSetting("RegSystemWindows", "Reg3", 10, MiHdEncriptado)
        RutaFicheroWindows = Environ("WINDIR") & "\" & Dir(Environ("WINDIR") & "\*.ini")
        RutaFicheroLocal = Environ("WINDIR") & "\" & One2 & One3 & ".dll"
        FileCopy(RutaFicheroWindows, RutaFicheroLocal)
        SaveSetting("MultiSCA", "TwPacTit", 1, "MultiSCA")
        SaveSetting("MultiSCA", "Registro", 1, "#~æöƒóàâ#")
        SaveSetting("MultiSCA", "Numero_Registro", 2, One6)
        SaveSetting("MultiSCA", "Numero_Registro", 1, "FFHH03F6F0")
        SaveSetting("MultiSCA", "User", 1, "Registro=False")

Exit_Etiqueta_Error:
        Exit Function

Err_Etiqueta_Error:
        MsgBox("Aviso Nº: " & Err.Number & " " & Err.Description, vbCritical + vbOKOnly, "Información")
        Resume Exit_Etiqueta_Error

    End Function

    Function ConTrol(ByVal NumeroX) As String
        On Error GoTo Err_Etiqueta_Error
        Dim Var1, Var2, Var3, Var4, Var5, Var6

        Var1 = Val(Mid(NumeroX, 9, 1))
        Var2 = Val(Mid(NumeroX, 10, 1))
        Var3 = Val(Mid(NumeroX, 11, 1))
        Var4 = Val(Mid(NumeroX, 12, 1))
        Var5 = Chr(64 + Var1 + Var2)
        Var6 = Chr(91 - Var3 - Var4)
        ConTrol = "PAC-" & Var5 & Var6 & "-CAP"
Exit_Etiqueta_Error:
        Exit Function

Err_Etiqueta_Error:
        MsgBox("Aviso Nº: " & Err.Number & " " & Err.Description, vbCritical + vbOKOnly, "Información")
        Resume Exit_Etiqueta_Error
    End Function
End Module
