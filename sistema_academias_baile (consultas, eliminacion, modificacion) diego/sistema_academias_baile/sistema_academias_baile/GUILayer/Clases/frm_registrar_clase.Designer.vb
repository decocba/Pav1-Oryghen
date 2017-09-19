<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_clase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_tipo_danza = New System.Windows.Forms.Label()
        Me.lbl_profesor = New System.Windows.Forms.Label()
        Me.lbl_fecha_inicio = New System.Windows.Forms.Label()
        Me.lbl_fecha_fin = New System.Windows.Forms.Label()
        Me.lbl_cupo = New System.Windows.Forms.Label()
        Me.lbl_clase = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cbo_tipo_danza = New System.Windows.Forms.ComboBox()
        Me.txt_cupo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_fin = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_costo = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_costo = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(20, 32)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(60, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre (*):"
        '
        'lbl_tipo_danza
        '
        Me.lbl_tipo_danza.AutoSize = True
        Me.lbl_tipo_danza.Location = New System.Drawing.Point(239, 32)
        Me.lbl_tipo_danza.Name = "lbl_tipo_danza"
        Me.lbl_tipo_danza.Size = New System.Drawing.Size(93, 13)
        Me.lbl_tipo_danza.TabIndex = 1
        Me.lbl_tipo_danza.Text = "Tipo de Danza (*):"
        '
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(197, 81)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(49, 13)
        Me.lbl_profesor.TabIndex = 2
        Me.lbl_profesor.Text = "Profesor:"
        '
        'lbl_fecha_inicio
        '
        Me.lbl_fecha_inicio.AutoSize = True
        Me.lbl_fecha_inicio.Location = New System.Drawing.Point(20, 122)
        Me.lbl_fecha_inicio.Name = "lbl_fecha_inicio"
        Me.lbl_fecha_inicio.Size = New System.Drawing.Size(80, 13)
        Me.lbl_fecha_inicio.TabIndex = 3
        Me.lbl_fecha_inicio.Text = "Fecha inicio (*):"
        '
        'lbl_fecha_fin
        '
        Me.lbl_fecha_fin.AutoSize = True
        Me.lbl_fecha_fin.Location = New System.Drawing.Point(26, 158)
        Me.lbl_fecha_fin.Name = "lbl_fecha_fin"
        Me.lbl_fecha_fin.Size = New System.Drawing.Size(54, 13)
        Me.lbl_fecha_fin.TabIndex = 4
        Me.lbl_fecha_fin.Text = "Fecha fin:"
        '
        'lbl_cupo
        '
        Me.lbl_cupo.AutoSize = True
        Me.lbl_cupo.Location = New System.Drawing.Point(20, 81)
        Me.lbl_cupo.Name = "lbl_cupo"
        Me.lbl_cupo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_cupo.TabIndex = 5
        Me.lbl_cupo.Text = "Cupo:"
        '
        'lbl_clase
        '
        Me.lbl_clase.AutoSize = True
        Me.lbl_clase.Location = New System.Drawing.Point(20, 196)
        Me.lbl_clase.Name = "lbl_clase"
        Me.lbl_clase.Size = New System.Drawing.Size(66, 13)
        Me.lbl_clase.TabIndex = 6
        Me.lbl_clase.Text = "Descripción:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(86, 29)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(132, 20)
        Me.txt_nombre.TabIndex = 7
        '
        'cbo_tipo_danza
        '
        Me.cbo_tipo_danza.FormattingEnabled = True
        Me.cbo_tipo_danza.Location = New System.Drawing.Point(338, 28)
        Me.cbo_tipo_danza.Name = "cbo_tipo_danza"
        Me.cbo_tipo_danza.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipo_danza.TabIndex = 8
        '
        'txt_cupo
        '
        Me.txt_cupo.Location = New System.Drawing.Point(61, 78)
        Me.txt_cupo.Name = "txt_cupo"
        Me.txt_cupo.Size = New System.Drawing.Size(100, 20)
        Me.txt_cupo.TabIndex = 9
        '
        'txt_fecha_inicio
        '
        Me.txt_fecha_inicio.Location = New System.Drawing.Point(107, 122)
        Me.txt_fecha_inicio.Mask = "00/00/0000"
        Me.txt_fecha_inicio.Name = "txt_fecha_inicio"
        Me.txt_fecha_inicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_inicio.TabIndex = 10
        Me.txt_fecha_inicio.ValidatingType = GetType(Date)
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.Location = New System.Drawing.Point(107, 158)
        Me.txt_fecha_fin.Mask = "00/00/0000"
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_fin.TabIndex = 11
        Me.txt_fecha_fin.ValidatingType = GetType(Date)
        '
        'lbl_costo
        '
        Me.lbl_costo.AutoSize = True
        Me.lbl_costo.Location = New System.Drawing.Point(239, 125)
        Me.lbl_costo.Name = "lbl_costo"
        Me.lbl_costo.Size = New System.Drawing.Size(50, 13)
        Me.lbl_costo.TabIndex = 12
        Me.lbl_costo.Text = "Costo (*):"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(23, 212)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(452, 121)
        Me.txt_descripcion.TabIndex = 13
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(295, 122)
        Me.txt_costo.Mask = "99999"
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(100, 20)
        Me.txt_costo.TabIndex = 14
        Me.txt_costo.ValidatingType = GetType(Integer)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_registrar_clase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 408)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_costo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.lbl_costo)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_inicio)
        Me.Controls.Add(Me.txt_cupo)
        Me.Controls.Add(Me.cbo_tipo_danza)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_clase)
        Me.Controls.Add(Me.lbl_cupo)
        Me.Controls.Add(Me.lbl_fecha_fin)
        Me.Controls.Add(Me.lbl_fecha_inicio)
        Me.Controls.Add(Me.lbl_profesor)
        Me.Controls.Add(Me.lbl_tipo_danza)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "frm_registrar_clase"
        Me.Text = "frm_registrar_clase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_danza As System.Windows.Forms.Label
    Friend WithEvents lbl_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_inicio As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_fin As System.Windows.Forms.Label
    Friend WithEvents lbl_cupo As System.Windows.Forms.Label
    Friend WithEvents lbl_clase As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cbo_tipo_danza As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cupo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_inicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_fin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_costo As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_costo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
