using Behavioral.Visitor.DesignPattern;
using Behavioral.Visitor.Model;

namespace Behavioral.Visitor.Interfaces;

public interface IPierogi
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiType Type { get; set; }

    public string ToString();
    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer);
}
