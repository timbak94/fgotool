Imports System.Data.Entity

Namespace Models

    Public Class ServantContext
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Property Categories As DbSet(Of Category)

        Public Property Servants As DbSet(Of Servant)
    End Class
End Namespace
