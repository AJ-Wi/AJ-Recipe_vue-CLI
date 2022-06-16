
Public Class EmpresaEntity
    Private E_IDempresa As Integer
    Private E_Medico As String
    Private E_Cedula As Integer
    Private E_NRegistro As Integer
    Private E_Clinica As String
    Private E_Direccion As String
    Private E_Clinica2 As String
    Private E_Direccion2 As String
    Private E_Telefono As String
    Private E_Telefono2 As String
    Private E_Web As String
    Private E_Web2 As String
    Private E_Correo As String
    Private E_Correo2 As String
    Private E_Enunciado As String
    Private E_Horario As String
    Private E_Horario2 As String
    Private E_Logo As String
    Private E_SubirBD As Boolean

    Public Property IDempresa() As Integer
        Get
            Return Me.E_IDempresa
        End Get
        Set(ByVal value As Integer)
            Me.E_IDempresa = value
        End Set
    End Property

    Public Property Medico() As String
        Get
            Return Me.E_Medico
        End Get
        Set(ByVal value As String)
            Me.E_Medico = value
        End Set
    End Property

    Public Property Cedula() As Integer
        Get
            Return Me.E_Cedula
        End Get
        Set(ByVal value As Integer)
            Me.E_Cedula = value
        End Set
    End Property

    Public Property NRegistro() As Integer
        Get
            Return Me.E_NRegistro
        End Get
        Set(ByVal value As Integer)
            Me.E_NRegistro = value
        End Set
    End Property

    Public Property Clinica() As String
        Get
            Return Me.E_Clinica
        End Get
        Set(ByVal value As String)
            Me.E_Clinica = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Me.E_Direccion
        End Get
        Set(ByVal value As String)
            Me.E_Direccion = value
        End Set
    End Property

    Public Property Clinica2() As String
        Get
            Return Me.E_Clinica2
        End Get
        Set(ByVal value As String)
            Me.E_Clinica2 = value
        End Set
    End Property

    Public Property Direccion2() As String
        Get
            Return Me.E_Direccion2
        End Get
        Set(ByVal value As String)
            Me.E_Direccion2 = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Me.E_Telefono
        End Get
        Set(ByVal value As String)
            Me.E_Telefono = value
        End Set
    End Property

    Public Property Telefono2() As String
        Get
            Return Me.E_Telefono2
        End Get
        Set(ByVal value As String)
            Me.E_Telefono2 = value
        End Set
    End Property

    Public Property Web() As String
        Get
            Return Me.E_Web
        End Get
        Set(ByVal value As String)
            Me.E_Web = value
        End Set
    End Property

    Public Property Web2() As String
        Get
            Return Me.E_Web2
        End Get
        Set(ByVal value As String)
            Me.E_Web2 = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return Me.E_Correo
        End Get
        Set(ByVal value As String)
            Me.E_Correo = value
        End Set
    End Property

    Public Property Correo2() As String
        Get
            Return Me.E_Correo2
        End Get
        Set(ByVal value As String)
            Me.E_Correo2 = value
        End Set
    End Property

    Public Property Enunciado() As String
        Get
            Return Me.E_Enunciado
        End Get
        Set(ByVal value As String)
            Me.E_Enunciado = value
        End Set
    End Property

    Public Property Horario() As String
        Get
            Return Me.E_Horario
        End Get
        Set(ByVal value As String)
            Me.E_Horario = value
        End Set
    End Property

    Public Property Horario2() As String
        Get
            Return Me.E_Horario2
        End Get
        Set(ByVal value As String)
            Me.E_Horario2 = value
        End Set
    End Property

    Public Property Logo() As String
        Get
            Return Me.E_Logo
        End Get
        Set(ByVal value As String)
            Me.E_Logo = value
        End Set
    End Property

    Public Property SubirBD() As Boolean
        Get
            Return Me.E_SubirBD
        End Get
        Set(ByVal value As Boolean)
            Me.E_SubirBD = value
        End Set
    End Property

End Class
