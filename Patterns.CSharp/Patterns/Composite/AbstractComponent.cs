namespace Patterns.CSharp.Patterns.Composite
{
    public abstract class AbstractComponent
    {
        protected string name;

        public AbstractComponent(string name)
        {
            this.name = name;
        }

        public abstract void Operation();
        public abstract void Add(AbstractComponent component);
        public abstract void Remove(AbstractComponent component);
        public abstract AbstractComponent GetChild(int index);
    }
}