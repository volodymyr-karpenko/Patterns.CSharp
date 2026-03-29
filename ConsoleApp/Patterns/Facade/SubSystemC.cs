namespace ConsoleApp.Patterns.Facade
{
    public class SubSystemC
    {
        public void OperationC()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationC) + "\r\n\r\n";
        }
    }
}