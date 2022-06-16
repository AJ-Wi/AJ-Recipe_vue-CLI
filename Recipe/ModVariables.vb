Imports Recipe.Entities
Imports Actualizar

Module ModVariables
    Friend Recipe As HistoriasEntity
    Friend Inf As String
    Friend Ventana As String
    Friend Tabla As String
    Friend NombreEnfermedad As String
    Friend Nuevo As Boolean
    Friend ID As Integer
    Friend Tipo As String
    Friend ActualBD As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\ActualBD.cif"
    Friend ActualizacionBD As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\ActualizacionBD.cif"
    Friend BdLocal As String = Application.StartupPath & "\Tratamientos.accdb"
    Friend Imagen As String

    Public Sub Errores(ByVal ElError As Exception)
        Utility.ErrorGeneral(ElError, Application.StartupPath & "\AppErrores.err")
    End Sub

End Module
