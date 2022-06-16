Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class TerapiasBU

    Public Shared Function CargarTodo() As List(Of TerapiasEntity)
        Return TerapiasDA.CargarTodo()
    End Function

    Public Shared Function BuscarPorId(ByVal id As Integer) As TerapiasEntity
        Return TerapiasDA.BuscarPorId(id)
    End Function

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of TerapiasEntity)
        Dim result As List(Of TerapiasEntity)

        If Texto <> Nothing Then
            result = TerapiasDA.BuscarPorCadena("'%" & Texto & "%'")
        Else
            result = TerapiasDA.CargarTodo()
        End If
        Return result
    End Function

    Public Shared Function Guardar(ByVal Terapias As TerapiasEntity) As TerapiasEntity
        Dim result As TerapiasEntity

        If TerapiasDA.Existe(Terapias.IDterapia) = True Then
            result = TerapiasDA.Actualizar(Terapias)
        Else
            result = TerapiasDA.Guardar(Terapias)
        End If
        Return result
    End Function

    Public Shared Sub Transferir(ByVal id As Integer, ByVal Tabla As String, Optional ByVal NombreEnfermedad As String = Nothing)
        TerapiasDA.Transferir(id, Tabla, NombreEnfermedad)
    End Sub

    Public Shared Sub EliminarPorID(ByVal id As Integer)
        TerapiasDA.EliminarPorID(id)
    End Sub

End Class
