using Behavioral.Mediator.DesignPattern;

namespace Behavioral.Mediator
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var pierogiWithPotatoesAndCheeseGentleman = new PierogiWithPotatoesAndCheeseGentleman();
            var pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman = new PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman();

            var pierogiMediator = new PierogiMediator(pierogiWithPotatoesAndCheeseGentleman, pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman);
            
            pierogiWithPotatoesAndCheeseGentleman.Send($"How are your pierogi? Mine are delicious!!! They are {pierogiWithPotatoesAndCheeseGentleman.Pierogi}");
            pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman.Send($"They are disgusting. They are {pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman.Pierogi}");
        }
    }
}