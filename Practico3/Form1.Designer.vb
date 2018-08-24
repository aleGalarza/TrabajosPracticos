<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.LNya = New System.Windows.Forms.Label()
		Me.LModificar = New System.Windows.Forms.Label()
		Me.LDni = New System.Windows.Forms.Label()
		Me.LApellido = New System.Windows.Forms.Label()
		Me.LNombre = New System.Windows.Forms.Label()
		Me.TDni = New System.Windows.Forms.TextBox()
		Me.TApellido = New System.Windows.Forms.TextBox()
		Me.TNombre = New System.Windows.Forms.TextBox()
		Me.TGuardar = New System.Windows.Forms.Button()
		Me.TEliminar = New System.Windows.Forms.Button()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LNya
		'
		Me.LNya.AutoSize = True
		Me.LNya.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LNya.Location = New System.Drawing.Point(20, 22)
		Me.LNya.Name = "LNya"
		Me.LNya.Size = New System.Drawing.Size(128, 14)
		Me.LNya.TabIndex = 0
		Me.LNya.Text = "Nombre y Apellido"
		'
		'LModificar
		'
		Me.LModificar.AutoSize = True
		Me.LModificar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LModificar.ForeColor = System.Drawing.Color.Red
		Me.LModificar.Location = New System.Drawing.Point(163, 22)
		Me.LModificar.Name = "LModificar"
		Me.LModificar.Size = New System.Drawing.Size(68, 14)
		Me.LModificar.TabIndex = 1
		Me.LModificar.Text = "Modificar"
		'
		'LDni
		'
		Me.LDni.AutoSize = True
		Me.LDni.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LDni.Location = New System.Drawing.Point(20, 56)
		Me.LDni.Name = "LDni"
		Me.LDni.Size = New System.Drawing.Size(33, 14)
		Me.LDni.TabIndex = 2
		Me.LDni.Text = "DNI"
		'
		'LApellido
		'
		Me.LApellido.AutoSize = True
		Me.LApellido.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LApellido.Location = New System.Drawing.Point(20, 94)
		Me.LApellido.Name = "LApellido"
		Me.LApellido.Size = New System.Drawing.Size(60, 14)
		Me.LApellido.TabIndex = 3
		Me.LApellido.Text = "Apellido"
		'
		'LNombre
		'
		Me.LNombre.AutoSize = True
		Me.LNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LNombre.Location = New System.Drawing.Point(20, 137)
		Me.LNombre.Name = "LNombre"
		Me.LNombre.Size = New System.Drawing.Size(59, 14)
		Me.LNombre.TabIndex = 4
		Me.LNombre.Text = "Nombre"
		'
		'TDni
		'
		Me.TDni.Location = New System.Drawing.Point(147, 50)
		Me.TDni.Name = "TDni"
		Me.TDni.Size = New System.Drawing.Size(100, 20)
		Me.TDni.TabIndex = 5
		'
		'TApellido
		'
		Me.TApellido.Location = New System.Drawing.Point(147, 88)
		Me.TApellido.Name = "TApellido"
		Me.TApellido.Size = New System.Drawing.Size(100, 20)
		Me.TApellido.TabIndex = 6
		'
		'TNombre
		'
		Me.TNombre.Location = New System.Drawing.Point(147, 131)
		Me.TNombre.Name = "TNombre"
		Me.TNombre.Size = New System.Drawing.Size(100, 20)
		Me.TNombre.TabIndex = 7
		'
		'TGuardar
		'
		Me.TGuardar.Location = New System.Drawing.Point(23, 205)
		Me.TGuardar.Name = "TGuardar"
		Me.TGuardar.Size = New System.Drawing.Size(75, 23)
		Me.TGuardar.TabIndex = 8
		Me.TGuardar.Text = "Guardar"
		Me.TGuardar.UseVisualStyleBackColor = True
		'
		'TEliminar
		'
		Me.TEliminar.Location = New System.Drawing.Point(156, 205)
		Me.TEliminar.Name = "TEliminar"
		Me.TEliminar.Size = New System.Drawing.Size(75, 23)
		Me.TEliminar.TabIndex = 9
		Me.TEliminar.Text = "Eliminar"
		Me.TEliminar.UseVisualStyleBackColor = True
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(300, 297)
		Me.Controls.Add(Me.TEliminar)
		Me.Controls.Add(Me.TGuardar)
		Me.Controls.Add(Me.TNombre)
		Me.Controls.Add(Me.TApellido)
		Me.Controls.Add(Me.TDni)
		Me.Controls.Add(Me.LNombre)
		Me.Controls.Add(Me.LApellido)
		Me.Controls.Add(Me.LDni)
		Me.Controls.Add(Me.LModificar)
		Me.Controls.Add(Me.LNya)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "Form1"
		Me.Text = "Pequeño Formulario"
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LNya As Label
	Friend WithEvents LModificar As Label
	Friend WithEvents LDni As Label
	Friend WithEvents LApellido As Label
	Friend WithEvents LNombre As Label
	Friend WithEvents TDni As TextBox
	Friend WithEvents TApellido As TextBox
	Friend WithEvents TNombre As TextBox
	Friend WithEvents TGuardar As Button
	Friend WithEvents TEliminar As Button
	Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
