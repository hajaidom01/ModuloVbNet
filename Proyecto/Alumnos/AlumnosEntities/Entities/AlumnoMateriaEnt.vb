Public Class AlumnoMateriaEnt

    Private _id As Int32
    Public Property Id() As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property

    Private _fkAlumno As Int32
    Public Property FkAlumno() As Int32
        Get
            Return _fkAlumno
        End Get
        Set(ByVal value As Int32)
            _fkAlumno = value
        End Set
    End Property

    Private _fkMateria As Int32
    Public Property FkMateria() As Int32
        Get
            Return _fkMateria
        End Get
        Set(ByVal value As Int32)
            _fkMateria = value
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
