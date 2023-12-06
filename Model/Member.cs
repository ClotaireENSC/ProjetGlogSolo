namespace ApiProjet.Model;

public class Member
{
    public static int NextId = 0; // Compteur d'identifiant

    public int Id { get; set; } // identifiant unique
    public string LastName { get; set; } = null!; // Nom de famille
    public string FirstName { get; set; } = null!; // Prénom
    public string Email { get; set; } = null!; // Email

    // Default constructor
    public Member() { }

    // public Member(MemberDTO memberDTO)
    // {
    //     Id = memberDTO.Id;
    //     LastName = memberDTO.LastName;
    //     FirstName = memberDTO.FirstName;
    // }
}
