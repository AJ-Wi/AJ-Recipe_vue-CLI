Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class EmpresaDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("Config"))

    Public Shared Function BuscarPorId(ByVal ID As Integer) As EmpresaEntity
        Dim result As EmpresaEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Empresa WHERE IDempresa = @IDempresa"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDempresa", ID)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = EmpresaDA.CargarEmpresa(oleDbDataReader)
            End If

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return result
    End Function

    Public Shared Function Existe(ByVal ID As Integer) As Boolean
        Dim num As Integer = 0

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT Count(*) FROM Empresa WHERE IDempresa = @IDempresa"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDempresa", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal Empresa As EmpresaEntity) As EmpresaEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO Empresa (Clinica, Medico, Cedula, NRegistro, Clinica2, Direccion, Direccion2, Telefono, Telefono2, Web, Web2, Correo, Correo2, Enunciado, Horario, Horario2, Logo) VALUES (@Clinica, @Medico, @Cedula, @NRegistro, @Clinica2, @Direccion, @Direccion2, @Telefono, @Telefono2, @Web, @Web2, @Correo, @Correo2, @Enunciado, @Horario, @Horario2, @Logo)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Clinica", Empresa.Clinica)
            oleDbCommand.Parameters.AddWithValue("@Medico", Empresa.Medico)
            oleDbCommand.Parameters.AddWithValue("@Cedula", Empresa.Cedula)
            oleDbCommand.Parameters.AddWithValue("@NRegistro", Empresa.NRegistro)
            oleDbCommand.Parameters.AddWithValue("@Clinica2", Empresa.Clinica2)
            oleDbCommand.Parameters.AddWithValue("@Direccion", Empresa.Direccion)
            oleDbCommand.Parameters.AddWithValue("@Direccion2", Empresa.Direccion2)
            oleDbCommand.Parameters.AddWithValue("@Telefono", Empresa.Telefono)
            oleDbCommand.Parameters.AddWithValue("@Telefono2", Empresa.Telefono2)
            oleDbCommand.Parameters.AddWithValue("@Web", Empresa.Web)
            oleDbCommand.Parameters.AddWithValue("@Web2", Empresa.Web2)
            oleDbCommand.Parameters.AddWithValue("@Correo", Empresa.Correo)
            oleDbCommand.Parameters.AddWithValue("@Correo2", Empresa.Correo2)
            oleDbCommand.Parameters.AddWithValue("@Enunciado", Empresa.Enunciado)
            oleDbCommand.Parameters.AddWithValue("@Horario", Empresa.Horario)
            oleDbCommand.Parameters.AddWithValue("@Horario2", Empresa.Horario2)
            oleDbCommand.Parameters.AddWithValue("@Logo", Empresa.Logo)
            oleDbCommand.Parameters.AddWithValue("@SubirBD", Empresa.SubirBD)
            Empresa.IDempresa = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Empresa
    End Function

    Public Shared Function Actualizar(ByVal Empresa As EmpresaEntity) As EmpresaEntity
        Dim cmdText As String = "UPDATE Empresa SET  "

        Try
            oleDbConnection.Open()
            cmdText += "Clinica = """ & Empresa.Clinica & """"
            cmdText += ", Medico = """ & Empresa.Medico & """"
            cmdText += ", Cedula = " & Empresa.Cedula
            cmdText += ", NRegistro = " & Empresa.NRegistro
            cmdText += ", Clinica2 = """ & Empresa.Clinica2 & """"
            cmdText += ", Direccion = """ & Empresa.Direccion & """"
            cmdText += ", Direccion2 = """ & Empresa.Direccion2 & """"
            cmdText += ", Telefono = """ & Empresa.Telefono & """"
            cmdText += ", Telefono2 = """ & Empresa.Telefono2 & """"
            cmdText += ", Web = """ & Empresa.Web & """"
            cmdText += ", Web2 = """ & Empresa.Web2 & """"
            cmdText += ", Correo = """ & Empresa.Correo & """"
            cmdText += ", Correo2 = """ & Empresa.Correo2 & """"
            cmdText += ", Enunciado = """ & Empresa.Enunciado & """"
            cmdText += ", Horario = """ & Empresa.Horario & """"
            cmdText += ", Horario2 = """ & Empresa.Horario2 & """"
            cmdText += ", Logo = """ & Empresa.Logo & """"
            cmdText += " WHERE IDempresa = " & Empresa.IDempresa
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)

            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
     oleDbConnection.Close()
        End Try
        Return Empresa
    End Function

    Private Shared Function CargarEmpresa(ByVal reader As IDataReader) As EmpresaEntity

        Try

            Return New EmpresaEntity() With {.IDempresa = CInt(reader("IDempresa")), _
                                             .Clinica = CStr(reader("Clinica")), _
                                             .Medico = CStr(reader("Medico")), _
                                             .Cedula = CInt(reader("Cedula")), _
                                             .NRegistro = CInt(reader("NRegistro")), _
                                             .Clinica2 = CStr(reader("Clinica2")), _
                                             .Direccion = CStr(reader("Direccion")), _
                                             .Direccion2 = CStr(reader("Direccion2")), _
                                             .Telefono = CStr(reader("Telefono")), _
                                             .Telefono2 = CStr(reader("Telefono2")), _
                                             .Web = CStr(reader("Web")), _
                                             .Web2 = CStr(reader("Web2")), _
                                             .Correo = CStr(reader("Correo")), _
                                             .Correo2 = CStr(reader("Correo2")), _
                                             .Enunciado = CStr(reader("Enunciado")), _
                                             .Horario = CStr(reader("Horario")), _
                                             .Horario2 = CStr(reader("Horario2")), _
                                             .Logo = CStr(reader("Logo")), _
                                             .SubirBD = CBool(reader("SubirBD"))}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

End Class
