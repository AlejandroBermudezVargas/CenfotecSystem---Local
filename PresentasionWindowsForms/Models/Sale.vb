﻿Public Class Sale

    Private _sale_id As Integer
    Public Property SaleId() As Integer
        Get
            Return _sale_id
        End Get
        Set(ByVal value As Integer)
            _sale_id = value
        End Set
    End Property

    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property


    Private _monto As Double
    Public Property Monto() As String
        Get
            Return _monto
        End Get
        Set(ByVal value As String)
            _monto = value
        End Set
    End Property

    Private _id_usuario As Integer
    Public Property Id_Usuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
        End Set
    End Property

    Private _tipo As String
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property


End Class
