Public NotInheritable Class Biemvenida

    Private Sub Biemvenida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Informacion de Version
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright

        'lo siguiente busca el archivo de la fecha en que se instalo si esta lo lee y me devuelve la fecha 
        'si no esta es por que es primera vez que se ejecuta y se escribe un nuevo fichero con la fecha
        'luego calcula los dias que le quedan al demo
    End Sub

End Class
