<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Alumno
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_nacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_sexo = New System.Windows.Forms.ComboBox()
        Me.txt_numero_documento = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_fecha_nacimiento = New System.Windows.Forms.Label()
        Me.lbl_numero_documento = New System.Windows.Forms.Label()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_calle_numero = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_localidad = New System.Windows.Forms.ComboBox()
        Me.cbo_departamento = New System.Windows.Forms.ComboBox()
        Me.cbo_provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.lbl_provincia = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_nombre_contacto = New System.Windows.Forms.TextBox()
        Me.txt_telefono_contacto = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_telefono_contacto = New System.Windows.Forms.Label()
        Me.lbl_nombre_contacto = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.txt_legajo = New System.Windows.Forms.TextBox()
        Me.lbl_legajo = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.lbl_legajo)
        Me.GroupBox1.Controls.Add(Me.txt_legajo)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_nacimiento)
        Me.GroupBox1.Controls.Add(Me.cbo_sexo)
        Me.GroupBox1.Controls.Add(Me.txt_numero_documento)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_documento)
        Me.GroupBox1.Controls.Add(Me.lbl_email)
        Me.GroupBox1.Controls.Add(Me.lbl_telefono)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha_nacimiento)
        Me.GroupBox1.Controls.Add(Me.lbl_numero_documento)
        Me.GroupBox1.Controls.Add(Me.lbl_tipo_documento)
        Me.GroupBox1.Controls.Add(Me.lbl_sexo)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(354, 24)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(251, 20)
        Me.txt_apellido.TabIndex = 16
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(76, 24)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(206, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(68, 101)
        Me.txt_telefono.Mask = "(999)000-0000"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(89, 20)
        Me.txt_telefono.TabIndex = 15
        '
        'txt_fecha_nacimiento
        '
        Me.txt_fecha_nacimiento.Location = New System.Drawing.Point(664, 60)
        Me.txt_fecha_nacimiento.Mask = "00/00/0000"
        Me.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento"
        Me.txt_fecha_nacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_nacimiento.TabIndex = 14
        Me.txt_fecha_nacimiento.ValidatingType = GetType(Date)
        '
        'cbo_sexo
        '
        Me.cbo_sexo.FormattingEnabled = True
        Me.cbo_sexo.Location = New System.Drawing.Point(664, 24)
        Me.cbo_sexo.Name = "cbo_sexo"
        Me.cbo_sexo.Size = New System.Drawing.Size(100, 21)
        Me.cbo_sexo.TabIndex = 13
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Location = New System.Drawing.Point(363, 60)
        Me.txt_numero_documento.Mask = "99999999"
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(133, 20)
        Me.txt_numero_documento.TabIndex = 12
        Me.txt_numero_documento.ValidatingType = GetType(Integer)
        '
        'cbo_tipo_documento
        '
        Me.cbo_tipo_documento.FormattingEnabled = True
        Me.cbo_tipo_documento.Location = New System.Drawing.Point(131, 60)
        Me.cbo_tipo_documento.Name = "cbo_tipo_documento"
        Me.cbo_tipo_documento.Size = New System.Drawing.Size(65, 21)
        Me.cbo_tipo_documento.TabIndex = 11
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(163, 104)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 7
        Me.lbl_email.Text = "E-mail:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(10, 104)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 6
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'lbl_fecha_nacimiento
        '
        Me.lbl_fecha_nacimiento.AutoSize = True
        Me.lbl_fecha_nacimiento.Location = New System.Drawing.Point(536, 63)
        Me.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento"
        Me.lbl_fecha_nacimiento.Size = New System.Drawing.Size(122, 13)
        Me.lbl_fecha_nacimiento.TabIndex = 5
        Me.lbl_fecha_nacimiento.Text = "Fecha de nacimiento (*):"
        '
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = True
        Me.lbl_numero_documento.Location = New System.Drawing.Point(226, 63)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(131, 13)
        Me.lbl_numero_documento.TabIndex = 4
        Me.lbl_numero_documento.Text = "Número de documento (*):"
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(10, 63)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(115, 13)
        Me.lbl_tipo_documento.TabIndex = 3
        Me.lbl_tipo_documento.Text = "Tipo de documento (*):"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(611, 27)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(47, 13)
        Me.lbl_sexo.TabIndex = 2
        Me.lbl_sexo.Text = "Sexo (*):"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(288, 29)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(60, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido (*):"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(10, 29)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(60, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre (*):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_calle)
        Me.GroupBox2.Controls.Add(Me.txt_calle_numero)
        Me.GroupBox2.Controls.Add(Me.cbo_localidad)
        Me.GroupBox2.Controls.Add(Me.cbo_departamento)
        Me.GroupBox2.Controls.Add(Me.cbo_provincia)
        Me.GroupBox2.Controls.Add(Me.lbl_numero)
        Me.GroupBox2.Controls.Add(Me.lbl_calle)
        Me.GroupBox2.Controls.Add(Me.lbl_localidad)
        Me.GroupBox2.Controls.Add(Me.lbl_departamento)
        Me.GroupBox2.Controls.Add(Me.lbl_provincia)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(781, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(83, 66)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_calle.TabIndex = 9
        '
        'txt_calle_numero
        '
        Me.txt_calle_numero.Location = New System.Drawing.Point(503, 66)
        Me.txt_calle_numero.Mask = "99999"
        Me.txt_calle_numero.Name = "txt_calle_numero"
        Me.txt_calle_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_calle_numero.TabIndex = 8
        Me.txt_calle_numero.ValidatingType = GetType(Integer)
        '
        'cbo_localidad
        '
        Me.cbo_localidad.FormattingEnabled = True
        Me.cbo_localidad.Location = New System.Drawing.Point(609, 25)
        Me.cbo_localidad.Name = "cbo_localidad"
        Me.cbo_localidad.Size = New System.Drawing.Size(155, 21)
        Me.cbo_localidad.TabIndex = 7
        '
        'cbo_departamento
        '
        Me.cbo_departamento.FormattingEnabled = True
        Me.cbo_departamento.Location = New System.Drawing.Point(354, 25)
        Me.cbo_departamento.Name = "cbo_departamento"
        Me.cbo_departamento.Size = New System.Drawing.Size(155, 21)
        Me.cbo_departamento.TabIndex = 6
        '
        'cbo_provincia
        '
        Me.cbo_provincia.FormattingEnabled = True
        Me.cbo_provincia.Location = New System.Drawing.Point(83, 26)
        Me.cbo_provincia.Name = "cbo_provincia"
        Me.cbo_provincia.Size = New System.Drawing.Size(155, 21)
        Me.cbo_provincia.TabIndex = 5
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(449, 69)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero.TabIndex = 4
        Me.lbl_numero.Text = "Número:"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(10, 69)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 3
        Me.lbl_calle.Text = "Calle:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(534, 28)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(69, 13)
        Me.lbl_localidad.TabIndex = 2
        Me.lbl_localidad.Text = "Localidad (*):"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.Location = New System.Drawing.Point(258, 29)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(90, 13)
        Me.lbl_departamento.TabIndex = 1
        Me.lbl_departamento.Text = "Departamento (*):"
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Location = New System.Drawing.Point(10, 29)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(67, 13)
        Me.lbl_provincia.TabIndex = 0
        Me.lbl_provincia.Text = "Provincia (*):"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_observacion)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(584, 104)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Observaciones"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(13, 25)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(556, 63)
        Me.txt_observacion.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_nombre_contacto)
        Me.GroupBox4.Controls.Add(Me.txt_telefono_contacto)
        Me.GroupBox4.Controls.Add(Me.lbl_telefono_contacto)
        Me.GroupBox4.Controls.Add(Me.lbl_nombre_contacto)
        Me.GroupBox4.Location = New System.Drawing.Point(630, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(173, 104)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de contacto"
        '
        'txt_nombre_contacto
        '
        Me.txt_nombre_contacto.Location = New System.Drawing.Point(61, 33)
        Me.txt_nombre_contacto.Name = "txt_nombre_contacto"
        Me.txt_nombre_contacto.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre_contacto.TabIndex = 4
        '
        'txt_telefono_contacto
        '
        Me.txt_telefono_contacto.Location = New System.Drawing.Point(60, 68)
        Me.txt_telefono_contacto.Mask = "(999)000-0000"
        Me.txt_telefono_contacto.Name = "txt_telefono_contacto"
        Me.txt_telefono_contacto.Size = New System.Drawing.Size(91, 20)
        Me.txt_telefono_contacto.TabIndex = 3
        '
        'lbl_telefono_contacto
        '
        Me.lbl_telefono_contacto.AutoSize = True
        Me.lbl_telefono_contacto.Location = New System.Drawing.Point(7, 71)
        Me.lbl_telefono_contacto.Name = "lbl_telefono_contacto"
        Me.lbl_telefono_contacto.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono_contacto.TabIndex = 1
        Me.lbl_telefono_contacto.Text = "Teléfono:"
        '
        'lbl_nombre_contacto
        '
        Me.lbl_nombre_contacto.AutoSize = True
        Me.lbl_nombre_contacto.Location = New System.Drawing.Point(7, 33)
        Me.lbl_nombre_contacto.Name = "lbl_nombre_contacto"
        Me.lbl_nombre_contacto.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre_contacto.TabIndex = 0
        Me.lbl_nombre_contacto.Text = "Nombre:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(426, 461)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(339, 461)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(258, 461)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 6
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        Me.btn_modificar.Visible = False
        '
        'txt_legajo
        '
        Me.txt_legajo.Enabled = False
        Me.txt_legajo.Location = New System.Drawing.Point(664, 101)
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(100, 20)
        Me.txt_legajo.TabIndex = 17
        Me.txt_legajo.Visible = False
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(615, 104)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_legajo.TabIndex = 18
        Me.lbl_legajo.Text = "Legajo:"
        Me.lbl_legajo.Visible = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(208, 100)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 19
        '
        'txt_tipo
        '
        Me.txt_tipo.Enabled = False
        Me.txt_tipo.Location = New System.Drawing.Point(505, 101)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo.TabIndex = 20
        Me.txt_tipo.Visible = False
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(465, 104)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipo.TabIndex = 21
        Me.lbl_tipo.Text = "Tipo:"
        Me.lbl_tipo.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(426, 461)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseMnemonic = False
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Registrar_Alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 496)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registrar_Alumno"
        Me.ShowIcon = False
        Me.Text = "Registrar Alumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_nacimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_nacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numero_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_calle_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents lbl_provincia As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telefono_contacto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_telefono_contacto As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_contacto As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_contacto As System.Windows.Forms.TextBox
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_legajo As System.Windows.Forms.Label
    Friend WithEvents txt_legajo As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
