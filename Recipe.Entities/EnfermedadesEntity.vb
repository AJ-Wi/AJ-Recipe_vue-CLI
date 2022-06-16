
Public Class EnfermedadesEntity
    Private E_IDenfermedad As Integer
    Private E_Enfermedad As String
    Private E_Medicamentos As String
    Private E_URLVideo As String

    Public Property IDenfermedad() As Integer
        Get
            Return Me.E_IDenfermedad
        End Get
        Set(ByVal value As Integer)
            Me.E_IDenfermedad = value
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

    Public Property URLVideo() As String
        Get
            Return Me.E_URLVideo
        End Get
        Set(ByVal value As String)
            Me.E_URLVideo = value
        End Set
    End Property

End Class
