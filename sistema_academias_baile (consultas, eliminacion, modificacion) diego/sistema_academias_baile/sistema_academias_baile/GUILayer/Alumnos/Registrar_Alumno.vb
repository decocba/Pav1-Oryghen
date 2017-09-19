Public Class Registrar_Alumno
    Dim oTipificaciones As New TipificacionesService
    Dim oAlumno As New Alumno
    Dim no_carga As Boolean = True
    Dim modifico As Boolean = False
    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registrar_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If no_carga Then
            cargarCombo(cbo_tipo_documento, oTipificaciones.lista_tipos_documentos, "nombre", "id_tipo_documento")
            cargarCombo(cbo_provincia, oTipificaciones.lista_provincias, "nombre", "id")
            cargarCombo(cbo_sexo, oTipificaciones.lista_sexos, "descripcion", "id")
            btn_guardar.Visible = False
        Else
            btn_guardar.Visible = True
            btn_guardar.Enabled = False
            btn_aceptar.Visible = False
        End If
        

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


    Sub cargar(id_seleccionado As Integer, tabla As String)
        btn_modificar.Visible = True
        lbl_legajo.Visible = True
        txt_legajo.Visible = True
        txt_legajo.Text = id_seleccionado
        lbl_tipo.Visible = True
        txt_tipo.Visible = True
        txt_tipo.Text = tabla

        btn_aceptar.Enabled = False

        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        cbo_sexo.Enabled = False
        cbo_tipo_documento.Enabled = False
        txt_numero_documento.Enabled = False
        txt_fecha_nacimiento.Enabled = False
        txt_telefono.Enabled = False
        txt_email.Enabled = False

        cbo_provincia.Enabled = False
        cbo_departamento.Enabled = False
        cbo_localidad.Enabled = False
        txt_calle.Enabled = False
        txt_calle_numero.Enabled = False
        txt_observacion.Enabled = False

        txt_nombre_contacto.Enabled = False
        txt_telefono_contacto.Enabled = False


        Dim oPersonaService As New PersonaService
        Dim data_resultado As DataTable = oPersonaService.buscar(id_seleccionado, tabla)
        For Each row As DataRow In data_resultado.Rows
            txt_nombre.Text = row.Item("nombre").ToString
            txt_apellido.Text = row.Item("apellido").ToString
            cbo_sexo.Text = row.Item("sexo").ToString
            cbo_tipo_documento.Text = row.Item("tipo_documento").ToString
            MessageBox.Show(row.Item("tipo_documento").ToString)

            txt_numero_documento.Text = row.Item("numero_documento").ToString
            txt_fecha_nacimiento.Text = row.Item("fecha_nacimiento")
            txt_telefono.Text = row.Item("telefono").ToString
            txt_email.Text = row.Item("email").ToString

            cbo_provincia.Text = row.Item("provincia").ToString
            cbo_departamento.Text = row.Item("departamento").ToString
            cbo_localidad.Text = row.Item("localidad").ToString
            txt_calle.Text = row.Item("calle").ToString
            txt_calle_numero.Text = row.Item("calleNro").ToString
            txt_observacion.Text = row.Item("observacion").ToString

            txt_nombre_contacto.Text = row.Item("nombre_contacto").ToString
            txt_telefono_contacto.Text = row.Item("telefono_contacto").ToString
        Next

        no_carga = False
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        txt_nombre.Enabled = True
        txt_apellido.Enabled = True
        cbo_sexo.Enabled = True
        cbo_tipo_documento.Enabled = True
        txt_numero_documento.Enabled = True
        txt_fecha_nacimiento.Enabled = True
        txt_telefono.Enabled = True
        txt_email.Enabled = True

        cbo_provincia.Enabled = True
        cbo_departamento.Enabled = True
        cbo_localidad.Enabled = True
        txt_calle.Enabled = True
        txt_calle_numero.Enabled = True
        txt_observacion.Enabled = True

        txt_nombre_contacto.Enabled = True
        txt_telefono_contacto.Enabled = True

        cargarCombo(cbo_tipo_documento, oTipificaciones.lista_tipos_documentos, "nombre", "id_tipo_documento")
        cargarCombo(cbo_provincia, oTipificaciones.lista_provincias, "nombre", "id")
        cargarCombo(cbo_sexo, oTipificaciones.lista_sexos, "descripcion", "id")
        modifico = True
        btn_guardar.Enabled = True
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        cargarAlumno()
        Dim oPersonaService As New PersonaService
        oPersonaService.actualizar(oAlumno, txt_legajo.Text, txt_tipo.Text)
        MessageBox.Show("Perfil actualizado")
        Close()

    End Sub
End Class