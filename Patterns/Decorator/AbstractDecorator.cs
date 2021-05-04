namespace Patterns.CSharp.Patterns.Decorator
{
    public abstract class AbstractDecorator : AbstractComponent
    {
        public AbstractComponent Component { protected get; set; }

        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }
}