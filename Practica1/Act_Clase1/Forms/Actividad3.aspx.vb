Public Class Actividad3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub InicioSesion(ByVal correo As String, ByVal password As String)
        Dim email As String = "hector@mail.com"
        Dim pass As String = "12345"
        Dim msg As String

        If email = correo AndAlso pass = password Then
            msg = "Bienvenido."
        Else
            msg = "Usuario o  contraseña incorrectos."
        End If
        MsgBox(msg)
    End Sub

    Protected Sub Borrar()
        txtMail.Text = ""
        txtPassword.Text = ""
    End Sub

    Protected Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Borrar()
    End Sub

    Protected Sub BtnLogin_Click(sender As Object, e As EventArgs)
        InicioSesion(txtMail.Text, txtPassword.Text)
    End Sub
End Class