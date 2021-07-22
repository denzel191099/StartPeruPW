<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chofer
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
        Me.txtcodigochofer.Location = New System.Drawing.Point(141, 49)
        Me.txtcodigochofer.MaxLength = 9
        Me.txtcodigochofer.Name = "txtcodigochofer"
        Me.txtcodigochofer.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigochofer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'dgchofer
        '
        Me.dgchofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgchofer.Location = New System.Drawing.Point(310, 49)
        Me.dgchofer.Name = "dgchofer"
        Me.dgchofer.ReadOnly = True
        Me.dgchofer.Size = New System.Drawing.Size(380, 209)
        Me.dgchofer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'txtnomchofer
        '
        Me.txtnomchofer.Location = New System.Drawing.Point(141, 99)
        Me.txtnomchofer.MaxLength = 25
        Me.txtnomchofer.Name = "txtnomchofer"
        Me.txtnomchofer.Size = New System.Drawing.Size(100, 20)
        Me.txtnomchofer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido Paterno"
        '
        'txtappchofer
        '
        Me.txtappchofer.Location = New System.Drawing.Point(141, 142)
        Me.txtappchofer.MaxLength = 25
        Me.txtappchofer.Name = "txtappchofer"
        Me.txtappchofer.Size = New System.Drawing.Size(100, 20)
        Me.txtappchofer.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido Materno"
        '
        'txtapmchofer
        '
        Me.txtapmchofer.Location = New System.Drawing.Point(141, 192)
        Me.txtapmchofer.MaxLength = 25
        Me.txtapmchofer.Name = "txtapmchofer"
        Me.txtapmchofer.Size = New System.Drawing.Size(100, 20)
        Me.txtapmchofer.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Licencia"
        '
        'cblicencia
        '
        Me.cblicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblicencia.FormattingEnabled = True
        Me.cblicencia.Items.AddRange(New Object() {"A-IIIa", "A-IIIb"})
        Me.cblicencia.Location = New System.Drawing.Point(141, 245)
        Me.cblicencia.Name = "cblicencia"
        Me.cblicencia.Size = New System.Drawing.Size(100, 21)
        Me.cblicencia.TabIndex = 10
        '
        'btregistrar
        '
        Me.btregistrar.Location = New System.Drawing.Point(44, 317)
        Me.btregistrar.Name = "btregistrar"
        Me.btregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btregistrar.TabIndex = 11
        Me.btregistrar.Text = "Registrar "
        Me.btregistrar.UseVisualStyleBackColor = True
        '
        'btmodificar
        '
        Me.btmodificar.Location = New System.Drawing.Point(150, 317)
        Me.btmodificar.Name = "btmodificar"
        Me.btmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btmodificar.TabIndex = 12
        Me.btmodificar.Text = "Modificar"
        Me.btmodificar.UseVisualStyleBackColor = True
        '
        'bteliminar
        '
        Me.bteliminar.Location = New System.Drawing.Point(258, 317)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(75, 23)
        Me.bteliminar.TabIndex = 13
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = True
        '
        'chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 385)
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
