Imports Actualizar

Public Class Globales

    Public Shared Function CrearLike(ByVal Cadena As String) As String
        Dim TMP As String = Nothing
        Dim n As Long

        Try

            For n = 1 To Len(Cadena)
                Select Case Mid$(UCase$(Cadena), CInt(n), 1)
                    Case "B", "V"
                        TMP = TMP & "[bvBV]"
                    Case "G", "J"
                        TMP = TMP & "[gjGJ]"
                    Case "A", "Á"
                        TMP = TMP & "[aáAÁ]"
                    Case "E", "É"
                        TMP = TMP & "[eéEÉ]"
                    Case "I", "Í"
                        TMP = TMP & "[iíIÍ]"
                    Case "O", "Ó"
                        TMP = TMP & "[oóOÓ]"
                    Case "U", "Ú"
                        TMP = TMP & "[uúUÚ]"
                    Case Else
                        TMP = TMP & Mid$(Cadena, CInt(n), 1)
                End Select
            Next n
        Catch x As Exception
            Errores(x)
        End Try
        Return TMP

    End Function

    Public Shared Sub Errores(ByVal ElError As Exception)
        Utility.ErrorGeneral(ElError, My.Computer.FileSystem.CurrentDirectory & "\AppErrores.err")
    End Sub

End Class
