Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json
Imports Microsoft.Office.Interop

Public Class ProductsController

    Shared Function getTopProducts()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTopProducts", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function totalProductos()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/totalProductos", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function
    Shared Function RegistrarProducto(ByVal nombre As String, ByVal costo As Double, ByVal codigo As String, _
                                      ByVal horarios As String, ByVal id_tipo_product As Integer, ByVal fecha_Inicio As Date) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products", Method.POST)
        Dim producto = New Producto
        producto.Nombre = nombre
        producto.Costo = costo
        producto.Codigo_Producto = codigo
        producto.Horario = horarios
        producto.Id_Tipo_Product = id_tipo_product
        producto.Fecha_Inicio = fecha_Inicio
        request.RequestFormat = DataFormat.Json
        request.AddBody(producto)
        Dim response = client.Execute(Of Producto)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Shared Function obtenerListaProductos() As List(Of Producto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products", Method.GET)
        request.RootElement = "result"
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim productos As List(Of Producto) = JsonConvert.DeserializeObject(Of List(Of Producto))(response.Content)
            Return productos
        Else
            Return Nothing
        End If
    End Function

    Shared Function obtenerProducto(ByVal id As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products/{id}", Method.GET)
        request.RootElement = "result"
        request.AddUrlSegment("id", id)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of Producto)(request)

        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim prod = New Producto
            prod.Costo = response.Data.Costo
            prod.Nombre = response.Data.Nombre
            prod.Codigo_Producto = response.Data.Codigo_Producto
            prod.Id_Tipo_Product = response.Data.Id_Tipo_Product
            prod.Horario = response.Data.Horario
            Return prod
        Else
            Return Nothing
        End If
    End Function

    Shared Sub ImportarProductos(ByVal path As String, ByVal ptipoProdImport As Integer)
        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim rango As Excel.Range
        Dim rowNum As Integer
        Dim fieldNum As Integer
        Dim rowCount As Integer
        Dim colCount As Integer
        Dim codProd As String
        Dim nombreProd As String
        Dim costoProd As Double
        Dim costo2 As String
        Dim tipoProd As Integer
        Dim horario As String
        Dim tipoProdImport As Integer
        Dim fecha_inicio As Date
        Dim errores As Boolean
        Dim registrosError As String

        tipoProdImport = ptipoProdImport
        horario = ""
        nombreProd = ""
        costoProd = 0
        codProd = ""
        registrosError = ""
        workbook = APP.Workbooks.Open(path)
        worksheet = workbook.Worksheets(1)
        rango = worksheet.UsedRange
        rowNum = 1
        rowCount = worksheet.UsedRange.Rows.Count
        colCount = worksheet.UsedRange.Columns.Count

        If colCount <> 6 Then
            MsgBox("La cantidad de columnas no coincide con la cantidad de campos de la tabla destino. " & vbNewLine _
                   & "Verifique el archivo e inténtelo de nuevo.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            MsgBox("Se importarán " & rowCount - 1 & " registros.", MsgBoxStyle.Information)
            For i = 2 To rowCount
                For j = 1 To colCount
                    fieldNum = j

                    Select Case (fieldNum)
                        Case 1
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                codProd = "No Provisto"
                            Else
                                codProd = CStr(rango.Cells(i, j).Value)
                            End If
                        Case 2
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                nombreProd = "No Provisto"
                            Else
                                nombreProd = CStr(rango.Cells(i, j).Value)
                            End If
                        Case 3
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                costo2 = "0"
                            Else
                                costo2 = rango.Cells(i, j).value.ToString()
                            End If
                            costoProd = Double.Parse(costo2)
                        Case 4
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                errores = True
                            End If
                            tipoProd = Integer.Parse(rango.Cells(i, j).Value.ToString())
                        Case 5
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                horario = "No Provisto"
                            Else
                                horario = rango.Cells(i, j).Value.ToString()
                            End If
                        Case 6
                            Dim dia As Integer
                            Dim mes As Integer

                            If CStr(Trim(rango.Cells(i, j).Value)) <> "" Then
                                dia = Left(Trim(CStr(rango.Cells(i, j).Value)), 2)
                                mes = Mid(Trim(CStr(rango.Cells(i, j).Value)), 4, 2)
                                If dia > 31 < 0 Or mes > 12 < 0 Then
                                    fecha_inicio = Date.Parse(Format("01/01/1900"))
                                    errores = True
                                Else
                                    fecha_inicio = Date.Parse(Format(CStr(rango.Cells(i, j).Value)))
                                End If
                            Else
                                fecha_inicio = Date.Parse(Format("01/01/1900"))
                            End If
                        Case Else
                    End Select
                Next j
                If errores Then
                    registrosError = registrosError & codProd & "|" & nombreProd & "|" & Str(costoProd) & "|" & tipoProd & "|" & horario & vbNewLine
                End If
                If tipoProd = tipoProdImport And Not errores Then
                    RegistrarProducto(nombreProd, costoProd, codProd, horario, tipoProd, fecha_inicio)
                End If
            Next i
            If registrosError.Length > 0 Then
                Dim resul = "Los siguientes registros presentaron problemas al tratar de ingresarse en la base de datos: " & vbNewLine _
                & "Código|Nombre|Costo|Tipo|Horario|Fecha Inicio" & registrosError
                MsgBox(resul, MsgBoxStyle.Critical)
            Else
                MsgBox("La información de productos se ingresó correctamente.", MsgBoxStyle.Information)
            End If

            costoProd = 0
            codProd = ""
            nombreProd = ""
            workbook.Close()
            APP = Nothing
        End If
    End Sub

End Class
