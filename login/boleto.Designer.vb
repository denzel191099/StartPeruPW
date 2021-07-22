<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class boleto
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
        Me.cbcodigo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpartida = New System.Windows.Forms.TextBox()
        Me.txtllegada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgboleto = New System.Windows.Forms.DataGridView()
        Me.dpboleto = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LB1 = New System.Windows.Forms.Label()
        Me.LB2 = New System.Windows.Forms.Label()
        Me.LB3 = New System.Windows.Forms.Label()
        Me.LB4 = New System.Windows.Forms.Label()
        Me.LB5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.cbasiento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.lbl10 = New System.Windows.Forms.Label()
        CType(Me.dgboleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbcodigo
        '
        Me.cbcodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcodigo.FormattingEnabled = True
        Me.cbcodigo.Location = New System.Drawing.Point(64, 37)
        Me.cbcodigo.Name = "cbcodigo"
        Me.cbcodigo.Size = New System.Drawing.Size(99, 21)
        Me.cbcodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo de viaje:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Partida"
        '
        'txtpartida
        '
        Me.txtpartida.Location = New System.Drawing.Point(247, 38)
        Me.txtpartida.MaxLength = 15
        Me.txtpartida.Name = "txtpartida"
        Me.txtpartida.Size = New System.Drawing.Size(100, 20)
        Me.txtpartida.TabIndex = 3
        '
        'txtllegada
        '
        Me.txtllegada.Location = New System.Drawing.Point(422, 38)
        Me.txtllegada.MaxLength = 15
        Me.txtllegada.Name = "txtllegada"
        Me.txtllegada.Size = New System.Drawing.Size(100, 20)
        Me.txtllegada.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Llegada"
        '
        'dgboleto
        '
        Me.dgboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgboleto.Location = New System.Drawing.Point(40, 304)
        Me.dgboleto.Name = "dgboleto"
        Me.dgboleto.Size = New System.Drawing.Size(667, 99)
        Me.dgboleto.TabIndex = 6
        '
        'dpboleto
        '
        Me.dpboleto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dpboleto.CustomFormat = "yyyy-MM-dd    hh:mm:ss"
        Me.dpboleto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpboleto.Location = New System.Drawing.Point(595, 14)
        Me.dpboleto.Name = "dpboleto"
        Me.dpboleto.Size = New System.Drawing.Size(133, 20)
        Me.dpboleto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Salida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Llegada:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(244, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Hora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(435, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Costo:"
        '
        'LB1
        '
        Me.LB1.AutoSize = True
        Me.LB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB1.Location = New System.Drawing.Point(118, 121)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(0, 24)
        Me.LB1.TabIndex = 13
        '
        'LB2
        '
        Me.LB2.AutoSize = True
        Me.LB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB2.Location = New System.Drawing.Point(141, 203)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(0, 24)
        Me.LB2.TabIndex = 14
        '
        'LB3
        '
        Me.LB3.AutoSize = True
        Me.LB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB3.Location = New System.Drawing.Point(327, 123)
        Me.LB3.Name = "LB3"
        Me.LB3.Size = New System.Drawing.Size(0, 24)
        Me.LB3.TabIndex = 15
        '
        'LB4
        '
        Me.LB4.AutoSize = True
        Me.LB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB4.Location = New System.Drawing.Point(327, 203)
        Me.LB4.Name = "LB4"
        Me.LB4.Size = New System.Drawing.Size(0, 24)
        Me.LB4.TabIndex = 16
        '
        'LB5
        '
        Me.LB5.AutoSize = True
        Me.LB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB5.Location = New System.Drawing.Point(538, 170)
        Me.LB5.Name = "LB5"
        Me.LB5.Size = New System.Drawing.Size(0, 24)
        Me.LB5.TabIndex = 17
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(504, 170)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(0, 24)
        Me.lbl6.TabIndex = 18
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(642, 156)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(36, 25)
        Me.btn3.TabIndex = 20
        Me.btn3.Text = "A3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(642, 188)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(36, 25)
        Me.btn4.TabIndex = 21
        Me.btn4.Text = "A4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Location = New System.Drawing.Point(213, 275)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnconfirmar.TabIndex = 23
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncerrar.Location = New System.Drawing.Point(340, 275)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 24
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(642, 125)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(36, 25)
        Me.btn2.TabIndex = 25
        Me.btn2.Text = "A2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(642, 94)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(36, 25)
        Me.btn1.TabIndex = 26
        Me.btn1.Text = "A1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(699, 94)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(36, 25)
        Me.btn6.TabIndex = 31
        Me.btn6.Text = "A6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(699, 125)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(36, 25)
        Me.btn7.TabIndex = 30
        Me.btn7.Text = "A7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(699, 219)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(36, 25)
        Me.btn10.TabIndex = 29
        Me.btn10.Text = "A10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(699, 188)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(36, 25)
        Me.btn9.TabIndex = 28
        Me.btn9.Text = "A9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(699, 156)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(36, 25)
        Me.btn8.TabIndex = 27
        Me.btn8.Text = "A8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'cbasiento
        '
        Me.cbasiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbasiento.FormattingEnabled = True
        Me.cbasiento.Location = New System.Drawing.Point(665, 57)
        Me.cbasiento.Name = "cbasiento"
        Me.cbasiento.Size = New System.Drawing.Size(42, 21)
        Me.cbasiento.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(573, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Asiento:"
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(642, 219)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(36, 25)
        Me.btn5.TabIndex = 22
        Me.btn5.Text = "A5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(576, 176)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(0, 18)
        Me.lbl10.TabIndex = 34
        '
        'boleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbasiento)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.LB5)
        Me.Controls.Add(Me.LB4)
        Me.Controls.Add(Me.LB3)
        Me.Controls.Add(Me.LB2)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dpboleto)
        Me.Controls.Add(Me.dgboleto)
        Me.Controls.Add(Me.txtllegada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpartida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbcodigo)
        Me.Name = "boleto"
        Me.Text = "boleto"
        CType(Me.dgboleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbcodigo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpartida As TextBox
    Friend WithEvents txtllegada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgboleto As DataGridView
    Friend WithEvents dpboleto As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LB1 As Label
    Friend WithEvents LB2 As Label
    Friend WithEvents LB3 As Label
    Friend WithEvents LB4 As Label
    Friend WithEvents LB5 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnconfirmar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents cbasiento As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn5 As Button
    Friend WithEvents lbl10 As Label
End Class
