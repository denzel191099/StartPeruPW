<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgviaje = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoviaje = New System.Windows.Forms.TextBox()
        Me.cbsalida = New System.Windows.Forms.ComboBox()
        Me.cbllegada = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbhora = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.cbauto = New System.Windows.Forms.ComboBox()
        Me.cbchofer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btregistrar = New System.Windows.Forms.Button()
        Me.btmodificar = New System.Windows.Forms.Button()
        Me.bteliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgviaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgviaje
        '
        Me.dgviaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviaje.Location = New System.Drawing.Point(310, 46)
        Me.dgviaje.Name = "dgviaje"
        Me.dgviaje.ReadOnly = True
        Me.dgviaje.Size = New System.Drawing.Size(386, 308)
        Me.dgviaje.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lugar de Salida:"
        '
        'txtcodigoviaje
        '
        Me.txtcodigoviaje.Location = New System.Drawing.Point(151, 46)
        Me.txtcodigoviaje.MaxLength = 9
        Me.txtcodigoviaje.Name = "txtcodigoviaje"
        Me.txtcodigoviaje.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigoviaje.TabIndex = 3
        '
        'cbsalida
        '
        Me.cbsalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsalida.FormattingEnabled = True
        Me.cbsalida.Items.AddRange(New Object() {"Lima"})
        Me.cbsalida.Location = New System.Drawing.Point(151, 78)
        Me.cbsalida.Name = "cbsalida"
        Me.cbsalida.Size = New System.Drawing.Size(100, 21)
        Me.cbsalida.TabIndex = 4
        '
        'cbllegada
        '
        Me.cbllegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbllegada.FormattingEnabled = True
        Me.cbllegada.Items.AddRange(New Object() {"Ica", "Piura", "Pisco"})
        Me.cbllegada.Location = New System.Drawing.Point(151, 122)
        Me.cbllegada.Name = "cbllegada"
        Me.cbllegada.Size = New System.Drawing.Size(100, 21)
        Me.cbllegada.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lugar de Llegada:"
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "yyyy-MM-dd"
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(151, 174)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(100, 20)
        Me.dtpdate.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha:"
        '
        'cbhora
        '
        Me.cbhora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbhora.FormattingEnabled = True
        Me.cbhora.Items.AddRange(New Object() {"13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00", "20:00:00", "21:00:00", "22:00:00", "23:00:00", "24:00:00"})
        Me.cbhora.Location = New System.Drawing.Point(151, 217)
        Me.cbhora.Name = "cbhora"
        Me.cbhora.Size = New System.Drawing.Size(100, 21)
        Me.cbhora.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hora:"
        '
        'txtcosto
        '
        Me.txtcosto.Location = New System.Drawing.Point(151, 264)
        Me.txtcosto.MaxLength = 4
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(100, 20)
        Me.txtcosto.TabIndex = 11
        '
        'cbauto
        '
        Me.cbauto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbauto.FormattingEnabled = True
        Me.cbauto.Items.AddRange(New Object() {"13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00", "20:00:00", "21:00:00", "22:00:00", "23:00:00", "24:00:00"})
        Me.cbauto.Location = New System.Drawing.Point(151, 316)
        Me.cbauto.Name = "cbauto"
        Me.cbauto.Size = New System.Drawing.Size(100, 21)
        Me.cbauto.TabIndex = 12
        '
        'cbchofer
        '
        Me.cbchofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbchofer.FormattingEnabled = True
        Me.cbchofer.Items.AddRange(New Object() {"13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00", "20:00:00", "21:00:00", "22:00:00", "23:00:00", "24:00:00"})
        Me.cbchofer.Location = New System.Drawing.Point(151, 363)
        Me.cbchofer.Name = "cbchofer"
        Me.cbchofer.Size = New System.Drawing.Size(100, 21)
        Me.cbchofer.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Costo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Codigo Autobus:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Codigo Chofer:"
        '
        'btregistrar
        '
        Me.btregistrar.FlatAppearance.BorderSize = 0
        Me.btregistrar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btregistrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btregistrar.Location = New System.Drawing.Point(190, 421)
        Me.btregistrar.Name = "btregistrar"
        Me.btregistrar.Size = New System.Drawing.Size(96, 36)
        Me.btregistrar.TabIndex = 17
        Me.btregistrar.Text = "Registrar"
        Me.btregistrar.UseVisualStyleBackColor = True
        '
        'btmodificar
        '
        Me.btmodificar.FlatAppearance.BorderSize = 0
        Me.btmodificar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmodificar.ForeColor = System.Drawing.SystemColors.Window
        Me.btmodificar.Location = New System.Drawing.Point(312, 421)
        Me.btmodificar.Name = "btmodificar"
        Me.btmodificar.Size = New System.Drawing.Size(96, 36)
        Me.btmodificar.TabIndex = 18
        Me.btmodificar.Text = "Modificar"
        Me.btmodificar.UseVisualStyleBackColor = True
        '
        'bteliminar
        '
        Me.bteliminar.FlatAppearance.BorderSize = 0
        Me.bteliminar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.bteliminar.Location = New System.Drawing.Point(435, 421)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(96, 36)
        Me.bteliminar.TabIndex = 19
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 33)
        Me.Panel1.TabIndex = 20
        '
        'Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(723, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bteliminar)
        Me.Controls.Add(Me.btmodificar)
        Me.Controls.Add(Me.btregistrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbchofer)
        Me.Controls.Add(Me.cbauto)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbhora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbllegada)
        Me.Controls.Add(Me.cbsalida)
        Me.Controls.Add(Me.txtcodigoviaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgviaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Viaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viaje"
        CType(Me.dgviaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgviaje As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigoviaje As TextBox
    Friend WithEvents cbsalida As ComboBox
    Friend WithEvents cbllegada As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbhora As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcosto As TextBox
    Friend WithEvents cbauto As ComboBox
    Friend WithEvents cbchofer As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btregistrar As Button
    Friend WithEvents btmodificar As Button
    Friend WithEvents bteliminar As Button
    Friend WithEvents Panel1 As Panel
End Class
