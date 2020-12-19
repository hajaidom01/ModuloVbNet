
Public Class AlumnoEnt

    Private _id As Int32
    Public Property Id As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _matricula As Int32
    Public Property Matricula() As Int32
        Get
            Return _matricula
        End Get
        Set(ByVal value As Int32)
            _matricula = value
        End Set
    End Property

End Class
