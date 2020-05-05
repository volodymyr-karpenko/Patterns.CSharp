namespace Patterns.CSharp.Patterns.Bridge
{
    public abstract class Abstraction
    {
        protected AbstractImplementor implementor;

        public Abstraction(AbstractImplementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}