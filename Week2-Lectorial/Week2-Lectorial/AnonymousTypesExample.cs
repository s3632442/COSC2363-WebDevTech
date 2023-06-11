using Ex2_2;

namespace Week2_Lectorial;

public static class AnonymousTypesExample
{
    private static void MainZ()
    {
        // Anonymous type - need to use var.
        var person = new { Name = "Matthew", Age = 32 };

        Console.WriteLine($"{person.Name} is {person.Age} years old.");
        Console.WriteLine();

        // Can also use anonymous types in LINQ during conversion.
        var animals = new List<Animal>
        {
            new Dog(72, "Milo", "Golden"),
            new Cat(12, "Shakespeare"),
            new Cat(10, "Allegra"),
            new Dog(50, "Dingo", "mixed breed"),
            new Dog(20, "Brandy", "Beagle")
        };

        var data = animals.Select(animal => new { animal.Name, WeightInPounds = animal.Weight * 2.205 });

        foreach(var x in data)
        {
            Console.WriteLine($"{x.Name} is {x.WeightInPounds:F2} pounds.");
        }
    }
}
