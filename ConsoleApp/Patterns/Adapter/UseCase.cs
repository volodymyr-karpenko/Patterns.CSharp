namespace ConsoleApp.Patterns.Adapter
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            ITarget target = new Adapter();
            target.Request();
        } 
    }
}