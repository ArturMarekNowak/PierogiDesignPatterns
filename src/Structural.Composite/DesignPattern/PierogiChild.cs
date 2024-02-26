namespace Structural.Composite.DesignPattern;

public class PierogiChild : IPierogiProducer
{
    public string Name { get; }

    public PierogiChild(string name)
    {
        Name = name;
    }

    public void DisplayPierogiProduced()
    {
        Console.WriteLine($"{Name} produced no pierogi :c");
    }
    
    public override string ToString()
    {
        return $"Child: {Name}";
    }
}