using System.Xml.Serialization;
using Behavioral.Visitor.DesignPattern;
using Behavioral.Visitor.Model;

namespace Behavioral.Visitor;

public class Program
{
    public static void Main()
    {
        var pierogiXmlSerializer = new PierogiXmlSerializer();
        var pierogiJsonSerializer = new PierogiJsonSerializer();
        var pierogiWithBlueberries = new PierogiWithBlueberries();
        pierogiXmlSerializer.SerializePierogiWithBlueberries(pierogiWithBlueberries);
        pierogiJsonSerializer.SerializePierogiWithBlueberries(pierogiWithBlueberries);
    }
}