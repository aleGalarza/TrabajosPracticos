﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario1
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
		Me.BGuardar = New System.Windows.Forms.Button()
		Me.BEliminar = New System.Windows.Forms.Button()
		Me.LApellido = New System.Windows.Forms.Label()
		Me.LNombre = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.BSalir = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'BGuardar
		'
		Me.BGuardar.Location = New System.Drawing.Point(36, 177)
		Me.BGuardar.Name = "BGuardar"
		Me.BGuardar.Size = New System.Drawing.Size(75, 23)
		Me.BGuardar.TabIndex = 0
		Me.BGuardar.Text = "Guarda"
		Me.BGuardar.UseVisualStyleBackColor = True
		'
		'BEliminar
		'
		Me.BEliminar.Location = New System.Drawing.Point(139, 177)
		Me.BEliminar.Name = "BEliminar"
		Me.BEliminar.Size = New System.Drawing.Size(75, 23)
		Me.BEliminar.TabIndex = 1
		Me.BEliminar.Text = "Eliminar"
		Me.BEliminar.UseVisualStyleBackColor = True
		'
		'LApellido
		'
		Me.LApellido.AutoSize = True
		Me.LApellido.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LApellido.Location = New System.Drawing.Point(23, 53)
		Me.LApellido.Name = "LApellido"
		Me.LApellido.Size = New System.Drawing.Size(56, 14)
		Me.LApellido.TabIndex = 2
		Me.LApellido.Text = "Apellido"
		'
		'LNombre
		'
		Me.LNombre.AutoSize = True
		Me.LNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LNombre.Location = New System.Drawing.Point(23, 113)
		Me.LNombre.Name = "LNombre"
		Me.LNombre.Size = New System.Drawing.Size(56, 14)
		Me.LNombre.TabIndex = 3
		Me.LNombre.Text = "Nombre"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(85, 51)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(119, 20)
		Me.TextBox1.TabIndex = 4
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(85, 107)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(119, 20)
		Me.TextBox2.TabIndex = 5
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(242, 51)
		Me.TextBox3.Multiline = True
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(198, 166)
		Me.TextBox3.TabIndex = 6
		'
		'BSalir
		'
		Me.BSalir.Location = New System.Drawing.Point(365, 22)
		Me.BSalir.Name = "BSalir"
		Me.BSalir.Size = New System.Drawing.Size(75, 23)
		Me.BSalir.TabIndex = 7
		Me.BSalir.Text = "Salir"
		Me.BSalir.UseVisualStyleBackColor = True
		'
		'Formulario1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(484, 261)
		Me.Controls.Add(Me.BSalir)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.LNombre)
		Me.Controls.Add(Me.LApellido)
		Me.Controls.Add(Me.BEliminar)
		Me.Controls.Add(Me.BGuardar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = True
		Me.Name = "Formulario1"
		Me.Text = "Mi Primer Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BGuardar As Button
	Friend WithEvents BEliminar As Button
	Friend WithEvents LApellido As Label
	Friend WithEvents LNombre As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents BSalir As Button
End Class
