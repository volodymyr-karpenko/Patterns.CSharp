namespace Patterns.CSharp.Patterns.Composite
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractComponent root = new ConcreteComponentComposite("Root");
            AbstractComponent branch1 = new ConcreteComponentComposite("Branch 1");
            AbstractComponent branch2 = new ConcreteComponentComposite("Branch 2");
            AbstractComponent leaf1 = new ConcreteComponentLeaf("Leaf 1");
            AbstractComponent leaf2 = new ConcreteComponentLeaf("Leaf 2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);

            root.Operation();
        }
    }
}