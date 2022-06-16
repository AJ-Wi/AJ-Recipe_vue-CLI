Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class ConsejosDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("CC"))

    Public Shared Function CargarTodo() As List(Of ConsejosEntity)
        Dim list As List(Of ConsejosEntity) = New List(Of ConsejosEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Consejos ORDER BY IDconsejo"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(ConsejosDA.CargarConsejos(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return list
    End Function

    Public Shared Function BuscarPorId(ByVal ID As Integer) As ConsejosEntity
        Dim result As ConsejosEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Consejos WHERE IDconsejo = @IDconsejo"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDconsejo", ID)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = ConsejosDA.CargarConsejos(oleDbDataReader)
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
            Dim cmdText As String = "DELETE * FROM Consejos WHERE IDconsejo = @IDconsejo"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDconsejo", ID)
            oleDbCommand.ExecuteScalar()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
    End Sub

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of ConsejosEntity)
        Dim list As List(Of ConsejosEntity) = New List(Of ConsejosEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Consejos WHERE Consejo like " & Globales.CrearLike(Texto)
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(ConsejosDA.CargarConsejos(oleDbDataReader))
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
            Dim cmdText As String = "SELECT Count(*) FROM Consejos WHERE IDconsejo = @IDconsejo"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDconsejo", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal Consejos As ConsejosEntity) As ConsejosEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO Consejos (Consejo, RutaImagen) VALUES (@Consejo, @RutaImagen)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Consejo", Consejos.Consejo)
            oleDbCommand.Parameters.AddWithValue("@RutaImagen", Consejos.RutaImagen)
            Consejos.IDconsejo = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Consejos
    End Function

    Public Shared Function Actualizar(ByVal Consejos As ConsejosEntity) As ConsejosEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "UPDATE Consejos SET  Consejo = @Consejo, RutaImagen = @RutaImagen WHERE IDconsejo = @IDconsejo"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Consejo", Consejos.Consejo)
            oleDbCommand.Parameters.AddWithValue("@IDconsejo", Consejos.IDconsejo)
            oleDbCommand.Parameters.AddWithValue("@RutaImagen", Consejos.RutaImagen)
            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Consejos
    End Function

    Public Shared Function Transferir(ByVal ID As Integer, ByVal Tabla As String, Optional ByVal NombreEnfermedad As String = Nothing) As ConsejosEntity
        Dim Consejos As ConsejosEntity = BuscarPorId(ID)
        Dim cmdText As String = "INSERT INTO "

        Try

            Select Case Tabla
                Case "Enfermedades"
                    cmdText += "Enfermedades (Enfermedad, Medicamentos, URLVideo) VALUES " & _
                               "(" & NombreEnfermedad & ", " & Consejos.Consejo & ", " & Consejos.RutaImagen & ")"
                Case "Dietas"
                    cmdText += "Dietas (Dieta) VALUES " & _
                               "(" & Consejos.Consejo & ")"
                Case "Terapias"
                    cmdText += "Terapias (Terapia) VALUES " & _
                               "(" & Consejos.Consejo & ")"
            End Select

            oleDbConnection.Open()
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Consejos.IDconsejo = CInt(oleDbCommand.ExecuteScalar)

            EliminarPorID(ID)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Consejos
    End Function

    Private Shared Function CargarConsejos(ByVal reader As IDataReader) As ConsejosEntity

        Try

            Return New ConsejosEntity() With {.IDconsejo = CInt(reader("IDconsejo")), _
                                              .Consejo = CStr(reader("Consejo")), _
                                              .RutaImagen = reader("RutaImagen").ToString}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try
    End Function

End Class
