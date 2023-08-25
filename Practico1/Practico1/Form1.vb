Public Class Form1
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        TextBox3.Text = TextBox1.Text & " " & TextBox2.Text
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            End
        End If
    End Sub
End Class
