Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class EnfermedadesDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("CC"))

    Public Shared Function CargarTodo() As List(Of EnfermedadesEntity)
        Dim list As List(Of EnfermedadesEntity) = New List(Of EnfermedadesEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Enfermedades ORDER BY Enfermedad"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(EnfermedadesDA.CargarEnfermedades(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return list
    End Function

    Public Shared Function BuscarPorId(ByVal ID As Integer) As EnfermedadesEntity
        Dim result As EnfermedadesEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Enfermedades WHERE IDenfermedad = @IDenfermedad"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDenfermedad", ID)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = EnfermedadesDA.CargarEnfermedades(oleDbDataReader)
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
            Dim cmdText As String = "DELETE * FROM Enfermedades WHERE IDenfermedad = @IDenfermedad"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDenfermedad", ID)
            oleDbCommand.ExecuteScalar()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
    End Sub

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of EnfermedadesEntity)
        Dim list As List(Of EnfermedadesEntity) = New List(Of EnfermedadesEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Enfermedades WHERE Enfermedad like " & Globales.CrearLike(Texto)
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(EnfermedadesDA.CargarEnfermedades(oleDbDataReader))
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
            Dim cmdText As String = "SELECT Count(*) FROM Enfermedades WHERE IDenfermedad = @IDenfermedad"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDenfermedad", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal Enfermedades As EnfermedadesEntity) As EnfermedadesEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO Enfermedades (Enfermedad, Medicamentos, URLVideo) VALUES (@Enfermedad, @Medicamentos, @URLVideo)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Enfermedad", Enfermedades.Enfermedad)
            oleDbCommand.Parameters.AddWithValue("@Medicamentos", Enfermedades.Medicamentos)
            oleDbCommand.Parameters.AddWithValue("@URLVideo", Enfermedades.URLVideo)
            Enfermedades.IDenfermedad = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Enfermedades
    End Function

    Public Shared Function Actualizar(ByVal Enfermedades As EnfermedadesEntity) As EnfermedadesEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "UPDATE Enfermedades SET  Enfermedad = @Enfermedad, Medicamentos = @Medicamentos, URLVideo = @URLVideo WHERE IDenfermedad = @IDenfermedad"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Enfermedad", Enfermedades.Enfermedad)
            oleDbCommand.Parameters.AddWithValue("@Medicamentos", Enfermedades.Medicamentos)
            oleDbCommand.Parameters.AddWithValue("@URLVideo", Enfermedades.URLVideo)
            oleDbCommand.Parameters.AddWithValue("@IDenfermedad", Enfermedades.IDenfermedad)
            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Enfermedades
    End Function

    Public Shared Function Transferir(ByVal ID As Integer, ByVal Tabla As String) As EnfermedadesEntity
        Dim Enfermedades As EnfermedadesEntity = BuscarPorId(ID)
        Dim cmdText As String = "INSERT INTO "

        Try

            Select Case Tabla
                Case "Consejos"
                    cmdText += "Consejos (Consejo, RutaImagen) VALUES " & _
                               "(" & Enfermedades.Medicamentos & ", " & Enfermedades.URLVideo & ")"
                Case "Dietas"
                    cmdText += "Dietas (Dieta) VALUES " & _
                               "(" & Enfermedades.Medicamentos & ")"
                Case "Terapias"
                    cmdText += "Terapias (Terapia) VALUES " & _
                               "(" & Enfermedades.Medicamentos & ")"
            End Select

            oleDbConnection.Open()
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Enfermedades.IDenfermedad = CInt(oleDbCommand.ExecuteScalar)

            EliminarPorID(ID)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Enfermedades
    End Function

    Private Shared Function CargarEnfermedades(ByVal reader As IDataReader) As EnfermedadesEntity

        Try

            Return New EnfermedadesEntity() With {.IDenfermedad = CInt(reader("IDenfermedad")), _
                                                  .Enfermedad = CStr(reader("Enfermedad")), _
                                                  .Medicamentos = CStr(reader("Medicamentos")), _
                                                  .URLVideo = reader("URLVideo").ToString}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

End Class
