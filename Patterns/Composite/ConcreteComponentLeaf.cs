using System;

namespace Patterns.CSharp.Patterns.Composite
{
    public class ConcreteComponentLeaf : AbstractComponent
    {
        public ConcreteComponentLeaf(string name) : base(name)
        {
        }
               
        public override void Operation()
        {
            PatternUseCase.Output += name + "\r\n\r\n";
        }

        public override void Add(AbstractComponent component)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(AbstractComponent component)
        {
            throw new InvalidOperationException();
        }

        public override AbstractComponent GetChild(int index)
        {
            throw new InvalidOperationException();
        }
    }
}