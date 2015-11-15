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
End Class
