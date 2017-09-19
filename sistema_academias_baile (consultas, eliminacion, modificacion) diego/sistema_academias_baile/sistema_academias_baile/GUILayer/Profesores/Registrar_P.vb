Public Class Registrar_P
    Dim oTipificaciones As New TipificacionesService
    Dim oAlumno As New Alumno
    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registrar_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cbo_tipo_documento, oTipificaciones.lista_tipos_documentos, "nombre", "id_tipo_documento")
        cargarCombo(cbo_provincia, oTipificaciones.lista_provincias, "nombre", "id")
        cargarCombo(cbo_sexo, oTipificaciones.lista_sexos, "descripcion", "id")

    End Sub

    Friend Sub cargarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.SelectedIndex = -1
    End Sub

    Private Sub cbo_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_provincia.SelectionChangeCommitted
        cargarCombo(cbo_departamento, oTipificaciones.lista_departamentos(cbo_provincia.SelectedItem("id")), "nombre", "id")
    End Sub

    Private Sub cbo_departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_departamento.SelectionChangeCommitted
        cargarCombo(cbo_localidad, oTipificaciones.lista_localidades(cbo_departamento.SelectedItem("id")), "nombre", "id")
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        cargarAlumno()
        Dim oAlumnoService As New AlumnoService
        oAlumnoService.registrar(oAlumno)
        MessageBox.Show("Alumno registrado")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub cargarAlumno()
        oAlumno.nombre = txt_nombre.Text
        oAlumno.apellido = txt_apellido.Text
        oAlumno.sexo = cbo_sexo.SelectedItem("id_sexo")
        oAlumno.tipo_documento = cbo_tipo_documento.SelectedItem("id_tipo_documento")
        oAlumno.numero_documento = CInt(txt_numero_documento.Text)
        oAlumno.fecha_nacimiento = CDate(txt_fecha_nacimiento.Text)
        'oAlumno.telefono = 111
        ' oAlumno.email = txt_email.Text
        oAlumno.provincia = cbo_provincia.SelectedItem("id")
        oAlumno.departamento = cbo_departamento.SelectedItem("id")
        oAlumno.localidad = cbo_localidad.SelectedItem("ID")
        oAlumno.calle = txt_calle.Text
        oAlumno.calle_numero = txt_calle_numero.Text
        oAlumno.observacion = txt_observacion.Text
        oAlumno.nombre_contacto = txt_nombre_contacto.Text
        'oAlumno.telefono_contacto = 111


        oAlumno.telefono = 111

        oAlumno.telefono_contacto = 111
    End Sub

    Private Sub cbo_provincia_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbo_provincia.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged

    End Sub
End Class