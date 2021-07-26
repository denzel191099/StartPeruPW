Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class cliente
    Private dv As New DataView
    Dim cn As New SqlConnection
    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        cn.ConnectionString = conexion

        Dim da As New SqlDataAdapter("select idcliente,nomcliente,appcliente,apmcliente,DNIcliente,celcliente,correo from cliente ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgcliente.DataSource = dv
    End Sub

    Private Sub btninsertarcliente_Click(sender As Object, e As EventArgs) Handles btninsertarcliente.Click

        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "resgistrarcliente1"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idcliente", SqlDbType.Char, 9)
        Dim nombre As New SqlParameter("@nomcliente", SqlDbType.VarChar, 25)
        Dim apellido1 As New SqlParameter("@appcliente", SqlDbType.VarChar, 30)
        Dim apellido2 As New SqlParameter("@apmcliente", SqlDbType.VarChar, 30)
        Dim dni As New SqlParameter("@DNIcliente", SqlDbType.VarChar, 9)
        Dim cel As New SqlParameter("@celcliente", SqlDbType.VarChar, 9)
        Dim correo As New SqlParameter("@correo", SqlDbType.VarChar, 50)


        Id.Value = StrConv(txtcodigocliente.Text, VbStrConv.Uppercase)
        nombre.Value = StrConv(txtnomcliente.Text, VbStrConv.ProperCase)
        apellido1.Value = StrConv(txtappcliente.Text, VbStrConv.ProperCase)
        apellido2.Value = StrConv(txtapmcliente.Text, VbStrConv.Uppercase)
        dni.Value = StrConv(txtdnicliente.Text, VbStrConv.ProperCase)
        cel.Value = StrConv(txtcel.Text, VbStrConv.ProperCase)
        correo.Value = StrConv(txtdnicliente.Text, VbStrConv.ProperCase)

        CmdInsertar.Parameters.Add(Id)
        CmdInsertar.Parameters.Add(nombre)
        CmdInsertar.Parameters.Add(apellido1)
        CmdInsertar.Parameters.Add(apellido2)
        CmdInsertar.Parameters.Add(dni)
        CmdInsertar.Parameters.Add(cel)
        CmdInsertar.Parameters.Add(correo)

        cn.Open()


        Dim N As Integer
        Try
            N = CmdInsertar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Hay un usuario registrado con ese codigo", vbInformation, "Cliente")
        End Try



        If N = 1 Then
            MsgBox("Los datos se registrando correctamente", vbInformation, "Cliente")

        End If
        cn.Close()

        Dim da As New SqlDataAdapter("select idcliente,nomcliente,appcliente,apmcliente,DNIcliente,celcliente,correo from cliente ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgcliente.DataSource = dv
        login.codigologin = txtcodigocliente.Text
        If N = 1 Then
            principal.btnboleto_Click(sender, e)
        End If
        cn.Close()



    End Sub

    Private Sub btnclientemodificar_Click(sender As Object, e As EventArgs) Handles btnclientemodificar.Click


        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "modificarcliente"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idcliente", SqlDbType.Char, 9)
        Dim nombre As New SqlParameter("@nomcliente", SqlDbType.VarChar, 25)
        Dim apellido1 As New SqlParameter("@appcliente", SqlDbType.VarChar, 30)
        Dim apellido2 As New SqlParameter("@apmcliente", SqlDbType.VarChar, 30)
        Dim dni As New SqlParameter("@DNIcliente", SqlDbType.VarChar, 9)
        Dim cel As New SqlParameter("@celcliente", SqlDbType.VarChar, 9)
        Dim correo As New SqlParameter("@correo", SqlDbType.VarChar, 50)

        Id.Value = StrConv(txtcodigocliente.Text, VbStrConv.Uppercase)
        nombre.Value = StrConv(txtnomcliente.Text, VbStrConv.ProperCase)
        apellido1.Value = StrConv(txtappcliente.Text, VbStrConv.ProperCase)
        apellido2.Value = StrConv(txtapmcliente.Text, VbStrConv.Uppercase)
        dni.Value = StrConv(txtdnicliente.Text, VbStrConv.ProperCase)
        cel.Value = StrConv(txtcel.Text, VbStrConv.ProperCase)
        correo.Value = StrConv(txtdnicliente.Text, VbStrConv.ProperCase)

        CmdInsertar.Parameters.Add(Id)
        CmdInsertar.Parameters.Add(nombre)
        CmdInsertar.Parameters.Add(apellido1)
        CmdInsertar.Parameters.Add(apellido2)
        CmdInsertar.Parameters.Add(dni)
        CmdInsertar.Parameters.Add(cel)
        CmdInsertar.Parameters.Add(correo)

        cn.Open()

        Dim N As Integer
        N = CmdInsertar.ExecuteNonQuery()
        If N = 1 Then
            MsgBox("Los datos se modificaron correctamente", vbInformation, "Cliente")

        End If
        cn.Close()



        Dim da As New SqlDataAdapter("select idcliente,nomcliente,appcliente,apmcliente,DNIcliente,celcliente,correo from cliente ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgcliente.DataSource = dv

        login.codigologin = txtcodigocliente.Text
        principal.btnboleto_Click(sender, e)
        cn.Close()

    End Sub

    Private Sub txtcodigocliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodigocliente.TextChanged
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim Cmdbusq As New SqlCommand()
        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "vistacliente"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@idcliente", SqlDbType.Char, 9)
        Id.Value = txtcodigocliente.Text
        Cmdbusq.Parameters.Add(Id)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()

        Try

            txtnomcliente.Text = dr(1)
            txtappcliente.Text = dr(2)
            txtapmcliente.Text = dr(3)
            txtdnicliente.Text = dr(4)
            txtcel.Text = dr(6)
            txtcorreocliente.Text = dr(7)
        Catch ex As Exception

        End Try
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtdnicliente_TextChanged(sender As Object, e As EventArgs) Handles txtdnicliente.TextChanged
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim Cmdbusq As New SqlCommand()
        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "dni"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@DNIcliente", SqlDbType.VarChar, 9)
        Id.Value = txtdnicliente.Text
        Cmdbusq.Parameters.Add(Id)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()

        Try
            txtcodigocliente.Text = dr(0)
            txtnomcliente.Text = dr(1)
            txtappcliente.Text = dr(2)
            txtapmcliente.Text = dr(3)
            txtcel.Text = dr(6)
            txtcorreocliente.Text = dr(7)
        Catch ex As Exception

        End Try
        dr.Close()
        cn.Close()

    End Sub
End Class