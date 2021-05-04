namespace Patterns.CSharp.Patterns.ChainOfResponsibility
{
    public class ConcreteHandlerTwo : AbstractHandler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
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