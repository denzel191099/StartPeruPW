Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.Odbc
Public Class Viaje
    Private dv As New DataView
    Dim strcomando1 As String
    Dim adapteras1 As SqlDataAdapter
    Dim data1 As DataSet

    Dim strcomando As String
    Dim adapteras As SqlDataAdapter
    Dim data As DataSet
    Private Sub Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        strcomando = "select * from chofer"
        adapteras = New System.Data.SqlClient.SqlDataAdapter(strcomando, cn)
        Data = New DataSet
        adapteras.Fill(Data)
        cbchofer.DataSource = Data.Tables(0)
        cbchofer.DisplayMember = "idchofer"

        strcomando1 = "select * from automoviles"
        adapteras1 = New System.Data.SqlClient.SqlDataAdapter(strcomando1, cn)
        data1 = New DataSet
        adapteras1.Fill(data1)
        cbauto.DataSource = data1.Tables(0)
        cbauto.DisplayMember = "idautomovil"


        Dim da As New SqlDataAdapter("select * from viaje ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgviaje.DataSource = dv



    End Sub

    Private Sub btregistrar_Click(sender As Object, e As EventArgs) Handles btregistrar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "resgistrarviaje"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idviaje", SqlDbType.Char, 9)

        Dim salida As New SqlParameter("@salida", SqlDbType.VarChar, 30)
        Dim llegada As New SqlParameter("@llegada", SqlDbType.VarChar, 30)
        Dim fecha As New SqlParameter("@fecha", SqlDbType.Date)
        Dim hora As New SqlParameter("@hora", SqlDbType.VarChar, 9)
        Dim costo As New SqlParameter("@costo", SqlDbType.Int)
        Dim auto As New SqlParameter("@idautomovil", SqlDbType.Char, 9)
        Dim chofer As New SqlParameter("@idchofer", SqlDbType.Char, 9)


        Id.Value = StrConv(txtcodigoviaje.Text, VbStrConv.Uppercase)
        salida.Value = StrConv(cbsalida.Text, VbStrConv.ProperCase)
        llegada.Value = StrConv(cbllegada.Text, VbStrConv.ProperCase)
        fecha.Value = Convert.ToDateTime(dtpdate.Value)
        hora.Value = StrConv(cbhora.Text, VbStrConv.ProperCase)
        costo.Value = StrConv(txtcosto.Text, VbStrConv.ProperCase)
        auto.Value = StrConv(cbauto.Text, VbStrConv.Uppercase)
        chofer.Value = StrConv(cbchofer.Text, VbStrConv.ProperCase)






        CmdInsertar.Parameters.Add(Id)
        CmdInsertar.Parameters.Add(salida)
        CmdInsertar.Parameters.Add(llegada)
        CmdInsertar.Parameters.Add(fecha)
        CmdInsertar.Parameters.Add(hora)
        CmdInsertar.Parameters.Add(costo)
        CmdInsertar.Parameters.Add(auto)
        CmdInsertar.Parameters.Add(chofer)

        ''--
        Dim CmdInsertar1 As New SqlCommand()
        CmdInsertar1.CommandType = CommandType.StoredProcedure
        CmdInsertar1.CommandText = "registrarviaje_auto"
        CmdInsertar1.Connection = cn
        Dim Id1 As New SqlParameter("@idviaje", SqlDbType.Char, 9)

        Id1.Value = StrConv(txtcodigoviaje.Text, VbStrConv.Uppercase)
        CmdInsertar1.Parameters.Add(Id1)

        cn.Open()
        Dim B As Integer
        Dim N As Integer


        N = CmdInsertar.ExecuteNonQuery()

        B = CmdInsertar1.ExecuteNonQuery()
        If N = 1 Then
            MsgBox("Los datos se registraron correctamente", vbInformation, "viaje")

        End If

        cn.Close()
        txtcodigoviaje.Clear()
        txtcosto.Clear()



        Dim da As New SqlDataAdapter("select * from viaje ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgviaje.DataSource = dv
    End Sub

    Private Sub btmodificar_Click(sender As Object, e As EventArgs) Handles btmodificar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "modificarviaje"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idviaje", SqlDbType.Char, 9)

        Dim salida As New SqlParameter("@salida", SqlDbType.VarChar, 30)
        Dim llegada As New SqlParameter("@llegada", SqlDbType.VarChar, 30)
        Dim fecha As New SqlParameter("@fecha", SqlDbType.Date)
        Dim hora As New SqlParameter("@hora", SqlDbType.VarChar, 9)
        Dim costo As New SqlParameter("@costo", SqlDbType.Int)
        Dim auto As New SqlParameter("@idautomovil", SqlDbType.Char, 9)
        Dim chofer As New SqlParameter("@idchofer", SqlDbType.Char, 9)


        Id.Value = StrConv(txtcodigoviaje.Text, VbStrConv.Uppercase)
        salida.Value = StrConv(cbsalida.Text, VbStrConv.ProperCase)
        llegada.Value = StrConv(cbllegada.Text, VbStrConv.ProperCase)
        fecha.Value = Convert.ToDateTime(dtpdate.Value)
        hora.Value = StrConv(cbhora.Text, VbStrConv.ProperCase)
        costo.Value = StrConv(txtcosto.Text, VbStrConv.ProperCase)
        auto.Value = StrConv(cbauto.Text, VbStrConv.Uppercase)
        chofer.Value = StrConv(cbchofer.Text, VbStrConv.ProperCase)






        CmdInsertar.Parameters.Add(Id)
        CmdInsertar.Parameters.Add(salida)
        CmdInsertar.Parameters.Add(llegada)
        CmdInsertar.Parameters.Add(fecha)
        CmdInsertar.Parameters.Add(hora)
        CmdInsertar.Parameters.Add(costo)
        CmdInsertar.Parameters.Add(auto)
        CmdInsertar.Parameters.Add(chofer)



        cn.Open()
        Try
            Dim N As Integer
            N = CmdInsertar.ExecuteNonQuery()
            If N = 1 Then
                MsgBox("Los datos se modificaron correctamente", vbInformation, "Chofer")

            End If

            cn.Close()

        Catch ex As Exception

        End Try



        Dim da As New SqlDataAdapter("select * from viaje ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgviaje.DataSource = dv
    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection()

        cn.ConnectionString = conexion



        Dim CmdEliminar As New SqlCommand()
        CmdEliminar.CommandType = CommandType.StoredProcedure
        CmdEliminar.CommandText = "eliminarviaje"
        CmdEliminar.Connection = cn



        Dim Id As New SqlParameter("@idviaje", SqlDbType.Char, 9)
        Id.Value = txtcodigoviaje.Text
        CmdEliminar.Parameters.Add(Id)

        Dim CmdEliminar1 As New SqlCommand()
        CmdEliminar1.CommandType = CommandType.StoredProcedure
        CmdEliminar1.CommandText = "eliminarviaje_auto"
        CmdEliminar1.Connection = cn



        Dim Id1 As New SqlParameter("@idviaje", SqlDbType.Char, 9)
        Id1.Value = txtcodigoviaje.Text
        CmdEliminar1.Parameters.Add(Id1)

        cn.Open()

        Dim B As Integer
        Dim N As Integer
        Try
            B = CmdEliminar1.ExecuteNonQuery()
            N = CmdEliminar.ExecuteNonQuery()

        Catch ex As Exception

        End Try


        If N = 1 Then
            MsgBox("Registro eliminado", vbInformation, "Viaje")

        End If

        cn.Close()

        txtcodigoviaje.Clear()



        Dim da As New SqlDataAdapter("select * from viaje ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgviaje.DataSource = dv
    End Sub

    Private Sub txtcodigoviaje_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoviaje.TextChanged
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim Cmdbusq As New SqlCommand()
        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "vistaviajes"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@idviaje", SqlDbType.Char, 9)
        Id.Value = txtcodigoviaje.Text
        Cmdbusq.Parameters.Add(Id)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()

        Try

            cbsalida.Text = dr(1)
            cbllegada.Text = dr(2)
            dtpdate.Text = dr(3)
            cbhora.Text = dr(4)
            txtcosto.Text = dr(5)
            cbauto.Text = dr(6)
            cbchofer.Text = dr(7)

        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try
    End Sub
End Class