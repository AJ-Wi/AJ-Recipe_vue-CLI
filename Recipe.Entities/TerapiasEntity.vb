
Public Class TerapiasEntity
    Private E_IDterapia As Integer
    Private E_Terapia As String

    Public Property IDterapia() As Integer
        Get
            Return Me.E_IDterapia
        End Get
        Set(ByVal value As Integer)
            Me.E_IDterapia = value
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

End Class
