using Behavioral.Interpreter.Model;

namespace Behavioral.Interpreter.DesignPattern;

public interface IPierogiExpression
{
    Func<Pierogi, bool> Interpret(string expression);
}