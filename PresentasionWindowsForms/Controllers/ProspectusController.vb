Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json
Public Class ProspectusController

    Shared Function getTotalProspectosClientes()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTotalProspectosClientes", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function getTotalProspectos()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTotalProspectos", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function listar()
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectus", Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim prospectos As List(Of Prospecto) = JsonConvert.DeserializeObject(Of List(Of Prospecto))(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return prospectos
        Else
            Return Nothing
        End If
    End Function
End Class
