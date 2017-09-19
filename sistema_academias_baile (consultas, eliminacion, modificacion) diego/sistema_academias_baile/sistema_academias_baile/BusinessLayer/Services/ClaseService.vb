Public Class ClaseService
    Private oClaseDao As ClaseDao

    Public Sub New()
        oClaseDao = New ClaseDao
    End Sub

    'Public Function validarUsuario(ByVal nombre As String, ByVal password As String) As Usuario
    ' Return oAlumno.metodo
    'End Function

    Public Function insertar()
        Return True
    End Function

    Public Function registrar(oClase As Clase)
        oClaseDao.registrar(oClase)
        Return True
    End Function


End Class
