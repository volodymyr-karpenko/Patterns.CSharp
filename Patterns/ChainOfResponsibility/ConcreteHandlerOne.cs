namespace Patterns.CSharp.Patterns.ChainOfResponsibility
{
    public class ConcreteHandlerOne : AbstractHandler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                PatternUseCase.Output += GetType().Name + " => " + nameof(HandleRequest) + " " + request.ToString() + "\r\n\r\n";
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}