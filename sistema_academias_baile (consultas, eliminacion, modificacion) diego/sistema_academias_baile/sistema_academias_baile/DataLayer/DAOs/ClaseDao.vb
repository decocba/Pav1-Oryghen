Public Class ClaseDao
    Public Sub registrar(o As Clase)
        BDHelper.getDBHelper.ConsultaSQL("INSERT INTO clases ([nombre],[id_tipo_danza],[id_profesor],[fecha_inicio],[fecha_fin],[cupo],[descripcion],[id_empleado_creo],[fecha_creacion],[id_estado_clase],[id_empleado_ultimo_estado],[fecha_ultimo_estado])   VALUES('" + o.nombre + "'," + o.tipo_danza.ToString + ",NULL,'" + o.fecha_inicio.ToString + "','" + o.fecha_fin.ToString + "'," + o.cupo.ToString + ",'" + o.descripcion + "',1,GETDATE(),1,1,1)")
    End Sub
End Class
