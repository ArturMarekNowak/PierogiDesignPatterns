using Creational.FactoryMethod.Model;

namespace Creational.FactoryMethod.Interface;

public interface IPierogi
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiTypes Type { get; set; }

    public string ToString();
}
