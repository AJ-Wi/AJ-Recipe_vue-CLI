Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class DietasDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("CC"))

    Public Shared Function CargarTodo() As List(Of DietasEntity)
        Dim list As List(Of DietasEntity) = New List(Of DietasEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Dietas ORDER BY IDdieta"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(DietasDA.CargarDietas(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return list
    End Function

    Public Shared Function BuscarPorId(ByVal ID As Integer) As DietasEntity
        Dim result As DietasEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Dietas WHERE IDdieta like @IDdieta"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDdieta", ID)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = DietasDA.CargarDietas(oleDbDataReader)
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
            Dim cmdText As String = "DELETE * FROM Dietas WHERE IDdieta = @IDdieta"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDdieta", ID)
            oleDbCommand.ExecuteScalar()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
    End Sub

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of DietasEntity)
        Dim list As List(Of DietasEntity) = New List(Of DietasEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Dietas WHERE Dieta like " & Globales.CrearLike(Texto)
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(DietasDA.CargarDietas(oleDbDataReader))
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
            Dim cmdText As String = "SELECT Count(*) FROM Dietas WHERE IDdieta = @IDdieta"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDdieta", ID)
            num = CInt(oleDbCommand.ExecuteScalar())

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal Dietas As DietasEntity) As DietasEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO Dietas (Dieta) VALUES (@Dieta)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Dieta", Dietas.Dieta)
            Dietas.IDdieta = CInt(oleDbCommand.ExecuteScalar())

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Dietas
    End Function

    Public Shared Function Actualizar(ByVal Dietas As DietasEntity) As DietasEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "UPDATE Dietas SET  Dieta = @Dieta WHERE IDdieta = @IDdieta"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Dieta", Dietas.Dieta)
            oleDbCommand.Parameters.AddWithValue("@IDdieta", Dietas.IDdieta)
            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Dietas
    End Function

    Public Shared Function Transferir(ByVal ID As Integer, ByVal Tabla As String, Optional ByVal NombreEnfermedad As String = Nothing) As DietasEntity
        Dim Dietas As DietasEntity = BuscarPorId(ID)
        Dim cmdText As String = "INSERT INTO "

        Try

            Select Case Tabla
                Case "Enfermedades"
                    cmdText += "Enfermedades (Enfermedad, Medicamentos, URLVideo) VALUES " & _
                               "(" & NombreEnfermedad & ", " & Dietas.Dieta & ", "")"
                Case "Consejos"
                    cmdText += "Consejos (Consejo, RutaImagen) VALUES " & _
                               "(" & Dietas.Dieta & ", "")"
                Case "Terapias"
                    cmdText += "Terapias (Terapia) VALUES " & _
                               "(" & Dietas.Dieta & ")"
            End Select

            oleDbConnection.Open()
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dietas.IDdieta = CInt(oleDbCommand.ExecuteScalar)

            EliminarPorID(ID)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Dietas
    End Function

    Private Shared Function CargarDietas(ByVal reader As IDataReader) As DietasEntity

        Try

            Return New DietasEntity() With {.IDdieta = CInt(reader("IDdieta")), _
                                            .Dieta = CStr(reader("Dieta"))}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try
    End Function

End Class
