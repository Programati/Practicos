﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LApellido = New Label()
        LNombre = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        BSalir = New Button()
        SuspendLayout()
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(12, 40)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 0
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(12, 102)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 1
        LNombre.Text = "Nombre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(124, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 102)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(138, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(286, 40)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(186, 85)
        TextBox3.TabIndex = 4
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(12, 170)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(75, 23)
        BGuardar.TabIndex = 5
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(124, 170)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 23)
        BEliminar.TabIndex = 6
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(397, 226)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(75, 23)
        BSalir.TabIndex = 7
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 261)
        Controls.Add(BSalir)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mi Primer Forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BSalir As Button
End Class
