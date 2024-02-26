using Structural.Composite.Model;

namespace Structural.Composite.DesignPattern;

public class PierogiGrandma : IPierogiProducer
{
    public string Name { get; }
    public List<IPierogiProducer> ChildrenList = new();

    public PierogiGrandma(string name)
    {
        Name = name;
    }
    
    public void AddChild(IPierogiProducer child)
    {
        ChildrenList.Add(child);
    }
    
    public void RemoveChild(IPierogiProducer child)
    {
        ChildrenList.Remove(child);
    }
    
    public void DisplayChildren()
    {
        Console.WriteLine($"{Name}'s children:");
        foreach (var child in ChildrenList)
        {
            Console.WriteLine(child);
        }
    }
    
    public void DisplayPierogiProduced()
    {
        Console.WriteLine($"{Name} produced:");
        for (int i = 0; i < 200; i++)
        {
            var pierogi = new Pierogi(10, PierogiType.WithPotatoesAndCheese);
            Console.WriteLine(pierogi);
        }
    }
    
    public override string ToString()
    {
        return $"Grandma: {Name}";
    }
}