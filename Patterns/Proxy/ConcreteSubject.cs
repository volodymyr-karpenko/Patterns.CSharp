namespace Patterns.CSharp.Patterns.Proxy
{
    public class ConcreteSubject : AbstractSubject
    {
        public override void Request()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(Request) + "\r\n\r\n";
        }
    }
}