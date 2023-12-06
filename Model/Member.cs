namespace ApiUniversity.Model;

public class Member
{
    public int Id { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;

    // Default constructor
    public Member() { }

    // public Member(MemberDTO memberDTO)
    // {
    //     Id = memberDTO.Id;
    //     LastName = memberDTO.LastName;
    //     FirstName = memberDTO.FirstName;
    // }
}
