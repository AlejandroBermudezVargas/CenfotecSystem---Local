Imports RestSharp
Imports System.Configuration
Imports RestSharp.Deserializers
Imports Newtonsoft.Json

Public Class Users_controller
    Shared Function login(ByVal pcorreo As String, ByVal ppassword As String) As UserModel
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/Login", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddParameter("correo", pcorreo)
        request.AddParameter("password", ppassword)

        Dim response = client.Execute(request)
        Dim usuario As UserModel = JsonConvert.DeserializeObject(Of UserModel)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuario
        Else
            Return Nothing
        End If
    End Function


    Shared Sub signOut(ByRef user As UserModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/SignOut", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddBody(user)
        Dim response = client.Execute(request)
    End Sub

    Shared Function create(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New UserModel(pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento))

        Dim response = client.Execute(Of UserModel)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function update(ByVal pid As String, ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/" + pid, Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New UserModel(CInt(pid), pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento))

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function updateUserAndPassword(ByVal pid As String, ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/change/{id}", Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddUrlSegment("id", pid)
        request.AddBody(New UserModel(CInt(pid), pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento))

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function getUsers() As List(Of UserModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users", Method.Get)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim usuarios As List(Of UserModel) = JsonConvert.DeserializeObject(Of List(Of UserModel))(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuarios
        Else
            Return Nothing
        End If
    End Function

    Shared Function getUser(ByVal pid As String) As UserModel
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/" + pid, Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim usuario As UserModel = JsonConvert.DeserializeObject(Of UserModel)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuario
        Else
            Return Nothing
        End If
    End Function

    Shared Function assignProspectus(ByVal usuario As UserModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/assign/" + usuario.id_usuario.ToString, Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddBody(usuario)

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
