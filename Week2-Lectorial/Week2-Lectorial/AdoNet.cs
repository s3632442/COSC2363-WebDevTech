using System.Data;
using Microsoft.Data.SqlClient;

namespace Week2_Lectorial;

public static class AdoNet
{
    // Connection string needs to be changed.
    // NOTE: You can either disable encryption with: Encrypt=False
    // OR
    // Trust the server's self-signed certificate with: TrustServerCertificate=True
    private const string ConnectionString =
        "server=rmit.australiaeast.cloudapp.azure.com;Encrypt=False;uid=demo_Log;database=demo_Log;pwd=abc123";
    //private const string ConnectionString =
    //    "server=rmit.australiaeast.cloudapp.azure.com;TrustServerCertificate=True;" +
    //    "uid=demo_Log;database=demo_Log;pwd=abc123";

    private static void MainZ()
    {
        DemonstrateConnectedAccess();

        Console.WriteLine(new string('-', 80));
        Console.WriteLine();

        DemonstrateDisconnectedAccess();

        Console.WriteLine(new string('-', 80));
        Console.WriteLine();

        //DemonstrateNonQuery();
    }

    private static void DemonstrateConnectedAccess()
    {
        using(var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            var command = new SqlCommand("select * from log", connection);
            using(var reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n",
                        reader["ip"], reader["time"], reader["request"], reader["status"], reader["size"]);
                }
            }
        }
    }

    private static void DemonstrateDisconnectedAccess()
    {
        // NOTE: Can use a using declaration instead of a using block.
        using var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "select * from log";

        var table = new DataTable();
        new SqlDataAdapter(command).Fill(table);

        foreach(var x in table.Select())
        {
            Console.WriteLine($"{x["ip"]}\n{x["time"]}\n{x["request"]}\n{x["status"]}\n{x["size"]}\n");
        }
    }

    private static void DemonstrateNonQuery()
    {
        using var connection = new SqlConnection(ConnectionString);
        connection.Open();

        // Updates the "Description" field in the "Status" table.
        var command = connection.CreateCommand();
        command.CommandText = "update Status set Description = 'Page Found' where Status = 200";

        var updates = command.ExecuteNonQuery();

        Console.WriteLine($"{updates} rows updated.\n");
    }
}
