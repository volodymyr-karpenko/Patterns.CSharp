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

        public override void Update()
        {
            observerState = subject.State;
            PatternUseCase.Output += GetType().Name + ": State of " + subject.GetType().Name + " is " + observerState + "\r\n\r\n";
        }
    }
}