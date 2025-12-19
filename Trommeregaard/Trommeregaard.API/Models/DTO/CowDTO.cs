namespace Trommeregaard.API.Models.DTO;
public class CowDTO
{
    public long TagId { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
    public Breed Breed { get; set; } = 0;
    public bool IsPregnant { get; set; } = false;
    public bool Gender { get; set; }
}
