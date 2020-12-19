Public Class UsuariosEnt
    Private _id As Int32
    Public Property Id() As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _status As Boolean
    Public Property Status() As Boolean
        Get
            Return _status
        End Get
        Set(ByVal value As Boolean)
            _status = value
        End Set
    End Property

End Class
