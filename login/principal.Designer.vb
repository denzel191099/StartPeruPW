<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.Panelcabecera = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.btngestioncliente = New System.Windows.Forms.Button()
        Me.btnboleto = New System.Windows.Forms.Button()
        Me.BtnHorario = New System.Windows.Forms.Button()
        Me.btnchofer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timerocultaremenu = New System.Windows.Forms.Timer(Me.components)
        Me.timemostrarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panelcontenedor = New System.Windows.Forms.Panel()
        Me.Panelcabecera.SuspendLayout()
        Me.Panelmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelcabecera
        '
        Me.Panelcabecera.BackColor = System.Drawing.Color.Crimson
        Me.Panelcabecera.Controls.Add(Me.Button1)
        Me.Panelcabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panelcabecera.Name = "Panelcabecera"
        Me.Panelcabecera.Size = New System.Drawing.Size(838, 40)
        Me.Panelcabecera.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(798, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.LightCoral
        Me.Panelmenu.Controls.Add(Me.btngestioncliente)
        Me.Panelmenu.Controls.Add(Me.btnchofer)
        Me.Panelmenu.Controls.Add(Me.btnboleto)
        Me.Panelmenu.Controls.Add(Me.BtnHorario)
        Me.Panelmenu.Controls.Add(Me.PictureBox1)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 40)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(220, 424)
        Me.Panelmenu.TabIndex = 1
        '
        'btngestioncliente
        '
        Me.btngestioncliente.BackColor = System.Drawing.Color.Crimson
        Me.btngestioncliente.FlatAppearance.BorderSize = 0
        Me.btngestioncliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btngestioncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngestioncliente.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngestioncliente.ForeColor = System.Drawing.SystemColors.Window
        Me.btngestioncliente.Image = Global.login.My.Resources.Resources.chofer3
        Me.btngestioncliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngestioncliente.Location = New System.Drawing.Point(12, 315)
        Me.btngestioncliente.Name = "btngestioncliente"
        Me.btngestioncliente.Size = New System.Drawing.Size(190, 60)
        Me.btngestioncliente.TabIndex = 5
        Me.btngestioncliente.Text = "Clientes"
        Me.btngestioncliente.UseVisualStyleBackColor = False
        '
        'btnboleto
        '
        Me.btnboleto.BackColor = System.Drawing.Color.Crimson
        Me.btnboleto.Enabled = False
        Me.btnboleto.FlatAppearance.BorderSize = 0
        Me.btnboleto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnboleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnboleto.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnboleto.ForeColor = System.Drawing.SystemColors.Window
        Me.btnboleto.Image = Global.login.My.Resources.Resources.chofer3
        Me.btnboleto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnboleto.Location = New System.Drawing.Point(12, 235)
        Me.btnboleto.Name = "btnboleto"
        Me.btnboleto.Size = New System.Drawing.Size(190, 60)
        Me.btnboleto.TabIndex = 4
        Me.btnboleto.Text = "Pasajes"
        Me.btnboleto.UseVisualStyleBackColor = False
        '
        'BtnHorario
        '
        Me.BtnHorario.BackColor = System.Drawing.Color.Crimson
        Me.BtnHorario.FlatAppearance.BorderSize = 0
        Me.BtnHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.BtnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHorario.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHorario.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnHorario.Image = Global.login.My.Resources.Resources.chofer3
        Me.BtnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHorario.Location = New System.Drawing.Point(12, 154)
        Me.BtnHorario.Name = "BtnHorario"
        Me.BtnHorario.Size = New System.Drawing.Size(190, 60)
        Me.BtnHorario.TabIndex = 3
        Me.BtnHorario.Text = "Viajes "
        Me.BtnHorario.UseVisualStyleBackColor = False
        '
        'btnchofer
        '
        Me.btnchofer.BackColor = System.Drawing.Color.Crimson
        Me.btnchofer.FlatAppearance.BorderSize = 0
        Me.btnchofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnchofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchofer.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchofer.ForeColor = System.Drawing.SystemColors.Window
        Me.btnchofer.Image = Global.login.My.Resources.Resources.chofer3
        Me.btnchofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnchofer.Location = New System.Drawing.Point(12, 73)
        Me.btnchofer.Name = "btnchofer"
        Me.btnchofer.Size = New System.Drawing.Size(190, 60)
        Me.btnchofer.TabIndex = 1
        Me.btnchofer.Text = "Pilotos"
        Me.btnchofer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.login.My.Resources.Resources.Mobile_Menu_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(179, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'timerocultaremenu
        '
        '
        'timemostrarmenu
        '
        '
        'Panelcontenedor
        '
        Me.Panelcontenedor.BackgroundImage = CType(resources.GetObject("Panelcontenedor.BackgroundImage"), System.Drawing.Image)
        Me.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcontenedor.Location = New System.Drawing.Point(220, 40)
        Me.Panelcontenedor.Name = "Panelcontenedor"
        Me.Panelcontenedor.Size = New System.Drawing.Size(618, 424)
        Me.Panelcontenedor.TabIndex = 2
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 464)
        Me.Controls.Add(Me.Panelcontenedor)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.Panelcabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "principal"
        Me.Text = "principal"
        Me.Panelcabecera.ResumeLayout(False)
        Me.Panelmenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelcabecera As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timerocultaremenu As Timer
    Friend WithEvents timemostrarmenu As Timer
    Friend WithEvents btnchofer As Button
    Friend WithEvents BtnHorario As Button
    Friend WithEvents Panelcontenedor As Panel
    Friend WithEvents btngestioncliente As Button
    Friend WithEvents btnboleto As Button
End Class
