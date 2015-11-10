Public Class Evento
    Private _lugar As String
    Private _fecha_inicio As Date
    Private _fecha_fin As Date
    Private _id_evento As Integer

    Public Property Lugar As String
        Get
            Return _lugar
        End Get
        Set(value As String)
            _lugar = value
        End Set
    End Property

    Public Property Fecha_inicio As Date
        Get
            Return _fecha_inicio
        End Get
        Set(value As Date)
            _fecha_inicio = value
        End Set
    End Property

    Public Property Fecha_fin As Date
        Get
            Return _fecha_fin
        End Get
        Set(value As Date)
            _fecha_fin = value
        End Set
    End Property

    Public Property Id_evento As Integer
        Get
            Return _id_evento
        End Get
        Set(value As Integer)
            _id_evento = value
        End Set
    End Property

End Class

