namespace ConsoleApp.Patterns.Mediator
{
    public abstract class AbstractMediator
    {
        public abstract void Send(string msg, AbstractColleague colleague);
    }
}