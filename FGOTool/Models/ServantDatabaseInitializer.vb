Imports System.Collections.Generic
Imports System.Data.Entity

Namespace Models

    Public Class ServantDatabaseInitializer
        Inherits DropCreateDatabaseIfModelChanges(Of ServantContext)

        Protected Overrides Sub Seed(ByVal context As ServantContext)
            GetCategories().ForEach(Function(c) context.Categories.Add(c))
            GetServants().ForEach(Function(p) context.Servants.Add(p))
        End Sub

        Private Shared Function GetCategories() As List(Of Category)
            Dim categories = New List(Of Category) From {
                 New Category With {.CategoryID = 1, .CategoryName = "Saber"},
                 New Category With {.CategoryID = 2, .CategoryName = "Archer"},
                 New Category With {.CategoryID = 3, .CategoryName = "Lancer"},
                 New Category With {.CategoryID = 4, .CategoryName = "Caster"},
                 New Category With {.CategoryID = 5, .CategoryName = "Rider"},
                 New Category With {.CategoryID = 6, .CategoryName = "Assassin"},
                 New Category With {.CategoryID = 7, .CategoryName = "Berserker"},
                 New Category With {.CategoryID = 8, .CategoryName = "Other"}
                }

            Return categories
        End Function

        Private Shared Function GetServants() As List(Of Servant)
            Dim servants = New List(Of Servant) From {
                New Servant With {.ServantID = 1, .ServantName = "Artoria Pendragon", .Description = "King Arthur" & "Britain", .ImagePath = "carconvert.png", .Attack = 11221, .Health = 15150, .UnitPrice = 22.5, .CategoryID = 1},
                New Servant With {.ServantID = 2, .ServantName = "Arjuna", .Description = "A great hero from the ancient epic poem from India, Mahabharata.", .Attack = 12342, .Health = 13230, .ImagePath = "carearly.png", .UnitPrice = 15.95, .CategoryID = 2},
                New Servant With {.ServantID = 3, .ServantName = "Cu Chulainn", .Description = "A peerless great hero from the Celtic, Ulster mythology.", .Attack = 12805, .Health = 12210, .ImagePath = "carfast.png", .UnitPrice = 32.99, .CategoryID = 3},
                New Servant With {.ServantID = 4, .ServantName = "Shakespeare", .Description = "William Shakespeare is undoubtedly the most famous author in the world, and also an actor.", .Attack = 10598, .Health = 14259, .ImagePath = "carfaster.png", .UnitPrice = 8.95, .CategoryID = 4},
                New Servant With {.ServantID = 5, .ServantName = "Iskandar", .Description = "Alexander III in Persian, he is also known by the nickname of Twin-Horns King.", .Attack = 11560, .Health = 13219, .ImagePath = "carracer.png", .UnitPrice = 34.95, .CategoryID = 5},
                New Servant With {.ServantID = 6, .ServantName = "Fuuma Kotarou", .Description = "Fuuma Clan.", .Attack = 11761, .Health = 12696, .ImagePath = "planeace.png", .UnitPrice = 95, .CategoryID = 6},
                New Servant With {.ServantID = 7, .ServantName = "Heracles", .Description = "One of the great heroes from Greek mythology.", .ImagePath = "planeglider.png", .Attack = 12901, .Health = 12521, .UnitPrice = 4.95, .CategoryID = 7},
                New Servant With {.ServantID = 8, .ServantName = "Jeanne d'Arc", .Description = "The holy woman that saved France", .ImagePath = "planepaper.png", .Attack = 9593, .Health = 16500, .UnitPrice = 2.95, .CategoryID = 8},
                New Servant With {.ServantID = 9, .ServantName = "Siegfried", .Description = "With the holy sword Balmung in hand, the 'dragon slayer' who defeated the evil dragon Fafnir.", .Attack = 8181, .Health = 14165, .ImagePath = "planeprop.png", .UnitPrice = 32.95, .CategoryID = 1},
                New Servant With {.ServantID = 10, .ServantName = "Billy the Kid", .Description = "The Juvenile Rascal King, said to have killed 21 people by the time he was 21 years old..", .Attack = 9325, .Health = 12889, .ImagePath = "truckearly.png", .UnitPrice = 15, .CategoryID = 2},
                New Servant With {.ServantID = 11, .ServantName = "Leonidas", .Description = "The king of Sparta, the country that became root word of the term spartan training.", .Attack = 11375, .Health = 14825, .ImagePath = "truckfire.png", .UnitPrice = 26, .CategoryID = 3},
                New Servant With {.ServantID = 12, .ServantName = "Merlin", .Description = "The court mage, advisor and prophet that appears in Arthurian legends.", .Attack = 11781, .Health = 13825, .ImagePath = "truckbig.png", .UnitPrice = 29, .CategoryID = 4},
                New Servant With {.ServantID = 13, .ServantName = "Edward Teach", .Description = "The most famous great pirate in the world, a great scoundrel that determined the image of pirates.", .Attack = 11326, .Health = 12830, .ImagePath = "boatbig.png", .UnitPrice = 95, .CategoryID = 5},
                New Servant With {.ServantID = 14, .ServantName = "Semiramis", .Description = "The oldest known poisoner in the world, and Empress of the Assyrian Empire.", .Attack = 11107, .Health = 14553, .ImagePath = "boatpaper.png", .UnitPrice = 4.95, .CategoryID = 6},
                New Servant With {.ServantID = 15, .ServantName = "Sakata Kintoki", .Description = "The strongest mystery killer of the Heian Period.", .Attack = 13915, .Health = 12150, .ImagePath = "boatsail.png", .UnitPrice = 42.95, .CategoryID = 7},
                New Servant With {.ServantID = 16, .ServantName = "Jeanne d'Arc (Alter)", .Description = "An alternate reality where she scorns those who betrayed her", .Attack = 13244, .Health = 11761, .ImagePath = "rocket.png", .UnitPrice = 122.95, .CategoryID = 8}}
            Return servants
        End Function
    End Class
End Namespace
