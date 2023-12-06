using ApiProjet.Model;

namespace ApiProjet.Data;

public static class SeedData
{
    // Test data for part 1 and 2
    public static void Init()
    {
        using var context = new ProjetContext();
        // Look for existing content
        if (context.Members.Any() || context.Documents.Any())
        {
            return;   // DB already filled
        }

        // Add members
        Member carson = new()
        {
            FirstName = "Alexander",
            LastName = "Carson",
            Email = "alexander.carson@gmail.com"
        };
        Member alonso = new()
        {
            FirstName = "Meredith",
            LastName = "Alonso",
            Email = "meredith.alonso@gmail.com"
        };
        Member anand = new()
        {
            FirstName = "Arturo",
            LastName = "Anand",
            Email = "arturo.anand@gmail.com"
        };
        Member barzdukas = new()
        {
            FirstName = "Gytis",
            LastName = "Barzdukas",
            Email = "gytis.barzdukas@gmail.com"
        };
        context.Members.AddRange(
            carson,
            alonso,
            anand,
            barzdukas
        );


        // Add documents
        Document annales_glog = new()
        {
            Titre = "TOUTES LES ANNALES de Génie Logiciel de l'ENSC ! (depuis 2003)",
            Auteur = "Anonymous",
            Stock = 3,
            Emprunt = 0
        };
        Document csharp_pln = new()
        {
            Titre = "Le C# pour les nuls !",
            Auteur = "Davis Stephen-Randy",
            Stock = 2,
            Emprunt = 0
        };
        Document shrek_4 = new()
        {
            Titre = "Shrek 4 : Il était une fin",
            Auteur = "Mike Mitchell",
            Stock = 4,
            Emprunt = 0
        };
        Document garcon_luther = new()
        {
            Titre = "GARÇON - Album",
            Auteur = "Luther",
            Stock = 1,
            Emprunt = 0
        };

        context.Documents.AddRange(
            annales_glog,
            csharp_pln,
            shrek_4,
            garcon_luther
        );

        // Commit changes into DB
        context.SaveChanges();
    }
}