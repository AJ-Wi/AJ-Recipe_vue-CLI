Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class EnfermedadesBU

    Public Shared Function CargarTodo() As List(Of EnfermedadesEntity)
        Return EnfermedadesDA.CargarTodo()
    End Function

    Public Shared Function BuscarPorId(ByVal id As Integer) As EnfermedadesEntity
        Return EnfermedadesDA.BuscarPorId(id)
    End Function

    Public Shared Function BuscarPorCadena(ByVal Texto As String) As List(Of EnfermedadesEntity)
        Dim result As List(Of EnfermedadesEntity)

        If Texto <> Nothing Then
            result = EnfermedadesDA.BuscarPorCadena("'%" & Texto & "%'")
        Else
            result = EnfermedadesDA.CargarTodo()
        End If
        Return result
    End Function

    Public Shared Function Guardar(ByVal Enfermedades As EnfermedadesEntity) As EnfermedadesEntity
        Dim result As EnfermedadesEntity

        If EnfermedadesDA.Existe(Enfermedades.IDenfermedad) = True Then
            result = EnfermedadesDA.Actualizar(Enfermedades)
        Else
            result = EnfermedadesDA.Guardar(Enfermedades)
        End If
        Return result
    End Function

    Public Shared Sub Transferir(ByVal id As Integer, ByVal Tabla As String)
        EnfermedadesDA.Transferir(id, Tabla)
    End Sub

    Public Shared Sub EliminarPorID(ByVal id As Integer)
        EnfermedadesDA.EliminarPorID(id)
    End Sub

End Class
