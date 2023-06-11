namespace Week2_Lectorial;

public static class EnumeratorDemo
{
    private static void MainZ()
    {
        IList<int> list = new List<int>();
        for(var i = 0; i < 10; i++)
            list.Add(i);

        // Use enumerator to access list.
        // ReSharper disable once GenericEnumeratorNotDisposed
        IEnumerator<int> etr = list.GetEnumerator();
        while(etr.MoveNext())
            Console.Write(etr.Current + " ");
        Console.WriteLine();

        // Use foreach to access list.
        foreach(var x in list)
            Console.Write(x + " ");
        Console.WriteLine();

        for(var i = 0; i < list.Count; i++)
            Console.Write(list[i] + " ");
        Console.WriteLine();
    }
}
