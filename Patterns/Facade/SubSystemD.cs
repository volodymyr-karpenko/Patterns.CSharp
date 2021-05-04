namespace Patterns.CSharp.Patterns.Facade
{
    public class SubSystemD
    {
        public void OperationD()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationD) + "\r\n\r\n";
        }
    }
}