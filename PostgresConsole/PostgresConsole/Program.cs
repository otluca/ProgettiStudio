using Npgsql;
using PostgresConsole;


//var connectionString = "Host=localhost;Username=postgres;Password=03481964;Database=TestDatabase";

//try
//{
//    await using var dataSource = NpgsqlDataSource.Create(connectionString);

//    await using (var cmd = dataSource.CreateCommand("SELECT testdata FROM tabletest"))
//    await using (var reader = await cmd.ExecuteReaderAsync())
//    {
//        while (await reader.ReadAsync())
//        {
//            Console.WriteLine(reader.GetString(0));
//        }
//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

Console.WriteLine("Lettura da Postgres...");

try
{
    using (var ctx = new TestContext())
    {
        foreach (var item in ctx.TableTests)
        {
            Console.WriteLine(item.ToJson());
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}


Console.WriteLine("Scrittura in  Postgres...");

//try
//{
//    using (var ctx = new TestContext())
//    {
//        int progressivo = (new Random()).Next(10, 1000);


//        var newItem = new TableTest
//        {
//            TestClass = progressivo,
//            TestData = $"Dato aggiunto da applicazione {progressivo}",
//            TestDescription = $"Descrizione da applicazione {progressivo}"
//        };

//        ctx.TableTests.Add(newItem);
//        ctx.SaveChanges();
//        Console.WriteLine($"Aggiunto record con ID {newItem.IdTableTest} ");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

Console.WriteLine("A go finio!!!");

