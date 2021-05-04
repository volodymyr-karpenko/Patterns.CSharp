namespace Patterns.CSharp.Patterns
{
    public abstract class PatternUseCase
    {
        public static string Output;

        public PatternUseCase()
        {
            Output = string.Empty;
        }

        public string GetOutput()
        {
            return Output;
        }
    }
}