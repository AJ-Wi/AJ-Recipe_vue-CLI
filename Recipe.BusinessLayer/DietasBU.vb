Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class DietasBU

    Public Shared Function CargarTodo() As List(Of DietasEntity)
        Return DietasDA.CargarTodo()
    End Function

    Public Shared Function BuscarPorId(ByVal id As Integer) As DietasEntity
        Return DietasDA.BuscarPorId(id)
    End Function

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of DietasEntity)
        Dim result As List(Of DietasEntity)

        If Texto <> Nothing Then
            result = DietasDA.BuscarPorCadena("'%" & Texto & "%'")
        Else
            result = DietasDA.CargarTodo()
        End If
        Return result
    End Function

    Public Shared Function Guardar(ByVal Dietas As DietasEntity) As DietasEntity
        Dim result As DietasEntity

        If DietasDA.Existe(Dietas.IDdieta) = True Then
            result = DietasDA.Actualizar(Dietas)
        Else
            result = DietasDA.Guardar(Dietas)
        End If
        Return result
    End Function

    Public Shared Sub Transferir(ByVal id As Integer, ByVal Tabla As String, Optional ByVal NombreEnfermedad As String = Nothing)
        DietasDA.Transferir(id, Tabla, NombreEnfermedad)
    End Sub

    Public Shared Sub EliminarPorID(ByVal id As Integer)
        DietasDA.EliminarPorID(id)
    End Sub

End Class
