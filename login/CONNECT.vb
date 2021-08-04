Imports System.Data.SqlClient

Module CONECCT
    Public cn As New SqlConnection
    Public Sub conection()
        Try
            Dim conexion As String
            conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"

            cn.ConnectionString = conexion
        Catch ex As Exception

        End Try

    End Sub


End Module
