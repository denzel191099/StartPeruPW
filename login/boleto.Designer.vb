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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boleto))
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
        Me.Asientos = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncerrar_boleto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgboleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbcodigo
        '
        Me.cbcodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcodigo.FormattingEnabled = True
        Me.cbcodigo.Location = New System.Drawing.Point(204, 55)
        Me.cbcodigo.Name = "cbcodigo"
        Me.cbcodigo.Size = New System.Drawing.Size(99, 21)
        Me.cbcodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(78, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo de viaje:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(78, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Partida:"
        '
        'txtpartida
        '
        Me.txtpartida.Location = New System.Drawing.Point(204, 95)
        Me.txtpartida.MaxLength = 15
        Me.txtpartida.Name = "txtpartida"
        Me.txtpartida.Size = New System.Drawing.Size(100, 20)
        Me.txtpartida.TabIndex = 3
        '
        'txtllegada
        '
        Me.txtllegada.Location = New System.Drawing.Point(203, 130)
        Me.txtllegada.MaxLength = 15
        Me.txtllegada.Name = "txtllegada"
        Me.txtllegada.Size = New System.Drawing.Size(100, 20)
        Me.txtllegada.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(78, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Llegada:"
        '
        'dgboleto
        '
        Me.dgboleto.BackgroundColor = System.Drawing.Color.Cornsilk
        Me.dgboleto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgboleto.Location = New System.Drawing.Point(81, 391)
        Me.dgboleto.Name = "dgboleto"
        Me.dgboleto.Size = New System.Drawing.Size(695, 376)
        Me.dgboleto.TabIndex = 6
        '
        'dpboleto
        '
        Me.dpboleto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dpboleto.CalendarMonthBackground = System.Drawing.Color.White
        Me.dpboleto.CustomFormat = "yyyy-MM-dd    hh:mm:ss"
        Me.dpboleto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpboleto.Location = New System.Drawing.Point(607, 56)
        Me.dpboleto.Name = "dpboleto"
        Me.dpboleto.Size = New System.Drawing.Size(147, 20)
        Me.dpboleto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(101, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Salida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(101, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Llegada:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.Location = New System.Drawing.Point(101, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.Location = New System.Drawing.Point(101, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Hora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label8.Location = New System.Drawing.Point(495, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Costo:"
        '
        'LB1
        '
        Me.LB1.AutoSize = True
        Me.LB1.BackColor = System.Drawing.Color.Transparent
        Me.LB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB1.Location = New System.Drawing.Point(166, 213)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(0, 24)
        Me.LB1.TabIndex = 13
        '
        'LB2
        '
        Me.LB2.AutoSize = True
        Me.LB2.BackColor = System.Drawing.Color.Transparent
        Me.LB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB2.Location = New System.Drawing.Point(199, 280)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(0, 24)
        Me.LB2.TabIndex = 14
        '
        'LB3
        '
        Me.LB3.AutoSize = True
        Me.LB3.BackColor = System.Drawing.Color.Transparent
        Me.LB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB3.Location = New System.Drawing.Point(184, 248)
        Me.LB3.Name = "LB3"
        Me.LB3.Size = New System.Drawing.Size(0, 24)
        Me.LB3.TabIndex = 15
        '
        'LB4
        '
        Me.LB4.AutoSize = True
        Me.LB4.BackColor = System.Drawing.Color.Transparent
        Me.LB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB4.Location = New System.Drawing.Point(184, 319)
        Me.LB4.Name = "LB4"
        Me.LB4.Size = New System.Drawing.Size(0, 24)
        Me.LB4.TabIndex = 16
        '
        'LB5
        '
        Me.LB5.AutoSize = True
        Me.LB5.BackColor = System.Drawing.Color.Transparent
        Me.LB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB5.Location = New System.Drawing.Point(604, 273)
        Me.LB5.Name = "LB5"
        Me.LB5.Size = New System.Drawing.Size(0, 24)
        Me.LB5.TabIndex = 17
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(570, 273)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(0, 24)
        Me.lbl6.TabIndex = 18
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(898, 246)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(26, 24)
        Me.btn3.TabIndex = 20
        Me.btn3.Text = "A3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(897, 296)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(26, 24)
        Me.btn4.TabIndex = 21
        Me.btn4.Text = "A4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconfirmar.Location = New System.Drawing.Point(587, 773)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(96, 39)
        Me.btnconfirmar.TabIndex = 23
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnconfirmar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.Crimson
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrar.Location = New System.Drawing.Point(689, 773)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(87, 39)
        Me.btncerrar.TabIndex = 24
        Me.btncerrar.Text = "Cerrar "
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(897, 193)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(26, 24)
        Me.btn2.TabIndex = 25
        Me.btn2.Text = "A2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(898, 143)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(25, 25)
        Me.btn1.TabIndex = 26
        Me.btn1.Text = "A1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(947, 144)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(26, 24)
        Me.btn6.TabIndex = 31
        Me.btn6.Text = "A6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(947, 193)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(26, 24)
        Me.btn7.TabIndex = 30
        Me.btn7.Text = "A7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10.Location = New System.Drawing.Point(947, 345)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(26, 24)
        Me.btn10.TabIndex = 29
        Me.btn10.Text = "A10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(947, 296)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(26, 24)
        Me.btn9.TabIndex = 28
        Me.btn9.Text = "A9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(947, 246)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(26, 24)
        Me.btn8.TabIndex = 27
        Me.btn8.Text = "A8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'cbasiento
        '
        Me.cbasiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbasiento.FormattingEnabled = True
        Me.cbasiento.Location = New System.Drawing.Point(203, 361)
        Me.cbasiento.Name = "cbasiento"
        Me.cbasiento.Size = New System.Drawing.Size(95, 21)
        Me.cbasiento.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label9.Location = New System.Drawing.Point(101, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Asiento:"
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(898, 345)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(26, 24)
        Me.btn5.TabIndex = 22
        Me.btn5.Text = "A5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.BackColor = System.Drawing.Color.Transparent
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(642, 279)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(0, 18)
        Me.lbl10.TabIndex = 34
        '
        'Asientos
        '
        Me.Asientos.BackColor = System.Drawing.Color.Transparent
        Me.Asientos.BackgroundImage = CType(resources.GetObject("Asientos.BackgroundImage"), System.Drawing.Image)
        Me.Asientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Asientos.Enabled = False
        Me.Asientos.InitialImage = CType(resources.GetObject("Asientos.InitialImage"), System.Drawing.Image)
        Me.Asientos.Location = New System.Drawing.Point(818, 103)
        Me.Asientos.Name = "Asientos"
        Me.Asientos.Size = New System.Drawing.Size(330, 709)
        Me.Asientos.TabIndex = 35
        Me.Asientos.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btncerrar_boleto)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(-13, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 24)
        Me.Panel1.TabIndex = 36
        '
        'btncerrar_boleto
        '
        Me.btncerrar_boleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar_boleto.BackColor = System.Drawing.Color.Transparent
        Me.btncerrar_boleto.FlatAppearance.BorderSize = 0
        Me.btncerrar_boleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar_boleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar_boleto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncerrar_boleto.Location = New System.Drawing.Point(1173, 0)
        Me.btncerrar_boleto.Name = "btncerrar_boleto"
        Me.btncerrar_boleto.Size = New System.Drawing.Size(32, 24)
        Me.btncerrar_boleto.TabIndex = 8
        Me.btncerrar_boleto.Text = "X"
        Me.btncerrar_boleto.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(34, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Boleto"
        '
        'boleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1188, 844)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.Asientos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "boleto"
        Me.Text = "boleto"
        CType(Me.dgboleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label8 As Label
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
    Friend WithEvents Asientos As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncerrar_boleto As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label7 As Label
    Public WithEvents LB1 As Label
    Public WithEvents LB2 As Label
    Public WithEvents LB3 As Label
    Public WithEvents LB4 As Label
    Public WithEvents LB5 As Label
    Public WithEvents lbl6 As Label
    Public WithEvents lbl10 As Label
End Class
