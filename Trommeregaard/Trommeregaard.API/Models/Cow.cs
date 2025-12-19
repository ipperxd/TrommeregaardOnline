namespace Trommeregaard.API.Models;
public class Cow
{
    public int Id { get; set; }
    public long TagId { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set;   }
    public string Breed { get; set; } = string.Empty;
    public bool IsPregnant { get; set; } = false;
    public bool Gender { get; set; }

}

public enum Breed
{
    Jersey = 0,
    Holstein = 1,
    Guernsey = 2,
    Ayrshire = 3,
    BrownSwiss = 4,
    MilkingShorthorn = 5
}
