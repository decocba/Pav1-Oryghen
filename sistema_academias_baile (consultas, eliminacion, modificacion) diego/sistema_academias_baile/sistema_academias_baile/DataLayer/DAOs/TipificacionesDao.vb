Public Class TipificacionesDao

    Function lista_tipos_documentos() As Object
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from tipos_documentos")
    End Function

    Function lista_provincias() As Object
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from provincias")
    End Function

    Function lista_departamentos(provincia As Integer) As Object
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from departamentos where idprovincia = " + provincia.ToString)
    End Function

    Function lista_localidades(departamento As Integer) As Object
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from localidades  where idDepartamento = " + departamento.ToString)
    End Function

    Function lista_sexos() As Object
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from sexos")
    End Function

    Function lista_tipos_danzas() As Object
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from tipos_danza")
    End Function

End Class
