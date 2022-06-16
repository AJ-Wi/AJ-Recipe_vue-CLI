
Public Class DietasEntity
    Private E_IDdieta As Integer
    Private E_Dieta As String

    Public Property IDdieta() As Integer
        Get
            Return Me.E_IDdieta
        End Get
        Set(ByVal value As Integer)
            Me.E_IDdieta = value
        End Set
    End Property

    Public Property Dieta() As String
        Get
            Return Me.E_Dieta
        End Get
        Set(ByVal value As String)
            Me.E_Dieta = value
        End Set
    End Property

End Class
