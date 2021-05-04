namespace Patterns.CSharp.Patterns.Visitor
{
    public abstract class AbstractVisitor
    {
        public abstract void VisitElementOne(ConcreteElementOne element);
        public abstract void VisitElementTwo(ConcreteElementTwo element);
    }
}