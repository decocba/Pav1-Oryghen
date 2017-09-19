Public Class frm_registrar_clase
    Dim oTipificaciones As New TipificacionesService
    Dim oClase As New Clase
    Private Sub frm_registrar_clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cbo_tipo_danza, oTipificaciones.lista_tipos_danzas, "nombre", "id_tipo_danza")
    End Sub

    Friend Sub cargarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarClase()
        Dim oClaseService As New ClaseService
        oClaseService.registrar(oClase)
        MessageBox.Show("Clase registrada")
    End Sub

    Private Sub cargarClase()
        oClase.nombre = txt_nombre.Text
        oClase.tipo_danza = cbo_tipo_danza.SelectedItem("id_tipo_danza")
        oClase.cupo = txt_cupo.Text
        oClase.fecha_inicio = CDate(txt_fecha_inicio.Text)
        oClase.fecha_fin = CDate(txt_fecha_fin.Text)
        oClase.costo = txt_costo.Text
        oClase.descripcion = txt_descripcion.Text

    End Sub
End Class