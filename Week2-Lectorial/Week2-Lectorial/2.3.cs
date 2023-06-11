using System.Diagnostics.CodeAnalysis;

namespace Ex2_3;

public class Person
{
    // NOTE: You can also use init instead of set with required making the properties readonly.
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    // Purposely created two different constructors to demonstrate the required property behavior.
    public Person()
    { }
    
    // The SetsRequiredMembers attribute is needed to allow the use of this constructor without object-initialiser.
    [SetsRequiredMembers]
    public Person(string firstName, string lastName)
    {
        // If you forget to set the required FirstName and / or LastName properties you will get a compiler warning.
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString() => $"{FirstName} {LastName}";
}

public static class TestPerson
{
    private static void MainZ()
    {
        // This complies as all required properties are set using this constructor.
        var person = new Person("Matthew", "Bolger");
        Console.WriteLine(person);

        // This does not compile as the required properties are not set with this constructor and object-initialiser
        // was not used to set them.
        //person = new Person();

        // This compiles as all the required properties are set using object-initialiser.
        person = new Person
        {
            FirstName = "Matthew",
            LastName = "Bolger"
        };
        Console.WriteLine(person);

        // NOTE: As the properties have setter's they are mutable.
        // NOTE: If the properties used init instead of set then they would be readonly after object creation.
        person.FirstName = "Matt";
        Console.WriteLine(person);
    }
}
