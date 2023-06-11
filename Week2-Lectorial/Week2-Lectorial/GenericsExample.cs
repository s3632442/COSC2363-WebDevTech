using Generics;

namespace Week2_Lectorial;

public static class GenericsExample
{
    private static void MainZ()
    {
        // Using a generic method.
        int[] a = new int[] { 1, 5, 8, 9, 11, 14, 20 };
        Console.WriteLine(IsContainedIn(5, a));
        Console.WriteLine(IsContainedIn(14, a));
        Console.WriteLine(IsContainedIn(12, a));

        // Using a generic method which has a generic return type.
        //int i = 5;
        //List<int> a = ScalarToList(i);

        // Using a generic method and generic type together.
        //for(var i = 0; i < 50; i++)
        //{
        //    try
        //    {
        //        var r = GetRandomValue();
        //        Console.WriteLine(r);
        //    }
        //    catch(InvalidOperationException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    // OR.
        //    //var result = ExecuteWithTryCatch(GetRandomValue);

        //    //if(result.HasReturnValue)
        //    //    Console.WriteLine(result.ReturnValue);
        //    //else
        //    //    Console.WriteLine(result.Exception.Message);
        //}

        // Extension method example.
        //List<int> b = i.ScalarToList();
    }

    private static int GetRandomValue()
    {
        var r = Random.Shared.Next();

        // OR
        // if(r.IsEven())
        if(r % 2 == 0)
            throw new InvalidOperationException($"r is {r} and I don't like even numbers.");

        return r;
    }

    // Generic methods.
    public static bool IsContainedIn<T>(T item, params T[] values) => values.Contains(item);
    public static List<T> ScalarToList<T>(T item) => new List<T>(1) { item };

    // Generic method using a generic type.
    public static Result<T> ExecuteWithTryCatch<T>(Func<T> func)
    {
        try
        {
            return new Result<T>(func());
        }
        catch(Exception e)
        {
            return new Result<T>(e);
        }
    }
}
