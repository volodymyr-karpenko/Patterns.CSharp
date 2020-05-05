namespace Patterns.CSharp.Patterns.Mediator
{
    public class ConcreteColleagueTwo : AbstractColleague
    {
        public ConcreteColleagueTwo(AbstractMediator mediator) : base(mediator)
        {
        }

        public void Send(string msg)
        {
            mediator.Send(msg, this);
        }

        public void Notify(string msg)
        {
            PatternUseCase.Output += "Notification from " + mediator.GetType().Name + ": " + msg + "\r\n\r\n";
        }
    }
}