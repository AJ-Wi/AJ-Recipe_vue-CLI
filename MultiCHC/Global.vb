Imports System.Data.OleDb

Module Globales

#Region "       Variables Publicas"

    Public RFecha As String = Environ("WINDIR") & "\system32\JobFc.dll"
    Public FicheroFecha As String, Nuevo As Boolean, Queda As String
    Public dataset As New DataSet
    Public Dato As String, mensaje As String, Pace As Date, CI As String, Imp As String

#End Region

    Public Sub SQLData(ByVal Tabla As String, ByVal Campo As String, ByVal Valor As String, ByVal Tipo As String, Optional ByVal Cambios As String = Nothing)
        Dim base As New OleDbConnection
        Dim rsbase As New OleDbDataAdapter
        Dim com As New OleDbCommand

        base.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\CHC.mdb"
        base.Open()

        Try

            Select Case Tipo
                Case "Editar"
                    com = New OleDbCommand("UPDATE " & Tabla & " SET " & Cambios & " WHERE (((" & Tabla & "." & Campo & ")=" & Valor & "))", base)
                Case "Guardar"
                    com = New OleDbCommand("INSERT INTO " & Tabla & " (" & Campo & ") VALUES ( " & Valor & ")", base)
                Case "Eliminar"
                    com = New OleDbCommand("DELETE FROM " & Tabla & " WHERE (((" & Tabla & "." & Campo & ")= " & Valor & "))", base)
                Case "CargarUnion"
                    rsbase = New OleDbDataAdapter("SELECT " & Campo & " FROM (" & Tabla & ") INNER JOIN " & Valor & " ON " & Tabla & "." & Cambios & "=" & _
                                                  Valor & "." & Cambios, base)
                    dataset.Clear()
                    rsbase.Fill(dataset, Tabla)
                    base.Close()
                    Exit Sub
            End Select

            com.ExecuteNonQuery()
            base.Close()

        Catch ex As Exception
            MsgBox("Error Nº " & Err.Number & " " & Err.Description, MsgBoxStyle.Information, "Error")
        End Try

    End Sub

    Public Function NombreIMG(ByVal Ruta As String) As String

        NombreIMG = Mid(Ruta, InStrRev(Ruta, "\") + 1, Len(Mid(Ruta, InStrRev(Ruta, "\") + 1)) - 4)

    End Function

    Public Function Encrip(ByVal Texto As String) As String
        Dim n As Long, i As Long, Chard As Long, LLave As String, Cadena As Long

        LLave = "MURCIELAGO"

        Texto = Trim(Texto)
        n = Len(LLave)

        For i = 1 To Len(Texto)

            Chard = Asc(Mid$(LLave, (i Mod n) - n * ((i Mod n) = 0), 1))
            Cadena = Asc(Mid$(Texto, i, 1))

            If Cadena = Chard Then
                Cadena = Cadena + 1
            End If

            Mid$(Texto, i, 1) = Chr(Cadena Xor Chard)

        Next

        Encrip = Texto

    End Function

#Region "       Validar caducidad del programa   "

    Sub EscribeFecha(ByVal Fecha)
        Dim Manejador As Long
        Manejador = FreeFile()
        FileOpen(Manejador, RFecha, OpenMode.Output)
        Print(Manejador, Encrip(Fecha & "el que logre desencriptar estas lieas es un guebito pelao, " & _
                                "que lo digo yo que me costo entender esto un poco y aprender a programarlo."))
        FileClose(Manejador)
    End Sub

    Sub LeerFecha()
        Dim Contenido As String

        If Len(Dir(RFecha)) <> 0 Then
            Contenido = My.Computer.FileSystem.ReadAllText(RFecha)
            FicheroFecha = Encrip(Contenido)
        Else
            EscribeFecha(DateString)
            Nuevo = True
        End If
    End Sub

    Function Vensido() As Boolean
        Dim Libre As String, Actual As String, Vence As String

        LeerFecha()
        If Nuevo = False Then

            If Mid(DateString, 7, 4) = Mid(FicheroFecha, 7, 4) Or Mid(DateString, 7, 4) = Mid(FicheroFecha, 7, 4) + 1 Then
                If Mid(DateString, 1, 2) = Mid(FicheroFecha, 1, 2) Or Mid(DateString, 1, 2) = Mid(FicheroFecha, 1, 2) + 1 Then

                    If Mid(FicheroFecha, 1, 2) <> Mid(DateString, 1, 2) Then
                        Queda = Mid(FicheroFecha, 4, 2) - Mid(DateString, 4, 2)
                    Else
                        Queda = Mid(FicheroFecha, 4, 2) + 30 - Mid(DateString, 4, 2)
                    End If

                    If Queda = 0 Then
                        Vensido = True
                    Else
                        Vensido = False
                    End If

                Else
                    Vensido = True
                End If

            Else
                Vensido = True
            End If

        Else
            Queda = 30
        End If

    End Function

#End Region

#Region "       Serial del Disco Duro"

    Function VolumeSerialNumber(ByVal RootPath As String) As String
        Dim fso As New Scripting.FileSystemObject
        Dim dr As Scripting.Drive
        Dim Serial As Long
        Dim s As String
        Dim a As String

        dr = fso.GetDrive(RootPath)
        Serial = dr.SerialNumber

        If Serial <> 0 Then
            'Creo 8 caracteres
            a = Hex(Serial)
            s = Right(a, 8)

            VolumeSerialNumber = Encriptar(Left(s, 4) + "-" + Right(s, 4))
        Else
            'Algo falla en la funcion, pues devuelvo un string cualquiera
            VolumeSerialNumber = Encriptar("0000-0000")
        End If
    End Function

    'Ahora encripto el VOL del HD
    Public Function Encriptar(ByVal Texto As String) As String
        Dim n As Long, i As Long, Chard As Long, LLave As String, Cadena As String

        LLave = "Sant"

        If CurDir() <> My.Application.Info.DirectoryPath Then ChDir(My.Application.Info.DirectoryPath)

        Texto = Trim(Texto)
        n = Len(LLave)

        For i = 1 To Len(Texto)

            Chard = Asc(Mid$(LLave, (i Mod n) - n * ((i Mod n) = 0), 1))
            Mid$(Texto, i, 1) = Chr(Asc(Mid$(Texto, i, 1)) Xor Chard)

        Next
        Encriptar = Texto

    End Function

#End Region

End Module
