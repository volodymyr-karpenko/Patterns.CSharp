namespace Patterns.CSharp.Patterns.Mediator
{
    public class ConcreteMediator : AbstractMediator
    {
        public ConcreteColleagueOne Colleague1 { get; set; }
        public ConcreteColleagueTwo Colleague2 { get; set; }

        public override void Send(string msg, AbstractColleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Notify(msg);
            }
            else
            {
                Colleague1.Notify(msg);
            }
        }
    }
}