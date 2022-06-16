Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class PacientesDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("HC"))

    Public Shared Function BuscarPorCedula(ByVal Cedula As String) As PacientesEntity
        Dim result As PacientesEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM Pacientes WHERE Cedula = @Cedula"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Cedula", Cedula)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = PacientesDA.CargarPaciente(oleDbDataReader)
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
            Dim cmdText As String = "SELECT Count(*) FROM Pacientes WHERE Cedula = @Cedula"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Cedula", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function GuardarViejos(ByVal Pacientes As PacientesEntity) As PacientesEntity

        Try
            oleDbConnection.Open()

            Dim cmdText As String = "INSERT INTO Pacientes (Cedula, Nombre)" _
                                    & " VALUES" _
                                    & " (@Cedula, @Nombre)"

            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)

            oleDbCommand.Parameters.AddWithValue("@Cedula", Pacientes.Cedula)
            oleDbCommand.Parameters.AddWithValue("@Nombre", Pacientes.Nombre)

            Pacientes.Cedula = CStr(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Pacientes
    End Function

    Public Shared Function Guardar(ByVal Pacientes As PacientesEntity) As PacientesEntity

        Try
            oleDbConnection.Open()

            Dim cmdText As String = "INSERT INTO Pacientes (Cedula, Nombre, FechaNacimiento, Sexo, EstadoCivil, Ocupacion, TipoSangre, LugarOrigen, LugarResidencia," _
                                    & " Domicilio, Telefono, Religion, Escolaridad, Email, PersonaContacto, TelefonoContacto, ParentescoContacto, Diabetes, Hipertension," _
                                    & " Cardiopatia, Hepatopatia, Nefropatia, Mentales, Asma, Cancer, Alergicas, Endocrinas, FamiliaresOtros, Actuales, Quirurgicos," _
                                    & " Transfuciones, Alergias, Traumaticos, Hospitalizaciones, Adicciones, PersonalOtros, Duchas, Dientes, Habitacion, Tabaquismo," _
                                    & " Alcoholismo, Alimentacion, Deportes, Inmunizaciones, Pendientes, Desparacitacion)" _
                                    & " VALUES" _
                                    & " (@Cedula, @Nombre, @FechaNacimiento, @Sexo, @EstadoCivil, @Ocupacion, @TipoSangre, @LugarOrigen, @LugarResidencia, @Domicilio," _
                                    & " @Telefono, @Religion, @Escolaridad, @Email, @PersonaContacto, @TelefonoContacto, @ParentescoContacto, @Diabetes, @Hipertension," _
                                    & " @Cardiopatia, @Hepatopatia, @Nefropatia, @Mentales, @Asma, @Cancer, @Alergicas, @Endocrinas, @FamiliaresOtros, @Actuales," _
                                    & " @Quirurgicos, @Transfuciones, @Alergias, @Traumaticos, @Hospitalizaciones, @Adicciones, @PersonalOtros, @Duchas, @Dientes," _
                                    & " @Habitacion, @Tabaquismo, @Alcoholismo, @Alimentacion, @Deportes, @Inmunizaciones, @Pendientes, @Desparacitacion)"

            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)

            oleDbCommand.Parameters.AddWithValue("@Cedula", Pacientes.Cedula)
            oleDbCommand.Parameters.AddWithValue("@Nombre", Pacientes.Nombre)
            oleDbCommand.Parameters.AddWithValue("@FechaNacimiento", Pacientes.FechaNacimiento)
            oleDbCommand.Parameters.AddWithValue("@Sexo", Pacientes.Sexo)
            oleDbCommand.Parameters.AddWithValue("@EstadoCivil", Pacientes.EstadoCivil)
            oleDbCommand.Parameters.AddWithValue("@Ocupacion", Pacientes.Ocupacion)
            oleDbCommand.Parameters.AddWithValue("@TipoSangre", Pacientes.TipoSangre)
            oleDbCommand.Parameters.AddWithValue("@LugarOrigen", Pacientes.LugarOrigen)
            oleDbCommand.Parameters.AddWithValue("@LugarResidencia", Pacientes.LugarResidencia)
            oleDbCommand.Parameters.AddWithValue("@Domicilio", Pacientes.Domicilio)
            oleDbCommand.Parameters.AddWithValue("@Telefono", Pacientes.Telefono)
            oleDbCommand.Parameters.AddWithValue("@Religion", Pacientes.Religion)
            oleDbCommand.Parameters.AddWithValue("@Escolaridad", Pacientes.Escolaridad)
            oleDbCommand.Parameters.AddWithValue("@Email", Pacientes.Email)
            oleDbCommand.Parameters.AddWithValue("@PersonaContacto", Pacientes.PersonaContacto)
            oleDbCommand.Parameters.AddWithValue("@TelefonoContacto", Pacientes.TelefonoContacto)
            oleDbCommand.Parameters.AddWithValue("@ParentescoContacto", Pacientes.ParentescoContacto)
            oleDbCommand.Parameters.AddWithValue("@Diabetes", Pacientes.Diabetes)
            oleDbCommand.Parameters.AddWithValue("@Hipertension", Pacientes.Hipertension)
            oleDbCommand.Parameters.AddWithValue("@Cardiopatia", Pacientes.Cardiopatia)
            oleDbCommand.Parameters.AddWithValue("@Hepatopatia", Pacientes.Hepatopatia)
            oleDbCommand.Parameters.AddWithValue("@Nefropatia", Pacientes.Nefropatia)
            oleDbCommand.Parameters.AddWithValue("@Mentales", Pacientes.Mentales)
            oleDbCommand.Parameters.AddWithValue("@Asma", Pacientes.Asma)
            oleDbCommand.Parameters.AddWithValue("@Cancer", Pacientes.Cancer)
            oleDbCommand.Parameters.AddWithValue("@Alergicas", Pacientes.Alergicas)
            oleDbCommand.Parameters.AddWithValue("@Endocrinas", Pacientes.Endocrinas)
            oleDbCommand.Parameters.AddWithValue("@FamiliaresOtros", Pacientes.FamiliaresOtros)
            oleDbCommand.Parameters.AddWithValue("@Actuales", Pacientes.Actuales)
            oleDbCommand.Parameters.AddWithValue("@Quirurgicos", Pacientes.Quirurgicos)
            oleDbCommand.Parameters.AddWithValue("@Transfuciones", Pacientes.Transfuciones)
            oleDbCommand.Parameters.AddWithValue("@Alergias", Pacientes.Alergias)
            oleDbCommand.Parameters.AddWithValue("@Traumaticos", Pacientes.Traumaticos)
            oleDbCommand.Parameters.AddWithValue("@Hospitalizaciones", Pacientes.Hospitalizaciones)
            oleDbCommand.Parameters.AddWithValue("@Adicciones", Pacientes.Adicciones)
            oleDbCommand.Parameters.AddWithValue("@PersonalOtros", Pacientes.PersonalOtros)
            oleDbCommand.Parameters.AddWithValue("@Duchas", Pacientes.Duchas)
            oleDbCommand.Parameters.AddWithValue("@Dientes", Pacientes.Dientes)
            oleDbCommand.Parameters.AddWithValue("@Habitacion", Pacientes.Habitacion)
            oleDbCommand.Parameters.AddWithValue("@Tabaquismo", Pacientes.Tabaquismo)
            oleDbCommand.Parameters.AddWithValue("@Alcoholismo", Pacientes.Alcoholismo)
            oleDbCommand.Parameters.AddWithValue("@Alimentacion", Pacientes.Alimentacion)
            oleDbCommand.Parameters.AddWithValue("@Deportes", Pacientes.Deportes)
            oleDbCommand.Parameters.AddWithValue("@Inmunizaciones", Pacientes.Inmunizaciones)
            oleDbCommand.Parameters.AddWithValue("@Pendientes", Pacientes.Pendientes)
            oleDbCommand.Parameters.AddWithValue("@Desparacitacion", Pacientes.Desparacitacion)

            Pacientes.Cedula = CStr(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Pacientes
    End Function

    Public Shared Function Actualizar(ByVal Pacientes As PacientesEntity) As PacientesEntity
        Dim cmdText As String = "UPDATE Pacientes SET  "

        Try
            cmdText += "Cedula = """ & Pacientes.Cedula & """"
            cmdText += ", Nombre = """ & Pacientes.Nombre & """"
            cmdText += ", FechaNacimiento = """ & Pacientes.FechaNacimiento & """"
            cmdText += ", Sexo = """ & Pacientes.Sexo & """"
            cmdText += ", EstadoCivil = """ & Pacientes.EstadoCivil & """"
            cmdText += ", Ocupacion = """ & Pacientes.Ocupacion & """"
            cmdText += ", TipoSangre = """ & Pacientes.TipoSangre & """"
            cmdText += ", LugarOrigen = """ & Pacientes.LugarOrigen & """"
            cmdText += ", LugarResidencia = """ & Pacientes.LugarResidencia & """"
            cmdText += ", Domicilio = """ & Pacientes.Domicilio & """"
            cmdText += ", Telefono = """ & Pacientes.Telefono & """"
            cmdText += ", Religion = """ & Pacientes.Religion & """"
            cmdText += ", Escolaridad = """ & Pacientes.Escolaridad & """"
            cmdText += ", Email = """ & Pacientes.Email & """"
            cmdText += ", PersonaContacto = """ & Pacientes.PersonaContacto & """"
            cmdText += ", TelefonoContacto = """ & Pacientes.TelefonoContacto & """"
            cmdText += ", ParentescoContacto = """ & Pacientes.ParentescoContacto & """"
            cmdText += ", Diabetes = """ & Pacientes.Diabetes & """"
            cmdText += ", Hipertension = """ & Pacientes.Hipertension & """"
            cmdText += ", Cardiopatia = """ & Pacientes.Cardiopatia & """"
            cmdText += ", Hepatopatia = """ & Pacientes.Hepatopatia & """"
            cmdText += ", Nefropatia = """ & Pacientes.Nefropatia & """"
            cmdText += ", Mentales = """ & Pacientes.Mentales & """"
            cmdText += ", Asma = """ & Pacientes.Asma & """"
            cmdText += ", Cancer = """ & Pacientes.Cancer & """"
            cmdText += ", Alergicas = """ & Pacientes.Alergicas & """"
            cmdText += ", Endocrinas = """ & Pacientes.Endocrinas & """"
            cmdText += ", FamiliaresOtros = """ & Pacientes.FamiliaresOtros & """"
            cmdText += ", Actuales = """ & Pacientes.Actuales & """"
            cmdText += ", Quirurgicos = """ & Pacientes.Quirurgicos & """"
            cmdText += ", Transfuciones = """ & Pacientes.Transfuciones & """"
            cmdText += ", Alergias = """ & Pacientes.Alergias & """"
            cmdText += ", Traumaticos = """ & Pacientes.Traumaticos & """"
            cmdText += ", Hospitalizaciones = """ & Pacientes.Hospitalizaciones & """"
            cmdText += ", Adicciones = """ & Pacientes.Adicciones & """"
            cmdText += ", PersonalOtros = """ & Pacientes.PersonalOtros & """"
            cmdText += ", Duchas = """ & Pacientes.Duchas & """"
            cmdText += ", Dientes = """ & Pacientes.Dientes & """"
            cmdText += ", Habitacion = """ & Pacientes.Habitacion & """"
            cmdText += ", Tabaquismo = """ & Pacientes.Tabaquismo & """"
            cmdText += ", Alcoholismo = """ & Pacientes.Alcoholismo & """"
            cmdText += ", Alimentacion = """ & Pacientes.Alimentacion & """"
            cmdText += ", Deportes = """ & Pacientes.Deportes & """"
            cmdText += ", Inmunizaciones = """ & Pacientes.Inmunizaciones & """"
            cmdText += ", Pendientes = """ & Pacientes.Pendientes & """"
            cmdText += ", Desparacitacion = """ & Pacientes.Desparacitacion & """"
            cmdText += " WHERE Cedula = " & Pacientes.Cedula

            oleDbConnection.Open()
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)

            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return Pacientes
    End Function

    Public Shared Sub EliminarPorCedula(ByVal ID As String)
        Try
            oleDbConnection.Open()
            Dim cmdText As String = "DELETE * FROM Pacientes WHERE Cedula = @Cedula"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Cedula", ID)
            oleDbCommand.ExecuteScalar()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
    End Sub

    Private Shared Function CargarPaciente(ByVal reader As IDataReader) As PacientesEntity

        Try

            Return New PacientesEntity() With {.Cedula = reader("Cedula").ToString, _
                                                .Nombre = reader("Nombre").ToString, _
                                                .FechaNacimiento = reader("FechaNacimiento").ToString, _
                                                .Sexo = reader("Sexo").ToString, _
                                                .EstadoCivil = reader("EstadoCivil").ToString, _
                                                .Ocupacion = reader("Ocupacion").ToString, _
                                                .TipoSangre = reader("TipoSangre").ToString, _
                                                .LugarOrigen = reader("LugarOrigen").ToString, _
                                                .LugarResidencia = reader("LugarResidencia").ToString, _
                                                .Domicilio = reader("Domicilio").ToString, _
                                                .Telefono = reader("Telefono").ToString, _
                                                .Religion = reader("Religion").ToString, _
                                                .Escolaridad = reader("Escolaridad").ToString, _
                                                .Email = reader("Email").ToString, _
                                                .PersonaContacto = reader("PersonaContacto").ToString, _
                                                .TelefonoContacto = reader("TelefonoContacto").ToString, _
                                                .ParentescoContacto = reader("ParentescoContacto").ToString, _
                                                .Diabetes = reader("Diabetes").ToString, _
                                                .Hipertension = reader("Hipertension").ToString, _
                                                .Cardiopatia = reader("Cardiopatia").ToString, _
                                                .Hepatopatia = reader("Hepatopatia").ToString, _
                                                .Nefropatia = reader("Nefropatia").ToString, _
                                                .Mentales = reader("Mentales").ToString, _
                                                .Asma = reader("Asma").ToString, _
                                                .Cancer = reader("Cancer").ToString, _
                                                .Alergicas = reader("Alergicas").ToString, _
                                                .Endocrinas = reader("Endocrinas").ToString, _
                                                .FamiliaresOtros = reader("FamiliaresOtros").ToString, _
                                                .Actuales = reader("Actuales").ToString, _
                                                .Quirurgicos = reader("Quirurgicos").ToString, _
                                                .Transfuciones = reader("Transfuciones").ToString, _
                                                .Alergias = reader("Alergias").ToString, _
                                                .Traumaticos = reader("Traumaticos").ToString, _
                                                .Hospitalizaciones = reader("Hospitalizaciones").ToString, _
                                                .Adicciones = reader("Adicciones").ToString, _
                                                .PersonalOtros = reader("PersonalOtros").ToString, _
                                                .Duchas = reader("Duchas").ToString, _
                                                .Dientes = reader("Dientes").ToString, _
                                                .Habitacion = reader("Habitacion").ToString, _
                                                .Tabaquismo = reader("Tabaquismo").ToString, _
                                                .Alcoholismo = reader("Alcoholismo").ToString, _
                                                .Alimentacion = reader("Alimentacion").ToString, _
                                                .Deportes = reader("Deportes").ToString, _
                                                .Inmunizaciones = reader("Inmunizaciones").ToString, _
                                                .Pendientes = reader("Pendientes").ToString, _
                                                .Desparacitacion = reader("Desparacitacion").ToString}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

End Class
