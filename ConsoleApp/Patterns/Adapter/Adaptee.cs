namespace ConsoleApp.Patterns.Adapter
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(SpecificRequest) + "\r\n\r\n";
        }
    }
}