
Public Class HistoriasEntity
    Private E_IDpaciente As Integer
    Private E_Nombre As String
    Private E_Cedula As String
    Private E_Enfermedad As String
    Private E_Medicamentos As String
    Private E_Terapia As String
    Private E_Dietas As String
    Private E_URLVideo As String
    Private E_Fecha As String
    Private E_FechaNacimiento As String
    Private E_Tipo As String
    Private E_Lugar As String
    Private E_FechaExpiracion As String
    Private E_RutaImagen As String

    Public Property IDpaciente() As Integer
        Get
            Return Me.E_IDpaciente
        End Get
        Set(ByVal value As Integer)
            Me.E_IDpaciente = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me.E_Nombre
        End Get
        Set(ByVal value As String)
            Me.E_Nombre = value
        End Set
    End Property

    Public Property Cedula() As String
        Get
            Return Me.E_Cedula
        End Get
        Set(ByVal value As String)
            Me.E_Cedula = value
        End Set
    End Property

    Public Property Enfermedad() As String
        Get
            Return Me.E_Enfermedad
        End Get
        Set(ByVal value As String)
            Me.E_Enfermedad = value
        End Set
    End Property

    Public Property Medicamentos() As String
        Get
            Return Me.E_Medicamentos
        End Get
        Set(ByVal value As String)
            Me.E_Medicamentos = value
        End Set
    End Property

    Public Property Terapia() As String
        Get
            Return Me.E_Terapia
        End Get
        Set(ByVal value As String)
            Me.E_Terapia = value
        End Set
    End Property

    Public Property Dietas() As String
        Get
            Return Me.E_Dietas
        End Get
        Set(ByVal value As String)
            Me.E_Dietas = value
        End Set
    End Property

    Public Property URLVideo() As String
        Get
            Return Me.E_URLVideo
        End Get
        Set(ByVal value As String)
            Me.E_URLVideo = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return Me.E_Fecha
        End Get
        Set(ByVal value As String)
            Me.E_Fecha = value
        End Set
    End Property

    Public Property FechaNacimiento() As String
        Get
            Return Me.E_FechaNacimiento
        End Get
        Set(ByVal value As String)
            Me.E_FechaNacimiento = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Me.E_Tipo
        End Get
        Set(ByVal value As String)
            Me.E_Tipo = value
        End Set
    End Property

    Public Property Lugar() As String
        Get
            Return Me.E_Lugar
        End Get
        Set(ByVal value As String)
            Me.E_Lugar = value
        End Set
    End Property

    Public Property FechaExpiracion() As String
        Get
            Return Me.E_FechaExpiracion
        End Get
        Set(ByVal value As String)
            Me.E_FechaExpiracion = value
        End Set
    End Property

    Public Property RutaImagen() As String
        Get
            Return Me.E_RutaImagen
        End Get
        Set(ByVal value As String)
            Me.E_RutaImagen = value
        End Set
    End Property

End Class
