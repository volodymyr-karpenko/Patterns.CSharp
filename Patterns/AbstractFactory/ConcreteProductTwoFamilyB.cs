namespace Patterns.CSharp.Patterns.AbstractFactory
{
    public class ConcreteProductTwoFamilyB : AbstractProductTwo
    {
        public override void Interact(AbstractProductOne productOne)
        {
            PatternUseCase.Output += GetType().Name + " " + nameof(Interact) + " " + productOne.GetType().Name + "\r\n\r\n";
        }
    }
}