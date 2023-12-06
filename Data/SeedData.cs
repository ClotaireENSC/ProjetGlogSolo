using ApiProjet.Model;

namespace ApiProjet.Data;

public static class SeedData
{
    // Test data for part 1 and 2
    public static void Init()
    {
        using var context = new ProjetContext();
        // Look for existing content
        if (context.Members.Any())
        {
            return;   // DB already filled
        }

        // Add students
        Member carson = new()
        {
            FirstName = "Alexander",
            LastName = "Carson"
        };
        Member alonso = new()
        {
            FirstName = "Meredith",
            LastName = "Alonso"
        };
        Member anand = new()
        {
            FirstName = "Arturo",
            LastName = "Anand"
        };
        Member barzdukas = new()
        {
            FirstName = "Gytis",
            LastName = "Barzdukas"
        };
        context.Members.AddRange(
            carson,
            alonso,
            anand,
            barzdukas
        );

        // Commit changes into DB
        context.SaveChanges();
    }
}