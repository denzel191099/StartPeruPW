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
        CType(Me.dgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Apellido Materno"
        '
        'txtapmcliente
        '
        Me.txtapmcliente.Location = New System.Drawing.Point(159, 197)
        Me.txtapmcliente.MaxLength = 25
        Me.txtapmcliente.Name = "txtapmcliente"
        Me.txtapmcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtapmcliente.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido Paterno"
        '
        'txtappcliente
        '
        Me.txtappcliente.Location = New System.Drawing.Point(159, 147)
        Me.txtappcliente.MaxLength = 25
        Me.txtappcliente.Name = "txtappcliente"
        Me.txtappcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtappcliente.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'txtnomcliente
        '
        Me.txtnomcliente.Location = New System.Drawing.Point(159, 104)
        Me.txtnomcliente.MaxLength = 25
        Me.txtnomcliente.Name = "txtnomcliente"
        Me.txtnomcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtnomcliente.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DNI:"
        '
        'txtdnicliente
        '
        Me.txtdnicliente.Location = New System.Drawing.Point(159, 63)
        Me.txtdnicliente.MaxLength = 9
        Me.txtdnicliente.Name = "txtdnicliente"
        Me.txtdnicliente.Size = New System.Drawing.Size(100, 20)
        Me.txtdnicliente.TabIndex = 9
        '
        'dgcliente
        '
        Me.dgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcliente.Location = New System.Drawing.Point(331, 53)
        Me.dgcliente.Name = "dgcliente"
        Me.dgcliente.ReadOnly = True
        Me.dgcliente.Size = New System.Drawing.Size(380, 209)
        Me.dgcliente.TabIndex = 17
        '
        'txtcel
        '
        Me.txtcel.Location = New System.Drawing.Point(159, 243)
        Me.txtcel.Name = "txtcel"
        Me.txtcel.Size = New System.Drawing.Size(100, 20)
        Me.txtcel.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Correo:"
        '
        'txtcorreocliente
        '
        Me.txtcorreocliente.Location = New System.Drawing.Point(159, 292)
        Me.txtcorreocliente.Name = "txtcorreocliente"
        Me.txtcorreocliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcorreocliente.TabIndex = 20
        '
        'btninsertarcliente
        '
        Me.btninsertarcliente.Location = New System.Drawing.Point(104, 347)
        Me.btninsertarcliente.Name = "btninsertarcliente"
        Me.btninsertarcliente.Size = New System.Drawing.Size(75, 23)
        Me.btninsertarcliente.TabIndex = 22
        Me.btninsertarcliente.Text = "Insertar"
        Me.btninsertarcliente.UseVisualStyleBackColor = True
        '
        'btnclientemodificar
        '
        Me.btnclientemodificar.Location = New System.Drawing.Point(219, 347)
        Me.btnclientemodificar.Name = "btnclientemodificar"
        Me.btnclientemodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnclientemodificar.TabIndex = 23
        Me.btnclientemodificar.Text = "Modificar"
        Me.btnclientemodificar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Codigo:"
        '
        'txtcodigocliente
        '
        Me.txtcodigocliente.Location = New System.Drawing.Point(159, 18)
        Me.txtcodigocliente.MaxLength = 9
        Me.txtcodigocliente.Name = "txtcodigocliente"
        Me.txtcodigocliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigocliente.TabIndex = 24
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(759, 427)
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
        Me.Name = "cliente"
        Me.Text = "cliente"
        CType(Me.dgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtapmcliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtappcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnomcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdnicliente As TextBox
    Friend WithEvents dgcliente As DataGridView
    Friend WithEvents txtcel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcorreocliente As TextBox
    Friend WithEvents btninsertarcliente As Button
    Friend WithEvents btnclientemodificar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcodigocliente As TextBox
End Class
