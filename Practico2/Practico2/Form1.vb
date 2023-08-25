Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
        Dim respuesta As MsgBoxResult
        If TDni.Text = "" Or TApellido.Text = "" Or TNombre.Text = "" Then
            MsgBox("Hay campos sin rellenar", MsgBoxStyle.Critical, "Error")
        Else
            If (IsNumeric(TDni.Text) = False) Then
                MsgBox("Ingrese solo numeros en DNI", MsgBoxStyle.Critical, "Importante")
            Else
                If (IsNumeric(TApellido.Text) = True) Or (IsNumeric(TNombre.Text) = True) Then
                    MsgBox("Asegurese que los campos Apellido o Nombre tenga solo letras", MsgBoxStyle.Critical, "Critico")
                Else
                    respuesta = MsgBox("Seguro que desea agregar un nuevo Cliente", MsgBoxStyle.Question + vbYesNo, "Confirmar insercion")
                    If respuesta = MsgBoxResult.Yes Then
                        LModificar.Text = TApellido.Text & " " & TNombre.Text
                        MsgBox("El cliente " & LModificar.Text & " se agrego exitosamente", MsgBoxStyle.Information, "Guardar")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
        Dim respuesta As MsgBoxResult
        If LModificar.Text = "" Then
            MsgBox("Debe guardar un Cliente primero")
        Else
            respuesta = MsgBox("Esta seguro que desea eliminar el registro de:" & LModificar.Text & "??", MsgBoxStyle.YesNo, "Atencion")
            If respuesta = MsgBoxResult.Yes Then
                MsgBox("El cliente " & LModificar.Text & " se elimino correctamente", MsgBoxStyle.Information, "Informacion")
                LModificar.Text = ""
                TDni.Text = ""
                TApellido.Text = ""
                TNombre.Text = ""
            End If
        End If
    End Sub
End Class
