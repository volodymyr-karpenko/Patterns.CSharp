using System.Collections;

namespace Patterns.CSharp.Patterns.Composite
{
    public class ConcreteComponentComposite : AbstractComponent
    {
        private ArrayList nodes = new ArrayList();

        public ConcreteComponentComposite(string name) : base(name)
        {
        }
        
        public override void Operation()
        {
            PatternUseCase.Output += name + "\r\n\r\n";

            foreach (AbstractComponent component in nodes)
            {
                component.Operation();
            }
        }

        public override void Add(AbstractComponent component)
        {
            nodes.Add(component);
        }

        public override void Remove(AbstractComponent component)
        {
            nodes.Remove(component);
        }

        public override AbstractComponent GetChild(int index)
        {
            return nodes[index] as AbstractComponent;
        }
    }
}