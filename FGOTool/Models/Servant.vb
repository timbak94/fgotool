Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Servant


        <ScaffoldColumn(False)>
        Public Property ServantID As Integer

        <Required, StringLength(100), Display(Name:="Name")>
        Public Property ServantName As String

        <Required, StringLength(10000), Display(Name:="Servant Description"), DataType(DataType.MultilineText)>
        Public Property Description As String

        Public Property ImagePath As String

        <Display(Name:="ATK")>
        Public Property Attack As Integer

        <Display(Name:="HP")>
        Public Property Health As Integer

        <Display(Name:="Price")>
        Public Property UnitPrice As Double?

        Public Property CategoryID As Integer?

        Public Overridable Property Category As Category
    End Class
End Namespace