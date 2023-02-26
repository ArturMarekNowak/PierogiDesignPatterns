using System.Linq.Expressions;
using Behavioral.Interpreter.Model;

namespace Behavioral.Interpreter.DesignPattern;

public class PierogiQueryInterpreter : IPierogiExpression
{
    public Func<Pierogi, bool> Interpret(string query)
    {
        return BuildExpression(query).Compile();
    }
 
    private Expression<Func<Pierogi, bool>> BuildExpression(string query)
    {
        var tokenizedQuery = query.Split(' ').ToList();

        if (tokenizedQuery.Count != 3) 
            throw new ArgumentException("Invalid number of tokens");
        
        var typeParameters = Expression.Parameter(typeof(Pierogi));
        var leftPartOfQuery = Expression.Property(typeParameters, tokenizedQuery[0]);
        var typeProperty = typeof(Pierogi).GetProperty(tokenizedQuery[0]).PropertyType;
        var rightPartOfQuery = Expression.Constant(Convert.ChangeType(tokenizedQuery[2], typeProperty));
        
        if (!Enum.TryParse(tokenizedQuery[1], out ExpressionType @operator)) 
            throw new ArgumentException("Invalid operator");
        
        return Expression.Lambda<Func<Pierogi, bool>>(Expression.MakeBinary(@operator, leftPartOfQuery, rightPartOfQuery), typeParameters);
    }
    
}