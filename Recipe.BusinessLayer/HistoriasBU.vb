Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class HistoriasBU

    Public Shared Function BuscarPorId(ByVal id As Integer) As HistoriasEntity
        Return HistoriasDA.BuscarPorId(id)
    End Function

    Public Shared Function BuscarPorCedula(ByVal Texto As String) As List(Of HistoriasEntity)
        Return HistoriasDA.BuscarPorCedula(Texto)
    End Function

    Public Shared Function Guardar(ByVal Historias As HistoriasEntity) As HistoriasEntity

        If HistoriasDA.Existe(Historias.IDpaciente) = True Then
            Return HistoriasDA.Actualizar(Historias)
        Else
            Return HistoriasDA.Guardar(Historias)
        End If

    End Function

    Public Shared Sub EliminarPorID(ByVal id As Integer)
        HistoriasDA.EliminarPorID(id)
    End Sub

End Class
