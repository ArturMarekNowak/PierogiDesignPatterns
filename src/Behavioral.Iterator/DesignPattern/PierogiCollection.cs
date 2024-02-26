using System.Collections;
using Behavioral.Iterator.Model;

namespace Behavioral.Iterator.DesignPattern;

public class PierogiCollection : IEnumerable<Pierogi>
{
    private Pierogi[] _pierogi;
    public PierogiCollection(Pierogi[] pierogi)
    {
        _pierogi = pierogi;
    }

    public IEnumerator<Pierogi> GetEnumerator()
    {
        return new PierogiEnumerator(_pierogi);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new PierogiEnumerator(_pierogi);
    }
}