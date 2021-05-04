using System.Collections;

namespace Patterns.CSharp.Patterns.Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable pool = new Hashtable
        {
            { "1", new ConcreteFlyweightShared() },
            { "2", new ConcreteFlyweightShared() },
            { "3", new ConcreteFlyweightShared() }
        };

        public AbstractFlyweight GetFlyweight(string key)
        {
            if (!pool.ContainsKey(key))
            {
                pool.Add(key, new ConcreteFlyweightShared());
            }

            return pool[key] as AbstractFlyweight;
        }
    }
}