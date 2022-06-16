Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class TerapiasDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("CC"))

    Public Shared Function CargarTodo() As List(Of TerapiasEntity)
        Dim list As List(Of TerapiasEntity) = New List(Of TerapiasEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Terapias ORDER BY IDterapia"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(TerapiasDA.CargarTerapias(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return list
    End Function

    Public Shared Function BuscarPorId(ByVal ID As Integer) As TerapiasEntity
        Dim result As TerapiasEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Terapias WHERE IDterapia = @IDterapia"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDterapia", ID)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = TerapiasDA.CargarTerapias(oleDbDataReader)
            End If

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return result
    End Function

    Public Shared Sub EliminarPorID(ByVal ID As Integer)
        Try
            oleDbConnection.Open()
            Dim cmdText As String = "DELETE * FROM Terapias WHERE IDterapia = @IDterapia"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDterapia", ID)
            oleDbCommand.ExecuteScalar()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
    End Sub

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of TerapiasEntity)
        Dim list As List(Of TerapiasEntity) = New List(Of TerapiasEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Terapias WHERE Terapia like " & Globales.CrearLike(Texto)
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(TerapiasDA.CargarTerapias(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return list
    End Function

    Public Shared Function Existe(ByVal ID As Integer) As Boolean
        Dim num As Integer = 0

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT Count(*) FROM Terapias WHERE IDterapia = @IDterapia"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDterapia", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal Terapias As TerapiasEntity) As TerapiasEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO Terapias (Terapia) VALUES (@Terapia)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Terapia", Terapias.Terapia)
            Terapias.IDterapia = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Terapias
    End Function

    Public Shared Function Actualizar(ByVal Terapias As TerapiasEntity) As TerapiasEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "UPDATE Terapias SET  Terapia = @Terapia WHERE IDterapia = @IDterapia"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Terapia", Terapias.Terapia)
            oleDbCommand.Parameters.AddWithValue("@IDterapia", Terapias.IDterapia)
            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Terapias
    End Function

    Public Shared Function Transferir(ByVal ID As Integer, ByVal Tabla As String, Optional ByVal NombreEnfermedad As String = Nothing) As TerapiasEntity
        Dim Terapias As TerapiasEntity = BuscarPorId(ID)
        Dim cmdText As String = "INSERT INTO "

        Try

            Select Case Tabla
                Case "Enfermedades"
                    cmdText += "Enfermedades (Enfermedad, Medicamentos, URLVideo) VALUES " & _
                               "(" & NombreEnfermedad & ", " & Terapias.Terapia & ", "")"
                Case "Consejos"
                    cmdText += "Consejos (Consejo, RutaImagen) VALUES " & _
                               "(" & Terapias.Terapia & ", "")"
                Case "Dietas"
                    cmdText += "Dietas (Dieta) VALUES " & _
                               "(" & Terapias.Terapia & ")"
            End Select

            oleDbConnection.Open()
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Terapias.IDterapia = CInt(oleDbCommand.ExecuteScalar)

            EliminarPorID(ID)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Terapias
    End Function

    Private Shared Function CargarTerapias(ByVal reader As IDataReader) As TerapiasEntity

        Try

            Return New TerapiasEntity() With {.IDterapia = CInt(reader("IDterapia")), _
                                              .Terapia = CStr(reader("Terapia"))}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

End Class
