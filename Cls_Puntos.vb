Public Class Cls_Puntos
    Private _id_punto As Integer
    Public Property Id_punto() As Integer
        Get
            Return _id_punto
        End Get
        Set(value As Integer)
            _id_punto = value
        End Set
    End Property
    Private _remision As Integer
    Public Property Id_Remision() As Integer
        Get
            Return _remision
        End Get
        Set(value As Integer)
            _remision = value
        End Set
    End Property
End Class
