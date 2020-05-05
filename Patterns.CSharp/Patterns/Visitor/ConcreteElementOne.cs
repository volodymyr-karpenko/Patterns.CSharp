namespace Patterns.CSharp.Patterns.Visitor
{
    public class ConcreteElementOne : AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitElementOne(this);
        }

        public void OperationOne()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationOne) + "\r\n\r\n";
        }
    }
}