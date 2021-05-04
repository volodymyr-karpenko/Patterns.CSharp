using System.Collections;

namespace Patterns.CSharp.Patterns.Visitor
{
    public class ObjectStructure
    {
        ArrayList elements = new ArrayList();

        public void Add(AbstractElement element)
        {
            elements.Add(element);
        }

        public void Remove(AbstractElement element)
        {
            elements.Remove(element);
        }

        public void Accept(AbstractVisitor visitor)
        {
            foreach (AbstractElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}