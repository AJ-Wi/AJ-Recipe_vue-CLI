
Public Class UserEntity
    Private E_IDUsuario As Integer
    Private E_Usuario As String
    Private E_Contraseña As String
    Private E_Tipo As String

    Public Property IDUsuario() As Integer
        Get
            Return Me.E_IDUsuario
        End Get
        Set(ByVal value As Integer)
            Me.E_IDUsuario = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return Me.E_Usuario
        End Get
        Set(ByVal value As String)
            Me.E_Usuario = value
        End Set
    End Property

    Public Property Contraseña() As String
        Get
            Return Me.E_Contraseña
        End Get
        Set(ByVal value As String)
            Me.E_Contraseña = value
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

End Class
