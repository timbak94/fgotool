Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports FGOTool.Models
Imports System.Web.ModelBinding

Public Class ServantList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Function GetServants(<QueryString("id")> ByVal categoryId As Integer?) As IQueryable(Of Servant)

        Dim _db = New FGOTool.Models.ServantContext()
        Dim query As IQueryable(Of Servant) = _db.Servants
        If categoryId.HasValue AndAlso categoryId > 0 Then
            query = query.Where(Function(p) p.CategoryID = categoryId)
        End If

        Return query
    End Function
End Class