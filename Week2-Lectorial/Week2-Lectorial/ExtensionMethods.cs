using System.Text;

namespace ExtensionMethods;

public static class StringExtensions
{
    public static int ParseToInt32(this string s)
    {
        return int.Parse(s);
        //return Convert.ToInt32(s);
    }

    public static string MultipleBy(this string s, int x)
    {
        var output = new StringBuilder(s.Length * x + x);
        for(var i = 0; i < x; i++)
        {
            output.Append(s);
            output.Append(' ');
        }

        return output.ToString();
    }
}

public static class IntExtensions
{
    public static bool IsEven(this int i) => i % 2 == 0;
    public static bool IsOdd(this int i) => i % 2 == 1;
}

public static class GenericExtensions
{
    public static List<T> ScalarToList<T>(this T item) => new List<T>(1) { item };
}

public static class ExtensionMethods
{
    public static void MainZ()
    {
        const string s = "128";
        var i = s.ParseToInt32();

        Console.WriteLine(i);
        Console.WriteLine(s.MultipleBy(3));
    }
}
