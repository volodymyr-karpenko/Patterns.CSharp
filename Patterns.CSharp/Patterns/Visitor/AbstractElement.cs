namespace Patterns.CSharp.Patterns.Visitor
{
    public abstract class AbstractElement
    {
        public abstract void Accept(AbstractVisitor visitor);
    }
}