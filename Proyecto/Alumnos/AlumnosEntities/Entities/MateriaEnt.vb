Public Class MateriaEnt

    Private _Id As Int32
    Public Property Id() As Int32
        Get
            Return _Id
        End Get
        Set(ByVal value As Int32)
            _Id = value
        End Set
    End Property

    Private _nombreMateria As String
    Public Property NombreMateria() As String
        Get
            Return _nombreMateria
        End Get
        Set(ByVal value As String)
            _nombreMateria = value
        End Set
    End Property

    Private _activa As Boolean
    Public Property Activa() As Boolean
        Get
            Return _activa
        End Get
        Set(ByVal value As Boolean)
            _activa = value
        End Set
    End Property

End Class
