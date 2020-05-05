namespace Patterns.CSharp.Patterns.Facade
{
    public class SubSystemB
    {
        public void OperationB()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationB) + "\r\n\r\n";
        }
    }
}