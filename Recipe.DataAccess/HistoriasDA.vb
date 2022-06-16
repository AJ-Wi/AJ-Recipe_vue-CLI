Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class HistoriasDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("HC"))

    Public Shared Function Existe(ByVal ID As Integer) As Boolean
        Dim num As Integer = 0

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT Count(*) FROM Historias WHERE IDpaciente = @IDpaciente"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDpaciente", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal Historias As HistoriasEntity) As HistoriasEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO Historias (Cedula, Nombre, Enfermedad, Medicamentos, Terapia, Dietas, URLVideo, Fecha, Tipo, Lugar, FechaNacimiento, FechaExpiracion, RutaImagen)" & _
                                                  " VALUES (@Cedula, @Nombre, @Enfermedad, @Medicamentos, @Terapia, @Dietas, @URLVideo, @Fecha, @Tipo, @Lugar, @FechaNacimiento, @FechaExpiracion, @RutaImagen)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Cedula", Historias.Cedula)
            oleDbCommand.Parameters.AddWithValue("@Nombre", Historias.Nombre)
            oleDbCommand.Parameters.AddWithValue("@Enfermedad", Historias.Enfermedad)
            oleDbCommand.Parameters.AddWithValue("@Medicamentos", Historias.Medicamentos)
            oleDbCommand.Parameters.AddWithValue("@Terapia", Historias.Terapia)
            oleDbCommand.Parameters.AddWithValue("@Dietas", Historias.Dietas)
            oleDbCommand.Parameters.AddWithValue("@URLVideo", Historias.URLVideo)
            oleDbCommand.Parameters.AddWithValue("@Fecha", Historias.Fecha)
            oleDbCommand.Parameters.AddWithValue("@Tipo", Historias.Tipo)
            oleDbCommand.Parameters.AddWithValue("@Lugar", Historias.Lugar)
            oleDbCommand.Parameters.AddWithValue("@FechaNacimiento", Historias.FechaNacimiento)
            oleDbCommand.Parameters.AddWithValue("@FechaExpiracion", Historias.FechaExpiracion)
            oleDbCommand.Parameters.AddWithValue("@RutaImagen", Historias.RutaImagen)
            Historias.IDpaciente = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Historias
    End Function

    Public Shared Function Actualizar(ByVal Historias As HistoriasEntity) As HistoriasEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "UPDATE Historias SET  Cedula = @Cedula, Nombre = @Nombre, Enfermedad = @Enfermedad, Medicamentos = @Medicamentos, Terapia = @Terapia," & _
                                    " Dietas = @Dietas, URLVideo = @URLVideo, Fecha = @Fecha, Tipo = @Tipo, Lugar = @Lugar, FechaNacimiento = @FechaNacimiento," & _
                                    " FechaExpiracion = @FechaExpiracion, RutaImagen = @RutaImagen WHERE IDpaciente = @IDpaciente"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Cedula", Historias.Cedula)
            oleDbCommand.Parameters.AddWithValue("@Nombre", Historias.Nombre)
            oleDbCommand.Parameters.AddWithValue("@Enfermedad", Historias.Enfermedad)
            oleDbCommand.Parameters.AddWithValue("@Medicamentos", Historias.Medicamentos)
            oleDbCommand.Parameters.AddWithValue("@Terapia", Historias.Terapia)
            oleDbCommand.Parameters.AddWithValue("@Dietas", Historias.Dietas)
            oleDbCommand.Parameters.AddWithValue("@URLVideo", Historias.URLVideo)
            oleDbCommand.Parameters.AddWithValue("@Fecha", Historias.Fecha)
            oleDbCommand.Parameters.AddWithValue("@Tipo", Historias.Tipo)
            oleDbCommand.Parameters.AddWithValue("@Lugar", Historias.Lugar)
            oleDbCommand.Parameters.AddWithValue("@FechaNacimiento", Historias.FechaNacimiento)
            oleDbCommand.Parameters.AddWithValue("@FechaExpiracion", Historias.FechaExpiracion)
            oleDbCommand.Parameters.AddWithValue("@IDpaciente", Historias.IDpaciente)
            oleDbCommand.Parameters.AddWithValue("@RutaImagen", Historias.RutaImagen)
            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Historias
    End Function

    Public Shared Function BuscarPorId(ByVal ID As Integer) As HistoriasEntity
        Dim result As HistoriasEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Historias WHERE IDpaciente = @IDpaciente"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDpaciente", ID)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()

            If oleDbDataReader.Read() = True Then
                result = HistoriasDA.CargarHistorias(oleDbDataReader)
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
            Dim cmdText As String = "DELETE * FROM Historias WHERE IDpaciente = @IDpaciente"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDpaciente", ID)
            oleDbCommand.ExecuteScalar()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
    End Sub

    Private Shared Function CargarHistorias(ByVal reader As IDataReader) As HistoriasEntity

        Try

            If reader("Tipo").ToString = "Formato Normal" Then
                Return New HistoriasEntity() With {.IDpaciente = CInt(reader("IDpaciente")), _
                                       .Cedula = CStr(reader("Cedula")), _
                                       .Nombre = CStr(reader("Nombre")), _
                                       .Enfermedad = CStr(reader("Enfermedad")), _
                                       .Medicamentos = CStr(reader("Medicamentos")), _
                                       .Terapia = reader("Terapia").ToString, _
                                       .Dietas = reader("Dietas").ToString, _
                                       .URLVideo = reader("URLVideo").ToString, _
                                       .Fecha = CStr(reader("Fecha")), _
                                       .Tipo = CStr(reader("Tipo")), _
                                       .RutaImagen = reader("RutaImagen").ToString}
            Else
                Return New HistoriasEntity() With {.IDpaciente = CInt(reader("IDpaciente")), _
                           .Cedula = CStr(reader("Cedula")), _
                           .Nombre = CStr(reader("Nombre")), _
                           .Enfermedad = CStr(reader("Enfermedad")), _
                           .Medicamentos = CStr(reader("Medicamentos")), _
                           .Terapia = CStr(reader("Terapia")), _
                           .Fecha = CStr(reader("Fecha")), _
                           .Tipo = CStr(reader("Tipo")), _
                           .Lugar = CStr(reader("Lugar")), _
                           .FechaNacimiento = CStr(reader("FechaNacimiento")), _
                           .FechaExpiracion = CStr(reader("FechaExpiracion"))}
            End If

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

    Public Shared Function BuscarPorCedula(ByVal Texto As String) As List(Of HistoriasEntity)
        Dim list As List(Of HistoriasEntity) = New List(Of HistoriasEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Historias WHERE Cedula = @Cedula"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Cedula", Texto)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(HistoriasDA.CargarPorCedula(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return list
    End Function

    Private Shared Function CargarPorCedula(ByVal reader As IDataReader) As HistoriasEntity

        Try

            Return New HistoriasEntity() With {.IDpaciente = CInt(reader("IDpaciente")), _
                                               .Nombre = CStr(reader("Nombre")), _
                                               .Enfermedad = CStr(reader("Enfermedad")), _
                                               .Fecha = CStr(reader("Fecha"))}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

End Class
