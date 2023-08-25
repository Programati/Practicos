Public Class FormPF
	Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
		Dim respuesta As MsgBoxResult

		If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
			MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
		Else
			If ChMasterCard.Checked = False And ChNaranja.Checked = False And ChVisa.Checked = False Then
				MsgBox("Debe seleccionar una tarjeta", MsgBoxStyle.Critical, "Importante")
			Else
				If rbVaron.Checked = False And rbMujer.Checked = False Then
					MsgBox("Debe seleccionar un sexo", MsgBoxStyle.Critical, "Importante")
				End If
			End If

		End If


		If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") And (ChMasterCard.Checked = True Or ChNaranja.Checked = True Or ChVisa.Checked = True) And (rbVaron.Checked = True Or rbMujer.Checked = True) Then

			If (IsNumeric(TextBox1.Text) = False) Then
				MsgBox("Ingrese solo numeros en DNI", MsgBoxStyle.Critical, "Importante")
			Else
				If (IsNumeric(TextBox2.Text) = True) Or (IsNumeric(TextBox3.Text) = True) Then
					MsgBox("Solo ingrese letras en apellido o nombre", MsgBoxStyle.Critical, "Critico")
				Else
					If (IsNumeric(TextBox4.Text) = False) Then
						MsgBox("Ingrese solo numeros en Telefono", MsgBoxStyle.Critical, "Importante")
					Else
						respuesta = MsgBox("Seguro que desea agregar un nuevo Cliente", MsgBoxStyle.Question + vbYesNo, "Confirmar insercion")
						If respuesta = MsgBoxResult.Yes Then
							lNyA.Text = TextBox3.Text & " " & TextBox2.Text
							MsgBox("El cliente " & lNyA.Text & " se agrego exitosamente", MsgBoxStyle.Information, "Guardar")

						End If
					End If

				End If


			End If
		End If



	End Sub

	Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
		Dim respuesta As MsgBoxResult
		If lNyA.Text = "" Then
			MsgBox("Debe guardar un Cliente primero")

		Else
			respuesta = MsgBox("Esta seguro que desea eliminar el registro de:" & lNyA.Text & "??", MsgBoxStyle.YesNo, "Atencion")
			If respuesta = MsgBoxResult.Yes Then
				MsgBox("El cliente " & lNyA.Text & " se elimino correctamente", MsgBoxStyle.Information, "Informacion")
				TextBox1.Text = ""
				TextBox2.Text = ""
				TextBox3.Text = ""
				TextBox4.Text = ""
				lNyA.Text = ""
				ChMasterCard.Checked = False
				ChVisa.Checked = False
				ChNaranja.Checked = False
				rbVaron.Checked = False
				rbMujer.Checked = False
				pic1.Image = Nothing

			End If
		End If






	End Sub

	Private Sub rbVaron_CheckedChanged(sender As Object, e As EventArgs) Handles rbVaron.CheckedChanged
		pic1.Image = My.Resources.Varon


	End Sub

	Private Sub rvMujer_CheckedChanged(sender As Object, e As EventArgs) Handles rbMujer.CheckedChanged
		pic1.Image = My.Resources.mujerb
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub
End Class


