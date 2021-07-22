Imports System.Runtime.InteropServices
Public Class principal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panelcabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelcabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()


    End Sub

    Private Sub timerocultaremenu_Tick(sender As Object, e As EventArgs) Handles timerocultaremenu.Tick
        If Panelmenu.Width <= 60 Then
            Me.timerocultaremenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width - 20
        End If
    End Sub

    Private Sub timemostrarmenu_Tick(sender As Object, e As EventArgs) Handles timemostrarmenu.Tick
        If Panelmenu.Width >= 220 Then
            Me.timemostrarmenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width + 20
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panelmenu.Width = 220 Then
            timerocultaremenu.Enabled = True
        ElseIf Panelmenu.Width = 60 Then
            timemostrarmenu.Enabled = True
        End If
    End Sub

    Private Sub abrirpanelform(ByVal formhijo As Object)
        If Me.Panelcontenedor.Controls.Count > 0 Then
            Me.Panelcontenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formhijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Me.Panelcontenedor.Controls.Add(fh)
            Me.Panelcontenedor.Tag = fh
            fh.Show()

    End Sub

    Private Sub btnchofer_Click(sender As Object, e As EventArgs) Handles btnchofer.Click
        abrirpanelform(New chofer)
    End Sub

    Private Sub BtnHorario_Click(sender As Object, e As EventArgs) Handles BtnHorario.Click
        abrirpanelform(New Viaje)
    End Sub

    Public Sub btnboleto_Click(sender As Object, e As EventArgs) Handles btnboleto.Click
        abrirpanelform(New boleto)


    End Sub

    Private Sub btngestioncliente_Click(sender As Object, e As EventArgs) Handles btngestioncliente.Click
        abrirpanelform(New cliente)
    End Sub

    Private Sub Panelcabecera_Paint(sender As Object, e As PaintEventArgs) Handles Panelcabecera.Paint

    End Sub
End Class