namespace ConsoleApp.Patterns.Proxy
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractSubject subject = new Proxy();
            subject.Request();
        }
    }
}