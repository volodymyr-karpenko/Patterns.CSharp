namespace Patterns.CSharp.Patterns.TemplateMethod
{
    public class ConcreteProductOne : AbstractProduct
    {
        public override void CreatePartOne()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(CreatePartOne) + "\r\n\r\n";
        }

        public override void CreatePartTwo()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(CreatePartTwo) + "\r\n\r\n";
        }
    }
}