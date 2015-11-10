Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json
Public Class EventosController

    Shared Function CrearEvento(ByVal id As Integer, ByVal lugar As String, ByVal fechaInicio As Date, ByVal fechaFin As Date)
        Dim evento = New Evento
        evento.Lugar = lugar
        evento.Fecha_inicio = fechaInicio
        evento.Fecha_fin = fechaFin
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request As RestRequest
        If (id <> Nothing) Then
            evento.Id_evento = id
            request = New RestRequest("Events/" + evento.Id_evento.ToString, Method.PUT) 'esta basura no sirve
            request.RequestFormat = DataFormat.Json
        Else
            request = New RestRequest("Events", Method.POST)
            request.RequestFormat = DataFormat.Json
        End If
        request.AddBody(evento)
        Dim response = cliente.Execute(Of Evento)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return True
        Else
            Return Nothing
        End If
    End Function

    Shared Function ListarEventos()
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Events", Method.GET)
        Dim respuesta = cliente.Execute(request)
        Dim eventos As List(Of Evento) = JsonConvert.DeserializeObject(Of List(Of Evento))(respuesta.Content)
        If (respuesta.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return eventos
        Else
            Return Nothing
        End If
    End Function

    Shared Function getEvento(ByVal id As Integer)
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Events", Method.GET)
        request.AddParameter("id", id)
        request.RequestFormat = DataFormat.Json
        Dim respuesta = cliente.Execute(Of Evento)(request)
        If (respuesta.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return respuesta.Data
        Else
            Return Nothing
        End If

    End Function

    Shared Function eliminar(ByVal id As Integer)
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Events", Method.DELETE)
        request.AddParameter("id", id)
        request.RequestFormat = DataFormat.Json
        Dim respuesta = cliente.Execute(Of Evento)(request)
        If (respuesta.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return True
        Else
            Return Nothing
        End If
    End Function

End Class

