﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.288
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 1.0.3705.288.
'
Namespace localhost2
    
    '<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="StockQuote_SecuritySoap", [Namespace]:="http://tempuri.org/")>  _
    Public Class StockQuote_Security
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://localhost/ASP.NET/Chapter20/WebServices/StockQuote_Security.asmx"
        End Sub
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Login(ByVal ID As String, ByVal Password As String) As LicenseKey
            Dim results() As Object = Me.Invoke("Login", New Object() {ID, Password})
            Return CType(results(0),LicenseKey)
        End Function
        
        '<remarks/>
        Public Function BeginLogin(ByVal ID As String, ByVal Password As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Login", New Object() {ID, Password}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndLogin(ByVal asyncResult As System.IAsyncResult) As LicenseKey
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),LicenseKey)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStockQuote", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetStockQuote(ByVal Ticker As String, ByVal Key As LicenseKey) As Integer
            Dim results() As Object = Me.Invoke("GetStockQuote", New Object() {Ticker, Key})
            Return CType(results(0),Integer)
        End Function
        
        '<remarks/>
        Public Function BeginGetStockQuote(ByVal Ticker As String, ByVal Key As LicenseKey, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetStockQuote", New Object() {Ticker, Key}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetStockQuote(ByVal asyncResult As System.IAsyncResult) As Integer
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Integer)
        End Function
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Public Class LicenseKey
        
        '<remarks/>
        Public Key As String
    End Class
End Namespace
