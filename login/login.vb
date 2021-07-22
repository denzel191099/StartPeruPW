Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class login
    Public codigologin As String
    Public enunciado = "a"
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection

        cn.ConnectionString = conexion
        Dim Cmdbusq As New SqlCommand()

        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "logins"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@usuario", SqlDbType.VarChar, 30)
        Dim contra As New SqlParameter("@contraseña", SqlDbType.VarChar, 30)
        Id.Value = txtusuario.Text
        contra.Value = txtcontra.Text
        Cmdbusq.Parameters.Add(Id)
        Cmdbusq.Parameters.Add(contra)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()
        Try


            enunciado = dr(2)
        Catch ex As Exception
            dr.Close()
            cn.Close()

        End Try

        Try
            If enunciado.Contains("admin") Then

                principal.Show()

                enunciado = "a"
                Me.Hide()


            ElseIf enunciado <> "a" Then
                boleto.Show()
                enunciado = "a"
                Me.Hide()



            ElseIf enunciado = "a" Then
                MsgBox("usuario incorrecto")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btncerrar2_Click(sender As Object, e As EventArgs) Handles btncerrar2.Click
        Close()

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class