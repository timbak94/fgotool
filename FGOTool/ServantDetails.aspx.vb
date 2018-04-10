Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports FGOTool.Models
Imports System.Web.ModelBinding

Public Class ServantDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Function GetServant(<QueryString("servantID")> ByVal servantId As Integer?) As IQueryable(Of Servant)
        System.Diagnostics.Debug.WriteLine("Servant detail")

        Dim _db = New FGOTool.Models.ServantContext()
        Dim query As IQueryable(Of Servant) = _db.Servants
        If servantId.HasValue AndAlso servantId > 0 Then
            query = query.Where(Function(p) p.ServantID = servantId)
            System.Diagnostics.Debug.WriteLine("found")

        Else
            System.Diagnostics.Debug.WriteLine("nah")


            query = Nothing
        End If

        Return query
    End Function
End Class