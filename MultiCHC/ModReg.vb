Module ModReg

    Function NoEstaRegistrado() As Boolean
        On Error GoTo Err_Comando7_Click
        Dim Var1, Var2, Var3, Var4, Var5, Var6, Var7, Var8, Var9
        Dim Uno, dos, Tres, Cuatro, Cinco, Seis, Primera, Segunda
        Dim ClaveContraclave As Boolean
        Dim SerieDiscoduro As Boolean
        Dim FicheroExisteSN As Boolean
        Dim disco As String
        Uno = GetSetting("RegSystemWindows", "Reg2", "5")
        dos = GetSetting("RegSystemWindows", "Reg3", "5")
        Tres = GetSetting("RegSystemWindows", "Reg3", "10")
        Cuatro = GetSetting("RegSystemWindows", "Reg1", "3")
        Cinco = GetSetting("RegSystemWindows", "Reg2", "2")
        Seis = GetSetting("RegSystemWindows", "Numero_Registro", "2")

        If Len(Uno) = 0 Then
            NoEstaRegistrado = True
        Else
            Primera = Mid(dos, 1, 1)
            Segunda = Mid(dos, 2, 1)
            Var1 = Val(Mid(Uno, 1, 1))
            Var2 = Val(Mid(Uno, 2, 1))
            Var3 = Val(Mid(Uno, 3, 1))
            Var4 = Val(Mid(Uno, 4, 1))
            Var5 = Chr(64 + Var1 + Var2)
            Var6 = Chr(91 - Var3 - Var4)
            Var7 = Chr(70 + Var1 - Var4)
            Var8 = Chr(75 - Var3 + Var2)
            var9 = Chr(80 + Var4 + Var2)

            If Var5 = UCase(Primera) And Var6 = UCase(Segunda) _
            And Var7 = UCase(Cuatro) And Var8 = UCase(Cinco) _
            And Var9 = UCase(Seis) Then
                ClaveContraclave = True
            Else
                ClaveContraclave = False
            End If

            disco = Left(CurDir, 3)

            If Tres = VolumeSerialNumber(disco) Then

                SerieDiscoduro = True
            Else
                SerieDiscoduro = False
            End If

            If Len(Dir(Environ("WINDIR") & "\" & dos & ".dll")) <> 0 Then
                FicheroExisteSN = True
            Else
                FicheroExisteSN = False
            End If

            If ClaveContraclave And SerieDiscoduro And FicheroExisteSN Then
                NoEstaRegistrado = False
            Else
                NoEstaRegistrado = True
            End If

        End If
Exit_Comando7_Click:
        Exit Function

Err_Comando7_Click:
        MsgBox("Aviso Nº: " & Err.Number & " " & Err.Description, vbCritical + vbOKOnly, "Información")
        Resume Exit_Comando7_Click

    End Function

    Function MiraClaveAleatoria() As String
        Dim ClaveReg As String, Mivalor As String, Contador As Long

        ClaveReg = GetSetting("RegSystemWindows", "Reg2", "Aleatoria")

        If ClaveReg = "" Then
            For Contador = 1 To 12
                Randomize()
                Mivalor = Mivalor & Trim(Str(Int((8 * Rnd()) + 1)))
            Next Contador
            SaveSetting("RegSystemWindows", "Reg2", "Aleatoria", Mivalor)
            MiraClaveAleatoria = Str(Mivalor)
        Else
            MiraClaveAleatoria = ClaveReg
        End If

    End Function
End Module
