﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class respuestasDelSistema
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PresentasionWindowsForms.respuestasDelSistema", GetType(respuestasDelSistema).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Hubo un error al crear el usuario.
        '''</summary>
        Friend Shared ReadOnly Property CREATE_USER_ERROR() As String
            Get
                Return ResourceManager.GetString("CREATE_USER_ERROR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El usuario ha sido creado exitosamente!.
        '''</summary>
        Friend Shared ReadOnly Property CREATE_USER_SUCCESS() As String
            Get
                Return ResourceManager.GetString("CREATE_USER_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El usuario ha sido eliminado exitoxamente!.
        '''</summary>
        Friend Shared ReadOnly Property DELETE_USER_SUCCESS() As String
            Get
                Return ResourceManager.GetString("DELETE_USER_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El usuario no existe en el sistema!.
        '''</summary>
        Friend Shared ReadOnly Property elUsuarioNoExiste() As String
            Get
                Return ResourceManager.GetString("elUsuarioNoExiste", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tu rol se encuentra inactivo!.
        '''</summary>
        Friend Shared ReadOnly Property INACTIVE_ROL() As String
            Get
                Return ResourceManager.GetString("INACTIVE_ROL", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tu usuario se encuentra inactivo en el sistema!.
        '''</summary>
        Friend Shared ReadOnly Property INACTIVE_USER() As String
            Get
                Return ResourceManager.GetString("INACTIVE_USER", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Combinación de password y contraseña incorrectos.
        '''</summary>
        Friend Shared ReadOnly Property USER_NOT_EXIST() As String
            Get
                Return ResourceManager.GetString("USER_NOT_EXIST", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
