namespace Patterns.CSharp.Patterns.Visitor
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            ObjectStructure structure = new ObjectStructure();
            structure.Add(new ConcreteElementOne());
            structure.Add(new ConcreteElementTwo());
            structure.Accept(new ConcreteVisitorOne());
            structure.Accept(new ConcreteVisitorTwo());
        }
    }
}