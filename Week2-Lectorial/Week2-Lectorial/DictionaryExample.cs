// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
using Ex2_2;

namespace Week2_Lectorial;

public static class DictionaryExample
{
    private static void MainZ()
    {
        // Dictionary can be used with key-value pairs - lookup a key to get a value.
        IDictionary<int, Animal> dictionary = new Dictionary<int, Animal>();
        // OR
        //var dictionary = new Dictionary<int, Animal>();

        // Can insert with Add method or [ ] syntax.
        // The [ ] syntax will override the value if the key already exists.
        // The Add method will not override if the key already exists (will throw exception instead).
        dictionary[1] = new Dog(72, "Milo", "Golden");
        dictionary.Add(2, new Cat(12, "Shakespeare"));

        // Can lookup with [ ] syntax or ContainsKey and TryGetValue.
        // The [ ] will throw an exception if the key does not exist.
        Console.WriteLine(dictionary[1]);

        Test(dictionary);

        // Can delete with Remove method.
        dictionary.Remove(1);

        Test(dictionary);

        // Can empty with Clear method.
        dictionary.Clear();

        Test(dictionary);
    }

    private static void Test(IDictionary<int, Animal> dictionary)
    {
        TestWithContains(dictionary, 1);
        TestWithContains(dictionary, 2);
        TestWithContains(dictionary, 3);
        Console.WriteLine();

        TestWithTryGetValue(dictionary, 1);
        TestWithTryGetValue(dictionary, 2);
        TestWithTryGetValue(dictionary, 3);
        Console.WriteLine();
    }

    private static void TestWithContains(IDictionary<int, Animal> dictionary, int key)
    {
        if(dictionary.ContainsKey(key))
            Console.Write($"Key {key} exists: {dictionary[key]}");
        else
            Console.WriteLine($"Key {key} NOT found.");
    }

    private static void TestWithTryGetValue(IDictionary<int, Animal> dictionary, int key)
    {
        if(dictionary.TryGetValue(key, out var animal))
            Console.Write($"Key {key} exists: {animal}");
        else
            Console.WriteLine($"Key {key} NOT found.");

        // Another technique not using out var:
        //Animal animal;
        //if(dictionary.TryGetValue(key, out animal))
    }
}
