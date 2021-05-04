namespace Patterns.CSharp.Patterns.Mediator
{
    public abstract class AbstractColleague
    {
        protected AbstractMediator mediator;

        public AbstractColleague(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Notify(string msg);
    }
}