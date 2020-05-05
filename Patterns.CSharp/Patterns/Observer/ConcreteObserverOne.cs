namespace Patterns.CSharp.Patterns.Observer
{
    public class ConcreteObserverOne : AbstractObserver
    {
        private string observerState;
        private AbstractSubject subject;

        public ConcreteObserverOne(AbstractSubject subject)
        {
            this.subject = subject;
        }

        public override void Update(string state)
        {
            observerState = state;
            PatternUseCase.Output += GetType().Name + ": State of " + subject.GetType().Name + " is " + observerState + "\r\n\r\n";
        }
    }
}