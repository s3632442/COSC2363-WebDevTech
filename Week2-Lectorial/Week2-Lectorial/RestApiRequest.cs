using Newtonsoft.Json;
using Week2_Lectorial.Models;

namespace Week2_Lectorial;

public static class RestApiRequest
{
    private static void MainZ()
    {
        const string Url = "https://coreteaching01.csit.rmit.edu.au/~e103884/wdt/services/example/";

        using var client = new HttpClient();
        var json = client.GetStringAsync(Url).Result;

        Console.WriteLine(json);

        // Convert JSON string to Person objects.
        var people = JsonConvert.DeserializeObject<List<Person>>(json, new JsonSerializerSettings
        {
            // See here for DateTime format string documentation:
            // https://learn.microsoft.com/en-au/dotnet/standard/base-types/custom-date-and-time-format-strings
            DateFormatString = "dd/MM/yyyy"
        });

        // ReSharper disable once PossibleNullReferenceException
        // Process objects, in this case just printing for demonstration purposes.
        foreach(var person in people)
        {
            Console.WriteLine($"Person ID: {person.PersonID}, Name: {person.FirstName} {person.LastName}");
            foreach(var pet in person.Pets)
            {
                Console.WriteLine($"\tName: {pet.Name}, Date Registered {pet.DateRegistered.ToShortDateString()}");
            }
            Console.WriteLine();
        }
    }
}
