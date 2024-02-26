using Behavioral.ChainOfResponsibility.Exceptions;
using Behavioral.ChainOfResponsibility.Model;

namespace Behavioral.ChainOfResponsibility.DesignPattern;

public class Owner : IApprover
{
    private IApprover _approver;
    
    public void SetSuccessor(IApprover approver)
    {
        _approver = approver;
    }

    public void ProcessReviewRequest(Pierogi pierogi)
    {
        if (pierogi.Type is not PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup)
        {
            Console.WriteLine("Aaaah yummy! I approve it :D");
            
            if (_approver is not null) 
                _approver.ProcessReviewRequest(pierogi);
            else
                Console.WriteLine($"Hurray {pierogi} were accepted :D");
        }
        else
        {
            throw new DisgustingMealException();
        }
    }
}