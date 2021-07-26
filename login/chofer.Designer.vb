<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class chofer
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
        Me.txtcodigochofer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgchofer = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomchofer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtappchofer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapmchofer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cblicencia = New System.Windows.Forms.ComboBox()
        Me.btregistrar = New System.Windows.Forms.Button()
        Me.btmodificar = New System.Windows.Forms.Button()
        Me.bteliminar = New System.Windows.Forms.Button()
        CType(Me.dgchofer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodigochofer
        '
        Me.txtcodigochofer.Location = New System.Drawing.Point(141, 53)
        Me.txtcodigochofer.MaxLength = 9
        Me.txtcodigochofer.Name = "txtcodigochofer"
        Me.txtcodigochofer.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigochofer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'dgchofer
        '
        Me.dgchofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgchofer.Location = New System.Drawing.Point(308, 53)
        Me.dgchofer.Name = "dgchofer"
        Me.dgchofer.ReadOnly = True
        Me.dgchofer.Size = New System.Drawing.Size(566, 209)
        Me.dgchofer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'txtnomchofer
        '
        Me.txtnomchofer.Location = New System.Drawing.Point(141, 98)
        Me.txtnomchofer.MaxLength = 25
        Me.txtnomchofer.Name = "txtnomchofer"
        Me.txtnomchofer.Size = New System.Drawing.Size(100, 20)
        Me.txtnomchofer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido Paterno:"
        '
        'txtappchofer
        '
        Me.txtappchofer.Location = New System.Drawing.Point(141, 146)
        Me.txtappchofer.MaxLength = 25
        Me.txtappchofer.Name = "txtappchofer"
        Me.txtappchofer.Size = New System.Drawing.Size(100, 20)
        Me.txtappchofer.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido Materno:"
        '
        'txtapmchofer
        '
        Me.txtapmchofer.Location = New System.Drawing.Point(141, 194)
        Me.txtapmchofer.MaxLength = 25
        Me.txtapmchofer.Name = "txtapmchofer"
        Me.txtapmchofer.Size = New System.Drawing.Size(100, 20)
        Me.txtapmchofer.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Licencia:"
        '
        'cblicencia
        '
        Me.cblicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblicencia.FormattingEnabled = True
        Me.cblicencia.Items.AddRange(New Object() {"A-IIIa", "A-IIIb"})
        Me.cblicencia.Location = New System.Drawing.Point(141, 241)
        Me.cblicencia.Name = "cblicencia"
        Me.cblicencia.Size = New System.Drawing.Size(100, 21)
        Me.cblicencia.TabIndex = 10
        '
        'btregistrar
        '
        Me.btregistrar.BackColor = System.Drawing.Color.Crimson
        Me.btregistrar.FlatAppearance.BorderSize = 0
        Me.btregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btregistrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btregistrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btregistrar.Location = New System.Drawing.Point(128, 307)
        Me.btregistrar.Name = "btregistrar"
        Me.btregistrar.Size = New System.Drawing.Size(108, 45)
        Me.btregistrar.TabIndex = 11
        Me.btregistrar.Text = "Registrar "
        Me.btregistrar.UseVisualStyleBackColor = False
        '
        'btmodificar
        '
        Me.btmodificar.BackColor = System.Drawing.Color.Crimson
        Me.btmodificar.FlatAppearance.BorderSize = 0
        Me.btmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmodificar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmodificar.ForeColor = System.Drawing.SystemColors.Window
        Me.btmodificar.Location = New System.Drawing.Point(308, 307)
        Me.btmodificar.Name = "btmodificar"
        Me.btmodificar.Size = New System.Drawing.Size(108, 45)
        Me.btmodificar.TabIndex = 12
        Me.btmodificar.Text = "Modificar"
        Me.btmodificar.UseVisualStyleBackColor = False
        '
        'bteliminar
        '
        Me.bteliminar.BackColor = System.Drawing.Color.Crimson
        Me.bteliminar.FlatAppearance.BorderSize = 0
        Me.bteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bteliminar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.bteliminar.Location = New System.Drawing.Point(492, 307)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(108, 45)
        Me.bteliminar.TabIndex = 13
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = False
        '
        'chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(886, 407)
        Me.Controls.Add(Me.bteliminar)
        Me.Controls.Add(Me.btmodificar)
        Me.Controls.Add(Me.btregistrar)
        Me.Controls.Add(Me.cblicencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapmchofer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtappchofer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnomchofer)
        Me.Controls.Add(Me.dgchofer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcodigochofer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "chofer"
        Me.Text = "chofer"
        CType(Me.dgchofer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcodigochofer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgchofer As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnomchofer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtappchofer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtapmchofer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cblicencia As ComboBox
    Friend WithEvents btregistrar As Button
    Friend WithEvents btmodificar As Button
    Friend WithEvents bteliminar As Button
End Class
