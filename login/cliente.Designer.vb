<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cliente))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapmcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtappcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdnicliente = New System.Windows.Forms.TextBox()
        Me.dgcliente = New System.Windows.Forms.DataGridView()
        Me.txtcel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcorreocliente = New System.Windows.Forms.TextBox()
        Me.btninsertarcliente = New System.Windows.Forms.Button()
        Me.btnclientemodificar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodigocliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(101, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Apellido Materno"
        '
        'txtapmcliente
        '
        Me.txtapmcliente.Location = New System.Drawing.Point(225, 277)
        Me.txtapmcliente.MaxLength = 25
        Me.txtapmcliente.Name = "txtapmcliente"
        Me.txtapmcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtapmcliente.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(101, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido Paterno"
        '
        'txtappcliente
        '
        Me.txtappcliente.Location = New System.Drawing.Point(225, 227)
        Me.txtappcliente.MaxLength = 25
        Me.txtappcliente.Name = "txtappcliente"
        Me.txtappcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtappcliente.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(101, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'txtnomcliente
        '
        Me.txtnomcliente.Location = New System.Drawing.Point(225, 184)
        Me.txtnomcliente.MaxLength = 25
        Me.txtnomcliente.Name = "txtnomcliente"
        Me.txtnomcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtnomcliente.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(101, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DNI:"
        '
        'txtdnicliente
        '
        Me.txtdnicliente.Location = New System.Drawing.Point(225, 143)
        Me.txtdnicliente.MaxLength = 9
        Me.txtdnicliente.Name = "txtdnicliente"
        Me.txtdnicliente.Size = New System.Drawing.Size(100, 20)
        Me.txtdnicliente.TabIndex = 9
        '
        'dgcliente
        '
        Me.dgcliente.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.dgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcliente.Location = New System.Drawing.Point(390, 75)
        Me.dgcliente.Name = "dgcliente"
        Me.dgcliente.ReadOnly = True
        Me.dgcliente.Size = New System.Drawing.Size(654, 423)
        Me.dgcliente.TabIndex = 17
        '
        'txtcel
        '
        Me.txtcel.Location = New System.Drawing.Point(225, 323)
        Me.txtcel.Name = "txtcel"
        Me.txtcel.Size = New System.Drawing.Size(100, 20)
        Me.txtcel.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(104, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(104, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Correo:"
        '
        'txtcorreocliente
        '
        Me.txtcorreocliente.Location = New System.Drawing.Point(225, 372)
        Me.txtcorreocliente.Name = "txtcorreocliente"
        Me.txtcorreocliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcorreocliente.TabIndex = 20
        '
        'btninsertarcliente
        '
        Me.btninsertarcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btninsertarcliente.FlatAppearance.BorderSize = 0
        Me.btninsertarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsertarcliente.Image = CType(resources.GetObject("btninsertarcliente.Image"), System.Drawing.Image)
        Me.btninsertarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertarcliente.Location = New System.Drawing.Point(845, 504)
        Me.btninsertarcliente.Name = "btninsertarcliente"
        Me.btninsertarcliente.Size = New System.Drawing.Size(97, 40)
        Me.btninsertarcliente.TabIndex = 22
        Me.btninsertarcliente.Text = "Insertar  "
        Me.btninsertarcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btninsertarcliente.UseVisualStyleBackColor = False
        '
        'btnclientemodificar
        '
        Me.btnclientemodificar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnclientemodificar.FlatAppearance.BorderSize = 0
        Me.btnclientemodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientemodificar.Image = CType(resources.GetObject("btnclientemodificar.Image"), System.Drawing.Image)
        Me.btnclientemodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientemodificar.Location = New System.Drawing.Point(948, 504)
        Me.btnclientemodificar.Name = "btnclientemodificar"
        Me.btnclientemodificar.Size = New System.Drawing.Size(96, 40)
        Me.btnclientemodificar.TabIndex = 23
        Me.btnclientemodificar.Text = "Modificar  "
        Me.btnclientemodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclientemodificar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(101, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Codigo:"
        '
        'txtcodigocliente
        '
        Me.txtcodigocliente.Location = New System.Drawing.Point(225, 98)
        Me.txtcodigocliente.MaxLength = 9
        Me.txtcodigocliente.Name = "txtcodigocliente"
        Me.txtcodigocliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigocliente.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 19)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label8.Location = New System.Drawing.Point(26, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cliente"
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1082, 632)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcodigocliente)
        Me.Controls.Add(Me.btnclientemodificar)
        Me.Controls.Add(Me.btninsertarcliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcorreocliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcel)
        Me.Controls.Add(Me.dgcliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapmcliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtappcliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnomcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdnicliente)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cliente"
        Me.Text = "cliente"
        CType(Me.dgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtapmcliente As TextBox
    Friend WithEvents txtappcliente As TextBox
    Friend WithEvents txtnomcliente As TextBox
    Friend WithEvents txtdnicliente As TextBox
    Friend WithEvents dgcliente As DataGridView
    Friend WithEvents txtcel As TextBox
    Friend WithEvents txtcorreocliente As TextBox
    Friend WithEvents btninsertarcliente As Button
    Friend WithEvents btnclientemodificar As Button
    Friend WithEvents txtcodigocliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Label4 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label7 As Label
End Class
