// ReSharper disable ConvertToUsingDeclaration
namespace Week2_Lectorial;

public static class UsingExample
{
    private static readonly string TestFilePath =
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Test.txt";

    private static void MainZ()
    {
        WithoutTryFinallyOrUsing();
        //TryFinally();
        //UsingScoped();
        //UsingDeclaration();
    }

    private static void WithoutTryFinallyOrUsing()
    {
        // StreamWriter implements IDisposable interface which exposes Dispose method.
        // The Dispose method is used with unmanaged resources and is used to clean-up the resource deterministically.
        StreamWriter writer = File.CreateText(TestFilePath);

        writer.WriteLine("Hello World");

        // Create an exception on purpose.
        //string s = null;
        //writer.WriteLine(s.Length);

        writer.WriteLine("Bye World");

        // Should call dispose - this line can accidentally forgotten OR if an exception occurs above it will not run.
        writer.Dispose();
    }

    private static void TryFinally()
    {
        StreamWriter writer = null;
        try
        {
            writer = File.CreateText(TestFilePath);

            writer.WriteLine("Hello World");

            // Create an exception on purpose.
            //string s = null;
            //writer.WriteLine(s.Length);

            writer.WriteLine("Bye World");
        }
        finally
        {
            // Careful calling Dispose as fp could be null and thus avoid causing a NullReferenceException.
            writer?.Dispose();
            // OR
            //if(writer != null)
            //    writer.Dispose();
        }
    }

    private static void UsingScoped()
    {
        // Using will automatically call Dispose when the scope is left - even if an exception occurs.
        using(var writer = File.CreateText(TestFilePath))
        {
            writer.WriteLine("Hello World");

            // Create an exception on purpose.
            //string s = null;
            //writer.WriteLine(s.Length);

            writer.WriteLine("Bye World");
        }
    }

    private static void UsingDeclaration()
    {
        // Using declaration (scope is implicit).
        using var writer = File.CreateText(TestFilePath);
        writer.WriteLine("Hello World");

        // Create an exception on purpose.
        //string s = null;
        //writer.WriteLine(s.Length);

        writer.WriteLine("Bye World");
    }
}
