namespace Patterns.CSharp.Patterns.Prototype
{
    public abstract class AbstractPrototype
    {
        public int Id { get; private set; }

        public AbstractPrototype(int id)
        {
            Id = id;
        }

        public abstract AbstractPrototype Clone();
    }
}