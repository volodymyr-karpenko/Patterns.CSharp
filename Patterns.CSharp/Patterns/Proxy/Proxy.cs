namespace Patterns.CSharp.Patterns.Proxy
{
    public class Proxy : AbstractSubject
    {
        private AbstractSubject subject;        

        public override void Request()
        {
            if (subject == null)
            {
                subject = new ConcreteSubject();
            }

            subject.Request();
        }
    }
}