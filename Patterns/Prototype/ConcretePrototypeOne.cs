namespace Patterns.CSharp.Patterns.Prototype
{
    public class ConcretePrototypeOne : AbstractPrototype
    {
        public ConcretePrototypeOne(int id) : base(id)
        {
        }

        public override AbstractPrototype Clone()
        {            
            return new ConcretePrototypeOne(Id);
        }
    }
}