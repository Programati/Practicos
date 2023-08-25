<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        LNya = New Label()
        LModificar = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LDni = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        TGuardar = New Button()
        TEliminar = New Button()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(33, 48)
        LNya.Name = "LNya"
        LNya.Size = New Size(107, 15)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apelldio"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(161, 48)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(0, 15)
        LModificar.TabIndex = 1
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(33, 243)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(33, 183)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apelldio"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(33, 124)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 4
        LDni.Text = "DNI"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(161, 116)
        TDni.Name = "TDni"
        TDni.Size = New Size(187, 23)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(161, 175)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(187, 23)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(161, 235)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(187, 23)
        TNombre.TabIndex = 7
        ' 
        ' TGuardar
        ' 
        TGuardar.Location = New Point(83, 308)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(75, 23)
        TGuardar.TabIndex = 8
        TGuardar.Text = "Guardar"
        TGuardar.UseVisualStyleBackColor = True
        ' 
        ' TEliminar
        ' 
        TEliminar.Location = New Point(207, 308)
        TEliminar.Name = "TEliminar"
        TEliminar.Size = New Size(75, 23)
        TEliminar.TabIndex = 9
        TEliminar.Text = "Eliminar"
        TEliminar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 361)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Controls.Add(TNombre)
        Controls.Add(TApellido)
        Controls.Add(TDni)
        Controls.Add(LDni)
        Controls.Add(LApellido)
        Controls.Add(LNombre)
        Controls.Add(LModificar)
        Controls.Add(LNya)
        Name = "Form1"
        Text = "Pequeño Formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LDni As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
End Class
