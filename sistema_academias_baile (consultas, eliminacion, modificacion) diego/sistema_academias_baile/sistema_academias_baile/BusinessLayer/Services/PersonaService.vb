Public Class PersonaService
    Private oPersonaDao As PersonaDao

    Public Sub New()
        oPersonaDao = New PersonaDao
    End Sub


    Public Function consultar(tabla As String, nombre As String)
        Return oPersonaDao.consultar(tabla, nombre)

    End Function

    Public Function buscar(id_seleccionado As Integer, tabla As String)
        Return oPersonaDao.buscar(id_seleccionado, tabla)
    End Function

    Sub actualizar(oAlumno As Alumno, id As String, tabla As String)
        oPersonaDao.actualizar(oAlumno, id, tabla)
    End Sub

    Sub eliminar(id As String, tabla As String)
        oPersonaDao.eliminar(id, tabla)
    End Sub
End Class
