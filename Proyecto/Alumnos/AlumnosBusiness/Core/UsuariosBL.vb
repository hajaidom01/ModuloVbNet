Imports AlumnosDataAccess
Imports AlumnosEntities

Public Class UsuariosBL

    Dim data As New UsuariosDat
    Public Function Login(ByVal user As String, ByVal password As String) As Boolean
        Return data.Login(user, password)
    End Function
End Class
