Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class EmpresaBU

    Public Shared Function BuscarPorId(ByVal id As Integer) As EmpresaEntity
        Return EmpresaDA.BuscarPorId(id)
    End Function

    Public Shared Function Guardar(ByVal Empresa As EmpresaEntity) As EmpresaEntity
        Dim result As EmpresaEntity

        If EmpresaDA.Existe(Empresa.IDempresa) = True Then
            result = EmpresaDA.Actualizar(Empresa)
        Else
            result = EmpresaDA.Guardar(Empresa)
        End If
        Return result
    End Function

    Public Shared Function Existe(ByVal ID As Integer) As Boolean
        If EmpresaDA.Existe(ID) = True Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
