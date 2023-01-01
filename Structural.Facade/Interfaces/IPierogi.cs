using Structural.Facade.Model;

namespace Structural.Facade.Interfaces;

public interface IPierogi
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiType Type { get; set; }

    public string ToString();
}
