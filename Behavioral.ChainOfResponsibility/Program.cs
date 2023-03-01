using Behavioral.ChainOfResponsibility.DesignPattern;
using Behavioral.ChainOfResponsibility.Model;

namespace Behavioral.ChainOfResponsibility
{
    public sealed class Program
    {
        static void Main()
        {
            var waitress = new Waitress();
            var cook = new Cook();
            var owner = new Owner();
            
            waitress.SetSuccessor(cook);
            cook.SetSuccessor(owner);
            
            waitress.ProcessReviewRequest(new Pierogi(10, PierogiType.WithPotatoesAndCheese));
            waitress.ProcessReviewRequest(new Pierogi(10, PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup));
        }
    }
}