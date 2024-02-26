using Structural.Decorator.Model;

namespace Structural.Decorator.Interfaces;

public interface IPierogi
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiType Type { get; set; }

    public string ToString();
}
