Public Class AlumnoService

    Private oAlumnoDao As AlumnoDao

    Public Sub New()
        oAlumnoDao = New AlumnoDao
    End Sub

    'Public Function validarUsuario(ByVal nombre As String, ByVal password As String) As Usuario
    ' Return oAlumno.metodo
    'End Function

    Public Function insertar()
        Return True
    End Function

    Public Function registrar(oAlumno As Alumno)
        oAlumnoDao.registrar(oAlumno)
        Return True
    End Function

    Sub actualizar(oAlumno As Alumno, p2 As String, p3 As String)
        Throw New NotImplementedException
    End Sub


End Class
