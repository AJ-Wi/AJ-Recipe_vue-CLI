
Public Class ConsejosEntity
    Private E_IDconsejo As Integer
    Private E_Consejo As String
    Private E_RutaImagen As String

    Public Property IDconsejo() As Integer
        Get
            Return Me.E_IDconsejo
        End Get
        Set(ByVal value As Integer)
            Me.E_IDconsejo = value
        End Set
    End Property

    Public Property Consejo() As String
        Get
            Return Me.E_Consejo
        End Get
        Set(ByVal value As String)
            Me.E_Consejo = value
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
