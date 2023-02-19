using System.Collections;
using Behavioral.Iterator.Model;

namespace Behavioral.Iterator.DesignPattern;

public class PierogiEnumerator : IEnumerator<Pierogi>
{
    private Pierogi[] _pierogi;
    private int _position = -1;

    public Pierogi Current
    {
        get
        {
            try
            {
                return _pierogi[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current => Current;

    public PierogiEnumerator(Pierogi[] pierogi)
    {
        _pierogi = pierogi;
    }
            
    public bool MoveNext()
    {
        _position++;
        return _position < _pierogi.Length;
    }

    public void Reset()
    {
        _position = -1;
    }

    public void Dispose()
    {
        _pierogi = null;
    }
}