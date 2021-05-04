namespace Patterns.CSharp.Patterns.Prototype
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractPrototype prototype = new ConcretePrototypeOne(1);
            AbstractPrototype clone = prototype.Clone();

            PatternUseCase.Output += prototype.GetType().Name + " => Clone: " + clone.GetType().Name + " Id = " + clone.Id.ToString() + "\r\n\r\n";

            prototype = new ConcretePrototypeTwo(2);
            clone = prototype.Clone();

            PatternUseCase.Output += prototype.GetType().Name + " => Clone: " + clone.GetType().Name + " Id = " + clone.Id.ToString() + "\r\n\r\n";
        }
    }
}