Imports System.ComponentModel

Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged

    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged

    End Sub


    Private Sub TApellido_Validated(sender As Object, e As EventArgs) Handles TApellido.Validated
        If IsNumeric(Me.TApellido.Text) Then
            MessageBox.Show("El campo Apelldio sólo acepta letras")
        End If
    End Sub

    Private Sub TDni_Validated(sender As Object, e As EventArgs) Handles TDni.Validated
        If Not IsNumeric(Me.TDni.Text) Then
            MessageBox.Show("El campo DNI solo acepta número")
        End If
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        If TDni.Text = "" Or TApellido.Text = "" Or TNombre.Text = "" Then
            MsgBox("Hay campos sin rellenar", 16)
            TDni.Focus()


        Else
            If MsgBox("Guardar Datos?", 4 + 256 + 32) = 6 Then
                LModificar.Text = TApellido.Text + " " + TNombre.Text
            End If
        End If
    End Sub
End Class
