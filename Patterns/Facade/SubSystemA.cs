namespace Patterns.CSharp.Patterns.Facade
{
    public class SubSystemA
    {
        public void OperationA()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationA) + "\r\n\r\n";
        }
    }
}