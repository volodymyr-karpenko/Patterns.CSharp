namespace Patterns.CSharp.Patterns.Visitor
{
    public class ConcreteVisitorOne : AbstractVisitor
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