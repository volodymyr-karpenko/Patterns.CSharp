using System.Collections;

namespace Patterns.CSharp.Patterns.Iterator
{
    public class Enumerator : IEnumerator
    {
        private Enumerable EnumerableObject { get; set; }
        private int current = -1;

        public Enumerator(Enumerable enumerable)
        {
            EnumerableObject = enumerable;
        }

        public object Current => EnumerableObject[current];

        public bool MoveNext()
        {
            if (current < EnumerableObject.Count - 1)
            {
                current++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}