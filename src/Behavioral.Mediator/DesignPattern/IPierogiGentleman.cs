using Behavioral.Mediator.Model;

namespace Behavioral.Mediator.DesignPattern;

public interface IPierogiGentleman
{
    public IPierogiMediator PierogiMediator { set; }
    public Pierogi Pierogi { get; set; }
}