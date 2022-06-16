Imports Actualizar
Imports Recipe.Entities
Imports System.Data.OleDb

Public Class UserDA
    Shared oleDbConnection As OleDbConnection = New OleDbConnection(Utility.ConnectionString("Config"))

    Public Shared Function CargarTodo() As List(Of UserEntity)
        Dim list As List(Of UserEntity) = New List(Of UserEntity)()

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM [User] ORDER BY IDUsuario"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            While oleDbDataReader.Read()
                list.Add(UserDA.CargarUser(oleDbDataReader))
            End While

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return list
    End Function

    Public Shared Function BuscarPorID(ByVal ID As Integer) As UserEntity
        Dim result As UserEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM [User] WHERE IDUsuario = " & ID
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = UserDA.CargarUser(oleDbDataReader)
            End If

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return result
    End Function

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As UserEntity
        Dim result As UserEntity = Nothing

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT * FROM [User] WHERE Usuario = " & Texto
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
            If oleDbDataReader.Read() = True Then
                result = UserDA.CargarUser(oleDbDataReader)
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
            Dim cmdText As String = "SELECT Count(*) FROM [User] WHERE IDUsuario = @IDUsuario"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@IDUsuario", ID)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function ExisteUser(ByVal Texto As String) As Boolean
        Dim num As Integer = 0

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "SELECT Count(*) FROM [User] WHERE Usuario = @Usuario"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Usuario", Texto)
            num = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return num > 0
    End Function

    Public Shared Function Guardar(ByVal User As UserEntity) As UserEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "INSERT INTO [User] (Usuario, Contraseña, Tipo) VALUES (@Usuario, @Contraseña, @Tipo)"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Usuario", User.Usuario)
            oleDbCommand.Parameters.AddWithValue("@Contraseña", User.Contraseña)
            oleDbCommand.Parameters.AddWithValue("@Tipo", User.Tipo)
            User.IDUsuario = CInt(oleDbCommand.ExecuteScalar)

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return User
    End Function

    Public Shared Function Actualizar(ByVal User As UserEntity) As UserEntity

        Try
            oleDbConnection.Open()
            Dim cmdText As String = "UPDATE [User] SET  Usuario = @Usuario, Contraseña = @Contraseña, Tipo = @Tipo WHERE IDUsuario = @IDUsuario"
            Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
            oleDbCommand.Parameters.AddWithValue("@Usuario", User.Usuario)
            oleDbCommand.Parameters.AddWithValue("@Contraseña", User.Contraseña)
            oleDbCommand.Parameters.AddWithValue("@Tipo", User.Tipo)
            oleDbCommand.Parameters.AddWithValue("@IDUsuario", User.IDUsuario)
            oleDbCommand.ExecuteNonQuery()

        Catch x As Exception
            Globales.Errores(x)
        Finally
            oleDbConnection.Close()
        End Try
        Return User
    End Function

    Private Shared Function CargarUser(ByVal reader As IDataReader) As UserEntity

        Try

            Return New UserEntity() With {.IDUsuario = CInt(reader("IDUsuario")), _
                                          .Usuario = CStr(reader("Usuario")), _
                                          .Contraseña = CStr(reader("Contraseña")), _
                                          .Tipo = CStr(reader("Tipo"))}

        Catch x As Exception
            Globales.Errores(x)
            Return Nothing
        End Try

    End Function

End Class
