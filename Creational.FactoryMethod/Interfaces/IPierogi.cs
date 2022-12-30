using Creational.Factory.Model;

namespace Creational.Factory.Interfaces;

public interface IPierogi
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiType Type { get; set; }

    public string ToString();
}
