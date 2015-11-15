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

    Shared Function guardarOActualizar(ByVal id As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal fecha_nacimiento As Date,
                            ByVal procedencia As String, ByVal estado As Boolean, ByVal telefono As String,
                            ByVal email As String, ByVal direccion As String, ByVal estaInteresado As Boolean,
                            ByVal esCliente As Boolean, ByVal intereses As List(Of Tipo_Producto)) As Boolean
        Dim nvoProspecto = New Prospecto
        nvoProspecto.Nombre = nombre
        nvoProspecto.Apellidos = apellidos
        nvoProspecto.Fecha_nacimiento = fecha_nacimiento
        nvoProspecto.Procedencia = procedencia
        nvoProspecto.Estado = estado
        nvoProspecto.Telefono = telefono
        nvoProspecto.Email = email
        nvoProspecto.Direccion = direccion
        nvoProspecto.Interesado = estaInteresado
        nvoProspecto.Cliente = esCliente
        'If (Not intereses.Equals(Nothing)) Then
        'nvoProspecto.Tipo_producto = intereses
        'End If
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request As RestRequest
        If (id <> -1) Then
            nvoProspecto.Id_prospecto = id
            request = New RestRequest("Prospectus/" + id.ToString, Method.PUT)
            request.RequestFormat = DataFormat.Json
        Else
            request = New RestRequest("Prospectus", Method.POST)
            request.RequestFormat = DataFormat.Json
        End If
        request.AddBody(nvoProspecto)
        Dim response = client.Execute(Of Prospecto)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created) Or
            (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent))) Then
            Return True
        Else
            Return Nothing
        End If
    End Function
End Class
