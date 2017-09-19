Public Class TipificacionesService
    Private oTipificacionesDao As New TipificacionesDao
    Function lista_tipos_documentos() As Object
        Return oTipificacionesDao.lista_tipos_documentos
    End Function

    Function lista_provincias() As Object
        Return oTipificacionesDao.lista_provincias
    End Function

    Function lista_departamentos(ByVal provincia As Integer) As Object
        Return oTipificacionesDao.lista_departamentos(provincia)
    End Function

    Function lista_localidades(ByVal departamento As Integer) As Object
        Return oTipificacionesDao.lista_localidades(departamento)
    End Function

    Function lista_sexos() As Object
        Return oTipificacionesDao.lista_sexos()
    End Function

    Function lista_tipos_danzas() As Object
        Return oTipificacionesDao.lista_tipos_danzas()
    End Function

End Class
