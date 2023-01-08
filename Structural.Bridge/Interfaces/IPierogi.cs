using Structural.Bridge.Model;

namespace Structural.Bridge.Interfaces;

public interface IPierogi
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiType Type { get; set; }

    public string ToString();
}
