Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class UserBU

    Public Shared Function CargarTodo() As List(Of UserEntity)
        Return UserDA.CargarTodo()
    End Function

    Public Shared Function BuscarPorID(ByVal ID As Integer) As UserEntity
        Return UserDA.BuscarPorID(ID)
    End Function

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As UserEntity
        Return UserDA.BuscarPorCadena("'" & Texto & "'")
    End Function

    Public Shared Function ExisteUsuario(ByVal Texto As String) As Boolean
        Return UserDA.ExisteUser(Texto)
    End Function

    Public Shared Function Guardar(ByVal User As UserEntity) As UserEntity
        Dim result As UserEntity

        If UserDA.Existe(User.IDUsuario) = True Then
            result = UserDA.Actualizar(User)
        Else
            result = UserDA.Guardar(User)
        End If
        Return result
    End Function

End Class
