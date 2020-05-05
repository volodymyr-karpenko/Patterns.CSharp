namespace Patterns.CSharp.Patterns.Adapter
{
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}