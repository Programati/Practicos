<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPF
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lNyA = New System.Windows.Forms.Label()
        Me.lTdC = New System.Windows.Forms.Label()
        Me.ChNaranja = New System.Windows.Forms.CheckBox()
        Me.ChVisa = New System.Windows.Forms.CheckBox()
        Me.ChMasterCard = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbVaron = New System.Windows.Forms.RadioButton()
        Me.rbMujer = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(154, 158)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 203)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre y apellido"
        '
        'lNyA
        '
        Me.lNyA.AutoSize = True
        Me.lNyA.ForeColor = System.Drawing.Color.Red
        Me.lNyA.Location = New System.Drawing.Point(173, 67)
        Me.lNyA.Name = "lNyA"
        Me.lNyA.Size = New System.Drawing.Size(0, 13)
        Me.lNyA.TabIndex = 9
        '
        'lTdC
        '
        Me.lTdC.AutoSize = True
        Me.lTdC.Location = New System.Drawing.Point(26, 292)
        Me.lTdC.Name = "lTdC"
        Me.lTdC.Size = New System.Drawing.Size(96, 13)
        Me.lTdC.TabIndex = 10
        Me.lTdC.Text = "Tarjetas de Credito"
        '
        'ChNaranja
        '
        Me.ChNaranja.AutoSize = True
        Me.ChNaranja.Location = New System.Drawing.Point(154, 291)
        Me.ChNaranja.Name = "ChNaranja"
        Me.ChNaranja.Size = New System.Drawing.Size(63, 17)
        Me.ChNaranja.TabIndex = 11
        Me.ChNaranja.Text = "Naranja"
        Me.ChNaranja.UseVisualStyleBackColor = True
        '
        'ChVisa
        '
        Me.ChVisa.AutoSize = True
        Me.ChVisa.Location = New System.Drawing.Point(154, 323)
        Me.ChVisa.Name = "ChVisa"
        Me.ChVisa.Size = New System.Drawing.Size(46, 17)
        Me.ChVisa.TabIndex = 12
        Me.ChVisa.Text = "Visa"
        Me.ChVisa.UseVisualStyleBackColor = True
        '
        'ChMasterCard
        '
        Me.ChMasterCard.AutoSize = True
        Me.ChMasterCard.Location = New System.Drawing.Point(154, 356)
        Me.ChMasterCard.Name = "ChMasterCard"
        Me.ChMasterCard.Size = New System.Drawing.Size(80, 17)
        Me.ChMasterCard.TabIndex = 13
        Me.ChMasterCard.Text = "MasterCard"
        Me.ChMasterCard.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Telefono"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(154, 248)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(127, 20)
        Me.TextBox4.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbVaron)
        Me.GroupBox1.Controls.Add(Me.rbMujer)
        Me.GroupBox1.Location = New System.Drawing.Point(330, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 51)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'rbVaron
        '
        Me.rbVaron.AutoSize = True
        Me.rbVaron.BackgroundImage = Global.practico_3.My.Resources.Resources.Varon
        Me.rbVaron.Location = New System.Drawing.Point(16, 19)
        Me.rbVaron.Name = "rbVaron"
        Me.rbVaron.Size = New System.Drawing.Size(53, 17)
        Me.rbVaron.TabIndex = 17
        Me.rbVaron.TabStop = True
        Me.rbVaron.Text = "Varon"
        Me.rbVaron.UseVisualStyleBackColor = True
        '
        'rbMujer
        '
        Me.rbMujer.AutoSize = True
        Me.rbMujer.BackgroundImage = Global.practico_3.My.Resources.Resources.mujerb
        Me.rbMujer.Location = New System.Drawing.Point(88, 19)
        Me.rbMujer.Name = "rbMujer"
        Me.rbMujer.Size = New System.Drawing.Size(51, 17)
        Me.rbMujer.TabIndex = 18
        Me.rbMujer.TabStop = True
        Me.rbMujer.Text = "Mujer"
        Me.rbMujer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.practico_3.My.Resources.Resources.exit_ico
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(370, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 47)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = " Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(330, 76)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(160, 134)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic1.TabIndex = 16
        Me.pic1.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = Global.practico_3.My.Resources.Resources.delete_ico
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(150, 382)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(84, 47)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.practico_3.My.Resources.Resources.Save_ico
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_guardar.Location = New System.Drawing.Point(29, 382)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(88, 47)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.lTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lTitulo.Location = New System.Drawing.Point(173, 29)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(202, 26)
        Me.lTitulo.TabIndex = 21
        Me.lTitulo.Text = "NUEVO CLIENTE"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 450)
        Me.Controls.Add(Me.lTitulo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ChMasterCard)
        Me.Controls.Add(Me.ChVisa)
        Me.Controls.Add(Me.ChNaranja)
        Me.Controls.Add(Me.lTdC)
        Me.Controls.Add(Me.lNyA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPF"
        Me.Text = "Pequeño Formulario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lNyA As Label
    Friend WithEvents lTdC As Label
    Friend WithEvents ChNaranja As CheckBox
    Friend WithEvents ChVisa As CheckBox
    Friend WithEvents ChMasterCard As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents rbVaron As RadioButton
    Friend WithEvents rbMujer As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lTitulo As Label
End Class
