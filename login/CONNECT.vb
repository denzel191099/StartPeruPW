Imports System.Data.SqlClient

Module CONECCT
    Public cn As New SqlConnection
    Public Sub conection()
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"

        cn.ConnectionString = conexion
    End Sub


End Module
