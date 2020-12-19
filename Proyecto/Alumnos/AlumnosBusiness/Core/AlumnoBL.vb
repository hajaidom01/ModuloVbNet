Imports AlumnosDataAccess
Imports AlumnosEntities

Public Class AlumnoBL

    Dim data As New AlumnosDat

    Public Function ObtenerAlumnos() As List(Of AlumnoEnt)
        Return data.GetAll()
    End Function

    Public Function BuscarAlumno(matricula As Integer) As AlumnoEnt
        Return data.AlumnoPorMatricula(matricula)
    End Function

    Public Function GuardarAlumno(alumno As AlumnoEnt) As Boolean
        Return data.GuardarAlumno(alumno)
    End Function

    Public Function EditarAlumno(alumno As AlumnoEnt) As Boolean
        Return data.EditarAlumno(alumno)
    End Function
End Class
