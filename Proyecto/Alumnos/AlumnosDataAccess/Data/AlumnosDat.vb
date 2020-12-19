Imports AlumnosEntities

Public Class AlumnosDat

    Public Function GetAll() As List(Of AlumnoEnt)

        Using Entity As New EscuelaEntities

            Dim query = (From a In Entity.Alumnos
                         Select New AlumnoEnt With {
                             .Apellido = a.Apellido,
                             .Id = a.Id,
                             .Nombre = a.Nombre
                             }).ToList()

            Return query

        End Using
    End Function

    Public Function GuardarAlumno(alumno As AlumnoEnt) As Boolean
        Using oEntidad As New EscuelaEntities
            Dim alumnoInsert = New Alumno With {
                .Nombre = alumno.Nombre,
                .Apellido = alumno.Apellido,
                .Matricula = alumno.Matricula
            }

            oEntidad.Alumnos.Add(alumnoInsert)

            Try
                oEntidad.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try

        End Using
    End Function

    Public Function EditarAlumno(alumno As AlumnoEnt) As Boolean
        Using oEntidad As New EscuelaEntities
            Dim query = (From a In oEntidad.Alumnos
                         Where a.Id = alumno.Id
                         Select a).SingleOrDefault()

            query.Nombre = alumno.Nombre
            query.Apellido = alumno.Apellido
            query.Matricula = alumno.Matricula

            Try
                oEntidad.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function AlumnoPorMatricula(ByVal matricula As Int32) As AlumnoEnt
        Dim alumno = New AlumnoEnt

        Using Entity As New EscuelaEntities

            alumno = (From a In Entity.Alumnos
                      Where a.Matricula = matricula
                      Select New AlumnoEnt With {
                          .Id = a.Id,
                          .Nombre = a.Nombre,
                          .Apellido = a.Apellido,
                          .Matricula = a.Matricula
                          }).SingleOrDefault()

        End Using

        Return alumno

    End Function

    Public Function CrearAlumno(ByVal alumno As AlumnoEnt) As Boolean

        Try
            Using oEntidad As New EscuelaEntities

                Dim alum As New AlumnosDataAccess.Alumno With {
                    .Nombre = alumno.Nombre,
                    .Apellido = alumno.Apellido
                }
                oEntidad.Alumnos.Add(alum)

                oEntidad.SaveChanges()

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


End Class
