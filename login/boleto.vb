Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports iTextSharp.text.pdf
Imports System.IO
Imports iTextSharp.text



Public Class boleto
    Dim asiento1 As String
    Dim asiento2 As String
    Dim asiento3 As String
    Dim asiento4 As String
    Dim asiento5 As String
    Dim asiento6 As String
    Dim asiento7 As String
    Dim asiento8 As String
    Dim asiento9 As String
    Dim asiento10 As String


    Private dv As New DataView
    Dim strcomando As String
    Dim adapteras As SqlDataAdapter
    Dim data As DataSet

    Dim nombrecliente As String
    Dim dni As String
    Dim dircliente As String
    Dim cel As String
    Dim correo As String
    Dim hora As DateTime


    Private Sub boleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim da As New SqlDataAdapter("exec vistaboleto ", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        dgboleto.DataSource = dv

        strcomando = "select * from viaje"
        adapteras = New System.Data.SqlClient.SqlDataAdapter(strcomando, cn)
        data = New DataSet
        adapteras.Fill(data)
        cbcodigo.DataSource = data.Tables(0)
        cbcodigo.DisplayMember = "idviaje"

        lbl6.Text = "S/"



        Dim Cmdbusq As New SqlCommand()
        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "datoscliente"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@idcliente", SqlDbType.Char, 9)
        Id.Value = login.codigologin
        Cmdbusq.Parameters.Add(Id)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()

        Try
            nombrecliente = dr(1) & " " & dr(2) & " " & dr(3)
            dni = dr(4)
            dircliente = dr(5)
            cel = dr(6)
            correo = dr(7)

        Catch ex As Exception
            dr.Close()
            cn.Close()

        End Try
        ''----------------------------------------

        cbasiento.SelectedIndex = 0



    End Sub

    Private Sub txtpartida_TextChanged(sender As Object, e As EventArgs) Handles txtpartida.TextChanged
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        dv.RowFilter = String.Format("salida Like '%{0}%'", txtpartida.Text)
    End Sub

    Private Sub txtllegada_TextChanged(sender As Object, e As EventArgs) Handles txtllegada.TextChanged
        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        dv.RowFilter = String.Format("llegada like '%{0}%'", txtllegada.Text)
    End Sub

    Private Sub cbcodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcodigo.SelectedIndexChanged
        cbasiento.Items.Clear()

        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim Cmdbusq As New SqlCommand()
        Cmdbusq.CommandType = CommandType.StoredProcedure
        Cmdbusq.CommandText = "pagoboleto"
        Cmdbusq.Connection = cn
        Dim Id As New SqlParameter("@idviaje", SqlDbType.Char, 9)
        Id.Value = cbcodigo.Text
        Cmdbusq.Parameters.Add(Id)
        cn.Open()
        Dim dr As SqlDataReader
        dr = Cmdbusq.ExecuteReader
        dr.Read()

        Try
            LB1.Text = dr(0)
            LB2.Text = dr(1)
            LB3.Text = dr(2)
            LB4.Text = dr(3)
            LB5.Text = dr(4)
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try


        Dim conexion1 As String
        conexion1 = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion


        Dim i = 0
        Dim Cmdbusq1 As New SqlCommand()
        Cmdbusq1.CommandType = CommandType.StoredProcedure
        Cmdbusq1.CommandText = "vistabus"
        Cmdbusq1.Connection = cn1
        Dim Idbus As New SqlParameter("@idviaje", SqlDbType.Char, 9)
        Idbus.Value = cbcodigo.Text
        Cmdbusq1.Parameters.Add(Idbus)
        cn1.Open()

        Dim dr1 As SqlDataReader
        dr1 = Cmdbusq1.ExecuteReader
        dr1.Read()

        Try
            asiento1 = dr1(1)
            asiento2 = dr1(2)
            asiento3 = dr1(3)
            asiento4 = dr1(4)
            asiento5 = dr1(5)
            asiento6 = dr1(6)
            asiento7 = dr1(7)
            asiento8 = dr1(8)
            asiento9 = dr1(9)
            asiento10 = dr1(10)


            While i <= 10
                i = i + 1
                If String.Compare(dr1(i), "ocup") = -1 Then
                    cbasiento.Items.Add(dr1(i))

                End If

                If String.Compare(dr1(1), "ocup") = 1 Then
                    btn1.BackColor = Color.Red
                ElseIf String.Compare(dr1(1), "ocup") = -1 Then
                    btn1.BackColor = Color.Transparent
                End If

                If String.Compare(dr1(2), "ocup") = 1 Then
                    btn2.BackColor = Color.Red
                ElseIf String.Compare(dr1(2), "ocup") = -1 Then
                    btn2.BackColor = Color.Transparent
                End If

                If String.Compare(dr1(3), "ocup") = 1 Then
                    btn3.BackColor = Color.Red
                ElseIf String.Compare(dr1(3), "ocup") = -1 Then
                    btn3.BackColor = Color.Transparent
                End If

                If String.Compare(dr1(4), "ocup") = 1 Then
                    btn4.BackColor = Color.Red
                ElseIf String.Compare(dr1(4), "ocup") = -1 Then
                    btn4.BackColor = Color.Transparent
                End If

                If String.Compare(dr1(5), "ocup") = 1 Then
                    btn5.BackColor = Color.Red
                ElseIf String.Compare(dr1(5), "ocup") = -1 Then
                    btn5.BackColor = Color.Transparent
                End If
                If String.Compare(dr1(6), "ocup") = 1 Then
                    btn6.BackColor = Color.Red
                ElseIf String.Compare(dr1(6), "ocup") = -1 Then
                    btn6.BackColor = Color.Transparent
                End If
                If String.Compare(dr1(7), "ocup") = 1 Then
                    btn7.BackColor = Color.Red
                ElseIf String.Compare(dr1(7), "ocup") = -1 Then
                    btn7.BackColor = Color.Transparent
                End If
                If String.Compare(dr1(8), "ocup") = 1 Then
                    btn8.BackColor = Color.Red
                ElseIf String.Compare(dr1(8), "ocup") = -1 Then
                    btn8.BackColor = Color.Transparent
                End If
                If String.Compare(dr1(9), "ocup") = 1 Then
                    btn9.BackColor = Color.Red
                ElseIf String.Compare(dr1(9), "ocup") = -1 Then
                    btn9.BackColor = Color.Transparent
                End If
                If String.Compare(dr1(10), "ocup") = 1 Then
                    btn10.BackColor = Color.Red
                ElseIf String.Compare(dr1(10), "ocup") = -1 Then
                    btn10.BackColor = Color.Transparent
                End If

            End While




        Catch ex As Exception
            dr1.Close()

        End Try
        cn1.Close()
        Try
            cbasiento.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnconfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click


        If String.Compare(cbasiento.Text, "A1") = 1 Then

            asiento1 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A2") = 1 Then
            asiento2 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A3") = 1 Then
            asiento3 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A4") = 1 Then
            asiento4 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A5") = 1 Then
            asiento5 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A6") = 1 Then
            asiento6 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A7") = 1 Then
            asiento7 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A8") = 1 Then
            asiento8 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A9") = 1 Then
            asiento9 = "ocup"
        End If
        If String.Compare(cbasiento.Text, "A10") = 1 Then
            asiento10 = "ocup"
        End If


        Dim conexion As String
        conexion = "Data Source=DESKTOP-K9B34K5;Initial Catalog=Empresadetransporte;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim CmdInsertar As New SqlCommand()
        CmdInsertar.CommandType = CommandType.StoredProcedure
        CmdInsertar.CommandText = "insertarasiento"
        CmdInsertar.Connection = cn
        Dim Id As New SqlParameter("@idviaje", SqlDbType.Char, 9)

        Dim a1 As New SqlParameter("@asiento1", SqlDbType.Char, 5)
        Dim a2 As New SqlParameter("@asiento2", SqlDbType.Char, 5)
        Dim a3 As New SqlParameter("@asiento3", SqlDbType.Char, 5)
        Dim a4 As New SqlParameter("@asiento4", SqlDbType.Char, 5)
        Dim a5 As New SqlParameter("@asiento5", SqlDbType.Char, 5)
        Dim a6 As New SqlParameter("@asiento6", SqlDbType.Char, 5)
        Dim a7 As New SqlParameter("@asiento7", SqlDbType.Char, 5)
        Dim a8 As New SqlParameter("@asiento8", SqlDbType.Char, 5)
        Dim a9 As New SqlParameter("@asiento9", SqlDbType.Char, 5)
        Dim a10 As New SqlParameter("@asiento10", SqlDbType.Char, 5)

        Id.Value = (cbcodigo.Text)
        a1.Value = (asiento1)
        a2.Value = (asiento2)
        a3.Value = (asiento3)
        a4.Value = (asiento4)
        a5.Value = (asiento5)
        a6.Value = (asiento6)
        a7.Value = (asiento7)
        a8.Value = (asiento8)
        a9.Value = (asiento9)
        a10.Value = (asiento10)



        CmdInsertar.Parameters.Add(Id)
        CmdInsertar.Parameters.Add(a1)
        CmdInsertar.Parameters.Add(a2)
        CmdInsertar.Parameters.Add(a3)
        CmdInsertar.Parameters.Add(a4)
        CmdInsertar.Parameters.Add(a5)
        CmdInsertar.Parameters.Add(a6)
        CmdInsertar.Parameters.Add(a7)
        CmdInsertar.Parameters.Add(a8)
        CmdInsertar.Parameters.Add(a9)
        CmdInsertar.Parameters.Add(a10)


        cn.Open()
        Try
            Dim N As Integer
            N = CmdInsertar.ExecuteNonQuery()


            cn.Close()

        Catch ex As Exception

        End Try







        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("C:\Users\usuario\Desktop\Boleta.pdf", FileMode.Create))

        Dim font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim fontB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
        Dim fontB12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
        Dim Cvacio As PdfPCell = New PdfPCell(New Phrase(""))
        Cvacio.Border = 0


        pdfDoc.Open()
        Dim table1 As PdfPTable = New PdfPTable(4)
        Dim col1 As PdfPCell
        Dim col2 As PdfPCell
        Dim col3 As PdfPCell
        Dim col4 As PdfPCell
        Dim col5 As PdfPCell
        Dim col6 As PdfPCell

        table1.WidthPercentage = 95

        Dim witdths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        table1.SetWidths(witdths)

        Try
            Dim imagenURL As String = "chofer.png"
            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
            imagenBMP.ScaleToFit(100.0F, 140.0F)
            imagenBMP.SpacingBefore = 20.0F
            imagenBMP.SetAbsolutePosition(40, 740)
            pdfDoc.Add(imagenBMP)
        Catch ex As Exception

        End Try




        table1.AddCell(Cvacio)
        col2 = New PdfPCell(New Phrase("Nombre de la empresa", fontB12))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(Cvacio)
        col3 = New PdfPCell(New Phrase("Nota de Boleta", fontB12))
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(Cvacio)
        col2 = New PdfPCell(New Phrase("Telefono: 947-528-584", font8))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(Cvacio)
        col3 = New PdfPCell(New Phrase("Codigo de Cliente: " & login.codigologin, fontB8))
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(Cvacio)
        col2 = New PdfPCell(New Phrase("Av. 28 Julio 504, Cercado de Lima", font8))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(Cvacio)
        col3 = New PdfPCell(New Phrase("B" & login.codigologin, fontB12))
        col3.Border = 0
        table1.AddCell(col3)
        pdfDoc.Add(table1)

        pdfDoc.Add(New Paragraph("."))


        Dim table2 As PdfPTable = New PdfPTable(4)
        Dim witdth2 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F}
        table2.WidthPercentage = 80
        table2.SetWidths(witdth2)

        table2.AddCell(Cvacio)
        table2.AddCell(Cvacio)
        table2.AddCell(Cvacio)
        table2.AddCell(Cvacio)

        col1 = New PdfPCell(New Phrase("Cliente: ", font8))
        col1.Border = 0
        table2.AddCell(col1)

        col2 = New PdfPCell(New Phrase(nombrecliente, font8))
        col2.Border = 0
        table2.AddCell(col2)

        col3 = New PdfPCell(New Phrase("fecha: ", font8))
        col3.Border = 0
        table2.AddCell(col3)

        hora = Convert.ToDateTime(dpboleto.Value)

        col4 = New PdfPCell(New Phrase(hora, font8))
        col4.Border = 0
        table2.AddCell(col4)

        table2.AddCell(Cvacio)
        table2.AddCell(Cvacio)


        col1 = New PdfPCell(New Phrase("Dni: ", font8))
        col1.Border = 0
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase(dni, font8))
        col2.Border = 0
        table2.AddCell(col2)


        col3 = New PdfPCell(New Phrase("Celular: ", font8))
        col3.Border = 0
        table2.AddCell(col3)



        col4 = New PdfPCell(New Phrase(cel, font8))
        col4.Border = 0
        table2.AddCell(col4)


        col1 = New PdfPCell(New Phrase("Correo: ", font8))
        col1.Border = 0
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase(correo, font8))
        col2.Border = 0
        table2.AddCell(col2)


        col1 = New PdfPCell(New Phrase("Direccion ", font8))
        col1.Border = 0
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase(dircliente, font8))
        col2.Border = 0
        table2.AddCell(col2)
        table2.AddCell(Cvacio)
        table2.AddCell(Cvacio)



        pdfDoc.Add(table2)


        Dim table3 As PdfPTable = New PdfPTable(7)
        Dim withs3 As Single() = New Single() {1.0F, 3.0F, 2.0F, 2.0F, 2.0F, 2.0F, 1.0F}

        table3.WidthPercentage = 95
        table3.SetWidths(withs3)
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")


        col1 = New PdfPCell(New Phrase("Codigo", fontB8))
        col1.Border = 0
        table3.AddCell(col1)


        col2 = New PdfPCell(New Phrase("Salida", fontB8))
        col2.Border = 0
        table3.AddCell(col2)


        col3 = New PdfPCell(New Phrase("Llegada ", fontB8))
        col3.Border = 0
        table3.AddCell(col3)


        col4 = New PdfPCell(New Phrase("Hora de partida", fontB8))
        col4.Border = 0
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Costo", fontB8))
        col5.Border = 0
        table3.AddCell(col5)
        col5.HorizontalAlignment = 2

        col6 = New PdfPCell(New Phrase("Asiento", fontB8))
        col6.Border = 0
        table3.AddCell(col6)


        table3.AddCell(Cvacio)
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")
        table3.AddCell("")

        col1 = New PdfPCell(New Phrase(cbcodigo.Text, fontB8))
        col1.Border = 0
        table3.AddCell(col1)


        col2 = New PdfPCell(New Phrase(LB1.Text, fontB8))
        col2.Border = 0
        table3.AddCell(col2)


        col3 = New PdfPCell(New Phrase(LB2.Text, fontB8))
        col3.Border = 0
        table3.AddCell(col3)


        col4 = New PdfPCell(New Phrase(LB4.Text, fontB8))
        col4.Border = 0
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("S/ " & LB5.Text, fontB8))
        col5.Border = 0
        table3.AddCell(col5)
        col5.HorizontalAlignment = 2


        col6 = New PdfPCell(New Phrase(cbasiento.Text, fontB8))
        col6.Border = 0
        table3.AddCell(col6)
        col6.HorizontalAlignment = 2
        table3.AddCell(Cvacio)


        pdfDoc.Add(table3)



        pdfDoc.Close()
        Process.Start("C:\Users\usuario\Desktop\Boleta.pdf")


        Application.Exit()

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub btncerrar_Click_1(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbasiento.SelectedIndexChanged

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim i As Integer
        i = i + 1
        lbl10.Text = i
        btn3.BackColor = Color.Green


        If i = 2 Then
            i = 0
            btn3.BackColor = Color.Transparent


        End If

    End Sub
End Class