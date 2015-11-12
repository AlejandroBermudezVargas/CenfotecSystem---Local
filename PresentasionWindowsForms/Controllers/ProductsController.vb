Imports System.Configuration
Imports RestSharp
'Imports Microsoft.Office.Interop
Imports Newtonsoft.Json

Public Class ProductsController
    Shared Function RegistrarProducto(ByVal nombre As String, ByVal costo As Double, ByVal codigo As String, _
                                      ByVal horarios As String, ByVal id_tipo_product As Integer) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products", Method.POST)
        Dim producto = New Producto
        producto.Nombre = nombre
        producto.Costo = costo
        producto.Codigo_Producto = codigo
        producto.Horario = horarios
        producto.Id_Tipo_Product = id_tipo_product
        request.RequestFormat = DataFormat.Json
        request.AddObject(producto)
        Dim response = client.Execute(Of Producto)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return True
        Else
            Return False
        End If

    End Function

    'Shared Sub ImportarProductos(ByVal path As String)
    '    Dim APP As New Excel.Application
    '    Dim worksheet As Excel.Worksheet
    '    Dim workbook As Excel.Workbook
    '    Dim rango As Excel.Range
    '    Dim rowNum As Integer
    '    Dim fieldNum As Integer
    '    Dim rowCount As Integer
    '    Dim colCount As Integer
    '    Dim codProd As String
    '    Dim nombreProd As String
    '    Dim costoProd As Double
    '    Dim costo2 As String
    '    Dim tipoProd As Integer
    '    Dim horario As String

    '    horario = ""
    '    nombreProd = ""
    '    costoProd = 0
    '    codProd = ""
    '    workbook = APP.Workbooks.Open(path)
    '    worksheet = workbook.Worksheets(1)
    '    rango = worksheet.UsedRange
    '    rowNum = 1
    '    rowCount = worksheet.UsedRange.Rows.Count
    '    colCount = worksheet.UsedRange.Columns.Count

    '    MsgBox(rowCount)
    '    For i = 1 To rowCount
    '        For j = 1 To colCount
    '            fieldNum = j
    '            Select Case (fieldNum)
    '                Case 1
    '                    codProd = rango.Cells(i, j).Value.ToString()
    '                Case 2
    '                    nombreProd = rango.Cells(i, j).Value.ToString()
    '                Case 3
    '                    costo2 = rango.Cells(i, j).Value.ToString()
    '                    If (costo2.Equals("Costo")) Then
    '                    Else
    '                        costoProd = Double.Parse(costo2)
    '                    End If
    '                Case 4
    '                    tipoProd = Integer.Parse(rango.Cells(i, j).Value.ToString())
    '                Case 5
    '                    horario = rango.Cells(i, j).Value.ToString()
    '                Case Else
    '            End Select
    '        Next j
    '        RegistrarProducto(nombreProd, costoProd, codProd, horario, tipoProd)
    '    Next i
    '    costoProd = 0
    '    codProd = ""
    '    nombreProd = ""
    '    workbook.Close()
    'End Sub
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
        'request.RequestFormat = DataFormat.Json
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
End Class
