namespace Week2_Lectorial.Models;

public class Person
{
    public int PersonID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Pet> Pets { get; set; }
}
