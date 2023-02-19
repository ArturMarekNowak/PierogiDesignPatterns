using Behavioral.Iterator.DesignPattern;
using Behavioral.Iterator.Model;

namespace Behavioral.Iterator
{
    public class Program 
    {
        public static void Main()
        {
            Pierogi[] pierogiArray = { new(10, PierogiType.WithBlueberries), 
                                       new(10, PierogiType.WithCabbage) };

            var pierogiCollection = new PierogiCollection(pierogiArray);
           
            foreach (var pierog in pierogiCollection)
                Console.WriteLine(pierog);
        }
    }
}