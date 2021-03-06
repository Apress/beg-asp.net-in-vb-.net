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
Namespace net.terraservice
    
    '<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="TerraServiceSoap", [Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class TerraService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://terraservice.net/TerraService.asmx"
        End Sub
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/ConvertLonLatPtToNearestPlace", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ConvertLonLatPtToNearestPlace(ByVal point As LonLatPt) As String
            Dim results() As Object = Me.Invoke("ConvertLonLatPtToNearestPlace", New Object() {point})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginConvertLonLatPtToNearestPlace(ByVal point As LonLatPt, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ConvertLonLatPtToNearestPlace", New Object() {point}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndConvertLonLatPtToNearestPlace(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/ConvertLonLatPtToUtmPt", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ConvertLonLatPtToUtmPt(ByVal point As LonLatPt) As UtmPt
            Dim results() As Object = Me.Invoke("ConvertLonLatPtToUtmPt", New Object() {point})
            Return CType(results(0),UtmPt)
        End Function
        
        '<remarks/>
        Public Function BeginConvertLonLatPtToUtmPt(ByVal point As LonLatPt, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ConvertLonLatPtToUtmPt", New Object() {point}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndConvertLonLatPtToUtmPt(ByVal asyncResult As System.IAsyncResult) As UtmPt
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),UtmPt)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/ConvertUtmPtToLonLatPt", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ConvertUtmPtToLonLatPt(ByVal utm As UtmPt) As LonLatPt
            Dim results() As Object = Me.Invoke("ConvertUtmPtToLonLatPt", New Object() {utm})
            Return CType(results(0),LonLatPt)
        End Function
        
        '<remarks/>
        Public Function BeginConvertUtmPtToLonLatPt(ByVal utm As UtmPt, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ConvertUtmPtToLonLatPt", New Object() {utm}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndConvertUtmPtToLonLatPt(ByVal asyncResult As System.IAsyncResult) As LonLatPt
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),LonLatPt)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/ConvertPlaceToLonLatPt", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ConvertPlaceToLonLatPt(ByVal place As Place) As LonLatPt
            Dim results() As Object = Me.Invoke("ConvertPlaceToLonLatPt", New Object() {place})
            Return CType(results(0),LonLatPt)
        End Function
        
        '<remarks/>
        Public Function BeginConvertPlaceToLonLatPt(ByVal place As Place, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ConvertPlaceToLonLatPt", New Object() {place}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndConvertPlaceToLonLatPt(ByVal asyncResult As System.IAsyncResult) As LonLatPt
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),LonLatPt)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/CountPlacesInRect", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CountPlacesInRect(ByVal upperleft As LonLatPt, ByVal lowerright As LonLatPt, ByVal ptype As PlaceType) As Integer
            Dim results() As Object = Me.Invoke("CountPlacesInRect", New Object() {upperleft, lowerright, ptype})
            Return CType(results(0),Integer)
        End Function
        
        '<remarks/>
        Public Function BeginCountPlacesInRect(ByVal upperleft As LonLatPt, ByVal lowerright As LonLatPt, ByVal ptype As PlaceType, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CountPlacesInRect", New Object() {upperleft, lowerright, ptype}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndCountPlacesInRect(ByVal asyncResult As System.IAsyncResult) As Integer
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Integer)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetAreaFromPt", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetAreaFromPt(ByVal center As LonLatPt, ByVal theme As Theme, ByVal scale As Scale, ByVal displayPixWidth As Integer, ByVal displayPixHeight As Integer) As AreaBoundingBox
            Dim results() As Object = Me.Invoke("GetAreaFromPt", New Object() {center, theme, scale, displayPixWidth, displayPixHeight})
            Return CType(results(0),AreaBoundingBox)
        End Function
        
        '<remarks/>
        Public Function BeginGetAreaFromPt(ByVal center As LonLatPt, ByVal theme As Theme, ByVal scale As Scale, ByVal displayPixWidth As Integer, ByVal displayPixHeight As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetAreaFromPt", New Object() {center, theme, scale, displayPixWidth, displayPixHeight}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetAreaFromPt(ByVal asyncResult As System.IAsyncResult) As AreaBoundingBox
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),AreaBoundingBox)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetAreaFromRect", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetAreaFromRect(ByVal upperLeft As LonLatPt, ByVal lowerRight As LonLatPt, ByVal theme As Theme, ByVal scale As Scale) As AreaBoundingBox
            Dim results() As Object = Me.Invoke("GetAreaFromRect", New Object() {upperLeft, lowerRight, theme, scale})
            Return CType(results(0),AreaBoundingBox)
        End Function
        
        '<remarks/>
        Public Function BeginGetAreaFromRect(ByVal upperLeft As LonLatPt, ByVal lowerRight As LonLatPt, ByVal theme As Theme, ByVal scale As Scale, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetAreaFromRect", New Object() {upperLeft, lowerRight, theme, scale}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetAreaFromRect(ByVal asyncResult As System.IAsyncResult) As AreaBoundingBox
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),AreaBoundingBox)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetAreaFromTileId", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetAreaFromTileId(ByVal id As TileId, ByVal displayPixWidth As Integer, ByVal displayPixHeight As Integer) As AreaBoundingBox
            Dim results() As Object = Me.Invoke("GetAreaFromTileId", New Object() {id, displayPixWidth, displayPixHeight})
            Return CType(results(0),AreaBoundingBox)
        End Function
        
        '<remarks/>
        Public Function BeginGetAreaFromTileId(ByVal id As TileId, ByVal displayPixWidth As Integer, ByVal displayPixHeight As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetAreaFromTileId", New Object() {id, displayPixWidth, displayPixHeight}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetAreaFromTileId(ByVal asyncResult As System.IAsyncResult) As AreaBoundingBox
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),AreaBoundingBox)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetLatLonMetrics", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetLatLonMetrics(ByVal point As LonLatPt) As <System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=false)> ThemeBoundingBox()
            Dim results() As Object = Me.Invoke("GetLatLonMetrics", New Object() {point})
            Return CType(results(0),ThemeBoundingBox())
        End Function
        
        '<remarks/>
        Public Function BeginGetLatLonMetrics(ByVal point As LonLatPt, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetLatLonMetrics", New Object() {point}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetLatLonMetrics(ByVal asyncResult As System.IAsyncResult) As ThemeBoundingBox()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),ThemeBoundingBox())
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetPlaceFacts", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPlaceFacts(ByVal place As Place) As PlaceFacts
            Dim results() As Object = Me.Invoke("GetPlaceFacts", New Object() {place})
            Return CType(results(0),PlaceFacts)
        End Function
        
        '<remarks/>
        Public Function BeginGetPlaceFacts(ByVal place As Place, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetPlaceFacts", New Object() {place}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetPlaceFacts(ByVal asyncResult As System.IAsyncResult) As PlaceFacts
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),PlaceFacts)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetPlaceList", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPlaceList(ByVal placeName As String, ByVal MaxItems As Integer, ByVal imagePresence As Boolean) As <System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=false)> PlaceFacts()
            Dim results() As Object = Me.Invoke("GetPlaceList", New Object() {placeName, MaxItems, imagePresence})
            Return CType(results(0),PlaceFacts())
        End Function
        
        '<remarks/>
        Public Function BeginGetPlaceList(ByVal placeName As String, ByVal MaxItems As Integer, ByVal imagePresence As Boolean, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetPlaceList", New Object() {placeName, MaxItems, imagePresence}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetPlaceList(ByVal asyncResult As System.IAsyncResult) As PlaceFacts()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),PlaceFacts())
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetPlaceListInRect", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPlaceListInRect(ByVal upperleft As LonLatPt, ByVal lowerright As LonLatPt, ByVal ptype As PlaceType, ByVal MaxItems As Integer) As <System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=false)> PlaceFacts()
            Dim results() As Object = Me.Invoke("GetPlaceListInRect", New Object() {upperleft, lowerright, ptype, MaxItems})
            Return CType(results(0),PlaceFacts())
        End Function
        
        '<remarks/>
        Public Function BeginGetPlaceListInRect(ByVal upperleft As LonLatPt, ByVal lowerright As LonLatPt, ByVal ptype As PlaceType, ByVal MaxItems As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetPlaceListInRect", New Object() {upperleft, lowerright, ptype, MaxItems}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetPlaceListInRect(ByVal asyncResult As System.IAsyncResult) As PlaceFacts()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),PlaceFacts())
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetTheme", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetTheme(ByVal theme As Theme) As ThemeInfo
            Dim results() As Object = Me.Invoke("GetTheme", New Object() {theme})
            Return CType(results(0),ThemeInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetTheme(ByVal theme As Theme, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetTheme", New Object() {theme}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetTheme(ByVal asyncResult As System.IAsyncResult) As ThemeInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),ThemeInfo)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetTileMetaFromLonLatPt", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetTileMetaFromLonLatPt(ByVal point As LonLatPt, ByVal theme As Theme, ByVal scale As Scale) As TileMeta
            Dim results() As Object = Me.Invoke("GetTileMetaFromLonLatPt", New Object() {point, theme, scale})
            Return CType(results(0),TileMeta)
        End Function
        
        '<remarks/>
        Public Function BeginGetTileMetaFromLonLatPt(ByVal point As LonLatPt, ByVal theme As Theme, ByVal scale As Scale, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetTileMetaFromLonLatPt", New Object() {point, theme, scale}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetTileMetaFromLonLatPt(ByVal asyncResult As System.IAsyncResult) As TileMeta
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),TileMeta)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetTileMetaFromTileId", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetTileMetaFromTileId(ByVal id As TileId) As TileMeta
            Dim results() As Object = Me.Invoke("GetTileMetaFromTileId", New Object() {id})
            Return CType(results(0),TileMeta)
        End Function
        
        '<remarks/>
        Public Function BeginGetTileMetaFromTileId(ByVal id As TileId, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetTileMetaFromTileId", New Object() {id}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetTileMetaFromTileId(ByVal asyncResult As System.IAsyncResult) As TileMeta
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),TileMeta)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://terraserver-usa.com/terraserver/GetTile", RequestNamespace:="http://terraserver-usa.com/terraserver/", ResponseNamespace:="http://terraserver-usa.com/terraserver/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetTile(ByVal id As TileId) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetTile", New Object() {id})
            Return CType(results(0),Byte())
        End Function
        
        '<remarks/>
        Public Function BeginGetTile(ByVal id As TileId, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetTile", New Object() {id}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetTile(ByVal asyncResult As System.IAsyncResult) As Byte()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Byte())
        End Function
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class LonLatPt
        
        '<remarks/>
        Public Lon As Double
        
        '<remarks/>
        Public Lat As Double
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class ThemeInfo
        
        '<remarks/>
        Public Theme As Theme
        
        '<remarks/>
        Public Name As String
        
        '<remarks/>
        Public Description As String
        
        '<remarks/>
        Public Supplier As String
        
        '<remarks/>
        Public LoScale As Scale
        
        '<remarks/>
        Public HiScale As Scale
        
        '<remarks/>
        Public ProjectionId As ProjectionType
        
        '<remarks/>
        Public ProjectionName As String
        
        '<remarks/>
        Public CopyrightNotice As String
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Enum Theme
        
        '<remarks/>
        Photo
        
        '<remarks/>
        Topo
        
        '<remarks/>
        Relief
    End Enum
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Enum Scale
        
        '<remarks/>
        Scale1mm
        
        '<remarks/>
        Scale2mm
        
        '<remarks/>
        Scale4mm
        
        '<remarks/>
        Scale8mm
        
        '<remarks/>
        Scale16mm
        
        '<remarks/>
        Scale32mm
        
        '<remarks/>
        Scale63mm
        
        '<remarks/>
        Scale125mm
        
        '<remarks/>
        Scale250mm
        
        '<remarks/>
        Scale500mm
        
        '<remarks/>
        Scale1m
        
        '<remarks/>
        Scale2m
        
        '<remarks/>
        Scale4m
        
        '<remarks/>
        Scale8m
        
        '<remarks/>
        Scale16m
        
        '<remarks/>
        Scale32m
        
        '<remarks/>
        Scale64m
        
        '<remarks/>
        Scale128m
        
        '<remarks/>
        Scale256m
        
        '<remarks/>
        Scale512m
        
        '<remarks/>
        Scale1km
        
        '<remarks/>
        Scale2km
        
        '<remarks/>
        Scale4km
        
        '<remarks/>
        Scale8km
        
        '<remarks/>
        Scale16km
    End Enum
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Enum ProjectionType
        
        '<remarks/>
        Geographic
        
        '<remarks/>
        UtmNad27
        
        '<remarks/>
        UtmNad83
    End Enum
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class PlaceFacts
        
        '<remarks/>
        Public Place As Place
        
        '<remarks/>
        Public Center As LonLatPt
        
        '<remarks/>
        Public AvailableThemeMask As Themes
        
        '<remarks/>
        Public PlaceTypeId As PlaceType
        
        '<remarks/>
        Public Population As Integer
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class Place
        
        '<remarks/>
        Public City As String
        
        '<remarks/>
        Public State As String
        
        '<remarks/>
        Public Country As String
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/"),  _
     System.FlagsAttribute()>  _
    Public Enum Themes
        
        '<remarks/>
        Photo = 1
        
        '<remarks/>
        Topo = 2
        
        '<remarks/>
        Relief = 4
    End Enum
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Enum PlaceType
        
        '<remarks/>
        UnknownPlaceType
        
        '<remarks/>
        AirRailStation
        
        '<remarks/>
        BayGulf
        
        '<remarks/>
        CapePeninsula
        
        '<remarks/>
        CityTown
        
        '<remarks/>
        HillMountain
        
        '<remarks/>
        Island
        
        '<remarks/>
        Lake
        
        '<remarks/>
        OtherLandFeature
        
        '<remarks/>
        OtherWaterFeature
        
        '<remarks/>
        ParkBeach
        
        '<remarks/>
        PointOfInterest
        
        '<remarks/>
        River
    End Enum
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class ThemeBoundingBox
        
        '<remarks/>
        Public Theme As Theme
        
        '<remarks/>
        Public ThemeName As String
        
        '<remarks/>
        Public Sparseness As Integer
        
        '<remarks/>
        Public LoScale As Scale
        
        '<remarks/>
        Public HiScale As Scale
        
        '<remarks/>
        Public ProjectionId As ProjectionType
        
        '<remarks/>
        Public ProjectionName As String
        
        '<remarks/>
        Public WestLongitude As Double
        
        '<remarks/>
        Public NorthLatitude As Double
        
        '<remarks/>
        Public EastLongitude As Double
        
        '<remarks/>
        Public SouthLatitude As Double
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class OverlappingThemeInfo
        
        '<remarks/>
        Public LocalTheme As Boolean
        
        '<remarks/>
        Public Theme As Theme
        
        '<remarks/>
        Public Point As LonLatPt
        
        '<remarks/>
        Public ThemeName As String
        
        '<remarks/>
        Public Capture As Date
        
        '<remarks/>
        Public ProjectionId As ProjectionType
        
        '<remarks/>
        Public LoScale As Scale
        
        '<remarks/>
        Public HiScale As Scale
        
        '<remarks/>
        Public Url As String
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class LonLatPtOffset
        
        '<remarks/>
        Public Point As LonLatPt
        
        '<remarks/>
        Public XOffset As Integer
        
        '<remarks/>
        Public YOffset As Integer
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class TileId
        
        '<remarks/>
        Public Theme As Theme
        
        '<remarks/>
        Public Scale As Scale
        
        '<remarks/>
        Public Scene As Integer
        
        '<remarks/>
        Public X As Integer
        
        '<remarks/>
        Public Y As Integer
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class TileMeta
        
        '<remarks/>
        Public Id As TileId
        
        '<remarks/>
        Public TileExists As Boolean
        
        '<remarks/>
        Public NorthWest As LonLatPt
        
        '<remarks/>
        Public NorthEast As LonLatPt
        
        '<remarks/>
        Public SouthWest As LonLatPt
        
        '<remarks/>
        Public SouthEast As LonLatPt
        
        '<remarks/>
        Public Center As LonLatPt
        
        '<remarks/>
        Public Capture As Date
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class AreaCoordinate
        
        '<remarks/>
        Public TileMeta As TileMeta
        
        '<remarks/>
        Public Offset As LonLatPtOffset
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class AreaBoundingBox
        
        '<remarks/>
        Public NorthWest As AreaCoordinate
        
        '<remarks/>
        Public NorthEast As AreaCoordinate
        
        '<remarks/>
        Public SouthWest As AreaCoordinate
        
        '<remarks/>
        Public SouthEast As AreaCoordinate
        
        '<remarks/>
        Public Center As AreaCoordinate
        
        '<remarks/>
        Public NearestPlace As String
        
        '<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=false)>  _
        Public OverlappingThemeInfos() As OverlappingThemeInfo
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://terraserver-usa.com/terraserver/")>  _
    Public Class UtmPt
        
        '<remarks/>
        Public Zone As Integer
        
        '<remarks/>
        Public X As Double
        
        '<remarks/>
        Public Y As Double
    End Class
End Namespace
