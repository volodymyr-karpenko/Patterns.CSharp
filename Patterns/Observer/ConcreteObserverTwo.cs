﻿namespace Patterns.CSharp.Patterns.Observer
{
    public class ConcreteObserverTwo : AbstractObserver
    {
        private string observerState;
        private AbstractSubject subject;

        public ConcreteObserverTwo(AbstractSubject subject)
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