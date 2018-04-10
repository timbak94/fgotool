Imports System.Web.Optimization
Imports System.Data.Entity
Imports FGOTool.Models



Public Class Global_asax
    Inherits HttpApplication

    Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        Database.SetInitializer(New ServantDatabaseInitializer())
    End Sub
End Class
