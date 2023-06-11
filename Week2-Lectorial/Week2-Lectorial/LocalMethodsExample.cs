// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
namespace Week2_Lectorial;

public static class LocalMethodsExample
{
    private static void MainZ()
    {
        var set = new HashSet<int>(new[] { 1, 2, 4 });

        // Local method - can reduce code duplication without exposing additional methods and local methods can access
        // variables that are in-scope.
        // NOTE: Local methods can have parameters and a return type.
        void RunTest()
        {
            Console.WriteLine($"[ {string.Join(", ", set)} ]");
            for(var i = 0; i <= 5; i++)
            {
                Test(i);
            }
            Console.WriteLine();
        }

        // Local method.
        void Test(int value)
        {
            if(set.Contains(value))
                Console.WriteLine($"Value {value} is contained within the set.");
            else
                Console.WriteLine($"Value {value} is NOT contained within the set.");
        }

        RunTest();
        set.Add(3);
        RunTest();

        Console.WriteLine($"Set size {set.Count}");
        set.Add(1);
        set.Add(2);
        set.Add(4);
        set.Add(3);
        Console.WriteLine($"Set size {set.Count}");
        Console.WriteLine();

        RunTest();
        set.Remove(1);
        RunTest();
        set.Clear();
        RunTest();
    }
}
