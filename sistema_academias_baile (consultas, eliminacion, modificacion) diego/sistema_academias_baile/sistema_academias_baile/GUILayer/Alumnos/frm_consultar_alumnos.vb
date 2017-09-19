Public Class frm_consultar_alumnos


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)
        Dim tabla As String

        Dim oPersonaService As New PersonaService

        llenarGrid(oPersonaService.consultar(cbo_tipo_persona.SelectedItem, txt_nombre_buscado.Text))
    End Sub

    Private Sub llenarGrid(ByRef source As DataTable)
        data_persona.Rows.Clear()

        If cbo_tipo_persona.SelectedItem = "Alumnos" Then
            For Each row As DataRow In source.Rows
                data_persona.Rows.Add(New String() {row.Item("id_alumno").ToString, row.Item("nombre").ToString, row.Item("apellido").ToString, row.Item("fecha_ingreso").ToString().Substring(0, 10)})
            Next
        End If

        If cbo_tipo_persona.SelectedItem = "Profesores" Then
            For Each row As DataRow In source.Rows
                data_persona.Rows.Add(New String() {row.Item("id_profesor").ToString, row.Item("nombre").ToString, row.Item("apellido").ToString, row.Item("fecha_ingreso").ToString().Substring(0, 10)})
            Next
        End If

        If cbo_tipo_persona.SelectedItem = "Empleados" Then
            For Each row As DataRow In source.Rows
                data_persona.Rows.Add(New String() {row.Item("id_empleado").ToString, row.Item("nombre").ToString, row.Item("apellido").ToString, row.Item("fecha_ingreso").ToString().Substring(0, 10)})
            Next
        End If

    End Sub

    Private Sub frm_consultar_alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        Dim id_seleccionado As Integer = data_persona.CurrentRow.Cells("id_colum").Value
        Dim ventana As Registrar_Alumno = New Registrar_Alumno()
        ventana.cargar(id_seleccionado, cbo_tipo_persona.SelectedItem)
        ventana.Text = "Consulta de datos personales"
        ventana.Show()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_seleccionado As Integer = data_persona.CurrentRow.Cells("id_colum").Value
        MessageBox.Show(id_seleccionado.ToString)
        Dim oPersonaService As New PersonaService
        oPersonaService.eliminar(id_seleccionado.ToString, cbo_tipo_persona.Text)
        MessageBox.Show("Eliminado")
        llenarGrid(oPersonaService.consultar(cbo_tipo_persona.SelectedItem, txt_nombre_buscado.Text))

    End Sub

    Private Sub gb_bucar_Enter(sender As Object, e As EventArgs) Handles gb_bucar.Enter

    End Sub
End Class