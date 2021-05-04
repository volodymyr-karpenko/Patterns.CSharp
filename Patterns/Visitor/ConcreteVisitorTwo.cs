namespace Patterns.CSharp.Patterns.Visitor
{
    public class ConcreteVisitorTwo : AbstractVisitor
    {
        public override void VisitElementOne(ConcreteElementOne element)
        {
            element.OperationOne();
        }

        public override void VisitElementTwo(ConcreteElementTwo element)
        {
            element.OperationTwo();
        }
    }
}