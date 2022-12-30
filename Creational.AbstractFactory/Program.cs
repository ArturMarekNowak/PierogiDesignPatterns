using Creational.AbstractFactory.DesignPattern;

namespace Creational.AbstractFactory;

sealed class Program
{
    public static void Main()
    {
        var cheapRestaurant = new PierogiCheapRestaurant();
        var expensiveRestaurant = new PierogiExpensiveRestaurant();
        Console.WriteLine("------CheapRestaurant------");
        Console.WriteLine(cheapRestaurant.CookPierogiWithCabbage());
        Console.WriteLine(cheapRestaurant.CookPierogiWithMeat());
        Console.WriteLine("------ExpensiveRestaurant------");
        Console.WriteLine(expensiveRestaurant.CookPierogiWithCabbage());
        Console.WriteLine(expensiveRestaurant.CookPierogiWithMeat());
    }
}