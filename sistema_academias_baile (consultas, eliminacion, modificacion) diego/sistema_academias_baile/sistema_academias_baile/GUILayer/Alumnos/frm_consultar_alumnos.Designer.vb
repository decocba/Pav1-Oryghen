<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consultar_alumnos
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
        Me.txt_nombre_buscado = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.data_persona = New System.Windows.Forms.DataGridView()
        Me.id_colum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.gb_bucar = New System.Windows.Forms.GroupBox()
        Me.cbo_tipo_persona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.data_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_bucar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(53, 55)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_nombre_buscado
        '
        Me.txt_nombre_buscado.Location = New System.Drawing.Point(106, 52)
        Me.txt_nombre_buscado.Name = "txt_nombre_buscado"
        Me.txt_nombre_buscado.Size = New System.Drawing.Size(169, 20)
        Me.txt_nombre_buscado.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(132, 80)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Consultar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'data_persona
        '
        Me.data_persona.AllowUserToAddRows = False
        Me.data_persona.AllowUserToDeleteRows = False
        Me.data_persona.AllowUserToOrderColumns = True
        Me.data_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_persona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_colum, Me.nombre_persona, Me.apellido_persona})
        Me.data_persona.Location = New System.Drawing.Point(18, 19)
        Me.data_persona.Name = "data_persona"
        Me.data_persona.Size = New System.Drawing.Size(309, 140)
        Me.data_persona.TabIndex = 3
        '
        'id_colum
        '
        Me.id_colum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id_colum.HeaderText = "ID"
        Me.id_colum.Name = "id_colum"
        Me.id_colum.ReadOnly = True
        Me.id_colum.Width = 43
        '
        'nombre_persona
        '
        Me.nombre_persona.HeaderText = "Nombre"
        Me.nombre_persona.Name = "nombre_persona"
        Me.nombre_persona.ReadOnly = True
        '
        'apellido_persona
        '
        Me.apellido_persona.HeaderText = "Apellido"
        Me.apellido_persona.Name = "apellido_persona"
        Me.apellido_persona.ReadOnly = True
        '
        'btn_ver
        '
        Me.btn_ver.Location = New System.Drawing.Point(21, 392)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(75, 23)
        Me.btn_ver.TabIndex = 4
        Me.btn_ver.Text = "Ver Detalles"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(102, 392)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 5
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(295, 392)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'gb_bucar
        '
        Me.gb_bucar.Controls.Add(Me.cbo_tipo_persona)
        Me.gb_bucar.Controls.Add(Me.Label1)
        Me.gb_bucar.Controls.Add(Me.lbl_nombre)
        Me.gb_bucar.Controls.Add(Me.txt_nombre_buscado)
        Me.gb_bucar.Controls.Add(Me.btn_buscar)
        Me.gb_bucar.Location = New System.Drawing.Point(21, 22)
        Me.gb_bucar.Name = "gb_bucar"
        Me.gb_bucar.Size = New System.Drawing.Size(349, 109)
        Me.gb_bucar.TabIndex = 7
        Me.gb_bucar.TabStop = False
        Me.gb_bucar.Text = "Buscar"
        '
        'cbo_tipo_persona
        '
        Me.cbo_tipo_persona.FormattingEnabled = True
        Me.cbo_tipo_persona.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cbo_tipo_persona.Items.AddRange(New Object() {"Alumnos", "Profesores", "Empleados"})
        Me.cbo_tipo_persona.Location = New System.Drawing.Point(106, 19)
        Me.cbo_tipo_persona.Name = "cbo_tipo_persona"
        Me.cbo_tipo_persona.Size = New System.Drawing.Size(169, 21)
        Me.cbo_tipo_persona.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.data_persona)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 178)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de alumnos"
        '
        'frm_consultar_alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 427)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_bucar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_ver)
        Me.Name = "frm_consultar_alumnos"
        Me.Text = "frm_consultar_alumnos"
        CType(Me.data_persona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_bucar.ResumeLayout(False)
        Me.gb_bucar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_buscado As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents data_persona As System.Windows.Forms.DataGridView
    Friend WithEvents btn_ver As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents gb_bucar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents id_colum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_persona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido_persona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbo_tipo_persona As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class
