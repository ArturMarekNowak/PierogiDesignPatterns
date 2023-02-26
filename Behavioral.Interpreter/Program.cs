using Behavioral.Interpreter.Extensions;
using Behavioral.Interpreter.Model;

public static class Program
{
    public static void Main()
    {
        var pierogiDatabase = new List<Pierogi>
        {
            new(10, PierogiType.WithBlueberries),
            new(20, PierogiType.WithBlueberries),
            new(30, PierogiType.WithBlueberries),
            new(40, PierogiType.WithBlueberries),
            new(40, PierogiType.WithBlueberries),
            new(50, PierogiType.WithBlueberries),
            new(60, PierogiType.WithBlueberries),
            new(70, PierogiType.WithBlueberries),
            new(80, PierogiType.WithBlueberries),
            new(90, PierogiType.WithBlueberries),
            new(100, PierogiType.WithBlueberries)
        };

        var queryOne = "Count GreaterThan 50";

        var queryResult = pierogiDatabase.RunCustomQuery(queryOne);

        foreach (var pierogi in queryResult)
        {
            Console.WriteLine(pierogi);
        }
    }
}