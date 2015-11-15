Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json

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

    Shared Function obtenerProducto(ByVal id_producto As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products/{id}", Method.GET)
        request.RootElement = "result"
        request.AddUrlSegment("id", id_producto)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of Producto)(request)

        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim prod = New Producto
            prod.Id_Producto = response.Data.Id_Producto
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
