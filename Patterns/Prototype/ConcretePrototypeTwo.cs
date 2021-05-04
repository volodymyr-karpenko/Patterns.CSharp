namespace Patterns.CSharp.Patterns.Prototype
{
    public class ConcretePrototypeTwo : AbstractPrototype
    {
        public ConcretePrototypeTwo(int id) : base(id)
        {
        }

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototypeTwo(Id);
        }
    }
}