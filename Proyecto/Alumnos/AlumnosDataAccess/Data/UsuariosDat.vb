Imports AlumnosEntities
Public Class UsuariosDat

    Public Function Login(ByVal user As String, ByVal password As String) As Boolean
        Dim response As Boolean
        Using ent As New EscuelaEntities
            Dim query = (From a In ent.Usuarios
                         Where a.Usuario1 = user AndAlso a.Password = password
                         Select New UsuariosEnt With {
                             .Usuario = a.Usuario1
                             }).SingleOrDefault()



            If query IsNot Nothing Then
                response = True
            End If
        End Using
        Return response
    End Function

End Class
