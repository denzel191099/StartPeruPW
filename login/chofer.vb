Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class chofer
    Private dv As New DataView

    Private Sub chofer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim da As New SqlDataAdapter("select idchofer as id_piloto, nomchofer as nombre_piloto, appchofer as app_piloto, apmchofer as apm_piloto,licencia from chofer ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgchofer.DataSource = dv

    End Sub

    Private Sub btregistrar_Click(sender As Object, e As EventArgs) Handles btregistrar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "registrarchofer"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idchofer", SqlDbType.Char, 9)

        Dim nombre As New SqlParameter("@nomchofer", SqlDbType.VarChar, 30)
        Dim apellido1 As New SqlParameter("@appchofer", SqlDbType.VarChar, 30)
        Dim apellido2 As New SqlParameter("@apmchofer", SqlDbType.VarChar, 30)
        Dim licencia As New SqlParameter("@licencia", SqlDbType.VarChar, 30)


        Id.Value = StrConv(txtcodigochofer.Text, VbStrConv.Uppercase)
        nombre.Value = StrConv(txtnomchofer.Text, VbStrConv.ProperCase)

        apellido1.Value = StrConv(txtappchofer.Text, VbStrConv.ProperCase)
        apellido2.Value = StrConv(txtapmchofer.Text, VbStrConv.ProperCase)
        licencia.Value = StrConv(cblicencia.Text, VbStrConv.ProperCase)






        CmdInsertar.Parameters.Add(Id)
        CmdInsertar.Parameters.Add(nombre)
        CmdInsertar.Parameters.Add(apellido1)
        CmdInsertar.Parameters.Add(apellido2)
        CmdInsertar.Parameters.Add(licencia)



        cn.Open()

        Dim N As Integer
        N = CmdInsertar.ExecuteNonQuery()
        If N = 1 Then
            MsgBox("Los datos se registrando correctamente", vbInformation, "Chofer")

        End If

        cn.Close()




        cn.Close()
        Dim da As New SqlDataAdapter("select idchofer as id_piloto, nomchofer as nombre_piloto, appchofer as app_piloto, apmchofer as apm_piloto,licencia from chofer ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgchofer.DataSource = dv

        txtapmchofer.Clear()
        txtcodigochofer.Clear()
        txtappchofer.Clear()
        txtnomchofer.Clear()
    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion



        Dim CmdEliminar As New SqlCommand()
        CmdEliminar.CommandType = CommandType.StoredProcedure
        CmdEliminar.CommandText = "eliminarchofer"
        CmdEliminar.Connection = cn



        Dim Id As New SqlParameter("@idchofer", SqlDbType.Char, 9)
        Id.Value = txtcodigochofer.Text
        CmdEliminar.Parameters.Add(Id)

        cn.Open()


        Dim N As Integer
            N = CmdEliminar.ExecuteNonQuery()



        If N = 1 Then
            MsgBox("Registro eliminado", vbInformation, "Chofer")

        End If

        cn.Close()

        txtcodigochofer.Clear()
        txtapmchofer.Clear()
        txtcodigochofer.Clear()
        txtappchofer.Clear()
        txtnomchofer.Clear()


        Dim da As New SqlDataAdapter("select idchofer as id_piloto, nomchofer as nombre_piloto, appchofer as app_piloto, apmchofer as apm_piloto,licencia from chofer ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgchofer.DataSource = dv
    End Sub

    Private Sub btmodificar_Click(sender As Object, e As EventArgs) Handles btmodificar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion





        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "modificachofer"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idchofer", SqlDbType.Char, 9)

        Dim nombre As New SqlParameter("@nomchofer", SqlDbType.VarChar, 30)
        Dim apellido1 As New SqlParameter("@appchofer", SqlDbType.VarChar, 30)
        Dim apellido2 As New SqlParameter("@apmchofer", SqlDbType.VarChar, 30)
        Dim licencia As New SqlParameter("@licencia", SqlDbType.VarChar, 30)


        If txtnomchofer.Text <> String.Empty Then
            nombre.Value = StrConv(txtnomchofer.Text, VbStrConv.ProperCase)
            CmdInsertar.Parameters.Add(nombre)
        Else

        End If




        Id.Value = StrConv(txtcodigochofer.Text, VbStrConv.Uppercase)




        apellido1.Value = StrConv(txtappchofer.Text, VbStrConv.ProperCase)
        apellido2.Value = StrConv(txtapmchofer.Text, VbStrConv.ProperCase)
        licencia.Value = StrConv(cblicencia.Text, VbStrConv.ProperCase)






        CmdInsertar.Parameters.Add(Id)




        CmdInsertar.Parameters.Add(apellido1)
        CmdInsertar.Parameters.Add(apellido2)
        CmdInsertar.Parameters.Add(licencia)



        cn.Open()

        Dim N As Integer
        N = CmdInsertar.ExecuteNonQuery()
        If N = 1 Then
            MsgBox("Los datos se modificaron correctamente", vbInformation, "Chofer")

        End If

        cn.Close()

        txtapmchofer.Clear()
        txtcodigochofer.Clear()
        txtappchofer.Clear()
        txtnomchofer.Clear()



        Dim da As New SqlDataAdapter("select idchofer as id_piloto, nomchofer as nombre_piloto, appchofer as app_piloto, apmchofer as apm_piloto,licencia from chofer ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgchofer.DataSource = dv
    End Sub

    Private Sub txtcodigochofer_TextChanged(sender As Object, e As EventArgs) Handles txtcodigochofer.TextChanged
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim Cmdbusq As New SqlCommand()
        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "vistachofer"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@idchofer", SqlDbType.Char, 9)
        Id.Value = txtcodigochofer.Text
        Cmdbusq.Parameters.Add(Id)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()

        Try

            txtnomchofer.Text = dr(1)
            txtappchofer.Text = dr(2)
            txtapmchofer.Text = dr(3)
            cblicencia.Text = dr(4)
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub cblicencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblicencia.SelectedIndexChanged

    End Sub
End Class