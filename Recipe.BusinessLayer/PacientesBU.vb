Imports Recipe.DataAccess
Imports Recipe.Entities

Public Class PacientesBU

    Public Shared Function BuscarPorCedula(ByVal Texto As String) As PacientesEntity
        Return PacientesDA.BuscarPorCedula(Texto)
    End Function

    Public Shared Function GuardarViejos(ByVal Pacientes As PacientesEntity) As PacientesEntity
        Return PacientesDA.GuardarViejos(Pacientes)
    End Function

    Public Shared Function Guardar(ByVal Pacientes As PacientesEntity) As PacientesEntity

        If PacientesDA.Existe(Pacientes.Cedula) = True Then
            Return PacientesDA.Actualizar(Pacientes)
        Else
            Return PacientesDA.Guardar(Pacientes)
        End If

    End Function

    Public Shared Function ExisteCedula(ByVal Cedula As String) As Boolean
        Return PacientesDA.Existe(Cedula)
    End Function

    Public Shared Sub EliminarPorCedula(ByVal Texto As String)
        PacientesDA.EliminarPorCedula(Texto)
    End Sub

End Class
