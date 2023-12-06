namespace ApiUniversity.Model;

public class Document
{
    public static int NextId = 0; // Compteur d'identifiant

    public int Id { get; set; } // identifiant unique
    public string Titre { get; set; } = null!; // titre du document
    public string Auteur { get; set; } = null!; // auteur du document
    public int Stock { get; set; } // stock total dans la médiathèque
    public int Emprunt { get; set; } // nombre de documents empruntés
    public List<Member> emprunteur { get; set; } = null!; // liste d’identifiants des emprunteurs

    // Default constructor
    public Document()
    {
        Id += NextId++;
    }

    // public Document(DocumentDTO documentDTO)
    // {
    //     Id = documentDTO.Id;
    //     LastName = documentDTO.LastName;
    //     FirstName = documentDTO.FirstName;
    // }
}
