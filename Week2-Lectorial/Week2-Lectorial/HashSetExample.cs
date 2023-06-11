// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
namespace Week2_Lectorial;

public static class HashSetExample
{
    private static void MainZ()
    {
        // HashSet can be used to know if a value is present.
        ISet<int> set = new HashSet<int>(new[] { 1, 2, 4 });
        // OR
        //var set = new HashSet<int>(new[] { 1, 2, 4 });

        RunTest(set);

        // Can insert with Add method.
        set.Add(3);

        RunTest(set);

        Console.WriteLine($"Set size {set.Count}");
        set.Add(1); // Duplicates can be added - no effect.
        set.Add(2);
        set.Add(3);
        set.Add(4);
        Console.WriteLine($"Set size {set.Count}");
        Console.WriteLine();

        RunTest(set);

        // Can delete with Remove method.
        set.Remove(1);

        RunTest(set);

        // Can empty with Clear method.
        set.Clear();

        RunTest(set);
    }

    private static void RunTest(ISet<int> set)
    {
        Console.WriteLine($"[ {string.Join(", ", set)} ]");
        for(var i = 0; i <= 5; i++)
        {
            Test(set, i);
        }
        Console.WriteLine();
    }

    private static void Test(ISet<int> set, int value)
    {
        if(set.Contains(value))
            Console.WriteLine($"Value {value} is contained within the set.");
        else
            Console.WriteLine($"Value {value} is NOT contained within the set.");
    }
}
