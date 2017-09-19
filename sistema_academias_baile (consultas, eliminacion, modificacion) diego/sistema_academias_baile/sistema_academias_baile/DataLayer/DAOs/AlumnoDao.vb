Public Class AlumnoDao
    Public Sub registrar(oAlumno As Alumno)
        BDHelper.getDBHelper.ConsultaSQL("INSERT INTO alumnos ([tipo_documento],[numero_documento],[nombre],[apellido],[fecha_nacimiento],[sexo],[provincia],[departamento],[localidad],[calle],[calleNro],[telefono],[email],[observacion],[fecha_ingreso],[id_empleado_registro],[borrado],[fecha_borrado],[id_empleado_borro],[nombre_contacto],[telefono_contacto],[fecha_creacion]) VALUES( " + oAlumno.tipo_documento.ToString + "," + oAlumno.numero_documento.ToString + ",'" + oAlumno.nombre + "','" + oAlumno.apellido + "','" + oAlumno.fecha_nacimiento.ToString + "'," + oAlumno.sexo.ToString + "," + oAlumno.provincia.ToString + "," + oAlumno.departamento.ToString + "," + oAlumno.localidad.ToString + ",'" + oAlumno.calle + "'," + oAlumno.calle_numero.ToString + "," + oAlumno.telefono.ToString + ",'" + oAlumno.email + "','" + oAlumno.observacion + "', GETDATE(), 1,NULL,NULL,NULL,'" + oAlumno.nombre_contacto + "'," + oAlumno.telefono.ToString + ",GETDATE())")
    End Sub

End Class
