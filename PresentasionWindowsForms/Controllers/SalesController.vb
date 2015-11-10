Imports RestSharp
Imports System.Configuration
Imports RestSharp.Deserializers
Imports Newtonsoft.Json

Public Class SalesController

    Shared Function RegistrarVenta(ByVal fecha As Date, ByVal monto As Double, ByVal id_usuario As Integer, ByVal tipo As String) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales", Method.POST)
        Dim sale = New Sale

        sale.Tipo = tipo
        sale.Id_Usuario = id_usuario
        sale.Monto = monto
        sale.Fecha = fecha
        request.RequestFormat = DataFormat.Json
        request.AddObject(sale)
        Dim response = client.Execute(Of Sale)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
