using Week2_Lectorial.Enums;
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression

namespace Week2_Lectorial;

public static class EnumsExample
{
    private static void Main()
    {
        // Enums used to help clarify a value's type / meaning and possible values.
        AnimalType a1 = AnimalType.Cat;
        Console.WriteLine(a1);

        // Can also use var.
        var a2 = AnimalType.Dog;
        Console.WriteLine(a2);

        Console.WriteLine();
        foreach(var x in Enum.GetValues<AnimalType>())
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();

        TestAnimal(a1);
        TestAnimal(a2);
        TestAnimal(AnimalType.Fish);

        var status = DeliveryStatus.AwaitingCollection;
        Console.WriteLine(status);
        Console.WriteLine();

        MultiHue h1 = MultiHue.None;
        MultiHue h2 = MultiHue.Blue;
        MultiHue h3 = MultiHue.Blue | MultiHue.Green | MultiHue.Red;

        Console.WriteLine(h1);
        Console.WriteLine(h2);
        Console.WriteLine(h3);
        Console.WriteLine();

        // Branching with flag testing.
        if(h3.HasFlag(MultiHue.Blue))
            Console.WriteLine("Blue is present.");
        if(!h3.HasFlag(MultiHue.Black))
            Console.WriteLine("Black is absent.");
    }

    private static void TestAnimal(AnimalType animalType)
    {
        // Branching on enum values.
        if(animalType == AnimalType.Cat)
            Console.WriteLine("It is a cat!");

        // Can also use a switch.
        switch(animalType)
        {
            case AnimalType.Cat:
                Console.WriteLine("Meow! It is a cat!");
                break;
            case AnimalType.Dog:
                Console.WriteLine("Bark! It is a dog!");
                break;
            default:
                Console.WriteLine("Sadly this animal is not a cat or a dog.");
                break;
        }

        Console.WriteLine();
    }
}
