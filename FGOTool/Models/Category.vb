

Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Category

        <ScaffoldColumn(False)>
        Public Property CategoryID As Integer

        <Required, StringLength(100), Display(Name:="Name")>
        Public Property CategoryName As String

        <Display(Name:="Product Description")>
        Public Property Description As String

        Public Overridable Property Servants As ICollection(Of Servant)
    End Class
End Namespace

