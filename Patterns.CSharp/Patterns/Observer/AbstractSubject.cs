using System.Collections;

namespace Patterns.CSharp.Patterns.Observer
{
    public abstract class AbstractSubject
    {
        private ArrayList observers = new ArrayList();
        public abstract string State { get; set; }

        public void Attach(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(AbstractObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (AbstractObserver item in observers)
            {
                item.Update(State);
            }
        }
    }
}