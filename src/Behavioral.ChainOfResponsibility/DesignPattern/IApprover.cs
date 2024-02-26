using Behavioral.ChainOfResponsibility.Model;

namespace Behavioral.ChainOfResponsibility.DesignPattern;

public interface IApprover
{
    void SetSuccessor(IApprover approver);
    void ProcessReviewRequest(Pierogi pierogi);
}