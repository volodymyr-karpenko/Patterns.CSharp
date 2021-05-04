namespace Patterns.CSharp.Patterns.Mediator
{
    public class ConcreteColleagueOne : AbstractColleague
    {
        public ConcreteColleagueOne(AbstractMediator mediator) : base(mediator)
        {
        }

        public void Send(string msg)
        {
            mediator.Send(msg, this);
        }

        public override void Notify(string msg)
        {
            PatternUseCase.Output += "Notification from " + mediator.GetType().Name + ": " + msg + "\r\n\r\n";
        }
    }
}