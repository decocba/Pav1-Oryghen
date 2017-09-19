Public Class PersonaDao
    Public Function consultar(tabla As String, nombre As String)
        Dim str As String = "SELECT * FROM " + tabla + " where borrado IS NULL"
        If String.IsNullOrEmpty(nombre) Then

        Else
            str = str + " where nombre LIKE '%" + nombre + "%'"
        End If
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function buscar(id As String, tabla As String)
        Dim tipo_identificacion As String = ""
        If tabla = "Alumnos" Then
            tipo_identificacion = "id_alumno"
        End If
        If tabla = "Profesores" Then
            tipo_identificacion = "id_profesor"
        End If
        If tabla = "Empleados" Then
            tipo_identificacion = "id_empleado"
        End If
        Dim str As String = "SELECT t.nombre, t.apellido, tipos_documentos.nombre AS tipo_documento, t.numero_documento, t.fecha_nacimiento, provincias.Nombre AS provincia,                      departamentos.Nombre AS departamento, localidades.Nombre AS localidad, sexos.descripcion AS sexo, t.telefono, t.email, t.calle, t.calleNro, t.observacion, t.telefono_contacto, t.nombre_contacto FROM " + tabla + " t INNER JOIN sexos ON t.sexo = sexos.id_sexo INNER JOIN  tipos_documentos ON t.tipo_documento = tipos_documentos.id_tipo_documento INNER JOIN provincias ON t.provincia = provincias.ID INNER JOIN localidades ON t.localidad = localidades.ID INNER JOIN departamentos ON t.departamento = departamentos.ID AND provincias.ID = departamentos.idProvincia AND localidades.idDepartamento = departamentos.ID WHERE t." + tipo_identificacion + " = " + id.ToString

        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Sub actualizar(o As Persona, id As String, tabla As String)
        Dim tipo As String = ""
        If tabla = "Alumnos" Then
            tipo = "alumno"
        End If
        If tabla = "Profesores" Then
            tipo = "profesor"
        End If
        If tabla = "Empleados" Then
            tipo = "empleado"
        End If

        Dim str As String = "UPDATE " + tabla + " SET [tipo_documento] = " + o.tipo_documento.ToString + ",[numero_documento] = " + o.numero_documento.ToString + ",[nombre] = '" + o.nombre + "',[apellido] = '" + o.apellido + "',[fecha_nacimiento] = '" + o.fecha_nacimiento.ToString + "',[sexo] = " + o.sexo.ToString + ",[provincia] = " + o.provincia.ToString + ",[departamento] = " + o.departamento.ToString + ",[localidad] = " + o.localidad.ToString + ",[calle] = '" + o.calle + "',[calleNro] = " + o.calle_numero.ToString + ",[telefono] = " + o.telefono.ToString + ",[email] = '" + o.email + "',[observacion] = '" + o.observacion + "',[nombre_contacto] = '" + o.nombre_contacto + "',[telefono_contacto] = " + o.telefono_contacto.ToString + " WHERE id_" + tipo + " = " + id.ToString
        BDHelper.getDBHelper.ConsultaSQL(str)
    End Sub

    Sub eliminar(id As String, tabla As String)
        Dim tipo As String = ""
        If tabla = "Alumnos" Then
            tipo = "alumno"
        End If
        If tabla = "Profesores" Then
            tipo = "profesor"
        End If
        If tabla = "Empleados" Then
            tipo = "empleado"
        End If
        Dim str As String = "UPDATE " + tabla + " SET [borrado] = 'True' WHERE id_" + tipo + " = " + id.ToString
        BDHelper.getDBHelper.ConsultaSQL(str)


    End Sub

End Class
