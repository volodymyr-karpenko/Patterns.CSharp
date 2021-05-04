namespace Patterns.CSharp.Patterns.Visitor
{
    public class ConcreteElementTwo : AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitElementTwo(this);
        }

        public void OperationTwo()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationTwo) + "\r\n\r\n";
        }
    }
}