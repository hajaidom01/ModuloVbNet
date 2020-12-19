Imports AlumnosEntities
Imports AlumnosBusiness

Public Class Alumnos
    Inherits System.Web.UI.Page

    Dim BlAlumnos As New AlumnoBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DeshabilitarCampos()
        btnGuarda.Enabled = False
        btnEditar.Enabled = False


        txtId.Enabled = False
    End Sub

    Public Sub BuscarAlumno()

        Dim matricula As Int32 = txtMat.Text

        Dim alumno = New AlumnoEnt

        alumno = BlAlumnos.BuscarAlumno(matricula)

        If alumno IsNot Nothing Then
            txtNombre.Text = alumno.Nombre
            txtApellido.Text = alumno.Apellido
            txtMatricula.Text = alumno.Matricula
            txtId.Text = alumno.Id
            btnGuarda.Enabled = False
            btnEditar.Enabled = True
        Else
            Response.Write("<script>alert('Alumno no encontrado.');</script>")
            txtMat.Text = ""
            txtMat.Focus()
        End If

        HabilitarCampos()

    End Sub

    Public Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        BuscarAlumno()
    End Sub

    Private Sub LimpiarCampos()
        txtApellido.Text = ""
        txtId.Text = ""
        txtMatricula.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub DeshabilitarCampos()
        txtApellido.Enabled = False
        txtId.Enabled = False
        txtMatricula.Enabled = False
        txtNombre.Enabled = False
    End Sub

    Protected Sub BtnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
        DeshabilitarCampos()
        txtMat.Text = ""
    End Sub

    Private Sub HabilitarCampos()
        txtApellido.Enabled = True
        txtMatricula.Enabled = True
        txtNombre.Enabled = True
    End Sub

    Protected Sub BtnNuevo_Click(sender As Object, e As EventArgs)
        HabilitarCampos()
        LimpiarCampos()
        txtMat.Text = ""
        btnGuarda.Enabled = True
    End Sub

    Protected Sub BtnGuarda_Click(sender As Object, e As EventArgs)
        GuardarAlumno()
    End Sub

    Protected Sub BtnEditar_Click(sender As Object, e As EventArgs)
        Editar()
    End Sub

    Protected Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
        txtMat.Text = ""
    End Sub

    Private Sub GuardarAlumno()
        Dim alumno = New AlumnoEnt With
            {
            .Nombre = txtNombre.Text,
            .Apellido = txtApellido.Text,
            .Matricula = Convert.ToInt32(txtMatricula.Text)
            }

        Dim respuesta As Boolean
        respuesta = BlAlumnos.GuardarAlumno(alumno)

        If Not respuesta Then
            Response.Write("<script>alert('No es posible guardar el registro.');</script>")
        Else
            Response.Write("<script>alert('El registro se guardó correctamente.');</script>")
        End If
        LimpiarCampos()
    End Sub

    Private Sub Editar()
        Dim alumno = New AlumnoEnt With
            {
            .Id = Convert.ToInt32(txtId.Text),
            .Nombre = txtNombre.Text,
            .Apellido = txtApellido.Text,
            .Matricula = Convert.ToInt32(txtMatricula.Text)
            }

        Dim respuesta As Boolean
        respuesta = BlAlumnos.EditarAlumno(alumno)

        If Not respuesta Then
            Response.Write("<script>alert('No es posible editar el registro.');</script>")
        Else
            Response.Write("<script>alert('El registro se editó correctamente.');</script>")
            LimpiarCampos()
            DeshabilitarCampos()
            txtMat.Text = ""
        End If

    End Sub

End Class