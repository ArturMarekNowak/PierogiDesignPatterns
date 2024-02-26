using Behavioral.Interpreter.DesignPattern;
using Behavioral.Interpreter.Model;

namespace Behavioral.Interpreter.Extensions;

public static class PierogiListExtensions
{
    public static IEnumerable<Pierogi> RunCustomQuery(this IEnumerable<Pierogi> pierogiList, string query)
    {
        var pierogiInterpreter = new PierogiQueryInterpreter();
        return pierogiList.Where(p => pierogiInterpreter.Interpret(query)(p));
    }
}