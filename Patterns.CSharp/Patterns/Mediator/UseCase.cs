namespace Patterns.CSharp.Patterns.Mediator
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleagueOne colleague1 = new ConcreteColleagueOne(mediator);
            ConcreteColleagueTwo colleague2 = new ConcreteColleagueTwo(mediator);
            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            colleague2.Send("IMPORTANT MESSAGE");
        }
    }
}