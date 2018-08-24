Imports System.ComponentModel

Public Class Form1


	Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
		e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
		If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			Me.ErrorProvider1.SetError(TDni, "Solo puede digitar numeros")
			MsgBox("Solo Puede digitar numeros")
			Me.TDni.Clear()
			TDni.BackColor = Color.Red

		Else
			Me.ErrorProvider1.SetError(TDni, "")
			TDni.BackColor = Color.White
		End If
	End Sub




	Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
		e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
		If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
			MsgBox("Solo Puede digitar letras")

			Me.TApellido.Clear()

		End If
	End Sub

	Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
		e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
		If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
			MsgBox("Solo Puede digitar letras")
			Me.TNombre.Clear()

		End If
	End Sub

	Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
		Dim ask As MsgBoxResult
		If TDni.Text.Trim() = "" Or TNombre.Text.Trim() = "" Or TApellido.Text.Trim() = "" Then
			MsgBox("Debe Completar todos los Campos", vbCritical, "Error")
		Else
			ask = MsgBox("Seguro que desea crear un nuevo Cliente? ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmar Insercion")
			If (MsgBoxResult.Yes = ask) Then
				MsgBox("El cliente " + TNombre.Text + " " + TApellido.Text + " se registro correctamente", MsgBoxStyle.OkOnly)
				LModificar.Text = TNombre.Text + " " + TApellido.Text
			Else
				MsgBox("El cliente no se registro")
			End If

		End If
	End Sub

	Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
		Dim ask As MsgBoxResult


		ask = MsgBox("Esta a punto de eliminar el Cliente: " + TNombre.Text + " " + TApellido.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MessageBoxDefaultButton.Button2, "Confirmar Eliminacion")

		If (MsgBoxResult.Yes = ask) Then

			MsgBox("El Cliente: " + TApellido.Text + " " + TNombre.Text + " se elimino correctamente", MsgBoxStyle.Information, "Eliminar"
				   )
			TNombre.Clear()
			TApellido.Clear()
			TDni.Clear()
			LModificar.Text = ""
			LModificar.Text = "Modificar"

		Else

			MsgBox("No se elimino el cliente")
		End If
	End Sub


End Class
