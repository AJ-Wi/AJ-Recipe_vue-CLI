Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class ConsejosBU

    Public Shared Function CargarTodo() As List(Of ConsejosEntity)
        Return ConsejosDA.CargarTodo()
    End Function

    Public Shared Function BuscarPorId(ByVal id As Integer) As ConsejosEntity
        Return ConsejosDA.BuscarPorId(id)
    End Function

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of ConsejosEntity)
        Dim result As List(Of ConsejosEntity)
        If Texto <> Nothing Then
            result = ConsejosDA.BuscarPorCadena("'%" & Texto & "%'")
        Else
            result = ConsejosDA.CargarTodo()
        End If
        Return result
    End Function

    Public Shared Function Guardar(ByVal Consejos As ConsejosEntity) As ConsejosEntity
        Dim result As ConsejosEntity
        If ConsejosDA.Existe(Consejos.IDconsejo) = True Then
            result = ConsejosDA.Actualizar(Consejos)
        Else
            result = ConsejosDA.Guardar(Consejos)
        End If
        Return result
    End Function

    Public Shared Sub Transferir(ByVal id As Integer, ByVal Tabla As String, Optional ByVal NombreEnfermedad As String = Nothing)
        ConsejosDA.Transferir(id, Tabla, NombreEnfermedad)
    End Sub

    Public Shared Sub EliminarPorID(ByVal id As Integer)
        ConsejosDA.EliminarPorID(id)
    End Sub

End Class
