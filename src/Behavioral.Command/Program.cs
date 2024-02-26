using Behavioral.Command.DesignPattern;

namespace Behavioral.Command
{
    public sealed class Program
    {
        static void Main()
        {
            var cook = new Cook();
            var owner = new Owner();
            var waitress = new Waitress();
            
            Console.WriteLine("Please, get me pierogi!");
            waitress.Serve(new BuyPierogi(cook));
            
            Console.WriteLine("It was delicious, please compliment the owner for this lovely evening :D");
            waitress.Serve(new Compliment(owner));
        }
    }
}