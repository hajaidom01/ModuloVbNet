Imports AlumnosBusiness
Imports AlumnosEntities

Public Class Login
    Inherits System.Web.UI.Page

    Dim bl As New UsuariosBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Function Login(ByVal user As String, ByVal password As String) As Boolean
        Return bl.Login(user, password)
    End Function

    Protected Sub BtnLogin_Click(sender As Object, e As EventArgs)
        Dim user As String = txtUser.Text
        Dim pass As String = txtMail.Text

        If (user = "" OrElse pass = "") Then
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>alert('Capture usuario y contraseña.')</script>", False)

            Return
        End If

        If (Login(user, pass)) Then
            Response.Redirect("../Alumnos/Alumnos.aspx")
        Else
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>alert('Credenciales invalidas.')</script>", False)
        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub
End Class